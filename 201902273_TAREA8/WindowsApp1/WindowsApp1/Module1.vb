Imports System.Math
Module Module1
    Public numero As Byte = 0
    Public etapa(12) As Integer
    Public equipo(12) As String
    Public km(12) As Double
    Public tiempo(12) As Integer
    Public nacionalidad(12) As String
    Public penaliza(12) As Integer
    Public tiempotot(12) As Integer
    Public Const pen1 = 30
    Public Const pen2 = 40
    Public Const pen3 = 50
    Public Const rec1 = 15
    Public Const rec2 = 10
    Public I As Byte
    Sub limpiar_E()
        Form1.Comboequipo.SelectedIndex = -1
        Form1.ComboBox1.SelectedIndex = -1
        Form1.Textetapa.Clear()
        Form1.Textkm.Clear()
        Form1.Texttiempo.Clear()
        Form1.Textconsulta.Clear()
    End Sub

    Sub mostrar()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 11
            If (etapa(I) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(Str(etapa(I)), equipo(I), Str(km(I)), nacionalidad(I), Str(tiempo(I)), Str(penaliza(I)), Str(tiempotot(I)))
            Else
                Exit For

            End If
        Next I
    End Sub
    Sub penalización_recompensa()
        If (tiempo(numero) > 120) Then
            penaliza(numero) = pen1
            tiempotot(numero) = tiempo(numero) + penaliza(numero)
        ElseIf (tiempo(numero) > 140) Then
            penaliza(numero) = pen2
            tiempotot(numero) = tiempo(numero) + penaliza(numero)
        ElseIf (tiempo(numero) > 160) Then
            penaliza(numero) = pen3
            tiempotot(numero) = tiempo(numero) + penaliza(numero)
        ElseIf (tiempo(numero) < 85 And equipo(numero) = "Movistar") Then
            penaliza(numero) = rec1
            tiempotot(numero) = tiempo(numero) - penaliza(numero)
        ElseIf (tiempo(numero) < 85 And equipo(numero) = "Pro Team") Then
            penaliza(numero) = rec2
            tiempotot(numero) = tiempo(numero) - penaliza(numero)
        Else
            penaliza(numero) = 0
            tiempotot(numero) = tiempo(numero) - penaliza(numero)
        End If
    End Sub



End Module
