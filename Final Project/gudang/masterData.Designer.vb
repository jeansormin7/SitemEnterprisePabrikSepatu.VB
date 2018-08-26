<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class masterData
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.createMaster = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.jumlahBarangText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.jenisText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.hargaText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.jenisB = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.delete = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(16, 53)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(994, 13)
        Me.BunifuSeparator2.TabIndex = 54
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(247, 31)
        Me.Label1.TabIndex = 53
        Me.Label1.Text = "Master Data Barang"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(9, 290)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1000, 32)
        Me.Panel1.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(325, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(336, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "List Pengajuan Produksi Barang"
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.jenisB, Me.Jumlah, Me.harga})
        Me.DataGridView2.Location = New System.Drawing.Point(9, 317)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(997, 149)
        Me.DataGridView2.TabIndex = 65
        '
        'createMaster
        '
        Me.createMaster.BackColor = System.Drawing.SystemColors.HotTrack
        Me.createMaster.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.createMaster.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.createMaster.Location = New System.Drawing.Point(667, 494)
        Me.createMaster.Name = "createMaster"
        Me.createMaster.Size = New System.Drawing.Size(153, 46)
        Me.createMaster.TabIndex = 70
        Me.createMaster.Text = "Create"
        Me.createMaster.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 22)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Jenis Barang"
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
        Me.jumlahBarangText.Location = New System.Drawing.Point(158, 143)
        Me.jumlahBarangText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahBarangText.Name = "jumlahBarangText"
        Me.jumlahBarangText.Size = New System.Drawing.Size(327, 33)
        Me.jumlahBarangText.TabIndex = 68
        Me.jumlahBarangText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(17, 154)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(123, 22)
        Me.Label2.TabIndex = 71
        Me.Label2.Text = "Jumlah Barang"
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
        Me.jenisText.Location = New System.Drawing.Point(158, 98)
        Me.jenisText.Margin = New System.Windows.Forms.Padding(4)
        Me.jenisText.Name = "jenisText"
        Me.jenisText.Size = New System.Drawing.Size(327, 33)
        Me.jenisText.TabIndex = 72
        Me.jenisText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'hargaText
        '
        Me.hargaText.BackColor = System.Drawing.Color.Gainsboro
        Me.hargaText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.hargaText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.hargaText.ForeColor = System.Drawing.Color.Black
        Me.hargaText.HintForeColor = System.Drawing.Color.Empty
        Me.hargaText.HintText = ""
        Me.hargaText.isPassword = False
        Me.hargaText.LineFocusedColor = System.Drawing.Color.Black
        Me.hargaText.LineIdleColor = System.Drawing.Color.Black
        Me.hargaText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.hargaText.LineThickness = 3
        Me.hargaText.Location = New System.Drawing.Point(679, 98)
        Me.hargaText.Margin = New System.Windows.Forms.Padding(4)
        Me.hargaText.Name = "hargaText"
        Me.hargaText.Size = New System.Drawing.Size(327, 33)
        Me.hargaText.TabIndex = 73
        Me.hargaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(547, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(102, 22)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Harga/Unit"
        '
        'jenisB
        '
        Me.jenisB.HeaderText = "Jenis Barang"
        Me.jenisB.Name = "jenisB"
        Me.jenisB.Width = 200
        '
        'Jumlah
        '
        Me.Jumlah.HeaderText = "Jumlah Barang"
        Me.Jumlah.Name = "Jumlah"
        Me.Jumlah.Width = 200
        '
        'harga
        '
        Me.harga.HeaderText = "Harga / Unit"
        Me.harga.Name = "harga"
        Me.harga.Width = 200
        '
        'delete
        '
        Me.delete.BackColor = System.Drawing.Color.Red
        Me.delete.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.delete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.delete.Location = New System.Drawing.Point(853, 494)
        Me.delete.Name = "delete"
        Me.delete.Size = New System.Drawing.Size(153, 46)
        Me.delete.TabIndex = 75
        Me.delete.Text = "Delete"
        Me.delete.UseVisualStyleBackColor = False
        '
        'masterData
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.delete)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.hargaText)
        Me.Controls.Add(Me.jenisText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.createMaster)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jumlahBarangText)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "masterData"
        Me.Size = New System.Drawing.Size(1019, 756)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents createMaster As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents jumlahBarangText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents jenisText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents hargaText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label4 As Label
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents Jumlah As DataGridViewTextBoxColumn
    Friend WithEvents jenisB As DataGridViewTextBoxColumn
    Friend WithEvents delete As Button
End Class
