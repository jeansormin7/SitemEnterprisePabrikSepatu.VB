Imports System.Data.SqlClient
Public Class homeProduksi
    Dim cmd As New SqlCommand
    Dim database As databasee = New databasee
    Dim modalPilihRaww As New modalPilihRaw

    Private Sub homeProduksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tablePermintaanProduksi()

    End Sub

    Private Sub listProduksiBarang_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles listProduksiBarang.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = listProduksiBarang.Rows(index)
        idText.Text = selectedRow.Cells(0).Value.ToString()
        jenisBarangText.Text = selectedRow.Cells(2).Value.ToString()
        tanggalText.Text = selectedRow.Cells(1).Value.ToString()
        jumlahBarangText.Text = selectedRow.Cells(3).Value.ToString()
        If (selectedRow.Cells(4).Value.ToString() = "Accepted") Then
            modalPilihRaww.id = Integer.Parse(idText.Text)
            modalPilihRaww.Show()
        End If


    End Sub

    Sub load_tablePermintaanProduksi()
        listProduksiBarang.Rows.Clear()
        Dim query As String
        database.con.Open()
        query = "select * FROM t_pengajuanProduksi"
        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_pengajuanProduksi As Integer = data_reader("id_pengajuanProduksi")
            Dim jenis_barang As String = data_reader("jenis_barang")
            Dim tanggal_pengajuan As Date = data_reader("tanggal_pengajuan")
            Dim jumlah_barnag As Integer = data_reader("jumlah_barang")
            Dim status_pengajuan As String = data_reader("status_pengajuan")

            listProduksiBarang.Rows.Add(id_pengajuanProduksi, tanggal_pengajuan, jenis_barang, jumlah_barnag, status_pengajuan)
        End While

        database.con.Close()


    End Sub


    Private Sub BunifuFlatButton1_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton1.Click
        Dim updateStatus As String = "update t_pengajuanProduksi set status_pengajuan=@status_pengajuan where id_pengajuanProduksi = @id_pengajuanProduksi"
        updatePengajuanProduksi(updateStatus)
        MessageBox.Show("status berhasil dikonfirmasi")
        load_tablePermintaanProduksi()

    End Sub

    Private Sub updatePengajuanProduksi(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@id_pengajuanProduksi", Integer.Parse(idText.Text))
        cs.Parameters.AddWithValue("@status_pengajuan", BunifuDropdown1.selectedValue)
        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub
End Class
