Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class RequestThread
	Dim TargetEndpoint As IPEndPoint
	Dim Payload As Byte()
	Dim MainFormRef As MainForm
	Dim UpdateItem As ListViewItem

	Dim WorkerThread As Thread

	Public Sub New(ByVal targetEnd As IPEndPoint, ByVal payload As String, ByVal MainFormRef As MainForm, Optional ByVal updateItem As ListViewItem = Nothing)
		Me.TargetEndpoint = targetEnd
		Me.Payload = System.Text.Encoding.UTF8.GetBytes(payload)
		Me.MainFormRef = MainFormRef
		Me.UpdateItem = updateItem
		WorkerThread = New Thread(AddressOf Actions)
		WorkerThread.Start()
	End Sub

	Public Sub Actions()
		' Connect
		Dim tcp As New TcpClient
		Try
			tcp.Connect(TargetEndpoint)
		Catch ex As Exception
			Me.MainFormRef.ResponseError(UpdateItem, "(connect error)" + ControlChars.CrLf + ex.Message)
			Me.MainFormRef.IncreaseCompleted()
			Return
		End Try
		' Upload
		Dim netstream As NetworkStream = tcp.GetStream()
		netstream.Write(Payload, 0, Payload.Length)
		' Download
		Me.MainFormRef.DownloadingPhase(UpdateItem)
		tcp.ReceiveBufferSize = 1048576
		Dim recv(tcp.ReceiveBufferSize) As Byte
		netstream.Read(recv, 0, CInt(tcp.ReceiveBufferSize))
		Dim out As String
		out = System.Text.Encoding.UTF8.GetString(recv)
		Me.MainFormRef.ResponseReceived(UpdateItem, out)
		Me.MainFormRef.IncreaseCompleted()
	End Sub
End Class
