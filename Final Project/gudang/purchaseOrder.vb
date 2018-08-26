Imports System.Data.SqlClient
Public Class purchaseOrder
    Dim cmd As SqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim insertquery As String = "insert into t_purchaseOrder(tanggal, jenis_rawMaterial, jumlah_rawMaterial, harga, status_terima, status_bayar) values(@tanggal, @jenis_rawMaterial, @jumlah_rawMaterial, @harga, @status_terima, @status_bayar)"
        addPurchaseOrder(insertquery)
        MessageBox.Show("Sales Order berhasil dibuat")
        load_tabelPO()


    End Sub

    Private Sub addPurchaseOrder(ByVal query As String)
        Dim datee As Date = Format(tanggalText.Value, "yyyy-MM-dd")
        Dim cmd As New SqlCommand(query, con)
        cmd.Parameters.AddWithValue("@tanggal", datee)
        cmd.Parameters.AddWithValue("@jenis_rawMaterial", jenisRawText.selectedValue)
        cmd.Parameters.AddWithValue("@jumlah_rawMaterial", jumlahRawText.Text)
        cmd.Parameters.AddWithValue("@status_terima", "Pending")
        cmd.Parameters.AddWithValue("@status_bayar", "Pending")
        cmd.Parameters.AddWithValue("@harga", 0)

        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()

    End Sub

    Private Sub purchaseOrder_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabelPO()


        Dim query As String = "select * from t_rawMaterial"
        database.con.Open()

        cmd = New SqlCommand(query, database.con)
        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()

            jenisRawText.AddItem(data_reader("jenis_rawMaterial").ToString())
        End While
        database.con.Close()
    End Sub

    Sub load_tabelPO()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_purchaseOrder"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()
            Dim id_PO As Integer = data_reader("id_purchaseOrder")
            Dim tanggal As Date = data_reader("tanggal")
            Dim jenisRaw As String = data_reader("jenis_rawMaterial")
            Dim jumlahRaw As Integer = data_reader("jumlah_rawMaterial")
            Dim status As String = data_reader("status_terima")


            tablePO.Rows.Add(id_PO, tanggal, jenisRaw, jumlahRaw, status)
        End While
        database.con.Close()

    End Sub
End Class
