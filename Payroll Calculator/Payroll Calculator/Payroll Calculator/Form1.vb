' Program:      Payroll Calculator
' Developer:    Josh Nichols
' Date:         February 5, 2022
' Purpose:      Allows the user to enter gross weekly pay then calculates
'               the totals of FICA, Federal, and state taxes and displays each
'               It then displays the total Net Pay after taces are calculated.

Option Strict On

Public Class frmPayrollCalculator
    'Constant variables to be used for calculations
    Const _cdecFicaPercent As Decimal = 0.0765D
    Const _cdecFederalPercent As Decimal = 0.22D
    Const _cdecStatePercent As Decimal = 0.04D

    Private Sub frmPayrollCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This clears the tax and net pay labels when the user opens the program
        ' This also sets the focus on the Gross Weekly text box for input
        lblFicaTotal.Text = ""
        lblFederalTotal.Text = ""
        lblStateTotal.Text = ""
        lblNetPayTotal.Text = ""
        txtGrossWeekly.Focus()
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' When the calculate button is pressed this will take that text from the input box and convert it
        ' to a decimal the uses that for calculation then display the outputs in currency format. 

        ' here we assign some variables to be used for calculations
        Dim strGrossPay As String
        Dim decGrossPay As Decimal
        Dim decFicaTotal As Decimal
        Dim decFederalTotal As Decimal
        Dim decStateTotal As Decimal
        Dim decNetPayTotal As Decimal

        ' Here is where we use our variables as well as our constants for calculation of the respected totals of taxes
        strGrossPay = txtGrossWeekly.Text
        decGrossPay = Convert.ToDecimal(strGrossPay)
        decFicaTotal = decGrossPay * _cdecFicaPercent
        decFederalTotal = decGrossPay * _cdecFederalPercent
        decStateTotal = decGrossPay * _cdecStatePercent
        decNetPayTotal = decGrossPay - decFicaTotal - decFederalTotal - decStateTotal
        lblFicaTotal.Text = decFicaTotal.ToString("C")
        lblFederalTotal.Text = decFederalTotal.ToString("C")
        lblStateTotal.Text = decStateTotal.ToString("C")
        lblNetPayTotal.Text = decNetPayTotal.ToString("C")


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' When the user clicks clear the text box and all the total labels are cleared and reset
        ' for the program to be used again, also resets the focus on the Gross Weekly text box.

        txtGrossWeekly.Clear()
        lblFicaTotal.Text = ""
        lblFederalTotal.Text = ""
        lblStateTotal.Text = ""
        lblNetPayTotal.Text = ""
        txtGrossWeekly.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes and exits the program.

        Close()
    End Sub
End Class
