' Program Name: Factorial Calculator        
' Author:       Josh Nichols
' Date:         March 27, 2022
' Purpose:      The Factorial Calculator takes input from the user then calculates
'               the factorials from 1 up to the users selection

Public Class frmFactorialCalculator
    Private Sub btnEnterValue_Click(sender As Object, e As EventArgs) Handles btnEnterValue.Click
        ' This event handler takes user input and the using the factorial funtion will calculate the factorial of all numbers 
        ' from 1 up to the user seclection

        'Variable declartions
        Dim strUserInput As String
        Dim intValue As Integer
        Dim intFactorial As Long
        Dim intUserInput As Integer

        ' taking user input and assigning it to a variable for use
        strUserInput = InputBox("Please enter a number from 1 to 12", "Factorial Selection")
        intUserInput = Convert.ToInt32(strUserInput)


        Do While intValue < intUserInput

            'intFactorial = Factorial(intValue)

            intValue += 1

            intFactorial = Factorial(intValue)

            lstFactorials.Items.Add(intValue.ToString() & "! " & intFactorial.ToString())
        Loop


    End Sub


    Public Function Factorial(value As Integer) As Long
        'function to calculate the factorial of a give number

        If value = 0 Then
            Return 1
        Else
            Return value * Factorial(value - 1)
        End If
    End Function

    Private Sub mnuClear_Click(sender As Object, e As EventArgs) Handles mnuClear.Click
        ' clears the Factorials list

        lstFactorials.Items.Clear()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Closes the program

        Close()
    End Sub
End Class
