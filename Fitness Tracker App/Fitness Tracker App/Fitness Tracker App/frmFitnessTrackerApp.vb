' Program:      Fitness Tracker App
' Developer:    Josh Nichols
' Date:         February 6, 2022
' Purpose:      Allows the user to enter the current date and their birthdate
'               program then calculates and shows the user a total number of hours
'               they have exercised in their lifetime

Option Strict On

Public Class frmFitnessTrackerApp
    ' Constant variables used for calculation
    Const _cdecHoursInDay As Decimal = 24D
    Const _cdecDaysPerYear As Decimal = 365D
    Const _cdecDaysPerMonth As Decimal = 30D
    Const _cdecAverageHoursPerWeek As Decimal = 2.5D
    Const _cdecDaysInAWeek As Decimal = 7D


    Private Sub frmFitnessTrackerApp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Sets the focus on the Name text box for input and clears the total hours label

        txtName.Focus()
        lblHoursTotal.Text = ""

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This is where variables are established and calculations are made to process the 
        ' given input for the appropriate output

        ' Variables for birthdate
        Dim strBirthMonth As String
        Dim strBirthDay As String
        Dim strBirthYear As String
        Dim decBirthMonth As Decimal
        Dim decBirthDay As Decimal
        Dim decBirthYear As Decimal

        ' variables for current date 
        Dim strCurrentMonth As String
        Dim strCurrentDay As String
        Dim strCurrentYear As String
        Dim decCurrentMonth As Decimal
        Dim decCurrentDay As Decimal
        Dim decCurrentYear As Decimal

        Dim decMonthsToDays As Decimal
        Dim decTotalDays As Decimal
        Dim decDays As Decimal
        Dim decYearsToDays As Decimal
        Dim decTotalHoursWorked As Decimal
        Dim strName As String = txtName.Text

        'Birth Date Conversions
        strBirthMonth = txtBirthMonth.Text
        decBirthMonth = Convert.ToDecimal(strBirthMonth)
        strBirthDay = txtBirthDay.Text
        decBirthDay = Convert.ToDecimal(strBirthDay)
        strBirthYear = txtBirthYear.Text
        decBirthYear = Convert.ToDecimal(strBirthYear)

        'Current Date Conversions
        strCurrentMonth = txtCurrentMonth.Text
        decCurrentMonth = Convert.ToDecimal(strCurrentMonth)
        strCurrentDay = txtCurrentDay.Text
        decCurrentDay = Convert.ToDecimal(strCurrentDay)
        strCurrentYear = txtCurrentYear.Text
        decCurrentYear = Convert.ToDecimal(strCurrentYear)

        'Calculations
        decYearsToDays = (decCurrentYear - decBirthYear) * _cdecDaysPerYear
        decMonthsToDays = (decCurrentMonth - decBirthMonth) * _cdecDaysPerMonth
        decDays = (decCurrentDay + decBirthDay) / _cdecDaysPerYear
        decTotalDays = decYearsToDays + decMonthsToDays + decDays
        Dim decAverageHoursPerDay As Decimal = _cdecAverageHoursPerWeek / _cdecDaysInAWeek
        decTotalHoursWorked = decTotalDays * decAverageHoursPerDay

        lblHoursTotal.Text = strName + " " + "has worked out " + decTotalHoursWorked.ToString("F") + " hours in their lifetime."

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This will clear all the txt boxes and the hours total label to reset the program
        ' To be used again and repeat the process.

        txtName.Focus()
        txtName.Clear()
        txtBirthMonth.Clear()
        txtBirthDay.Clear()
        txtBirthYear.Clear()
        txtCurrentMonth.Clear()
        txtCurrentDay.Clear()
        txtCurrentYear.Clear()
        lblHoursTotal.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the application

        Close()
    End Sub
End Class

