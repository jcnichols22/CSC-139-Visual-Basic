' Program Name: Internet Speed Test Survey
' Author:       Josh Nichols
' Date:         March 26, 2022
' Purpose:      This program takes the input of 10 different speed tests
'               Then calculates the average internet speed based on those tests.

Option Strict On

Public Class frmInternetSpeedTest
    Private Sub btnInternetSpeed_Click(sender As Object, e As EventArgs) Handles btnInternetSpeed.Click
        ' The btnInternetSpeed_Click event accepts and displays up to 10 speed tests
        ' and then calculates and displays the average speed tests for the month

        ' Declare and initalize variables
        Dim strInternetSpeed As String
        Dim decInternetSpeed As Decimal
        Dim decAverageInternetSpeed As Decimal
        Dim decTotalInternetSpeed As Decimal
        Dim strInputMessage As String = "Enter the Internet Speed for day #"
        Dim strInputHeading As String = "Internet Speed"
        Dim strNormalMessage As String = "Enter the Internet Speed for day #"
        Dim strNonNumericError As String = "Error - Enter a number for the Internet Speed of day #"
        Dim strNegativeError As String = "Error - Enter a positive number for the Internet Speed of day #"

        'Declare and initialize loop variables
        Dim strCancelClicked As String = ""
        Dim intMaxNumberOfEntries As Integer = 10
        Dim intNumberOfEntries As Integer = 1

        ' This loop allows the user to enter the Internet speed of up to 10 tests.
        ' The loop terminates when the user has entered 10 speed test values
        strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")

        Do Until intNumberOfEntries > intMaxNumberOfEntries Or strInternetSpeed = strCancelClicked
            If IsNumeric(strInternetSpeed) Then
                decInternetSpeed = Convert.ToDecimal(strInternetSpeed)
                If decInternetSpeed > 0 Then
                    lstInternetSpeed.Items.Add(decInternetSpeed)
                    decTotalInternetSpeed += decInternetSpeed
                    intNumberOfEntries += 1
                    strInputMessage = strNormalMessage
                Else
                    strInputMessage = strNegativeError
                End If
            Else
                strInputMessage = strNonNumericError
            End If
            If intNumberOfEntries <= intMaxNumberOfEntries Then
                strInternetSpeed = InputBox(strInputMessage & intNumberOfEntries, strInputHeading, " ")
            End If
        Loop

        'Calculates and displays average Internet Speed
        If intNumberOfEntries > 1 Then
            lblAverageSpeed.Visible = True
            decAverageInternetSpeed = decTotalInternetSpeed / (intNumberOfEntries - 1)
            lblAverageSpeed.Text = "Average Internet Speed is " &
                decAverageInternetSpeed.ToString("F2") & " Mbps"
        Else
            MsgBox("No Internet Speed value entered")
        End If

        'disables the internet speed button
        btnInternetSpeed.Enabled = False
    End Sub
End Class
