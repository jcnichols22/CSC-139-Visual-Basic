' Program Name: Karaoke Music Night
' Author:       Josh Nichols
' Date:         March 30, 2022
' Purpose:      Allows the user to select from 2 Karaoke options and with an entered number of songs/hours provide a total price for visit

Option Strict On

Public Class frmKaraokeMusicNight
    Private Sub cboKaraokeSelection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKaraokeSelection.SelectedIndexChanged
        ' This Event Handler allows the user to enter the karaoke selection and then calls subprocedures to display information
        ' based on the selection type
        Dim intKaraokeSelection As Integer

        intKaraokeSelection = cboKaraokeSelection.SelectedIndex
        lblRentalType.Text = ""
        Select Case intKaraokeSelection
            Case 0
                lblRentalType.Text = "Please enter a number of songs"
            Case 1
                lblRentalType.Text = "Please enter a number of hours to rent room"
        End Select

        'Make Items Visible in window
        lblRentalType.Visible = True
        txtNumberOfHoursOrSongs.Visible = True
        btnTotalCost.Visible = True
        btnClear.Visible = True
        lblTotalCost.Visible = True

        'Clear the total label
        lblTotalCost.Text = ""

        'set focus on number of tickets
        txtNumberOfHoursOrSongs.Focus()
    End Sub

    Private Function ValidateNumberOfHoursOrSongs() As Boolean
        ' This procedure validates the value entered for the amount of hours or songs
        Dim intNumberOfHoursOrSongs As Integer
        Dim blnValidityCheck As Boolean = False
        Dim strNumberOfHoursOrSongsMessage As String = "Please enter a number you would like to purchase"
        Dim strMessageBoxTitle As String = "Error"

        Try
            intNumberOfHoursOrSongs = Convert.ToInt32(txtNumberOfHoursOrSongs.Text)
            'checks if numeric and poistive number
            If (IsNumeric(intNumberOfHoursOrSongs) And intNumberOfHoursOrSongs >= 0) Then
                blnValidityCheck = True
            Else
                MsgBox(strNumberOfHoursOrSongsMessage, , strMessageBoxTitle)
                txtNumberOfHoursOrSongs.Focus()
                txtNumberOfHoursOrSongs.Clear()
            End If
        Catch Exception As FormatException
            MsgBox(strNumberOfHoursOrSongsMessage, , strMessageBoxTitle)
            txtNumberOfHoursOrSongs.Focus()
            txtNumberOfHoursOrSongs.Clear()
        Catch Exception As OverflowException
            MsgBox(strNumberOfHoursOrSongsMessage, , strMessageBoxTitle)
            txtNumberOfHoursOrSongs.Focus()
            txtNumberOfHoursOrSongs.Clear()
        Catch Exception As SystemException
            MsgBox(strNumberOfHoursOrSongsMessage, , strMessageBoxTitle)
            txtNumberOfHoursOrSongs.Focus()
            txtNumberOfHoursOrSongs.Clear()
        End Try
        Return blnValidityCheck
    End Function

    Private Function PerSongCost(ByVal intNumberOfHoursOrSongs As Integer, ByVal decTicketChoice As Decimal) As Decimal
        ' This function calculates the cost of the per song price
        Dim decPerSongPrice As Decimal = 2.99D
        Dim decFinalCost As Decimal

        decFinalCost = intNumberOfHoursOrSongs * decPerSongPrice
        Return decFinalCost
    End Function

    Private Function PerHourCost(ByVal intNumberOfHoursOrSongs As Integer, ByVal decTicketChoice As Decimal) As Decimal
        ' This function calculates the cost of the per hour
        Dim decPerHourPrice As Decimal = 8.99D
        Dim decFinalCost As Decimal

        decFinalCost = intNumberOfHoursOrSongs * decPerHourPrice
        Return decFinalCost
    End Function

    Private Sub btnTotalCost_Click(sender As Object, e As EventArgs) Handles btnTotalCost.Click
        Dim intNumberOfHoursOrSongs As Integer
        Dim blnNumberofTicketsIsValid As Boolean = False
        Dim decFinalCost As Decimal
        Dim decKaraokeSelection As Decimal

        ' call a function to ensure the number of tickets is valid
        blnNumberofTicketsIsValid = ValidateNumberOfHoursOrSongs()

        ' if number of tickets is valid calculate the cost
        If (blnNumberofTicketsIsValid) Then
            intNumberOfHoursOrSongs = Convert.ToInt32(txtNumberOfHoursOrSongs.Text)
            decKaraokeSelection = cboKaraokeSelection.SelectedIndex
            Select Case decKaraokeSelection
                Case 0
                    decFinalCost = PerSongCost(intNumberOfHoursOrSongs, decKaraokeSelection)
                Case 1
                    decFinalCost = PerHourCost(intNumberOfHoursOrSongs, decKaraokeSelection)
            End Select
            'Display the cost of the tickets
            lblTotalCost.Text = "Total Cost of Karaoke night - " & decFinalCost.ToString("C")

        End If
    End Sub

    Private Sub frmKaraokeMusicNight_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Hold the splas screen for 3 seconds
        Threading.Thread.Sleep(3000)
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' This event handler clears the form and resets the form for reuse when the user clicks the clear button.

        lblTotalCost.Text = ""
        txtNumberOfHoursOrSongs.Clear()
        lblRentalType.Visible = False
        txtNumberOfHoursOrSongs.Visible = False
        btnTotalCost.Visible = False
        btnClear.Visible = False
        lblTotalCost.Visible = False
    End Sub
End Class
