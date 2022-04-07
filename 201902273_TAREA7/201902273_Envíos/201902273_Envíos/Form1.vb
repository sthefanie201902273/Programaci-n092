Imports System.Math
Public Class Form1
    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        Dim j As Byte
        Dim totlociones As Double = 0
        Dim plastico As Byte = 0
        Dim totdocumentos As Double = 0
        Dim ropa As Byte = 0
        For j = 0 To 9
            If (paquete(j) <> Nothing) Then
                If (paquete(j) = "Lociones") Then
                    totlociones = totlociones + valor(j)
                End If
                If (paquete(j) = "Artículos de plástico") Then
                    plastico = plastico + 1
                End If
                If (paquete(j) = "Documentos") Then
                    totdocumentos = totdocumentos + valor(j)
                End If
                If (paquete(j) = "Ropa") Then
                    ropa = ropa + 1
                End If
            Else
                Exit For
            End If
        Next j
        TextBox1.Text = "Q" + Str(Round(totlociones, 2))
        TextBox2.Text = Str(plastico)
        TextBox3.Text = "Q" + Str(Round(totdocumentos, 2))
        TextBox4.Text = Str(ropa)
    End Sub

    Private Sub SalirToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem1.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub LimpiarEntradasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarEntradasToolStripMenuItem.Click
        limpiar_entradas()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()

    End Sub

    Private Sub LimpiarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LimpiarVectoresToolStripMenuItem.Click
        limpiar_vec()
    End Sub

    Private Sub MostrarVectoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarVectoresToolStripMenuItem.Click
        mostrar()
    End Sub

    Private Sub AceptarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AceptarToolStripMenuItem.Click
        If (numero <= 9) Then
            Nombre(numero) = Textnonbre.Text
            valor(numero) = Val(Textvalor.Text)
            paquete(numero) = Combopaquete.Text
            tipo_envio(numero) = ComboBox1.Text
            peso(numero) = Val(InputBox("Ingrese el peso del paquete"))
            If (peso(numero) >= 0 And peso(numero) <= 5) Then
                Select Case (Combopaquete.SelectedIndex)
                    Case 0
                        impuesto(numero) = peso(numero) * documentos
                    Case 1
                        impuesto(numero) = peso(numero) * ropa
                    Case 2
                        impuesto(numero) = peso(numero) * art_pedecedero
                    Case 3
                        impuesto(numero) = peso(numero) * art_plasticos
                    Case 4
                        impuesto(numero) = peso(numero) * lociones
                    Case -1
                        MsgBox("Debe seleccionar un tipo de paquete")
                        Exit Sub
                End Select
            Else
                impuesto(numero) = peso(numero) * 0
            End If
            pagoparcial(numero) = valor(numero) + impuesto(numero)

            Select Case (ComboBox1.SelectedIndex)
                Case 0
                    pagototal(numero) = camion + pagoparcial(numero)
                Case 1
                    pagototal(numero) = moto + pagoparcial(numero)
                Case -1
                    MsgBox("Debe seleccionar una forma de envio")
                    Exit Sub
            End Select
            numero = numero + 1
        End If
        If (numero = 10) Then
            MsgBox("Vectores llenos")
        End If
    End Sub
End Class
