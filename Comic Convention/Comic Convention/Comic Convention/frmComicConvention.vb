' Program Name: Comic Convention Registration
' Author:       Josh Nichols
' Date:         February 23, 2022
' Purpose:      Allows a user to enter a group size then select a registartion type
'               the program will then calcualte and display a total price for the 
'               specified group size.

Option Strict On
Public Class frmComicConvention
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' this event handler calculates the cost of comic convention registration based on a group size

        ' Variable Declarations
        Dim decTotalPrice As Decimal
        Dim decGroupSize As Decimal
        Dim decSuperheroPrice As Decimal = 380D
        Dim decAutographsPrice As Decimal = 275D
        Dim decConventionPrice As Decimal = 209D

        'Did the user enter a numeric value?
        If IsNumeric(txtGroupSize.Text) Then
            decGroupSize = Convert.ToDecimal(txtGroupSize.Text)
            ' Is the group greater than 20
            If decGroupSize > 20 Then
                MsgBox("Please enter a valid group size", , "Input Error")
                txtGroupSize.Clear()
                txtGroupSize.Focus()
            End If
            ' Is group greater than zero
            If decGroupSize > 0 Then
                ' Dtermine price for groups
                If radSuperhero.Checked Then
                    decTotalPrice = decGroupSize * decSuperheroPrice
                ElseIf radAutographs.Checked Then
                    decTotalPrice = decGroupSize * decAutographsPrice
                ElseIf radConvention.Checked Then
                    decTotalPrice = decGroupSize * decConventionPrice
                End If
                ' Display group totals
                lblTotal.Text = decTotalPrice.ToString("C")

            Else
                ' Display error message if user entered a negative value
                MsgBox("Please enter a poistive number", , "Input Error")
                txtGroupSize.Clear()
                txtGroupSize.Focus()

            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter the group number please", , "Input Error")
            txtGroupSize.Clear()
            txtGroupSize.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler clears the group size text and the total text and also removes 
        ' radio button selections for use to run the program again.

        radAutographs.Checked = False
        radSuperhero.Checked = False
        radConvention.Checked = False
        txtGroupSize.Clear()
        txtGroupSize.Focus()
        lblTotal.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event hanlder sets the focus on the group size box and clears the total when the program loads

        txtGroupSize.Focus()
        lblTotal.Text = ""
    End Sub
End Class
