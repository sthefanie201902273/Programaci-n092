Imports System.Math
Module Module1
    Public numero As Byte = 0
    Public Nombre(6) As String
    Public Producto(6) As String
    Public canti(6) As Integer
    Public cantd(6) As Integer
    Public descuento(6) As Double
    Public cantdepacks(6) As Integer
    Public cantsobrante(6) As Integer
    Public valordepack(6) As Double
    Public ingresoporpack(6) As Double
    Public ingresopacks(6) As Double
    Public ingresoporproducto(6) As Double
    Public total(6) As Double
    Public Const jugos = 8.5
    Public Const frituras = 11.2
    Public Const galletas = 4.25
    Public Const baterias = 15
    Public Const desc1 = 0.1
    Public Const desc2 = 0.05
    Public Const desc3 = 0.03
    Sub numerodepacks()
        cantdepacks(numero) = canti(numero) / cantd(numero)
    End Sub
    Sub numerosobrante()
        cantsobrante(numero) = canti(numero) Mod cantd(numero)
    End Sub
    Sub valorpack()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                valordepack(numero) = Round((cantd(numero) * jugos), 2)

            Case 1
                valordepack(numero) = Round((cantd(numero) * frituras), 2)
            Case 2
                valordepack(numero) = Round((cantd(numero) * galletas), 2)
            Case 3
                valordepack(numero) = Round((cantd(numero) * baterias), 2)
        End Select

    End Sub
    Sub productoo()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                Producto(numero) = "jugos"

            Case 1
                Producto(numero) = "frituras"
            Case 2
                Producto(numero) = "galletas"
            Case 3
                Producto(numero) = "baterias"
        End Select
    End Sub
    Sub descuentoo()
        If (cantd(numero) >= 3 And cantd(numero) < 5) Then
            descuento(numero) = Round((valordepack(numero) * desc3), 2)
        ElseIf (cantd(numero) >= 5 And cantd(numero) < 10) Then
            descuento(numero) = Round((valordepack(numero) * desc2), 2)
        ElseIf (cantd(numero) >= 10) Then
            descuento(numero) = Round((valordepack(numero) * desc1), 2)
        Else
            descuento(numero) = 0
        End If
    End Sub
    Sub ingresopack_unidad()
        ingresoporpack(numero) = Round((valordepack(numero) - descuento(numero)), 2)
    End Sub
    Sub ingresopackss()
        ingresopacks(numero) = Round(((valordepack(numero) - descuento(numero)) * cantdepacks(numero)), 2)
    End Sub
    Sub ingresosobrante()
        Select Case (Form1.ComboBox1.SelectedIndex)
            Case 0
                ingresoporproducto(numero) = Round((cantsobrante(numero) * jugos), 2)
            Case 1
                ingresoporproducto(numero) = Round((cantsobrante(numero) * frituras), 2)
            Case 2
                ingresoporproducto(numero) = Round((cantsobrante(numero) * galletas), 2)
            Case 3
                ingresoporproducto(numero) = Round((cantsobrante(numero) * baterias), 2)
        End Select

    End Sub
    Sub totall()
        total(numero) = Round((ingresopacks(numero) + ingresoporproducto(numero)), 2)

    End Sub
    Sub mostrar()
        Form1.DataGridView1.Rows.Add(Nombre(numero), Producto(numero), Str(canti(numero)), Str(cantd(numero)), Str(cantdepacks(numero)), Str(cantsobrante(numero)), Str(ingresoporpack(numero)), Str(ingresopacks(numero)), Str(ingresoporproducto(numero)), Str(total(numero)))
    End Sub
End Module
