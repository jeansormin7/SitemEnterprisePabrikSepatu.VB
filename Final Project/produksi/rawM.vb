Imports System.Data.SqlClient
Public Class rawM
    Dim cmd As SqlCommand
    Private Sub rawM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_tabelRaw()

    End Sub

    Sub load_tabelRaw()
        Dim query As String
        database.con.Open()
        query = "Select * FROM t_rawMaterial"

        cmd = New SqlCommand(query, database.con)

        Dim data_reader As SqlDataReader = cmd.ExecuteReader()
        While data_reader.Read()

            Dim jenis_raw As String = data_reader("jenis_rawMaterial")
            Dim stock As String = data_reader("stok_rawMaterial")


            rawMaterialTable.Rows.Add(jenis_raw, stock)
        End While
        database.con.Close()

    End Sub
End Class
