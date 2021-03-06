﻿Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class RequestThread
	Const MAXRECEIVE As Integer = 2 * 1024 * 1024 ' 2 megabytes

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
			Me.MainFormRef.ResponseError(UpdateItem, "(connect error)" & ControlChars.CrLf & ex.Message)
			Me.MainFormRef.IncreaseCompleted()
			Return
		End Try
		' Upload
		Dim netstream As NetworkStream = tcp.GetStream()
		netstream.Write(Payload, 0, Payload.Length)
		' Download
		Me.MainFormRef.DownloadingPhase(UpdateItem)
		tcp.ReceiveBufferSize = MAXRECEIVE
		Dim ReceivedBytes(MAXRECEIVE) As Byte
		Dim ResponseLength As Integer = 0
		Do
			Dim read As Integer = netstream.Read(ReceivedBytes, ResponseLength, MAXRECEIVE - ResponseLength)
			ResponseLength += read
			Thread.Sleep(1000) ' wait up to 1 second for the next chunk
		Loop While netstream.DataAvailable AndAlso ResponseLength < MAXRECEIVE
		' Build String for response
		Dim out As String
		out = System.Text.Encoding.UTF8.GetString(ReceivedBytes, 0, ResponseLength)
		Me.MainFormRef.ResponseReceived(UpdateItem, out)
		Me.MainFormRef.IncreaseCompleted()
	End Sub
End Class
