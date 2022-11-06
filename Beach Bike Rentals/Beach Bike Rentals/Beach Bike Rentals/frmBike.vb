' Program:      Beach Bike Rentals
' Developer:    Josh Nichols
' Date:         1/30/2022
' Purpose:      This application calculates and displays the total
'               cost of renting a bike for a specified number of days.

Option Strict On

Public Class frmBike

    ' Cost per bike rental - used in multiple procedures
    Const _cdecPricePerDay As Decimal = 9.95D

    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        ' This event handler is executed when the user clicks the
        ' Find Cost button. It calculates and displays the cost
        ' Of the bike rented (number of days times the cost per bike).

        Dim strNumberOfDays As String
        Dim intNumberOfDays As Integer
        Dim decTotalCost As Decimal

        strNumberOfDays = txtNumberOfDays.Text
        intNumberOfDays = Convert.ToInt32(strNumberOfDays)
        decTotalCost = intNumberOfDays * _cdecPricePerDay
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler is executed when the user clicks the
        ' Clear button. It clears the number of days text box
        ' and the Text property of the Total Cost label.
        ' then, it sets the focus on the txtNumberOfDays object.

        txtNumberOfDays.Clear()
        lblTotalCost.Text = ""
        txtNumberOfDays.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the window and terminates the application

        Close()
    End Sub
End Class
