Imports System.Data.SqlClient
Public Class masterData
    Dim cmd As SqlCommand
    Private Sub masterData_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        load_tabel()


    End Sub

    Private Sub createMaster_Click(sender As Object, e As EventArgs) Handles createMaster.Click
        DataGridView2.Rows.Clear()
        Dim insertquery As String = "insert into t_barang(jenis_barang, stok_barang, harga_barang) values(@jenis_barang, @stok_barang, @harga_barang)"
        addBarang(insertquery)
        MessageBox.Show("Barang berhasil dibuat")
        load_tabel()

    End Sub


    Private Sub addBarang(ByVal query As String)

        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@jenis_barang", jenisText.Text)
        cmd.Parameters.AddWithValue("@stok_barang", jumlahBarangText.Text)
        cmd.Parameters.AddWithValue("@harga_barang", hargaText.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Sub load_tabel()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_barang"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim jenisBarang As String = data_reader("jenis_barang")
            Dim stok As Integer = data_reader("stok_barang")
            Dim harga As String = data_reader("harga_barang")


            DataGridView2.Rows.Add(jenisBarang, stok, harga)
        End While
        database.con.Close()

    End Sub

    Private Sub delete_Click(sender As Object, e As EventArgs) Handles delete.Click
        DataGridView2.Rows.Clear()
        Dim delquery As String = "delete from t_barang where jenis_barang=@jenis_barang"
        addBarang(delquery)
        MessageBox.Show("Barang berhasil dibuat")
        load_tabel()

    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = DataGridView2.Rows(index)

        jenisText.Text = selectedRow.Cells(0).Value.ToString()
        jumlahBarangText.Text = selectedRow.Cells(1).Value.ToString()
        hargaText.Text = selectedRow.Cells(2).Value.ToString()

    End Sub
End Class
