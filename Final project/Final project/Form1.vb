Public Class Form1

    'Nate Legault And Darcy Idler Final Project

    'Done by Nate

    Private Sub mnuNewGame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuNewGame.Click, btnNewGame.Click

        Form2.Show()

    End Sub

    Private Sub mnuHelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelp.Click, btnHelp.Click

        MessageBox.Show("Arkanoid is a game where you use your left and right arrow keys," & _
                        "  To stop the ball from hitting the bottom " & _
                         " You have one life If the ball hits the bottom then you lose and if you destroy all the blocks you win" & _
                         " If you need to pause you can press the P key.")

    End Sub

    Private Sub mnuExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuExit.Click, btnExit.Click

        End

    End Sub

End Class
