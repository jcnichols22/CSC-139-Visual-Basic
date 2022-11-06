' Title:    Gaming Art Windows Application
' Author:   Josh Nichols
' Date:     April 18, 2022
' Purpose:  The application displays the game design artists who have entered the Game Art &
'           design competiton as an interface for a Microsfot Access database. 

Public Class frmArt
    Private Sub ArtistBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles ArtistBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ArtistBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.ArtDataSet)

    End Sub

    Private Sub frmArt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ArtDataSet.Artist' table. You can move, or remove it, as needed.
        Me.ArtistTableAdapter.Fill(Me.ArtDataSet.Artist)

    End Sub

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        ' strSql is a SQL statement that selects all the fields from the 
        ' Artist table

        Dim strSql As String = "SELECT * FROM Artist"

        ' strPath provides the database type and path of the Art database
        Dim strPath As String = "Provider=Microsoft.ACE.OLEDB.12.0 ;" & "Data Source=C:\Users\jcnic\Documents\School\CSC 139 Visual BASIC Programming\1337102113_581194\Hoisington Visual Basic Data Files9781337102117\Chapter 10\Art.accdb"
        Dim odaArtist As New OleDb.OleDbDataAdapter(strSql, strPath)
        Dim datValue As New DataTable
        Dim intCount As Integer
        Dim decTotalValue As Decimal = 0D

        ' The DataTable named datValue is filled with the table data
        odaArtist.Fill(datValue)
        ' The connection to the database is disconnected
        odaArtist.Dispose()
        For intCount = 0 To datValue.Rows.Count - 1
            decTotalValue += Convert.ToDecimal(datValue.Rows(intCount)("Retail Price"))
        Next
        lblTotalRetailValue.Visible = True
        lblTotalRetailValue.Text = "The Total Retail Value is " & decTotalValue.ToString("C")
    End Sub
End Class
