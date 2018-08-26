<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listAllTransaksi
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tableTransaksi = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tableTransaksi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(20, 49)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(940, 10)
        Me.BunifuSeparator2.TabIndex = 98
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 14)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(233, 31)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "List Produk Keluar"
        '
        'tableTransaksi
        '
        Me.tableTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableTransaksi.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.jenisBarang, Me.jumlahBarang, Me.total})
        Me.tableTransaksi.Location = New System.Drawing.Point(20, 99)
        Me.tableTransaksi.Name = "tableTransaksi"
        Me.tableTransaksi.RowTemplate.Height = 24
        Me.tableTransaksi.Size = New System.Drawing.Size(940, 421)
        Me.tableTransaksi.TabIndex = 99
        '
        'id
        '
        Me.id.FillWeight = 200.0!
        Me.id.HeaderText = "ID Transaksi"
        Me.id.Name = "id"
        Me.id.Width = 200
        '
        'jenisBarang
        '
        Me.jenisBarang.HeaderText = "Jenis Barang"
        Me.jenisBarang.Name = "jenisBarang"
        Me.jenisBarang.Width = 200
        '
        'jumlahBarang
        '
        Me.jumlahBarang.HeaderText = "Jumlah Barang"
        Me.jumlahBarang.Name = "jumlahBarang"
        Me.jumlahBarang.Width = 200
        '
        'total
        '
        Me.total.HeaderText = "Total Harga"
        Me.total.Name = "total"
        Me.total.Width = 200
        '
        'listAllTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.tableTransaksi)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "listAllTransaksi"
        Me.Size = New System.Drawing.Size(1012, 545)
        CType(Me.tableTransaksi, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents tableTransaksi As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents jenisBarang As DataGridViewTextBoxColumn
    Friend WithEvents jumlahBarang As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
End Class
