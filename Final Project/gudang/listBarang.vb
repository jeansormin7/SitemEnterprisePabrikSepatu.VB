Imports System.Data.SqlClient

Public Class listBarang
    Dim cmd As SqlCommand
    Dim database As databasee = New databasee
    Private Sub createPengajuanProduksi_Click(sender As Object, e As EventArgs) Handles createPengajuanProduksi.Click
        DataGridView2.Rows.Clear()
        Dim insertquery As String = "insert into t_pengajuanProduksi(jenis_barang, tanggal_pengajuan,jumlah_barang,status_pengajuan)values(@jenis_barang,@tanggal_produksi,@jumlah_barang,@status_pengajuan)"
        addPengajuanProduksi(insertquery)
        MessageBox.Show("Permintaan Produksi Barang Berhasil dibuat")
        load_tablePengajuanProduksi()
    End Sub

    Private Sub addPengajuanProduksi(ByVal query As String)
        database.con.Open()
        Dim datee As Date = Format(tanggalpick.Value, "yyyy-MM-dd")
        cmd = New SqlCommand(query, database.con)

        cmd.Parameters.AddWithValue("@jenis_barang", jenisBarangText.selectedValue)
        cmd.Parameters.AddWithValue("@tanggal_produksi", datee)
        cmd.Parameters.AddWithValue("@jumlah_barang", jumlahBarangText.Text)
        cmd.Parameters.AddWithValue("@status_pengajuan", "Pending")
        cmd.ExecuteNonQuery()
        database.con.Close()
    End Sub

    Private Sub listBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tablePengajuanProduksi()
        load_tableBarang()
        loadRaw()


        Dim query As String = "select * from t_barang "
        database.con.Open()
        cmd = New SqlCommand(query, database.con)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            jenisBarangText.AddItem(data_reader("jenis_barang").ToString)
        End While
        database.con.Close()
    End Sub



    Sub load_tableBarang()
        Dim query As String = "select * from t_barang"
        database.con.Open()

        query = "select * from t_barang"
        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()

            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim stok_barang As Integer = data_reader("stok_barang")


            DataGridView1.Rows.Add(jenis_barang, stok_barang)

        End While
        database.con.Close()

    End Sub

    Sub loadRaw()
        Dim query As String = "select * from t_rawMaterial"
        database.con.Open()

        query = "select * from t_rawMaterial"
        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()

            Dim jenis_barang As String = data_reader("jenis_rawMaterial")
            Dim stok_barang As Integer = data_reader("stok_rawMaterial")


            tableRaw.Rows.Add(jenis_barang, stok_barang)

        End While
        database.con.Close()

    End Sub

    Sub load_tablePengajuanProduksi()
        Dim query As String = "select * from t_pengajuanProduksi"
        database.con.Open()

        query = "select * from t_pengajuanProduksi"
        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_pengajuanProduksi As Integer = data_reader("id_pengajuanProduksi")
            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim tanggal_pengajuan As String = data_reader("tanggal_pengajuan")
            Dim jumlah_barang As String = data_reader("jumlah_barang")
            Dim status_pengajuan As String = data_reader("status_pengajuan")
            DataGridView2.Rows.Add(tanggal_pengajuan, jenis_barang, jumlah_barang, status_pengajuan)
        End While
        database.con.Close()
    End Sub
End Class
