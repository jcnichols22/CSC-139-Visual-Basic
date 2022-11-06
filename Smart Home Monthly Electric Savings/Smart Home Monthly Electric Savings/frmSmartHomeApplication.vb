' Program Name: Smart Home Monthly Electric Savings
' Author:       Josh Nichols
' Date:         April 15, 2022
' Purpose:      Displays savings for each month from smart home

Option Strict On
Public Class frmSmartHomeApplication
    Dim intSize As Integer = 11
    Dim strMonths(intSize) As String
    Dim decSavings(intSize) As Decimal
    Dim index As Integer
    Private Sub FrmSmartHome_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Variable declaration
        Dim objReader As IO.StreamReader
        Dim strLocationAndNameOfFile As String = "C:\Users\jcnic\Documents\School\CSC 139 Visual BASIC Programming\Smart Home Monthly Electric Savings\savings.txt"
        Dim strFileError As String = "The file is not available. Restart when the file is available"
        Dim intCount As Integer = 0, intFill As Integer

        ' checks for file 
        If IO.File.Exists(strLocationAndNameOfFile) Then
            objReader = IO.File.OpenText(strLocationAndNameOfFile)
            Do While objReader.Peek <> -1
                strMonths(intCount) = objReader.ReadLine()
                decSavings(intCount) = Convert.ToDecimal(objReader.ReadLine())
                intCount += 1
            Loop
            objReader.Close()
            For intFill = 0 To (strMonths.GetLength(0) - 1)
                cboMonth.Items.Add(strMonths(intFill))
            Next
        Else
            MsgBox(strFileError, , "Error")
            Close()
        End If
    End Sub

    Private Sub CboMonth_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMonth.SelectedIndexChanged
        btnStatistics.Visible = True
        If cboMonth.SelectedIndex <> -1 Then
            index = cboMonth.SelectedIndex
        End If
    End Sub

    Private Sub BtnStatistics_Click(sender As Object, e As EventArgs) Handles btnStatistics.Click
        ' this button displays all the information for each months saviings 
        lblSavings.Text = String.Format("The electric savings for {0} is {1}", strMonths(index), decSavings(index).ToString("C"))
        Dim intiterations As Integer = 0
        Dim decTotalSavings As Decimal
        Dim decAverageSavings As Decimal
        Do While intiterations <> 12
            decTotalSavings += decSavings(intiterations)
            intiterations += 1
        Loop
        decAverageSavings = decTotalSavings / 12
        lblAverageSavings.Text = String.Format("The average monthly savings: {0}", decAverageSavings.ToString("C"))
        lblMostSavings.Text = String.Format("{0} had the most significant monthly savings", strMonths(Array.IndexOf(decSavings, decSavings.Max())))
        MakeLabelsVisible()
    End Sub

    Private Sub MakeLabelsVisible()
        ' Makes all the labels visible
        lblSavings.Visible = True
        lblAverageSavings.Visible = True
        lblMostSavings.Visible = True
    End Sub
End Class
