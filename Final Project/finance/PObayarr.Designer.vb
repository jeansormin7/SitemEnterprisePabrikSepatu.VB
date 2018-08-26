<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PObayarr
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.statusBText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.hargaText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.jumlahText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tablePO = New System.Windows.Forms.DataGridView()
        Me.idPO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jenisR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.jumlahR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.harga = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusByr = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BunifuSeparator2 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jenisRText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.idText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Panel1.SuspendLayout()
        CType(Me.tablePO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(20, 231)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(940, 32)
        Me.Panel1.TabIndex = 124
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(395, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 27)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "List Purchase Order"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(807, 485)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 46)
        Me.Button1.TabIndex = 123
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'statusBText
        '
        Me.statusBText.BackColor = System.Drawing.Color.Transparent
        Me.statusBText.BorderRadius = 3
        Me.statusBText.DisabledColor = System.Drawing.Color.Gray
        Me.statusBText.ForeColor = System.Drawing.Color.Black
        Me.statusBText.Items = New String() {"Accepted" & Global.Microsoft.VisualBasic.ChrW(9), "Process"}
        Me.statusBText.Location = New System.Drawing.Point(692, 129)
        Me.statusBText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.statusBText.Name = "statusBText"
        Me.statusBText.NomalColor = System.Drawing.Color.Gainsboro
        Me.statusBText.onHoverColor = System.Drawing.Color.Silver
        Me.statusBText.selectedIndex = -1
        Me.statusBText.Size = New System.Drawing.Size(268, 35)
        Me.statusBText.TabIndex = 122
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
        Me.hargaText.Location = New System.Drawing.Point(692, 80)
        Me.hargaText.Margin = New System.Windows.Forms.Padding(4)
        Me.hargaText.Name = "hargaText"
        Me.hargaText.Size = New System.Drawing.Size(268, 33)
        Me.hargaText.TabIndex = 121
        Me.hargaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(562, 140)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 22)
        Me.Label2.TabIndex = 120
        Me.Label2.Text = "Status Bayar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(562, 91)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 22)
        Me.Label1.TabIndex = 119
        Me.Label1.Text = "Harga"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 140)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(153, 22)
        Me.Label12.TabIndex = 117
        Me.Label12.Text = "Jenis Raw Material"
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
        Me.jumlahText.Location = New System.Drawing.Point(222, 180)
        Me.jumlahText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahText.Name = "jumlahText"
        Me.jumlahText.Size = New System.Drawing.Size(268, 33)
        Me.jumlahText.TabIndex = 116
        Me.jumlahText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(16, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(172, 22)
        Me.Label9.TabIndex = 115
        Me.Label9.Text = "Jumlah Raw Material"
        '
        'tablePO
        '
        Me.tablePO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tablePO.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.idPO, Me.jenisR, Me.jumlahR, Me.harga, Me.StatusByr})
        Me.tablePO.Location = New System.Drawing.Point(20, 261)
        Me.tablePO.Name = "tablePO"
        Me.tablePO.RowTemplate.Height = 24
        Me.tablePO.Size = New System.Drawing.Size(940, 204)
        Me.tablePO.TabIndex = 114
        '
        'idPO
        '
        Me.idPO.HeaderText = "ID Purchase Order"
        Me.idPO.Name = "idPO"
        Me.idPO.Width = 200
        '
        'jenisR
        '
        Me.jenisR.HeaderText = "Jenis Raw Material"
        Me.jenisR.Name = "jenisR"
        Me.jenisR.Width = 200
        '
        'jumlahR
        '
        Me.jumlahR.HeaderText = "Jumlah Raw Material"
        Me.jumlahR.Name = "jumlahR"
        Me.jumlahR.Width = 200
        '
        'harga
        '
        Me.harga.HeaderText = "Harga"
        Me.harga.Name = "harga"
        Me.harga.Width = 150
        '
        'StatusByr
        '
        Me.StatusByr.HeaderText = "Status Bayar"
        Me.StatusByr.Name = "StatusByr"
        Me.StatusByr.Width = 200
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(20, 53)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(940, 10)
        Me.BunifuSeparator2.TabIndex = 113
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(193, 31)
        Me.Label7.TabIndex = 112
        Me.Label7.Text = "Purchase Order"
        '
        'jenisRText
        '
        Me.jenisRText.BackColor = System.Drawing.Color.Gainsboro
        Me.jenisRText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.jenisRText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.jenisRText.ForeColor = System.Drawing.Color.Black
        Me.jenisRText.HintForeColor = System.Drawing.Color.Empty
        Me.jenisRText.HintText = ""
        Me.jenisRText.isPassword = False
        Me.jenisRText.LineFocusedColor = System.Drawing.Color.Black
        Me.jenisRText.LineIdleColor = System.Drawing.Color.Black
        Me.jenisRText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.jenisRText.LineThickness = 3
        Me.jenisRText.Location = New System.Drawing.Point(222, 128)
        Me.jenisRText.Margin = New System.Windows.Forms.Padding(4)
        Me.jenisRText.Name = "jenisRText"
        Me.jenisRText.Size = New System.Drawing.Size(268, 33)
        Me.jenisRText.TabIndex = 125
        Me.jenisRText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 91)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 22)
        Me.Label3.TabIndex = 126
        Me.Label3.Text = "ID"
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
        Me.idText.Location = New System.Drawing.Point(222, 80)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(268, 33)
        Me.idText.TabIndex = 127
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'PObayarr
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.jenisRText)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.statusBText)
        Me.Controls.Add(Me.hargaText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.jumlahText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tablePO)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "PObayarr"
        Me.Size = New System.Drawing.Size(1012, 545)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.tablePO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents statusBText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents hargaText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents jumlahText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents tablePO As DataGridView
    Friend WithEvents idPO As DataGridViewTextBoxColumn
    Friend WithEvents jenisR As DataGridViewTextBoxColumn
    Friend WithEvents jumlahR As DataGridViewTextBoxColumn
    Friend WithEvents harga As DataGridViewTextBoxColumn
    Friend WithEvents StatusByr As DataGridViewTextBoxColumn
    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents jenisRText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label3 As Label
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMaterialTextbox
End Class
