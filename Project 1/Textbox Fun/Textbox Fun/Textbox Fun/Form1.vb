Public Class Form1
    Dim currTextBox As TextBox
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtTop.Focus()

    End Sub

    Private Sub txtTop_Enter(sender As Object, e As EventArgs) Handles txtTop.Enter
        currTextBox = txtTop
    End Sub

    Private Sub txtBottom_Enter(sender As Object, e As EventArgs) Handles txtBottom.Enter
        currTextBox = txtBottom
    End Sub

    Private Sub btnAddAnA_Click(sender As Object, e As EventArgs) Handles btnAddAnA.Click
        currTextBox.Text = currTextBox.Text & "A"
    End Sub
End Class
