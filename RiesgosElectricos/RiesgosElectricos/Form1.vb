Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BTN_Calcular.Click
        Dim mA As Integer
        mA = TXT_mA.Text
        Val(TXT_mA.Text)
        If mA = 0 Then
            LBL_Riesgo.Text = "NO HAY CORRIENTE"
            LBL_Descripcion.Text = "No existe peligro"
            PCB_Mostrar.Image = PCB_Pila.Image
        ElseIf mA < 3 Then
            LBL_Riesgo.Text = "PERCEPCIÓN"
            LBL_Descripcion.Text = "El paso de la corriente produce cosquilleo. No existe peligro"
            PCB_Mostrar.Image = PCB_Shock.Image
        ElseIf mA < 10 Then
            LBL_Riesgo.Text = "ELECTRIZACION"
            LBL_Descripcion.Text = "El paso de la corriente produce movimientos reflejos"
            PCB_Mostrar.Image = PCB_Tetanizacion.Image
        ElseIf mA < 25 Then
            LBL_Riesgo.Text = "TETANIZACIÓN"
            LBL_Descripcion.Text = "El paso de la corriente provoca contracciones musculares, agarrotamiento."
            PCB_Mostrar.Image = PCB_Cerebro.Image
        ElseIf mA < 60 Then
            LBL_Riesgo.Text = "PARO RESPIRATORIO"
            LBL_Descripcion.Text = "Si la corriente atraviesa el cerebro"
            PCB_Mostrar.Image = PCB_Pulmones.Image
        ElseIf mA < 75 Then
            LBL_Riesgo.Text = "ASFIXIA"
            LBL_Descripcion.Text = "Si la corriente atraviesa el tórax"
            PCB_Mostrar.Image = PCB_Corazon.Image
        ElseIf mA > 75 Then
            LBL_Riesgo.Text = "MUERTE"
            LBL_Descripcion.Text = "En pocos ms"
            PCB_Mostrar.Image = PCB_Muerte.Image
        End If
    End Sub

    Private Sub LBL_Riesgo_Click(sender As Object, e As EventArgs) Handles LBL_Riesgo.Click

    End Sub
End Class
