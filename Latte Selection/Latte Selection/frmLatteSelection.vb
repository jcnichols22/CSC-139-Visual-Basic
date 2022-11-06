' Program Name: Latte Selection
' Developer:    Josh Nichols
' Date:         January 20, 2022
' Purpose:      This application displays two latte flavors (pumpkin spice
'               and mocha). The user can select a latte flavor.
Public Class frmLatteSelection
    Private Sub btnPumpkin_Click(sender As Object, e As EventArgs) Handles btnPumpkin.Click
        'This code is executed when the user clicks the Pumpkin Spice button. it displays the
        'pumpkin picture, hides the mocha picture, and enables the Select Latte button.

        picPumpkin.Visible = True
        picMocha.Visible = False
        btnSelect.Enabled = True 'Enables button

    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' This code is executed when the user clicks the Select buttin. it disables the
        ' Pumpkin spic button, the select button, and the Mocha button. It hides the
        ' Instructions label, displays the confirmation label, and enables the Exit window button.

        btnPumpkin.Enabled = False
        btnSelect.Enabled = False
        btnMocha.Enabled = False
        lblInstructions.Visible = False
        lblConfirmation.Visible = True
        btnExit.Enabled = True

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This code is executed when the user clicks the exit window button.
        ' It closes the window and terminates the program execution.

        Close()

    End Sub

    Private Sub btnMocha_Click(sender As Object, e As EventArgs) Handles btnMocha.Click
        'This code is executed when the user clicks the Mocha button. it displays the
        'Mocha picture, hides the pumpkin spice picture, and enables the Select Latte button.
        picMocha.Visible = True
        picPumpkin.Visible = False
        btnSelect.Enabled = True
    End Sub
End Class
