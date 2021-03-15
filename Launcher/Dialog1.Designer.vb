<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dialog1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SERVER = New Launcher.TxtBox()
        Me.NsButton1 = New Launcher.NSButton()
        Me.NsButton2 = New Launcher.NSButton()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Server Adresse:"
        '
        'SERVER
        '
        Me.SERVER.BackColor = System.Drawing.Color.White
        Me.SERVER.ForeColor = System.Drawing.Color.Black
        Me.SERVER.Image = Nothing
        Me.SERVER.Location = New System.Drawing.Point(29, 57)
        Me.SERVER.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SERVER.MaxLength = 32767
        Me.SERVER.Name = "SERVER"
        Me.SERVER.NoRounding = False
        Me.SERVER.Size = New System.Drawing.Size(363, 31)
        Me.SERVER.TabIndex = 2
        Me.SERVER.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left
        Me.SERVER.UseSystemPasswordChar = False
        '
        'NsButton1
        '
        Me.NsButton1.Location = New System.Drawing.Point(196, 119)
        Me.NsButton1.Name = "NsButton1"
        Me.NsButton1.Size = New System.Drawing.Size(95, 38)
        Me.NsButton1.TabIndex = 3
        Me.NsButton1.Text = "    Speichern"
        '
        'NsButton2
        '
        Me.NsButton2.Location = New System.Drawing.Point(297, 119)
        Me.NsButton2.Name = "NsButton2"
        Me.NsButton2.Size = New System.Drawing.Size(95, 38)
        Me.NsButton2.TabIndex = 4
        Me.NsButton2.Text = "   Abbrechen"
        '
        'Dialog1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(421, 184)
        Me.Controls.Add(Me.NsButton2)
        Me.Controls.Add(Me.NsButton1)
        Me.Controls.Add(Me.SERVER)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Franklin Gothic Book", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Silver
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Dialog1"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Dialog1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents SERVER As TxtBox
    Friend WithEvents NsButton1 As NSButton
    Friend WithEvents NsButton2 As NSButton
End Class
