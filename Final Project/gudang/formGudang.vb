Public Class formGudang
    Dim homeGudang As New homeGudang
    Dim listBarang As New listBarang
    Dim goodReceip As New goodReceipt
    Dim goodisu As New goodIssue
    Dim purchase As New purchaseOrder
    Dim mt As New masterData


    Private Sub formGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelGudang.Controls.Add(homeGudang)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        PanelGudang.Controls.Clear()
        PanelGudang.Controls.Add(listBarang)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        PanelGudang.Controls.Clear()
        PanelGudang.Controls.Add(homeGudang)
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        PanelGudang.Controls.Clear()
        PanelGudang.Controls.Add(goodReceip)


    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        PanelGudang.Controls.Clear()

        PanelGudang.Controls.Add(goodisu)
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click
        PanelGudang.Controls.Clear()

        PanelGudang.Controls.Add(purchase)
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        PanelGudang.Controls.Clear()
        PanelGudang.Controls.Add(mt)
    End Sub
End Class