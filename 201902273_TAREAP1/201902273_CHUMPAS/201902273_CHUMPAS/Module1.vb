Imports System.Math
Module Module1
    Public cantA As Double, cantS As Double, CantL As Double
    Public costoA As Double, costoS As Double, costoL As Double
    Public totalmatA As Double, totalmatS As Double, totalmatL As Double
    Public valoryarda As Double, totalchumpas As Double
    Public precioA As Double, precioS As Double, precioL As Double, costotot As Double
    Public Const yardas_small = 2
    Public Const yardas_medium = 2.5
    Public Const yardas_large = 3
    Public Const MO_small = 65.5
    Public Const MO_medium = 85.99
    Public Const MO_large = 99.99
    Public Const algodon = 15
    Public Const seda = 23.99
    Public Const lona = 30.99
    Sub LIM()
        Form1.Radiosmall.Checked = False
        Form1.Radiomedium.Checked = False
        Form1.Radiolarge.Checked = False
        Form1.Checkalgodon.Checked = False
        Form1.Checkseda.Checked = False
        Form1.Checklona.Checked = False
        Form1.Textalgodon.Clear()
        Form1.Textseda.Clear()
        Form1.Textlona.Clear()
        Totales.Textcost1.Clear()
        Totales.Textcost2.Clear()
        Totales.Textcost3.Clear()
        Totales.Textvent1.Clear()
        Totales.Textvent2.Clear()
        Totales.Textvent3.Clear()
        Totales.Texttotal.Clear()
        Totales.Texttamaño.Clear()
        Totales.Texttotaless.Clear()
        costoA = 0
        costoS = 0
        costoL = 0
        precioA = 0
        precioS = 0
        precioL = 0
        totalchumpas = 0
    End Sub

    Function Totchumpas() As Double
        Totchumpas = cantA + CantL + cantS
        Return Totchumpas
    End Function

    Function MO() As Double
        If (Form1.Radiosmall.Checked) Then
            MO = MO_small
        ElseIf (Form1.Radiomedium.Checked) Then
            MO = MO_medium
        ElseIf (Form1.Radiolarge.Checked) Then
            MO = MO_large
        End If
        Return MO

    End Function

    Sub calculotot()

        costotot = costoA + costoL + costoS

    End Sub
    Sub Mostrar_resultados()
        Totales.Textcost1.Text = Str(Round(costoA, 2))
        Totales.Textcost2.Text = Str(Round(costoS, 2))
        Totales.Textcost3.Text = Str(Round(costoL, 2))
        Totales.Textvent1.Text = Str(Round(precioA, 2))
        Totales.Textvent2.Text = Str(Round(precioS, 2))
        Totales.Textvent3.Text = Str(Round(precioL, 2))
        Totales.Texttotal.Text = Str(Round(costotot, 2))
        Totales.Texttotaless.Text = Str(Round(totalchumpas, 2))
    End Sub
End Module
