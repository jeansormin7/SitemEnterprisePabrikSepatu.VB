<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalTransaksi
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
        Me.jenisText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.jumlahText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BunifuMaterialTextbox1 = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BunifuSeparator2
        '
        Me.BunifuSeparator2.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator2.LineThickness = 1
        Me.BunifuSeparator2.Location = New System.Drawing.Point(22, 48)
        Me.BunifuSeparator2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator2.Name = "BunifuSeparator2"
        Me.BunifuSeparator2.Size = New System.Drawing.Size(583, 12)
        Me.BunifuSeparator2.TabIndex = 98
        Me.BunifuSeparator2.Transparency = 255
        Me.BunifuSeparator2.Vertical = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 13)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(179, 31)
        Me.Label7.TabIndex = 97
        Me.Label7.Text = "List Transaksi"
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
        Me.jenisText.Location = New System.Drawing.Point(248, 98)
        Me.jenisText.Margin = New System.Windows.Forms.Padding(4)
        Me.jenisText.Name = "jenisText"
        Me.jenisText.Size = New System.Drawing.Size(294, 33)
        Me.jenisText.TabIndex = 100
        Me.jenisText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(72, 109)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 22)
        Me.Label12.TabIndex = 99
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
        Me.jumlahText.Location = New System.Drawing.Point(248, 166)
        Me.jumlahText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahText.Name = "jumlahText"
        Me.jumlahText.Size = New System.Drawing.Size(294, 33)
        Me.jumlahText.TabIndex = 102
        Me.jumlahText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(72, 177)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 22)
        Me.Label9.TabIndex = 101
        Me.Label9.Text = "Jumlah Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(72, 238)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 22)
        Me.Label1.TabIndex = 103
        Me.Label1.Text = "Total"
        '
        'BunifuMaterialTextbox1
        '
        Me.BunifuMaterialTextbox1.BackColor = System.Drawing.Color.Gainsboro
        Me.BunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.BunifuMaterialTextbox1.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.BunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty
        Me.BunifuMaterialTextbox1.HintText = ""
        Me.BunifuMaterialTextbox1.isPassword = False
        Me.BunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Black
        Me.BunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.BunifuMaterialTextbox1.LineThickness = 3
        Me.BunifuMaterialTextbox1.Location = New System.Drawing.Point(248, 227)
        Me.BunifuMaterialTextbox1.Margin = New System.Windows.Forms.Padding(4)
        Me.BunifuMaterialTextbox1.Name = "BunifuMaterialTextbox1"
        Me.BunifuMaterialTextbox1.Size = New System.Drawing.Size(294, 33)
        Me.BunifuMaterialTextbox1.TabIndex = 104
        Me.BunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(364, 320)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(178, 46)
        Me.Button1.TabIndex = 105
        Me.Button1.Text = "Create "
        Me.Button1.UseVisualStyleBackColor = False
        '
        'modalTransaksi
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BunifuMaterialTextbox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.jumlahText)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.jenisText)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.BunifuSeparator2)
        Me.Controls.Add(Me.Label7)
        Me.Name = "modalTransaksi"
        Me.Size = New System.Drawing.Size(653, 448)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuSeparator2 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label7 As Label
    Friend WithEvents jenisText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
    Friend WithEvents jumlahText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BunifuMaterialTextbox1 As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Button1 As Button
End Class
