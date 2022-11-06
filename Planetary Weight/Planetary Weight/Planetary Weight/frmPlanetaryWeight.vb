' Program Name: Planetary Weight
' Author:       Josh Nichols
' Date:         February 23, 2022
' Purpose:      This windows application computes the users estimated weight on Venus and Mars

Option Strict On

Public Class frmPlanetaryWeight
    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        ' The btnDisplay event handler calculates the weight of the user on Venus or Mars

        ' Variable Declartions
        Dim decUserWeight As Decimal
        Dim decFinalWeight As Decimal
        Dim decWeightOnPlanetPounds As Decimal
        Dim decWeightOnPlanetKilo As Decimal
        Dim decPoundOnVenus As Decimal = 0.907D
        Dim decPoundOnMars As Decimal = 0.377D
        Dim decPoundinKilograms As Decimal = 0.454D

        ' Check for numeric value
        If IsNumeric(txtWeight.Text) Then
            decUserWeight = Convert.ToDecimal(txtWeight.Text)
            'Is weight greater than 0
            If decUserWeight > 0 Then
                ' Determine weights
                If radMars.Checked Then
                    decWeightOnPlanetPounds = decUserWeight * decPoundOnMars
                    decWeightOnPlanetKilo = decWeightOnPlanetPounds * decPoundinKilograms
                    lblWeightFinal.Text = ("Your weight on Mars is " & decWeightOnPlanetPounds.ToString("N1") & " lbs or " & decWeightOnPlanetKilo.ToString("N1") & " kg.")

                ElseIf radVenus.Checked Then
                    decWeightOnPlanetPounds = decUserWeight * decPoundOnVenus
                    decWeightOnPlanetKilo = decWeightOnPlanetPounds * decPoundinKilograms
                    lblWeightFinal.Text = ("Your weight on Venus is " & decWeightOnPlanetPounds.ToString("N1") & " lbs or " & decWeightOnPlanetKilo.ToString("N1") & " kg.")

                End If

            Else
                ' Display error message if blank input
                MsgBox("Please enter a number", , "Input Error")
                txtWeight.Text = ""
                txtWeight.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter your weight in numbers", , "Input Error")
            txtWeight.Text = ""
            txtWeight.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' the btnClear event handler will clear the txtWeight box and the lblFinalWeight text 
        ' in order to make more calculations

        lblWeightFinal.Text = ""
        txtWeight.Clear()

    End Sub

    Private Sub frmPlanetaryWeight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' this event handler is executed when the form loads. It applies a focus on the txtWeight box
        ' for user input. It also clears the lblWeightFinal text.

        txtWeight.Focus()
        lblWeightFinal.Text = ""
    End Sub
End Class
