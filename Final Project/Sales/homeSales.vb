Imports System.Data.SqlClient
Public Class homeSales
    Dim cmd As SqlCommand
    Private Sub homeSales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabel()
        Dim query As String = "select * from t_barang"
        database.con.Open()

        cmd = New SqlCommand(query, database.con)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()

            jenisBarangText.AddItem(data_reader("jenis_barang").ToString())
        End While
        database.con.Close()

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
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tableSalesOrder.Rows.Clear()
        Dim insertquery As String = "insert into t_salesOrder(tanggal, jumlah_barang, alamat_costumer, telepon_costumer, status_pembayaran, username, jenis_barang) values(@tanggal, @jumlah_barang, @alamat_costumer, @telepon_costumer, @status_pembayaran, @username, @jenis_barang)"
        addSalesOrder(insertquery)
        MessageBox.Show("Sales Order berhasil dibuat")
        load_tabel()
    End Sub

    Private Sub addSalesOrder(ByVal query As String)
        Dim datee As Date = Format(tanggalText.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jenis_barang", jenisBarangText.selectedValue)
        cmd.Parameters.AddWithValue("@jumlah_barang", jumlahText.Text)
        cmd.Parameters.AddWithValue("@alamat_costumer", alamatText.Text)
        cmd.Parameters.AddWithValue("@telepon_costumer", teleponText.Text)
        cmd.Parameters.AddWithValue("@status_pembayaran", "Pending")
        cmd.Parameters.AddWithValue("@username", Form1.usernameText.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Sub load_tabel()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_salesOrder"

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

            tableSalesOrder.Rows.Add(id_salesOrder, tanggal, jenis_barang, jumlah_barang, alamat_costumer, telepon_costumer, status_pembayaran)
        End While
        database.con.Close()

    End Sub


End Class
