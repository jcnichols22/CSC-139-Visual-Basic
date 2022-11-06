' Program Name: Drink Machine  
' Author:       Josh Nichols
' Date:         April 6, 2022
' Purpose:      Allows the user to click buttons to enter amounts then select a button for a drink


Public Class frmDrinkMachine

    'Declare variables for currency 
    Dim decNickel As Decimal
    Dim decDime As Decimal
    Dim decQuarter As Decimal
    Dim decDollar As Decimal
    Dim decDrinks As Decimal = 1.25D
    Dim decAmountInserted As Decimal


    Private Sub btnNickel_Click(sender As Object, e As EventArgs) Handles btnNickel.Click
        ' this button calculates a total that adds 5 cents to the total amount sets the change label to zero
        ' and turns off visibility to the enjoy pic
        decNickel = lblAmountTotal.Text
        decNickel = decNickel + 0.05
        lblAmountTotal.Text = decNickel.ToString("C")

        lblChangeTotal.Text = "$0.00"
        picEnjoy.Visible = False


    End Sub

    Private Sub btnDime_Click(sender As Object, e As EventArgs) Handles btnDime.Click
        ' This button adds 10 cents to the value in the total amount label sets the change label to zero
        ' and turns off visibility to the enjoy pic
        decDime = lblAmountTotal.Text
        decDime = decDime + 0.1
        lblAmountTotal.Text = decDime.ToString("C")

        lblChangeTotal.Text = "$0.00"
        picEnjoy.Visible = False
    End Sub

    Private Sub btnQuarter_Click(sender As Object, e As EventArgs) Handles btnQuarter.Click
        ' This button adds 25 cents to the calue in the total amount label sets the change label to zero
        ' and turns off visibility to the enjoy pic
        decQuarter = lblAmountTotal.Text
        decQuarter = decQuarter + 0.25
        lblAmountTotal.Text = decQuarter.ToString("C")

        lblChangeTotal.Text = "$0.00"
        picEnjoy.Visible = False
    End Sub

    Private Sub btnDollar_Click(sender As Object, e As EventArgs) Handles btnDollar.Click
        ' this button adds 1 dollar to the value in the total amount label sets the change label to zero
        ' and turns off visibility to the enjoy pic
        decDollar = lblAmountTotal.Text
        decDollar = decDollar + 1.0
        lblAmountTotal.Text = decDollar.ToString("C")

        lblChangeTotal.Text = "$0.00"
        picEnjoy.Visible = False
    End Sub

    Private Sub btnDrPepper_Click(sender As Object, e As EventArgs) Handles btnDrPepper.Click
        ' This button selects a drink telling the user to enter more money if less than the drink cost and displaying change if any
        decAmountInserted = lblAmountTotal.Text

        'if less than 1.25 tells the user how much more to enter
        If decAmountInserted < decDrinks Then
            lblInsertMore.Visible = True
            lblInsertMore.Text = "Please enter " & (decDrinks - decAmountInserted).ToString("C") & " more"
            lblChangeTotal.Text = "$0.00"
            picEnjoy.Visible = False

            ' calculates change resets the total amount entered label displays a picture saying enjoy and sets the insertmore label to blank
        Else

            lblChangeTotal.Text = (decAmountInserted - decDrinks).ToString("C")

            lblAmountTotal.Text = "$0.00"
            picEnjoy.Visible = True
            lblInsertMore.Text = ""

        End If

    End Sub

    Private Sub btnMtnDew_Click(sender As Object, e As EventArgs) Handles btnMtnDew.Click
        ' This button selects a drink telling the user to enter more money if less than the drink cost and displaying change if any
        decAmountInserted = lblAmountTotal.Text

        'if less than 1.25 tells the user how much more to enter
        If decAmountInserted < decDrinks Then
            lblInsertMore.Visible = True
            lblInsertMore.Text = "Please enter " & (decDrinks - decAmountInserted).ToString("C") & " more"
            lblChangeTotal.Text = "$0.00"
            picEnjoy.Visible = False

            ' calculates change resets the total amount entered label displays a picture saying enjoy and sets the insertmore label to blank
        Else

            lblChangeTotal.Text = (decAmountInserted - decDrinks).ToString("C")

            lblAmountTotal.Text = "$0.00"
            picEnjoy.Visible = True
            lblInsertMore.Text = ""

        End If
    End Sub

    Private Sub btnCoke_Click(sender As Object, e As EventArgs) Handles btnCoke.Click
        ' This button selects a drink telling the user to enter more money if less than the drink cost and displaying change if any
        decAmountInserted = lblAmountTotal.Text

        'if less than 1.25 tells the user how much more to enter
        If decAmountInserted < decDrinks Then
            lblInsertMore.Visible = True
            lblInsertMore.Text = "Please enter " & (decDrinks - decAmountInserted).ToString("C") & " more"
            lblChangeTotal.Text = "$0.00"
            picEnjoy.Visible = False

            ' calculates change resets the total amount entered label displays a picture saying enjoy and sets the insertmore label to blank
        Else

            lblChangeTotal.Text = (decAmountInserted - decDrinks).ToString("C")

            lblAmountTotal.Text = "$0.00"
            picEnjoy.Visible = True
            lblInsertMore.Text = ""

        End If
    End Sub

    Private Sub btnDietDrPepper_Click(sender As Object, e As EventArgs) Handles btnDietDrPepper.Click
        ' This button selects a drink telling the user to enter more money if less than the drink cost and displaying change if any
        decAmountInserted = lblAmountTotal.Text

        'if less than 1.25 tells the user how much more to enter
        If decAmountInserted < decDrinks Then
            lblInsertMore.Visible = True
            lblInsertMore.Text = "Please enter " & (decDrinks - decAmountInserted).ToString("C") & " more"
            lblChangeTotal.Text = "$0.00"
            picEnjoy.Visible = False

            ' calculates change resets the total amount entered label displays a picture saying enjoy and sets the insertmore label to blank
        Else

            lblChangeTotal.Text = (decAmountInserted - decDrinks).ToString("C")

            lblAmountTotal.Text = "$0.00"
            picEnjoy.Visible = True
            lblInsertMore.Text = ""

        End If
    End Sub

    Private Sub btnDietMtnDew_Click(sender As Object, e As EventArgs) Handles btnDietMtnDew.Click
        ' This button selects a drink telling the user to enter more money if less than the drink cost and displaying change if any
        decAmountInserted = lblAmountTotal.Text

        'if less than 1.25 tells the user how much more to enter
        If decAmountInserted < decDrinks Then
            lblInsertMore.Visible = True
            lblInsertMore.Text = "Please enter " & (decDrinks - decAmountInserted).ToString("C") & " more"
            lblChangeTotal.Text = "$0.00"
            picEnjoy.Visible = False

            ' calculates change resets the total amount entered label displays a picture saying enjoy and sets the insertmore label to blank
        Else

            lblChangeTotal.Text = (decAmountInserted - decDrinks).ToString("C")

            lblAmountTotal.Text = "$0.00"
            picEnjoy.Visible = True
            lblInsertMore.Text = ""

        End If
    End Sub

    Private Sub btnDietCoke_Click(sender As Object, e As EventArgs) Handles btnDietCoke.Click
        ' This button selects a drink telling the user to enter more money if less than the drink cost and displaying change if any
        decAmountInserted = lblAmountTotal.Text

        'if less than 1.25 tells the user how much more to enter
        If decAmountInserted < decDrinks Then
            lblInsertMore.Visible = True
            lblInsertMore.Text = "Please enter " & (decDrinks - decAmountInserted).ToString("C") & " more"
            lblChangeTotal.Text = "$0.00"
            picEnjoy.Visible = False

            ' calculates change resets the total amount entered label displays a picture saying enjoy and sets the insertmore label to blank
        Else

            lblChangeTotal.Text = (decAmountInserted - decDrinks).ToString("C")

            lblAmountTotal.Text = "$0.00"
            picEnjoy.Visible = True
            lblInsertMore.Text = ""

        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Closes the program
        Close()
    End Sub
End Class
