Public Class Form1
    Private Sub CERRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CERRARToolStripMenuItem.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (numero_paciente <= 5) Then
            Nombre(numero_paciente) = Textpaciente.Text
            Nit(numero_paciente) = Val(Textnit.Text)
            Honorarios(numero_paciente) = Val(Texthonorarios.Text)
            Dias(numero_paciente) = Val(InputBox("ingrese número de días"))
            subtot()
            Descuento(numero_paciente) = desc()
            Total(numero_paciente) = tot()
            mostrarresultados()
            numero_paciente = numero_paciente + 1

        End If
        If (numero_paciente = 6) Then
            MsgBox("Vectores Llenos")
        End If

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiar_vec()
    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_E()
    End Sub
End Class
