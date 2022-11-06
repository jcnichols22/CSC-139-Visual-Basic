' Program Name: Broadway Ticket Group Discount
' Author:       Josh Nichols
' Date:         February 24, 2022
' Purpose:      Allows the user to input a number of guests
'               the program then goes througha  selection of statements
'               and applies a discount for more tickets purchased.

Option Strict On
Public Class frmBroadwayTickets
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        ' Variable declaration
        Dim decTotal As Decimal
        Dim decNumOfGuests As Decimal
        Dim dec1to8Price As Decimal = 249D
        Dim dec9to12Price As Decimal = 219D
        Dim dec13to24Price As Decimal = 199D
        Dim dec25to99Price As Decimal = 169D

        ' Did user enter a numeric value?
        If IsNumeric(txtNumOfGuests.Text) Then
            decNumOfGuests = Convert.ToDecimal(txtNumOfGuests.Text)
            'Is Square Footage Greater than zero
            If decNumOfGuests > 0 Then
                If decNumOfGuests >= 1 And decNumOfGuests <= 8 Then
                    decTotal = decNumOfGuests * dec1to8Price
                ElseIf decNumOfGuests >= 9 And decNumOfGuests <= 12 Then
                    decTotal = decNumOfGuests * dec9to12Price
                ElseIf decNumOfGuests >= 13 And decNumOfGuests <= 24 Then
                    decTotal = decNumOfGuests * dec13to24Price
                ElseIf decNumOfGuests >= 25 And decNumOfGuests <= 99 Then
                    decTotal = decNumOfGuests * dec25to99Price
                End If
                ' Calculate and display the cost estime                
                lblTotal.Text = ("For your Group of " & txtNumOfGuests.Text & " the cost would be " & decTotal.ToString("C"))
            Else
                ' Display error message if user entered a negative value
                MsgBox("You entered " & decNumOfGuests.ToString() & ". Enter a Positive Number", , "Input Error")
                txtNumOfGuests.Text = ""
                txtNumOfGuests.Focus()
            End If
        Else
            ' Display error message if user entered a nonnumeric value
            MsgBox("Enter the square footage of Decking", , "Input Error")
            txtNumOfGuests.Text = ""
            txtNumOfGuests.Focus()
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler will clear the number of guests text box 
        ' it will also clear the total label and set the focus back on the num of guests text box

        txtNumOfGuests.Clear()
        txtNumOfGuests.Focus()
        lblTotal.Text = ""
    End Sub

    Private Sub frmBroadwayTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This handler loads the application with a focus on the number of guests text box
        ' and clears the total label text.

        txtNumOfGuests.Clear()
        txtNumOfGuests.Focus()
        lblTotal.Text = ""
    End Sub
End Class
