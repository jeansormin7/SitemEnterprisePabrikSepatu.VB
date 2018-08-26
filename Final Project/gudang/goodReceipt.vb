Imports System.Data.SqlClient

Public Class goodReceipt
    Dim lb As New listBarang
    Dim cmd As SqlCommand

    Private Sub goodReceipt_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabel()

    End Sub

    Sub load_tabel()
        Dim query As String
        database.con.Open()
        query = "select pro.id_produksi, pro.statuss, pe.jenis_barang, pe.jumlah_barang, pe.status_pengajuan from t_produksi pro inner join t_pilihRaw pii on pro.id_pilihRaw=pii.id_pilihRaw  inner join t_pengajuanProduksi pe on pii.id_pengajuanProduksi=pe.id_pengajuanProduksi"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_produksi As Integer = data_reader("id_produksi")
            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim jumlah_barang As String = data_reader("jumlah_barang")



            DataGridView1.Rows.Add(id_produksi, jenis_barang, jumlah_barang)
        End While
        database.con.Close()

    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Label9.Text = DataGridView1.Item(0, i).Value
        Label4.Text = DataGridView1.Item(1, i).Value
        Label5.Text = DataGridView1.Item(2, i).Value
        Label7.Text = get_total(Label4.Text).ToString


    End Sub

    Function get_total(jenis_barang As String) As Integer
        Dim total As Integer = 0
        Dim stok_barang As Integer
        Dim query As String = "select * from t_barang where jenis_barang=@jenis_barang"
        database.con.Open()
        cmd = New SqlCommand(query, database.con)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            stok_barang = data_reader("stok_barang")

        End While
        database.con.Close()
        total = Integer.Parse(Label5.Text) + stok_barang
        Return total
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updateStokBarang As String = "update t_barang set stok_barang=@stok_barang where jenis_barang = @jenis_barang"
        Dim updateStatusPengajuan As String = "update t_pengajuanProduksi set status_pengajuan=@status_pengajuan where jenis_barang = @jenis_barang"

        updateStokBarangs(updateStokBarang)
        MessageBox.Show("Stok Barang Tambah")
        lb.loadRaw()
        lb.load_tableBarang()


    End Sub

    Private Sub updateStokBarangs(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@jenis_barang", Label4.Text)
        cs.Parameters.AddWithValue("@stok_barang", Label7.Text)
        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub
End Class
