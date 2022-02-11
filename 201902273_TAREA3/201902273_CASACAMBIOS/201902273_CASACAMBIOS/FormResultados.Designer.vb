<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormResultados
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Texttotal1 = New System.Windows.Forms.TextBox()
        Me.Textcomision1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Texttotal2 = New System.Windows.Forms.TextBox()
        Me.Textcomision2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.regresar = New System.Windows.Forms.Button()
        Me.limpiar1 = New System.Windows.Forms.Button()
        Me.salir2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT Black", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(208, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 34)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "TOTALES"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Comisión"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Texttotal1)
        Me.GroupBox1.Controls.Add(Me.Textcomision1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 70)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(264, 155)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Compra"
        '
        'Texttotal1
        '
        Me.Texttotal1.Enabled = False
        Me.Texttotal1.Location = New System.Drawing.Point(97, 74)
        Me.Texttotal1.Name = "Texttotal1"
        Me.Texttotal1.Size = New System.Drawing.Size(73, 20)
        Me.Texttotal1.TabIndex = 13
        '
        'Textcomision1
        '
        Me.Textcomision1.Enabled = False
        Me.Textcomision1.Location = New System.Drawing.Point(97, 29)
        Me.Textcomision1.Name = "Textcomision1"
        Me.Textcomision1.Size = New System.Drawing.Size(73, 20)
        Me.Textcomision1.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total de compra"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.YellowGreen
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Texttotal2)
        Me.GroupBox2.Controls.Add(Me.Textcomision2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(308, 70)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(243, 155)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Venta"
        '
        'Texttotal2
        '
        Me.Texttotal2.Enabled = False
        Me.Texttotal2.Location = New System.Drawing.Point(103, 70)
        Me.Texttotal2.Name = "Texttotal2"
        Me.Texttotal2.Size = New System.Drawing.Size(73, 20)
        Me.Texttotal2.TabIndex = 15
        '
        'Textcomision2
        '
        Me.Textcomision2.Enabled = False
        Me.Textcomision2.Location = New System.Drawing.Point(103, 29)
        Me.Textcomision2.Name = "Textcomision2"
        Me.Textcomision2.Size = New System.Drawing.Size(73, 20)
        Me.Textcomision2.TabIndex = 14
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Total de Venta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Comisión"
        '
        'regresar
        '
        Me.regresar.BackColor = System.Drawing.Color.DarkGoldenrod
        Me.regresar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.regresar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.regresar.Location = New System.Drawing.Point(155, 245)
        Me.regresar.Name = "regresar"
        Me.regresar.Size = New System.Drawing.Size(74, 25)
        Me.regresar.TabIndex = 13
        Me.regresar.Text = "Regresar"
        Me.regresar.UseVisualStyleBackColor = False
        '
        'limpiar1
        '
        Me.limpiar1.BackColor = System.Drawing.Color.Teal
        Me.limpiar1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.limpiar1.Location = New System.Drawing.Point(256, 245)
        Me.limpiar1.Name = "limpiar1"
        Me.limpiar1.Size = New System.Drawing.Size(74, 25)
        Me.limpiar1.TabIndex = 14
        Me.limpiar1.Text = "Limpiar"
        Me.limpiar1.UseVisualStyleBackColor = False
        '
        'salir2
        '
        Me.salir2.BackColor = System.Drawing.Color.DarkSlateGray
        Me.salir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.salir2.Location = New System.Drawing.Point(368, 245)
        Me.salir2.Name = "salir2"
        Me.salir2.Size = New System.Drawing.Size(74, 25)
        Me.salir2.TabIndex = 15
        Me.salir2.Text = "Salir"
        Me.salir2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(187, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Q"
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(171, 77)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 13)
        Me.Label7.TabIndex = 26
        Me.Label7.Text = "Us $, Mxn $,€ ó ₡"
        Me.Label7.Visible = False
        '
        'FormResultados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201902273_CASACAMBIOS.My.Resources.Resources.fondo3
        Me.ClientSize = New System.Drawing.Size(575, 299)
        Me.Controls.Add(Me.salir2)
        Me.Controls.Add(Me.limpiar1)
        Me.Controls.Add(Me.regresar)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label5)
        Me.Name = "FormResultados"
        Me.Text = "Resultados"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Texttotal1 As TextBox
    Friend WithEvents Textcomision1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Texttotal2 As TextBox
    Friend WithEvents Textcomision2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents regresar As Button
    Friend WithEvents limpiar1 As Button
    Friend WithEvents salir2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
