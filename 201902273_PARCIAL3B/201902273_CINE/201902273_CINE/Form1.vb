Imports System.Math
Public Class Form1
    Private Sub LIMPIARMATRIZToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARMATRIZToolStripMenuItem.Click
        limpiarMatriz()
        limpiarE()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        limpiarE()
        Mostrar_Matriz()
    End Sub

    Private Sub BUSCARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BUSCARToolStripMenuItem.Click
        buscar()
    End Sub

    Private Sub ACEPTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACEPTARToolStripMenuItem.Click
        If (numero <= 6) Then
            cine(numero, 0) = Str(Val(Textnit.Text))
            cine(numero, 1) = Textpeli.Text
            cine(numero, 2) = Str(Val(Textnormal.Text))
            cine(numero, 3) = Str(Val(Text3d.Text))
            cine(numero, 4) = Str(Val(Text4dx.Text))
            If (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then
                If (CheckBox1.Checked) Then
                    cine(numero, 5) = Str(normal * Val(cine(numero, 2)))
                Else
                    cine(numero, 5) = 0
                End If
                If (CheckBox2.Checked) Then
                    cine(numero, 6) = Str(D * Val(cine(numero, 3)))
                Else
                    cine(numero, 6) = 0
                End If
                If (CheckBox3.Checked) Then
                    cine(numero, 7) = Str(DDX * Val(cine(numero, 4)))
                Else
                    cine(numero, 7) = 0
                End If
            Else
                MsgBox("Debe seleccionar al menos una sala de cine")
            End If
            cine(numero, 8) = Str(Val(cine(numero, 5)) + Val(cine(numero, 6)) + Val(cine(numero, 7)))
            numero = numero + 1
        End If
        If (numero = 7) Then
            MsgBox("Se ha llenado la matriz, porfavor seleccione la opción limpiar matriz")
        End If

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        cine(numero, 0) = Str(Val(Textnit.Text))
        cine(numero, 1) = Textpeli.Text
        cine(numero, 2) = Str(Val(Textnormal.Text))
        cine(numero, 3) = Str(Val(Text3d.Text))
        cine(numero, 4) = Str(Val(Text4dx.Text))
        If (CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked) Then
            If (CheckBox1.Checked) Then
                cine(numero, 5) = Str(normal * Val(cine(numero, 2)))
            Else
                cine(numero, 5) = 0
            End If
            If (CheckBox2.Checked) Then
                cine(numero, 6) = Str(D * Val(cine(numero, 3)))
            Else
                cine(numero, 6) = 0
            End If
            If (CheckBox3.Checked) Then
                cine(numero, 7) = Str(DDX * Val(cine(numero, 4)))
            Else
                cine(numero, 7) = 0
            End If
        Else
            MsgBox("Debe seleccionar al menos una sala de cine")
        End If
        cine(numero, 8) = Str(Val(cine(numero, 5)) + Val(cine(numero, 6)) + Val(cine(numero, 7)))
        MsgBox("Registro actualizado correctamente en la matriz")
        numero = I
        limpiarE()

    End Sub
End Class
