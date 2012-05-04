'###############################################################################################
'#                                                                                             #
'#                     Portal 2 Map Launcher v1.5 Created by ForgottenCoders.                  #
'#                                                                                             #
'###############################################################################################
Imports Microsoft.Win32

Public Class Home
    Private Declare Function GetAsyncKeyState Lib "user32" (ByVal vkey As Long) As Integer 'used for global keybinds
    Dim REGLocation As String, REGLocation1 As String, REGMapLocation As String, REGDLCMAPlocation As String
    Dim ARYOtherMaps As New List(Of String), ARYCustomMPMaps As New List(Of String), ARYCustomSPMaps As New List(Of String), mapname As String
    Dim ARYAllMaps As New List(Of String), mapcmd As String, diar1 As IO.FileInfo(), hotkey As Boolean, noclipp1 As Boolean, noclipp2 As Boolean, svcheats As Boolean
    Dim defaultparameters As String = "-windowed -noborder -console -novid +gameui_hide "
    Dim ARYStockSPMaps() As String = {
    "sp_a1_intro1.bsp", "sp_a1_intro2.bsp", "sp_a1_intro3.bsp", "sp_a1_intro4.bsp", "sp_a1_intro5.bsp", "sp_a1_intro6.bsp", "sp_a1_intro7.bsp",
    "sp_a1_wakeup.bsp", "sp_a2_bridge_intro.bsp", "sp_a2_bridge_the_gap.bsp", "sp_a2_bts1.bsp", "sp_a2_bts2.bsp", "sp_a2_bts3.bsp", "sp_a2_bts4.bsp", "sp_a2_bts5.bsp", "sp_a2_bts6.bsp", "sp_a2_catapult_intro.bsp", "sp_a2_column_blocker.bsp",
    "sp_a2_core.bsp", "sp_a2_dual_lasers.bsp", "sp_a2_fizzler_intro.bsp", "sp_a2_intro.bsp", "sp_a2_laser_chaining.bsp", "sp_a2_laser_intro.bsp", "sp_a2_laser_over_goo.bsp", "sp_a2_laser_relays.bsp", "sp_a2_laser_stairs.bsp",
    "sp_a2_laser_vs_turret.bsp", "sp_a2_pit_flings.bsp", "sp_a2_pull_the_rug.bsp", "sp_a2_ricochet.bsp", "sp_a2_sphere_peek.bsp", "sp_a2_triple_laser.bsp", "sp_a2_trust_fling.bsp", "sp_a2_turret_blocker.bsp", "sp_a2_turret_intro.bsp",
    "sp_a3_00.bsp", "sp_a3_01.bsp", "sp_a3_03.bsp", "sp_a3_bomb_flings.bsp", "sp_a3_crazy_box.bsp", "sp_a3_end.bsp", "sp_a3_jump_intro.bsp", "sp_a3_portal_intro.bsp", "sp_a3_speed_flings.bsp", "sp_a3_speed_ramp.bsp",
    "sp_a3_transition01.bsp", "sp_a4_finale1.bsp", "sp_a4_finale2.bsp", "sp_a4_finale3.bsp", "sp_a4_finale4.bsp", "sp_a4_intro.bsp", "sp_a4_jump_polarity.bsp", "sp_a4_laser_catapult.bsp", "sp_a4_laser_platform.bsp",
    "sp_a4_speed_tb_catch.bsp", "sp_a4_stop_the_box.bsp", "sp_a4_tb_catch.bsp", "sp_a4_tb_intro.bsp", "sp_a4_tb_polarity.bsp", "sp_a4_tb_trust_drop.bsp", "sp_a4_tb_wall_button.bsp", "sp_a5_credits.bsp"
    }
    Dim ARYStockMPMaps() As String = {
    "mp_coop_catapult_1.bsp", "mp_coop_catapult_2.bsp", "mp_coop_catapult_wall_intro.bsp", "mp_coop_come_along.bsp", "mp_coop_credits.bsp", "mp_coop_doors.bsp", "mp_coop_fan.bsp",
    "mp_coop_fling_1.bsp", "mp_coop_fling_3.bsp", "mp_coop_fling_crushers.bsp", "mp_coop_infinifling_train.bsp", "mp_coop_laser_2.bsp", "mp_coop_laser_crusher.bsp", "mp_coop_lobby_2.bsp", "mp_coop_multifling_1.bsp", "mp_coop_paint_bridge.bsp",
    "mp_coop_paint_come_along.bsp", "mp_coop_paint_longjump_intro.bsp", "mp_coop_paint_red_racer.bsp", "mp_coop_paint_redirect.bsp", "mp_coop_paint_speed_catch.bsp", "mp_coop_paint_speed_fling.bsp", "mp_coop_paint_walljumps.bsp", "mp_coop_race_2.bsp",
    "mp_coop_rat_maze.bsp", "mp_coop_start.bsp", "mp_coop_tbeam_catch_grind_1.bsp", "mp_coop_tbeam_drill.bsp", "mp_coop_tbeam_end.bsp", "mp_coop_tbeam_laser_1.bsp", "mp_coop_tbeam_maze.bsp", "mp_coop_tbeam_polarity.bsp", "mp_coop_tbeam_polarity2.bsp",
    "mp_coop_tbeam_polarity3.bsp", "mp_coop_tbeam_redirect.bsp", "mp_coop_teambts.bsp", "mp_coop_turret_ball.bsp", "mp_coop_turret_walls.bsp", "mp_coop_wall_2.bsp", "mp_coop_wall_5.bsp", "mp_coop_wall_block.bsp", "mp_coop_wall_intro.bsp"
    }
    Dim ARYDLCMaps() As String = {
    "mp_coop_2paints_1bridge.bsp", "mp_coop_bridge_catch.bsp", "mp_coop_catapult_catch.bsp", "mp_coop_laser_tbeam.bsp",
    "mp_coop_lobby_3.bsp", "mp_coop_paint_conversion.bsp", "mp_coop_paint_crazy_box.bsp", "mp_coop_paint_rat_maze.bsp", "mp_coop_separation_1.bsp", "mp_coop_tripleaxis.bsp"
    }
    Dim ARYOtherFiles() As String = {
    "aa1.bsp", "aa1a.bsp", "aa2.bsp", "aa3.bsp", "ab1.bsp", "ab12.bsp", "background1.bsp", "bb1.bsp", "bb2.bsp",
    "borealis1.bsp", "borealis2.bsp", "borealis3.bsp", "borealis4.bsp", "borealis5.bsp", "cc1.bsp", "cc2.bsp", "e1912.bsp"
    }
    Dim serverkilled As Boolean
    Dim lastmapaccess As Date

    Private Sub Home_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If My.Settings.disablesplash = True Then
            DisableSplashScreenToolStripMenuItem.Text = "Enable SplashScreen"
        Else
            DisableSplashScreenToolStripMenuItem.Text = "Disable SplashScreen"
        End If
        About.Close()
        Splash.Close()
        Splash.TMRSplash.Stop()
        If My.Settings.p2location = "" Or Not My.Computer.FileSystem.FileExists(My.Settings.p2location + "\portal2.exe") Then
            If My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\Applications\portal2.exe\shell\open\command", "", Nothing) Is Nothing Then
                MsgBox("ERROR: Portal 2 could not be detected" & vbNewLine & "Please manually select your portal2.exe", MsgBoxStyle.Critical, "Portal2.exe Not Found")
                Portal2Location.ShowDialog()
                My.Settings.p2location = Portal2Location.SelectedPath.ToString
                My.Settings.Save()
                Application.Restart()
            Else
                REGLocation = My.Computer.Registry.GetValue("HKEY_CLASSES_ROOT\Applications\portal2.exe\shell\open\command", "", Nothing)
                REGLocation1 = REGLocation.Replace("\portal2.exe" + Chr(34) + " " + Chr(34) + "%1" + Chr(34), "")
                REGLocation = REGLocation1.Remove(0, 1)
                My.Settings.p2location = REGLocation
            End If
        End If
        REGLocation = My.Settings.p2location
        REGMapLocation = REGLocation + "\portal2\maps"
        REGDLCMAPlocation = REGLocation + "\portal2_dlc1\maps"
        Dim di As New IO.DirectoryInfo(REGMapLocation)
        diar1 = di.GetFiles("*.bsp")
        Timer1.Start()
        VersionXXToolStripMenuItem.Text = "Version " + My.Application.Info.Version.Major.ToString + "." + My.Application.Info.Version.Minor.ToString
        lastmapaccess = IO.File.GetLastAccessTime(REGMapLocation)
    End Sub

    Private Sub BTNLaunch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BTNLaunch.Click
        If ListBox2.SelectedItem = Nothing Then
            mapname = DDNMaps.SelectedItem.ToString.Replace(".bsp", "")
        Else
            mapname = ListBox2.SelectedItem.ToString.Replace(".bsp", "")
        End If
        If mapname.Contains("sp_") Then
            P2Hijacker(defaultparameters + "+map", mapname)
        ElseIf mapname.Contains("mp_coop_") Then
            If IsProcessRunning("portal2") = True Then
                If serverkilled = True Then
                    If CHKSplitScreen.Checked = True Then
                        P2Hijacker(defaultparameters + "+ss_map", mapname)
                    Else
                        P2Hijacker(defaultparameters + "+map", mapname)
                    End If
                    serverkilled = False
                Else
                    P2Hijacker(defaultparameters + "+changelevel", mapname)
                End If


            ElseIf CHKSplitScreen.Checked = True Then
                P2Hijacker(defaultparameters + "ss_map", mapname)
            Else
                P2Hijacker(defaultparameters + "+map", mapname)
            End If

        End If
        Me.WindowState = FormWindowState.Minimized
    End Sub


    Public Sub P2Hijacker(Optional ByVal parameter As String = "", Optional ByVal mapname As String = "")
        Shell(Chr(34) + REGLocation + "\portal2.exe " + Chr(34) + "-hijack " & parameter + " " + mapname)
    End Sub
    Public Sub AddMapToList(ByVal text As Array)
        For Each line In text
            DDNMaps.Items.Add(line)
        Next
    End Sub
    Public Sub RemoveMapFromList(ByVal text As Array)
        For Each line In text
            DDNMaps.Items.Remove(line)
        Next
    End Sub


    Private Sub DDNMaps_MouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles DDNMaps.MouseClick
        DDNMaps.Items.Clear()
        MapListGenerator()
        RemoveDuplicates(DDNMaps)
        ListBox2.Items.Clear()
    End Sub

    Public Sub MapListGenerator()

        If CHKDefaultSoloMaps.Checked = True Then
            AddMapToList(ARYStockSPMaps)
        End If

        If CHKDefaultMPMaps.Checked = True Then
            AddMapToList(ARYStockMPMaps)
        End If

        If CHKDLCMaps.Checked = True Then
            AddMapToList(ARYDLCMaps)
        End If

        If CHKCustomSoloMaps.Checked = True Then
            For Each file In diar1
                If file.ToString.Contains("sp_") Then
                    DDNMaps.Items.Add(file.ToString)
                    ARYCustomSPMaps.Add(file.ToString)
                    If CHKDefaultSoloMaps.Checked = False Then
                        RemoveMapFromList(ARYStockSPMaps)
                    End If
                Else
                End If
            Next
        End If

        If CHKCustomMPMaps.Checked = True Then
            For Each file In diar1
                If file.ToString.Contains("mp_coop_") Then
                    ARYCustomMPMaps.Add(file.ToString)
                    DDNMaps.Items.Add(file.ToString)
                    If CHKDefaultMPMaps.Checked = False Then
                        RemoveMapFromList(ARYStockMPMaps)
                    End If
                Else
                End If
            Next
        End If
    End Sub

    'the public function for checking if process running.

    Public Function IsProcessRunning(ByVal name As String) As Boolean
        For Each clsProcess As Process In Process.GetProcesses()
            If clsProcess.ProcessName.StartsWith(name) Then
                Return True
            End If
        Next
        Return False
    End Function
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        hotkey = GetAsyncKeyState(Keys.F10) 'keys.f2 can be changed to any other key to change hotkey.
        If IsProcessRunning("portal2") = True Then
            If hotkey = True Then
                P2Hijacker("+hideconsole +gameui_activate")
                P2Hijacker("+hideconsole")
                P2Hijacker("+minimize")
                Me.Focus()
                Me.BringToFront()
                Me.WindowState = FormWindowState.Normal
            End If
        End If
        If Not IO.File.GetLastAccessTime(REGMapLocation) = lastmapaccess Then
            Dim di As New IO.DirectoryInfo(REGMapLocation)
            diar1 = di.GetFiles("*.bsp")
            ListBox2.Items.Clear()
            DDNMaps.Items.Clear()
            MapListGenerator()
            lastmapaccess = IO.File.GetLastAccessTime(REGMapLocation)
        End If
    End Sub
    'closes the program
    Private Sub ExitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem.Click
        Application.Exit()
    End Sub
    'shows the about box
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        About.Show()
    End Sub
    'taskkills portal2.exe
    Private Sub ExitWithPortal2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitWithPortal2ToolStripMenuItem.Click
        Shell("taskkill /f /im portal2.exe", vbHide)
    End Sub
    'check if you playing in splitscreen or in network.
    Private Sub CHKSplitScreen_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CHKSplitScreen.CheckedChanged
        If IsProcessRunning("portal2") = True Then
            P2Hijacker("+killserver")
            serverkilled = True
        End If
    End Sub
    'show instructions.
    Private Sub ContentsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ContentsToolStripMenuItem.Click
        Instructions.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Process.Start("explorer.exe", REGMapLocation)
    End Sub

    Private Sub ListBox1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.All
        End If
    End Sub

    Private Sub ListBox1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles ListBox1.DragDrop
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            Dim MyFiles() As String, i As Integer
            MyFiles = e.Data.GetData(DataFormats.FileDrop)
            For i = 0 To MyFiles.Length - 1
                If MyFiles(i).Contains(".bsp") Then
                    Try
                        IO.File.Copy(MyFiles(i), REGMapLocation & "\" & IO.Path.GetFileName(MyFiles(i)), True)
                    Catch IOException As Exception
                        MsgBox("A error occured while copying the file, please try again" + vbNewLine + IOException.ToString)
                    End Try
                Else
                    MsgBox("File Is Not A Valid '.bsp' File")
                End If
            Next
        End If
    End Sub

    Private Sub DisableSplashScreenToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DisableSplashScreenToolStripMenuItem.Click
        If My.Settings.disablesplash = False Then
            My.Settings.disablesplash = True
            DisableSplashScreenToolStripMenuItem.Text = "Enable SplashScreen"
            MsgBox("SplashScreen Disabled")
        Else
            My.Settings.disablesplash = False
            DisableSplashScreenToolStripMenuItem.Text = "Disable SplashScreen"
            MsgBox("SplashScreen Enabled")
        End If
        My.Settings.Save()
    End Sub

    Private Sub bugreport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bugreport.Click
        Process.Start("http://tracker.forgottencoders.co.uk/projects/p2map")
    End Sub

    Private Sub VersionXXToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VersionXXToolStripMenuItem.Click
        changelog.Show()
    End Sub

    Public Sub RemoveDuplicates(ByVal combobox)
        For i As Int16 = 0 To combobox.Items.Count - 2
            For j As Int16 = combobox.Items.Count - 1 To i + 1 Step -1
                If combobox.Items(i).ToString = combobox.Items(j).ToString Then
                    combobox.Items.RemoveAt(j)
                End If
            Next
        Next
    End Sub


    Private Sub FilterTxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterTxt.TextChanged
        If FilterTxt.Text = "" Then
            ListBox2.Items.Clear()
        Else
            For Each line In DDNMaps.Items
                If line.ToString.Contains(filtertxt.Text) Then
                    ListBox2.Items.Add(line)
                Else
                    ListBox2.Items.Remove(line)
                End If
            Next
            RemoveDuplicates(ListBox2)
        End If
    End Sub

    Private Sub FilterTxt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilterTxt.Click
        MapListGenerator()
    End Sub

    Private Sub Home_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        My.Settings.Save()
    End Sub
End Class