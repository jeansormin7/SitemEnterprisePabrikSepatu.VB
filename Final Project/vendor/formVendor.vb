Public Class formVendor
    Dim homeV As New homeVendor
    Dim kirimRaw As New kirimRawMaterial
    Private Sub formVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panalVendor.Controls.Add(homeV)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        panalVendor.Controls.Clear()

        panalVendor.Controls.Add(homeV)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        panalVendor.Controls.Clear()

        panalVendor.Controls.Add(kirimRaw)
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        Form1.Show()

    End Sub
End Class