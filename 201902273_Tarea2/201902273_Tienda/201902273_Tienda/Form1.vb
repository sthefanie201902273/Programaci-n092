Imports System.Math
Public Class Form1
    Dim NOMBRE_CLIENTE As String, cant_arroz As Integer = 0
    Dim cant_frijol As Integer = 0, cant_azucar As Integer = 0
    Dim pago_sinIVA As Double, iva_total As Double, Pago_conIVA As Double
    Dim Descuento As Double, Total_a_Pagar As Double
    Const iva = 0.12
    Const desc_aniversario = 0.025

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        GroupBox2.Visible = True
        GroupBox1.Visible = False
        Label8.Visible = False
        TextBox4.Visible = False
        TextBox10.Visible = True
        TextBox11.Visible = True
        NOMBRE_CLIENTE = TextBox4.Text
        cant_arroz = TextBox1.Text : cant_frijol = TextBox2.Text : cant_azucar = TextBox3.Text

        pago_sinIVA = Round((cant_arroz * 2) + (cant_frijol * 1.75) + (cant_azucar * 2.5), 2)
        iva_total = Round((pago_sinIVA * iva), 2)
        Pago_conIVA = Round((pago_sinIVA + iva_total), 2)
        Descuento = Round((Pago_conIVA * desc_aniversario), 2)
        Total_a_Pagar = Round((Pago_conIVA - Descuento), 2)

        TextBox7.Text = pago_sinIVA.ToString
        TextBox6.Text = iva_total.ToString
        TextBox5.Text = Pago_conIVA.ToString
        TextBox8.Text = Descuento.ToString
        TextBox9.Text = Total_a_Pagar.ToString
        TextBox10.Text = "MUCHAS GRACIAS POR TU COMPRA "
        TextBox11.Text = NOMBRE_CLIENTE
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        TextBox4.Clear()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        GroupBox2.Visible = False
        GroupBox1.Visible = True
        Label8.Visible = True
        TextBox4.Visible = True
        TextBox10.Visible = False
        TextBox11.Visible = False
        TextBox4.Focus()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class
