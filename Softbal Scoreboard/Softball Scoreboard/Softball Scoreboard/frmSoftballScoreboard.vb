' Program Name: Softball Scoreboard
' Author:       Josh Nichols
' Date:         March 26, 2022
' Purpose:      This program allows the user to enter the score of a softball game
'               for each inning, keeping a running total throughout each inning. 


Public Class frmSoftballScoreboard

    'Declare Variables here
    Dim intCurrentInning As Integer = 1
    Dim strScoreEntered As String
    Dim intcurrentTotal As Integer

    Private Sub btnEnterScore_Click(sender As Object, e As EventArgs) Handles btnEnterScore.Click
        'This event handler will calculate the input from the user of each inning of the
        'softball game keeping a running total throughout the game.

        If intCurrentInning <= 7 Then
            ' Get user input
            strScoreEntered = InputBox("Score for this Inning " & intCurrentInning.ToString())

            ' non numeric input error
            While Not IsNumeric(strScoreEntered)
                MsgBox("Plese enter only numbers!")
                strScoreEntered = InputBox("Score for this Inning " & intCurrentInning.ToString())
            End While

            ' Negative value error message
            While strScoreEntered < 0
                MsgBox("Please enter a positive number")
                strScoreEntered = InputBox("Score for Inning " & intCurrentInning.ToString())
            End While


            ' this increases the total score
            intcurrentTotal = lblTotalScore.Text
            intCurrentTotal += strScoreEntered
            lblTotalScore.Text = intCurrentTotal.ToString()

            ' List boox to keep up with current score and running total
            lstScores.Items.Add(strScoreEntered & " " & intCurrentTotal.ToString())

            ' stops running after 7 innings and displays total
            If intCurrentInning = 7 Then
                lstScores.Items.Add(intCurrentTotal.ToString())
            End If
            ' Increase inning number
            intCurrentInning += 1

        Else
            ' Trying to enter a score after inning 7
            MsgBox("Thats the ball game!!! Great Game")
        End If
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' Clears the scores list, sets the total label back to zero, sets the current inning to 1

        lstScores.Items.Clear()
        lblTotalScore.Text = "0"
        intCurrentInning = 1
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Closes the program

        Close()
    End Sub
End Class
