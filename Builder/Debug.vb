Imports System
Imports System.Net
Imports System.Text
Imports System.IO
Imports System.IO.Compression
Imports System.Diagnostics
Imports System.Reflection
Imports System.Windows.Forms
Imports System.ComponentModel
Imports System.Security.Cryptography
Imports System.Collections.Generic
Imports System.Runtime.InteropServices
Imports System.Net.Security
Imports System.Security
Imports System.Security.Cryptography.X509Certificates

''' <summary>
''' License Loader, Version: 2.0.0.7, Changed: 09/05/2013
''' </summary>

Friend NotInheritable Class License

#Region " ReadOnly Properties "

    ReadOnly Property Username As String
        Get
            Dim Data As Object = Instance.GetMethod("GetUsername").Invoke(Nothing, Nothing)
            Return DirectCast(Data, String)
        End Get
    End Property

    Private _ProductVersion As Version
    ReadOnly Property ProductVersion As Version
        Get
            If _ProductVersion Is Nothing Then
                _ProductVersion = New Version(Application.ProductVersion)
            End If

            Return _ProductVersion
        End Get
    End Property

    ReadOnly Property ExecutablePath As String
        Get
            Dim Data As Object = Instance.GetMethod("GetExecutablePath").Invoke(Nothing, Nothing)
            Return DirectCast(Data, String)
        End Get
    End Property

    ReadOnly Property GlobalMessage As String
        Get
            Dim Data As Object = Instance.GetMethod("GetMessage").Invoke(Nothing, Nothing)
            Return DirectCast(Data, String)
        End Get
    End Property

    ReadOnly Property IPAddress As IPAddress
        Get
            Dim Data As Object = Instance.GetMethod("GetIPAddress").Invoke(Nothing, Nothing)
            Return DirectCast(Data, IPAddress)
        End Get
    End Property

    ReadOnly Property ExpirationDate As Date
        Get
            Dim Data As Object = Instance.GetMethod("GetExpiration").Invoke(Nothing, Nothing)
            Return DirectCast(Data, Date)
        End Get
    End Property

    ReadOnly Property TimeRemaining As TimeSpan
        Get
            Dim Data As Object = Instance.GetMethod("GetRemaining").Invoke(Nothing, Nothing)
            Return DirectCast(Data, TimeSpan)
        End Get
    End Property

    ReadOnly Property LicenseType As LicenseType
        Get
            Dim Data As Object = Instance.GetMethod("GetLicenseType").Invoke(Nothing, Nothing)
            Return DirectCast(Data, LicenseType)
        End Get
    End Property

    ReadOnly Property Points As Integer
        Get
            Dim Data As Object = Instance.GetMethod("GetPoints").Invoke(Nothing, Nothing)
            Return DirectCast(Data, Integer)
        End Get
    End Property

    ReadOnly Property UnlimitedTime As Boolean
        Get
            Dim Data As Object = Instance.GetMethod("GetUnlimitedTime").Invoke(Nothing, Nothing)
            Return DirectCast(Data, Boolean)
        End Get
    End Property

    ReadOnly Property UpdateAvailable As Boolean
        Get
            Dim Data As Object = Instance.GetMethod("GetUpdateAvailable").Invoke(Nothing, Nothing)
            Return DirectCast(Data, Boolean)
        End Get
    End Property

    ReadOnly Property UsersCount As Integer
        Get
            Dim Data As Object = Instance.GetMethod("GetUsersCount").Invoke(Nothing, Nothing)
            Return DirectCast(Data, Integer)
        End Get
    End Property

    ReadOnly Property UsersOnline As Integer
        Get
            Dim Data As Object = Instance.GetMethod("GetUsersOnline").Invoke(Nothing, Nothing)
            Return DirectCast(Data, Integer)
        End Get
    End Property

    ReadOnly Property GUID As String
        Get
            Dim Data As Object = Instance.GetMethod("GetGUID").Invoke(Nothing, Nothing)
            Return DirectCast(Data, String)
        End Get
    End Property

    ReadOnly Property PublicToken As String
        Get
            Dim Data As Object = Instance.GetMethod("GetPublicToken").Invoke(Nothing, Nothing)
            Return DirectCast(Data, String)
        End Get
    End Property

    ReadOnly Property PrivateKey As Byte()
        Get
            Dim Data As Object = Instance.GetMethod("GetPrivateKey").Invoke(Nothing, Nothing)
            Return DirectCast(Data, Byte())
        End Get
    End Property

    ReadOnly Property Client As WebClient
        Get
            Dim Data As Object = Instance.GetMethod("GetClient").Invoke(Nothing, Nothing)
            Return DirectCast(Data, WebClient)
        End Get
    End Property

    ReadOnly Property News As NewsPost()
        Get
            Dim Data As Object = Instance.GetMethod("GetNews").Invoke(Nothing, Nothing)
            Dim Values As Object() = DirectCast(Data, Object())

            Dim Section As Integer
            Dim T As New List(Of NewsPost)

            For I As Integer = 0 To Values.Length - 1 Step 3
                Section = I * 3
                T.Add(New NewsPost(Values(I), Values(I + 1), Values(I + 2)))
            Next

            Return T.ToArray()
        End Get
    End Property

#End Region

#Region " Initialize Properties "

    Private _ID As String
    Property ID() As String
        Get
            Return _ID
        End Get
        Set(ByVal value As String)
            _ID = value
        End Set
    End Property

    Private _Catch As Boolean = True
    Property [Catch]() As Boolean
        Get
            Return _Catch
        End Get
        Set(ByVal value As Boolean)
            _Catch = value
        End Set
    End Property

    Private _DisableUpdates As Boolean
    Property DisableUpdates() As Boolean
        Get
            Return _DisableUpdates
        End Get
        Set(ByVal value As Boolean)
            _DisableUpdates = value
        End Set
    End Property

    Private _RunHook As GenericDelegate
    Property RunHook() As GenericDelegate
        Get
            Return _RunHook
        End Get
        Set(ByVal value As GenericDelegate)
            _RunHook = value
        End Set
    End Property

    Private _BanHook As GenericDelegate
    Property BanHook() As GenericDelegate
        Get
            Return _BanHook
        End Get
        Set(ByVal value As GenericDelegate)
            _BanHook = value
        End Set
    End Property

    Private _RenewHook As GenericDelegate
    Property RenewHook() As GenericDelegate
        Get
            Return _RenewHook
        End Get
        Set(ByVal value As GenericDelegate)
            _RenewHook = value
        End Set
    End Property

    Private _Protection As RuntimeProtection
    Property Protection() As RuntimeProtection
        Get
            Return _Protection
        End Get
        Set(ByVal value As RuntimeProtection)
            _Protection = value
        End Set
    End Property

    Private _ValidateCore As Boolean = True
    Property ValidateCore As Boolean
        Get
            Return _ValidateCore
        End Get
        Set(ByVal value As Boolean)
            _ValidateCore = value
        End Set
    End Property

#End Region

#Region " Public Methods "

    Sub Initialize(ByVal programID As String)
        ID = programID
        Initialize()
    End Sub

    Sub Initialize()
        If LicenseGlobal.LicenseInitialize Then Return
        LicenseGlobal.LicenseInitialize = True

        If String.IsNullOrEmpty(ID) Then
            ErrorKill("Unable to initialize due to missing Net Seal ID.")
            Return
        End If

        ServicePointManager.Expect100Continue = False
        ServicePointManager.DefaultConnectionLimit = 5

        Try
            WC = New CookieClient()

            Dim Common As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
            LocationPath = Path.Combine(Common, "Nimoru")

            LicenseLocation = Path.Combine(LocationPath, "LicenseSE")
            GizmoDllLocation = Path.Combine(LocationPath, "GizmoDll")
            GizmoLocation = Path.Combine(LocationPath, "GizmoSE")

            OverrideSSL() '--BEGIN OVERRIDE--

            DownloadChecksums()
            DownloadComponents()

            RestoreSSL() '--END OVERRIDE--

            Endpoint = Checksums(5)
            ValidateSignature()

            Instance.GetMethod("SetID").Invoke(Nothing, New Object() {ID})
            Instance.GetMethod("SetCatch").Invoke(Nothing, New Object() {[Catch]})
            Instance.GetMethod("SetDisableUpdates").Invoke(Nothing, New Object() {DisableUpdates})
            Instance.GetMethod("SetRunHook").Invoke(Nothing, New Object() {RunHook})
            Instance.GetMethod("SetBanHook").Invoke(Nothing, New Object() {BanHook})
            Instance.GetMethod("SetRenewHook").Invoke(Nothing, New Object() {RenewHook})
            Instance.GetMethod("SetScan").Invoke(Nothing, New Object() {DirectCast(Protection, Byte)})
        Catch ex As Exception
            Dim T As New StringBuilder
            T.AppendLine(Date.UtcNow.ToString)
            T.AppendLine()
            T.AppendLine(ex.Message)
            T.AppendLine(ex.StackTrace)
            File.WriteAllText("loader.log", T.ToString)

            ErrorKill("Unable to continue due to an error. Exception written to 'loader.log' file.")
            Return
        End Try

        Try
            Instance.GetMethod("RunWE").Invoke(Nothing, New Object() {Version, ProductVersion, Endpoint})
        Catch
            ErrorKill("Unable to initialize license file.")
        End Try
    End Sub

    Sub ShowAccount()
        Instance.GetMethod("ShowAccount").Invoke(Nothing, Nothing)
    End Sub

    Function Encrypt(ByVal data As String) As String
        InitializeRm()

        Dim R As Byte() = Encoding.UTF8.GetBytes(data)
        Dim O As Byte() = Encryptor.TransformFinalBlock(R, 0, R.Length)
        Dim U(O.Length + 3) As Byte

        Buffer.BlockCopy(BitConverter.GetBytes(data.Length), 0, U, 0, 4)
        Buffer.BlockCopy(O, 0, U, 4, O.Length)

        Return Convert.ToBase64String(U)
    End Function

    Function Decrypt(ByVal data As Byte()) As Byte()
        InitializeRm()

        Dim Size As Integer = BitConverter.ToInt32(data, 0)
        Dim O As Byte() = Decryptor.TransformFinalBlock(data, 4, data.Length - 4)

        Dim U(Size - 1) As Byte
        Buffer.BlockCopy(O, 0, U, 0, Size)

        Return U
    End Function

    'NOTE: If String.IsNullOrEmpty() get new posts from License.News.
    Function GetPostMessage(ByVal postID As Integer) As String
        Dim Data As Object = Instance.GetMethod("GetPostMessage").Invoke(Nothing, New Object() {postID})
        Return DirectCast(Data, String)
    End Function

    Function GetVariable(ByVal name As String) As String
        Dim Data As Object = Instance.GetMethod("GetVariable").Invoke(Nothing, New Object() {name})
        Return DirectCast(Data, String)
    End Function

    Function SpendPoints(ByVal count As Integer) As Boolean
        Dim Data As Object = Instance.GetMethod("SpendPoints").Invoke(Nothing, New Object() {count})
        Return DirectCast(Data, Boolean)
    End Function

    Sub InstallUpdates()
        Instance.GetMethod("InstallUpdates").Invoke(Nothing, Nothing)
    End Sub

    Sub BanCurrentUser(ByVal reason As String)
        Instance.GetMethod("BanCurrentUser").Invoke(Nothing, New Object() {reason})
    End Sub

#End Region

#Region " System Declarations "

    'IMPORTANT: DO NOT CHANGE THIS!
    Private Version As New Version("2.0.0.6")

    Private Instance As Type
    Private WC As CookieClient

    Private LocationPath As String
    Private LicenseLocation As String
    Private GizmoDllLocation As String
    Private GizmoLocation As String

    Private Checksums As String()
    Private Endpoint As String

    Private Const Domain1 As String = "http://seal.nimoru.com/Base/"
    Private Const Domain2 As String = "https://s3.amazonaws.com/nimoru/"

    Private Const PublicKey As String = "BgIAAAAiAABEU1MxAAQAAKVlurdZMaHymNk04yRy3VGj0Bhf6gGIBsGr1zk42LrdnwYLfvn7MBAiYoCH2cD07M/HuM6NW1WqJQVF2omwH5S211wfvBCutU92RxXldmfvd06l8eQqmppztYIrXdxmW0BRlosBKPM5ms6YXZnoMKseAoqZ6Ajza8U9QCJMkSHSR+O23EoGj9V+7xwkCoYHklFtLJzERB6y/DW1BCCHhLblzpFz+mht1CD6xAi2QBNY7vZcWdbqo+ZLT4y7sw8jU61liYBuZLA/t+6KHhoIwZ+NIErsCHW5RD9ln5VpMC66wBCcY594ZTIManIuvmpw4eQaUXZPoMogf29gJgJSolaDg5iP1XDqzOTPu9RdsHe3R1ZaNglrL05zoTM94Zkl5KT+bPAUC99kGrEDmNipe6tj8FwoOTNNaTaOvWZlXTtAfaxqGV47nxKfabgxEl08n0c3PBJEjUZzJ4chwQ2Ex2A5uYBgRukcmKmRmdwIphHq0IwdoxS1+6HSwXxg1d3EEAoxJ75R1eSXF+cXOeC7d/U2UY0tqwAAAMvTiz5uMzpBQIYdNcbYnrJwHObk"

    Private ReadOnly Property UID As String
        Get
            Return "?uid=" & BitConverter.ToString(BitConverter.GetBytes(Environment.TickCount)).Replace("-", "")
        End Get
    End Property

    Private Encryptor As ICryptoTransform
    Private Decryptor As ICryptoTransform
    Private RmInitialize As Boolean

    <EditorBrowsable(EditorBrowsableState.Advanced)> _
    Delegate Sub GenericDelegate()

    <DllImport("kernel32.dll", EntryPoint:="ExitProcess")> _
    Private Shared Sub ExitProcess(ByVal code As UInteger)
    End Sub

    <DllImport("mscoree.dll", EntryPoint:="StrongNameSignatureVerificationEx", CharSet:=CharSet.Unicode)> _
    Private Shared Function StrongNameSignatureVerificationEx( _
    ByVal fileName As String, _
    ByVal force As Boolean, _
    ByRef genuine As Boolean) As Boolean
    End Function

    <DllImport("mscoree.dll", PreserveSig:=False, EntryPoint:="CLRCreateInstance")> _
    Private Shared Function CreateInstance( _
      <MarshalAs(UnmanagedType.LPStruct)> ByVal cid As Guid, _
      <MarshalAs(UnmanagedType.LPStruct)> ByVal iid As Guid) As <MarshalAs(UnmanagedType.Interface)> Object
    End Function

#End Region

#Region " System Methods "

    Private Sub DownloadChecksums()
        Try
            Checksums = WC.DownloadString(Domain1 & "checksumSE.php" & UID).Split(Char.MinValue)
        Catch ex As Exception
            Threading.Thread.Sleep(500)
            Checksums = WC.DownloadString(Domain2 & "checksumSE.txt" & UID).Split(Convert.ToChar(124))
        End Try
    End Sub

    Private Sub DownloadComponents()
        Dim Hash As String
        If Not Directory.Exists(LocationPath) Then
            Directory.CreateDirectory(LocationPath)
        End If

        If Not File.Exists(GizmoDllLocation) Then
            DownloadGizmoDll()
        End If

        Hash = MD5File(GizmoDllLocation)
        If Not Hash = Checksums(1) Then
            DownloadGizmoDll()
        End If

        If Not File.Exists(GizmoLocation) Then
            DownloadGizmo()
        End If

        Hash = MD5File(GizmoLocation)
        If Not Hash = Checksums(2) Then
            DownloadGizmo()
        End If

        If Not File.Exists(LicenseLocation) Then
            DownloadLicense()
        End If

        Hash = MD5File(LicenseLocation)
        If Not Hash = Checksums(3) Then
            DownloadLicense()
        End If
    End Sub

    Private Sub ValidateSignature()
        If ValidateCore AndAlso Not CheckCore() Then
            Throw New InvalidDataException("Core framework files are not trusted.")
            Return
        End If

        Dim M As FileStream = File.OpenRead(LicenseLocation)
        Dim R As New BinaryReader(M)

        Dim FullData As Byte() = R.ReadBytes(CInt(M.Length))
        M.Position = 2

        Dim Sign As Byte() = R.ReadBytes(40)
        Dim Data As Byte() = R.ReadBytes(CInt(M.Length - Sign.Length - 2))
        R.Close()

        Dim DSA As New DSACryptoServiceProvider
        DSA.ImportCspBlob(Convert.FromBase64String(PublicKey))

        If DSA.VerifyData(Data, Sign) Then
            Instance = Assembly.Load(FullData).GetType("Share")
        Else
            Throw New InvalidDataException("Unable to validate signature.")
        End If
    End Sub


    Private Sub DownloadGizmoDll()
        Dim Data As Byte() = WC.DownloadData(Checksums(0) & Checksums(1) & ".co")
        Data = Decompress(Data)

        Dim Hash As String = MD5(Data)
        If Not Checksums(1) = Hash Then
            Fail(GizmoDllLocation)
            Return
        End If

        File.WriteAllBytes(GizmoDllLocation, Data)
    End Sub

    Private Sub DownloadGizmo()
        Dim Data As Byte() = WC.DownloadData(Checksums(0) & Checksums(2) & ".co")
        Data = GizmoDecompress(Data)

        Dim Hash As String = MD5(Data)
        If Not Checksums(2) = Hash Then
            Fail(GizmoLocation)
            Return
        End If

        File.WriteAllBytes(GizmoLocation, Data)
    End Sub

    Private Sub DownloadLicense()
        Dim PI As New ProcessStartInfo
        PI.Arguments = String.Format("""{0}"" ""{1}"" {2} -s", Checksums(0) & Checksums(3) & ".co", LicenseLocation, Checksums(3))
        PI.FileName = GizmoLocation
        PI.UseShellExecute = False

        Dim P As Process = Process.Start(PI)
        If Not P.WaitForExit(20000) Then
            Environment.Exit(0)
        End If

        If Not P.ExitCode = 7788 Then
            Environment.Exit(0)
        End If
    End Sub


    Private Sub Fail(ByVal path As String)
        File.Delete(path)
        ErrorKill("Failed to initialize all the required components.")
    End Sub

    Private Sub ErrorKill(ByVal message As String)
        MessageBox.Show(message, "Loader Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Environment.Exit(0)
        ExitProcess(0)
    End Sub


    Private Function Decompress(ByVal data As Byte()) As Byte()
        Dim Size As Integer = BitConverter.ToInt32(data, 0)

        Dim U(Size - 1) As Byte
        Dim M As New MemoryStream(data, 4, data.Length - 4)

        Dim D As New DeflateStream(M, CompressionMode.Decompress, False)
        D.Read(U, 0, U.Length)

        D.Close()
        M.Close()
        Return U
    End Function

    Private Function GizmoDecompress(ByVal data As Byte()) As Byte()
        Dim GizmoDll As Byte() = File.ReadAllBytes(GizmoDllLocation)
        Dim G As MethodInfo = Assembly.Load(GizmoDll).GetType("H").GetMethod("Decompress")
        Return DirectCast(G.Invoke(Nothing, New Object() {data}), Byte())
    End Function


    Private Function MD5(ByVal data As Byte()) As String
        Dim H As New MD5CryptoServiceProvider
        Return HashToString(H.ComputeHash(data))
    End Function

    Private Function MD5File(ByVal path As String) As String
        Dim F As New FileStream(path, FileMode.Open, FileAccess.Read)
        Dim H As New MD5CryptoServiceProvider

        Dim Hash As String = HashToString(H.ComputeHash(F))

        F.Close()
        Return Hash
    End Function

    Private Function HashToString(ByVal data As Byte()) As String
        Return BitConverter.ToString(data).ToLower().Replace("-", String.Empty)
    End Function

    Private Sub InitializeRm()
        If RmInitialize Then Return
        RmInitialize = True

        Dim Rm As New RijndaelManaged
        Rm.Padding = PaddingMode.Zeros
        Rm.Mode = CipherMode.CBC
        Rm.Key = PrivateKey
        Rm.IV = PrivateKey

        Encryptor = Rm.CreateEncryptor()
        Decryptor = Rm.CreateDecryptor()
    End Sub

    Private SN As IStrongName

    Private Function CheckCore() As Boolean
        Dim Base As String = RuntimeEnvironment.GetRuntimeDirectory()
        Dim Build As String = RuntimeEnvironment.GetSystemVersion()
        Dim HostCLR As Boolean = Int32.Parse(Build(1).ToString()) >= 4

        If HostCLR Then
            Dim CID_META_HOST As New Guid("9280188D-0E8E-4867-B30C-7FA83884E8DE")
            Dim CID_STRONG_NAME As New Guid("B79B0ACD-F5CD-409B-B5A5-A16244610B92")

            Dim Meta As IMeta = DirectCast(CreateInstance(CID_META_HOST, GetType(IMeta).GUID), IMeta)
            Dim Runtime As IRuntime = DirectCast(Meta.GetRuntime(Build, GetType(IRuntime).GUID), IRuntime)
            SN = DirectCast(Runtime.GetInterface(CID_STRONG_NAME, GetType(IStrongName).GUID), IStrongName)
        End If

        Dim File1 As String = Path.ChangeExtension(Path.Combine(Base, "mscorlib"), "dll")
        Dim File2 As String = Path.ChangeExtension(Path.Combine(Base, "system"), "dll")

        Dim Token As Byte() = New Byte() {183, 122, 92, 86, 25, 52, 224, 137}
        If Not IsTrusted(File1, Token, HostCLR) Then Return False
        If Not IsTrusted(File2, Token, HostCLR) Then Return False

        Return True
    End Function

    Private Function IsTrusted(ByVal path As String, ByVal token As Byte(), ByVal hostCLR As Boolean) As Boolean
        Dim Genuine As Boolean

        If hostCLR Then
            If Not (SN.StrongNameSignatureVerificationEx(path, True, Genuine) = 0 AndAlso Genuine) Then Return False
        Else
            If Not (StrongNameSignatureVerificationEx(path, True, Genuine) AndAlso Genuine) Then Return False
        End If

        Dim PublicToken As Byte() = Assembly.LoadFile(path).GetName().GetPublicKeyToken()
        If PublicToken Is Nothing OrElse Not PublicToken.Length = 8 Then Return False

        For I As Integer = 0 To 7
            If Not PublicToken(I) = token(I) Then Return False
        Next

        Return True
    End Function

    Private SSLCallback As RemoteCertificateValidationCallback
    Private Function ValidateSSL(ByVal sender As Object, ByVal cert As X509Certificate, ByVal chain As X509Chain, ByVal errors As SslPolicyErrors) As Boolean
        Return True
    End Function

    Private Sub OverrideSSL()
        SSLCallback = ServicePointManager.ServerCertificateValidationCallback
        ServicePointManager.ServerCertificateValidationCallback = New RemoteCertificateValidationCallback(AddressOf ValidateSSL)
    End Sub

    Private Sub RestoreSSL()
        ServicePointManager.ServerCertificateValidationCallback = SSLCallback
    End Sub

#End Region

    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("D332DB9E-B9B3-4125-8207-A14884F53216")> _
    Private Interface IMeta
        Function GetRuntime(ByVal version As String, <MarshalAs(UnmanagedType.LPStruct)> ByVal iid As Guid) As <MarshalAs(UnmanagedType.Interface)> Object
    End Interface

    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("BD39D1D2-BA2F-486A-89B0-B4B0CB466891")> _
    Private Interface IRuntime
        Sub M1()
        Sub M2()
        Sub M3()
        Sub M4()
        Sub M5()
        Sub M6()
        Function GetInterface(<MarshalAs(UnmanagedType.LPStruct)> ByVal cid As Guid, <MarshalAs(UnmanagedType.LPStruct)> ByVal iid As Guid) As <MarshalAs(UnmanagedType.Interface)> Object
    End Interface

    <InterfaceType(ComInterfaceType.InterfaceIsIUnknown), Guid("9FD93CCF-3280-4391-B3A9-96E1CDE77C8D")> _
    Private Interface IStrongName
        Sub M1()
        Sub M2()
        Sub M3()
        Sub M4()
        Sub M5()
        Sub M6()
        Sub M7()
        Sub M8()
        Sub M9()
        Sub M10()
        Sub M11()
        Sub M12()
        Sub M13()
        Sub M14()
        Sub M15()
        Sub M16()
        Sub M17()
        Sub M18()
        Sub M19()
        Sub M20()
        Function StrongNameSignatureVerificationEx(ByVal filePath As String, ByVal force As Boolean, ByRef genuine As Boolean) As Integer
    End Interface

End Class

Friend Module LicenseGlobal

    Friend Seal As New License
    Friend LicenseInitialize As Boolean

End Module

Friend Enum LicenseType As Byte
    Free = 0
    Bronze = 1
    Silver = 2
    Gold = 3
    Platinum = 4
    Diamond = 5
End Enum

<Flags()> _
Friend Enum RuntimeProtection As Byte
    None = 0
    Debuggers = 1
    DebuggersEx = 2
    Timing = 4
    Parent = 8
    FullScan = 15
    VirtualMachine = 16
End Enum

Friend Structure NewsPost
    Private ReadOnly _ID As Integer
    ReadOnly Property ID() As Integer
        Get
            Return _ID
        End Get
    End Property

    Private ReadOnly _Name As String
    ReadOnly Property Name() As String
        Get
            Return _Name
        End Get
    End Property

    Private ReadOnly _Time As Date
    ReadOnly Property Time() As Date
        Get
            Return _Time
        End Get
    End Property

    Sub New(ByVal id As Object, ByVal name As Object, ByVal time As Object)
        _ID = DirectCast(id, Integer)
        _Name = DirectCast(name, String)
        _Time = DirectCast(time, Date)
    End Sub
End Structure

Friend NotInheritable Class CookieClient
    Inherits WebClient

    Private Request As HttpWebRequest
    Public Cookies As New CookieContainer

    Protected Overrides Function GetWebRequest(ByVal address As Uri) As WebRequest
        Request = DirectCast(MyBase.GetWebRequest(address), HttpWebRequest)
        Request.Timeout = 8000
        Request.ReadWriteTimeout = 30000
        Request.KeepAlive = False
        Request.CookieContainer = Cookies
        Request.Proxy = Nothing
        Return Request
    End Function

    Sub ClearCookies()
        Cookies = New CookieContainer
    End Sub

End Class