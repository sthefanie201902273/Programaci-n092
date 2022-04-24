Module Module1
    Public cine(7, 9) As String
    Public numero As Byte = 0
    Public I As Byte
    Public Const normal = 44
    Public Const D = 62
    Public Const DDX = 104
    Sub limpiarE()

        Form1.Textnit.Clear()
        Form1.Textpeli.Clear()
        Form1.Textnormal.Clear()
        Form1.Text3d.Clear()
        Form1.Text4dx.Clear()
        Form1.CheckBox1.Checked = False
        Form1.CheckBox2.Checked = False
        Form1.CheckBox3.Checked = False
        Form1.Textnit.Focus()
    End Sub
    Sub limpiarMatriz()
        Form1.DataGridView1.Rows.Clear()
        numero = 0
        I = 0

        While (I <= 6)
            cine(I, 0) = Nothing
            cine(I, 1) = Nothing
            cine(I, 2) = Nothing
            cine(I, 3) = Nothing
            cine(I, 4) = Nothing
            cine(I, 5) = Nothing
            cine(I, 6) = Nothing
            cine(I, 7) = Nothing
            cine(I, 8) = Nothing
            I = I + 1
        End While
    End Sub
    Sub Mostrar_Matriz()
        Form1.DataGridView1.Rows.Clear()
        I = 0
        While (I <= 6)
            If (cine(I, 0) <> Nothing) Then
                Form1.DataGridView1.Rows.Add(cine(I, 0), cine(I, 1), cine(I, 2), cine(I, 3), cine(I, 4), cine(I, 5), cine(I, 6), cine(I, 7), cine(I, 8))
            Else
                Exit While
            End If
            I = I + 1
        End While
    End Sub
    Sub buscar()
        Dim X As Byte
        For X = 0 To 6

            If (cine(I, 0) <> Nothing) Then
                If (Val(cine(I, 0)) = Val(Form1.Textconsulta.Text)) Then
                    MsgBox("registro encontrado")
                    Exit For
                End If
            Else
                Exit For
            End If
        Next X
        If (X = 7) Then
            MsgBox("NIT no encontrado")
        Else
            MsgBox("Registro Encontrado exitosamente")
            Form1.Textnit.Text = cine(I, 0)
            Form1.Textpeli.Text = cine(I, 1)
            Form1.Textnormal.Text = cine(I, 2)
            Form1.Text3d.Text = cine(I, 3)
            Form1.Text4dx.Text = cine(I, 4)
            If (cine(I, 2) > 0) Then
                Form1.CheckBox1.Checked = True
            End If
            If (cine(I, 3) > 0) Then
                Form1.CheckBox2.Checked = True
            End If
            If (cine(I, 4) > 0) Then
                Form1.CheckBox3.Checked = True
            End If

            Form1.DataGridView1.Rows.Clear()
            Form1.DataGridView1.Rows.Add(cine(I, 0), cine(I, 1), cine(I, 2), cine(I, 3), cine(I, 4), cine(I, 5), cine(I, 6), cine(I, 7), cine(I, 8))

            numero = I
        End If

    End Sub
End Module
