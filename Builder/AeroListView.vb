Imports System.Runtime.InteropServices

Public Class AeroListView

    Inherits ListView

    <DllImport("uxtheme", CharSet:=CharSet.Unicode)> _
    Public Shared Function SetWindowTheme(ByVal hWnd As IntPtr, _
                                        ByVal textSubAppName As String, _
                                        ByVal textSubIdList As String) As Integer
    End Function

    Sub New()
        Me.DoubleBuffered = True
    End Sub

    Private Sub AreoListView_HandleCreated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.HandleCreated
        SetWindowTheme(Me.Handle, "explorer", Nothing)
    End Sub
End Class