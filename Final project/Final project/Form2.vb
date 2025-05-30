Public Class Form2

    'Nate Legault and Darcy Idler Final Project

    Dim intPaddleSpeed As Integer
    Dim intBallSpeed As Double
    Dim blnPaused As Boolean
    Dim blnMoveRight As Boolean
    Dim blnMoveLeft As Boolean
    Dim blnMoveUp As Boolean
    Dim blnPlayerPaddle As Boolean
    Dim blnPaddleRight As Boolean
    Dim blnPaddleLeft As Boolean
    Dim blnTennisMode As Boolean
    Dim blnInGame As Boolean

    'Done By Darcy

    Private Sub picDificultyEasy_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picDificultyEasy.Click

        LoadSettingsEasy()

    End Sub

    Private Sub picDificultyNormal_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picDificultyNormal.Click

        LoadSettingsNormal()

    End Sub

    Private Sub picDificultyHard_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picDificultyHard.Click

        LoadSettingsHard()

    End Sub

    Private Sub picDificultyTennis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picDificultyTennis.Click

        LoadSettingsTennis()

    End Sub

    Private Sub picHelp_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picHelp.Click

        MessageBox.Show("Arkanoid is a game where you use your left and right arrow keys," & _
                        "  To stop the ball from hitting the bottom " & _
                         " You have one life If the ball hits the bottom then you lose and if you destroy all the blocks you win" & _
                         " If you need to pause you can press the P key.")

    End Sub

    Private Sub picExitGame_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles picExitGame.Click

        End

    End Sub

    'Done by Nate
    Sub tmrMain_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmrMain.Tick

        MovePaddle()
        CheckHit()
        CheckGameOver()

    End Sub

    Sub Form2_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown

        If e.KeyValue = Keys.Right Then
            blnPaddleRight = True
            blnPaddleLeft = False
        End If
        If e.KeyValue = Keys.Left Then
            blnPaddleLeft = True
            blnPaddleRight = False
        End If

    End Sub

    Sub MovePaddle()
        If blnPaddleRight = True And picPlayerPaddle.Left + picPlayerPaddle.Width < Me.ClientRectangle.Width Then

            picPlayerPaddle.Left += intPaddleSpeed
        End If
        If blnPaddleLeft = True And picPlayerPaddle.Left > Me.ClientRectangle.Left Then
            picPlayerPaddle.Left -= intPaddleSpeed
        End If

    End Sub

    Sub Form2_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp

        If e.KeyValue = Keys.Right Then
            blnPaddleRight = False
        End If
        If e.KeyValue = Keys.Left Then
            blnPaddleLeft = False
        End If

    End Sub

    Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadNewGame()

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Loads the difficulty selection screen 
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadNewGame()

        blnInGame = False
        blnPaused = False
        intPaddleSpeed = 0
        intBallSpeed = 0
        picBall.Location = New Point(393, 400)
        picPlayerPaddle.Location = New Point(304, 457)
        picDificultyEasy.Visible = True
        picDificultyNormal.Visible = True
        picDificultyHard.Visible = True
        picDificultyTennis.Visible = True
        picExitGame.Visible = True
        picHelp.Visible = True
        picBlock1.Visible = False
        picBlock2.Visible = False
        picBlock3.Visible = False
        picBlock4.Visible = False
        picBlock5.Visible = False
        picBlock6.Visible = False
        picBlock7.Visible = False
        picBlock8.Visible = False
        picBlock9.Visible = False
        picBlock10.Visible = False
        picBlock11.Visible = False
        picBlock12.Visible = False
        picBlock13.Visible = False
        picBlock14.Visible = False
        picBlock15.Visible = False
        picBlock16.Visible = False
        picBlock17.Visible = False
        picBlock18.Visible = False
        picBlock19.Visible = False
        picBlock20.Visible = False
        picBlock21.Visible = False
        picBlock22.Visible = False
        picBlock23.Visible = False
        picBlock24.Visible = False
        picBlock25.Visible = False
        picBlock26.Visible = False
        picBlock27.Visible = False
        picBlock28.Visible = False
        picStartGame.Visible = False
        picArkanoidLogo.Visible = True
        picBall.Visible = True
        picPlayerPaddle.Visible = True
        blnPaddleRight = False
        blnPaddleLeft = False
        tmrMain.Enabled = False

    End Sub

    'Done by Darcy

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Loads the game with easy settings
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadSettingsEasy()

        blnInGame = True
        intPaddleSpeed = 8
        intBallSpeed = 3
        picBall.Location = New Point(393, 400)
        picPlayerPaddle.Location = New Point(304, 457)
        picDificultyEasy.Visible = False
        picDificultyNormal.Visible = False
        picDificultyHard.Visible = False
        picDificultyTennis.Visible = False
        picExitGame.Visible = False
        picHelp.Visible = False
        picBlock1.Visible = True
        picBlock2.Visible = True
        picBlock3.Visible = True
        picBlock4.Visible = True
        picBlock5.Visible = True
        picBlock6.Visible = True
        picBlock7.Visible = True
        picBlock8.Visible = True
        picBlock9.Visible = True
        picBlock10.Visible = True
        picBlock11.Visible = True
        picBlock12.Visible = True
        picBlock13.Visible = True
        picBlock14.Visible = True
        picBlock15.Visible = False
        picBlock16.Visible = False
        picBlock17.Visible = False
        picBlock18.Visible = False
        picBlock19.Visible = False
        picBlock20.Visible = False
        picBlock21.Visible = False
        picBlock22.Visible = False
        picBlock23.Visible = False
        picBlock24.Visible = False
        picBlock25.Visible = False
        picBlock26.Visible = False
        picBlock27.Visible = False
        picBlock28.Visible = False
        picStartGame.Visible = True
        picArkanoidLogo.Visible = False
        picBall.Visible = True
        picPlayerPaddle.Visible = True
        blnPaddleRight = False
        blnPaddleLeft = False
        blnPaused = True
        blnTennisMode = False
        tmrMain.Enabled = False

    End Sub

    'Done By Darcy

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Loads the game with normal settings
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadSettingsNormal()

        blnInGame = True
        intPaddleSpeed = 8
        intBallSpeed = 5
        picBall.Location = New Point(393, 400)
        picPlayerPaddle.Location = New Point(304, 457)
        picDificultyEasy.Visible = False
        picDificultyNormal.Visible = False
        picDificultyHard.Visible = False
        picDificultyTennis.Visible = False
        picExitGame.Visible = False
        picHelp.Visible = False
        picBlock1.Visible = True
        picBlock2.Visible = True
        picBlock3.Visible = True
        picBlock4.Visible = True
        picBlock5.Visible = True
        picBlock6.Visible = True
        picBlock7.Visible = True
        picBlock8.Visible = True
        picBlock9.Visible = True
        picBlock10.Visible = True
        picBlock11.Visible = True
        picBlock12.Visible = True
        picBlock13.Visible = True
        picBlock14.Visible = True
        picBlock15.Visible = True
        picBlock16.Visible = True
        picBlock17.Visible = True
        picBlock18.Visible = True
        picBlock19.Visible = True
        picBlock20.Visible = True
        picBlock21.Visible = True
        picBlock22.Visible = False
        picBlock23.Visible = False
        picBlock24.Visible = False
        picBlock25.Visible = False
        picBlock26.Visible = False
        picBlock27.Visible = False
        picBlock28.Visible = False
        picStartGame.Visible = True
        picArkanoidLogo.Visible = False
        picBall.Visible = True
        picPlayerPaddle.Visible = True
        blnPaddleRight = False
        blnPaddleLeft = False
        blnPaused = True
        blnTennisMode = False
        tmrMain.Enabled = False

    End Sub

    'Done by Darcy

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Loads the game with hard settings
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadSettingsHard()

        blnInGame = True
        intPaddleSpeed = 14
        intBallSpeed = 8
        picBall.Location = New Point(393, 400)
        picPlayerPaddle.Location = New Point(304, 457)
        picDificultyEasy.Visible = False
        picDificultyNormal.Visible = False
        picDificultyHard.Visible = False
        picDificultyTennis.Visible = False
        picExitGame.Visible = False
        picHelp.Visible = False
        picBlock1.Visible = True
        picBlock2.Visible = True
        picBlock3.Visible = True
        picBlock4.Visible = True
        picBlock5.Visible = True
        picBlock6.Visible = True
        picBlock7.Visible = True
        picBlock8.Visible = True
        picBlock9.Visible = True
        picBlock10.Visible = True
        picBlock11.Visible = True
        picBlock12.Visible = True
        picBlock13.Visible = True
        picBlock14.Visible = True
        picBlock15.Visible = True
        picBlock16.Visible = True
        picBlock17.Visible = True
        picBlock18.Visible = True
        picBlock19.Visible = True
        picBlock20.Visible = True
        picBlock21.Visible = True
        picBlock22.Visible = True
        picBlock23.Visible = True
        picBlock24.Visible = True
        picBlock25.Visible = True
        picBlock26.Visible = True
        picBlock27.Visible = True
        picBlock28.Visible = True
        picStartGame.Visible = True
        picArkanoidLogo.Visible = False
        picBall.Visible = True
        picPlayerPaddle.Visible = True
        blnPaddleRight = False
        blnPaddleLeft = False
        blnPaused = True
        blnTennisMode = False
        tmrMain.Enabled = False

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Loads the the tennis mode and game settings
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub LoadSettingsTennis()

        blnInGame = True
        intPaddleSpeed = 16
        intBallSpeed = 10
        picBall.Location = New Point(393, 400)
        picPlayerPaddle.Location = New Point(304, 457)
        picDificultyEasy.Visible = False
        picDificultyNormal.Visible = False
        picDificultyHard.Visible = False
        picDificultyTennis.Visible = False
        picExitGame.Visible = False
        picHelp.Visible = False
        picBlock1.Visible = False
        picBlock2.Visible = False
        picBlock3.Visible = False
        picBlock4.Visible = False
        picBlock5.Visible = False
        picBlock6.Visible = False
        picBlock7.Visible = False
        picBlock8.Visible = False
        picBlock9.Visible = False
        picBlock10.Visible = False
        picBlock11.Visible = False
        picBlock12.Visible = False
        picBlock13.Visible = False
        picBlock14.Visible = False
        picBlock15.Visible = False
        picBlock16.Visible = False
        picBlock17.Visible = False
        picBlock18.Visible = False
        picBlock19.Visible = False
        picBlock20.Visible = False
        picBlock21.Visible = False
        picBlock22.Visible = False
        picBlock23.Visible = False
        picBlock24.Visible = False
        picBlock25.Visible = False
        picBlock26.Visible = False
        picBlock27.Visible = False
        picBlock28.Visible = False
        picStartGame.Visible = True
        picArkanoidLogo.Visible = False
        picBall.Visible = True
        picPlayerPaddle.Visible = True
        blnPaddleRight = False
        blnPaddleLeft = False
        blnPaused = True
        blnTennisMode = True
        tmrMain.Enabled = False


    End Sub

    'Done by Nate

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Check if the walls, paddle or blocks have been hit and will either bounce of and make it
    'disapear, bounce of of end the game
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub CheckHit()

        If blnMoveRight = True Then
            picBall.Left += intBallSpeed
        Else
            picBall.Left -= intBallSpeed
        End If

        If blnMoveUp = True Then
            picBall.Top -= intBallSpeed
        Else
            picBall.Top += intBallSpeed
        End If

        If picBall.Left <= Me.ClientRectangle.Left Then
            blnMoveRight = True
        End If
        If picBall.Left + picBall.Width >= Me.ClientRectangle.Right Then
            blnMoveRight = False
        End If

        If picBall.Top <= Me.ClientRectangle.Top Then
            blnMoveUp = False
        End If

        If picBall.Top + picBall.Height >= picPlayerPaddle.Top And
            picPlayerPaddle.Top + picPlayerPaddle.Height >= picBall.Top And
            picBall.Left + picBall.Width >= picPlayerPaddle.Left And _
            picPlayerPaddle.Left + picPlayerPaddle.Width >= picBall.Left And picBall.Visible = True And picPlayerPaddle.Visible = True Then
            blnMoveUp = True
        End If

        If picBall.Top + picBall.Height >= picBlock1.Top And
    picBlock1.Top + picBlock1.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock1.Left And _
    picBlock1.Left + picBlock1.Width >= picBall.Left And picBall.Visible = True And picBlock1.Visible = True Then
            picBlock1.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock2.Top And
    picBlock2.Top + picBlock2.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock2.Left And _
    picBlock2.Left + picBlock2.Width >= picBall.Left And picBall.Visible = True And picBlock2.Visible = True Then
            picBlock2.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock3.Top And
   picBlock3.Top + picBlock3.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock3.Left And _
   picBlock3.Left + picBlock3.Width >= picBall.Left And picBall.Visible = True And picBlock3.Visible = True Then
            picBlock3.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock4.Top And
   picBlock4.Top + picBlock4.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock4.Left And _
   picBlock4.Left + picBlock4.Width >= picBall.Left And picBall.Visible = True And picBlock4.Visible = True Then
            picBlock4.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock5.Top And
   picBlock5.Top + picBlock5.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock5.Left And _
   picBlock5.Left + picBlock5.Width >= picBall.Left And picBall.Visible = True And picBlock5.Visible = True Then
            picBlock5.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock6.Top And
   picBlock6.Top + picBlock6.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock6.Left And _
   picBlock6.Left + picBlock6.Width >= picBall.Left And picBall.Visible = True And picBlock6.Visible = True Then
            picBlock6.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock7.Top And
