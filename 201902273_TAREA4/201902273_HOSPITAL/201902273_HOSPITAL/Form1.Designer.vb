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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Textpaciente = New System.Windows.Forms.TextBox()
        Me.Textnit = New System.Windows.Forms.TextBox()
        Me.Texthonorarios = New System.Windows.Forms.TextBox()
        Me.Combohabitación = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Checkcama = New System.Windows.Forms.CheckBox()
        Me.Checkoperacion = New System.Windows.Forms.CheckBox()
        Me.Checkmaternidad = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Combopago = New System.Windows.Forms.ComboBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CALCULARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARENTRADASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LIMPIARVECTORESToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CERRARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Listnombre = New System.Windows.Forms.ListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Listnit = New System.Windows.Forms.ListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Listhonorarios = New System.Windows.Forms.ListBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Listdias = New System.Windows.Forms.ListBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Listpago = New System.Windows.Forms.ListBox()
        Me.Listhabitacion = New System.Windows.Forms.ListBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Listservicio = New System.Windows.Forms.ListBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Listsubtotal = New System.Windows.Forms.ListBox()
        Me.Listdescuento = New System.Windows.Forms.ListBox()
        Me.Listtotal = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del paciente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nit:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 91)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(217, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Honorarios del médico (Q):"
        '
        'Textpaciente
        '
        Me.Textpaciente.Location = New System.Drawing.Point(235, 38)
        Me.Textpaciente.Name = "Textpaciente"
        Me.Textpaciente.Size = New System.Drawing.Size(231, 20)
        Me.Textpaciente.TabIndex = 4
        '
        'Textnit
        '
        Me.Textnit.Location = New System.Drawing.Point(235, 63)
        Me.Textnit.Name = "Textnit"
        Me.Textnit.Size = New System.Drawing.Size(68, 20)
        Me.Textnit.TabIndex = 5
        '
        'Texthonorarios
        '
        Me.Texthonorarios.Location = New System.Drawing.Point(235, 94)
        Me.Texthonorarios.Name = "Texthonorarios"
        Me.Texthonorarios.Size = New System.Drawing.Size(79, 20)
        Me.Texthonorarios.TabIndex = 7
        '
        'Combohabitación
        '
        Me.Combohabitación.FormattingEnabled = True
        Me.Combohabitación.Items.AddRange(New Object() {"Privada", "Semiprivada", "No privada"})
        Me.Combohabitación.Location = New System.Drawing.Point(131, 138)
        Me.Combohabitación.Name = "Combohabitación"
        Me.Combohabitación.Size = New System.Drawing.Size(121, 21)
        Me.Combohabitación.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(103, 22)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Hábitación:"
        '
        'Checkcama
        '
        Me.Checkcama.AutoSize = True
        Me.Checkcama.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkcama.Location = New System.Drawing.Point(344, 168)
        Me.Checkcama.Name = "Checkcama"
        Me.Checkcama.Size = New System.Drawing.Size(130, 21)
        Me.Checkcama.TabIndex = 10
        Me.Checkcama.Text = "Encamamiento"
        Me.Checkcama.UseVisualStyleBackColor = True
        '
        'Checkoperacion
        '
        Me.Checkoperacion.AutoSize = True
        Me.Checkoperacion.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkoperacion.Location = New System.Drawing.Point(480, 168)
        Me.Checkoperacion.Name = "Checkoperacion"
        Me.Checkoperacion.Size = New System.Drawing.Size(98, 21)
        Me.Checkoperacion.TabIndex = 11
        Me.Checkoperacion.Text = "Operación"
        Me.Checkoperacion.UseVisualStyleBackColor = True
        '
        'Checkmaternidad
        '
        Me.Checkmaternidad.AutoSize = True
        Me.Checkmaternidad.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Checkmaternidad.Location = New System.Drawing.Point(584, 168)
        Me.Checkmaternidad.Name = "Checkmaternidad"
        Me.Checkmaternidad.Size = New System.Drawing.Size(108, 21)
        Me.Checkmaternidad.TabIndex = 12
        Me.Checkmaternidad.Text = "Maternidad"
        Me.Checkmaternidad.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Tipo de pago:"
        '
        'Combopago
        '
        Me.Combopago.FormattingEnabled = True
        Me.Combopago.Items.AddRange(New Object() {"Efectivo", "Cheque", "Tarjeta de débito", "Tarjeta de crédito"})
        Me.Combopago.Location = New System.Drawing.Point(131, 169)
        Me.Combopago.Name = "Combopago"
        Me.Combopago.Size = New System.Drawing.Size(120, 21)
        Me.Combopago.TabIndex = 14
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.AliceBlue
        Me.MenuStrip1.Font = New System.Drawing.Font("Bodoni MT", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CALCULARToolStripMenuItem, Me.LIMPIARENTRADASToolStripMenuItem, Me.LIMPIARVECTORESToolStripMenuItem, Me.CERRARToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(928, 25)
        Me.MenuStrip1.TabIndex = 15
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CALCULARToolStripMenuItem
        '
        Me.CALCULARToolStripMenuItem.Name = "CALCULARToolStripMenuItem"
        Me.CALCULARToolStripMenuItem.Size = New System.Drawing.Size(86, 21)
        Me.CALCULARToolStripMenuItem.Text = "CALCULAR"
        '
        'LIMPIARENTRADASToolStripMenuItem
        '
        Me.LIMPIARENTRADASToolStripMenuItem.Name = "LIMPIARENTRADASToolStripMenuItem"
        Me.LIMPIARENTRADASToolStripMenuItem.Size = New System.Drawing.Size(144, 21)
        Me.LIMPIARENTRADASToolStripMenuItem.Text = "LIMPIAR ENTRADAS"
        '
        'LIMPIARVECTORESToolStripMenuItem
        '
        Me.LIMPIARVECTORESToolStripMenuItem.Name = "LIMPIARVECTORESToolStripMenuItem"
        Me.LIMPIARVECTORESToolStripMenuItem.Size = New System.Drawing.Size(140, 21)
        Me.LIMPIARVECTORESToolStripMenuItem.Text = "LIMPIAR VECTORES"
        '
        'CERRARToolStripMenuItem
        '
        Me.CERRARToolStripMenuItem.Name = "CERRARToolStripMenuItem"
        Me.CERRARToolStripMenuItem.Size = New System.Drawing.Size(71, 21)
        Me.CERRARToolStripMenuItem.Text = "CERRAR"
        '
        'Listnombre
        '
        Me.Listnombre.FormattingEnabled = True
        Me.Listnombre.Location = New System.Drawing.Point(9, 244)
        Me.Listnombre.Name = "Listnombre"
        Me.Listnombre.Size = New System.Drawing.Size(117, 147)
        Me.Listnombre.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 224)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Nombre"
        '
        'Listnit
        '
        Me.Listnit.FormattingEnabled = True
        Me.Listnit.Location = New System.Drawing.Point(131, 244)
        Me.Listnit.Name = "Listnit"
        Me.Listnit.Size = New System.Drawing.Size(67, 147)
        Me.Listnit.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(128, 224)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(31, 17)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Nit"
        '
        'Listhonorarios
        '
        Me.Listhonorarios.FormattingEnabled = True
        Me.Listhonorarios.Location = New System.Drawing.Point(204, 244)
        Me.Listhonorarios.Name = "Listhonorarios"
        Me.Listhonorarios.Size = New System.Drawing.Size(78, 147)
        Me.Listhonorarios.TabIndex = 20
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(201, 224)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(93, 17)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Honorarios "
        '
        'Listdias
        '
        Me.Listdias.FormattingEnabled = True
        Me.Listdias.Location = New System.Drawing.Point(287, 244)
        Me.Listdias.Name = "Listdias"
        Me.Listdias.Size = New System.Drawing.Size(53, 147)
        Me.Listdias.TabIndex = 22
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(300, 224)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 17)
        Me.Label9.TabIndex = 23
        Me.Label9.Text = "Días"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(367, 224)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 17)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "Pago"
        '
        'Listpago
        '
        Me.Listpago.FormattingEnabled = True
        Me.Listpago.Location = New System.Drawing.Point(344, 244)
        Me.Listpago.Name = "Listpago"
        Me.Listpago.Size = New System.Drawing.Size(97, 147)
        Me.Listpago.TabIndex = 25
        '
        'Listhabitacion
        '
        Me.Listhabitacion.FormattingEnabled = True
        Me.Listhabitacion.Location = New System.Drawing.Point(447, 244)
        Me.Listhabitacion.Name = "Listhabitacion"
        Me.Listhabitacion.Size = New System.Drawing.Size(73, 147)
        Me.Listhabitacion.TabIndex = 26
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(767, 208)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(79, 17)
        Me.Label11.TabIndex = 27
        Me.Label11.Text = "Descuento"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(693, 224)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(68, 17)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Subtotal"
        '
        'Listservicio
        '
        Me.Listservicio.FormattingEnabled = True
        Me.Listservicio.Location = New System.Drawing.Point(526, 244)
        Me.Listservicio.Name = "Listservicio"
        Me.Listservicio.Size = New System.Drawing.Size(156, 147)
        Me.Listservicio.TabIndex = 29
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(438, 224)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(87, 17)
        Me.Label13.TabIndex = 30
        Me.Label13.Text = "Habitación"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(569, 224)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 17)
        Me.Label14.TabIndex = 31
        Me.Label14.Text = "Servicio"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(858, 224)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(46, 17)
        Me.Label15.TabIndex = 32
        Me.Label15.Text = "Total"
        '
        'Listsubtotal
        '
        Me.Listsubtotal.FormattingEnabled = True
        Me.Listsubtotal.Location = New System.Drawing.Point(688, 244)
        Me.Listsubtotal.Name = "Listsubtotal"
        Me.Listsubtotal.Size = New System.Drawing.Size(76, 147)
        Me.Listsubtotal.TabIndex = 33
        '
        'Listdescuento
        '
        Me.Listdescuento.FormattingEnabled = True
        Me.Listdescuento.Location = New System.Drawing.Point(770, 244)
        Me.Listdescuento.Name = "Listdescuento"
        Me.Listdescuento.Size = New System.Drawing.Size(76, 147)
        Me.Listdescuento.TabIndex = 34
        '
        'Listtotal
        '
        Me.Listtotal.FormattingEnabled = True
        Me.Listtotal.Location = New System.Drawing.Point(852, 244)
        Me.Listtotal.Name = "Listtotal"
        Me.Listtotal.Size = New System.Drawing.Size(76, 147)
        Me.Listtotal.TabIndex = 35
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global._201902273_HOSPITAL.My.Resources.Resources._222
        Me.PictureBox1.Location = New System.Drawing.Point(698, 38)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(136, 119)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Monotype Corsiva", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(476, 135)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(86, 22)
        Me.Label16.TabIndex = 37
        Me.Label16.Text = "Servicios:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Modern No. 20", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(767, 224)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(77, 17)
        Me.Label17.TabIndex = 38
        Me.Label17.Text = "ó Recargo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(928, 416)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Listtotal)
        Me.Controls.Add(Me.Listdescuento)
        Me.Controls.Add(Me.Listsubtotal)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Listservicio)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Listhabitacion)
        Me.Controls.Add(Me.Listpago)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Listdias)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Listhonorarios)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Listnit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Listnombre)
        Me.Controls.Add(Me.Combopago)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Checkmaternidad)
        Me.Controls.Add(Me.Checkoperacion)
        Me.Controls.Add(Me.Checkcama)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Combohabitación)
        Me.Controls.Add(Me.Texthonorarios)
        Me.Controls.Add(Me.Textnit)
        Me.Controls.Add(Me.Textpaciente)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Textpaciente As TextBox
    Friend WithEvents Textnit As TextBox
    Friend WithEvents Texthonorarios As TextBox
    Friend WithEvents Combohabitación As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Checkcama As CheckBox
    Friend WithEvents Checkoperacion As CheckBox
    Friend WithEvents Checkmaternidad As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Combopago As ComboBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CALCULARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARENTRADASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LIMPIARVECTORESToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CERRARToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Listnombre As ListBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Listnit As ListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Listhonorarios As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Listdias As ListBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Listpago As ListBox
    Friend WithEvents Listhabitacion As ListBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Listservicio As ListBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Listsubtotal As ListBox
    Friend WithEvents Listdescuento As ListBox
    Friend WithEvents Listtotal As ListBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
End Class
