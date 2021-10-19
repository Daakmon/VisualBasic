Public Class Form1
    Dim imagenespacio1 As Integer = 0
    Const IMAGENESGALERIA As Integer = 4


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        TMR_3s.Start()
        Galeria(imagenespacio1)

        TXT_ImporteExtras.Text = ""
        TXT_ImporteExtras.Text = ""

    End Sub
    Private Sub TMR_3s_Tick(sender As Object, e As EventArgs) Handles TMR_3s.Tick
        Dim n As Integer

        n = Int(Rnd() * 11)
        PCB_Imagen.Image = IML_Galeria.Images(n)
    End Sub

    Private Sub ReiniciarReloj(sender As Object, e As EventArgs) Handles CHK_Extra1.CheckedChanged, CHK_Extra2.CheckedChanged, CHK_Extra3.CheckedChanged
        TMR_3s.Stop()
        TMR_3s.Start()

    End Sub

    Private Sub BTN_Reservar_Click(sender As Object, e As EventArgs) Handles BTN_Reservar.Click
        LSB_Fechas.Items.Add(DTP_SeleccionFecha.Value)


    End Sub

    Private Sub PCB_1_Click(sender As Object, e As EventArgs) Handles PCB_1.Click, PCB_2.Click, PCB_3.Click, PCB_4.Click
        PCB_Imagen.Image = sender.Image
    End Sub

    Private Sub Galeria(x As Integer)
        PCB_1.Image = IML_Galeria.Images(x)
        PCB_2.Image = IML_Galeria.Images(x + 1)
        PCB_3.Image = IML_Galeria.Images(x + 2)
        PCB_4.Image = IML_Galeria.Images(x + 3)
    End Sub

    Private Sub BotonIzquierda(sender As Object, e As EventArgs) Handles BTN_Izquierda.Click
        BTN_Derecha.Enabled = True

        If imagenespacio1 > 0 Then
            imagenespacio1 -= 1
            Galeria(imagenespacio1)
        Else
            BTN_Izquierda.Enabled = False
        End If
    End Sub

    Private Sub BotonDerecha(sender As Object, e As EventArgs) Handles BTN_Derecha.Click
        BTN_Izquierda.Enabled = True

        If imagenespacio1 < IML_Galeria.Images.Count - IMAGENESGALERIA Then
            imagenespacio1 += 1
            Galeria(imagenespacio1)
        Else
            BTN_Derecha.Enabled = False
        End If
    End Sub

    Private Sub Factura(sender As Object, e As EventArgs) Handles CHK_Extra1.CheckedChanged, CHK_Extra2.CheckedChanged, CHK_Extra3.CheckedChanged
        Dim extras As Integer

        TXT_ImporteExtras.Text = ""
        TXT_Total.Text = ""
        TXT_ImporteEstancia.Text = 300

        'Format(300, "0.00€")
        For Each elemento As CheckBox In GRB_Extras.Controls
            If elemento.Checked Then
                extras += elemento.Tag
            End If
        Next

        TXT_ImporteExtras.Text = extras
        TXT_Total.Text = 300 + extras
    End Sub
End Class
