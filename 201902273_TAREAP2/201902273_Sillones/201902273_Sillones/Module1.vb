Imports System.Math
Module Module1
    Public numero As Byte = 0
    Public no_venta(8) As Integer
    Public tamaño(8) As String
    Public tela(8) As String
    Public cantidad(8) As Integer
    Public preciocosto(8) As Double
    Public precioventa(8) As Double
    Public precioventa_unidad(8) As Double
    Public material(8) As Double
    Public mano_obra(8) As Double
    Public Yarda(8) As Double
    Public Const Mo_sofa = 250.99
    Public Const Mo_individual = 150.99
    Public Const Mo_doble = 200.99
    Public Const cuero = 75
    Public Const cuerina = 45.99
    Public Const venta = 0.65

    Sub tamaño_sillon()
        Select Case (Form1.Combotamaño.SelectedIndex)
            Case 0
                tamaño(numero) = Form1.Combotamaño.Text
                mano_obra(numero) = Round((cantidad(numero) * Mo_sofa), 2)
                Yarda(numero) = 8
            Case 1
                tamaño(numero) = Form1.Combotamaño.Text
                mano_obra(numero) = Round((cantidad(numero) * Mo_individual), 2)
                Yarda(numero) = 3.5
            Case 2
                tamaño(numero) = Form1.Combotamaño.Text
                mano_obra(numero) = Round((cantidad(numero) * Mo_doble), 2)
                Yarda(numero) = 6

        End Select
    End Sub

    Sub telas()
        If (Form1.Radiocuero.Checked) Then
            tela(numero) = "Cuero"
            material(numero) = Round((cantidad(numero) * Yarda(numero) * cuero), 2)
        ElseIf (Form1.Radiocuerina.Checked) Then
            tela(numero) = "Cuerina"
            material(numero) = Round((cantidad(numero) * Yarda(numero) * cuerina), 2)

        End If
    End Sub
    Function preciocost() As Double
        preciocost = mano_obra(numero) + material(numero)
        Return preciocost
    End Function
    Function preciovent() As Double
        preciovent = Round(((preciocosto(numero) * venta) + preciocosto(numero)), 2)
        Return preciovent
    End Function
    Function preciovent_unidad() As Double
        preciovent_unidad = Round((precioventa(numero) / cantidad(numero)), 2)

        Return preciovent_unidad
    End Function
    Sub mostrar()
        Form1.DataGridView1.Rows.Add(Str(no_venta(numero)), tamaño(numero), tela(numero), Str(cantidad(numero)), Str(mano_obra(numero)), Str(material(numero)), Str(preciocosto(numero)), Str(precioventa(numero)), Str(precioventa_unidad(numero)))
    End Sub
    Sub limpiar_vectores()
        Dim x As Byte
        For x = 0 To 7
            no_venta(x) = Nothing
            tamaño(x) = Nothing
            tela(x) = Nothing
            cantidad(x) = Nothing
            material(x) = Nothing
            mano_obra(x) = Nothing
            preciocosto(x) = Nothing
            precioventa(x) = Nothing
            precioventa_unidad(x) = Nothing
        Next x

        numero = 0
    End Sub
    Sub limpiar_entradas()
        Form1.Radiocuero.Checked = False
        Form1.Radiocuerina.Checked = False
        Form1.Textcant.Clear()
        Form1.Textventa.Clear()
        Form1.Combotamaño.SelectedIndex = -1

    End Sub
End Module
