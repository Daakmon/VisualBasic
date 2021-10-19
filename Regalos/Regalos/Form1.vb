Public Class Form1
    Dim cantidad As Integer
    Dim anterior As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_Regalo1.Text = ""
        LBL_Regalo2.Text = ""

        LSB_Regalos.SelectedIndex = -1
        cantidad = 0
        anterior = -1
    End Sub

    Private Sub BTN_Elegir_Click(sender As Object, e As EventArgs) Handles BTN_Elegir.Click

        If (cantidad = 0) Then
            LBL_Regalo1.Text = LSB_Regalos.SelectedItem
            PCB_Imagen.Image = IML_Regalos.Images(LSB_Regalos.SelectedIndex)
            anterior = LSB_Regalos.SelectedIndex
            cantidad += 1
        ElseIf (cantidad = 1 And anterior <> LSB_Regalos.SelectedIndex) Then
            LBL_Regalo2.Text = LSB_Regalos.SelectedItem
            PCB_Imagen.Image = IML_Regalos.Images(LSB_Regalos.SelectedIndex)
            BTN_Elegir.Enabled = False
            MsgBox("Ya has seleccionado dos regalos")
        Else
            MsgBox("No puedes seleccionar dos regalos iguales")
        End If

    End Sub

    Private Sub Salir_Click(sender As Object, e As EventArgs) Handles Salir.Click
        End
    End Sub

    Private Sub BTN_Borrar_Click(sender As Object, e As EventArgs) Handles BTN_Borrar.Click
        cantidad = 0
        anterior = -1
        LBL_Regalo1.Text = ""
        LBL_Regalo2.Text = ""
        PCB_Imagen.Image = Nothing
        BTN_Elegir.Enabled = True
    End Sub

    Private Sub LSB_Regalos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSB_Regalos.SelectedIndexChanged
        PCB_Imagen.Image = IML_Regalos.Images(LSB_Regalos.SelectedIndex)
    End Sub
End Class
