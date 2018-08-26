Public Class formProduksi
    Dim homeproduksi As New homeProduksi
    Dim raw As New rawM
    Dim produksiB As New produksiBarang

    Private Sub formProduksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelProduksi.Controls.Add(homeproduksi)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        panelProduksi.Controls.Clear()
        panelProduksi.Controls.Add(raw)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        panelProduksi.Controls.Clear()
        panelProduksi.Controls.Add(homeproduksi)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        panelProduksi.Controls.Clear()
        panelProduksi.Controls.Add(produksiB)
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class