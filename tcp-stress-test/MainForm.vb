Public Class MainForm

	' Completion counter
	Dim completed As Long = 0
	Dim started As Long = 0

	Private Sub UpdateCounter()
		tsslRequestCounter.Text = String.Format("{0} / {1}", completed, started)
	End Sub

	Private Delegate Sub IncreaseCompletedDelegate()
	Public Sub IncreaseCompleted()
		If Me.InvokeRequired Then
			Me.BeginInvoke(New IncreaseCompletedDelegate(AddressOf IncreaseCompleted))
		Else
			completed += 1
			UpdateCounter()
		End If
	End Sub

	Private Function IncreaseStarted() As Long
		started += 1
		UpdateCounter()
		Return started
	End Function

	' Request handlers
	Dim CurrentTarget As Net.IPEndPoint

	Private Function CheckTarget() As Boolean
		Try
			CurrentTarget = New Net.IPEndPoint(Net.IPAddress.Parse(txtTarget.Text), CInt(numPort.Value))
			Return True
		Catch ex As Exception
			MessageBoxError(ex.Message, "IP Creation Failed")
			CurrentTarget = Nothing
			Return False
		End Try
	End Function

	Private Sub SendRequest()
		Dim lvi As New ListViewItem(New String() {IncreaseStarted().ToString, "-", "?", "?", "?"})
		lvi.ImageIndex = StatusImages.UPLOAD
		lvi.Tag = New RequestThread(CurrentTarget, txtPayload.Text, Me, lvi)
		lvResponses.Items.Add(lvi)
	End Sub

	Private Delegate Sub DownloadingPhaseDelegate(ByVal lvi As ListViewItem)
	Public Sub DownloadingPhase(ByVal lvi As ListViewItem)
		If Me.lvResponses.InvokeRequired Then
			Me.lvResponses.BeginInvoke(New DownloadingPhaseDelegate(AddressOf DownloadingPhase), lvi)
		Else
			lvi.ImageIndex = StatusImages.DOWNLOAD
		End If
	End Sub

	Private Delegate Sub ResponseReceivedDelegate(ByVal lvi As ListViewItem, ByVal out As String)
	Public Sub ResponseReceived(ByVal lvi As ListViewItem, ByVal out As String)
		If Me.lvResponses.InvokeRequired Then
			Me.lvResponses.BeginInvoke(New ResponseReceivedDelegate(AddressOf ResponseReceived), lvi, out)
		Else
			Dim headerOffset As Integer = out.IndexOf(ControlChars.CrLf + ControlChars.CrLf)
			If out.Substring(0, 4) = "HTTP" AndAlso headerOffset >= 0 Then
				Dim code As Integer = 200
				Select Case code
					Case 200
						lvi.ImageIndex = StatusImages.CODE200
					Case 301
						lvi.ImageIndex = StatusImages.CODE301
					Case 302
						lvi.ImageIndex = StatusImages.CODE302
					Case 304
						lvi.ImageIndex = StatusImages.CODE304
					Case 401
						lvi.ImageIndex = StatusImages.CODE401
					Case 403
						lvi.ImageIndex = StatusImages.CODE403
					Case 404
						lvi.ImageIndex = StatusImages.CODE404
					Case 500 To 599
						lvi.ImageIndex = StatusImages.CODE5XX
					Case Else
						lvi.ImageIndex = StatusImages.UNKNOWN
				End Select
				lvi.SubItems(1).Text = code.ToString
				lvi.SubItems(2).Text = (out.Length - headerOffset - 4).ToString
				lvi.SubItems(3).Text = headerOffset.ToString
			Else
				lvi.ImageIndex = StatusImages.NONHTTP
				lvi.SubItems(1).Text = "???"
				lvi.SubItems(2).Text = "-"
				lvi.SubItems(3).Text = "-"
			End If
			lvi.SubItems(4).Text = out.Length.ToString
			lvi.Tag = out
			lvResponses_SelectedIndexChanged(Me, New EventArgs)
		End If
	End Sub

	Private Delegate Sub ResponseErrorDelegate(ByVal lvi As ListViewItem, ByVal message As String)
	Public Sub ResponseError(ByVal lvi As ListViewItem, ByVal message As String)
		If Me.lvResponses.InvokeRequired Then
			Me.lvResponses.BeginInvoke(New ResponseErrorDelegate(AddressOf ResponseError), lvi, message)
		Else
			lvi.ImageIndex = StatusImages.FAILURE
			lvi.SubItems(1).Text = "FAIL"
			lvi.SubItems(2).Text = "-"
			lvi.SubItems(3).Text = "-"
			lvi.SubItems(4).Text = "-"
			lvi.Tag = message
			lvResponses_SelectedIndexChanged(Me, New EventArgs)
		End If
	End Sub

	Public Sub MessageBoxError(ByVal message As String, Optional ByVal caption As String = "Error")
		MessageBox.Show(message, caption, MessageBoxButtons.OK, MessageBoxIcon.Error)
	End Sub

	' Change payload size
	Private Function GetPayloadSize() As Integer
		Return txtPayload.Text.Length
	End Function

	Private Sub UpdateUpstreamBandwidth(ByVal length As Integer)
		Dim speed As Decimal = length * numQueueCount.Value / Math.Max(1, numQueueDelay.Value) * 1000
		Dim prefixes As String() = New String() {"", "kibi", "mibi", "gibi"}
		Dim prefix As Integer = 0
		While prefix + 1 < prefixes.Length AndAlso speed >= 1024
			prefix += 1
			speed /= 1024
		End While
		lblUpstream.Text = String.Format("Upstream bandwidth: {0} {1}byte/s", Math.Round(speed, 3).ToString, prefixes(prefix))
	End Sub

	' Buttons
	Private Sub btnResolve_Click(sender As Object, e As EventArgs) Handles btnResolve.Click
		Try
			Dim host As Net.IPHostEntry = Net.Dns.GetHostEntry(txtTarget.Text)
			If host.AddressList.Length < 1 Then
				Throw New Exception("Resolve failed")
			End If
			txtTarget.Text = host.AddressList(0).ToString()
		Catch ex As System.Net.Sockets.SocketException
			MessageBoxError(ex.Message, "Resolve Error")
		Catch ex As System.Exception
			MessageBoxError(ex.Message, "Error while Resolving")
		End Try
	End Sub

	Private Sub btnOneRequest_Click(sender As Object, e As EventArgs) Handles btnOneRequest.Click
		If CheckTarget() Then
			SendRequest()
		End If
	End Sub

	Private Sub btnEnqueue_Click(sender As Object, e As EventArgs) Handles btnEnqueue.Click
		If CheckTarget() Then
			For i As Integer = 1 To CInt(numQueueCount.Value)
				SendRequest()
			Next
		End If
	End Sub

	' Queue tick
	Private Sub tmrQueue_Tick(sender As Object, e As EventArgs) Handles tmrQueue.Tick
		For i As Integer = 1 To CInt(numQueueCount.Value)
			SendRequest()
		Next
	End Sub

	Private Sub btnToggleAttack_CheckedChanged(sender As Object, e As EventArgs) Handles btnToggleAttack.CheckedChanged
		' Check if the endpoint is valid
		If btnToggleAttack.Checked AndAlso Not CheckTarget() Then
			btnToggleAttack.Checked = False
		End If
		tmrQueue.Enabled = btnToggleAttack.Checked
	End Sub

	' Payload changes
	Private Sub txtPayload_TextChanged(sender As Object, e As EventArgs) Handles txtPayload.TextChanged
		Dim length As Integer = GetPayloadSize()
		If length = 0 Then
			lblPayloadSize.Text = "Payload Size: (empty)"
		ElseIf length = 1 Then
			lblPayloadSize.Text = "Payload Size: a byte"
		Else
			lblPayloadSize.Text = "Payload Size: " + length.ToString + " bytes"
		End If
		UpdateUpstreamBandwidth(length)
	End Sub

	Private Sub numQueueCount_ValueChanged(sender As Object, e As EventArgs) Handles numQueueCount.ValueChanged
		UpdateUpstreamBandwidth(GetPayloadSize())
	End Sub

	Private Sub numQueueDelay_ValueChanged(sender As Object, e As EventArgs) Handles numQueueDelay.ValueChanged
		tmrQueue.Interval = CInt(numQueueDelay.Value)
		UpdateUpstreamBandwidth(GetPayloadSize())
	End Sub

	' Change response selection, or the response text has changed
	Private Sub lvResponses_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvResponses.SelectedIndexChanged
		If lvResponses.SelectedIndices.Count = 1 Then
			Try
				Dim SelectedResponseItem As ListViewItem = lvResponses.SelectedItems(0)
				If Not lvResponses.Tag Is SelectedResponseItem Then
					' Try to use the tag as a string (could be RequestThread)
					txtResponsesRaw.Text = CStr(SelectedResponseItem.Tag)
					' If it fails, it will not be set
					lvResponses.Tag = SelectedResponseItem
				End If
			Catch ex As Exception
				txtResponsesRaw.Text = ""
			End Try
		ElseIf lvResponses.SelectedIndices.Count = 0 Then
			txtResponsesRaw.Text = "Select a response"
			lvResponses.Tag = Nothing
		Else
			txtResponsesRaw.Text = "Multiple responses are selected"
			lvResponses.Tag = Nothing
		End If
	End Sub
End Class
