' Program Name: Building Plans Conversion
' Author:       Josh Nichols
' Date:         February 23, 2022
' Purpose:      This program allows the user to input a measurement and convert that to 
'               either inches or meters depending on which is selected.

Option Strict On
Public Class frmBuildPlansConversion
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' This event handler takes the user input then calculates and displays a measurement 
        ' based on which radio button is selected

        ' Variable Declaration
        Dim decInchEqual As Decimal = 0.0254D
        Dim decMeterEqual As Decimal = 39.37008D
        Dim decNumber As Decimal
        Dim decTotal As Decimal

        ' Did user enter a numeric value?
        If IsNumeric(txtNumber.Text) Then
            decNumber = Convert.ToDecimal(txtNumber.Text)
            'Is Square Footage Greater than zero
            If decNumber > 0 Then
                ' Determine cost per square foot
                If radImperialToMetric.Checked Then
                    decTotal = decNumber * decMeterEqual
                    lblTotal.Text = ("Your measurement converted to Metric is: " & decTotal.ToString("N3"))
                ElseIf radMetricToImperial.Checked Then
                    decTotal = decNumber * decInchEqual
                    lblTotal.Text = ("Your measurement converted to Imperial is: " & decTotal.ToString("N3"))
                End If

            Else
                ' Display error message if user entered a negative value
                MsgBox("You entered " & decNumber.ToString() & ". Enter a Positive Number", , "Input Error")
                txtNumber.Text = ""
                txtNumber.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter a measurement to convert", , "Input Error")
            txtNumber.Text = ""
            txtNumber.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' this event handler clears the total text and number text 
        ' it also deselects all radio buttons for the program to be used again

        lblTotal.Text = ""
        txtNumber.Clear()
        txtNumber.Focus()
        radImperialToMetric.Checked = False
        radMetricToImperial.Checked = False
    End Sub

    Private Sub frmBuildPlansConversion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event handler clears the total text and sets the focus on the number box when the program starts

        lblTotal.Text = ""
        txtNumber.Focus()

    End Sub
End Class
