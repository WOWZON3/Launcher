Imports System.IO
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tb_UserPass.Text = My.Settings.UserPass
        NsCheckBox1.Checked = My.Settings.AutoLogin
        Dialog1.SERVER.Text = My.Settings.SVR
        Try

            If My.Computer.Network.Ping("logon-worldofwarcry.sytes.net", 3724) Then
                Label7.ForeColor = Color.Lime
                Label7.Text = "Online"
            Else
                Label7.ForeColor = Color.Firebrick
                Label7.Text = "Offline"
            End If
        Catch ex As Exception
        End Try

        Try
            If My.Computer.Network.Ping("logon-worldofwarcry.sytes.net", 8085) Then
                Label8.ForeColor = Color.Lime
                Label8.Text = "Online"
            Else
                Label8.ForeColor = Color.Firebrick
                Label8.Text = "Offline"
            End If
        Catch ex As Exception

        End Try
        WMP.settings.volume = 100
        Try
            Dim InfoText As String = My.Computer.FileSystem.ReadAllText(".\Logs" & "\Information.dat")
            Label4.Text = InfoText
            Dim dateiinhalt As String = My.Computer.FileSystem.ReadAllText(".\Data\deDE" & "\realmlist.wtf")
            NsTextBox1.Text = dateiinhalt.Replace("set realmlist ", "")
        Catch ex As Exception

        End Try
        Try
            For Each a As String In IO.Directory.GetDirectories(My.Computer.FileSystem.CurrentDirectory & "\Interface\AddOns\")
                Dim fi As New IO.FileInfo(a)
                ListBox1.Items.Add(fi.Name)
            Next
            For Each b As String In IO.Directory.GetFiles(My.Computer.FileSystem.CurrentDirectory & "\Data\Soundtrack\")
                Dim fi As New IO.FileInfo(b)
                ListBox2.Items.Add(fi.Name)
            Next
            For Each c As String In IO.Directory.GetFiles(My.Computer.FileSystem.CurrentDirectory & "\Screenshots\")
                Dim fi As New IO.FileInfo(c)
                ListBox3.Items.Add(fi.Name)
            Next
        Catch ex As Exception

        End Try

    End Sub

    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        Try
            Dim Writer As New StreamWriter(".\Data\deDE" & "\realmlist.wtf", False)
            Writer.Write("set realmlist " & NsTextBox1.Text)
            Writer.Close()
        Catch ex As Exception
            MsgBox("Fehler! " & ex.Message)
        End Try
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        Try
            Dim myTempPath As String = ".\Cache\WDB\deDE"
            System.IO.Directory.Delete(myTempPath, True)
            Label1.Visible = True
            Timer1.Start()
        Catch ex As Exception
            MsgBox("Das gewählte Verzeichnis ist leer und muss deshalb nicht geleert werden.")
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Visible = False
        Timer1.Stop()
    End Sub

    Private Sub NsButton3_Click(sender As Object, e As EventArgs) Handles NsButton3.Click
        If MessageBox.Show("Sollen die Einstellungen des Spiels wirklich gelöscht werden? Dies kann anschließend nicht mehr rückgängig gemacht werden.", "Konfigurationsdateien des Spiels löschen?", MessageBoxButtons.YesNo) _
             = Windows.Forms.DialogResult.Yes Then
            Try
                Dim myTempPath As String = ".\WTF"
                System.IO.Directory.Delete(myTempPath, True)
                Label2.Visible = True
                Timer2.Start()
            Catch ex As Exception
                MsgBox("Das gewählte Verzeichnis ist leer und muss deshalb nicht geleert werden.")
            End Try
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Visible = False
        My.Computer.FileSystem.CreateDirectory("WTF")
        Timer2.Stop()
    End Sub

    Private Sub NsButton4_Click(sender As Object, e As EventArgs) Handles NsButton4.Click
        Try
            Process.Start(lbl_AddOn.Text)
        Catch ex As Exception
            MsgBox("Fehler! " & ex.Message)
        End Try
    End Sub

    Private Sub NsButton5_Click(sender As Object, e As EventArgs) Handles NsButton5.Click
        If My.Computer.FileSystem.DirectoryExists(My.Computer.FileSystem.CurrentDirectory & "\BackUps\") = True Then
            Try
                My.Computer.FileSystem.CopyDirectory(My.Computer.FileSystem.CurrentDirectory & "\Interface\AddOns\" & lbl_AddOn.Text, My.Computer.FileSystem.CurrentDirectory & "\BackUps\" & lbl_AddOn.Text)
            Catch ex As Exception
                MsgBox("Fehler! " & ex.Message)
            End Try
        Else
            Try
                My.Computer.FileSystem.CreateDirectory(My.Computer.FileSystem.CurrentDirectory & "\BackUps\")
                My.Computer.FileSystem.CopyDirectory(My.Computer.FileSystem.CurrentDirectory & "\Interface\AddOns\" & lbl_AddOn.Text, My.Computer.FileSystem.CurrentDirectory & "\BackUps\" & lbl_AddOn.Text)
            Catch ex As Exception
                MsgBox("Fehler! " & ex.Message)
            End Try
        End If
        ListBox1.Items.Clear()
        For Each a As String In IO.Directory.GetDirectories(My.Computer.FileSystem.CurrentDirectory & "\Interface\AddOns\")
            Dim fi As New IO.FileInfo(a)
            ListBox1.Items.Add(fi.Name)
        Next
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        lbl_AddOn.Text = ListBox1.SelectedItem
    End Sub

    Private Sub NsButton6_Click(sender As Object, e As EventArgs) Handles NsButton6.Click
        Try
            My.Computer.FileSystem.DeleteDirectory(".\Interface\AddOns\" & lbl_AddOn.Text, False)
        Catch ex As Exception
            MsgBox("Fehler! " & ex.Message)
        End Try
        ListBox1.Items.Clear()
        For Each a As String In IO.Directory.GetDirectories(My.Computer.FileSystem.CurrentDirectory & "\Interface\AddOns\")
            Dim fi As New IO.FileInfo(a)
            ListBox1.Items.Add(fi.Name)
        Next
    End Sub

    Private Sub NsButton7_Click(sender As Object, e As EventArgs) Handles NsButton7.Click
        NsButton7.Visible = False
        NsButton9.Visible = True
        WMP.URL = My.Computer.FileSystem.CurrentDirectory & "\Data\Soundtrack\" & ListBox2.SelectedItem
        WMP.Ctlcontrols.play()
    End Sub

    Private Sub NsButton9_Click(sender As Object, e As EventArgs) Handles NsButton9.Click
        NsButton9.Visible = False
        NsButton7.Visible = True
        WMP.Ctlcontrols.pause()
    End Sub

    Private Sub NsButton8_Click(sender As Object, e As EventArgs) Handles NsButton8.Click
        NsButton9.Visible = False
        NsButton7.Visible = True
        WMP.Ctlcontrols.pause()
        WMP.currentPlaylist.clear()
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox2.SelectedIndexChanged
        Label3.Text = My.Computer.FileSystem.CurrentDirectory & "\Data\Soundtrack\" & ListBox2.SelectedItem
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        WMP.settings.volume = TrackBar1.Value
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_Play1.Click
        Try
            Process.Start("WoW.exe")
            Me.Close()
        Catch ex As Exception
            MsgBox("Fehler! " & ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub NsCheckBox1_CheckedChanged(sender As Object) Handles NsCheckBox1.CheckedChanged
        If NsCheckBox1.Checked = True Then
            gb_AU.Enabled = True
            btn_Play1.Visible = False
            btn_Play2.Visible = True
        Else
            gb_AU.Enabled = False
            btn_Play1.Visible = True
            btn_Play2.Visible = False
        End If
        My.Settings.AutoLogin = NsCheckBox1.Checked
        My.Settings.Save()
    End Sub

    Private Sub tb_UserPass_TextChanged(sender As Object, e As EventArgs) Handles tb_UserPass.TextChanged
        My.Settings.UserPass = tb_UserPass.Text
        My.Settings.Save()
    End Sub

    Private Sub btn_Play2_Click(sender As Object, e As EventArgs) Handles btn_Play2.Click
        OUT.Text = TextBox1.Text.Replace("%PASS%", tb_UserPass.Text)
        Try
            Dim Writer As New StreamWriter(My.Computer.FileSystem.CurrentDirectory & "\Logs\tmp.vbs", False)
            Writer.Write(OUT.Text)
            Writer.Close()
            Process.Start(My.Computer.FileSystem.CurrentDirectory & "\Logs\tmp.vbs")
            Timer3.Start()
            Me.Close()
        Catch ex As Exception
            MsgBox("Fehler! " & ex.Message)
        End Try
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Try
            My.Computer.FileSystem.DeleteFile(My.Computer.FileSystem.CurrentDirectory & "\Logs\tmp.vbs")
            Timer3.Stop()
        Catch ex As Exception
            Timer3.Stop()
        End Try
    End Sub

    Private Sub ListBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox3.SelectedIndexChanged
        Try
            PictureBox3.Load(My.Computer.FileSystem.CurrentDirectory & "\Screenshots\" & ListBox3.SelectedItem)
        Catch ex As Exception
            MsgBox("Fehler! " & ex.Message)
        End Try
    End Sub

    Private Sub NsButton11_Click(sender As Object, e As EventArgs) Handles NsButton11.Click
        Try
            ListBox3.SelectedIndex = ListBox3.SelectedIndex - 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NsButton10_Click(sender As Object, e As EventArgs) Handles NsButton10.Click
        Try
            ListBox3.SelectedIndex = ListBox3.SelectedIndex + 1
        Catch ex As Exception

        End Try
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("http://" & Dialog1.SERVER.Text & "/wow/register")
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Process.Start("http://" & Dialog1.SERVER.Text & "/wow/store")
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        Process.Start("http://" & Dialog1.SERVER.Text & "/wow/ucp")
    End Sub

    Private Sub LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel4.LinkClicked
        Process.Start("http://" & Dialog1.SERVER.Text & "/wow/board/")
    End Sub

    Private Sub NsButton12_Click(sender As Object, e As EventArgs) Handles NsButton12.Click
        Dialog1.ShowDialog()
    End Sub
End Class
