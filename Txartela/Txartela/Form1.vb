Public Class Form1
    Dim precioninio As Double
    Dim preciofamiliar As Double
    Dim preciojubilado As Double

    Private Sub Calcular(sender As Object, e As EventArgs) Handles CMB_Anio.SelectedIndexChanged, CHK_Discapacidad.CheckedChanged, CHK_FamilyBig.CheckedChanged, RDB_Familiar.CheckedChanged, RDB_Jubilado.CheckedChanged, RDB_Ninio.CheckedChanged
        precioninio = 2
        preciofamiliar = 5
        preciojubilado = 1

        If RDB_Ninio.Checked Then
            If CMB_Anio.SelectedIndex = 0 Then
                LBL_Precio.Text = precioninio & "€"
            End If
            If CMB_Anio.SelectedIndex = 1 Then
                precioninio = precioninio * 20
                LBL_Precio.Text = precioninio & "€"
            End If
            If CMB_Anio.SelectedIndex = 2 Then
                precioninio = precioninio * 100
                LBL_Precio.Text = precioninio & "€"
            End If

            If CHK_Discapacidad.Checked Then
                precioninio = precioninio * (1 - 20 / 100)
                LBL_Precio.Text = precioninio & "€"
            End If
            If CHK_FamilyBig.Checked Then
                precioninio = precioninio * (1 - 50 / 100)
                LBL_Precio.Text = precioninio & "€"
            End If
            If CHK_Discapacidad.Checked And CHK_FamilyBig.Checked Then
                precioninio = precioninio * (1 - 70 / 100)
                LBL_Precio.Text = precioninio & "€"
            End If
        End If

        If RDB_Familiar.Checked Then
            If CMB_Anio.SelectedIndex = 0 Then
                LBL_Precio.Text = preciofamiliar & "€"
            End If
            If CMB_Anio.SelectedIndex = 1 Then
                preciofamiliar = preciofamiliar * 20
                LBL_Precio.Text = preciofamiliar & "€"
            End If
            If CMB_Anio.SelectedIndex = 2 Then
                preciofamiliar = preciofamiliar * 100
                LBL_Precio.Text = preciofamiliar & "€"
            End If

            If CHK_Discapacidad.Checked Then
                preciofamiliar = preciofamiliar * (1 - 20 / 100)
                LBL_Precio.Text = preciofamiliar & "€"
            End If
            If CHK_FamilyBig.Checked Then
                preciofamiliar = preciofamiliar * (1 - 50 / 100)
                LBL_Precio.Text = preciofamiliar & "€"
            End If
            If CHK_Discapacidad.Checked And CHK_FamilyBig.Checked Then
                preciofamiliar = preciofamiliar * (1 - 70 / 100)
                LBL_Precio.Text = preciofamiliar & "€"
            End If
        End If

        If RDB_Jubilado.Checked Then
            If CMB_Anio.SelectedIndex = 0 Then
                LBL_Precio.Text = preciojubilado & "€"
            End If
            If CMB_Anio.SelectedIndex = 1 Then
                preciojubilado = preciojubilado * 20
                LBL_Precio.Text = preciojubilado & "€"
            End If
            If CMB_Anio.SelectedIndex = 2 Then
                preciojubilado = preciojubilado * 100
                LBL_Precio.Text = preciojubilado & "€"
            End If

            If CHK_Discapacidad.Checked Then
                preciojubilado = preciojubilado * (1 - 20 / 100)
                LBL_Precio.Text = preciojubilado & "€"
            End If
            If CHK_FamilyBig.Checked Then
                preciojubilado = preciojubilado * (1 - 50 / 100)
                LBL_Precio.Text = preciojubilado & "€"
            End If
            If CHK_Discapacidad.Checked And CHK_FamilyBig.Checked Then
                preciojubilado = Format(preciojubilado * (1 - 70 / 100), "0.00€")
                LBL_Precio.Text = preciojubilado & "€"
            End If
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        precioninio = 2
        preciofamiliar = 5
        preciojubilado = 1

        CMB_Anio.SelectedIndex = 0
        LBL_Precio.Text = ""
    End Sub

    Private Sub BTN_Des_Click(sender As Object, e As EventArgs) Handles BTN_Des.Click
        CHK_Discapacidad.Checked = False
        CHK_FamilyBig.Checked = False
        LBL_Precio.Text = ""
        RDB_Ninio.Checked = True
        CMB_Anio.SelectedIndex = 0

    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub

End Class
