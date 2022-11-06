' Program Name: Spring Break Specials
' Developer:    Josh Nichols
' Date:         1/21/2022
' Purpose:      Program gives the user to pick between 3 different spring break specials.
'               once the user selects a vacation they are prompted to submit that choice
'               once a selection has been made the user is then prompted to exit the program.
Public Class frmSprinkBreakSpecials
    Private Sub btnMyrtleBeach_Click(sender As Object, e As EventArgs) Handles btnMyrtleBeach.Click
        ' This block enables the myrtle beach picture whille making the others hidden.
        ' it also hides the enjoy label and enables the purchase button.
        btnPurchaseTrip.Visible = True
        picMyrtleBeach.Visible = True
        picKeyWest.Visible = False
        picVeniceBeach.Visible = False
        lblEnjoy.Visible = False
    End Sub

    Private Sub btnKeyWest_Click(sender As Object, e As EventArgs) Handles btnKeyWest.Click
        ' This block enables the key west picture while keeping the other 2 hidden
        ' it also hides the enjoy label and enables the purchase button
        btnPurchaseTrip.Visible = True
        picVeniceBeach.Visible = False
        picMyrtleBeach.Visible = False
        lblEnjoy.Visible = False
        picKeyWest.Visible = True

    End Sub

    Private Sub btnVeniceBeach_Click(sender As Object, e As EventArgs) Handles btnVeniceBeach.Click
        ' This block enables the venice beach picture while keeping the other 2 hidden. 
        ' it also hides the enjoy label and enables the purchase button.
        btnPurchaseTrip.Visible = True
        picVeniceBeach.Visible = True
        picKeyWest.Visible = False
        picMyrtleBeach.Visible = False
        lblEnjoy.Visible = False

    End Sub

    Private Sub btnPurchaseTrip_Click(sender As Object, e As EventArgs) Handles btnPurchaseTrip.Click
        ' This block enables the enjoy label and makes the exit program button visible.
        ' It also disables the 3 city buttons and hides the purchase trip button to keep the screen from 
        ' being to crowded and providing a cleaner minimal look.
        btnMyrtleBeach.Enabled = False
        btnKeyWest.Enabled = False
        btnVeniceBeach.Enabled = False
        lblEnjoy.Visible = True
        lblInstructions.Visible = False
        btnExit.Visible = True
        btnPurchaseTrip.Visible = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' This will close the program after the user makes their selection
        Close()
    End Sub
End Class
