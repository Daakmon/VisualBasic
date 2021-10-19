Public Class FRM_Factura
    Dim cantidad As Integer
    Dim precio As Double
    Dim base As Double
    Dim descantidadimporte As Double
    Dim desclienteprioritarioimporte As Double
    Dim desivaimporte As Double
    Dim totalimporte As Double

    Const IVA As Integer = 21

    Private Sub Calcular(sender As Object, e As EventArgs) Handles TXT_Cantidad.TextChanged, TXT_Precio.TextChanged, CHK_ClientePrioritario.CheckedChanged, BTN_Calcular.Click
        precio = Val(TXT_Precio.Text)

        base = cantidad * precio
        TXT_Importe.Text = base

        If cantidad < 10 Then
            TXT_DesCantidadPorc.Text = ""
        ElseIf cantidad < 100 Then
            descantidadimporte = base * (1 - 5 / 100)
            TXT_DesCantidadPorc.Text = "5%"
        ElseIf cantidad < 1000 Then
            descantidadimporte = base * (1 - 15 / 100)
            TXT_DesCantidadPorc.Text = "15%"
        ElseIf cantidad < 10000 Then
            descantidadimporte = base * (1 - 30 / 100)
            TXT_DesCantidadPorc.Text = "30%"
        ElseIf cantidad > 10000 Then
            descantidadimporte = base * (1 - 50 / 100)
            TXT_DesCantidadPorc.Text = "50%"
            MsgBox("Llega")
        End If

        TXT_DesCantidadImporte.Text = descantidadimporte

        If CHK_ClientePrioritario.Checked Then
            desclienteprioritarioimporte = descantidadimporte * (1 - 10 / 100)
            TXT_DesClientePrioritarioImporte.Text = desclienteprioritarioimporte

            desivaimporte = desclienteprioritarioimporte * (1 - 21 / 100)
            TXT_DesIVAImporte.Text = desivaimporte
        Else
            TXT_DesClientePrioritarioImporte.Text = ""
            totalimporte = descantidadimporte * (1 - 21 / 100)
            TXT_DesIVAImporte.Text = totalimporte
        End If

        TXT_TotalImporte.Text = totalimporte
    End Sub

    Private Sub TXT_TotalImporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cantidad = Val(TXT_Cantidad.Text)
        TXT_Precio.Text = "2"
        precio = Val(TXT_Precio.Text)

        TXT_DesIVAPorc.Text = IVA
    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub

End Class
