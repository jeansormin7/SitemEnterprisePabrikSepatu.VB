Imports System.Data.SqlClient
Public Class listAllTransaksi
    Dim cmd As SqlCommand
    Private Sub listAllTransaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabeltransaksi()

    End Sub

    Sub load_tabeltransaksi()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_transaksi"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_transaksi As Integer = data_reader("id_transaksi")
            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim jumlah_barang As Integer = data_reader("jumlah_barang")
            Dim harga As Integer = data_reader("harga")

            tableTransaksi.Rows.Add(id_transaksi, jenis_barang, jumlah_barang, harga)
        End While
        database.con.Close()

    End Sub
End Class
