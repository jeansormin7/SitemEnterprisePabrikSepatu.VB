Imports System.Data.SqlClient
Public Class produksiBarang
    Dim cmd As SqlCommand
    Private Sub produksiBarang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabel()


        tabl.BorderStyle = BorderStyle.None
        tabl.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249)
        tabl.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        tabl.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise
        tabl.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke
        tabl.BackgroundColor = Color.White

        tabl.EnableHeadersVisualStyles = False
        tabl.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        tabl.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72)
        tabl.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
    End Sub

    Sub load_tabel()
        Dim query As String
        database.con.Open()
        query = "  select r.id_pilihRaw, p.jenis_barang,p.jumlah_barang, p.status_pengajuan,r.statuss, r.karet,r.kain, r.kulit from t_pilihRaw r inner join
   t_pengajuanProduksi p on r.id_pengajuanProduksi=p.id_pengajuanProduksi "


        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_pilihRaw As Integer = data_reader("id_pilihRaw")
            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim jumlah_barang As String = data_reader("jumlah_barang")
            Dim kain As Integer = data_reader("kain")
            Dim karet As String = data_reader("karet")
            Dim kulit As String = data_reader("kulit")


            tabl.Rows.Add(id_pilihRaw, jenis_barang, jumlah_barang, kulit, kain, karet)
        End While
        database.con.Close()

    End Sub

    Private Sub tabl_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabl.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tabl.Rows(index)

        idText.Text = selectedRow.Cells(0).Value.ToString()
        jenisText.Text = selectedRow.Cells(1).Value.ToString()
        jumlahText.Text = selectedRow.Cells(2).Value.ToString()
        kulitText.Text = selectedRow.Cells(3).Value.ToString()
        kainText.Text = selectedRow.Cells(4).Value.ToString()
        karetText.Text = selectedRow.Cells(5).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        tabl.Rows.Clear()
        Dim insertquery As String = "insert into t_produksi(id_pilihRaw, statuss) values(@id_pilihRaw, @statuss)"
        Dim updateStatusPengajuan As String = "update t_pengajuanProduksi set status_pengajuan=@status_pengajuan where id_pengajuanProduksi = @id_pengajuanProduksi"
        Dim updateStatusPilihRaw As String = "update t_pilihRaw set statuss=@statuss where id_pilihRaw = @id_pilihRaw"
        addProduksi(insertquery)
        updateStatusPengajuanProduksi(updateStatusPengajuan)
        updateStatusPilihRaws(updateStatusPilihRaw)

        updateStock(get_stockRaw("kulit") - Integer.Parse(kulitText.Text), "kulit")
        updateStock(get_stockRaw("kain") - Integer.Parse(kainText.Text), "kain")
        updateStock(get_stockRaw("karet") - Integer.Parse(karetText.Text), "karet")
        MessageBox.Show("Produksi barang Berhasil Dibuat")

        load_tabel()

    End Sub

    Private Sub addProduksi(ByVal query As String)

        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@id_pilihRaw", idText.Text)
        cmd.Parameters.AddWithValue("@statuss", "acc")

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub updateStatusPilihRaws(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@id_pilihRaw", Integer.Parse(idText.Text))
        cs.Parameters.AddWithValue("@statuss", "acc")
        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub

    Private Sub updateStatusPengajuanProduksi(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@id_pengajuanProduksi", Integer.Parse(idText.Text))
        cs.Parameters.AddWithValue("@status_pengajuan", "done")
        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub

    Function get_stockRaw(jenis_rawMaterial As String) As Integer

        Dim stock As Integer
        Dim query As String = "select * from t_rawMaterial where jenis_rawMaterial=@jenis_rawMaterial"
        database.con.Open()
        cmd = New SqlCommand(query, database.con)
        cmd.Parameters.AddWithValue("@jenis_rawMaterial", jenis_rawMaterial)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            stock = data_reader("stok_rawMaterial")

        End While
        database.con.Close()
        Return stock

    End Function

    Sub updateStock(stock As Integer, jenis_rawMaterial As String)

        Dim updateStok As String = "update t_rawMaterial set stok_rawMaterial=@stok_rawMaterial where jenis_rawMaterial=@jenis_rawMaterial"
        database.con.Open()
        cmd = New SqlCommand(updateStok, database.con)
        cmd.Parameters.AddWithValue("@stok_rawMaterial", stock)
        cmd.Parameters.AddWithValue("@jenis_rawMaterial", jenis_rawMaterial)
        cmd.ExecuteNonQuery()
        database.con.Close()
    End Sub
End Class