picBlock7.Top + picBlock7.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock7.Left And _
picBlock7.Left + picBlock7.Width >= picBall.Left And picBall.Visible = True And picBlock7.Visible = True Then
            picBlock7.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock8.Top And
   picBlock8.Top + picBlock8.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock8.Left And _
   picBlock8.Left + picBlock8.Width >= picBall.Left And picBall.Visible = True And picBlock8.Visible = True Then
            picBlock8.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock9.Top And
   picBlock9.Top + picBlock9.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock9.Left And _
   picBlock9.Left + picBlock9.Width >= picBall.Left And picBall.Visible = True And picBlock9.Visible = True Then
            picBlock9.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock10.Top And
   picBlock10.Top + picBlock10.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock10.Left And _
   picBlock10.Left + picBlock10.Width >= picBall.Left And picBall.Visible = True And picBlock10.Visible = True Then
            picBlock10.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock11.Top And
   picBlock11.Top + picBlock11.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock11.Left And _
   picBlock11.Left + picBlock11.Width >= picBall.Left And picBall.Visible = True And picBlock11.Visible = True Then
            picBlock11.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock12.Top And
   picBlock12.Top + picBlock12.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock12.Left And _
   picBlock12.Left + picBlock12.Width >= picBall.Left And picBall.Visible = True And picBlock12.Visible = True Then
            picBlock12.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock13.Top And
    picBlock13.Top + picBlock13.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock13.Left And _
    picBlock13.Left + picBlock13.Width >= picBall.Left And picBall.Visible = True And picBlock13.Visible = True Then
            picBlock13.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock14.Top And
