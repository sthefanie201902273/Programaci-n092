Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub CToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CToolStripMenuItem.Click
        If (numero <= 5) Then
            Nombre(numero) = Textnombre.Text
            If (IsNumeric(Textinventario.Text) And Val(Textinventario.Text)) Then
                canti(numero) = Val(Textinventario.Text)
            Else
                MsgBox("cantidad en inventario invalida")
                Exit Sub
            End If
            If ((IsNumeric(Textcantd.Text) And Val(Textcantd.Text))) Then

                cantd(numero) = Val(Textcantd.Text)
            Else
                MsgBox("cantidad deseada invalida")
                Exit Sub
            End If
            If (Val(Textcantd.Text) > Val(Textinventario.Text)) Then
                MsgBox("la cantidad deseada debe ser menor que el inventario disponible")
                Exit Sub
            End If
            numerodepacks()
            numerosobrante()
            Select Case (ComboBox1.SelectedIndex)
                Case 0, 1, 2, 3
                    valorpack()
                Case -1
                    MsgBox("debe seleccionar un producto")
                    Exit Sub
            End Select
            descuentoo()
            productoo()
            ingresopack_unidad()
            ingresopackss()
            ingresosobrante()
            totall()
            mostrar()
            numero = numero + 1
            End If
            If (numero = 6) Then
            MsgBox("Vectores Llenos")
        End If



    End Sub

    Private Sub LToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LToolStripMenuItem.Click
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub LlToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LlToolStripMenuItem.Click
        Dim c As Byte
        For c = 0 To 5
            Nombre(c) = Nothing
            Producto(c) = Nothing
            canti(c) = Nothing
            cantd(c) = Nothing
            descuento(c) = Nothing
            cantdepacks(c) = Nothing
            cantsobrante(c) = Nothing
            valordepack(c) = Nothing
            ingresoporpack(c) = Nothing
            ingresopacks(c) = Nothing
            ingresoporproducto(c) = Nothing
            total(c) = Nothing

        Next c
        numero = 0

    End Sub
End Class
