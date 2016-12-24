Imports System.Net, System.Net.Sockets, System.IO
Public Class Connection
    Private client As TcpClient
    Private IP As String
    Public Event GotInfo(ByVal client As Connection, ByVal Message As String)
    Public Event Disconnected(ByVal client As Connection)
    Sub New(ByVal client As TcpClient)
        client.ReceiveTimeout = 30
        client.SendTimeout = 30
        Me.client = client
        client.GetStream().BeginRead(New Byte() {0}, 0, 0, AddressOf Read, Nothing)


        IP = client.Client.RemoteEndPoint.ToString().Remove(client.Client.RemoteEndPoint.ToString().LastIndexOf(":"))

    End Sub

    Sub Read(ByVal ar As IAsyncResult)
        Dim Message As String
        Try

            Dim reader As New StreamReader(client.GetStream())
            Message = reader.ReadLine()
            RaiseEvent GotInfo(Me, Main.AES_Decrypt(Message))
            client.GetStream().BeginRead(New Byte() {0}, 0, 0, AddressOf Read, Nothing)
        Catch ex As Exception
            RaiseEvent Disconnected(Me)
        End Try
    End Sub
    Public Sub Send(ByVal Message As String)
        Try
            Dim writer As New StreamWriter(client.GetStream())
            writer.WriteLine((Main.AES_Encrypt(Message)))
            writer.Flush()
        Catch ex As Exception
            '    MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Public ReadOnly Property IPAddress
        Get
            Return IP
        End Get
    End Property

End Class
