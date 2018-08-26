<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeProduksi
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.listProduksiBarang = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggalProduksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.statusProduksi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.jumlahBarangText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.jenisBarangText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.idText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tanggalText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel1.SuspendLayout()
        CType(Me.listProduksiBarang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Location = New System.Drawing.Point(9, 319)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(986, 32)
        Me.Panel1.TabIndex = 61
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(412, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(252, 27)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "List Permintaan Barang"
        '
        'listProduksiBarang
        '
        Me.listProduksiBarang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listProduksiBarang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tanggalProduksi, Me.jenisBarang, Me.jumlahBarang, Me.statusProduksi})
        Me.listProduksiBarang.Location = New System.Drawing.Point(9, 348)
        Me.listProduksiBarang.Name = "listProduksiBarang"
        Me.listProduksiBarang.RowTemplate.Height = 24
        Me.listProduksiBarang.Size = New System.Drawing.Size(986, 150)
        Me.listProduksiBarang.TabIndex = 60
        '
        'id
        '
        Me.id.HeaderText = "ID "
        Me.id.Name = "id"
        '
        'tanggalProduksi
        '
        Me.tanggalProduksi.HeaderText = "Tanggal Produksi"
        Me.tanggalProduksi.Name = "tanggalProduksi"
        Me.tanggalProduksi.Width = 200
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
        'statusProduksi
        '
        Me.statusProduksi.HeaderText = "Status Produksi"
        Me.statusProduksi.Name = "statusProduksi"
        Me.statusProduksi.Width = 200
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(9, 54)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(999, 10)
        Me.BunifuSeparator1.TabIndex = 48
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(397, 31)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "List Permintaan Produksi Barang"
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Konfirmasi"
        Me.BunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent
        Me.BunifuFlatButton1.Iconimage = Nothing
        Me.BunifuFlatButton1.Iconimage_right = Nothing
        Me.BunifuFlatButton1.Iconimage_right_Selected = Nothing
        Me.BunifuFlatButton1.Iconimage_Selected = Nothing
        Me.BunifuFlatButton1.IconMarginLeft = 0
        Me.BunifuFlatButton1.IconMarginRight = 0
        Me.BunifuFlatButton1.IconRightVisible = True
        Me.BunifuFlatButton1.IconRightZoom = 0R
        Me.BunifuFlatButton1.IconVisible = True
        Me.BunifuFlatButton1.IconZoom = 90.0R
        Me.BunifuFlatButton1.IsTab = False
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(835, 262)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(160, 34)
        Me.BunifuFlatButton1.TabIndex = 62
        Me.BunifuFlatButton1.Text = "Konfirmasi"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'jumlahBarangText
        '
        Me.jumlahBarangText.BackColor = System.Drawing.Color.Gainsboro
        Me.jumlahBarangText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jumlahBarangText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jumlahBarangText.ForeColor = System.Drawing.Color.Black
        Me.jumlahBarangText.HintForeColor = System.Drawing.Color.Empty
        Me.jumlahBarangText.HintText = ""
        Me.jumlahBarangText.isPassword = False
        Me.jumlahBarangText.LineFocusedColor = System.Drawing.Color.Black
        Me.jumlahBarangText.LineIdleColor = System.Drawing.Color.Black
        Me.jumlahBarangText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jumlahBarangText.LineThickness = 3
        Me.jumlahBarangText.Location = New System.Drawing.Point(682, 81)
        Me.jumlahBarangText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahBarangText.Name = "jumlahBarangText"
        Me.jumlahBarangText.Size = New System.Drawing.Size(311, 33)
        Me.jumlahBarangText.TabIndex = 57
        Me.jumlahBarangText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(540, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(135, 23)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Jumlah Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(540, 142)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(140, 23)
        Me.Label6.TabIndex = 54
        Me.Label6.Text = "Status Produksi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(5, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 23)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 188)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 23)
        Me.Label3.TabIndex = 52
        Me.Label3.Text = "Jenis Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(5, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(160, 23)
        Me.Label5.TabIndex = 53
        Me.Label5.Text = "Tanggal Produksi"
        '
        'jenisBarangText
        '
        Me.jenisBarangText.BackColor = System.Drawing.Color.Gainsboro
        Me.jenisBarangText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jenisBarangText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jenisBarangText.ForeColor = System.Drawing.Color.Black
        Me.jenisBarangText.HintForeColor = System.Drawing.Color.Empty
        Me.jenisBarangText.HintText = ""
        Me.jenisBarangText.isPassword = False
        Me.jenisBarangText.LineFocusedColor = System.Drawing.Color.Black
        Me.jenisBarangText.LineIdleColor = System.Drawing.Color.Black
        Me.jenisBarangText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jenisBarangText.LineThickness = 3
        Me.jenisBarangText.Location = New System.Drawing.Point(194, 188)
        Me.jenisBarangText.Margin = New System.Windows.Forms.Padding(4)
        Me.jenisBarangText.Name = "jenisBarangText"
        Me.jenisBarangText.Size = New System.Drawing.Size(311, 33)
        Me.jenisBarangText.TabIndex = 55
        Me.jenisBarangText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'idText
        '
        Me.idText.BackColor = System.Drawing.Color.Gainsboro
        Me.idText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.idText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.idText.ForeColor = System.Drawing.Color.Black
        Me.idText.HintForeColor = System.Drawing.Color.Empty
        Me.idText.HintText = ""
        Me.idText.isPassword = False
        Me.idText.LineFocusedColor = System.Drawing.Color.Black
        Me.idText.LineIdleColor = System.Drawing.Color.Black
        Me.idText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.idText.LineThickness = 3
        Me.idText.Location = New System.Drawing.Point(194, 81)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(311, 33)
        Me.idText.TabIndex = 49
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tanggalText
        '
        Me.tanggalText.BackColor = System.Drawing.Color.Gainsboro
        Me.tanggalText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.tanggalText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.tanggalText.ForeColor = System.Drawing.Color.Black
        Me.tanggalText.HintForeColor = System.Drawing.Color.Empty
        Me.tanggalText.HintText = ""
        Me.tanggalText.isPassword = False
        Me.tanggalText.LineFocusedColor = System.Drawing.Color.Black
        Me.tanggalText.LineIdleColor = System.Drawing.Color.Black
        Me.tanggalText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.tanggalText.LineThickness = 3
        Me.tanggalText.Location = New System.Drawing.Point(194, 132)
        Me.tanggalText.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(311, 33)
        Me.tanggalText.TabIndex = 56
        Me.tanggalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown1.Items = New String() {"--Status--", "Accepted", "Process"}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(682, 142)
        Me.BunifuDropdown1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.Gainsboro
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.Silver
        Me.BunifuDropdown1.selectedIndex = 0
        Me.BunifuDropdown1.Size = New System.Drawing.Size(313, 35)
        Me.BunifuDropdown1.TabIndex = 63
        '
        'homeProduksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.listProduksiBarang)
        Me.Controls.Add(Me.jumlahBarangText)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.jenisBarangText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "homeProduksi"
        Me.Size = New System.Drawing.Size(1012, 545)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.listProduksiBarang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents listProduksiBarang As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tanggalProduksi As DataGridViewTextBoxColumn
    Friend WithEvents jenisBarang As DataGridViewTextBoxColumn
    Friend WithEvents jumlahBarang As DataGridViewTextBoxColumn
    Friend WithEvents statusProduksi As DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents tanggalText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents jenisBarangText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents jumlahBarangText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents createBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
End Class
