Public Class Form1
    Dim n1, n2 As Integer

    Private Sub BTN_OtraSuma_Click(sender As Object, e As EventArgs) Handles BTN_OtraSuma.Click
        n1 = Int(Rnd() * 10) + 1
        n2 = Int(Rnd() * 10) + 1

        PCB_Mal.Visible = False
        PCB_Bien.Visible = False

        TXT_Num1.Text = n1
        TXT_Num2.Text = n2
        TXT_NumRes.Text = ""

    End Sub

    Private Sub BTN_Revisar_Click(sender As Object, e As EventArgs) Handles BTN_Revisar.Click
        Dim n3 As Integer
        n3 = Val(TXT_NumRes.Text)

        If (n1 + n2 = n3) Then
            TXT_Estado.Text = "Bien"
            PCB_Mal.Visible = False
            PCB_Bien.Visible = True
            BTN_OtraSuma.Focus()
        Else
            TXT_Estado.Text = "Mal"
            PCB_Bien.Visible = False
            PCB_Mal.Visible = True
            TXT_NumRes.Text = ""
            TXT_NumRes.Focus()
        End If

    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        n1 = Int(Rnd() * 10) + 1
        n2 = Int(Rnd() * 10) + 1

        TXT_Num1.Text = n1
        TXT_Num2.Text = n2
        TXT_NumRes.Text = ""

    End Sub

End Class
