<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PCB_Imagen = New System.Windows.Forms.PictureBox()
        Me.GRB_Extras = New System.Windows.Forms.GroupBox()
        Me.CHK_Extra3 = New System.Windows.Forms.CheckBox()
        Me.CHK_Extra2 = New System.Windows.Forms.CheckBox()
        Me.CHK_Extra1 = New System.Windows.Forms.CheckBox()
        Me.IML_Galeria = New System.Windows.Forms.ImageList(Me.components)
        Me.TMR_3s = New System.Windows.Forms.Timer(Me.components)
        Me.LBL_1 = New System.Windows.Forms.Label()
        Me.LBL_2 = New System.Windows.Forms.Label()
        Me.LBL_3 = New System.Windows.Forms.Label()
        Me.LSB_Fechas = New System.Windows.Forms.ListBox()
        Me.DTP_SeleccionFecha = New System.Windows.Forms.DateTimePicker()
        Me.BTN_Reservar = New System.Windows.Forms.Button()
        Me.TXT_ImporteEstancia = New System.Windows.Forms.TextBox()
        Me.TXT_ImporteExtras = New System.Windows.Forms.TextBox()
        Me.TXT_Total = New System.Windows.Forms.TextBox()
        Me.LBL_4 = New System.Windows.Forms.Label()
        Me.LBL_5 = New System.Windows.Forms.Label()
        Me.LBL_6 = New System.Windows.Forms.Label()
        Me.PCB_1 = New System.Windows.Forms.PictureBox()
        Me.PCB_2 = New System.Windows.Forms.PictureBox()
        Me.PCB_3 = New System.Windows.Forms.PictureBox()
        Me.PCB_4 = New System.Windows.Forms.PictureBox()
        Me.BTN_Izquierda = New System.Windows.Forms.Button()
        Me.BTN_Derecha = New System.Windows.Forms.Button()
        CType(Me.PCB_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRB_Extras.SuspendLayout()
        CType(Me.PCB_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PCB_Imagen
        '
        Me.PCB_Imagen.Location = New System.Drawing.Point(12, 12)
        Me.PCB_Imagen.Name = "PCB_Imagen"
        Me.PCB_Imagen.Size = New System.Drawing.Size(258, 233)
        Me.PCB_Imagen.TabIndex = 0
        Me.PCB_Imagen.TabStop = False
        '
        'GRB_Extras
        '
        Me.GRB_Extras.Controls.Add(Me.CHK_Extra3)
        Me.GRB_Extras.Controls.Add(Me.CHK_Extra2)
        Me.GRB_Extras.Controls.Add(Me.CHK_Extra1)
        Me.GRB_Extras.Location = New System.Drawing.Point(301, 12)
        Me.GRB_Extras.Name = "GRB_Extras"
        Me.GRB_Extras.Size = New System.Drawing.Size(240, 121)
        Me.GRB_Extras.TabIndex = 1
        Me.GRB_Extras.TabStop = False
        Me.GRB_Extras.Text = "Extras"
        '
        'CHK_Extra3
        '
        Me.CHK_Extra3.AutoSize = True
        Me.CHK_Extra3.Location = New System.Drawing.Point(17, 93)
        Me.CHK_Extra3.Name = "CHK_Extra3"
        Me.CHK_Extra3.Size = New System.Drawing.Size(149, 17)
        Me.CHK_Extra3.TabIndex = 2
        Me.CHK_Extra3.Tag = "40"
        Me.CHK_Extra3.Text = " Servicio guarderia por dia"
        Me.CHK_Extra3.UseVisualStyleBackColor = True
        '
        'CHK_Extra2
        '
        Me.CHK_Extra2.AutoSize = True
        Me.CHK_Extra2.Location = New System.Drawing.Point(17, 58)
        Me.CHK_Extra2.Name = "CHK_Extra2"
        Me.CHK_Extra2.Size = New System.Drawing.Size(126, 17)
        Me.CHK_Extra2.TabIndex = 1
        Me.CHK_Extra2.Tag = "150"
        Me.CHK_Extra2.Text = " Pack visitas guiadas"
        Me.CHK_Extra2.UseVisualStyleBackColor = True
        '
        'CHK_Extra1
        '
        Me.CHK_Extra1.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.CHK_Extra1.AutoSize = True
        Me.CHK_Extra1.Location = New System.Drawing.Point(17, 24)
        Me.CHK_Extra1.Name = "CHK_Extra1"
        Me.CHK_Extra1.Size = New System.Drawing.Size(138, 17)
        Me.CHK_Extra1.TabIndex = 0
        Me.CHK_Extra1.Tag = "25"
        Me.CHK_Extra1.Text = "Translado al aeropuerto"
        Me.CHK_Extra1.UseVisualStyleBackColor = True
        '
        'IML_Galeria
        '
        Me.IML_Galeria.ImageStream = CType(resources.GetObject("IML_Galeria.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_Galeria.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_Galeria.Images.SetKeyName(0, "1.jpg")
        Me.IML_Galeria.Images.SetKeyName(1, "2.jpg")
        Me.IML_Galeria.Images.SetKeyName(2, "3.jpg")
        Me.IML_Galeria.Images.SetKeyName(3, "4.jpg")
        Me.IML_Galeria.Images.SetKeyName(4, "5.jpg")
        Me.IML_Galeria.Images.SetKeyName(5, "6.jpg")
        Me.IML_Galeria.Images.SetKeyName(6, "7.jpg")
        Me.IML_Galeria.Images.SetKeyName(7, "8.jpg")
        Me.IML_Galeria.Images.SetKeyName(8, "9.jpg")
        Me.IML_Galeria.Images.SetKeyName(9, "10.jpg")
        Me.IML_Galeria.Images.SetKeyName(10, "11.jpg")
        '
        'TMR_3s
        '
        Me.TMR_3s.Interval = 8000
        '
        'LBL_1
        '
        Me.LBL_1.AutoSize = True
        Me.LBL_1.Location = New System.Drawing.Point(298, 153)
        Me.LBL_1.Name = "LBL_1"
        Me.LBL_1.Size = New System.Drawing.Size(100, 13)
        Me.LBL_1.TabIndex = 2
        Me.LBL_1.Text = "Importe de estancia"
        '
        'LBL_2
        '
        Me.LBL_2.AutoSize = True
        Me.LBL_2.Location = New System.Drawing.Point(298, 191)
        Me.LBL_2.Name = "LBL_2"
        Me.LBL_2.Size = New System.Drawing.Size(91, 13)
        Me.LBL_2.TabIndex = 3
        Me.LBL_2.Text = " Importe de extras"
        '
        'LBL_3
        '
        Me.LBL_3.AutoSize = True
        Me.LBL_3.Location = New System.Drawing.Point(298, 232)
        Me.LBL_3.Name = "LBL_3"
        Me.LBL_3.Size = New System.Drawing.Size(34, 13)
        Me.LBL_3.TabIndex = 4
        Me.LBL_3.Text = " Total"
        '
        'LSB_Fechas
        '
        Me.LSB_Fechas.FormattingEnabled = True
        Me.LSB_Fechas.Location = New System.Drawing.Point(559, 102)
        Me.LSB_Fechas.Name = "LSB_Fechas"
        Me.LSB_Fechas.Size = New System.Drawing.Size(212, 277)
        Me.LSB_Fechas.TabIndex = 5
        '
        'DTP_SeleccionFecha
        '
        Me.DTP_SeleccionFecha.Location = New System.Drawing.Point(559, 17)
        Me.DTP_SeleccionFecha.Name = "DTP_SeleccionFecha"
        Me.DTP_SeleccionFecha.Size = New System.Drawing.Size(212, 20)
        Me.DTP_SeleccionFecha.TabIndex = 6
        '
        'BTN_Reservar
        '
        Me.BTN_Reservar.Location = New System.Drawing.Point(559, 54)
        Me.BTN_Reservar.Name = "BTN_Reservar"
        Me.BTN_Reservar.Size = New System.Drawing.Size(212, 33)
        Me.BTN_Reservar.TabIndex = 7
        Me.BTN_Reservar.Text = "Reservar"
        Me.BTN_Reservar.UseVisualStyleBackColor = True
        '
        'TXT_ImporteEstancia
        '
        Me.TXT_ImporteEstancia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ImporteEstancia.Location = New System.Drawing.Point(404, 145)
        Me.TXT_ImporteEstancia.Name = "TXT_ImporteEstancia"
        Me.TXT_ImporteEstancia.ReadOnly = True
        Me.TXT_ImporteEstancia.Size = New System.Drawing.Size(96, 26)
        Me.TXT_ImporteEstancia.TabIndex = 8
        '
        'TXT_ImporteExtras
        '
        Me.TXT_ImporteExtras.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_ImporteExtras.Location = New System.Drawing.Point(404, 183)
        Me.TXT_ImporteExtras.Name = "TXT_ImporteExtras"
        Me.TXT_ImporteExtras.ReadOnly = True
        Me.TXT_ImporteExtras.Size = New System.Drawing.Size(96, 26)
        Me.TXT_ImporteExtras.TabIndex = 9
        '
        'TXT_Total
        '
        Me.TXT_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Total.Location = New System.Drawing.Point(404, 224)
        Me.TXT_Total.Name = "TXT_Total"
        Me.TXT_Total.ReadOnly = True
        Me.TXT_Total.Size = New System.Drawing.Size(96, 26)
        Me.TXT_Total.TabIndex = 10
        '
        'LBL_4
        '
        Me.LBL_4.AutoSize = True
        Me.LBL_4.Location = New System.Drawing.Point(507, 153)
        Me.LBL_4.Name = "LBL_4"
        Me.LBL_4.Size = New System.Drawing.Size(34, 13)
        Me.LBL_4.TabIndex = 11
        Me.LBL_4.Text = "Euros"
        '
        'LBL_5
        '
        Me.LBL_5.AutoSize = True
        Me.LBL_5.Location = New System.Drawing.Point(507, 191)
        Me.LBL_5.Name = "LBL_5"
        Me.LBL_5.Size = New System.Drawing.Size(34, 13)
        Me.LBL_5.TabIndex = 12
        Me.LBL_5.Text = "Euros"
        '
        'LBL_6
        '
        Me.LBL_6.AutoSize = True
        Me.LBL_6.Location = New System.Drawing.Point(507, 232)
        Me.LBL_6.Name = "LBL_6"
        Me.LBL_6.Size = New System.Drawing.Size(34, 13)
        Me.LBL_6.TabIndex = 13
        Me.LBL_6.Text = "Euros"
        '
        'PCB_1
        '
        Me.PCB_1.Location = New System.Drawing.Point(47, 267)
        Me.PCB_1.Name = "PCB_1"
        Me.PCB_1.Size = New System.Drawing.Size(110, 108)
        Me.PCB_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_1.TabIndex = 14
        Me.PCB_1.TabStop = False
        '
        'PCB_2
        '
        Me.PCB_2.Location = New System.Drawing.Point(163, 267)
        Me.PCB_2.Name = "PCB_2"
        Me.PCB_2.Size = New System.Drawing.Size(110, 108)
        Me.PCB_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_2.TabIndex = 15
        Me.PCB_2.TabStop = False
        '
        'PCB_3
        '
        Me.PCB_3.Location = New System.Drawing.Point(279, 267)
        Me.PCB_3.Name = "PCB_3"
        Me.PCB_3.Size = New System.Drawing.Size(110, 108)
        Me.PCB_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_3.TabIndex = 16
        Me.PCB_3.TabStop = False
        '
        'PCB_4
        '
        Me.PCB_4.Location = New System.Drawing.Point(395, 267)
        Me.PCB_4.Name = "PCB_4"
        Me.PCB_4.Size = New System.Drawing.Size(110, 108)
        Me.PCB_4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_4.TabIndex = 17
        Me.PCB_4.TabStop = False
        '
        'BTN_Izquierda
        '
        Me.BTN_Izquierda.Location = New System.Drawing.Point(12, 267)
        Me.BTN_Izquierda.Name = "BTN_Izquierda"
        Me.BTN_Izquierda.Size = New System.Drawing.Size(29, 108)
        Me.BTN_Izquierda.TabIndex = 18
        Me.BTN_Izquierda.Text = "<"
        Me.BTN_Izquierda.UseVisualStyleBackColor = True
        '
        'BTN_Derecha
        '
        Me.BTN_Derecha.Location = New System.Drawing.Point(510, 267)
        Me.BTN_Derecha.Name = "BTN_Derecha"
        Me.BTN_Derecha.Size = New System.Drawing.Size(29, 108)
        Me.BTN_Derecha.TabIndex = 19
        Me.BTN_Derecha.Text = ">"
        Me.BTN_Derecha.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(781, 390)
        Me.Controls.Add(Me.BTN_Derecha)
        Me.Controls.Add(Me.BTN_Izquierda)
        Me.Controls.Add(Me.PCB_4)
        Me.Controls.Add(Me.PCB_3)
        Me.Controls.Add(Me.PCB_2)
        Me.Controls.Add(Me.PCB_1)
        Me.Controls.Add(Me.LBL_6)
        Me.Controls.Add(Me.LBL_5)
        Me.Controls.Add(Me.LBL_4)
        Me.Controls.Add(Me.TXT_Total)
        Me.Controls.Add(Me.TXT_ImporteExtras)
        Me.Controls.Add(Me.TXT_ImporteEstancia)
        Me.Controls.Add(Me.BTN_Reservar)
        Me.Controls.Add(Me.DTP_SeleccionFecha)
        Me.Controls.Add(Me.LSB_Fechas)
        Me.Controls.Add(Me.LBL_3)
        Me.Controls.Add(Me.LBL_2)
        Me.Controls.Add(Me.LBL_1)
        Me.Controls.Add(Me.GRB_Extras)
        Me.Controls.Add(Me.PCB_Imagen)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PCB_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRB_Extras.ResumeLayout(False)
        Me.GRB_Extras.PerformLayout()
        CType(Me.PCB_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PCB_Imagen As PictureBox
    Friend WithEvents GRB_Extras As GroupBox
    Friend WithEvents CHK_Extra3 As CheckBox
    Friend WithEvents CHK_Extra2 As CheckBox
    Friend WithEvents CHK_Extra1 As CheckBox
    Friend WithEvents IML_Galeria As ImageList
    Friend WithEvents TMR_3s As Timer
    Friend WithEvents LBL_1 As Label
    Friend WithEvents LBL_2 As Label
    Friend WithEvents LBL_3 As Label
    Friend WithEvents LSB_Fechas As ListBox
    Friend WithEvents DTP_SeleccionFecha As DateTimePicker
    Friend WithEvents BTN_Reservar As Button
    Friend WithEvents TXT_ImporteEstancia As TextBox
    Friend WithEvents TXT_ImporteExtras As TextBox
    Friend WithEvents TXT_Total As TextBox
    Friend WithEvents LBL_4 As Label
    Friend WithEvents LBL_5 As Label
    Friend WithEvents LBL_6 As Label
    Friend WithEvents PCB_1 As PictureBox
    Friend WithEvents PCB_2 As PictureBox
    Friend WithEvents PCB_3 As PictureBox
    Friend WithEvents PCB_4 As PictureBox
    Friend WithEvents BTN_Izquierda As Button
    Friend WithEvents BTN_Derecha As Button
End Class
