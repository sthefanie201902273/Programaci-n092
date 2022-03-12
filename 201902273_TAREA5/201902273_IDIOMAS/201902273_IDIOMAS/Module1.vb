Imports System.Math
Module Module1

    Public datos(7, 10) As String
    Public contador As Byte = 0
    Public Const ingles = 150
    Public Const portugues = 80
    Public Const frances = 125
    Public Const desc_efectivo = 0.02
    Public Const desc_cheque = 0.015
    Public Const desc_dias = 0.05
    Sub limpiardatos()
        Form1.Textnombre.Clear()
        Form1.Textcarnet.Clear()
        Form1.Textfecha.Clear()
        Form1.Comboidiomas.SelectedIndex = -1
        Form1.Combopago.Text = ""
        Form1.Checksabado.Checked = False
        Form1.Checkviernes.Checked = False

    End Sub
    Sub limpiarMatriz()
        contador = 0
        Form1.DataGridView1.Rows.Clear()

    End Sub
    Sub parcial()
        Select Case (Form1.Comboidiomas.SelectedIndex)
            Case 0
                datos(contador, 7) = Str(Round(ingles * Val(datos(contador, 5)), 2))

            Case 1
                datos(contador, 7) = Str(Round(portugues * Val(datos(contador, 5)), 2))
            Case 2
                datos(contador, 7) = Str(Round(frances * Val(datos(contador, 5)), 2))
            Case Else
                MsgBox("Debe seleccionar un idioma")
                Exit Sub
                Form1.Comboidiomas.Focus()
        End Select
    End Sub
    Sub descuento1()
        Select Case (Form1.Combopago.SelectedIndex)

            Case 0
                datos(contador, 8) = Str(Round(Val(datos(contador, 7)) * desc_cheque, 2))

            Case 1
                datos(contador, 8) = Str(Round(Val(datos(contador, 7)) * desc_efectivo, 2))
            Case -1
                MsgBox("Debe seleccionar un tipo de pago")
                Exit Sub
                Form1.Combopago.Focus()
        End Select

    End Sub
    Sub Desc2()
        If (Form1.Checkviernes.Checked And Form1.Checksabado.Checked) Then
            datos(contador, 4) = "Viernes y Sábado"
            datos(contador, 9) = Str(Round(Val(datos(contador, 7)) * desc_dias, 2))

        ElseIf (form1.Checksabado.Checked) Then
            datos(contador, 4) = "Sábado"
            datos(contador, 9) = Str(Val(datos(contador, 7)) * 0)
        ElseIf (form1.Checkviernes.Checked) Then
            datos(contador, 4) = "Viernes"
            datos(contador, 9) = Str(Val(datos(contador, 7)) * 0)
        Else
            MsgBox("Debe seleccionar al menos un día para recibir el idioma")
            Exit Sub
            Form1.Checkviernes.Focus()
        End If


    End Sub
    Sub pagofinal()
        datos(contador, 10) = Str(Val(datos(contador, 7)) - (Val(datos(contador, 8)) + Val(datos(contador, 9))))
    End Sub
    Sub Mostrar()
        Form1.DataGridView1.Rows.Add(datos(contador, 0), datos(contador, 1), datos(contador, 2), datos(contador, 3), datos(contador, 4), datos(contador, 5), datos(contador, 6), datos(contador, 7), datos(contador, 8), datos(contador, 9), datos(contador, 10))
    End Sub
End Module
