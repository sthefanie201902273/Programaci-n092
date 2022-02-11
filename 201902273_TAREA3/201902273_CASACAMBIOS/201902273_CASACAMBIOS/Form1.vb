Public Class Form1
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub compradolar_CheckedChanged(sender As Object, e As EventArgs) Handles compradolar.CheckedChanged

    End Sub

    Private Sub calcular_Click(sender As Object, e As EventArgs) Handles calcular.Click



        If (Checkcompra.Checked) Or (Checkventa.Checked) Then
            If (Checkcompra.Checked) Then

                If (IsNumeric(Textcompra.Text) And Val(Textcompra.Text) >= 0) Then
                    cantidadCompra = Val(Textcompra.Text)
                Else
                    MsgBox("Cantidad de compra invalida, intentelo de nuevo")
                    Textcompra.Focus()
                    Exit Sub
                End If
            Else
                cantidadCompra = 0
            End If
            If (Checkventa.Checked) Then

                If (IsNumeric(Textventa.Text) And Val(Textventa.Text) >= 0) Then
                    cantidadVenta = Val(Textventa.Text)
                Else
                    MsgBox("Cantidad de venta invalida, intentelo de nuevo")
                    Textventa.Focus()
                    Exit Sub
                End If
            Else
                cantidadVenta = 0
            End If
        Else
            MsgBox("No seleccionó ninguna transacción")
            Exit Sub
        End If


        If (Checkcompra.Checked) Then

            If (Checkcompra.Checked) And (compradolar.Checked) Then
                dolarc = cantidadCompra / precioDolar
                comisionC = dolarc * comisioncompra
            ElseIf (Checkcompra.Checked) And (comprapeso.Checked) Then
                pesoc = cantidadCompra / precioPeso
                comisionC = pesoc * comisioncompra
            ElseIf (Checkcompra.Checked) And (compraeuro.Checked) Then
                euroc = cantidadCompra / precioEuro
                comisionC = euroc * comisioncompra
            ElseIf (Checkcompra.Checked) And (compracolones.Checked) Then
                colonc = cantidadCompra / precioColon
                comisionC = colonc * comisioncompra

            Else
                MsgBox("No seleccionó ningun tipo de moneda para compra")
                Exit Sub
            End If
        Else
            dolarc = 0
            pesoc = 0
            euroc = 0
            colonc = 0
        End If

        If (Checkventa.Checked) Then
            If (Checkventa.Checked) And (ventadolar.Checked) Then
                dolarv = cantidadVenta * precioDolar
                comisionV = dolarv * comisionventa
            ElseIf (Checkventa.Checked) And (ventapeso.Checked) Then
                pesov = cantidadVenta * precioPeso
                comisionV = pesov * comisionventa
            ElseIf (Checkventa.Checked) And (ventaeuro.Checked) Then
                eurov = cantidadVenta * precioEuro
                comisionV = eurov * comisionventa
            ElseIf (Checkventa.Checked) And (ventacolones.Checked) Then
                colonv = cantidadVenta * precioColon
                comisionV = colonv * comisionventa

            Else
                MsgBox("No seleccionó ningun tipo de moneda para su venta")
                Exit Sub
            End If
        Else
            dolarv = 0
            pesov = 0
            eurov = 0
            colonv = 0
        End If


        Me.Hide()
        FormResultados.Show()
        FormResultados.Calculo_tot()
        Resultados()


    End Sub

    Private Sub Checkcompra_CheckedChanged(sender As Object, e As EventArgs) Handles Checkcompra.CheckedChanged
        If (Checkcompra.Checked) Then
            Textcompra.Visible = True
            Groupcompra.Visible = True
            LabelQ.Visible = True
            LabelCant.Visible = True
            Textcompra.Focus()
        Else
            Textcompra.Visible = False
            Groupcompra.Visible = False
            LabelQ.Visible = False
            LabelCant.Visible = False
        End If

    End Sub

    Private Sub Checkventa_CheckedChanged(sender As Object, e As EventArgs) Handles Checkventa.CheckedChanged
        If (Checkventa.Checked) Then
            Textventa.Visible = True
            Groupventa.Visible = True
            Textventa.Focus()
        Else
            Textventa.Visible = False
            Groupventa.Visible = False
        End If
    End Sub

    Private Sub salir_Click(sender As Object, e As EventArgs) Handles salir.Click
        If (MsgBox("¿Está seguro que quiere salir?", vbQuestion + vbYesNo, "Salir") = vbYes) Then
            Me.Close()
        End If
    End Sub

    Private Sub limpiar_Click(sender As Object, e As EventArgs) Handles limpiar.Click
        LIMPIAR_form1()
    End Sub
End Class

