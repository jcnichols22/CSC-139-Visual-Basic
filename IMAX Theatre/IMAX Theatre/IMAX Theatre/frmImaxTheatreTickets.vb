' Program Name: IMAX Theatre Tickets
' Author:       Josh Nichols
' Date:         March 30, 2022
' Purpose:      Allows the user to select from 2 tickets and with an entered number of guests provide a total price for visit

Option Strict On

Public Class frmImaxTheatreTickets

    Private Sub cboTickets_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTickets.SelectedIndexChanged
        ' this event handler allows the user to enter the ticket choice and then calls subprocedures to calculate the price
        Dim intTicketChoice As Integer

        intTicketChoice = cboTickets.SelectedIndex

        'Make items visibile in window 
        lblNumberOfTickets.Visible = True
        txtNumberOfTickets.Visible = True
        btnTicketCost.Visible = True
        btnClear.Visible = True
        lblTicketTotal.Visible = True

        ' Clear the total label

        lblTicketTotal.Text = ""

        ' set the focus on number of tickets
        txtNumberOfTickets.Focus()
    End Sub

    Private Function ValidateNumberOfTickets() As Boolean
        ' This procedure validates the value entered for the amount of tickets
        Dim intTicketNumber As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberOfTicketsMessage As String = "Please enter the number of tickets you would like to purchase"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intTicketNumber = Convert.ToInt32(txtNumberOfTickets.Text)
            'checks if numeric and poistive number
            If (IsNumeric(intTicketNumber) And intTicketNumber >= 0) Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
                txtNumberOfTickets.Focus()
                txtNumberOfTickets.Clear()
            End If
        Catch Exception As FormatException
            MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
            txtNumberOfTickets.Focus()
            txtNumberOfTickets.Clear()
        Catch Exception As OverflowException
            MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
            txtNumberOfTickets.Focus()
            txtNumberOfTickets.Clear()
        Catch Exception As SystemException
            MsgBox(strNumberOfTicketsMessage, , strMessageBoxTitle)
            txtNumberOfTickets.Focus()
            txtNumberOfTickets.Clear()
        End Try
        Return blnValidityCheck
    End Function


    Private Function MatineeCost(ByVal intTicketNumber As Integer, ByVal decTicketChoice As Decimal) As Decimal
        ' This function calculates the cost of the matinee ticket
        Dim decMatineePrice As Decimal = 16D
        Dim decFinalCost As Decimal

        decFinalCost = intTicketNumber * decMatineePrice
        Return decFinalCost
    End Function

    Private Function EveningCost(ByVal intTicketNumber As Integer, ByVal decTicketChoice As Decimal) As Decimal
        ' This function calculates the cost of the matinee ticket
        Dim decEveningPrice As Decimal = 27D
        Dim decFinalCost As Decimal

        decFinalCost = intTicketNumber * decEveningPrice
        Return decFinalCost
    End Function

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clears the form and resets the form for reuse when the user clicks the clear button.

        txtNumberOfTickets.Clear()
        lblTicketTotal.Text = ""
        lblNumberOfTickets.Visible = False
        txtNumberOfTickets.Visible = False
        btnTicketCost.Visible = False
        btnClear.Visible = False
        lblTicketTotal.Visible = False

    End Sub

    Private Sub btnTicketCost_Click(sender As Object, e As EventArgs) Handles btnTicketCost.Click
        Dim intTicketNumber As Integer
        Dim blnNumberofTicketsIsValid As Boolean = False
        Dim decFinalCost As Decimal
        Dim decTicketChoice As Decimal

        ' call a function to ensure the number of tickets is valid
        blnNumberofTicketsIsValid = ValidateNumberOfTickets()

        ' if number of tickets is valid calculate the cost
        If (blnNumberofTicketsIsValid) Then
            intTicketNumber = Convert.ToInt32(txtNumberOfTickets.Text)
            decTicketChoice = cboTickets.SelectedIndex
            Select Case decTicketChoice
                Case 0
                    decFinalCost = MatineeCost(intTicketNumber, decTicketChoice)
                Case 1
                    decFinalCost = EveningCost(intTicketNumber, decTicketChoice)
            End Select
            'Display the cost of the tickets
            lblTicketTotal.Text = decFinalCost.ToString("C") & " for the tickets"

        End If
    End Sub

    Private Sub frmImaxTheatreTickets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hold the splas screen for 5 seconds
        Threading.Thread.Sleep(5000)
    End Sub
End Class
