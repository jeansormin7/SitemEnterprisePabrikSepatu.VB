Imports System.Data.SqlClient
Public Class goodIssue
    Dim cmd As SqlCommand
    Private Sub goodIssue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabelSalesOrder()
        load_tabelGoodIssue()

        tableSalesOrder.BorderStyle = BorderStyle.None
        tableSalesOrder.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        tableSalesOrder.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        tableSalesOrder.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        tableSalesOrder.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        tableSalesOrder.BackgroundColor = Color.White

        tableSalesOrder.EnableHeadersVisualStyles = False
        tableSalesOrder.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        tableSalesOrder.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        tableSalesOrder.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

        tableGoodIssue.BorderStyle = BorderStyle.None
        tableGoodIssue.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        tableGoodIssue.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        tableGoodIssue.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        tableGoodIssue.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        tableGoodIssue.BackgroundColor = Color.White

        tableGoodIssue.EnableHeadersVisualStyles = False
        tableGoodIssue.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        tableGoodIssue.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        tableGoodIssue.ColumnHeadersDefaultCellStyle.ForeColor = Color.White

    End Sub

    Sub load_tabelSalesOrder()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_salesOrder where status_pembayaran = 'Accepted'"

        cmd = New SqlCommand(query, database.con)
        tableSalesOrder.Rows.Clear()
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

            tableSalesOrder.Rows.Add(id_salesOrder, tanggal, jenis_barang, jumlah_barang, alamat_costumer, telepon_costumer, status_pembayaran)
        End While
        database.con.Close()

    End Sub

    Sub load_tabelGoodIssue()
        Dim query As String
        database.con.Open()
        query = " select gi.id_goodIssue, b.jenis_barang, so.jumlah_barang from t_goodIssue gi inner join t_salesOrder so on gi.id_salesOrder=so.id_salesOrder inner join t_barang b 
on so.jenis_barang=b.jenis_barang"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_goodIssue As Integer = data_reader("id_goodIssue")

            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim jumlah_barangKeluar As String = data_reader("jumlah_barang")


            tableGoodIssue.Rows.Add(id_goodIssue, jenis_barang, jumlah_barangKeluar)
        End While
        database.con.Close()

    End Sub

    Private Sub tableSalesOrder_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableSalesOrder.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tableSalesOrder.Rows(index)

        IdText.Text = selectedRow.Cells(0).Value.ToString()
        jenisText.Text = selectedRow.Cells(2).Value.ToString()
        jumlahText.Text = selectedRow.Cells(3).Value.ToString()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_goodIssue(id_salesOrder, statuss)  values(@id_salesOrder, @statuss)"
        Dim updateQuery As String = "update t_salesOrder set status_pembayaran=@status_pembayaran where id_salesOrder = @id"
        addGoodIssue(insertquery)
        updateSalesOrder(updateQuery)
        updateStock(get_subStock(jenisText.Text) - Integer.Parse(jumlahText.Text), jenisText.Text)
        MessageBox.Show("Good Issue Berhasil Dibuat")
        load_tabelGoodIssue()
        load_tabelSalesOrder()


    End Sub

    Private Sub addGoodIssue(ByVal query As String)
        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@id_salesOrder", IdText.Text)
        cmd.Parameters.AddWithValue("@statuss", "pending")


        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub updateSalesOrder(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@id", Integer.Parse(IdText.Text))
        cs.Parameters.AddWithValue("@status_pembayaran", "done")
        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub

    Function get_subStock(jenis_barang As String) As Integer

        Dim stock As Integer
        Dim query As String = "select * from t_barang where jenis_barang=@jenis_barang"
        database.con.Open()
        cmd = New SqlCommand(query, database.con)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            stock = data_reader("stok_barang")

        End While
        database.con.Close()
        Return stock

    End Function

    Sub updateStock(stock As Integer, jenis_barang As String)

        Dim updateStok As String = "update t_barang set stok_barang=@stok_barang where jenis_barang=@jenis_barang"
        database.con.Open()
        cmd = New SqlCommand(updateStok, database.con)
        cmd.Parameters.AddWithValue("@stok_barang", stock)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang)
        cmd.ExecuteNonQuery()
        database.con.Close()
    End Sub
End Class
