Imports System.Data.SqlClient
Public Class modalPilihRaw
    Dim cmd As SqlCommand
    Public Property id As Integer
    Private Sub modalPilihRaw_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        idText.Text = id.ToString
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Hide()
    End Sub

    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim insertquery As String = "insert into t_pilihRaw(id_pengajuanProduksi, kulit, kain, karet, statuss) values(@id_pengajuanProduksi, @kulit, @kain, @karet, @statuss)"

        addRaw(insertquery)
        MessageBox.Show("Berhasil Di buat")

    End Sub

    Private Sub addRaw(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@id_pengajuanProduksi", idText.Text)
        cmd.Parameters.AddWithValue("@kulit", kulitText.Text)
        cmd.Parameters.AddWithValue("@kain", kainText.Text)
        cmd.Parameters.AddWithValue("@karet", karetText.Text)
        cmd.Parameters.AddWithValue("@statuss", "pending")
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub
End Class