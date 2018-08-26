Imports System.Data.SqlClient
Public Class homeFinance
    Dim cmd As SqlCommand
    Private Sub homeFinance_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabelGoodIssue()

    End Sub

    Sub load_tabelGoodIssue()
        Dim query As String
        database.con.Open()
        query = " select gi.id_goodIssue, gi.statuss, b.jenis_barang, so.jumlah_barang from t_goodIssue gi inner join t_salesOrder so on gi.id_salesOrder=so.id_salesOrder inner join t_barang b 
on so.jenis_barang=b.jenis_barang where statuss = 'pending'"

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

    Private Sub tableGoodIssue_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tableGoodIssue.CellClick
        Dim i As Integer = tableGoodIssue.CurrentRow.Index
        idText.Text = tableGoodIssue.Item(0, i).Value
        jenis.Text = tableGoodIssue.Item(1, i).Value
        jumlah.Text = tableGoodIssue.Item(2, i).Value
        Label3.Text = get_total(jenis.Text).ToString
    End Sub
    Function get_total(jenis_barang As String) As Integer
        Dim total As Integer = 0
        Dim harga_barang As Integer
        Dim query As String = "select * from t_barang where jenis_barang=@jenis_barang"
        database.con.Open()
        cmd = New SqlCommand(query, database.con)
        cmd.Parameters.AddWithValue("@jenis_barang", jenis_barang)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            harga_barang = data_reader("harga_barang")

        End While
        database.con.Close()
        total = Integer.Parse(jumlah.Text) * harga_barang
        Return total
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tableGoodIssue.Rows.Clear()

        Dim insertquery As String = "insert into t_transaksi(jenis_barang, jumlah_barang,harga)values(@jenis_barang,@jumlah_barang,@harga)"
        Dim updateStatusGoodIssue As String = "update t_goodIssue set statuss=@statuss where id_goodIssue = @id_goodIssue"
        addTransaksi(insertquery)
        updateStatusGI(updateStatusGoodIssue)
        MessageBox.Show("Transaksi Berhasil dibuat")
        load_tabelGoodIssue()

    End Sub

    Private Sub addTransaksi(ByVal query As String)

        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@jenis_barang", jenis.Text)
        cmd.Parameters.AddWithValue("@jumlah_barang", jumlah.Text)
        cmd.Parameters.AddWithValue("@harga", Label3.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub updateStatusGI(ByVal query As String)

        Dim cmd As New SqlCommand(query, con)

        cmd.Parameters.AddWithValue("@id_goodIssue", idText.Text)
        cmd.Parameters.AddWithValue("@statuss", "konfirmasi")

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub


End Class
