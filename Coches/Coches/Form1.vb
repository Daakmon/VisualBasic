Public Class Form1
    Dim IVA As Double

    Dim precioBase As Double
    Dim extras As Double
    Dim extraRegalo As Double
    Dim ivaImporte As Double
    Dim totalImporte As Double

    Private Sub CMB_SeleccionCoche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMB_SeleccionCoche.SelectedIndexChanged
        PCB_Foto.Image = IML_Fotos.Images(CMB_SeleccionCoche.SelectedIndex)

        CHK_Ambientador.Checked = False
        CHK_Asientos.Checked = False
        CHK_Intermitentes.Checked = False
        CHK_Llantas.Checked = False
        CHK_Navegador.Checked = False

        CHK_Ambientador.Enabled = True
        CHK_Asientos.Enabled = True
        CHK_Intermitentes.Enabled = True
        CHK_Llantas.Enabled = True
        CHK_Navegador.Enabled = True

        TXT_IVA.Text = ""
        TXT_PrecioBase.Text = ""
        TXT_Extras.Text = ""
        TXT_ExtraRegalado.Text = ""
        TXT_Total.Text = ""

        LBL_Nombre.Font = New Font(LBL_Nombre.Font.Size, 22)

        'Se podria hacer un array con el precio base de los modelos y asignar el precio base con CMB_SeleccionCoche.SelectedIndex
        Select Case CMB_SeleccionCoche.SelectedIndex
            Case 0
                precioBase = 70000
                LBL_Nombre.Text = CMB_SeleccionCoche.SelectedItem
            Case 1
                precioBase = 100000
                LBL_Nombre.Text = CMB_SeleccionCoche.SelectedItem
            Case 2
                precioBase = 2400000
                LBL_Nombre.Font = New Font(LBL_Nombre.Font.Size, 14)
                LBL_Nombre.Text = CMB_SeleccionCoche.SelectedItem
        End Select

        TXT_PrecioBase.Text = precioBase & "€"

        totalImporte = precioBase * (1 + 21 / 100) & "€"
        TXT_Total.Text = totalImporte

        ivaImporte = precioBase * 21 / 100
        TXT_IVA.Text = ivaImporte & "€"
    End Sub

    Private Sub Checks(sender As Object, e As EventArgs) Handles CHK_Ambientador.CheckedChanged, CHK_Asientos.CheckedChanged, CHK_Intermitentes.CheckedChanged, CHK_Llantas.CheckedChanged, CHK_Navegador.CheckedChanged
        extras = 0
        extraRegalo = 0

        TXT_Extras.Text = "0"
        TXT_ExtraRegalado.Text = "0"

        Dim array As ArrayList = New ArrayList()

        'If CHK_Llantas.Checked Then
        'array.Add(300)
        'extras += 300
        'End If

        'If CHK_Ambientador.Checked Then
        'array.Add(10)
        'extras += 10
        'End If

        'If CHK_Navegador.Checked Then
        'array.Add(500)
        'extras += 500
        'End If

        'If CHK_Asientos.Checked Then
        'array.Add(800)
        'extras += 800
        'End If

        'If CHK_Intermitentes.Checked Then
        'array.Add(1000)
        'extras += 1000
        'End If

        'Comprueba todos los elementos del GroupBox donde cada elemento será el CheckBox y la propiedad Tag sera el valor
        For Each elemento As CheckBox In GRB_Complementos.Controls
            'If typeof elemento Is CheckBox Then 
            'Comprobaría el tipo de control es un CheckBox si hubiera que recorrer el formulario entero donde hay muxhos tipos de controles
            If elemento.Checked Then
                array.Add(elemento.Tag)
                extras += elemento.Tag
            End If
        Next

        If array.Count <> 0 Then

            extraRegalo = array(0)

            For index = 0 To array.Count - 1
                If (array(index) < extraRegalo) Then
                    extraRegalo = array(index)
                End If
            Next

            'For Each elemento As CheckBox In GRB_Complementos.Controls
            'If elemento.Checked And elemento.Tag < extraRegalo Then
            'extraRegalo = elemento.Tag
            'End If
            'Next
        End If

        TXT_Extras.Text = extras & "€"

        TXT_ExtraRegalado.Text = extraRegalo & "€"

        If extraRegalo = 0 Then
            LBL_Regalo.Text = ""
        Else
            LBL_Regalo.Text = "- " & extraRegalo & "€"
        End If

        totalImporte = (precioBase + extras - extraRegalo) * (1 + 21 / 100) & "€"
        ivaImporte = totalImporte * 21 / 100
        TXT_Total.Text = totalImporte & "€"
        TXT_IVA.Text = ivaImporte & "€"

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TXT_IVA.Text = ""
        TXT_PrecioBase.Text = ""
        TXT_Extras.Text = ""
        TXT_ExtraRegalado.Text = ""
        TXT_Total.Text = ""

        CHK_Ambientador.Checked = False
        CHK_Asientos.Checked = False
        CHK_Intermitentes.Checked = False
        CHK_Llantas.Checked = False
        CHK_Navegador.Checked = False

        If CMB_SeleccionCoche.SelectedIndex = -1 Then
            CHK_Ambientador.Enabled = False
            CHK_Asientos.Enabled = False
            CHK_Intermitentes.Enabled = False
            CHK_Llantas.Enabled = False
            CHK_Navegador.Enabled = False
        End If
    End Sub

    Private Sub BTN_Salir_Click(sender As Object, e As EventArgs) Handles BTN_Salir.Click
        End
    End Sub

End Class
