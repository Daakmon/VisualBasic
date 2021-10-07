Public Class Primitiva
    Private Sub Primitiva_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim chkControl As CheckBox

        For Each chkControl In GRB_Numeros.Controls
            AddHandler chkControl.CheckedChanged, AddressOf seleccionNumeros
        Next
    End Sub

    Private Sub seleccionNumeros(sender As Object, e As EventArgs)

    End Sub

End Class
