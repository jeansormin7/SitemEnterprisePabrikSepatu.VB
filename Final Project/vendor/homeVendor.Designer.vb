<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class homeVendor
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
        Me.tablePO = New System.Windows.Forms.DataGridView()
        Me.idP = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tgl = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jlhR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.hrg = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.idText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tanggalText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.rawText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.jumlahRawText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.hargaText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.tablePO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(27, 59)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(940, 10)
        Me.BunifuSeparator2.TabIndex = 43
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(245, 31)
        Me.Label7.TabIndex = 42
        Me.Label7.Text = "List Purchase Order"
        '
        'tablePO
        '
        Me.tablePO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablePO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idP, Me.tgl, Me.jenisR, Me.jlhR, Me.hrg})
        Me.tablePO.Location = New System.Drawing.Point(27, 321)
        Me.tablePO.Name = "tablePO"
        Me.tablePO.RowTemplate.Height = 24
        Me.tablePO.Size = New System.Drawing.Size(940, 249)
        Me.tablePO.TabIndex = 44
        '
        'idP
        '
        Me.idP.HeaderText = "ID Purchase Order"
        Me.idP.Name = "idP"
        Me.idP.Width = 200
        '
        'tgl
        '
        Me.tgl.HeaderText = "Tanggal"
        Me.tgl.Name = "tgl"
        Me.tgl.Width = 150
        '
        'jenisR
        '
        Me.jenisR.HeaderText = "Nama Raw Material"
        Me.jenisR.Name = "jenisR"
        Me.jenisR.Width = 200
        '
        'jlhR
        '
        Me.jlhR.HeaderText = "Jumlah Raw Material"
        Me.jlhR.Name = "jlhR"
        Me.jlhR.Width = 200
        '
        'hrg
        '
        Me.hrg.HeaderText = "Harga"
        Me.hrg.Name = "hrg"
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
        Me.idText.Location = New System.Drawing.Point(214, 96)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(268, 33)
        Me.idText.TabIndex = 58
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(23, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(151, 22)
        Me.Label9.TabIndex = 57
        Me.Label9.Text = "ID Purchase Order"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(23, 154)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 22)
        Me.Label1.TabIndex = 59
        Me.Label1.Text = "Tanggal"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 198)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Raw Material"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(555, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 22)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Jumlah Raw "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(555, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 22)
        Me.Label4.TabIndex = 62
        Me.Label4.Text = "Harga"
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
        Me.tanggalText.Location = New System.Drawing.Point(214, 143)
        Me.tanggalText.Margin = New System.Windows.Forms.Padding(4)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(268, 33)
        Me.tanggalText.TabIndex = 64
        Me.tanggalText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'rawText
        '
        Me.rawText.BackColor = System.Drawing.Color.Gainsboro
        Me.rawText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.rawText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.rawText.ForeColor = System.Drawing.Color.Black
        Me.rawText.HintForeColor = System.Drawing.Color.Empty
        Me.rawText.HintText = ""
        Me.rawText.isPassword = False
        Me.rawText.LineFocusedColor = System.Drawing.Color.Black
        Me.rawText.LineIdleColor = System.Drawing.Color.Black
        Me.rawText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.rawText.LineThickness = 3
        Me.rawText.Location = New System.Drawing.Point(214, 198)
        Me.rawText.Margin = New System.Windows.Forms.Padding(4)
        Me.rawText.Name = "rawText"
        Me.rawText.Size = New System.Drawing.Size(268, 33)
        Me.rawText.TabIndex = 65
        Me.rawText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'jumlahRawText
        '
        Me.jumlahRawText.BackColor = System.Drawing.Color.Gainsboro
        Me.jumlahRawText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jumlahRawText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jumlahRawText.ForeColor = System.Drawing.Color.Black
        Me.jumlahRawText.HintForeColor = System.Drawing.Color.Empty
        Me.jumlahRawText.HintText = ""
        Me.jumlahRawText.isPassword = False
        Me.jumlahRawText.LineFocusedColor = System.Drawing.Color.Black
        Me.jumlahRawText.LineIdleColor = System.Drawing.Color.Black
        Me.jumlahRawText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jumlahRawText.LineThickness = 3
        Me.jumlahRawText.Location = New System.Drawing.Point(699, 96)
        Me.jumlahRawText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahRawText.Name = "jumlahRawText"
        Me.jumlahRawText.Size = New System.Drawing.Size(268, 33)
        Me.jumlahRawText.TabIndex = 66
        Me.jumlahRawText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.hargaText.Location = New System.Drawing.Point(699, 143)
        Me.hargaText.Margin = New System.Windows.Forms.Padding(4)
        Me.hargaText.Name = "hargaText"
        Me.hargaText.Size = New System.Drawing.Size(268, 33)
        Me.hargaText.TabIndex = 67
        Me.hargaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(814, 246)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 46)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'homeVendor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.hargaText)
        Me.Controls.Add(Me.jumlahRawText)
        Me.Controls.Add(Me.rawText)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tablePO)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "homeVendor"
        Me.Size = New System.Drawing.Size(1019, 620)
        CType(Me.tablePO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents tablePO As DataGridView
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tanggalText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents rawText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents jumlahRawText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents hargaText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
    Friend WithEvents hrg As DataGridViewTextBoxColumn
    Friend WithEvents jlhR As DataGridViewTextBoxColumn
    Friend WithEvents jenisR As DataGridViewTextBoxColumn
    Friend WithEvents tgl As DataGridViewTextBoxColumn
    Friend WithEvents idP As DataGridViewTextBoxColumn
End Class
