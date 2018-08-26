<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class produksiBarang
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
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kulitText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.jenisText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.kainText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.karetText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.tabl = New System.Windows.Forms.DataGridView()
        Me.idRaw = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisBarang = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlah = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kul = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.kai = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.karet = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.idText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jumlahText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.tabl, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(27, 64)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(953, 10)
        Me.BunifuSeparator1.TabIndex = 52
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(205, 31)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Produksi Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(574, 101)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 81
        Me.Label3.Text = "Kulit"
        '
        'kulitText
        '
        Me.kulitText.BackColor = System.Drawing.Color.Gainsboro
        Me.kulitText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kulitText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.kulitText.ForeColor = System.Drawing.Color.Black
        Me.kulitText.HintForeColor = System.Drawing.Color.Empty
        Me.kulitText.HintText = ""
        Me.kulitText.isPassword = False
        Me.kulitText.LineFocusedColor = System.Drawing.Color.Black
        Me.kulitText.LineIdleColor = System.Drawing.Color.Black
        Me.kulitText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.kulitText.LineThickness = 3
        Me.kulitText.Location = New System.Drawing.Point(672, 91)
        Me.kulitText.Margin = New System.Windows.Forms.Padding(4)
        Me.kulitText.Name = "kulitText"
        Me.kulitText.Size = New System.Drawing.Size(289, 33)
        Me.kulitText.TabIndex = 80
        Me.kulitText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(44, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 23)
        Me.Label1.TabIndex = 79
        Me.Label1.Text = "Jenis Barang"
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
        Me.jenisText.Location = New System.Drawing.Point(234, 147)
        Me.jenisText.Margin = New System.Windows.Forms.Padding(4)
        Me.jenisText.Name = "jenisText"
        Me.jenisText.Size = New System.Drawing.Size(289, 33)
        Me.jenisText.TabIndex = 78
        Me.jenisText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(574, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 23)
        Me.Label5.TabIndex = 84
        Me.Label5.Text = "Kain"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(574, 209)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 23)
        Me.Label6.TabIndex = 85
        Me.Label6.Text = "Karet"
        '
        'kainText
        '
        Me.kainText.BackColor = System.Drawing.Color.Gainsboro
        Me.kainText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.kainText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.kainText.ForeColor = System.Drawing.Color.Black
        Me.kainText.HintForeColor = System.Drawing.Color.Empty
        Me.kainText.HintText = ""
        Me.kainText.isPassword = False
        Me.kainText.LineFocusedColor = System.Drawing.Color.Black
        Me.kainText.LineIdleColor = System.Drawing.Color.Black
        Me.kainText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.kainText.LineThickness = 3
        Me.kainText.Location = New System.Drawing.Point(672, 147)
        Me.kainText.Margin = New System.Windows.Forms.Padding(4)
        Me.kainText.Name = "kainText"
        Me.kainText.Size = New System.Drawing.Size(289, 33)
        Me.kainText.TabIndex = 86
        Me.kainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'karetText
        '
        Me.karetText.BackColor = System.Drawing.Color.Gainsboro
        Me.karetText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.karetText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.karetText.ForeColor = System.Drawing.Color.Black
        Me.karetText.HintForeColor = System.Drawing.Color.Empty
        Me.karetText.HintText = ""
        Me.karetText.isPassword = False
        Me.karetText.LineFocusedColor = System.Drawing.Color.Black
        Me.karetText.LineIdleColor = System.Drawing.Color.Black
        Me.karetText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.karetText.LineThickness = 3
        Me.karetText.Location = New System.Drawing.Point(672, 199)
        Me.karetText.Margin = New System.Windows.Forms.Padding(4)
        Me.karetText.Name = "karetText"
        Me.karetText.Size = New System.Drawing.Size(289, 33)
        Me.karetText.TabIndex = 87
        Me.karetText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'tabl
        '
        Me.tabl.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabl.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idRaw, Me.jenisBarang, Me.jumlah, Me.kul, Me.kai, Me.karet})
        Me.tabl.Location = New System.Drawing.Point(48, 342)
        Me.tabl.Name = "tabl"
        Me.tabl.RowTemplate.Height = 24
        Me.tabl.Size = New System.Drawing.Size(913, 219)
        Me.tabl.TabIndex = 88
        '
        'idRaw
        '
        Me.idRaw.HeaderText = "ID Raw"
        Me.idRaw.Name = "idRaw"
        '
        'jenisBarang
        '
        Me.jenisBarang.HeaderText = "Jenis Barang"
        Me.jenisBarang.Name = "jenisBarang"
        Me.jenisBarang.Width = 200
        '
        'jumlah
        '
        Me.jumlah.HeaderText = "Jumlah Barang"
        Me.jumlah.Name = "jumlah"
        Me.jumlah.Width = 150
        '
        'kul
        '
        Me.kul.HeaderText = "Kulit"
        Me.kul.Name = "kul"
        Me.kul.Width = 200
        '
        'kai
        '
        Me.kai.HeaderText = "Kain"
        Me.kai.Name = "kai"
        Me.kai.Width = 200
        '
        'karet
        '
        Me.karet.HeaderText = "Karet"
        Me.karet.Name = "karet"
        Me.karet.Width = 200
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(785, 257)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 46)
        Me.Button1.TabIndex = 89
        Me.Button1.Text = "Produksi Selesai"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(44, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 23)
        Me.Label2.TabIndex = 90
        Me.Label2.Text = "ID"
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
        Me.idText.Location = New System.Drawing.Point(234, 91)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(289, 33)
        Me.idText.TabIndex = 91
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(44, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(135, 23)
        Me.Label7.TabIndex = 92
        Me.Label7.Text = "Jumlah Barang"
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
        Me.jumlahText.Location = New System.Drawing.Point(234, 199)
        Me.jumlahText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahText.Name = "jumlahText"
        Me.jumlahText.Size = New System.Drawing.Size(289, 33)
        Me.jumlahText.TabIndex = 93
        Me.jumlahText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Location = New System.Drawing.Point(48, 309)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(913, 32)
        Me.Panel1.TabIndex = 94
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(379, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(180, 27)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Produksi Barang"
        '
        'produksiBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.jumlahText)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tabl)
        Me.Controls.Add(Me.karetText)
        Me.Controls.Add(Me.kainText)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kulitText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jenisText)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "produksiBarang"
        Me.Size = New System.Drawing.Size(1012, 727)
        CType(Me.tabl, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents kulitText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents jenisText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents kainText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents karetText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tabl As DataGridView
    Friend WithEvents jumlah As DataGridViewTextBoxColumn
    Friend WithEvents karet As DataGridViewTextBoxColumn
    Friend WithEvents kai As DataGridViewTextBoxColumn
    Friend WithEvents kul As DataGridViewTextBoxColumn
    Friend WithEvents jenisBarang As DataGridViewTextBoxColumn
    Friend WithEvents idRaw As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents jumlahText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label8 As Label
End Class
