Public Class Form1
    Dim turno As Integer
    Dim jugador As Integer

    Private Sub ClickImagenes(sender As Object, e As EventArgs) Handles PCB_1.Click, PCB_2.Click, PCB_3.Click, PCB_4.Click, PCB_5.Click, PCB_6.Click, PCB_7.Click, PCB_8.Click, PCB_9.Click
        turno += 1

        If turno Mod 2 <> 0 Then
            jugador = 1
            If sender.tag = 0 Then
                sender.Tag = 1
                sender.Image = IML_Imagenes.Images(1)
            End If
        Else
            jugador = 2
            If sender.tag = 0 Then
                sender.Tag = 2
                sender.Image = IML_Imagenes.Images(2)
            End If
        End If

        'Combinaciones Ganadoras
        'Horizontales
        If PCB_1.Tag = jugador And PCB_2.Tag = jugador And PCB_3.Tag = jugador Then
            Gandror()
        End If

        If PCB_4.Tag = jugador And PCB_5.Tag = jugador And PCB_6.Tag = jugador Then
            Gandror()
        End If
        If PCB_7.Tag = jugador And PCB_8.Tag = jugador And PCB_9.Tag = jugador Then
            Gandror()
        End If
        'Verticales
        If PCB_1.Tag = jugador And PCB_4.Tag = jugador And PCB_7.Tag = jugador Then
            Gandror()
        End If

        If PCB_2.Tag = jugador And PCB_5.Tag = jugador And PCB_8.Tag = jugador Then
            Gandror()
        End If

        If PCB_3.Tag = jugador And PCB_6.Tag = jugador And PCB_9.Tag = jugador Then
            Gandror()
        End If
        'Diagonales
        If PCB_1.Tag = jugador And PCB_5.Tag = jugador And PCB_9.Tag = jugador Then
            Gandror()
        End If

        If PCB_3.Tag = jugador And PCB_5.Tag = jugador And PCB_7.Tag = jugador Then
            Gandror()
        End If
    End Sub

    Private Sub Deshacer()
        turno = 0

        For Each elemento In Me.Controls
            If TypeOf elemento Is PictureBox Then
                elemento.Image = IML_Imagenes.Images(0)
                elemento.Tag = 0
            End If
        Next
    End Sub

    Private Sub Gandror()
        If jugador = 1 Then
            MsgBox("Ganador Jugador 1")
        Else
            MsgBox("Ganador Jugador 2")
        End If
        BTN_Deshacer.PerformClick() 'Despues de la ventana de ganador se autoclick en boton deshacer
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Deshacer()

        'PCB_1.Tag = 0
        'PCB_2.Tag = 0
        'PCB_3.Tag = 0
        'PCB_4.Tag = 0
        'PCB_5.Tag = 0
        'PCB_6.Tag = 0
        'PCB_7.Tag = 0
        'PCB_8.Tag = 0
        'PCB_9.Tag = 0

        'PCB_1.Image = IML_Imagenes.Images(0)
        'PCB_2.Image = IML_Imagenes.Images(0)
        'PCB_3.Image = IML_Imagenes.Images(0)
        'PCB_4.Image = IML_Imagenes.Images(0)
        'PCB_5.Image = IML_Imagenes.Images(0)
        'PCB_6.Image = IML_Imagenes.Images(0)
        'PCB_7.Image = IML_Imagenes.Images(0)
        'PCB_8.Image = IML_Imagenes.Images(0)
        'PCB_9.Image = IML_Imagenes.Images(0)
    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub

    Private Sub BTN_Deshacer_Click(sender As Object, e As EventArgs) Handles BTN_Deshacer.Click
        Deshacer()
    End Sub
End Class
