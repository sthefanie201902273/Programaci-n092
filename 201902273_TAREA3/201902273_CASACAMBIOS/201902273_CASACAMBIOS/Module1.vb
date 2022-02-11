Imports System.Math
Module Module1
    Public cantidadCompra As Double, cantidadVenta As Double, comisionC As Double
    Public comisionV As Double
    Public dolarc As Double, pesoc As Double, euroc As Double, colonc As Double
    Public dolarv As Double, pesov As Double, eurov As Double, colonv As Double
    Public Const precioDolar = 7.69
    Public Const precioPeso = 0.38
    Public Const precioEuro = 8.79
    Public Const precioColon = 0.012
    Public comisioncompra = 0.025
    Public comisionventa = 0.03

    Sub LIMPIAR_form1()
        FormResultados.Textcomision1.Clear()
        FormResultados.Textcomision2.Clear()
        FormResultados.Texttotal1.Clear()
        FormResultados.Texttotal2.Clear()
        Form1.Groupcompra.Visible = False
        Form1.Groupventa.Visible = False
        Form1.LabelQ.Visible = False
        Form1.LabelCant.Visible = False
        Form1.Checkcompra.Checked = False
        Form1.Checkventa.Checked = False
        Form1.Textcompra.Visible = False
        Form1.Textcompra.Clear()
        Form1.Textventa.Visible = False
        Form1.Textventa.Clear()
        Form1.compradolar.Checked = False
        Form1.comprapeso.Checked = False
        Form1.compraeuro.Checked = False
        Form1.compracolones.Checked = False
        Form1.ventadolar.Checked = False
        Form1.ventapeso.Checked = False
        Form1.ventaeuro.Checked = False
        Form1.ventacolones.Checked = False
        comisionC = 0
        comisionV = 0
        FormResultados.totalC = 0
        FormResultados.totalV = 0

    End Sub
    Sub LIMPIAR_form2()

        FormResultados.Hide()
        Form1.Show()
        LIMPIAR_form1()

    End Sub
    Sub Resultados()

        FormResultados.Textcomision1.Text = Str(Round(comisionC, 2))
        FormResultados.Textcomision2.Text = Str(Round(comisionV, 2))
        FormResultados.Texttotal1.Text = Str(Round(FormResultados.totalC, 2))
        FormResultados.Texttotal2.Text = Str(Round(FormResultados.totalV, 2))

    End Sub
End Module
