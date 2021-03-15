Imports System.Windows.Forms

Public Class Dialog1
    Private Sub NsButton1_Click(sender As Object, e As EventArgs) Handles NsButton1.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        My.Settings.SVR = SERVER.Text
        My.Settings.Save()
        Me.Close()
    End Sub

    Private Sub NsButton2_Click(sender As Object, e As EventArgs) Handles NsButton2.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub
End Class