picBlock14.Top + picBlock14.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock14.Left And _
picBlock14.Left + picBlock14.Width >= picBall.Left And picBall.Visible = True And picBlock14.Visible = True Then
            picBlock14.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock15.Top And
    picBlock15.Top + picBlock15.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock15.Left And _
    picBlock15.Left + picBlock15.Width >= picBall.Left And picBall.Visible = True And picBlock15.Visible = True Then
            picBlock15.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock16.Top And
    picBlock16.Top + picBlock16.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock16.Left And _
    picBlock16.Left + picBlock16.Width >= picBall.Left And picBall.Visible = True And picBlock16.Visible = True Then
            picBlock16.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock17.Top And
    picBlock17.Top + picBlock17.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock17.Left And _
    picBlock17.Left + picBlock17.Width >= picBall.Left And picBall.Visible = True And picBlock17.Visible = True Then
            picBlock17.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock18.Top And
    picBlock18.Top + picBlock18.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock18.Left And _
    picBlock18.Left + picBlock18.Width >= picBall.Left And picBall.Visible = True And picBlock18.Visible = True Then
            picBlock18.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock19.Top And
    picBlock19.Top + picBlock19.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock19.Left And _
    picBlock19.Left + picBlock19.Width >= picBall.Left And picBall.Visible = True And picBlock19.Visible = True Then
            picBlock19.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock20.Top And
    picBlock20.Top + picBlock20.Height >= picBall.Top And
    picBall.Left + picBall.Width >= picBlock20.Left And _
    picBlock20.Left + picBlock20.Width >= picBall.Left And picBall.Visible = True And picBlock20.Visible = True Then
            picBlock20.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock21.Top And
   picBlock21.Top + picBlock21.Height >= picBall.Top And
   picBall.Left + picBall.Width >= picBlock21.Left And _
   picBlock21.Left + picBlock21.Width >= picBall.Left And picBall.Visible = True And picBlock21.Visible = True Then
            picBlock21.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock22.Top And
