' Program:      Orlando AirBnB
' Developer:    Josh Nichols
' Date:         February 4, 2022
' Purpose:      This application calculates and displays the total
'               cost of an AirBnB rental for a specified numer of days.

Option Strict On

Public Class frmAirBnb

    ' Cost per night
    Const _cdecPricePerNight As Decimal = 79D

    Private Sub btnDisplayCost_Click(sender As Object, e As EventArgs) Handles btnDisplayCost.Click
        ' This is executed when the user clicks the 
        ' Display Cost button. It calculates and displays the cost
        ' of the AirBnB rented (number of nights times the cost per night)

        Dim strNumberOfNights As String
        Dim intNumberOfNights As Integer
        Dim decTotalCost As Decimal

        strNumberOfNights = txtNumberOfNights.Text
        intNumberOfNights = Convert.ToInt32(strNumberOfNights)
        decTotalCost = intNumberOfNights * _cdecPricePerNight
        lblTotalCost.Text = decTotalCost.ToString("C")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This is executed when the user clicks the Clear button.
        ' It clears the number of nights text box and the text property
        ' of the Total Cost label. It then sets the focus on
        ' the txtNumberOfNights textbox.

        txtNumberOfNights.Clear()
        lblTotalCost.Text = ""
        txtNumberOfNights.Focus()
    End Sub

    Private Sub frmAirBnb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This is executed when the form is loaded.
        ' It displays the cost heading, clears the text proper of
        ' the Total Cost label, and sets the focus 
        ' on the txtNumberOfNights textbox.

        lblPriceHeading.Text = "Only " & _cdecPricePerNight.ToString("C") & " Per Night"
        lblTotalCost.Text = ""
        txtNumberOfNights.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the window and terminates the application

        Close()
    End Sub
End Class
