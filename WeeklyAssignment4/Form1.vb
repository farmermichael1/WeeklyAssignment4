Public Class abnbReservation
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        clearScreen()
    End Sub
    Private Sub abnbReservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This code is executed when the form loads.
        ' Notice that the form name is spelled the same all through the code. 
        clearScreen()
    End Sub
    Private Sub clearScreen()
        lbCost.Text = ""
        txtNights.Text = ""
        txtNights.Focus()
    End Sub
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
    Private Sub btnCost_Click(sender As Object, e As EventArgs) Handles btnCost.Click
        Dim strNumNights As String
        Dim intNumNights As Integer
        Dim decTotalCost As Decimal
        Const cdecCostPerNight As Decimal = 79D
        strNumNights = txtNights.Text
        intNumNights = Convert.ToInt32(strNumNights)
        decTotalCost = intNumNights * cdecCostPerNight
        lbCost.Text = FormatCurrency(decTotalCost.ToString())
    End Sub

    Private Sub txtNights_TextChanged(sender As Object, e As EventArgs) Handles txtNights.TextChanged

    End Sub
End Class
