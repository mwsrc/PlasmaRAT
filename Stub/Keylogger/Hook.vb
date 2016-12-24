Public Class KeyboardHook
    Private Const HC_ACTION As Integer = 0
    Private Const WH_KEYBOARD_LL As Integer = 13
    Private Const WM_KEYDOWN = &H100
    Private Const WM_KEYUP = &H101
    Private Const WM_SYSKEYDOWN = &H104
    Private Const WM_SYSKEYUP = &H105
    Private Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scancode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure
    Private Declare Function SetWindowsHookEx Lib "user32" _
    Alias "SetWindowsHookExA" _
    (ByVal idHook As Integer, _
    ByVal lpfn As KeyboardProcDelegate, _
    ByVal hmod As Integer, _
    ByVal dwThreadId As Integer) As Integer
    Private Declare Function CallNextHookEx Lib "user32" _
    (ByVal hHook As Integer, _
    ByVal nCode As Integer, _
    ByVal wParam As Integer, _
    ByVal lParam As KBDLLHOOKSTRUCT) As Integer
    Private Declare Function UnhookWindowsHookEx Lib "user32" _
    (ByVal hHook As Integer) As Integer
    Private Delegate Function KeyboardProcDelegate _
    (ByVal nCode As Integer, _
    ByVal wParam As Integer, _
    ByRef lParam As KBDLLHOOKSTRUCT) As Integer
    Public Shared Event KeyDown(ByVal Key As Keys)
    Public Shared Event KeyUp(ByVal Key As Keys)
    Private Shared KeyHook As Integer
    Private Shared KeyHookDelegate As KeyboardProcDelegate

    Public Sub Register()
        KeyHookDelegate = New KeyboardProcDelegate(AddressOf KeyboardProc)
        KeyHook = SetWindowsHookEx(WH_KEYBOARD_LL, KeyHookDelegate, System.Runtime.InteropServices.Marshal.GetHINSTANCE(System.Reflection.Assembly.GetExecutingAssembly.GetModules()(0)).ToInt32, 0)
    End Sub
    Private Shared Function KeyboardProc(ByVal nCode As Integer, ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) As Integer
        If (nCode = HC_ACTION) Then
            Select Case wParam
                Case WM_KEYDOWN, WM_SYSKEYDOWN
                    RaiseEvent KeyDown(CType(lParam.vkCode, Keys))
                Case WM_KEYUP, WM_SYSKEYUP
                    RaiseEvent KeyUp(CType(lParam.vkCode, Keys))
            End Select
        End If
        ''Next
        Return CallNextHookEx(KeyHook, nCode, wParam, lParam)
    End Function
End Class
