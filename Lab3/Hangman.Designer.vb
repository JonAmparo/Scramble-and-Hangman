<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Hangman
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Hangman))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.TSMI_file = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackToMainToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_logout = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_endGame = New System.Windows.Forms.ToolStripMenuItem()
        Me.TSMI_about = New System.Windows.Forms.ToolStripMenuItem()
        Me.LLBL_signOut = New System.Windows.Forms.LinkLabel()
        Me.LBL_menuName = New System.Windows.Forms.Label()
        Me.LB_wrongWordS = New System.Windows.Forms.ListBox()
        Me.TB_submitS = New System.Windows.Forms.TextBox()
        Me.BTN_submitS = New System.Windows.Forms.Button()
        Me.BTN_playAgainS = New System.Windows.Forms.Button()
        Me.LBL_trieS = New System.Windows.Forms.Label()
        Me.LBL_wordS = New System.Windows.Forms.Label()
        Me.PB_hangmanPic = New System.Windows.Forms.PictureBox()
        Me.IMGL_hangman = New System.Windows.Forms.ImageList(Me.components)
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PB_hangmanPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TSMI_file, Me.TSMI_about})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(605, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'TSMI_file
        '
        Me.TSMI_file.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackToMainToolStripMenuItem, Me.TSMI_logout, Me.TSMI_endGame})
        Me.TSMI_file.Name = "TSMI_file"
        Me.TSMI_file.Size = New System.Drawing.Size(37, 20)
        Me.TSMI_file.Text = "File"
        '
        'BackToMainToolStripMenuItem
        '
        Me.BackToMainToolStripMenuItem.Name = "BackToMainToolStripMenuItem"
        Me.BackToMainToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.BackToMainToolStripMenuItem.Text = "Back to main"
        '
        'TSMI_logout
        '
        Me.TSMI_logout.Name = "TSMI_logout"
        Me.TSMI_logout.Size = New System.Drawing.Size(143, 22)
        Me.TSMI_logout.Text = "Logout"
        Me.TSMI_logout.Visible = False
        '
        'TSMI_endGame
        '
        Me.TSMI_endGame.Name = "TSMI_endGame"
        Me.TSMI_endGame.Size = New System.Drawing.Size(143, 22)
        Me.TSMI_endGame.Text = "End Game"
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
        Me.LLBL_signOut.Location = New System.Drawing.Point(259, 9)
        Me.LLBL_signOut.Name = "LLBL_signOut"
        Me.LLBL_signOut.Size = New System.Drawing.Size(56, 16)
        Me.LLBL_signOut.TabIndex = 8
        Me.LLBL_signOut.TabStop = True
        Me.LLBL_signOut.Text = "Sign out"
        Me.LLBL_signOut.Visible = False
        '
        'LBL_menuName
        '
        Me.LBL_menuName.AutoSize = True
        Me.LBL_menuName.BackColor = System.Drawing.SystemColors.Control
        Me.LBL_menuName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_menuName.Location = New System.Drawing.Point(321, 9)
        Me.LBL_menuName.Name = "LBL_menuName"
        Me.LBL_menuName.Size = New System.Drawing.Size(0, 20)
        Me.LBL_menuName.TabIndex = 9
        '
        'LB_wrongWordS
        '
        Me.LB_wrongWordS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_wrongWordS.FormattingEnabled = True
        Me.LB_wrongWordS.ItemHeight = 16
        Me.LB_wrongWordS.Location = New System.Drawing.Point(12, 278)
        Me.LB_wrongWordS.Name = "LB_wrongWordS"
        Me.LB_wrongWordS.Size = New System.Drawing.Size(177, 100)
        Me.LB_wrongWordS.TabIndex = 10
        '
        'TB_submitS
        '
        Me.TB_submitS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_submitS.Location = New System.Drawing.Point(305, 158)
        Me.TB_submitS.Name = "TB_submitS"
        Me.TB_submitS.Size = New System.Drawing.Size(192, 26)
        Me.TB_submitS.TabIndex = 11
        '
        'BTN_submitS
        '
        Me.BTN_submitS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_submitS.Location = New System.Drawing.Point(305, 190)
        Me.BTN_submitS.Name = "BTN_submitS"
        Me.BTN_submitS.Size = New System.Drawing.Size(97, 26)
        Me.BTN_submitS.TabIndex = 12
        Me.BTN_submitS.Text = "Submit"
        Me.BTN_submitS.UseVisualStyleBackColor = True
        '
        'BTN_playAgainS
        '
        Me.BTN_playAgainS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_playAgainS.Location = New System.Drawing.Point(408, 190)
        Me.BTN_playAgainS.Name = "BTN_playAgainS"
        Me.BTN_playAgainS.Size = New System.Drawing.Size(97, 26)
        Me.BTN_playAgainS.TabIndex = 13
        Me.BTN_playAgainS.Text = "New game"
        Me.BTN_playAgainS.UseVisualStyleBackColor = True
        '
        'LBL_trieS
        '
        Me.LBL_trieS.AutoSize = True
        Me.LBL_trieS.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBL_trieS.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_trieS.Location = New System.Drawing.Point(305, 244)
        Me.LBL_trieS.Name = "LBL_trieS"
        Me.LBL_trieS.Size = New System.Drawing.Size(97, 26)
        Me.LBL_trieS.TabIndex = 14
        Me.LBL_trieS.Text = " Tries left: "
        '
        'LBL_wordS
        '
        Me.LBL_wordS.AutoSize = True
        Me.LBL_wordS.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_wordS.Location = New System.Drawing.Point(298, 42)
        Me.LBL_wordS.Name = "LBL_wordS"
        Me.LBL_wordS.Size = New System.Drawing.Size(207, 37)
        Me.LBL_wordS.TabIndex = 15
        Me.LBL_wordS.Text = " Serendiputy"
        '
        'PB_hangmanPic
        '
        Me.PB_hangmanPic.Location = New System.Drawing.Point(12, 34)
        Me.PB_hangmanPic.Name = "PB_hangmanPic"
        Me.PB_hangmanPic.Size = New System.Drawing.Size(279, 235)
        Me.PB_hangmanPic.TabIndex = 16
        Me.PB_hangmanPic.TabStop = False
        '
        'IMGL_hangman
        '
        Me.IMGL_hangman.ImageStream = CType(resources.GetObject("IMGL_hangman.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IMGL_hangman.TransparentColor = System.Drawing.Color.Transparent
        Me.IMGL_hangman.Images.SetKeyName(0, "hangman_empty.jpg")
        Me.IMGL_hangman.Images.SetKeyName(1, "hangman_string.jpg")
        Me.IMGL_hangman.Images.SetKeyName(2, "hangman_head.jpg")
        Me.IMGL_hangman.Images.SetKeyName(3, "hangman_body.jpg")
        Me.IMGL_hangman.Images.SetKeyName(4, "hangman_1_arm.jpg")
        Me.IMGL_hangman.Images.SetKeyName(5, "hangman_2_arms.jpg")
        Me.IMGL_hangman.Images.SetKeyName(6, "hangman_1_leg.jpg")
        Me.IMGL_hangman.Images.SetKeyName(7, "hangman_whole.jpg")
        Me.IMGL_hangman.Images.SetKeyName(8, "hangman_over.jpg")
        '
        'Hangman
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 390)
        Me.Controls.Add(Me.PB_hangmanPic)
        Me.Controls.Add(Me.LBL_wordS)
        Me.Controls.Add(Me.LBL_trieS)
        Me.Controls.Add(Me.BTN_playAgainS)
        Me.Controls.Add(Me.BTN_submitS)
        Me.Controls.Add(Me.TB_submitS)
        Me.Controls.Add(Me.LB_wrongWordS)
        Me.Controls.Add(Me.LBL_menuName)
        Me.Controls.Add(Me.LLBL_signOut)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Hangman"
        Me.Text = "Hangman"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PB_hangmanPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents TSMI_file As ToolStripMenuItem
    Friend WithEvents BackToMainToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TSMI_logout As ToolStripMenuItem
    Friend WithEvents TSMI_endGame As ToolStripMenuItem
    Friend WithEvents TSMI_about As ToolStripMenuItem
    Friend WithEvents LLBL_signOut As LinkLabel
    Friend WithEvents LBL_menuName As Label
    Friend WithEvents LB_wrongWordS As ListBox
    Friend WithEvents TB_submitS As TextBox
    Friend WithEvents BTN_submitS As Button
    Friend WithEvents BTN_playAgainS As Button
    Friend WithEvents LBL_trieS As Label
    Friend WithEvents LBL_wordS As Label
    Friend WithEvents PB_hangmanPic As PictureBox
    Friend WithEvents IMGL_hangman As ImageList
End Class
