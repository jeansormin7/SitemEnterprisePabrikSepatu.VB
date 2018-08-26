Imports System.Data.SqlClient
Public Class homeVendor
    Dim cmd As SqlCommand
    Private Sub homeVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabelVendor()

    End Sub

    Sub load_tabelVendor()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_purchaseOrder where status_terima = 'pending'"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_PO As Integer = data_reader("id_purchaseOrder")
            Dim tanggal As Date = data_reader("tanggal")
            Dim jenisRaw As String = data_reader("jenis_rawMaterial")
            Dim jumlahRaw As Integer = data_reader("jumlah_rawMaterial")
            Dim harga As Integer = data_reader("harga")

            tablePO.Rows.Add(id_PO, tanggal, jenisRaw, jumlahRaw, harga)
        End While
        database.con.Close()

    End Sub

    Private Sub tablePO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablePO.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tablePO.Rows(index)

        idText.Text = selectedRow.Cells(0).Value.ToString()
        tanggalText.Text = selectedRow.Cells(1).Value.ToString()
        rawText.Text = selectedRow.Cells(2).Value.ToString()
        jumlahRawText.Text = selectedRow.Cells(3).Value.ToString()


        hargaText.Text = get_total(rawText.Text).ToString
    End Sub

    Function get_total(jenis_raw As String) As Integer
        Dim total As Integer = 0
        Dim harga_barang As Integer
        Dim query As String = "select * from t_rawMaterial where jenis_rawMaterial=@jenis_rawMaterial"
        database.con.Open()
        cmd = New SqlCommand(query, database.con)
        cmd.Parameters.AddWithValue("@jenis_rawMaterial", jenis_raw)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            harga_barang = data_reader("harga")

        End While
        database.con.Close()
        total = Integer.Parse(jumlahRawText.Text) * harga_barang
        Return total
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim updateStatus As String = "update t_purchaseOrder set harga=@harga, status_terima=@status_terima where id_purchaseOrder = @idPO"
        addPO(updateStatus)
        MessageBox.Show("Harga Raw Berhasil dikirim")
        load_tabelVendor()
    End Sub

    Private Sub addPO(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@idPO", Integer.Parse(idText.Text))
        cs.Parameters.AddWithValue("@harga", hargaText.Text)
        cs.Parameters.AddWithValue("@status_terima", "Accepted")

        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub


End Class
