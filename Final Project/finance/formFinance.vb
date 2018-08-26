Public Class formFinance
    Dim homefinanc As New homeFinance
    Dim listTrans As New listAllTransaksi
    Dim PO As New PObayarr
    Private Sub formFinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        panelFinance.Controls.Add(homefinanc)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        panelFinance.Controls.Clear()
        panelFinance.Controls.Add(listTrans)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        panelFinance.Controls.Clear()
        panelFinance.Controls.Add(homefinanc)
    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        panelFinance.Controls.Clear()
        panelFinance.Controls.Add(PO)
    End Sub

    Private Sub BunifuTileButton1_Click(sender As Object, e As EventArgs) Handles BunifuTileButton1.Click
        Me.Hide()
        Form1.Show()
    End Sub
End Class