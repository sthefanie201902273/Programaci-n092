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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LlToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SalirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Textnombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Textinventario = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Textcantd = New System.Windows.Forms.TextBox()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CToolStripMenuItem, Me.LToolStripMenuItem, Me.LlToolStripMenuItem, Me.SalirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(748, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CToolStripMenuItem
        '
        Me.CToolStripMenuItem.Name = "CToolStripMenuItem"
        Me.CToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CToolStripMenuItem.Text = "Aceptar"
        '
        'LToolStripMenuItem
        '
        Me.LToolStripMenuItem.Name = "LToolStripMenuItem"
        Me.LToolStripMenuItem.Size = New System.Drawing.Size(84, 20)
        Me.LToolStripMenuItem.Text = "Limpiar Grid"
        '
        'LlToolStripMenuItem
        '
        Me.LlToolStripMenuItem.Name = "LlToolStripMenuItem"
        Me.LlToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.LlToolStripMenuItem.Text = "Limpiar vectores"
        '
        'SalirToolStripMenuItem
        '
        Me.SalirToolStripMenuItem.Name = "SalirToolStripMenuItem"
        Me.SalirToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.SalirToolStripMenuItem.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(246, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(256, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "PACKS DE PRODUCTOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nombre del pack:"
        '
        'Textnombre
        '
        Me.Textnombre.Location = New System.Drawing.Point(167, 100)
        Me.Textnombre.Name = "Textnombre"
        Me.Textnombre.Size = New System.Drawing.Size(222, 20)
        Me.Textnombre.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 135)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 18)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Producto:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 18)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Cantidad Inventario:"
        '
        'Textinventario
        '
        Me.Textinventario.Location = New System.Drawing.Point(181, 168)
        Me.Textinventario.Name = "Textinventario"
        Me.Textinventario.Size = New System.Drawing.Size(113, 20)
        Me.Textinventario.TabIndex = 6
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Jugos", "Frituras", "Galletas", "Baterias"})
        Me.ComboBox1.Location = New System.Drawing.Point(167, 136)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column10, Me.Column8, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(707, 150)
        Me.DataGridView1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(356, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(202, 18)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cantidad deseada en pack:"
        '
        'Textcantd
        '
        Me.Textcantd.Location = New System.Drawing.Point(564, 167)
        Me.Textcantd.Name = "Textcantd"
        Me.Textcantd.Size = New System.Drawing.Size(113, 20)
        Me.Textcantd.TabIndex = 10
        '
        'Column1
        '
        Me.Column1.HeaderText = "Nombre de pack"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Producto"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Cantidad en inventario"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Cantidad deseasa en cada pack"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Número de packs"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "Sobrante"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "Ingresos por pack (unidad)"
        Me.Column7.Name = "Column7"
        '
        'Column10
        '
        Me.Column10.HeaderText = "Ingreso total de packs"
        Me.Column10.Name = "Column10"
        '
        'Column8
        '
        Me.Column8.HeaderText = "Ingreso producto sobrante"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "Total ingresos"
        Me.Column9.Name = "Column9"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 378)
        Me.Controls.Add(Me.Textcantd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Textinventario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Textnombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Supermercado"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LlToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SalirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Textnombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Textinventario As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Textcantd As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
End Class
