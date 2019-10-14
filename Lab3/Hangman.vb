Public Class Hangman
    Dim hangmanWord As String
    Dim word As String
    Dim r As New Random
    Dim tries As Integer
    Dim amount As Integer
    Dim temp() As Char

    Private Sub Hangman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_menuName.Text = Form1.loggedIn

        If Form1.LBL_menuName.Text.Count >= 1 Then
            LLBL_signOut.Visible = True
        End If

        'Randomize()
        'tries = 0
        'amount =' word.Length / 2
        'LB_wrongWordS.Items.Clear()
        'LBL_trieS.Text = "Tries left: " & (totalTries - tries)

        word = Form1.wordDoc(r.Next(Form1.wordDoc.Count))
        'amount = word.Length / 2
        tries = 0
        amount = 7
        LBL_trieS.Text = "Tries left: " & (amount - tries)

        ReDim temp(word.Length - 1)
        temp = word.ToArray

        For i As Integer = 0 To word.Length - 1
            temp(i) = "-"
        Next

        hangmanWord = String.Join("", temp)
        PB_hangmanPic.Image = Nothing
        PB_hangmanPic.Image = IMGL_hangman.Images(tries)
        LBL_wordS.Text = hangmanWord
        LB_wrongWordS.Items.Clear()

        'Dim temp = word.ToArray
        'Dim temp_string = ""
        'For i As Integer = 0 To 20

        '    temp_string = ""
        '    Dim index1 As Integer = r.Next(temp.Count - 1)
        '    Dim index2 As Integer = r.Next(temp.Count - 1)
        '    temp_string = temp(index1)
        '    temp(index1) = temp(index2)
        '    temp(index2) = temp_string

        'Next
        'hangmanWord = String.Join("", temp)

        'LBL_wordS.Text = hangmanWord
    End Sub

    Private Sub TSMI_about_Click(sender As Object, e As EventArgs) Handles TSMI_about.Click
        MsgBox("About the game... " & vbNewLine & vbNewLine &
               "This application was made in October 2018.  It's called 'Hangman',  the purpose of the game is to guess the correct word using the letters that are scrambled at the top of the screen.", MsgBoxStyle.Information)
    End Sub

    Private Sub BTN_submitS_Click(sender As Object, e As EventArgs) Handles BTN_submitS.Click
        If Not LB_wrongWordS.Items.Contains(TB_submitS.Text.Trim) Then
            If TB_submitS.Text.Trim <> "" Then

                If word.Contains(TB_submitS.Text.Trim) Then
                    For i As Integer = 0 To word.Count - 1
                        If word(i) = TB_submitS.Text.Trim Then
                            temp(i) = TB_submitS.Text.Trim
                        End If
                    Next

                Else
                    tries += 1
                    LB_wrongWordS.Items.Add(TB_submitS.Text.Trim)
                    PB_hangmanPic.Image = Nothing
                    PB_hangmanPic.Image = IMGL_hangman.Images(tries)
                End If
                LBL_trieS.Text = "Tries left: " & (amount - tries)
                If tries = amount Then
                    MsgBox("Aww!  Shucks!  You've ran out of tries!" & vbNewLine & vbNewLine &
                       word & " is the correcet word!")
                    BTN_submitS.Enabled = False
                End If

                hangmanWord = String.Join("", temp)

                LBL_wordS.Text = hangmanWord
                TB_submitS.Text = ""
            End If
        End If

        If hangmanWord = word Then
            MsgBox("You've won!" & vbNewLine & vbNewLine &
                       word & " is the correct word!")
        End If
    End Sub

    Private Sub BTN_playAgainS_Click(sender As Object, e As EventArgs) Handles BTN_playAgainS.Click
        Hangman_Load(sender, e)

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

    Private Sub TB_submitS_TextChanged(sender As Object, e As EventArgs) Handles TB_submitS.TextChanged

    End Sub
End Class