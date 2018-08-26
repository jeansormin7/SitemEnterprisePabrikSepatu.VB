Imports System.Data.SqlClient

Public Class homeGudang
    Dim cmd As New SqlCommand
    Dim database As databasee = New databasee
    Private Sub homeGudang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_table()
    End Sub

    Sub load_table()


        listSalesOrderGudang.Rows.Clear()
        Dim query As String
        database.con.Open()
        query = "select * FROM t_salesOrder where status_pembayaran = 'pending'"
        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_salesOrder As Integer = data_reader("id_salesOrder")
            Dim tanggal As Date = data_reader("tanggal")
            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim jumlah_barang As Integer = data_reader("jumlah_barang")
            Dim alamat_costumer As String = data_reader("alamat_costumer")
            Dim telepon_costumer As String = data_reader("telepon_costumer")
            Dim status_pembayaran As String = data_reader("status_pembayaran")
            Dim username As String = data_reader("username")

            listSalesOrderGudang.Rows.Add(id_salesOrder, tanggal, jenis_barang, jumlah_barang, alamat_costumer, telepon_costumer, status_pembayaran)

        End While
        database.con.Close()

    End Sub

    Private Sub listSalesOrderGudang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles listSalesOrderGudang.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = listSalesOrderGudang.Rows(index)

        idText.Text = selectedRow.Cells(0).Value.ToString()
        tanggalText.Text = selectedRow.Cells(1).Value.ToString()
        jenisBarangText.Text = selectedRow.Cells(2).Value.ToString()
        jumlahBarangText.Text = selectedRow.Cells(3).Value.ToString()

    End Sub

    Private Sub createBtn_Click(sender As Object, e As EventArgs) Handles createBtn.Click
        Dim updateStatus As String = "update t_salesOrder set status_pembayaran=@status_pembayaran where id_salesOrder = @id"
        addSalesOrder(updateStatus)
        load_table()
        MessageBox.Show("Status Berhasil")
    End Sub

    Private Sub addSalesOrder(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@id", Integer.Parse(idText.Text))
        cs.Parameters.AddWithValue("@status_pembayaran", BunifuDropdown1.selectedValue)
        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub
End Class
