<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.BTNLaunch = New System.Windows.Forms.Button()
        Me.DDNMaps = New System.Windows.Forms.ComboBox()
        Me.GRPDefaultMaps = New System.Windows.Forms.GroupBox()
        Me.GRPCustomMaps = New System.Windows.Forms.GroupBox()
        Me.GRPFilter = New System.Windows.Forms.GroupBox()
        Me.FilterTxt = New System.Windows.Forms.TextBox()
        Me.LSTFilteredMapList = New System.Windows.Forms.ListBox()
        Me.GRPMapList = New System.Windows.Forms.GroupBox()
        Me.GRPOverrides = New System.Windows.Forms.GroupBox()
        Me.CHKSplitScreen = New System.Windows.Forms.CheckBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitWithPortal2ToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.bugreport = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableSplashScreenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VersionXXToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IMGLogo = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Portal2Location = New System.Windows.Forms.FolderBrowserDialog()
        Me.DeveloperLinkLabel = New System.Windows.Forms.LinkLabel()
        Me.CHKCustomOtherMaps = New System.Windows.Forms.CheckBox()
        Me.CHKCustomMPMaps = New System.Windows.Forms.CheckBox()
        Me.CHKCustomSoloMaps = New System.Windows.Forms.CheckBox()
        Me.CHKOtherMaps = New System.Windows.Forms.CheckBox()
        Me.CHKDLCMaps = New System.Windows.Forms.CheckBox()
        Me.CHKDefaultSoloMaps = New System.Windows.Forms.CheckBox()
        Me.CHKDefaultMPMaps = New System.Windows.Forms.CheckBox()
        Me.GRPDefaultMaps.SuspendLayout()
        Me.GRPCustomMaps.SuspendLayout()
        Me.GRPFilter.SuspendLayout()
        Me.GRPMapList.SuspendLayout()
        Me.GRPOverrides.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.IMGLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BTNLaunch
        '
        Me.BTNLaunch.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNLaunch.Location = New System.Drawing.Point(8, 475)
        Me.BTNLaunch.Name = "BTNLaunch"
        Me.BTNLaunch.Size = New System.Drawing.Size(413, 45)
        Me.BTNLaunch.TabIndex = 1
        Me.BTNLaunch.Text = "Launch Selected Map!"
        Me.ToolTip1.SetToolTip(Me.BTNLaunch, "Launch Map With Chosen Parameters And Map")
        Me.BTNLaunch.UseVisualStyleBackColor = True
        '
        'DDNMaps
        '
        Me.DDNMaps.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DDNMaps.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.DDNMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DDNMaps.FormattingEnabled = True
        Me.DDNMaps.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.DDNMaps.Location = New System.Drawing.Point(6, 19)
        Me.DDNMaps.MaxDropDownItems = 5
        Me.DDNMaps.Name = "DDNMaps"
        Me.DDNMaps.Size = New System.Drawing.Size(239, 21)
        Me.DDNMaps.Sorted = True
        Me.DDNMaps.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.DDNMaps, "Click For List Of All Maps In Selected Map Categories")
        '
        'GRPDefaultMaps
        '
        Me.GRPDefaultMaps.Controls.Add(Me.CHKOtherMaps)
        Me.GRPDefaultMaps.Controls.Add(Me.CHKDLCMaps)
        Me.GRPDefaultMaps.Controls.Add(Me.CHKDefaultSoloMaps)
        Me.GRPDefaultMaps.Controls.Add(Me.CHKDefaultMPMaps)
        Me.GRPDefaultMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRPDefaultMaps.Location = New System.Drawing.Point(11, 197)
        Me.GRPDefaultMaps.Name = "GRPDefaultMaps"
        Me.GRPDefaultMaps.Size = New System.Drawing.Size(248, 66)
        Me.GRPDefaultMaps.TabIndex = 8
        Me.GRPDefaultMaps.TabStop = False
        Me.GRPDefaultMaps.Text = "Official Maps"
        Me.ToolTip1.SetToolTip(Me.GRPDefaultMaps, "All Default And DLC Maps Are In This Group")
        '
        'GRPCustomMaps
        '
        Me.GRPCustomMaps.Controls.Add(Me.CHKCustomOtherMaps)
        Me.GRPCustomMaps.Controls.Add(Me.CHKCustomMPMaps)
        Me.GRPCustomMaps.Controls.Add(Me.CHKCustomSoloMaps)
        Me.GRPCustomMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRPCustomMaps.Location = New System.Drawing.Point(265, 197)
        Me.GRPCustomMaps.Name = "GRPCustomMaps"
        Me.GRPCustomMaps.Size = New System.Drawing.Size(156, 92)
        Me.GRPCustomMaps.TabIndex = 9
        Me.GRPCustomMaps.TabStop = False
        Me.GRPCustomMaps.Text = "Custom Maps"
        Me.ToolTip1.SetToolTip(Me.GRPCustomMaps, "All Custom Maps Are In This Group")
        '
        'GRPFilter
        '
        Me.GRPFilter.Controls.Add(Me.FilterTxt)
        Me.GRPFilter.Controls.Add(Me.LSTFilteredMapList)
        Me.GRPFilter.Location = New System.Drawing.Point(8, 321)
        Me.GRPFilter.Name = "GRPFilter"
        Me.GRPFilter.Size = New System.Drawing.Size(251, 152)
        Me.GRPFilter.TabIndex = 11
        Me.GRPFilter.TabStop = False
        Me.GRPFilter.Text = "Filter/Search"
        Me.ToolTip1.SetToolTip(Me.GRPFilter, "Filter The Maps In Selected Map Categories")
        '
        'FilterTxt
        '
        Me.FilterTxt.Location = New System.Drawing.Point(6, 17)
        Me.FilterTxt.Name = "FilterTxt"
        Me.FilterTxt.Size = New System.Drawing.Size(231, 20)
        Me.FilterTxt.TabIndex = 19
        '
        'LSTFilteredMapList
        '
        Me.LSTFilteredMapList.AllowDrop = True
        Me.LSTFilteredMapList.BackColor = System.Drawing.Color.White
        Me.LSTFilteredMapList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LSTFilteredMapList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSTFilteredMapList.FormattingEnabled = True
        Me.LSTFilteredMapList.Location = New System.Drawing.Point(6, 39)
        Me.LSTFilteredMapList.Name = "LSTFilteredMapList"
        Me.LSTFilteredMapList.Size = New System.Drawing.Size(231, 106)
        Me.LSTFilteredMapList.TabIndex = 19
        '
        'GRPMapList
        '
        Me.GRPMapList.Controls.Add(Me.DDNMaps)
        Me.GRPMapList.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GRPMapList.Location = New System.Drawing.Point(8, 267)
        Me.GRPMapList.Name = "GRPMapList"
        Me.GRPMapList.Size = New System.Drawing.Size(251, 48)
        Me.GRPMapList.TabIndex = 12
        Me.GRPMapList.TabStop = False
        Me.GRPMapList.Text = "Map List"
        Me.ToolTip1.SetToolTip(Me.GRPMapList, "Click For List Of All Maps In Selected Map Categories")
        '
        'GRPOverrides
        '
        Me.GRPOverrides.Controls.Add(Me.CHKSplitScreen)
        Me.GRPOverrides.Location = New System.Drawing.Point(265, 291)
        Me.GRPOverrides.Name = "GRPOverrides"
        Me.GRPOverrides.Size = New System.Drawing.Size(155, 46)
        Me.GRPOverrides.TabIndex = 13
        Me.GRPOverrides.TabStop = False
        Me.GRPOverrides.Text = "Extra Options"
        Me.ToolTip1.SetToolTip(Me.GRPOverrides, "Overide The Way Portal 2 Map Launcher Loads The Maps")
        '
        'CHKSplitScreen
        '
        Me.CHKSplitScreen.AutoSize = True
        Me.CHKSplitScreen.Location = New System.Drawing.Point(11, 19)
        Me.CHKSplitScreen.Name = "CHKSplitScreen"
        Me.CHKSplitScreen.Size = New System.Drawing.Size(110, 17)
        Me.CHKSplitScreen.TabIndex = 10
        Me.CHKSplitScreen.Text = "SplitScreen Mode"
        Me.ToolTip1.SetToolTip(Me.CHKSplitScreen, "Enables Splitscreen Via SS_MAP Console Command")
        Me.CHKSplitScreen.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem1, Me.HelpToolStripMenuItem, Me.DisableSplashScreenToolStripMenuItem, Me.VersionXXToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(431, 24)
        Me.MenuStrip1.TabIndex = 14
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem1
        '
        Me.FileToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ExitWithPortal2ToolStripMenuItem})
        Me.FileToolStripMenuItem1.Name = "FileToolStripMenuItem1"
        Me.FileToolStripMenuItem1.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem1.Text = "&File"
        Me.FileToolStripMenuItem1.ToolTipText = "Standard File Options"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem.Text = "E&xit"
        Me.ExitToolStripMenuItem.ToolTipText = "Exit Application"
        '
        'ExitWithPortal2ToolStripMenuItem
        '
        Me.ExitWithPortal2ToolStripMenuItem.Name = "ExitWithPortal2ToolStripMenuItem"
        Me.ExitWithPortal2ToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ExitWithPortal2ToolStripMenuItem.Text = "Exit Portal 2"
        Me.ExitWithPortal2ToolStripMenuItem.ToolTipText = "Exit Portal2"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ContentsToolStripMenuItem, Me.ToolStripSeparator1, Me.bugreport, Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ContentsToolStripMenuItem
        '
        Me.ContentsToolStripMenuItem.Name = "ContentsToolStripMenuItem"
        Me.ContentsToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.ContentsToolStripMenuItem.Text = "&Instructions"
        Me.ContentsToolStripMenuItem.ToolTipText = "Shows Instructions In New Window"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(219, 6)
        '
        'bugreport
        '
        Me.bugreport.Name = "bugreport"
        Me.bugreport.Size = New System.Drawing.Size(222, 22)
        Me.bugreport.Text = "Report Bug/Suggest Feature"
        Me.bugreport.ToolTipText = "Loads BugTracker Webpage In Default Browser"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.AboutToolStripMenuItem.Text = "&About..."
        Me.AboutToolStripMenuItem.ToolTipText = "Shows Information About Application"
        '
        'DisableSplashScreenToolStripMenuItem
        '
        Me.DisableSplashScreenToolStripMenuItem.Name = "DisableSplashScreenToolStripMenuItem"
        Me.DisableSplashScreenToolStripMenuItem.Size = New System.Drawing.Size(129, 20)
        Me.DisableSplashScreenToolStripMenuItem.Text = "Disable SplashScreen"
        '
        'VersionXXToolStripMenuItem
        '
        Me.VersionXXToolStripMenuItem.Margin = New System.Windows.Forms.Padding(120, 0, 0, 0)
        Me.VersionXXToolStripMenuItem.Name = "VersionXXToolStripMenuItem"
        Me.VersionXXToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.VersionXXToolStripMenuItem.Text = "Version X.X.X"
        Me.VersionXXToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'IMGLogo
        '
        Me.IMGLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IMGLogo.Image = CType(resources.GetObject("IMGLogo.Image"), System.Drawing.Image)
        Me.IMGLogo.Location = New System.Drawing.Point(4, 21)
        Me.IMGLogo.Name = "IMGLogo"
        Me.IMGLogo.Size = New System.Drawing.Size(424, 121)
        Me.IMGLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IMGLogo.TabIndex = 0
        Me.IMGLogo.TabStop = False
        Me.ToolTip1.SetToolTip(Me.IMGLogo, "Portal 2 Map Launcher Banner")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 13)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "Drap map(s) to the box below"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(5, 108)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 21)
        Me.Button2.TabIndex = 16
        Me.Button2.Text = "Open Map Directory"
        Me.ToolTip1.SetToolTip(Me.Button2, "Open Location Where Your Portal2 Maps Are Located")
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.AllowDrop = True
        Me.ListBox1.BackColor = System.Drawing.Color.White
        Me.ListBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 9
        Me.ListBox1.Location = New System.Drawing.Point(6, 35)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(145, 74)
        Me.ListBox1.TabIndex = 18
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(265, 340)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(155, 133)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Drag N Drop"
        Me.ToolTip1.SetToolTip(Me.GroupBox1, "Drag A Map Here And It Will Be Copied To Your Map Directory")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 146)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(405, 39)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = resources.GetString("Label2.Text")
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Portal2Location
        '
        Me.Portal2Location.ShowNewFolderButton = False
        '
        'DeveloperLinkLabel
        '
        Me.DeveloperLinkLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DeveloperLinkLabel.AutoSize = True
        Me.DeveloperLinkLabel.LinkArea = New System.Windows.Forms.LinkArea(11, 15)
        Me.DeveloperLinkLabel.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.DeveloperLinkLabel.Location = New System.Drawing.Point(281, 520)
        Me.DeveloperLinkLabel.Name = "DeveloperLinkLabel"
        Me.DeveloperLinkLabel.Size = New System.Drawing.Size(147, 17)
        Me.DeveloperLinkLabel.TabIndex = 24
        Me.DeveloperLinkLabel.TabStop = True
        Me.DeveloperLinkLabel.Text = "Created by ForgottenCoders"
        Me.DeveloperLinkLabel.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.DeveloperLinkLabel.UseCompatibleTextRendering = True
        '
        'CHKCustomOtherMaps
        '
        Me.CHKCustomOtherMaps.AutoSize = True
        Me.CHKCustomOtherMaps.Checked = Global.Portal_2_Map_Launcher.My.MySettings.Default.OtherCustomChk
        Me.CHKCustomOtherMaps.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Portal_2_Map_Launcher.My.MySettings.Default, "OtherCustomChk", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHKCustomOtherMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCustomOtherMaps.Location = New System.Drawing.Point(11, 66)
        Me.CHKCustomOtherMaps.Name = "CHKCustomOtherMaps"
        Me.CHKCustomOtherMaps.Size = New System.Drawing.Size(81, 17)
        Me.CHKCustomOtherMaps.TabIndex = 9
        Me.CHKCustomOtherMaps.Text = "Other Maps"
        Me.ToolTip1.SetToolTip(Me.CHKCustomOtherMaps, "Adds/Removes All Other Custom Maps To Array")
        Me.CHKCustomOtherMaps.UseVisualStyleBackColor = True
        '
        'CHKCustomMPMaps
        '
        Me.CHKCustomMPMaps.AutoSize = True
        Me.CHKCustomMPMaps.Checked = Global.Portal_2_Map_Launcher.My.MySettings.Default.CustomMPChk
        Me.CHKCustomMPMaps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKCustomMPMaps.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Portal_2_Map_Launcher.My.MySettings.Default, "CustomMPChk", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHKCustomMPMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCustomMPMaps.Location = New System.Drawing.Point(11, 42)
        Me.CHKCustomMPMaps.Name = "CHKCustomMPMaps"
        Me.CHKCustomMPMaps.Size = New System.Drawing.Size(105, 17)
        Me.CHKCustomMPMaps.TabIndex = 7
        Me.CHKCustomMPMaps.Text = "Multiplayer Maps"
        Me.ToolTip1.SetToolTip(Me.CHKCustomMPMaps, "Adds/Removes All Custom MP Maps To Array")
        Me.CHKCustomMPMaps.UseVisualStyleBackColor = True
        '
        'CHKCustomSoloMaps
        '
        Me.CHKCustomSoloMaps.AutoSize = True
        Me.CHKCustomSoloMaps.Checked = Global.Portal_2_Map_Launcher.My.MySettings.Default.CustomSPChk
        Me.CHKCustomSoloMaps.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CHKCustomSoloMaps.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Portal_2_Map_Launcher.My.MySettings.Default, "CustomSPChk", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHKCustomSoloMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKCustomSoloMaps.Location = New System.Drawing.Point(11, 19)
        Me.CHKCustomSoloMaps.Name = "CHKCustomSoloMaps"
        Me.CHKCustomSoloMaps.Size = New System.Drawing.Size(112, 17)
        Me.CHKCustomSoloMaps.TabIndex = 5
        Me.CHKCustomSoloMaps.Text = "Singleplayer Maps"
        Me.ToolTip1.SetToolTip(Me.CHKCustomSoloMaps, "Adds/Removes All Custom SP Maps To Array")
        Me.CHKCustomSoloMaps.UseVisualStyleBackColor = True
        '
        'CHKOtherMaps
        '
        Me.CHKOtherMaps.AutoSize = True
        Me.CHKOtherMaps.Checked = Global.Portal_2_Map_Launcher.My.MySettings.Default.OtherChk
        Me.CHKOtherMaps.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Portal_2_Map_Launcher.My.MySettings.Default, "OtherChk", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHKOtherMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKOtherMaps.Location = New System.Drawing.Point(126, 42)
        Me.CHKOtherMaps.Name = "CHKOtherMaps"
        Me.CHKOtherMaps.Size = New System.Drawing.Size(81, 17)
        Me.CHKOtherMaps.TabIndex = 8
        Me.CHKOtherMaps.Text = "Other Maps"
        Me.ToolTip1.SetToolTip(Me.CHKOtherMaps, "Adds/Removes All Other Official Maps To Array")
        Me.CHKOtherMaps.UseVisualStyleBackColor = True
        '
        'CHKDLCMaps
        '
        Me.CHKDLCMaps.AutoSize = True
        Me.CHKDLCMaps.Checked = Global.Portal_2_Map_Launcher.My.MySettings.Default.DLCChk
        Me.CHKDLCMaps.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Portal_2_Map_Launcher.My.MySettings.Default, "DLCChk", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHKDLCMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKDLCMaps.Location = New System.Drawing.Point(126, 19)
        Me.CHKDLCMaps.Name = "CHKDLCMaps"
        Me.CHKDLCMaps.Size = New System.Drawing.Size(116, 17)
        Me.CHKDLCMaps.TabIndex = 7
        Me.CHKDLCMaps.Text = "Peer Review Maps"
        Me.ToolTip1.SetToolTip(Me.CHKDLCMaps, "Adds/Removes Peer Review DLC Maps To Array")
        Me.CHKDLCMaps.UseVisualStyleBackColor = True
        '
        'CHKDefaultSoloMaps
        '
        Me.CHKDefaultSoloMaps.AutoSize = True
        Me.CHKDefaultSoloMaps.Checked = Global.Portal_2_Map_Launcher.My.MySettings.Default.StockSPChk
        Me.CHKDefaultSoloMaps.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Portal_2_Map_Launcher.My.MySettings.Default, "StockSPChk", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHKDefaultSoloMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKDefaultSoloMaps.Location = New System.Drawing.Point(8, 19)
        Me.CHKDefaultSoloMaps.Name = "CHKDefaultSoloMaps"
        Me.CHKDefaultSoloMaps.Size = New System.Drawing.Size(112, 17)
        Me.CHKDefaultSoloMaps.TabIndex = 5
        Me.CHKDefaultSoloMaps.Text = "Singleplayer Maps"
        Me.ToolTip1.SetToolTip(Me.CHKDefaultSoloMaps, "Adds/Removes All Stock SP Maps To Array")
        Me.CHKDefaultSoloMaps.UseVisualStyleBackColor = True
        '
        'CHKDefaultMPMaps
        '
        Me.CHKDefaultMPMaps.AutoSize = True
        Me.CHKDefaultMPMaps.Checked = Global.Portal_2_Map_Launcher.My.MySettings.Default.StockMPChk
        Me.CHKDefaultMPMaps.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Global.Portal_2_Map_Launcher.My.MySettings.Default, "StockMPChk", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.CHKDefaultMPMaps.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHKDefaultMPMaps.Location = New System.Drawing.Point(8, 42)
        Me.CHKDefaultMPMaps.Name = "CHKDefaultMPMaps"
        Me.CHKDefaultMPMaps.Size = New System.Drawing.Size(105, 17)
        Me.CHKDefaultMPMaps.TabIndex = 6
        Me.CHKDefaultMPMaps.Text = "Multiplayer Maps"
        Me.ToolTip1.SetToolTip(Me.CHKDefaultMPMaps, "Adds/Removes All Stock MP Maps To Array")
        Me.CHKDefaultMPMaps.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(431, 539)
        Me.Controls.Add(Me.DeveloperLinkLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GRPOverrides)
        Me.Controls.Add(Me.GRPFilter)
        Me.Controls.Add(Me.GRPMapList)
        Me.Controls.Add(Me.GRPCustomMaps)
        Me.Controls.Add(Me.GRPDefaultMaps)
        Me.Controls.Add(Me.BTNLaunch)
        Me.Controls.Add(Me.IMGLogo)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Portal 2 Map Launcher"
        Me.GRPDefaultMaps.ResumeLayout(False)
        Me.GRPDefaultMaps.PerformLayout()
        Me.GRPCustomMaps.ResumeLayout(False)
        Me.GRPCustomMaps.PerformLayout()
        Me.GRPFilter.ResumeLayout(False)
        Me.GRPFilter.PerformLayout()
        Me.GRPMapList.ResumeLayout(False)
        Me.GRPOverrides.ResumeLayout(False)
        Me.GRPOverrides.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.IMGLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNLaunch As System.Windows.Forms.Button
    Friend WithEvents DDNMaps As System.Windows.Forms.ComboBox
    Friend WithEvents CHKDefaultSoloMaps As System.Windows.Forms.CheckBox
    Friend WithEvents CHKDefaultMPMaps As System.Windows.Forms.CheckBox
    Friend WithEvents GRPDefaultMaps As System.Windows.Forms.GroupBox
    Friend WithEvents GRPCustomMaps As System.Windows.Forms.GroupBox
    Friend WithEvents CHKCustomMPMaps As System.Windows.Forms.CheckBox
    Friend WithEvents CHKCustomSoloMaps As System.Windows.Forms.CheckBox
    Friend WithEvents CHKDLCMaps As System.Windows.Forms.CheckBox
    Friend WithEvents GRPFilter As System.Windows.Forms.GroupBox
    Friend WithEvents GRPMapList As System.Windows.Forms.GroupBox
    Friend WithEvents GRPOverrides As System.Windows.Forms.GroupBox
    Friend WithEvents CHKSplitScreen As System.Windows.Forms.CheckBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ContentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents IMGLogo As System.Windows.Forms.PictureBox
    Friend WithEvents ExitWithPortal2ToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DisableSplashScreenToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VersionXXToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bugreport As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents LSTFilteredMapList As System.Windows.Forms.ListBox
    Friend WithEvents FilterTxt As System.Windows.Forms.TextBox
    Friend WithEvents Portal2Location As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents CHKOtherMaps As System.Windows.Forms.CheckBox
    Friend WithEvents DeveloperLinkLabel As System.Windows.Forms.LinkLabel
    Friend WithEvents CHKCustomOtherMaps As System.Windows.Forms.CheckBox

End Class
