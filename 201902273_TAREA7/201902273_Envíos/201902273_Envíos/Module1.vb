Imports System.Math
Module Module1
    Public numero As Byte = 0
    Public Nombre(10) As String
    Public paquete(10) As String
    Public tipo_envio(10) As String
    Public peso(10) As Double
    Public valor(10) As Double
    Public impuesto(10) As Double
    Public pagoparcial(10) As Double
    Public pagototal(10) As Double
    Public Const camion = 50
    Public Const moto = 15
    Public Const documentos = 0.015
    Public Const ropa = 0.06
    Public Const art_pedecedero = 0.055
    Public Const art_plasticos = 0.045
    Public Const lociones = 0.02

    Sub limpiar_entradas()
        Form1.Textnonbre.Clear()
        Form1.Textvalor.Clear()
        Form1.Combopaquete.SelectedIndex = -1
        Form1.ComboBox1.SelectedIndex = -1

    End Sub
    Sub limpiar_vec()
        Dim x As Byte
        For x = 0 To 9
            Nombre(x) = Nothing
            paquete(x) = Nothing
            tipo_envio(x) = Nothing
            peso(x) = Nothing
            valor(x) = Nothing
            impuesto(x) = Nothing
            pagoparcial(x) = Nothing
            pagototal(x) = Nothing
        Next x
        Form1.ListBox1.Items.Clear()
        Form1.ListBox2.Items.Clear()
        Form1.ListBox3.Items.Clear()
        Form1.ListBox4.Items.Clear()
        Form1.ListBox5.Items.Clear()
        Form1.ListBox6.Items.Clear()
        Form1.ListBox7.Items.Clear()
        Form1.ListBox8.Items.Clear()
        numero = 0
    End Sub
    Sub mostrar()
        Dim y As Byte
        For y = 0 To 9
            If pagototal(y) <> Nothing Then
                Form1.ListBox1.Items.Add(Nombre(y))
                Form1.ListBox2.Items.Add(paquete(y))
                Form1.ListBox3.Items.Add(Str(Round(peso(y), 2)))
                Form1.ListBox4.Items.Add("Q" + Str(Round(valor(y), 2)))
                Form1.ListBox5.Items.Add(tipo_envio(y))
                Form1.ListBox6.Items.Add("Q" + Str(Round(impuesto(y), 2)))
                Form1.ListBox7.Items.Add("Q" + Str(Round(pagoparcial(y), 2)))
                Form1.ListBox8.Items.Add("Q" + Str(Round(pagototal(y), 2)))
            Else
                Exit For
            End If
        Next y

    End Sub
End Module
