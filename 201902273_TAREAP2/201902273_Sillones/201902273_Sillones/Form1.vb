Public Class Form1
    Private Sub LimpiarCeldasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarCeldasToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click

        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub CalcularToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CalcularToolStripMenuItem.Click
        If (numero < 8) Then
            If (IsNumeric(Textventa.Text) And Val(Textventa.Text)) Then
                no_venta(numero) = Val(Textventa.Text)
            Else
                MsgBox("ingresó un número inválido")
                Exit Sub
            End If
            If (IsNumeric(Textcant.Text) And Val(Textcant.Text)) Then
                cantidad(numero) = Val(Textcant.Text)
            Else
                MsgBox("ingresó una cantidad inválida")
                Exit Sub
            End If

            Select Case (Combotamaño.SelectedIndex)
                    Case 0, 1, 2
                        tamaño_sillon()
                    Case -1
                        MsgBox("Debe seleccionar un tamaño de sillon")
                        Exit Sub
                        Combotamaño.Focus()
                End Select

                If (Radiocuero.Checked Or Radiocuerina.Checked) Then
                    telas()
                Else
                    MsgBox("Debe seleccionar un tipo de tela")
                    Exit Sub

                End If
                preciocosto(numero) = preciocost()
                precioventa(numero) = preciovent()
                precioventa_unidad(numero) = preciovent_unidad()
                mostrar()
                numero = numero + 1
            End If
            If (numero = 8) Then
            MsgBox("Vectores llenos, limpie vectores")
        End If
    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vectores()
    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub
End Class
