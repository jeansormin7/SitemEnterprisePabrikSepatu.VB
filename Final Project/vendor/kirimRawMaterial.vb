Imports System.Data.SqlClient
Public Class kirimRawMaterial
    Dim cmd As SqlCommand
    Private Sub kirimRawMaterial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabelPO()

    End Sub

    Sub load_tabelPO()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_purchaseOrder where status_bayar = 'Accepted'"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim idPO As Integer = data_reader("id_purchaseOrder")
            Dim jenisR As String = data_reader("jenis_rawMaterial")
            Dim jumlahR As String = data_reader("jumlah_rawMaterial")



            tablePO.Rows.Add(idPO, jenisR, jumlahR)
        End While
        database.con.Close()

    End Sub

    Private Sub tablePO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablePO.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tablePO.Rows(index)
        Label3.Text = selectedRow.Cells(0).Value.ToString()
        Label4.Text = selectedRow.Cells(1).Value.ToString()
        Label5.Text = selectedRow.Cells(2).Value.ToString()
        Label8.Text = get_totalRaw(Label4.Text).ToString


    End Sub

    Function get_totalRaw(jenis_raw As String) As Integer
        Dim total As Integer = 0
        Dim harga_barang As Integer
        Dim query As String = "select * from t_rawMaterial where jenis_rawMaterial=@jenis_rawMaterial"
        database.con.Open()
        cmd = New SqlCommand(query, database.con)
        cmd.Parameters.AddWithValue("@jenis_rawMaterial", jenis_raw)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            harga_barang = data_reader("stok_rawMaterial")

        End While
        database.con.Close()
        total = Integer.Parse(Label5.Text) + harga_barang
        Return total
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tablePO.Rows.Clear()

        Dim updateStatusBayar As String = "update t_purchaseOrder set status_bayar=@status_bayar where id_purchaseOrder = @idPO"
        Dim updateStatus As String = "update t_rawMaterial set stok_rawMaterial=@stok_rawMaterial  where jenis_rawMaterial = @jenisRaw"
        addRaw(updateStatus)
        updatePO(updateStatusBayar)
        MessageBox.Show("Raw Material Berhail Dikirim")
        load_tabelPO()

    End Sub

    Private Sub updatePO(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@idPO", Label3.Text)
        cs.Parameters.AddWithValue("@status_bayar", "diterima")



        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub


    Private Sub addRaw(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@jenisRaw", Label4.Text)
        cs.Parameters.AddWithValue("@stok_rawMaterial", Label8.Text)


        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub

End Class
