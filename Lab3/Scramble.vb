Public Class Scramble
    Dim scramble As String
    Dim word As String
    Dim r As New Random
    Dim tries As Integer
    Dim amount As Integer


    Private Sub Scramble_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_menuName.Text = Form1.loggedIn

        If Form1.LBL_menuName.Text.Count >= 1 Then
            LLBL_signOut.Visible = True
        End If

        'Randomize()
        tries = 0
        LB_wrongWordS.Items.Clear()
        'LBL_trieS.Text = "Tries left: " & (totalTries - tries)

        word = Form1.wordDoc(r.Next(Form1.wordDoc.Count))
        amount = word.Length / 2
        If word.Length < 6 Then
            amount = 5
        End If
        LBL_trieS.Text = "Tries left: " & (amount - tries)

        Dim temp = word.ToArray
        Dim temp_string = ""
        For i As Integer = 0 To 20

            temp_string = ""
            Dim index1 As Integer = r.Next(temp.Count - 1)
            Dim index2 As Integer = r.Next(temp.Count - 1)
            temp_string = temp(index1)
            temp(index1) = temp(index2)
            temp(index2) = temp_string

        Next
        scramble = String.Join("", temp)

        LBL_wordS.Text = scramble
    End Sub

    Private Sub TSMI_about_Click(sender As Object, e As EventArgs) Handles TSMI_about.Click
        MsgBox("About the game... " & vbNewLine & vbNewLine &
               "This application was made in October 2018.  It's called 'Scramble',  the purpose of the game is to guess the correct word using the letters that are scrambled at the top of the screen.", MsgBoxStyle.Information)
    End Sub

    Private Sub BTN_submitS_Click(sender As Object, e As EventArgs) Handles BTN_submitS.Click
        If TB_submitS.Text.Count >= 1 Then
            tries += 1
            'BTN_playAgainS.Enabled = False
            If tries = amount OrElse TB_submitS.Text.Trim = word Then
                BTN_submitS.Enabled = False
                BTN_playAgainS.Enabled = True

                MsgBox("Aww!  Shucks!  You've ran out of tries!" & vbNewLine & vbNewLine &
                       word & " is the correcet word!") '& MsgBoxStyle.Critical'
            End If
            LB_wrongWordS.Items.Add(TB_submitS.Text.Trim)
            LBL_trieS.Text = "Tries left: " & (amount - tries)
            TB_submitS.Text = ""
        End If
    End Sub

    Private Sub BTN_playAgainS_Click(sender As Object, e As EventArgs) Handles BTN_playAgainS.Click
        Scramble_Load(sender, e)

        TB_submitS.Text = ""
        BTN_submitS.Enabled = True
    End Sub

    Private Sub BackToMainToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToMainToolStripMenuItem.Click
        Me.Close()
        Form1.Visible = True
    End Sub

    Private Sub TSMI_endGame_Click(sender As Object, e As EventArgs) Handles TSMI_endGame.Click
        Me.Close()
    End Sub

    Private Sub LLBL_signOut_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LLBL_signOut.LinkClicked
        If LLBL_signOut.Text = "Sign out" Then
            Me.Close()
            Form1.Visible = True
            Form1.TSMI_logout_Click(sender, e)
        End If
    End Sub
End Class