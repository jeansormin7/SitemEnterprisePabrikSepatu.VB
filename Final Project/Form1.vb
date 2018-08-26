Imports System.Data.SqlClient
Public Class Form1
    Private Sub BunifuFlatButton2_Click(sender As Object, e As EventArgs) Handles BunifuFlatButton2.Click
        Dim searchquery As String = "Select * from t_akun where username=@username and password=@password"

        Dim cmd As New SqlCommand(searchquery, con)
        cmd.Parameters.AddWithValue("@username", usernameText.Text)
        cmd.Parameters.AddWithValue("@password", passwordText.Text)



        Dim da As New SqlDataAdapter(cmd)
        Dim table As New DataTable

        da.Fill(table)

        If table.Rows.Count > 0 Then
            Dim role As String = table.Rows(0)(2)
            cekRole(role)
            Me.Hide()
        End If
    End Sub

    Private Sub cekRole(role As String)
        If (role = "SO") Then
            HomeSalesOrder.Show()
        ElseIf (role = "GDG") Then
            formGudang.Show()
        ElseIf (role = "PRO") Then
            formProduksi.Show()
        ElseIf (role = "FNC") Then
            formFinance.Show()
        ElseIf (role = "V") Then
            formVendor.Show()
        End If

    End Sub
End Class
