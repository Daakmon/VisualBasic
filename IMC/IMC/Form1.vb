Public Class Form1
    Private Sub BTN_Calcular_Click(sender As Object, e As EventArgs) Handles BTN_Calcular.Click
        Dim altura As Double
        Dim peso As Double
        Dim imc As Double

        altura = Val(TXT_Altura.Text)
        peso = Val(TXT_Peso.Text)

        imc = Format(peso / altura ^ 2, "0.00")

        LBL_Rango.Text = ""
        PCB_Anorexico.Visible = False
        PCB_Delgado.Visible = False
        PCB_Normal.Visible = False
        PCB_Sobrepeso.Visible = False
        PCB_Obesidad.Visible = False

        If (imc = 0) Then
            LBL_Rango.Text = ""
            LBL_Imc.Text = imc
        ElseIf (imc < 18.5) Then
            LBL_Rango.Text = "ANOREXICO"
            LBL_Imc.Text = imc
            PCB_Anorexico.Visible = True
        ElseIf (imc < 20) Then
            LBL_Rango.Text = "DELGADO"
            LBL_Imc.Text = imc
            PCB_Delgado.Visible = True
        ElseIf (imc < 25) Then
            LBL_Rango.Text = "NORMAL"
            LBL_Imc.Text = imc
            PCB_Normal.Visible = True
        ElseIf (imc < 30) Then
            LBL_Rango.Text = "SOBREPESO"
            LBL_Imc.Text = imc
            PCB_Sobrepeso.Visible = True
        ElseIf (imc > 30) Then
            LBL_Rango.Text = "OBESIDAD"
            LBL_Imc.Text = imc
            PCB_Obesidad.Visible = True
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LBL_Rango.Text = ""
        PCB_Anorexico.Visible = False
        PCB_Delgado.Visible = False
        PCB_Normal.Visible = False
        PCB_Sobrepeso.Visible = False
        PCB_Obesidad.Visible = False
    End Sub

End Class
