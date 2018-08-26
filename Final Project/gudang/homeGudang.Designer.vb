<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeGudang
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jumlahBarangText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.jenisBarangText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tanggalText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.idText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.createBtn = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listSalesOrderGudang = New System.Windows.Forms.DataGridView()
        Me.id_salesOrder = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_costumer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telpon_costumer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BunifuDropdown1 = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Panel1.SuspendLayout()
        CType(Me.listSalesOrderGudang, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(488, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 23)
        Me.Label7.TabIndex = 52
        Me.Label7.Text = "Status"
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
        Me.jumlahBarangText.Location = New System.Drawing.Point(645, 95)
        Me.jumlahBarangText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahBarangText.Name = "jumlahBarangText"
        Me.jumlahBarangText.Size = New System.Drawing.Size(313, 33)
        Me.jumlahBarangText.TabIndex = 51
        Me.jumlahBarangText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.jenisBarangText.Location = New System.Drawing.Point(139, 200)
        Me.jenisBarangText.Margin = New System.Windows.Forms.Padding(4)
        Me.jenisBarangText.Name = "jenisBarangText"
        Me.jenisBarangText.Size = New System.Drawing.Size(311, 33)
        Me.jenisBarangText.TabIndex = 50
        Me.jenisBarangText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.tanggalText.Location = New System.Drawing.Point(139, 148)
        Me.tanggalText.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(311, 33)
        Me.tanggalText.TabIndex = 49
        Me.tanggalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.idText.Location = New System.Drawing.Point(139, 95)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(311, 33)
        Me.idText.TabIndex = 48
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(19, 354)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(939, 32)
        Me.Panel1.TabIndex = 47
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(431, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "List Sales Order"
        '
        'createBtn
        '
        Me.createBtn.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.createBtn.BackColor = System.Drawing.SystemColors.HotTrack
        Me.createBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.createBtn.BorderRadius = 0
        Me.createBtn.ButtonText = "Update Status"
        Me.createBtn.Cursor = System.Windows.Forms.Cursors.Hand
        Me.createBtn.DisabledColor = System.Drawing.Color.Gray
        Me.createBtn.Iconcolor = System.Drawing.Color.Transparent
        Me.createBtn.Iconimage = Nothing
        Me.createBtn.Iconimage_right = Nothing
        Me.createBtn.Iconimage_right_Selected = Nothing
        Me.createBtn.Iconimage_Selected = Nothing
        Me.createBtn.IconMarginLeft = 0
        Me.createBtn.IconMarginRight = 0
        Me.createBtn.IconRightVisible = True
        Me.createBtn.IconRightZoom = 0R
        Me.createBtn.IconVisible = True
        Me.createBtn.IconZoom = 90.0R
        Me.createBtn.IsTab = False
        Me.createBtn.Location = New System.Drawing.Point(798, 274)
        Me.createBtn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.createBtn.Name = "createBtn"
        Me.createBtn.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.createBtn.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.createBtn.OnHoverTextColor = System.Drawing.Color.White
        Me.createBtn.selected = False
        Me.createBtn.Size = New System.Drawing.Size(160, 34)
        Me.createBtn.TabIndex = 46
        Me.createBtn.Text = "Update Status"
        Me.createBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.createBtn.Textcolor = System.Drawing.Color.White
        Me.createBtn.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(488, 105)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(135, 23)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Jumlah Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 210)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 23)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "Jenis Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 158)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 23)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Tanggal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 23)
        Me.Label3.TabIndex = 42
        Me.Label3.Text = "ID"
        '
        'listSalesOrderGudang
        '
        Me.listSalesOrderGudang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.listSalesOrderGudang.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id_salesOrder, Me.tanggal, Me.jenis_barang, Me.jumlah_barang, Me.alamat_costumer, Me.telpon_costumer, Me.status})
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listSalesOrderGudang.DefaultCellStyle = DataGridViewCellStyle1
        Me.listSalesOrderGudang.Location = New System.Drawing.Point(19, 384)
        Me.listSalesOrderGudang.Name = "listSalesOrderGudang"
        Me.listSalesOrderGudang.RowTemplate.Height = 24
        Me.listSalesOrderGudang.Size = New System.Drawing.Size(939, 302)
        Me.listSalesOrderGudang.TabIndex = 41
        '
        'id_salesOrder
        '
        Me.id_salesOrder.HeaderText = "ID"
        Me.id_salesOrder.Name = "id_salesOrder"
        Me.id_salesOrder.Width = 50
        '
        'tanggal
        '
        Me.tanggal.HeaderText = "Tanggal"
        Me.tanggal.Name = "tanggal"
        '
        'jenis_barang
        '
        Me.jenis_barang.HeaderText = "Jenis Barang"
        Me.jenis_barang.Name = "jenis_barang"
        Me.jenis_barang.Width = 150
        '
        'jumlah_barang
        '
        Me.jumlah_barang.HeaderText = "Jumlah Barang"
        Me.jumlah_barang.Name = "jumlah_barang"
        Me.jumlah_barang.Width = 140
        '
        'alamat_costumer
        '
        Me.alamat_costumer.HeaderText = "Alamat Costumer"
        Me.alamat_costumer.Name = "alamat_costumer"
        Me.alamat_costumer.Width = 150
        '
        'telpon_costumer
        '
        Me.telpon_costumer.HeaderText = "No Hp Costumer"
        Me.telpon_costumer.Name = "telpon_costumer"
        Me.telpon_costumer.Width = 150
        '
        'status
        '
        Me.status.HeaderText = "Status"
        Me.status.Name = "status"
        Me.status.Width = 150
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(19, 50)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(939, 10)
        Me.BunifuSeparator1.TabIndex = 40
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(199, 31)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "List Sales Order"
        '
        'BunifuDropdown1
        '
        Me.BunifuDropdown1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuDropdown1.BorderRadius = 3
        Me.BunifuDropdown1.DisabledColor = System.Drawing.Color.Gray
        Me.BunifuDropdown1.ForeColor = System.Drawing.Color.Black
        Me.BunifuDropdown1.Items = New String() {"--Status--", "Accepted", "pending"}
        Me.BunifuDropdown1.Location = New System.Drawing.Point(645, 158)
        Me.BunifuDropdown1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuDropdown1.Name = "BunifuDropdown1"
        Me.BunifuDropdown1.NomalColor = System.Drawing.Color.Gainsboro
        Me.BunifuDropdown1.onHoverColor = System.Drawing.Color.Silver
        Me.BunifuDropdown1.selectedIndex = -1
        Me.BunifuDropdown1.Size = New System.Drawing.Size(313, 35)
        Me.BunifuDropdown1.TabIndex = 61
        '
        'homeGudang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.BunifuDropdown1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.jumlahBarangText)
        Me.Controls.Add(Me.jenisBarangText)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.createBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listSalesOrderGudang)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "homeGudang"
        Me.Size = New System.Drawing.Size(1019, 756)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.listSalesOrderGudang, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label7 As Label
    Friend WithEvents jumlahBarangText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents jenisBarangText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tanggalText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents createBtn As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents listSalesOrderGudang As DataGridView
    Friend WithEvents id_salesOrder As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_barang As DataGridViewTextBoxColumn
    Friend WithEvents alamat_costumer As DataGridViewTextBoxColumn
    Friend WithEvents telpon_costumer As DataGridViewTextBoxColumn
    Friend WithEvents status As DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents BunifuDropdown1 As Bunifu.Framework.UI.BunifuDropdown
End Class
