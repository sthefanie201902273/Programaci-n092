Public Class FormResultados
    Public totalC As Double, totalV As Double
    Public Sub Calculo_tot()
        If (Form1.Checkcompra.Checked) Then
            If (Form1.Checkcompra.Checked) And (Form1.compradolar.Checked) Then
                totalC = dolarc + comisionC
            ElseIf (Form1.Checkcompra.Checked) And (Form1.comprapeso.Checked) Then
                totalC = pesoc + comisionC
            ElseIf (Form1.Checkcompra.Checked) And (Form1.compraeuro.Checked) Then
                totalC = euroc + comisionC
            ElseIf (Form1.Checkcompra.Checked) And (Form1.compracolones.Checked) Then
                totalC = colonc + comisionC
            Else
                totalC = 0
            End If
        End If
        If (Form1.Checkventa.Checked) Then
            If (Form1.Checkventa.Checked) And (Form1.ventadolar.Checked) Then
                totalV = dolarv + comisionV
            ElseIf (Form1.Checkventa.Checked) And (Form1.ventapeso.Checked) Then
                totalV = pesov + comisionV
            ElseIf (Form1.Checkventa.Checked) And (Form1.ventaeuro.Checked) Then
                totalV = eurov + comisionV
            ElseIf (Form1.Checkventa.Checked) And (Form1.ventacolones.Checked) Then
                totalV = colonv + comisionV
            Else
                totalV = 0
            End If
        End If

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub mostrar_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub salir2_Click(sender As Object, e As EventArgs) Handles salir2.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub Texttotal2_TextChanged(sender As Object, e As EventArgs) Handles Texttotal2.TextChanged

    End Sub

    Private Sub regresar_Click(sender As Object, e As EventArgs) Handles regresar.Click

        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub limpiar1_Click(sender As Object, e As EventArgs) Handles limpiar1.Click
        LIMPIAR_form2()
    End Sub

    Private Sub FormResultados_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
End Class