Imports System.Math
Module Module1
    Public numero As Byte = 0
    Public carro(7) As String
    Public kmi(7) As Double
    Public kmf(7) As Double
    Public placa(7) As Integer
    Public cobrobase(7) As Double
    Public pagofinal(7) As Double
    Public cobrokm(7) As Double
    Public kilometros(7) As Double
    Public Const tipo1 = 500
    Public Const tipo2 = 400
    Public Const tipo3 = 300
    Public Const tipo4 = 200
    Public Const cobrokm1 = 3
    Public Const cobrokm2 = 4
    Public Const cobrokm3 = 5

    Public I As Byte
    Sub limpiarvec()
        Form1.DataGridView1.Rows.Clear()
        numero = 0
        For I = 0 To 6
            carro(I) = Nothing
            kmi(I) = Nothing
            kmf(I) = Nothing
            placa(I) = Nothing
            cobrobase(I) = Nothing
            pagofinal(I) = Nothing
            cobrokm(I) = Nothing
            kilometros(I) = Nothing
        Next I
    End Sub
    Sub mostrar()
        Form1.DataGridView1.Rows.Clear()
        For I = 0 To 6
            If placa(I) <> Nothing Then
                Form1.DataGridView1.Rows.Add(Str(placa(I)), carro(I), Str(cobrobase(I)), Str(kmi(I)), Str(kmf(I)),Str(cobrokm(I)),Str(pagofinal(I)))

            Else
                Exit For
            End If
        Next I


    End Sub
    Function base() As Double
        Select Case (Form1.ComboBox1.SelectedIndex)

            Case 0
                carro(numero) = Form1.ComboBox1.Text
                base = tipo1
            Case 1
                carro(numero) = Form1.ComboBox1.Text
                base = tipo2
            Case 2
                carro(numero) = Form1.ComboBox1.Text
                base = tipo3
            Case 3
                carro(numero) = Form1.ComboBox1.Text
                base = tipo4
            Case Else
                MsgBox("Error no seleccionó ningún tipo")
                Form1.ComboBox1.Focus()
                Exit Function
        End Select
        Return base
    End Function

End Module
