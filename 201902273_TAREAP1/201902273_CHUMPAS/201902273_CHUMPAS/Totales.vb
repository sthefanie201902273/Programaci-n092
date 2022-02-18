Public Class Totales


    Private Sub Texttamaño_TextChanged(sender As Object, e As EventArgs) Handles Texttamaño.TextChanged


    End Sub

    Private Sub Totales_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form1.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If
    End Sub
End Class