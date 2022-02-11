<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Checkcompra = New System.Windows.Forms.CheckBox()
        Me.Checkventa = New System.Windows.Forms.CheckBox()
        Me.Textcompra = New System.Windows.Forms.TextBox()
        Me.Textventa = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.compradolar = New System.Windows.Forms.RadioButton()
        Me.comprapeso = New System.Windows.Forms.RadioButton()
        Me.compraeuro = New System.Windows.Forms.RadioButton()
        Me.compracolones = New System.Windows.Forms.RadioButton()
        Me.ventadolar = New System.Windows.Forms.RadioButton()
        Me.ventapeso = New System.Windows.Forms.RadioButton()
        Me.ventaeuro = New System.Windows.Forms.RadioButton()
        Me.ventacolones = New System.Windows.Forms.RadioButton()
        Me.Groupcompra = New System.Windows.Forms.GroupBox()
        Me.Groupventa = New System.Windows.Forms.GroupBox()
        Me.calcular = New System.Windows.Forms.Button()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.salir = New System.Windows.Forms.Button()
        Me.LabelQ = New System.Windows.Forms.Label()
        Me.LabelCant = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Groupcompra.SuspendLayout()
        Me.Groupventa.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label1.Font = New System.Drawing.Font("Bodoni MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(210, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione la transacción que desea efectuar"
        '
        'Checkcompra
        '
        Me.Checkcompra.AutoSize = True
        Me.Checkcompra.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkcompra.Location = New System.Drawing.Point(29, 66)
        Me.Checkcompra.Name = "Checkcompra"
        Me.Checkcompra.Size = New System.Drawing.Size(68, 17)
        Me.Checkcompra.TabIndex = 1
        Me.Checkcompra.Text = "Compra"
        Me.Checkcompra.UseVisualStyleBackColor = True
        '
        'Checkventa
        '
        Me.Checkventa.AutoSize = True
        Me.Checkventa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkventa.Location = New System.Drawing.Point(29, 104)
        Me.Checkventa.Name = "Checkventa"
        Me.Checkventa.Size = New System.Drawing.Size(59, 17)
        Me.Checkventa.TabIndex = 2
        Me.Checkventa.Text = "Venta"
        Me.Checkventa.UseVisualStyleBackColor = True
        '
        'Textcompra
        '
        Me.Textcompra.Location = New System.Drawing.Point(122, 64)
        Me.Textcompra.Name = "Textcompra"
        Me.Textcompra.Size = New System.Drawing.Size(37, 20)
        Me.Textcompra.TabIndex = 3
        Me.Textcompra.Visible = False
        '
        'Textventa
        '
        Me.Textventa.Location = New System.Drawing.Point(122, 101)
        Me.Textventa.Name = "Textventa"
        Me.Textventa.Size = New System.Drawing.Size(37, 20)
        Me.Textventa.TabIndex = 4
        Me.Textventa.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(119, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Cantidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label3.Font = New System.Drawing.Font("Bodoni MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(182, 19)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Seleccione tipo de moneda a comprar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label4.Font = New System.Drawing.Font("Bodoni MT Condensed", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(212, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(249, 32)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "BIENVENIDO A CASA DE CAMBIO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label5.Font = New System.Drawing.Font("Bodoni MT Condensed", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(23, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(175, 19)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Seleccione tipo de moneda a Vender"
        '
        'compradolar
        '
        Me.compradolar.AutoSize = True
        Me.compradolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compradolar.Location = New System.Drawing.Point(35, 41)
        Me.compradolar.Name = "compradolar"
        Me.compradolar.Size = New System.Drawing.Size(97, 17)
        Me.compradolar.TabIndex = 9
        Me.compradolar.TabStop = True
        Me.compradolar.Text = "Dólar (Us $ )"
        Me.compradolar.UseVisualStyleBackColor = True
        '
        'comprapeso
        '
        Me.comprapeso.AutoSize = True
        Me.comprapeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.comprapeso.Location = New System.Drawing.Point(35, 64)
        Me.comprapeso.Name = "comprapeso"
        Me.comprapeso.Size = New System.Drawing.Size(156, 17)
        Me.comprapeso.TabIndex = 10
        Me.comprapeso.TabStop = True
        Me.comprapeso.Text = "Peso mexicano (Mxn $)"
        Me.comprapeso.UseVisualStyleBackColor = True
        '
        'compraeuro
        '
        Me.compraeuro.AutoSize = True
        Me.compraeuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compraeuro.Location = New System.Drawing.Point(35, 87)
        Me.compraeuro.Name = "compraeuro"
        Me.compraeuro.Size = New System.Drawing.Size(76, 17)
        Me.compraeuro.TabIndex = 11
        Me.compraeuro.TabStop = True
        Me.compraeuro.Text = "Euros (€)"
        Me.compraeuro.UseVisualStyleBackColor = True
        '
        'compracolones
        '
        Me.compracolones.AutoSize = True
        Me.compracolones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.compracolones.Location = New System.Drawing.Point(35, 112)
        Me.compracolones.Name = "compracolones"
        Me.compracolones.Size = New System.Drawing.Size(179, 17)
        Me.compracolones.TabIndex = 12
        Me.compracolones.TabStop = True
        Me.compracolones.Text = "Colones Costarricences (₡)"
        Me.compracolones.UseVisualStyleBackColor = True
        '
        'ventadolar
        '
        Me.ventadolar.AutoSize = True
        Me.ventadolar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventadolar.Location = New System.Drawing.Point(35, 37)
        Me.ventadolar.Name = "ventadolar"
        Me.ventadolar.Size = New System.Drawing.Size(97, 17)
        Me.ventadolar.TabIndex = 13
        Me.ventadolar.TabStop = True
        Me.ventadolar.Text = "Dólar (Us $ )"
        Me.ventadolar.UseVisualStyleBackColor = True
        '
        'ventapeso
        '
        Me.ventapeso.AutoSize = True
        Me.ventapeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventapeso.Location = New System.Drawing.Point(35, 60)
        Me.ventapeso.Name = "ventapeso"
        Me.ventapeso.Size = New System.Drawing.Size(156, 17)
        Me.ventapeso.TabIndex = 14
        Me.ventapeso.TabStop = True
        Me.ventapeso.Text = "Peso mexicano (Mxn $)"
        Me.ventapeso.UseVisualStyleBackColor = True
        '
        'ventaeuro
        '
        Me.ventaeuro.AutoSize = True
        Me.ventaeuro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventaeuro.Location = New System.Drawing.Point(35, 83)
        Me.ventaeuro.Name = "ventaeuro"
        Me.ventaeuro.Size = New System.Drawing.Size(76, 17)
        Me.ventaeuro.TabIndex = 15
        Me.ventaeuro.TabStop = True
        Me.ventaeuro.Text = "Euros (€)"
        Me.ventaeuro.UseVisualStyleBackColor = True
        '
        'ventacolones
        '
        Me.ventacolones.AutoSize = True
        Me.ventacolones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ventacolones.Location = New System.Drawing.Point(35, 106)
        Me.ventacolones.Name = "ventacolones"
        Me.ventacolones.Size = New System.Drawing.Size(178, 17)
        Me.ventacolones.TabIndex = 16
        Me.ventacolones.TabStop = True
        Me.ventacolones.Text = "Colones Costarricenses (₡)"
        Me.ventacolones.UseVisualStyleBackColor = True
        '
        'Groupcompra
        '
        Me.Groupcompra.BackColor = System.Drawing.Color.OliveDrab
        Me.Groupcompra.Controls.Add(Me.compracolones)
        Me.Groupcompra.Controls.Add(Me.compraeuro)
        Me.Groupcompra.Controls.Add(Me.comprapeso)
        Me.Groupcompra.Controls.Add(Me.compradolar)
        Me.Groupcompra.Controls.Add(Me.Label3)
        Me.Groupcompra.Location = New System.Drawing.Point(389, 55)
        Me.Groupcompra.Name = "Groupcompra"
        Me.Groupcompra.Size = New System.Drawing.Size(232, 135)
        Me.Groupcompra.TabIndex = 17
        Me.Groupcompra.TabStop = False
        Me.Groupcompra.Text = "Compra"
        Me.Groupcompra.Visible = False
        '
        'Groupventa
        '
        Me.Groupventa.BackColor = System.Drawing.Color.OliveDrab
        Me.Groupventa.Controls.Add(Me.ventacolones)
        Me.Groupventa.Controls.Add(Me.ventaeuro)
        Me.Groupventa.Controls.Add(Me.ventapeso)
        Me.Groupventa.Controls.Add(Me.ventadolar)
        Me.Groupventa.Controls.Add(Me.Label5)
        Me.Groupventa.Location = New System.Drawing.Point(389, 204)
        Me.Groupventa.Name = "Groupventa"
        Me.Groupventa.Size = New System.Drawing.Size(232, 134)
        Me.Groupventa.TabIndex = 18
        Me.Groupventa.TabStop = False
        Me.Groupventa.Text = "Venta"
        Me.Groupventa.Visible = False
        '
        'calcular
        '
        Me.calcular.BackColor = System.Drawing.Color.DarkGreen
        Me.calcular.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.calcular.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.calcular.Location = New System.Drawing.Point(67, 204)
        Me.calcular.Name = "calcular"
        Me.calcular.Size = New System.Drawing.Size(84, 26)
        Me.calcular.TabIndex = 19
        Me.calcular.Text = "Cálcular"
        Me.calcular.UseVisualStyleBackColor = False
        '
        'limpiar
        '
        Me.limpiar.BackColor = System.Drawing.Color.SeaGreen
        Me.limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.limpiar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.limpiar.Location = New System.Drawing.Point(67, 241)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(84, 26)
        Me.limpiar.TabIndex = 20
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = False
        '
        'salir
        '
        Me.salir.BackColor = System.Drawing.Color.DarkCyan
        Me.salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.salir.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.salir.Location = New System.Drawing.Point(67, 278)
        Me.salir.Name = "salir"
        Me.salir.Size = New System.Drawing.Size(84, 26)
        Me.salir.TabIndex = 21
        Me.salir.Text = "Salir"
        Me.salir.UseVisualStyleBackColor = False
        '
        'LabelQ
        '
        Me.LabelQ.AutoSize = True
        Me.LabelQ.Location = New System.Drawing.Point(166, 66)
        Me.LabelQ.Name = "LabelQ"
        Me.LabelQ.Size = New System.Drawing.Size(15, 13)
        Me.LabelQ.TabIndex = 22
        Me.LabelQ.Text = "Q"
        Me.LabelQ.Visible = False
        '
        'LabelCant
        '
        Me.LabelCant.AutoSize = True
        Me.LabelCant.Location = New System.Drawing.Point(160, 105)
        Me.LabelCant.Name = "LabelCant"
        Me.LabelCant.Size = New System.Drawing.Size(93, 13)
        Me.LabelCant.TabIndex = 23
        Me.LabelCant.Text = "Us $, Mxn $,€ ó ₡"
        Me.LabelCant.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkSeaGreen
        Me.GroupBox1.Controls.Add(Me.LabelCant)
        Me.GroupBox1.Controls.Add(Me.LabelQ)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Textventa)
        Me.GroupBox1.Controls.Add(Me.Textcompra)
        Me.GroupBox1.Controls.Add(Me.Checkventa)
        Me.GroupBox1.Controls.Add(Me.Checkcompra)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(68, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(261, 139)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._201902273_CASACAMBIOS.My.Resources.Resources.fondo3
        Me.ClientSize = New System.Drawing.Size(667, 361)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.salir)
        Me.Controls.Add(Me.limpiar)
        Me.Controls.Add(Me.calcular)
        Me.Controls.Add(Me.Groupventa)
        Me.Controls.Add(Me.Groupcompra)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form1"
        Me.Text = "Casa de Cambio"
        Me.Groupcompra.ResumeLayout(False)
        Me.Groupcompra.PerformLayout()
        Me.Groupventa.ResumeLayout(False)
        Me.Groupventa.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Checkcompra As CheckBox
    Friend WithEvents Checkventa As CheckBox
    Friend WithEvents Textcompra As TextBox
    Friend WithEvents Textventa As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents compradolar As RadioButton
    Friend WithEvents comprapeso As RadioButton
    Friend WithEvents compraeuro As RadioButton
    Friend WithEvents compracolones As RadioButton
    Friend WithEvents ventadolar As RadioButton
    Friend WithEvents ventapeso As RadioButton
    Friend WithEvents ventaeuro As RadioButton
    Friend WithEvents ventacolones As RadioButton
    Friend WithEvents Groupcompra As GroupBox
    Friend WithEvents Groupventa As GroupBox
    Friend WithEvents calcular As Button
    Friend WithEvents limpiar As Button
    Friend WithEvents salir As Button
    Friend WithEvents LabelQ As Label
    Friend WithEvents LabelCant As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
