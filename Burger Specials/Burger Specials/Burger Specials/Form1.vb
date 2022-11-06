' Program Name: Burger Specials
' Developer:    Josh Nichols
' Date:         1/21/2022
' Purpose:      Program gives the user to select between 2 different burger specials
'               after a choice is made the user has the option to exit the program.
Public Class frmBurgerSpecials
    Private Sub btnPrimeBeef_Click(sender As Object, e As EventArgs) Handles btnPrimeBeef.Click
        ' When the Prime Beef button is seleceted the prime beef picture will become visible
        ' the veggie image will remina not visible and the Select Meal button will be enabled to allow 
        ' a meal to be selected.
        picPrimeBeef.Visible = True
        picVeggie.Visible = False
        btnSelect.Enabled = True

    End Sub

    Private Sub btnVeggie_Click(sender As Object, e As EventArgs) Handles btnVeggie.Click
        ' When the Veggie button is selected it will display the veggie burger and the prime beef burger will
        ' remain hidden. The Select Meal button is then enabled allowing the user to select the meal.
        picPrimeBeef.Visible = False
        picVeggie.Visible = True
        btnSelect.Enabled = True
    End Sub

    Private Sub btnSelect_Click(sender As Object, e As EventArgs) Handles btnSelect.Click
        ' here when the Select Meal button is clicked the choose message instrucion label becomes non visible
        ' the enjoy your meal message appears and the exit button is enabled the prime beef and veggie buttons are disabled.
        lblChooseMessage.Visible = False
        lblEnjoy.Visible = True
        btnExit.Enabled = True
        btnPrimeBeef.Enabled = False
        btnVeggie.Enabled = False

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' when the exit button is selected it will close the program. 
        Close()

    End Sub
End Class
