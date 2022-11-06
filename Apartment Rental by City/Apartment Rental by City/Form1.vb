Public Class Form1
    'Below are the global variables for storing the list of city
    'and list of correnponding rentals
    Private Shared cityList As New List(Of String)
    Private Shared rentList As New List(Of Integer)

    'This is the button click event for calculating the Average Rental of Cities
    Private Sub btnComputeAverage_Click(sender As Object, e As EventArgs) Handles btnComputeAverage.Click
        Dim averageRental As Double = rentList.Average()

        'Adding value to label that shows the City Rental Average
        lblRentalAvg.Text = "Average Rental City Cost $" & averageRental
    End Sub

    'This is the event which triggers when any value selected in the City List box
    Private Sub lbCity_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbCity.SelectedIndexChanged
        Dim cityIndex As Integer = cityList.IndexOf(lbCity.SelectedItem)

        'Adding value to label that shows the City Rental
        lblRentalCost.Text = "The selected city rental's median cost of $" & rentList(cityIndex)
    End Sub

    'This is the onload event of Form, this event will be triggers when you start
    'running the project
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'The below line is the linq query which fetches the data from the file that mentioned in string format
        'Please give appropriate location of rental.txt file to read the data
        Dim lines = (From line In IO.File.ReadAllLines("C:\Users\jcnic\Documents\School\CSC 139 Visual BASIC Programming\Apartment Rental by City\rentals.txt")
                     Select line.Split(CChar(vbTab))).ToArray

        'By using the variable lines(which holds all the data of rentals.txt file)
        'the loop below is declared to split the string and numbers
        For i As Integer = 0 To lines.GetUpperBound(0)
            'The variable lineStr holds the single line data
            Dim lineStr As String = lines(i)(0)
            'The below variable declared to get only the numbers from the string
            'Here i used linq query to get only the numbers from string
            Dim lineNumber As String = New String((From c As Char In lineStr Select c Where Char.IsDigit(c)).ToArray())

            'The below two lines are for adding the splitted rental and city name in City List and Rental List
            'global varaible
            cityList.Add(lineStr.Substring(0, lineStr.IndexOf(lineNumber)))
            rentList.Add(lineNumber)
        Next

        'Once the global varaiables filled with data
        'The List Box that decalred in the form is filled with City List
        'So based in the city selection the rental of selected city will be displayed
        lbCity.DataSource = Nothing
        lbCity.DataSource = cityList
    End Sub

    'This is the event of Clear form button
    'Which clears the value in labels that shows the City Rental and City Rental Avreage
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblRentalCost.Text = ""
        lblRentalAvg.Text = ""
    End Sub

    'Below is the event to Exit the form
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    'This is the event which triggered once the Menu Item with name 'Top Ten City Rental' is selected
    Private Sub TopTenCitiesRentalCostToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TopTenCitiesRentalCostToolStripMenuItem.Click
        'The below variable calls the DisplayRentalForm
        Dim displayRentalForm = New DisplayRentalForm()

        'The list box for City is filled with City List data
        displayRentalForm.lbCityList.DataSource = Nothing
        displayRentalForm.lbCityList.DataSource = cityList

        'The list box for Rental is filled with Rental List data
        displayRentalForm.lbRentalList.DataSource = Nothing
        displayRentalForm.lbRentalList.DataSource = rentList

        'The below line makes the DisplayRentalForm to display
        displayRentalForm.Show()
    End Sub

End Class