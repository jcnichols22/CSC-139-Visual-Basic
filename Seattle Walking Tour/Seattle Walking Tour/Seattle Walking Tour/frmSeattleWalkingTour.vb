' Program:      Seattle Walking tour Tickets
' Developer:    Josh Nichols
' Date:         February 4, 2022
' Purpose:      Allows the user to enter a number of tickets to be purchased
'               the program then calculates a total and displays it to the user
Public Class frmSeattleWalkingTour

    ' Cost per ticket
    Const _cdecPricePerTicket As Decimal = 14.99

    Private Sub frmSeattleWalkingTour_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This is executed when the form is loaded.
        ' It displays the cost heading, clears the text property of
        ' the Total Cost label, and sets the focus 
        ' on the txtNumberOfTickets textbox.

        lblPriceHeading.Text = _cdecPricePerTicket.ToString("C") & " Per Ticket"
        lblTotalCost.Text = ""
        txtNumberOfTickets.Focus()
    End Sub

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        ' This is executed when the user clicks the 
        ' Display Cost button. It calculates and displays the cost
        ' of the AirBnB rented (number of nights times the cost per night)

        Dim strNumberOfNights As String
        Dim intNumberOfNights As Integer
        Dim decTotalCost As Decimal

        strNumberOfNights = txtNumberOfTickets.Text
        intNumberOfNights = Convert.ToInt32(strNumberOfNights)
        decTotalCost = intNumberOfNights * _cdecPricePerTicket
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This is executed when the user clicks the Clear button.
        ' It clears the number of tickets text box and the text property
        ' of the Total Cost label. It then sets the focus on
        ' the txtNumberOfTickets textbox.

        txtNumberOfTickets.Clear()
        lblTotalCost.Text = ""
        txtNumberOfTickets.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the window and terminates the application

        Close()
    End Sub
End Class
