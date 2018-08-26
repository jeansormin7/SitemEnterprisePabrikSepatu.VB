<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class goodIssue
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tableSalesOrder = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenis_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah_barang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.alamat_costumer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telepon_costumer = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.status_bayar = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.jumlahText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tableGoodIssue = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jenisText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.tableSalesOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.tableGoodIssue, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(4, 51)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(994, 13)
        Me.BunifuSeparator2.TabIndex = 56
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(179, 31)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Barang Keluar"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(9, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 32)
        Me.Panel1.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(397, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(173, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "List Sales Order"
        '
        'tableSalesOrder
        '
        Me.tableSalesOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableSalesOrder.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tanggal, Me.jenis_barang, Me.jumlah_barang, Me.alamat_costumer, Me.telepon_costumer, Me.status_bayar})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableSalesOrder.DefaultCellStyle = DataGridViewCellStyle3
        Me.tableSalesOrder.Location = New System.Drawing.Point(9, 367)
        Me.tableSalesOrder.Name = "tableSalesOrder"
        Me.tableSalesOrder.RowTemplate.Height = 24
        Me.tableSalesOrder.Size = New System.Drawing.Size(950, 109)
        Me.tableSalesOrder.TabIndex = 67
        '
        'id
        '
        Me.id.HeaderText = "ID"
        Me.id.Name = "id"
        Me.id.Width = 50
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
        '
        'jumlah_barang
        '
        Me.jumlah_barang.HeaderText = "Jumlah Barang"
        Me.jumlah_barang.Name = "jumlah_barang"
        '
        'alamat_costumer
        '
        Me.alamat_costumer.HeaderText = "Alamat Costumer"
        Me.alamat_costumer.Name = "alamat_costumer"
        Me.alamat_costumer.Width = 105
        '
        'telepon_costumer
        '
        Me.telepon_costumer.HeaderText = "No Hp"
        Me.telepon_costumer.Name = "telepon_costumer"
        '
        'status_bayar
        '
        Me.status_bayar.HeaderText = "Status"
        Me.status_bayar.Name = "status_bayar"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 127)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 22)
        Me.Label12.TabIndex = 77
        Me.Label12.Text = "Jenis Barang"
        '
        'jumlahText
        '
        Me.jumlahText.BackColor = System.Drawing.Color.Gainsboro
        Me.jumlahText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jumlahText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jumlahText.ForeColor = System.Drawing.Color.Black
        Me.jumlahText.HintForeColor = System.Drawing.Color.Empty
        Me.jumlahText.HintText = ""
        Me.jumlahText.isPassword = False
        Me.jumlahText.LineFocusedColor = System.Drawing.Color.Black
        Me.jumlahText.LineIdleColor = System.Drawing.Color.Black
        Me.jumlahText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jumlahText.LineThickness = 3
        Me.jumlahText.Location = New System.Drawing.Point(696, 73)
        Me.jumlahText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahText.Name = "jumlahText"
        Me.jumlahText.Size = New System.Drawing.Size(290, 33)
        Me.jumlahText.TabIndex = 74
        Me.jumlahText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(520, 84)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 22)
        Me.Label9.TabIndex = 70
        Me.Label9.Text = "Jumlah Barang"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(808, 176)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 46)
        Me.Button1.TabIndex = 79
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(9, 542)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(950, 32)
        Me.Panel2.TabIndex = 81
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(397, 5)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(202, 27)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "List Barang Keluar"
        '
        'tableGoodIssue
        '
        Me.tableGoodIssue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tableGoodIssue.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tableGoodIssue.DefaultCellStyle = DataGridViewCellStyle4
        Me.tableGoodIssue.Location = New System.Drawing.Point(9, 569)
        Me.tableGoodIssue.Name = "tableGoodIssue"
        Me.tableGoodIssue.RowTemplate.Height = 24
        Me.tableGoodIssue.Size = New System.Drawing.Size(950, 109)
        Me.tableGoodIssue.TabIndex = 80
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Jenis Barang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Jumlah Barang"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 200
        '
        'IdText
        '
        Me.IdText.BackColor = System.Drawing.Color.Gainsboro
        Me.IdText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.IdText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.IdText.ForeColor = System.Drawing.Color.Black
        Me.IdText.HintForeColor = System.Drawing.Color.Empty
        Me.IdText.HintText = ""
        Me.IdText.isPassword = False
        Me.IdText.LineFocusedColor = System.Drawing.Color.Black
        Me.IdText.LineIdleColor = System.Drawing.Color.Black
        Me.IdText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.IdText.LineThickness = 3
        Me.IdText.Location = New System.Drawing.Point(196, 73)
        Me.IdText.Margin = New System.Windows.Forms.Padding(4)
        Me.IdText.Name = "IdText"
        Me.IdText.Size = New System.Drawing.Size(279, 33)
        Me.IdText.TabIndex = 82
        Me.IdText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(5, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 22)
        Me.Label3.TabIndex = 83
        Me.Label3.Text = "ID"
        '
        'jenisText
        '
        Me.jenisText.BackColor = System.Drawing.Color.Gainsboro
        Me.jenisText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jenisText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jenisText.ForeColor = System.Drawing.Color.Black
        Me.jenisText.HintForeColor = System.Drawing.Color.Empty
        Me.jenisText.HintText = ""
        Me.jenisText.isPassword = False
        Me.jenisText.LineFocusedColor = System.Drawing.Color.Black
        Me.jenisText.LineIdleColor = System.Drawing.Color.Black
        Me.jenisText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jenisText.LineThickness = 3
        Me.jenisText.Location = New System.Drawing.Point(196, 116)
        Me.jenisText.Margin = New System.Windows.Forms.Padding(4)
        Me.jenisText.Name = "jenisText"
        Me.jenisText.Size = New System.Drawing.Size(279, 33)
        Me.jenisText.TabIndex = 84
        Me.jenisText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'goodIssue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.jenisText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.IdText)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.tableGoodIssue)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.jumlahText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tableSalesOrder)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "goodIssue"
        Me.Size = New System.Drawing.Size(1019, 754)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tableSalesOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tableGoodIssue, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tableSalesOrder As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents jenis_barang As DataGridViewTextBoxColumn
    Friend WithEvents jumlah_barang As DataGridViewTextBoxColumn
    Friend WithEvents alamat_costumer As DataGridViewTextBoxColumn
    Friend WithEvents telepon_costumer As DataGridViewTextBoxColumn
    Friend WithEvents status_bayar As DataGridViewTextBoxColumn
    Friend WithEvents Label12 As Label
    Friend WithEvents jumlahText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents tableGoodIssue As DataGridView
    Friend WithEvents IdText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents jenisText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
