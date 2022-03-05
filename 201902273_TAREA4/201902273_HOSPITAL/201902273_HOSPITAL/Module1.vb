Imports System.Math
Module Module1
    Public numero_paciente As Byte = 0
    Public Nombre(6) As String
    Public Nit(6) As Integer
    Public Honorarios(6) As Double
    Public Habitacion(6) As String
    Public TipoPago(6) As String
    Public Dias(6) As Integer
    Public Servicio(6) As String
    Public Subtotal(6) As Double
    Public Descuento(6) As Double
    Public Total(6) As Double
    Public Const Priv_E = 350
    Public Const Priv_O = 550
    Public Const Priv_M = 450
    Public Const semipriv_E = 250
    Public Const semipriv_O = 400
    Public Const semipriv_M = 350
    Public Const noPriv_E = 150
    Public Const noPriv_O = 300
    Public Const noPriv_M = 250
    Public Const chequeefectivo = 0.15
    Public Const debito = 0.08
    Public Const creditorecargo = 0.05

    Sub limpiar_vec()
        numero_paciente = 0
        Form1.Listnombre.Items.Clear()
        Form1.Listnit.Items.Clear()
        Form1.Listhonorarios.Items.Clear()
        Form1.Listhabitacion.Items.Clear()
        Form1.Listdias.Items.Clear()
        Form1.Listdescuento.Items.Clear()
        Form1.Listservicio.Items.Clear()
        Form1.Listsubtotal.Items.Clear()
        Form1.Listtotal.Items.Clear()
        Form1.Listpago.Items.Clear()

    End Sub

    Sub limpiar_E()
        Form1.Combohabitación.SelectedIndex = -1
        Form1.Combopago.SelectedIndex = -1
        Form1.Textpaciente.Clear()
        Form1.Texthonorarios.Clear()
        Form1.Textnit.Clear()
        Form1.Checkcama.Checked = False
        Form1.Checkmaternidad.Checked = False
        Form1.Checkoperacion.Checked = False

    End Sub
    Function desc() As Double
        Select Case (Form1.Combopago.SelectedIndex)
            Case 0
                TipoPago(numero_paciente) = "Efectivo"
                desc = Subtotal(numero_paciente) * chequeefectivo * -1
            Case 1
                TipoPago(numero_paciente) = "Cheque"
                desc = Subtotal(numero_paciente) * chequeefectivo * -1
            Case 2
                TipoPago(numero_paciente) = "Tarjeta de débito"
                desc = Subtotal(numero_paciente) * debito * -1
            Case 3
                TipoPago(numero_paciente) = "Tarjeta de cédito"
                desc = Subtotal(numero_paciente) * creditorecargo
            Case Else
                MsgBox("Error no seleccionó pago")
                Form1.Combopago.Focus()
                Exit Function
        End Select
        Return desc
    End Function

    Function tot() As Double
        tot = Subtotal(numero_paciente) + Descuento(numero_paciente)
        Return tot
    End Function
    Sub privada()
        If (Form1.Checkcama.Checked Or Form1.Checkoperacion.Checked Or Form1.Checkmaternidad.Checked) Then
            If (Form1.Checkcama.Checked) Then
                Subtotal(numero_paciente) = Priv_E * Dias(numero_paciente)
                Servicio(numero_paciente) = "Encamamiento"
            End If
            If (Form1.Checkoperacion.Checked) Then
                Subtotal(numero_paciente) = Priv_O * Dias(numero_paciente)
                Servicio(numero_paciente) = "Operación"
            End If
            If (Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = Priv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Maternidad"
            End If
            If (Form1.Checkcama.Checked And Form1.Checkoperacion.Checked) Then
                Subtotal(numero_paciente) = Priv_E * Dias(numero_paciente) + Priv_O * Dias(numero_paciente)
                Servicio(numero_paciente) = "Ecamamiento y Operación"
            End If
            If (Form1.Checkcama.Checked And Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = Priv_E * Dias(numero_paciente) + Priv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Encamamiento y Maternidad"
            End If
            If (Form1.Checkoperacion.Checked And Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = Priv_O * Dias(numero_paciente) + Priv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Operación y Maternidad"
            End If
            If (Form1.Checkoperacion.Checked And Form1.Checkmaternidad.Checked And Form1.Checkcama.Checked) Then
                Subtotal(numero_paciente) = Priv_O * Dias(numero_paciente) + Priv_M * Dias(numero_paciente) + Priv_E * Dias(numero_paciente)
                Servicio(numero_paciente) = "Servicio completo"
            End If
        Else
            MsgBox("No seleccionó servicio")
            Exit Sub
        End If
    End Sub
    Sub semipriv()
        If (Form1.Checkcama.Checked Or Form1.Checkoperacion.Checked Or Form1.Checkmaternidad.Checked) Then
            If (Form1.Checkcama.Checked) Then
                Subtotal(numero_paciente) = semipriv_E * Dias(numero_paciente)
                Servicio(numero_paciente) = "Encamamiento"
            End If
            If (Form1.Checkoperacion.Checked) Then
                Subtotal(numero_paciente) = semipriv_O * Dias(numero_paciente)
                Servicio(numero_paciente) = "Operación"
            End If
            If (Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = semipriv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Maternidad"
            End If
            If (Form1.Checkcama.Checked And Form1.Checkoperacion.Checked) Then
                Subtotal(numero_paciente) = semipriv_E * Dias(numero_paciente) + semipriv_O * Dias(numero_paciente)
                Servicio(numero_paciente) = "Ecamamiento y Operación"
            End If
            If (Form1.Checkcama.Checked And Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = semipriv_E * Dias(numero_paciente) + semipriv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Encamamiento y Maternidad"
            End If
            If (Form1.Checkoperacion.Checked And Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = semipriv_O * Dias(numero_paciente) + semipriv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Operación y Maternidad"
            End If
            If (Form1.Checkoperacion.Checked And Form1.Checkmaternidad.Checked And Form1.Checkcama.Checked) Then
                Subtotal(numero_paciente) = semipriv_O * Dias(numero_paciente) + semipriv_M * Dias(numero_paciente) + semipriv_E * Dias(numero_paciente)
                Servicio(numero_paciente) = "3 servicios"
            End If
        Else
            MsgBox("No seleccionó servicio")
            Exit Sub
        End If
    End Sub
    Sub nopriv()
        If (Form1.Checkcama.Checked Or Form1.Checkoperacion.Checked Or Form1.Checkmaternidad.Checked) Then
            If (Form1.Checkcama.Checked) Then
                Subtotal(numero_paciente) = noPriv_E * Dias(numero_paciente)
                Servicio(numero_paciente) = "Encamamiento"
            End If
            If (Form1.Checkoperacion.Checked) Then
                Subtotal(numero_paciente) = noPriv_O * Dias(numero_paciente)
                Servicio(numero_paciente) = "Operación"
            End If
            If (Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = noPriv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Maternidad"
            End If
            If (Form1.Checkcama.Checked And Form1.Checkoperacion.Checked) Then
                Subtotal(numero_paciente) = noPriv_E * Dias(numero_paciente) + noPriv_O * Dias(numero_paciente)
                Servicio(numero_paciente) = "Ecamamiento y Operación"
            End If
            If (Form1.Checkcama.Checked And Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = noPriv_E * Dias(numero_paciente) + noPriv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Encamamiento y Maternidad"
            End If
            If (Form1.Checkoperacion.Checked And Form1.Checkmaternidad.Checked) Then
                Subtotal(numero_paciente) = noPriv_O * Dias(numero_paciente) + noPriv_M * Dias(numero_paciente)
                Servicio(numero_paciente) = "Operación y Maternidad"
            End If
            If (Form1.Checkoperacion.Checked And Form1.Checkmaternidad.Checked And Form1.Checkcama.Checked) Then
                Subtotal(numero_paciente) = noPriv_O * Dias(numero_paciente) + noPriv_M * Dias(numero_paciente) + noPriv_E * Dias(numero_paciente)
                Servicio(numero_paciente) = "3 servicios"
            End If
        Else
            MsgBox("No seleccionó servicio")
            Exit Sub
        End If
    End Sub
    Sub subtot()

        Select Case (Form1.Combohabitación.SelectedIndex)
            Case 0
                Habitacion(numero_paciente) = "Privada"
                privada()
            Case 1
                Habitacion(numero_paciente) = "Semiprivada"
                semipriv()
            Case 2
                Habitacion(numero_paciente) = " No privada"
                nopriv()
            Case Else
                MsgBox("No seleccionó habitación")
                Form1.Combohabitación.Focus()
                Exit Sub
        End Select
    End Sub
    Sub mostrarresultados()
        Form1.Listnombre.Items.Add(Nombre(numero_paciente))
        Form1.Listnit.Items.Add(Str(Nit(numero_paciente)))
        Form1.Listhonorarios.Items.Add("Q" + Str(Round(Honorarios(numero_paciente), 2)))
        Form1.Listdias.Items.Add(Str(Dias(numero_paciente)))
        Form1.Listpago.Items.Add(TipoPago(numero_paciente))
        Form1.Listhabitacion.Items.Add(Habitacion(numero_paciente))
        Form1.Listservicio.Items.Add(Servicio(numero_paciente))
        Form1.Listsubtotal.Items.Add("Q" + Str(Round(Subtotal(numero_paciente), 2)))
        Form1.Listdescuento.Items.Add("Q" + Str(Round(Descuento(numero_paciente), 2)))
        Form1.Listtotal.Items.Add("Q" + Str(Round(Total(numero_paciente), 2)))

    End Sub
End Module
