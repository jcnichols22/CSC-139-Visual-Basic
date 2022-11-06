'Program:       Simple Calculator
'Developer:     Josh Nichols
'Date:          March 2, 2022
'Purpose:       The purpose of this application is to allow the user to input using text or buttons 2 operands
'               that can be used for basic arithmatic and then a result is displayed to the user.

Option Strict On
Public Class frmSimpleCalculator

    'Variables Declared here
    Dim currTextBox As TextBox
    Dim Operand1 As Integer
    Dim Operand2 As Integer
    Dim Result As Integer

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' this event handler will take the operands entered in the 2 text boxes and add them together
        ' assignng the value to result then format the output to the lblResult

        Operand1 = CInt(txtOperand1.Text)
        Operand2 = CInt(txtOperand2.Text)

        'Processing
        Result = Operand1 + Operand2

        'output
        lblResult.Text = Operand1 & " + " & Operand2 & " = " & Result
    End Sub

    Private Sub btnMinus_Click(sender As Object, e As EventArgs) Handles btnMinus.Click
        ' this event handler will take the operands entered in the 2 text boxes and subtract them
        ' assignng the value to result then format the output to the lblResult

        Operand1 = CInt(txtOperand1.Text)
        Operand2 = CInt(txtOperand2.Text)

        'Processing
        Result = Operand1 - Operand2

        'output
        lblResult.Text = Operand1 & " - " & Operand2 & " = " & Result
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ' this event handler will take the operands entered in the 2 text boxes and multiply them together
        ' assignng the value to result then format the output to the lblResult

        Operand1 = CInt(txtOperand1.Text)
        Operand2 = CInt(txtOperand2.Text)

        'Processing
        Result = Operand1 * Operand2

        'output
        lblResult.Text = Operand1 & " x " & Operand2 & " = " & Result
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        ' this event handler will take the operands entered in the 2 text boxes and divide them
        ' assignng the value to result then format the output to the lblResult

        Operand1 = CInt(txtOperand1.Text)
        Operand2 = CInt(txtOperand2.Text)

        'Processing
        Result = CInt(Operand1 / Operand2)

        'output
        lblResult.Text = Operand1 & " / " & Operand2 & " = " & Result.ToString("F2")
    End Sub

    Private Sub frmSimpleCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'This event handler clears both of the txt boxes as well as the result label
        'This also sets the focus on the txtOperand1 box when the form loads

        txtOperand1.Clear()
        txtOperand2.Clear()
        lblResult.Text = ""
        txtOperand1.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'This event handler will clear both txt boxes and the result label of any text and reset the focus to the lblOperand1
        'this allows the program to be used again.

        txtOperand1.Clear()
        txtOperand2.Clear()
        lblResult.Text = ""
        txtOperand1.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'This closes the program
        Close()
    End Sub

    Private Sub txtOperand1_Enter(sender As Object, e As EventArgs) Handles txtOperand1.Enter

        currTextBox = txtOperand1
    End Sub

    Private Sub txtOperand2_Enter(sender As Object, e As EventArgs) Handles txtOperand2.Enter
        currTextBox = txtOperand2
    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        'takes the value of currTextBox and contintues to append 1 everytime the 1 button is selected

        currTextBox.Text = currTextBox.Text & "1"
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        'takes the value of currTextBox and contintues to append 2 everytime the 2 button is selected

        currTextBox.Text = currTextBox.Text & "2"
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        'takes the value of currTextBox and contintues to append 3 everytime the 3 button is selected

        currTextBox.Text = currTextBox.Text & "3"
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        'takes the value of currTextBox and contintues to append 4 everytime the 4 button is selected

        currTextBox.Text = currTextBox.Text & "4"
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        'takes the value of currTextBox and contintues to append 5 everytime the 5 button is selected

        currTextBox.Text = currTextBox.Text & "5"
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        'takes the value of currTextBox and contintues to append 6 everytime the 6 button is selected

        currTextBox.Text = currTextBox.Text & "6"
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        'takes the value of currTextBox and contintues to append 7 everytime the 7 button is selected

        currTextBox.Text = currTextBox.Text & "7"
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        'takes the value of currTextBox and contintues to append 8 everytime the 8 button is selected

        currTextBox.Text = currTextBox.Text & "8"
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        'takes the value of currTextBox and contintues to append 9 everytime the 9 button is selected

        currTextBox.Text = currTextBox.Text & "9"
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        'takes the value of currTextBox and contintues to append 0 everytime the 0 button is selected

        currTextBox.Text = currTextBox.Text & "0"
    End Sub
End Class
