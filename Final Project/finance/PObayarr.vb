Imports System.Data.SqlClient
Public Class PObayarr
    Dim cmd As SqlCommand
    Private Sub PObayarr_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabelPO()

    End Sub

    Sub load_tabelPO()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_purchaseOrder where status_terima = 'Accepted'"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim idPO As Integer = data_reader("id_purchaseOrder")
            Dim jenisR As String = data_reader("jenis_rawMaterial")
            Dim jumlahR As String = data_reader("jumlah_rawMaterial")
            Dim harga As Integer = data_reader("harga")
            Dim status_b As String = data_reader("status_bayar")


            tablePO.Rows.Add(idPO, jenisR, jumlahR, harga, status_b)
        End While
        database.con.Close()

    End Sub

    Private Sub tablePO_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tablePO.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim selectedRow As DataGridViewRow
        selectedRow = tablePO.Rows(index)

        idText.Text = selectedRow.Cells(0).Value.ToString()
        jenisRText.Text = selectedRow.Cells(1).Value.ToString()
        jumlahText.Text = selectedRow.Cells(2).Value.ToString()
        hargaText.Text = selectedRow.Cells(3).Value.ToString()
        statusBText.Text = selectedRow.Cells(4).Value.ToString()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tablePO.Rows.Clear()

        Dim updateStatus As String = "update t_purchaseOrder set status_bayar=@status_bayar, status_terima=@status_terima where id_purchaseOrder = @idPO"
        addPO(updateStatus)
        MessageBox.Show("Harga Raw Berhasil dikirim")
        load_tabelPO()
    End Sub

    Private Sub addPO(ByVal query As String)
        database.con.Open()
        Dim cs As New SqlCommand(query, database.con)
        cs.Parameters.AddWithValue("@idPO", Integer.Parse(idText.Text))
        cs.Parameters.AddWithValue("@status_bayar", statusBText.selectedValue)
        cs.Parameters.AddWithValue("@status_terima", "done")


        cs.ExecuteNonQuery()
        database.con.Close()
    End Sub
End Class
