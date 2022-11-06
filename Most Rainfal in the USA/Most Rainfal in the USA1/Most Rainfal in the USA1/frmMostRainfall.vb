' Program Name: Most Rainfall in US
' Author:       Josh Nichols
' Date:         March 26, 2022
' Purpose:      The most rainfall in US program enters up to 12 amounts of rainfall for a month
'               the program then calcualtes the average rainfall for that month.

Option Strict On

Public Class frmMostRainfall
    Private Sub btnEnterRainfall_Click(sender As Object, e As EventArgs) Handles btnEnterRainfall.Click
        ' The btnEnterRainfall_Click event accepts and displays up to 12 rainfall values
        ' and then calculates and displays the average rainfall for the month

        ' Declare and initalize variables
        Dim strRainFall As String
        Dim decRainFall As Decimal
        Dim decAverageRainfall As Decimal
        Dim decTotalRainfall As Decimal
        Dim strInputMessage As String = "Enter the Rainfall for day #"
        Dim strInputHeading As String = "Rainfall"
        Dim strNormalMessage As String = "Enter the Rainfall for day #"
        Dim strNonNumericError As String = "Error - Enter a number for the Rainfall of day #"
        Dim strNegativeError As String = "Error - Enter a positive number for the rainfall of day #"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 12
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the rainfall of up to 12 days.
        ' The loop terminates when the user has entered 12 rainfall values or the user
        ' clicks the Cancel button or the Close button in the InputBox
        strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strRainFall = strCancelClicked
            If IsNumeric(strRainFall) Then
                decRainFall = Convert.ToDecimal(strRainFall)
                If decRainFall > 0 Then
                    lstRainfall.Items.Add(decRainFall)
                    decTotalRainfall += decRainFall
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strRainFall = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'Calculates and displays average rainfall
        If intNumberOfEntries > 1 Then
            lblAverageTotal.Visible = True
            decAverageRainfall = decTotalRainfall / (intNumberOfEntries - 1)
            lblAverageTotal.Text = "Average rainfall is " &
                decAverageRainfall.ToString("F1") & " inches"
        Else
            MsgBox("No Rainfall value entered")
        End If

        'disables the rainfall button
        btnEnterRainfall.Enabled = False
    End Sub

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' The mnuClear_Click event clears the ListBox object and hides
        ' the average rainfall label. it also enables the rainfall button

        lstRainfall.Items.Clear()
        lblAverageTotal.Visible = False
        btnEnterRainfall.Enabled = True
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' The mnuExit_Click event closes the window and exits the application

        Close()
    End Sub
End Class
