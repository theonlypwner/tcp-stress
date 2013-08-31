<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		Me.components = New System.ComponentModel.Container()
		Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
		Me.tcMain = New System.Windows.Forms.TabControl()
		Me.tpPayload = New System.Windows.Forms.TabPage()
		Me.lblPayloadSize = New System.Windows.Forms.Label()
		Me.txtPayload = New System.Windows.Forms.TextBox()
		Me.tpResponse = New System.Windows.Forms.TabPage()
		Me.scResp = New System.Windows.Forms.SplitContainer()
		Me.lvResponses = New System.Windows.Forms.ListView()
		Me.chNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chResult = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chBody = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chHead = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.chTotal = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
		Me.ilResponses = New System.Windows.Forms.ImageList(Me.components)
		Me.tcResponses = New System.Windows.Forms.TabControl()
		Me.tpResponsesRaw = New System.Windows.Forms.TabPage()
		Me.txtResponsesRaw = New System.Windows.Forms.TextBox()
		Me.tpSettings = New System.Windows.Forms.TabPage()
		Me.lblUpstream = New System.Windows.Forms.Label()
		Me.numQueueCount = New System.Windows.Forms.NumericUpDown()
		Me.numQueueDelay = New System.Windows.Forms.NumericUpDown()
		Me.lblQueueCount = New System.Windows.Forms.Label()
		Me.lblQueueDelay = New System.Windows.Forms.Label()
		Me.ssStatus = New System.Windows.Forms.StatusStrip()
		Me.tsslRequests = New System.Windows.Forms.ToolStripStatusLabel()
		Me.tsslRequestCounter = New System.Windows.Forms.ToolStripStatusLabel()
		Me.lblTarget = New System.Windows.Forms.Label()
		Me.txtTarget = New System.Windows.Forms.TextBox()
		Me.numPort = New System.Windows.Forms.NumericUpDown()
		Me.lblPort = New System.Windows.Forms.Label()
		Me.btnToggleAttack = New System.Windows.Forms.CheckBox()
		Me.tmrQueue = New System.Windows.Forms.Timer(Me.components)
		Me.btnOneRequest = New System.Windows.Forms.Button()
		Me.btnResolve = New System.Windows.Forms.Button()
		Me.btnEnqueue = New System.Windows.Forms.Button()
		Me.tcMain.SuspendLayout()
		Me.tpPayload.SuspendLayout()
		Me.tpResponse.SuspendLayout()
		Me.scResp.Panel1.SuspendLayout()
		Me.scResp.Panel2.SuspendLayout()
		Me.scResp.SuspendLayout()
		Me.tcResponses.SuspendLayout()
		Me.tpResponsesRaw.SuspendLayout()
		Me.tpSettings.SuspendLayout()
		CType(Me.numQueueCount, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.numQueueDelay, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.ssStatus.SuspendLayout()
		CType(Me.numPort, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.SuspendLayout()
		'
		'tcMain
		'
		Me.tcMain.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.tcMain.Controls.Add(Me.tpPayload)
		Me.tcMain.Controls.Add(Me.tpResponse)
		Me.tcMain.Controls.Add(Me.tpSettings)
		Me.tcMain.Location = New System.Drawing.Point(12, 34)
		Me.tcMain.Name = "tcMain"
		Me.tcMain.SelectedIndex = 0
		Me.tcMain.Size = New System.Drawing.Size(564, 297)
		Me.tcMain.TabIndex = 0
		'
		'tpPayload
		'
		Me.tpPayload.Controls.Add(Me.lblPayloadSize)
		Me.tpPayload.Controls.Add(Me.txtPayload)
		Me.tpPayload.Location = New System.Drawing.Point(4, 22)
		Me.tpPayload.Name = "tpPayload"
		Me.tpPayload.Padding = New System.Windows.Forms.Padding(3)
		Me.tpPayload.Size = New System.Drawing.Size(556, 271)
		Me.tpPayload.TabIndex = 0
		Me.tpPayload.Text = "Payload"
		Me.tpPayload.UseVisualStyleBackColor = True
		'
		'lblPayloadSize
		'
		Me.lblPayloadSize.AutoSize = True
		Me.lblPayloadSize.Location = New System.Drawing.Point(6, 3)
		Me.lblPayloadSize.Name = "lblPayloadSize"
		Me.lblPayloadSize.Size = New System.Drawing.Size(114, 13)
		Me.lblPayloadSize.TabIndex = 1
		Me.lblPayloadSize.Text = "Payload Size: 26 bytes"
		'
		'txtPayload
		'
		Me.txtPayload.AcceptsTab = True
		Me.txtPayload.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
			Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtPayload.Location = New System.Drawing.Point(6, 19)
		Me.txtPayload.Multiline = True
		Me.txtPayload.Name = "txtPayload"
		Me.txtPayload.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtPayload.Size = New System.Drawing.Size(544, 246)
		Me.txtPayload.TabIndex = 0
		Me.txtPayload.Text = "GET / HTTP/1.1" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Host: " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
		'
		'tpResponse
		'
		Me.tpResponse.Controls.Add(Me.scResp)
		Me.tpResponse.Location = New System.Drawing.Point(4, 22)
		Me.tpResponse.Name = "tpResponse"
		Me.tpResponse.Padding = New System.Windows.Forms.Padding(3)
		Me.tpResponse.Size = New System.Drawing.Size(556, 271)
		Me.tpResponse.TabIndex = 1
		Me.tpResponse.Text = "Responses"
		Me.tpResponse.UseVisualStyleBackColor = True
		'
		'scResp
		'
		Me.scResp.Dock = System.Windows.Forms.DockStyle.Fill
		Me.scResp.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
		Me.scResp.Location = New System.Drawing.Point(3, 3)
		Me.scResp.Name = "scResp"
		'
		'scResp.Panel1
		'
		Me.scResp.Panel1.Controls.Add(Me.lvResponses)
		'
		'scResp.Panel2
		'
		Me.scResp.Panel2.Controls.Add(Me.tcResponses)
		Me.scResp.Size = New System.Drawing.Size(550, 265)
		Me.scResp.SplitterDistance = 270
		Me.scResp.TabIndex = 0
		'
		'lvResponses
		'
		Me.lvResponses.AllowColumnReorder = True
		Me.lvResponses.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.chNumber, Me.chResult, Me.chBody, Me.chHead, Me.chTotal})
		Me.lvResponses.Dock = System.Windows.Forms.DockStyle.Fill
		Me.lvResponses.FullRowSelect = True
		Me.lvResponses.Location = New System.Drawing.Point(0, 0)
		Me.lvResponses.Name = "lvResponses"
		Me.lvResponses.Size = New System.Drawing.Size(270, 265)
		Me.lvResponses.SmallImageList = Me.ilResponses
		Me.lvResponses.TabIndex = 0
		Me.lvResponses.UseCompatibleStateImageBehavior = False
		Me.lvResponses.View = System.Windows.Forms.View.Details
		'
		'chNumber
		'
		Me.chNumber.Text = "#"
		Me.chNumber.Width = 50
		'
		'chResult
		'
		Me.chResult.Text = "Result"
		Me.chResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.chResult.Width = 45
		'
		'chBody
		'
		Me.chBody.Text = "Body"
		Me.chBody.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.chBody.Width = 50
		'
		'chHead
		'
		Me.chHead.Text = "Head"
		Me.chHead.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.chHead.Width = 50
		'
		'chTotal
		'
		Me.chTotal.Text = "Total"
		Me.chTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.chTotal.Width = 50
		'
		'ilResponses
		'
		Me.ilResponses.ImageStream = CType(resources.GetObject("ilResponses.ImageStream"), System.Windows.Forms.ImageListStreamer)
		Me.ilResponses.TransparentColor = System.Drawing.Color.Transparent
		Me.ilResponses.Images.SetKeyName(0, "failure.png")
		Me.ilResponses.Images.SetKeyName(1, "upload.png")
		Me.ilResponses.Images.SetKeyName(2, "download.png")
		Me.ilResponses.Images.SetKeyName(3, "nothttp.png")
		Me.ilResponses.Images.SetKeyName(4, "unknown.png")
		Me.ilResponses.Images.SetKeyName(5, "200.png")
		Me.ilResponses.Images.SetKeyName(6, "301.png")
		Me.ilResponses.Images.SetKeyName(7, "302.png")
		Me.ilResponses.Images.SetKeyName(8, "304.png")
		Me.ilResponses.Images.SetKeyName(9, "401.png")
		Me.ilResponses.Images.SetKeyName(10, "403.png")
		Me.ilResponses.Images.SetKeyName(11, "404.png")
		Me.ilResponses.Images.SetKeyName(12, "5xx.png")
		'
		'tcResponses
		'
		Me.tcResponses.Controls.Add(Me.tpResponsesRaw)
		Me.tcResponses.Dock = System.Windows.Forms.DockStyle.Fill
		Me.tcResponses.Location = New System.Drawing.Point(0, 0)
		Me.tcResponses.Name = "tcResponses"
		Me.tcResponses.SelectedIndex = 0
		Me.tcResponses.Size = New System.Drawing.Size(276, 265)
		Me.tcResponses.TabIndex = 0
		'
		'tpResponsesRaw
		'
		Me.tpResponsesRaw.Controls.Add(Me.txtResponsesRaw)
		Me.tpResponsesRaw.Location = New System.Drawing.Point(4, 22)
		Me.tpResponsesRaw.Name = "tpResponsesRaw"
		Me.tpResponsesRaw.Padding = New System.Windows.Forms.Padding(3)
		Me.tpResponsesRaw.Size = New System.Drawing.Size(268, 239)
		Me.tpResponsesRaw.TabIndex = 0
		Me.tpResponsesRaw.Text = "Raw"
		Me.tpResponsesRaw.UseVisualStyleBackColor = True
		'
		'txtResponsesRaw
		'
		Me.txtResponsesRaw.Dock = System.Windows.Forms.DockStyle.Fill
		Me.txtResponsesRaw.Location = New System.Drawing.Point(3, 3)
		Me.txtResponsesRaw.Multiline = True
		Me.txtResponsesRaw.Name = "txtResponsesRaw"
		Me.txtResponsesRaw.ReadOnly = True
		Me.txtResponsesRaw.ScrollBars = System.Windows.Forms.ScrollBars.Both
		Me.txtResponsesRaw.Size = New System.Drawing.Size(262, 233)
		Me.txtResponsesRaw.TabIndex = 1
		Me.txtResponsesRaw.Text = "Select a response"
		'
		'tpSettings
		'
		Me.tpSettings.Controls.Add(Me.lblUpstream)
		Me.tpSettings.Controls.Add(Me.numQueueCount)
		Me.tpSettings.Controls.Add(Me.numQueueDelay)
		Me.tpSettings.Controls.Add(Me.lblQueueCount)
		Me.tpSettings.Controls.Add(Me.lblQueueDelay)
		Me.tpSettings.Location = New System.Drawing.Point(4, 22)
		Me.tpSettings.Name = "tpSettings"
		Me.tpSettings.Size = New System.Drawing.Size(556, 271)
		Me.tpSettings.TabIndex = 2
		Me.tpSettings.Text = "Settings"
		Me.tpSettings.UseVisualStyleBackColor = True
		'
		'lblUpstream
		'
		Me.lblUpstream.AutoSize = True
		Me.lblUpstream.Location = New System.Drawing.Point(3, 57)
		Me.lblUpstream.Name = "lblUpstream"
		Me.lblUpstream.Size = New System.Drawing.Size(161, 13)
		Me.lblUpstream.TabIndex = 2
		Me.lblUpstream.Text = "Upstream bandwidth: 260 byte/s"
		'
		'numQueueCount
		'
		Me.numQueueCount.Location = New System.Drawing.Point(89, 8)
		Me.numQueueCount.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
		Me.numQueueCount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numQueueCount.Name = "numQueueCount"
		Me.numQueueCount.Size = New System.Drawing.Size(57, 20)
		Me.numQueueCount.TabIndex = 1
		Me.numQueueCount.Value = New Decimal(New Integer() {1, 0, 0, 0})
		'
		'numQueueDelay
		'
		Me.numQueueDelay.Location = New System.Drawing.Point(89, 34)
		Me.numQueueDelay.Maximum = New Decimal(New Integer() {60000, 0, 0, 0})
		Me.numQueueDelay.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
		Me.numQueueDelay.Name = "numQueueDelay"
		Me.numQueueDelay.Size = New System.Drawing.Size(57, 20)
		Me.numQueueDelay.TabIndex = 1
		Me.numQueueDelay.Value = New Decimal(New Integer() {100, 0, 0, 0})
		'
		'lblQueueCount
		'
		Me.lblQueueCount.AutoSize = True
		Me.lblQueueCount.Location = New System.Drawing.Point(3, 10)
		Me.lblQueueCount.Name = "lblQueueCount"
		Me.lblQueueCount.Size = New System.Drawing.Size(81, 13)
		Me.lblQueueCount.TabIndex = 0
		Me.lblQueueCount.Text = "Request Count:"
		'
		'lblQueueDelay
		'
		Me.lblQueueDelay.AutoSize = True
		Me.lblQueueDelay.Location = New System.Drawing.Point(3, 36)
		Me.lblQueueDelay.Name = "lblQueueDelay"
		Me.lblQueueDelay.Size = New System.Drawing.Size(80, 13)
		Me.lblQueueDelay.TabIndex = 0
		Me.lblQueueDelay.Text = "Queue Interval:"
		'
		'ssStatus
		'
		Me.ssStatus.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsslRequests, Me.tsslRequestCounter})
		Me.ssStatus.Location = New System.Drawing.Point(0, 344)
		Me.ssStatus.Name = "ssStatus"
		Me.ssStatus.Size = New System.Drawing.Size(588, 22)
		Me.ssStatus.TabIndex = 1
		Me.ssStatus.Text = "StatusStrip1"
		'
		'tsslRequests
		'
		Me.tsslRequests.Name = "tsslRequests"
		Me.tsslRequests.Size = New System.Drawing.Size(57, 17)
		Me.tsslRequests.Text = "Requests:"
		'
		'tsslRequestCounter
		'
		Me.tsslRequestCounter.Name = "tsslRequestCounter"
		Me.tsslRequestCounter.Size = New System.Drawing.Size(30, 17)
		Me.tsslRequestCounter.Text = "0 / 0"
		Me.tsslRequestCounter.ToolTipText = "Completed / Started"
		'
		'lblTarget
		'
		Me.lblTarget.AutoSize = True
		Me.lblTarget.Location = New System.Drawing.Point(12, 9)
		Me.lblTarget.Name = "lblTarget"
		Me.lblTarget.Size = New System.Drawing.Size(54, 13)
		Me.lblTarget.TabIndex = 2
		Me.lblTarget.Text = "Target IP:"
		'
		'txtTarget
		'
		Me.txtTarget.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
			Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.txtTarget.Location = New System.Drawing.Point(72, 6)
		Me.txtTarget.Name = "txtTarget"
		Me.txtTarget.Size = New System.Drawing.Size(368, 20)
		Me.txtTarget.TabIndex = 3
		Me.txtTarget.Text = "127.0.0.1"
		'
		'numPort
		'
		Me.numPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.numPort.Location = New System.Drawing.Point(462, 7)
		Me.numPort.Maximum = New Decimal(New Integer() {65535, 0, 0, 0})
		Me.numPort.Name = "numPort"
		Me.numPort.Size = New System.Drawing.Size(52, 20)
		Me.numPort.TabIndex = 4
		Me.numPort.Value = New Decimal(New Integer() {80, 0, 0, 0})
		'
		'lblPort
		'
		Me.lblPort.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.lblPort.AutoSize = True
		Me.lblPort.Location = New System.Drawing.Point(446, 9)
		Me.lblPort.Name = "lblPort"
		Me.lblPort.Size = New System.Drawing.Size(10, 13)
		Me.lblPort.TabIndex = 5
		Me.lblPort.Text = ":"
		'
		'btnToggleAttack
		'
		Me.btnToggleAttack.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnToggleAttack.Appearance = System.Windows.Forms.Appearance.Button
		Me.btnToggleAttack.AutoSize = True
		Me.btnToggleAttack.Location = New System.Drawing.Point(525, 30)
		Me.btnToggleAttack.Name = "btnToggleAttack"
		Me.btnToggleAttack.Size = New System.Drawing.Size(51, 23)
		Me.btnToggleAttack.TabIndex = 6
		Me.btnToggleAttack.Text = "Attack!"
		Me.btnToggleAttack.UseVisualStyleBackColor = True
		'
		'tmrQueue
		'
		'
		'btnOneRequest
		'
		Me.btnOneRequest.Location = New System.Drawing.Point(373, 30)
		Me.btnOneRequest.Name = "btnOneRequest"
		Me.btnOneRequest.Size = New System.Drawing.Size(70, 23)
		Me.btnOneRequest.TabIndex = 7
		Me.btnOneRequest.Text = "Only Once"
		Me.btnOneRequest.UseVisualStyleBackColor = True
		'
		'btnResolve
		'
		Me.btnResolve.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
		Me.btnResolve.Location = New System.Drawing.Point(520, 4)
		Me.btnResolve.Name = "btnResolve"
		Me.btnResolve.Size = New System.Drawing.Size(56, 23)
		Me.btnResolve.TabIndex = 8
		Me.btnResolve.Text = "Resolve"
		Me.btnResolve.UseVisualStyleBackColor = True
		'
		'btnEnqueue
		'
		Me.btnEnqueue.Location = New System.Drawing.Point(449, 30)
		Me.btnEnqueue.Name = "btnEnqueue"
		Me.btnEnqueue.Size = New System.Drawing.Size(70, 23)
		Me.btnEnqueue.TabIndex = 9
		Me.btnEnqueue.Text = "Enqueue"
		Me.btnEnqueue.UseVisualStyleBackColor = True
		'
		'MainForm
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.ClientSize = New System.Drawing.Size(588, 366)
		Me.Controls.Add(Me.btnEnqueue)
		Me.Controls.Add(Me.btnResolve)
		Me.Controls.Add(Me.btnOneRequest)
		Me.Controls.Add(Me.btnToggleAttack)
		Me.Controls.Add(Me.lblPort)
		Me.Controls.Add(Me.numPort)
		Me.Controls.Add(Me.txtTarget)
		Me.Controls.Add(Me.lblTarget)
		Me.Controls.Add(Me.ssStatus)
		Me.Controls.Add(Me.tcMain)
		Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
		Me.MinimumSize = New System.Drawing.Size(425, 200)
		Me.Name = "MainForm"
		Me.Text = "TCP Stress Tester"
		Me.tcMain.ResumeLayout(False)
		Me.tpPayload.ResumeLayout(False)
		Me.tpPayload.PerformLayout()
		Me.tpResponse.ResumeLayout(False)
		Me.scResp.Panel1.ResumeLayout(False)
		Me.scResp.Panel2.ResumeLayout(False)
		Me.scResp.ResumeLayout(False)
		Me.tcResponses.ResumeLayout(False)
		Me.tpResponsesRaw.ResumeLayout(False)
		Me.tpResponsesRaw.PerformLayout()
		Me.tpSettings.ResumeLayout(False)
		Me.tpSettings.PerformLayout()
		CType(Me.numQueueCount, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.numQueueDelay, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ssStatus.ResumeLayout(False)
		Me.ssStatus.PerformLayout()
		CType(Me.numPort, System.ComponentModel.ISupportInitialize).EndInit()
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
	Friend WithEvents tcMain As System.Windows.Forms.TabControl
	Friend WithEvents tpPayload As System.Windows.Forms.TabPage
	Friend WithEvents tpResponse As System.Windows.Forms.TabPage
	Friend WithEvents ssStatus As System.Windows.Forms.StatusStrip
	Friend WithEvents lblTarget As System.Windows.Forms.Label
	Friend WithEvents txtTarget As System.Windows.Forms.TextBox
	Friend WithEvents numPort As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblPort As System.Windows.Forms.Label
	Friend WithEvents txtPayload As System.Windows.Forms.TextBox
	Friend WithEvents scResp As System.Windows.Forms.SplitContainer
	Friend WithEvents lvResponses As System.Windows.Forms.ListView
	Friend WithEvents chNumber As System.Windows.Forms.ColumnHeader
	Friend WithEvents chResult As System.Windows.Forms.ColumnHeader
	Friend WithEvents chBody As System.Windows.Forms.ColumnHeader
	Friend WithEvents chHead As System.Windows.Forms.ColumnHeader
	Friend WithEvents chTotal As System.Windows.Forms.ColumnHeader
	Friend WithEvents tcResponses As System.Windows.Forms.TabControl
	Friend WithEvents tpResponsesRaw As System.Windows.Forms.TabPage
	Friend WithEvents txtResponsesRaw As System.Windows.Forms.TextBox
	Friend WithEvents ilResponses As System.Windows.Forms.ImageList
	Friend WithEvents tsslRequestCounter As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents btnToggleAttack As System.Windows.Forms.CheckBox
	Friend WithEvents lblPayloadSize As System.Windows.Forms.Label
	Friend WithEvents tpSettings As System.Windows.Forms.TabPage
	Friend WithEvents numQueueDelay As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblQueueDelay As System.Windows.Forms.Label
	Friend WithEvents lblUpstream As System.Windows.Forms.Label
	Friend WithEvents tmrQueue As System.Windows.Forms.Timer
	Friend WithEvents tsslRequests As System.Windows.Forms.ToolStripStatusLabel
	Friend WithEvents btnOneRequest As System.Windows.Forms.Button
	Friend WithEvents btnResolve As System.Windows.Forms.Button
	Friend WithEvents numQueueCount As System.Windows.Forms.NumericUpDown
	Friend WithEvents lblQueueCount As System.Windows.Forms.Label
	Friend WithEvents btnEnqueue As System.Windows.Forms.Button

End Class
