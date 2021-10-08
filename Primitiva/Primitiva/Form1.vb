Public Class Primitiva
    Dim rndm, cont As Integer

    Private Sub Primitiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chkControl As CheckBox

        For Each chkControl In GRB_Numeros.Controls
            AddHandler chkControl.CheckedChanged, AddressOf seleccionNumeros
        Next

        'LBL_ContAciertos.Text = ""
        BTN_Sorteo.Enabled = False
    End Sub

    Private Sub seleccionNumeros(sender As Object, e As EventArgs)
        Dim seleccion As Integer
        seleccion = 0

        For Each ck In GRB_Numeros.Controls
            If ck.Checked Then
                seleccion += 1
            End If
        Next

        If seleccion = 6 Then
            BTN_Sorteo.Enabled = True
        ElseIf seleccion > 6 Then
            sender.Checked = False
            MsgBox("Ya se han seleccionado 6 numeros")
        End If
    End Sub

    Private Sub Random()
        Randomize()

        rndm = Int(Rnd() * 49) + 1
    End Sub

    Private Sub BTN_Sorteo_Click(sender As Object, e As EventArgs) Handles BTN_Sorteo.Click
        cont = 0

        For Each numero In Me.Controls
            If TypeOf numero Is TextBox Then
                Random()
                numero.Text = rndm
            End If
        Next

        For Each ck In GRB_Numeros.Controls
            For Each numero In Me.Controls
                If TypeOf numero Is TextBox Then
                    If Val(numero.Text) = Val(ck.Text) And ck.Checked Then 'El Val es opcional, sean string o integer funcionaran al ser iguales
                        cont += 1
                        LBL_ContAciertos.Text = cont
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub BTN_Deshacer_Click(sender As Object, e As EventArgs) Handles BTN_Deshacer.Click
        cont = 0

        For Each numero In Me.Controls
            If TypeOf numero Is TextBox Then
                numero.Text = ""
            End If
        Next

        For Each ck In GRB_Numeros.Controls
            ck.Checked = False
        Next

        BTN_Sorteo.Enabled = False
        LBL_ContAciertos.Text = ""
    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub

End Class
