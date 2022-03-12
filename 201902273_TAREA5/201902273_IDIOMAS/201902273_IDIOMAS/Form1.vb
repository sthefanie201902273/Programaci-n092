Imports System.Math
Public Class Form1
    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiarMatriz()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles Textfecha.TextChanged

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (contador < 8) Then
            datos(contador, 0) = Textnombre.Text
            datos(contador, 1) = Val(Textcarnet.Text)
            datos(contador, 2) = DateValue(Textfecha.Text)
            datos(contador, 3) = Comboidiomas.Text
            datos(contador, 5) = Val(InputBox("Ingrese cantidad de horas que desea recibir el idioma seleccionado"))
            datos(contador, 6) = Combopago.Text

            parcial()

            descuento1()
            Desc2()

            pagofinal()
            Mostrar()
            contador = contador + 1
        End If
        If (contador = 8) Then
            MsgBox("Se ha llenado la matriz, porfavor seleccione la opción limpiar matrices")
        End If

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiardatos()
    End Sub

    Private Sub Checkviernes_CheckedChanged(sender As Object, e As EventArgs) Handles Checkviernes.CheckedChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