picBlock22.Top + picBlock22.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock22.Left And _
picBlock22.Left + picBlock22.Width >= picBall.Left And picBall.Visible = True And picBlock22.Visible = True Then
            picBlock22.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock23.Top And
picBlock23.Top + picBlock23.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock23.Left And _
picBlock23.Left + picBlock23.Width >= picBall.Left And picBall.Visible = True And picBlock23.Visible = True Then
            picBlock23.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock24.Top And
picBlock24.Top + picBlock24.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock24.Left And _
picBlock24.Left + picBlock24.Width >= picBall.Left And picBall.Visible = True And picBlock24.Visible = True Then
            picBlock24.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock25.Top And
picBlock25.Top + picBlock25.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock25.Left And _
picBlock25.Left + picBlock25.Width >= picBall.Left And picBall.Visible = True And picBlock25.Visible = True Then
            picBlock25.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock26.Top And
picBlock26.Top + picBlock26.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock26.Left And _
picBlock26.Left + picBlock26.Width >= picBall.Left And picBall.Visible = True And picBlock26.Visible = True Then
            picBlock26.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock27.Top And
picBlock27.Top + picBlock27.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock27.Left And _
picBlock27.Left + picBlock27.Width >= picBall.Left And picBall.Visible = True And picBlock27.Visible = True Then
            picBlock27.Visible = False
            blnMoveUp = False
        End If
        If picBall.Top + picBall.Height >= picBlock28.Top And
