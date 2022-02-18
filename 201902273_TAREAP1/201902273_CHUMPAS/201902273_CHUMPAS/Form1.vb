Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click

        If (Radiosmall.Checked) Then
            valoryarda = yardas_small
        ElseIf (Radiomedium.Checked) Then
            valoryarda = yardas_medium
        ElseIf (Radiolarge.Checked) Then
            valoryarda = yardas_large
        Else
            MsgBox("no seleccionó tamaño de chumpa")
            Exit Sub
        End If

        If (Checkalgodon.Checked) Or (Checkseda.Checked) Or (Checklona.Checked) Then
            If (Checkalgodon.Checked) Then
                If (IsNumeric(Textalgodon.Text) And Val(Textalgodon.Text) >= 0) Then
                    cantA = Val(Textalgodon.Text)
                    totalmatA = valoryarda * algodon * cantA
                    costoA = (MO() * cantA) + totalmatA
                    precioA = (costoA + (0.65 * costoA)) / cantA
                Else
                    MsgBox("ingresó una cantidad inválida, intentelo de nuevo")
                    Textalgodon.Focus()
                    Exit Sub
                End If
            Else
                cantA = 0
                totalmatA = 0
                costoA = 0
                precioA = 0
            End If
            If (Checkseda.Checked) Then

                If (IsNumeric(Textseda.Text) And Val(Textseda.Text) >= 0) Then
                    cantS = Val(Textseda.Text)
                    totalmatS = valoryarda * seda * cantS
                    costoS = (MO() * cantS) + totalmatS
                    precioS = (costoS + (0.65 * costoS)) / cantS
                Else
                    MsgBox("ingresó una cantidad inválida, intentelo de nuevo")
                    Textseda.Focus()
                    Exit Sub
                End If
            Else
                cantS = 0
                totalmatS = 0
                costoS = 0
                precioS = 0
            End If
            If (Checklona.Checked) Then

                If (IsNumeric(Textlona.Text) And Val(Textlona.Text) >= 0) Then
                    CantL = Val(Textlona.Text)
                    totalmatL = valoryarda * lona * CantL
                    costoL = (MO() * CantL) + totalmatL
                    precioL = (costoL + (0.65 * costoL)) / CantL

                Else
                    MsgBox("ingresó una cantidad inválida, intentelo de nuevo")
                    Textlona.Focus()
                    Exit Sub
                End If
            Else
                CantL = 0
                totalmatL = 0
                costoL = 0
                precioL = 0
            End If
        Else
            MsgBox("No seleccionó ningún tipo de material")
            Exit Sub
        End If

        totalchumpas = Totchumpas()
        calculotot()
        Mostrar_resultados()
        Me.Hide()
        Totales.Show()
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click

        Call LIM()

    End Sub

    Private Sub Radiosmall_CheckedChanged(sender As Object, e As EventArgs) Handles Radiosmall.CheckedChanged
        Totales.Texttamaño.Text = "Cumpas small"
    End Sub

    Private Sub Radiomedium_CheckedChanged(sender As Object, e As EventArgs) Handles Radiomedium.CheckedChanged
        Totales.Texttamaño.Text = "Cumpas Medium"
    End Sub

    Private Sub Radiolarge_CheckedChanged(sender As Object, e As EventArgs) Handles Radiolarge.CheckedChanged
        Totales.Texttamaño.Text = "Cumpas Large"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
