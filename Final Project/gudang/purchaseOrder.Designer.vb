<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class purchaseOrder
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jenisRawText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.jumlahRawText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tanggalText = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tablePO = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tanggal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jlhR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stat = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.tablePO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(17, 54)
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
        Me.Label1.Location = New System.Drawing.Point(16, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(193, 31)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Purchase Order"
        '
        'jenisRawText
        '
        Me.jenisRawText.BackColor = System.Drawing.Color.Transparent
        Me.jenisRawText.BorderRadius = 3
        Me.jenisRawText.DisabledColor = System.Drawing.Color.Gray
        Me.jenisRawText.ForeColor = System.Drawing.Color.Black
        Me.jenisRawText.Items = New String(-1) {}
        Me.jenisRawText.Location = New System.Drawing.Point(209, 157)
        Me.jenisRawText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.jenisRawText.Name = "jenisRawText"
        Me.jenisRawText.NomalColor = System.Drawing.Color.Gainsboro
        Me.jenisRawText.onHoverColor = System.Drawing.Color.Silver
        Me.jenisRawText.selectedIndex = -1
        Me.jenisRawText.Size = New System.Drawing.Size(268, 35)
        Me.jenisRawText.TabIndex = 64
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(18, 170)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 22)
        Me.Label12.TabIndex = 63
        Me.Label12.Text = "Jenis Raw Material"
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
        Me.jumlahRawText.Location = New System.Drawing.Point(721, 107)
        Me.jumlahRawText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahRawText.Name = "jumlahRawText"
        Me.jumlahRawText.Size = New System.Drawing.Size(268, 33)
        Me.jumlahRawText.TabIndex = 62
        Me.jumlahRawText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(531, 118)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 22)
        Me.Label9.TabIndex = 61
        Me.Label9.Text = "Jumlah Raw Material"
        '
        'tanggalText
        '
        Me.tanggalText.BackColor = System.Drawing.Color.White
        Me.tanggalText.BorderRadius = 0
        Me.tanggalText.ForeColor = System.Drawing.Color.Black
        Me.tanggalText.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggalText.FormatCustom = Nothing
        Me.tanggalText.Location = New System.Drawing.Point(209, 94)
        Me.tanggalText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(268, 46)
        Me.tanggalText.TabIndex = 66
        Me.tanggalText.Value = New Date(2017, 12, 6, 23, 49, 43, 301)
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(18, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 22)
        Me.Label8.TabIndex = 65
        Me.Label8.Text = "Tanggal"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(39, 282)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(950, 32)
        Me.Panel1.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(377, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "List Purchase Order"
        '
        'tablePO
        '
        Me.tablePO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablePO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.tanggal, Me.jenisR, Me.jlhR, Me.stat})
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.Padding = New System.Windows.Forms.Padding(0, 4, 0, 4)
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.tablePO.DefaultCellStyle = DataGridViewCellStyle2
        Me.tablePO.Location = New System.Drawing.Point(39, 309)
        Me.tablePO.Name = "tablePO"
        Me.tablePO.RowTemplate.Height = 24
        Me.tablePO.Size = New System.Drawing.Size(950, 186)
        Me.tablePO.TabIndex = 67
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
        'jenisR
        '
        Me.jenisR.HeaderText = "Jenis Raw Material"
        Me.jenisR.Name = "jenisR"
        Me.jenisR.Width = 200
        '
        'jlhR
        '
        Me.jlhR.HeaderText = "Jumlah Raw Material"
        Me.jlhR.Name = "jlhR"
        Me.jlhR.Width = 200
        '
        'stat
        '
        Me.stat.HeaderText = "Status"
        Me.stat.Name = "stat"
        Me.stat.Width = 200
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(816, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(173, 46)
        Me.Button1.TabIndex = 69
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'purchaseOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.tablePO)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.jenisRawText)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.jumlahRawText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "purchaseOrder"
        Me.Size = New System.Drawing.Size(1019, 754)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablePO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label1 As Label
    Friend WithEvents jenisRawText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents Label12 As Label
    Friend WithEvents jumlahRawText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents tanggalText As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents tablePO As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents tanggal As DataGridViewTextBoxColumn
    Friend WithEvents jenisR As DataGridViewTextBoxColumn
    Friend WithEvents jlhR As DataGridViewTextBoxColumn
    Friend WithEvents stat As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
End Class
