Public Class Form1
    Dim cantidadArticulos As Integer
    Private Sub BTN_Comprar_Click(sender As Object, e As EventArgs) Handles BTN_Comprar.Click
        If LSB_Catalogo.SelectedIndex <> -1 Then
            LSB_Cesta.Items.Add(LSB_Catalogo.SelectedItem)
            LSB_Catalogo.Items.Remove(LSB_Catalogo.SelectedItem)
            cantidadArticulos = LSB_Cesta.Items.Count
            LBL_CantidadArticulos.Text = cantidadArticulos & " Articulos"
        Else
            MsgBox("No tienes seleccionado ningun articulo para comprar")
        End If
    End Sub

    Private Sub BTN_Devolver_Click(sender As Object, e As EventArgs) Handles BTN_Devolver.Click
        If LSB_Cesta.SelectedIndex <> -1 Then
            LSB_Catalogo.Items.Add(LSB_Cesta.SelectedItem)
            LSB_Cesta.Items.Remove(LSB_Cesta.SelectedItem)
            cantidadArticulos = LSB_Cesta.Items.Count
            LBL_CantidadArticulos.Text = cantidadArticulos & " Articulos"
        Else
            MsgBox("No tienes seleccionado ningun articulo para devolver")
        End If
    End Sub

    Private Sub BTN_Deshacer_Click(sender As Object, e As EventArgs) Handles BTN_Deshacer.Click
        For index = 0 To LSB_Cesta.Items.Count - 1
            LSB_Catalogo.Items.Add(LSB_Cesta.Items.Item(index))
        Next

        LSB_Cesta.Items.Clear()
        LBL_CantidadArticulos.Text = 0 & " Articulos"
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_CantidadArticulos.Text = 0 & " Articulos"
        LSB_Catalogo.SelectedIndex = -1
        LSB_Cesta.SelectedIndex = -1
        cantidadArticulos = 0

    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub
End Class
