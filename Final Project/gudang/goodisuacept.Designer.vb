<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class goodisuacept
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
        Me.jenisBarangText = New Bunifu.Framework.UI.BunifuDropdown()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.teleponText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.alamatText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.jumlahText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tanggalText = New Bunifu.Framework.UI.BunifuDatepicker()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'jenisBarangText
        '
        Me.jenisBarangText.BackColor = System.Drawing.Color.Transparent
        Me.jenisBarangText.BorderRadius = 3
        Me.jenisBarangText.DisabledColor = System.Drawing.Color.Gray
        Me.jenisBarangText.ForeColor = System.Drawing.Color.Black
        Me.jenisBarangText.Items = New String(-1) {}
        Me.jenisBarangText.Location = New System.Drawing.Point(195, 229)
        Me.jenisBarangText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.jenisBarangText.Name = "jenisBarangText"
        Me.jenisBarangText.NomalColor = System.Drawing.Color.Gainsboro
        Me.jenisBarangText.onHoverColor = System.Drawing.Color.Silver
        Me.jenisBarangText.selectedIndex = -1
        Me.jenisBarangText.Size = New System.Drawing.Size(180, 35)
        Me.jenisBarangText.TabIndex = 71
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 242)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(104, 22)
        Me.Label12.TabIndex = 70
        Me.Label12.Text = "Jenis Barang"
        '
        'teleponText
        '
        Me.teleponText.BackColor = System.Drawing.Color.Gainsboro
        Me.teleponText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.teleponText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.teleponText.ForeColor = System.Drawing.Color.Black
        Me.teleponText.HintForeColor = System.Drawing.Color.Empty
        Me.teleponText.HintText = ""
        Me.teleponText.isPassword = False
        Me.teleponText.LineFocusedColor = System.Drawing.Color.Black
        Me.teleponText.LineIdleColor = System.Drawing.Color.Black
        Me.teleponText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.teleponText.LineThickness = 3
        Me.teleponText.Location = New System.Drawing.Point(571, 229)
        Me.teleponText.Margin = New System.Windows.Forms.Padding(4)
        Me.teleponText.Name = "teleponText"
        Me.teleponText.Size = New System.Drawing.Size(172, 33)
        Me.teleponText.TabIndex = 69
        Me.teleponText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'alamatText
        '
        Me.alamatText.BackColor = System.Drawing.Color.Gainsboro
        Me.alamatText.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.alamatText.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.alamatText.ForeColor = System.Drawing.Color.Black
        Me.alamatText.HintForeColor = System.Drawing.Color.Empty
        Me.alamatText.HintText = ""
        Me.alamatText.isPassword = False
        Me.alamatText.LineFocusedColor = System.Drawing.Color.Black
        Me.alamatText.LineIdleColor = System.Drawing.Color.Black
        Me.alamatText.LineMouseHoverColor = System.Drawing.Color.SeaGreen
        Me.alamatText.LineThickness = 3
        Me.alamatText.Location = New System.Drawing.Point(571, 177)
        Me.alamatText.Margin = New System.Windows.Forms.Padding(4)
        Me.alamatText.Name = "alamatText"
        Me.alamatText.Size = New System.Drawing.Size(172, 33)
        Me.alamatText.TabIndex = 68
        Me.alamatText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.jumlahText.Location = New System.Drawing.Point(195, 290)
        Me.jumlahText.Margin = New System.Windows.Forms.Padding(4)
        Me.jumlahText.Name = "jumlahText"
        Me.jumlahText.Size = New System.Drawing.Size(180, 33)
        Me.jumlahText.TabIndex = 67
        Me.jumlahText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.Font = New System.Drawing.Font("Bell MT", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(805, 319)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 46)
        Me.Button1.TabIndex = 66
        Me.Button1.Text = "Create"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'tanggalText
        '
        Me.tanggalText.BackColor = System.Drawing.Color.White
        Me.tanggalText.BorderRadius = 0
        Me.tanggalText.ForeColor = System.Drawing.Color.Black
        Me.tanggalText.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.tanggalText.FormatCustom = Nothing
        Me.tanggalText.Location = New System.Drawing.Point(195, 164)
        Me.tanggalText.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tanggalText.Name = "tanggalText"
        Me.tanggalText.Size = New System.Drawing.Size(180, 46)
        Me.tanggalText.TabIndex = 65
        Me.tanggalText.Value = New Date(2017, 12, 6, 23, 49, 43, 301)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(398, 242)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(148, 22)
        Me.Label11.TabIndex = 64
        Me.Label11.Text = "Telepon Costumer"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(398, 188)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 22)
        Me.Label10.TabIndex = 63
        Me.Label10.Text = "Alamat Costumer"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(4, 301)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(123, 22)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Jumlah Barang"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Book Antiqua", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(4, 188)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 22)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Tanggal"
        '
        'goodisuacept
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.Controls.Add(Me.jenisBarangText)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.teleponText)
        Me.Controls.Add(Me.alamatText)
        Me.Controls.Add(Me.jumlahText)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.tanggalText)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Name = "goodisuacept"
        Me.Size = New System.Drawing.Size(769, 576)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents jenisBarangText As Bunifu.Framework.UI.BunifuDropdown
    Friend WithEvents teleponText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents alamatText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents tanggalText As Bunifu.Framework.UI.BunifuDatepicker
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents jumlahText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label12 As Label
End Class