picBlock28.Top + picBlock28.Height >= picBall.Top And
picBall.Left + picBall.Width >= picBlock28.Left And _
picBlock28.Left + picBlock28.Width >= picBall.Left And picBall.Visible = True And picBlock28.Visible = True Then
            picBlock28.Visible = False
            blnMoveUp = False
        End If
        If picBall.Bottom >= Me.ClientRectangle.Bottom And picBall.Visible = True Then
            tmrMain.Enabled = False
            My.Computer.Audio.Play(My.Resources.Roblox_Death_Sound_Effect1, AudioPlayMode.Background)
            Process.Start("https://www.xera.ca")
            PlayAgain()
        End If

    End Sub

    'Done By Darcy

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Checks if all the blocks are visable = false if they are then it ends the game and the
    'player wins
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub CheckGameOver()

        If picBlock1.Visible = False And picBlock2.Visible = False And picBlock3.Visible = False And _
                picBlock4.Visible = False And picBlock5.Visible = False And picBlock6.Visible = False _
                And picBlock8.Visible = False And picBlock9.Visible = False And picBlock10.Visible = False _
                And picBlock11.Visible = False And picBlock12.Visible = False And picBlock13.Visible = False _
                And picBlock15.Visible = False And picBlock16.Visible = False And picBlock17.Visible = False _
                And picBlock18.Visible = False And picBlock19.Visible = False And picBlock20.Visible = False And _
                 picBlock7.Visible = False And picBlock14.Visible = False And picBlock21.Visible = False And _
                 picBlock22.Visible = False And picBlock23.Visible = False And picBlock24.Visible = False And _
                 picBlock25.Visible = False And picBlock26.Visible = False And picBlock27.Visible = False And _
                 picBlock28.Visible = False And _
                tmrMain.Enabled = True And blnTennisMode = False Then
            tmrMain.Enabled = False
            MsgBox("Game Over All blocks Destroyed YOU WIN YEETUS!")
            PlayAgain()
        End If

    End Sub

    'Done By Nate
    Sub Form2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

        If e.KeyChar = "P" Or e.KeyChar = "p" And blnInGame = True Then
            If blnPaused = True Then
                tmrMain.Enabled = True
                blnPaused = False
                picStartGame.Visible = False
            Else
                tmrMain.Enabled = False
                blnPaused = True
                picStartGame.Visible = True
            End If
        End If

    End Sub

    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    'Prompts the player if they would like to play again or not if yes then it Calls LoadNewGame()
    'if no it ends the program
    '~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    Sub PlayAgain()

        Dim yesorno = MsgBox("Play Again ?", MsgBoxStyle.YesNo)

        If yesorno = MsgBoxResult.Yes Then
            tmrMain.Enabled = False
            LoadNewGame() 'Resets and restarts game
        Else
            End
        End If

    End Sub
End Class
