<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modalPilihRaw
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.BunifuElipse1 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuElipse2 = New Bunifu.Framework.UI.BunifuElipse(Me.components)
        Me.BunifuSeparator1 = New Bunifu.Framework.UI.BunifuSeparator()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.kulitText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.BunifuFlatButton1 = New Bunifu.Framework.UI.BunifuFlatButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.karetText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.kainText = New Bunifu.Framework.UI.BunifuMaterialTextbox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BunifuElipse1
        '
        Me.BunifuElipse1.ElipseRadius = 5
        Me.BunifuElipse1.TargetControl = Me
        '
        'BunifuElipse2
        '
        Me.BunifuElipse2.ElipseRadius = 5
        Me.BunifuElipse2.TargetControl = Me
        '
        'BunifuSeparator1
        '
        Me.BunifuSeparator1.BackColor = System.Drawing.Color.Transparent
        Me.BunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.BunifuSeparator1.LineThickness = 1
        Me.BunifuSeparator1.Location = New System.Drawing.Point(18, 44)
        Me.BunifuSeparator1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuSeparator1.Name = "BunifuSeparator1"
        Me.BunifuSeparator1.Size = New System.Drawing.Size(485, 10)
        Me.BunifuSeparator1.TabIndex = 50
        Me.BunifuSeparator1.Transparency = 255
        Me.BunifuSeparator1.Vertical = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Bell MT", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 31)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Pilih Raw"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(49, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 23)
        Me.Label3.TabIndex = 77
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
        Me.kulitText.Location = New System.Drawing.Point(195, 133)
        Me.kulitText.Margin = New System.Windows.Forms.Padding(4)
        Me.kulitText.Name = "kulitText"
        Me.kulitText.Size = New System.Drawing.Size(289, 33)
        Me.kulitText.TabIndex = 76
        Me.kulitText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 75
        Me.Label1.Text = "id P Produksi"
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
        Me.idText.Location = New System.Drawing.Point(195, 92)
        Me.idText.Margin = New System.Windows.Forms.Padding(4)
        Me.idText.Name = "idText"
        Me.idText.Size = New System.Drawing.Size(289, 33)
        Me.idText.TabIndex = 74
        Me.idText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'BunifuFlatButton1
        '
        Me.BunifuFlatButton1.Activecolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BunifuFlatButton1.BorderRadius = 0
        Me.BunifuFlatButton1.ButtonText = "Create"
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
        Me.BunifuFlatButton1.Location = New System.Drawing.Point(324, 274)
        Me.BunifuFlatButton1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.BunifuFlatButton1.Name = "BunifuFlatButton1"
        Me.BunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.OnHovercolor = System.Drawing.SystemColors.HotTrack
        Me.BunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White
        Me.BunifuFlatButton1.selected = False
        Me.BunifuFlatButton1.Size = New System.Drawing.Size(160, 34)
        Me.BunifuFlatButton1.TabIndex = 82
        Me.BunifuFlatButton1.Text = "Create"
        Me.BunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.BunifuFlatButton1.Textcolor = System.Drawing.Color.White
        Me.BunifuFlatButton1.TextFont = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(49, 231)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(57, 23)
        Me.Label6.TabIndex = 81
        Me.Label6.Text = "Karet"
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
        Me.karetText.Location = New System.Drawing.Point(195, 221)
        Me.karetText.Margin = New System.Windows.Forms.Padding(4)
        Me.karetText.Name = "karetText"
        Me.karetText.Size = New System.Drawing.Size(289, 33)
        Me.karetText.TabIndex = 80
        Me.karetText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
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
        Me.kainText.Location = New System.Drawing.Point(195, 180)
        Me.kainText.Margin = New System.Windows.Forms.Padding(4)
        Me.kainText.Name = "kainText"
        Me.kainText.Size = New System.Drawing.Size(289, 33)
        Me.kainText.TabIndex = 79
        Me.kainText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bell MT", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(49, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 23)
        Me.Label5.TabIndex = 78
        Me.Label5.Text = "Kain"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(498, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 32)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "X"
        '
        'modalPilihRaw
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(545, 429)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BunifuFlatButton1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.karetText)
        Me.Controls.Add(Me.kainText)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.kulitText)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idText)
        Me.Controls.Add(Me.BunifuSeparator1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "modalPilihRaw"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "modalPilihRaw"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BunifuElipse1 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuElipse2 As Bunifu.Framework.UI.BunifuElipse
    Friend WithEvents BunifuSeparator1 As Bunifu.Framework.UI.BunifuSeparator
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents kulitText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label1 As Label
    Friend WithEvents idText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents BunifuFlatButton1 As Bunifu.Framework.UI.BunifuFlatButton
    Friend WithEvents Label6 As Label
    Friend WithEvents karetText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents kainText As Bunifu.Framework.UI.BunifuMaterialTextbox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
End Class
