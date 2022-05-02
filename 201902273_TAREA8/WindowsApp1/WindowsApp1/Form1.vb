Imports System.Math
Public Class Form1
    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub LIMPIARVECTORESToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARVECTORESToolStripMenuItem.Click
        DataGridView1.Rows.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        Textconsulta.Clear()
        numero = 0
        For I = 0 To 11

            etapa(I) = Nothing
            equipo(I) = Nothing
            km(I) = Nothing
            tiempo(I) = Nothing
            tiempotot(I) = Nothing
            nacionalidad(I) = Nothing
            penaliza(I) = Nothing
        Next I

    End Sub

    Private Sub LIMPIARENTRADASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LIMPIARENTRADASToolStripMenuItem.Click
        limpiar_E()
    End Sub

    Private Sub SALIRToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALIRToolStripMenuItem.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If

    End Sub

    Private Sub MOSTRARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MOSTRARToolStripMenuItem.Click
        mostrar()

    End Sub

    Private Sub ORDENARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ORDENARToolStripMenuItem.Click
        Dim a As Byte
        Dim b As Byte
        Dim temp1 As Integer
        Dim temp2 As String
        Dim temp3 As Double
        Dim temp4 As String
        Dim temp5 As Integer
        Dim temp6 As Integer
        Dim temp7 As Integer
        For a = 0 To 10
            For b = a + 1 To 11
                If (etapa(b) <> Nothing) Then
                    If (etapa(a) > etapa(b)) Then
                        temp1 = etapa(a)
                        etapa(a) = etapa(b)
                        etapa(b) = temp1
                        temp2 = equipo(a)
                        equipo(a) = equipo(b)
                        equipo(b) = temp2
                        temp3 = km(a)
                        km(a) = km(b)
                        km(b) = temp3
                        temp4 = nacionalidad(a)
                        nacionalidad(a) = nacionalidad(b)
                        nacionalidad(b) = temp4
                        temp5 = tiempo(a)
                        tiempo(a) = tiempo(b)
                        tiempo(b) = temp5
                        temp6 = penaliza(a)
                        penaliza(a) = penaliza(b)
                        penaliza(b) = temp6
                        temp7 = tiempotot(a)
                        tiempotot(a) = tiempotot(b)
                        tiempotot(b) = temp7
                    End If
                End If
            Next b
        Next a
    End Sub

    Private Sub GUARDARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GUARDARToolStripMenuItem.Click
        If (numero <= 11) Then
            nacionalidad(numero) = ComboBox1.Text
            equipo(numero) = Comboequipo.Text
            etapa(numero) = Val(Textetapa.Text)
            km(numero) = Val(Textkm.Text)
            tiempo(numero) = Val(Texttiempo.Text)

            penalización_recompensa()

            numero = numero + 1

        End If
        If (numero = 12) Then
            MsgBox("Vectores Llenos")
        End If

    End Sub

    Private Sub VERESTADISTICASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERESTADISTICASToolStripMenuItem.Click
        Dim j As Byte
        Dim corredores As Byte = 0
        Dim km_eq1 As Double = 0
        Dim km_eq2 As Double = 0
        Dim km_eq3 As Double = 0
        Dim km_eq4 As Double = 0
        Dim tiempotot1 As Integer = 0
        Dim tiempotot2 As Integer = 0
        For j = 0 To 11
            If (km(j) <> Nothing) Then
                If (km(j) > 45 And nacionalidad(j) = "Guatemalteco") Then
                    corredores = corredores + 1
                End If
                If (equipo(j) = "SKY") Then
                    km_eq1 = km_eq1 + km(j)
                End If
                If (equipo(j) = "Movistar") Then
                    km_eq2 = km_eq2 + km(j)
                End If
                If (equipo(j) = "Pro Cycling") Then
                    km_eq3 = km_eq3 + km(j)
                End If
                If (equipo(j) = "Pro Team") Then
                    km_eq4 = km_eq4 + km(j)
                End If
                If (nacionalidad(j) = "Guatemalteco") Then
                    tiempotot1 = tiempotot1 + tiempotot(j)
                End If
                If (nacionalidad(j) = "Extranjero") Then
                    tiempotot2 = tiempotot2 + tiempotot(j)
                End If
            Else
                Exit For
            End If
        Next j
        If (tiempotot1 > 60) Then
            Dim hora As Integer = 60
            Dim conversion_hora As Integer
            Dim conversion_min As Integer
            conversion_hora = tiempotot1 / hora
            conversion_min = tiempotot1 - conversion_hora * hora
            TextBox6.Text = conversion_hora.ToString + " horas " + conversion_min.ToString + " min."
        Else
            TextBox6.Text = Str(tiempotot1) + " min."
        End If
        If (tiempotot2 > 60) Then
            Dim hora As Integer = 60
            Dim conversion_hora As Integer
            Dim conversion_min As Integer
            conversion_hora = tiempotot2 / hora
            conversion_min = tiempotot2 - conversion_hora * hora
            TextBox7.Text = conversion_hora.ToString + " horas " + conversion_min.ToString + " min."
        Else
            TextBox7.Text = Str(tiempotot2) + " min."
        End If
        TextBox1.Text = Str(corredores)
        TextBox2.Text = Str(Round(km_eq1, 2))
        TextBox3.Text = Str(Round(km_eq2, 2))
        TextBox4.Text = Str(Round(km_eq3, 2))
        TextBox5.Text = Str(Round(km_eq4, 2))




    End Sub

    Private Sub CONSULTARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CONSULTARToolStripMenuItem.Click
        Dim existe As Boolean = False
        I = 0
        While (I <= 11) And Not (existe)
            If (etapa(I) = Val(Textconsulta.Text)) Then
                existe = True
            Else
                I = I + 1
            End If
        End While

        If (existe) Then
            MsgBox("Registro Encontrado exitosamente")
            Textetapa.Text = Str(etapa(I))
            Textkm.Text = Str(km(I))
            Texttiempo.Text = Str(tiempo(I))
            Comboequipo.Text = equipo(I)
            ComboBox1.Text = nacionalidad(I)
            DataGridView1.Rows.Clear()
            DataGridView1.Rows.Add(Str(etapa(I)), equipo(I), Str(km(I)), nacionalidad(I), Str(tiempo(I)), Str(penaliza(I)), Str(tiempotot(I)))
            numero = I
        Else
            MsgBox("Etapa no encontrada")
            Textconsulta.Focus()
        End If

    End Sub

    Private Sub ACTUALIZARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ACTUALIZARToolStripMenuItem.Click
        nacionalidad(numero) = ComboBox1.Text
        equipo(numero) = Comboequipo.Text
        etapa(numero) = Val(Textetapa.Text)
        km(numero) = Val(Textkm.Text)
        tiempo(numero) = Val(Texttiempo.Text)

        penalización_recompensa()
        MsgBox("Registro actualizado correctamente en los vectores")
        numero = I

    End Sub
End Class
