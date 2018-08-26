Public Class HomeSalesOrder
    Dim homeSales As New homeSales
    Private Sub HomeSalesOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelSalesOrder.Controls.Add(homeSales)
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        Form1.Show()


    End Sub
End Class