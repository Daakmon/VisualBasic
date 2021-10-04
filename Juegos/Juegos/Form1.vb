Public Class Form1
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LSB_ListaJuegos.SelectedIndexChanged

        LBL_Titulo.Text = LSB_ListaJuegos.SelectedItem
        PCB_Imagen.Image = IML_ListaImagenes.Images(LSB_ListaJuegos.SelectedIndex)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LSB_ListaJuegos.SelectedIndex = 0
    End Sub

    Private Sub PCB_Imagen_Click(sender As Object, e As EventArgs)

    End Sub
End Class
