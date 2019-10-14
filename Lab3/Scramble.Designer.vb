<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Scramble
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
        Me.LB_wrongWordS = New System.Windows.Forms.ListBox()
        Me.LBL_wordS = New System.Windows.Forms.Label()
        Me.TB_submitS = New System.Windows.Forms.TextBox()
        Me.BTN_submitS = New System.Windows.Forms.Button()
        Me.LBL_trieS = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSMI_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_endGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.LLBL_signOut = New System.Windows.Forms.LinkLabel()
        Me.LBL_menuName = New System.Windows.Forms.Label()
        Me.BackToMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BTN_playAgainS = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LB_wrongWordS
        '
        Me.LB_wrongWordS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_wrongWordS.FormattingEnabled = True
        Me.LB_wrongWordS.ItemHeight = 16
        Me.LB_wrongWordS.Location = New System.Drawing.Point(33, 102)
        Me.LB_wrongWordS.Name = "LB_wrongWordS"
        Me.LB_wrongWordS.Size = New System.Drawing.Size(177, 212)
        Me.LB_wrongWordS.TabIndex = 0
        '
        'LBL_wordS
        '
        Me.LBL_wordS.AutoSize = True
        Me.LBL_wordS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_wordS.Location = New System.Drawing.Point(108, 48)
        Me.LBL_wordS.Name = "LBL_wordS"
        Me.LBL_wordS.Size = New System.Drawing.Size(207, 37)
        Me.LBL_wordS.TabIndex = 1
        Me.LBL_wordS.Text = " Serendiputy"
        '
        'TB_submitS
        '
        Me.TB_submitS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_submitS.Location = New System.Drawing.Point(241, 137)
        Me.TB_submitS.Name = "TB_submitS"
        Me.TB_submitS.Size = New System.Drawing.Size(192, 26)
        Me.TB_submitS.TabIndex = 2
        '
        'BTN_submitS
        '
        Me.BTN_submitS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_submitS.Location = New System.Drawing.Point(242, 180)
        Me.BTN_submitS.Name = "BTN_submitS"
        Me.BTN_submitS.Size = New System.Drawing.Size(97, 26)
        Me.BTN_submitS.TabIndex = 3
        Me.BTN_submitS.Text = "Submit"
        Me.BTN_submitS.UseVisualStyleBackColor = True
        '
        'LBL_trieS
        '
        Me.LBL_trieS.AutoSize = True
        Me.LBL_trieS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_trieS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_trieS.Location = New System.Drawing.Point(242, 288)
        Me.LBL_trieS.Name = "LBL_trieS"
        Me.LBL_trieS.Size = New System.Drawing.Size(97, 26)
        Me.LBL_trieS.TabIndex = 4
        Me.LBL_trieS.Text = " Tries left: "
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_file, Me.TSMI_about})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(497, 24)
        Me.MenuStrip1.TabIndex = 5
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSMI_file
        '
        Me.TSMI_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainToolStripMenuItem, Me.TSMI_logout, Me.TSMI_endGame})
        Me.TSMI_file.Name = "TSMI_file"
        Me.TSMI_file.Size = New System.Drawing.Size(37, 20)
        Me.TSMI_file.Text = "File"
        '
        'TSMI_endGame
        '
        Me.TSMI_endGame.Name = "TSMI_endGame"
        Me.TSMI_endGame.Size = New System.Drawing.Size(152, 22)
        Me.TSMI_endGame.Text = "End Game"
        '
        'TSMI_logout
        '
        Me.TSMI_logout.Name = "TSMI_logout"
        Me.TSMI_logout.Size = New System.Drawing.Size(152, 22)
        Me.TSMI_logout.Text = "Logout"
        Me.TSMI_logout.Visible = False
        '
        'TSMI_about
        '
        Me.TSMI_about.Name = "TSMI_about"
        Me.TSMI_about.Size = New System.Drawing.Size(52, 20)
        Me.TSMI_about.Text = "About"
        '
        'LLBL_signOut
        '
        Me.LLBL_signOut.AutoSize = True
        Me.LLBL_signOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LLBL_signOut.LinkColor = System.Drawing.Color.Black
        Me.LLBL_signOut.Location = New System.Drawing.Point(277, 8)
        Me.LLBL_signOut.Name = "LLBL_signOut"
        Me.LLBL_signOut.Size = New System.Drawing.Size(56, 16)
        Me.LLBL_signOut.TabIndex = 7
        Me.LLBL_signOut.TabStop = True
        Me.LLBL_signOut.Text = "Sign out"
        Me.LLBL_signOut.Visible = False
        '
        'LBL_menuName
        '
        Me.LBL_menuName.AutoSize = True
        Me.LBL_menuName.BackColor = System.Drawing.SystemColors.Control
        Me.LBL_menuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_menuName.Location = New System.Drawing.Point(339, 6)
        Me.LBL_menuName.Name = "LBL_menuName"
        Me.LBL_menuName.Size = New System.Drawing.Size(0, 20)
        Me.LBL_menuName.TabIndex = 8
        '
        'BackToMainToolStripMenuItem
        '
        Me.BackToMainToolStripMenuItem.Name = "BackToMainToolStripMenuItem"
        Me.BackToMainToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.BackToMainToolStripMenuItem.Text = "Back to main"
        '
        'BTN_playAgainS
        '
        Me.BTN_playAgainS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_playAgainS.Location = New System.Drawing.Point(343, 180)
        Me.BTN_playAgainS.Name = "BTN_playAgainS"
        Me.BTN_playAgainS.Size = New System.Drawing.Size(97, 26)
        Me.BTN_playAgainS.TabIndex = 9
        Me.BTN_playAgainS.Text = "Play again"
        Me.BTN_playAgainS.UseVisualStyleBackColor = True
        '
        'Scramble
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 339)
        Me.Controls.Add(Me.BTN_playAgainS)
        Me.Controls.Add(Me.LBL_menuName)
        Me.Controls.Add(Me.LLBL_signOut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.LBL_trieS)
        Me.Controls.Add(Me.BTN_submitS)
        Me.Controls.Add(Me.TB_submitS)
        Me.Controls.Add(Me.LBL_wordS)
        Me.Controls.Add(Me.LB_wrongWordS)
        Me.Name = "Scramble"
        Me.Text = "Scramble"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LB_wrongWordS As ListBox
    Friend WithEvents LBL_wordS As Label
    Friend WithEvents TB_submitS As TextBox
    Friend WithEvents BTN_submitS As Button
    Friend WithEvents LBL_trieS As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSMI_file As ToolStripMenuItem
    Friend WithEvents TSMI_endGame As ToolStripMenuItem
    Friend WithEvents TSMI_logout As ToolStripMenuItem
    Friend WithEvents TSMI_about As ToolStripMenuItem
    Friend WithEvents LLBL_signOut As LinkLabel
    Friend WithEvents LBL_menuName As Label
    Friend WithEvents BackToMainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BTN_playAgainS As Button
End Class
