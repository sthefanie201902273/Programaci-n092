Imports System.Math
Public Class Form1
    Private Sub CALCULARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CALCULARToolStripMenuItem.Click
        If (numero <= 6) Then
            kmi(numero) = Val(Textkmi.Text)
            kmf(numero) = Val(Textkmf.Text)
            placa(numero) = Val(Textplaca.Text)
            cobrobase(numero) = base()
            kilometros(numero) = Round((kmf(numero) - kmi(numero)), 2)
            If (kmi(numero) < kmf(numero)) Then
                If (kilometros(numero) > 0 And kilometros(numero) <= 50) Then
                    cobrokm(numero) = Round((kilometros(numero) * cobrokm1), 2)
                ElseIf (kilometros(numero) > 50 And kilometros(numero) <= 70) Then
                    cobrokm(numero) = Round((kilometros(numero) * cobrokm2), 2)
                ElseIf (kilometros(numero) > 70) Then
                    cobrokm(numero) = Round((kilometros(numero) * cobrokm3), 2)
                Else
                    MsgBox("Revise el ingreso de sus kilometrajes")
                    Textkmi.Focus()
                End If
            Else
                MsgBox("su kilometraje final debe ser mayor")
                Exit Sub
                Textkmf.Focus()
            End If
            pagofinal(numero) = Round((cobrobase(numero) + cobrokm(numero)), 2)

                numero = numero + 1

            End If
            If (numero = 7) Then
            MsgBox("Vectores Llenos")
        End If


    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        limpiarvec()
    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar()
        Textkmi.Clear()
        Textkmf.Clear()
        Textplaca.Clear()
        ComboBox1.SelectedIndex = -1
    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 6) And Not (existe)
            If (placa(I) = Val(Textconsulta.Text)) Then

                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            ComboBox1.Text = carro(I)
            Textplaca.Text = Str(placa(I))
            Textkmi.Text = Str(kmi(I))
            Textkmf.Text = Str(kmf(I))
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(placa(I)), carro(I), Str(cobrobase(I)), Str(kmi(I)), Str(kmf(I)), Str(cobrokm(I)), Str(pagofinal(I)))
            numero = I
        Else
            MsgBox("Placa no encontrado")
            Textconsulta.Focus()
        End If

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        kmi(numero) = Val(Textkmi.Text)
        kmf(numero) = Val(Textkmf.Text)
        placa(numero) = Val(Textplaca.Text)
        cobrobase(numero) = base()
        kilometros(numero) = Round((kmf(numero) - kmi(numero)), 2)

        If (kilometros(numero) > 0 And kilometros(numero) <= 50) Then
            cobrokm(numero) = Round((kilometros(numero) * cobrokm1), 2)
        ElseIf (kilometros(numero) > 50 And kilometros(numero) <= 70) Then
            cobrokm(numero) = Round((kilometros(numero) * cobrokm2), 2)
        ElseIf (kilometros(numero) > 70) Then
            cobrokm(numero) = Round((kilometros(numero) * cobrokm3), 2)
        Else
            MsgBox("Revise el ingreso de sus kilometrajes")
            Textkmi.Focus()
        End If

        pagofinal(numero) = Round((cobrobase(numero) + cobrokm(numero)), 2)
        MsgBox("Registro actualizado correctamente en los vectores")
        Textkmi.Clear()
        Textkmf.Clear()
        Textplaca.Clear()
        ComboBox1.SelectedIndex = -1
        numero = I

    End Sub

    Private Sub ELIMINARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARToolStripMenuItem.Click
        carro(numero) = Nothing
        kmi(numero) = Nothing
        kmf(numero) = Nothing
        placa(numero) = Nothing
        cobrobase(numero) = Nothing
        pagofinal(numero) = Nothing
        cobrokm(numero) = Nothing
        kilometros(numero) = Nothing
        For I = numero To 5
            carro(I) = carro(I + 1)
            kmi(I) = kmi(I + 1)
            kmf(I) = kmf(I + 1)
            placa(I) = placa(I + 1)
            cobrobase(I) = cobrobase(I + 1)
            pagofinal(I) = pagofinal(I + 1)
            cobrokm(I) = cobrokm(I + 1)
            kilometros(I) = kilometros(I + 1)
        Next I
        MsgBox("Registro Eliminado exitosamente")
        carro(I) = Nothing
        kmi(I) = Nothing
        kmf(I) = Nothing
        placa(I) = Nothing
        cobrobase(I) = Nothing
        pagofinal(I) = Nothing
        cobrokm(I) = Nothing
        kilometros(I) = Nothing
        numero = I
        Textkmi.Clear()
        Textkmf.Clear()
        Textplaca.Clear()
        ComboBox1.SelectedIndex = -1
        DataGridView1.Rows.Clear()

    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub
End Class
