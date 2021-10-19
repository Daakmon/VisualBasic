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
        Me.IML_Fotos = New System.Windows.Forms.ImageList(Me.components)
        Me.LBL_Nombre = New System.Windows.Forms.Label()
        Me.CMB_SeleccionCoche = New System.Windows.Forms.ComboBox()
        Me.LBL_PrecioBase = New System.Windows.Forms.Label()
        Me.LBL_Extras = New System.Windows.Forms.Label()
        Me.LBL_ExtraRegalado = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        Me.LBL_Total = New System.Windows.Forms.Label()
        Me.TXT_PrecioBase = New System.Windows.Forms.TextBox()
        Me.TXT_ExtraRegalado = New System.Windows.Forms.TextBox()
        Me.TXT_Extras = New System.Windows.Forms.TextBox()
        Me.TXT_IVA = New System.Windows.Forms.TextBox()
        Me.TXT_Total = New System.Windows.Forms.TextBox()
        Me.PCB_Foto = New System.Windows.Forms.PictureBox()
        Me.CHK_Llantas = New System.Windows.Forms.CheckBox()
        Me.GRB_Complementos = New System.Windows.Forms.GroupBox()
        Me.CHK_Intermitentes = New System.Windows.Forms.CheckBox()
        Me.CHK_Ambientador = New System.Windows.Forms.CheckBox()
        Me.CHK_Asientos = New System.Windows.Forms.CheckBox()
        Me.CHK_Navegador = New System.Windows.Forms.CheckBox()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.LBL_Regalo = New System.Windows.Forms.Label()
        CType(Me.PCB_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GRB_Complementos.SuspendLayout()
        Me.SuspendLayout()
        '
        'IML_Fotos
        '
        Me.IML_Fotos.ImageStream = CType(resources.GetObject("IML_Fotos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_Fotos.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_Fotos.Images.SetKeyName(0, "CamaroZL1.jpg")
        Me.IML_Fotos.Images.SetKeyName(1, "MustangGT500.jpg")
        Me.IML_Fotos.Images.SetKeyName(2, "LamborghiniSixtoElemento.jpg")
        '
        'LBL_Nombre
        '
        Me.LBL_Nombre.AutoSize = True
        Me.LBL_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Nombre.Location = New System.Drawing.Point(58, 26)
        Me.LBL_Nombre.Name = "LBL_Nombre"
        Me.LBL_Nombre.Size = New System.Drawing.Size(120, 36)
        Me.LBL_Nombre.TabIndex = 0
        Me.LBL_Nombre.Text = "Nombre"
        '
        'CMB_SeleccionCoche
        '
        Me.CMB_SeleccionCoche.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_SeleccionCoche.FormattingEnabled = True
        Me.CMB_SeleccionCoche.Items.AddRange(New Object() {"Camaro ZL1", "Ford GT500", "Lamborghini Sixto Elemento"})
        Me.CMB_SeleccionCoche.Location = New System.Drawing.Point(64, 65)
        Me.CMB_SeleccionCoche.Name = "CMB_SeleccionCoche"
        Me.CMB_SeleccionCoche.Size = New System.Drawing.Size(138, 21)
        Me.CMB_SeleccionCoche.TabIndex = 1
        '
        'LBL_PrecioBase
        '
        Me.LBL_PrecioBase.AutoSize = True
        Me.LBL_PrecioBase.Location = New System.Drawing.Point(61, 230)
        Me.LBL_PrecioBase.Name = "LBL_PrecioBase"
        Me.LBL_PrecioBase.Size = New System.Drawing.Size(66, 13)
        Me.LBL_PrecioBase.TabIndex = 2
        Me.LBL_PrecioBase.Text = "Precio base:"
        '
        'LBL_Extras
        '
        Me.LBL_Extras.AutoSize = True
        Me.LBL_Extras.Location = New System.Drawing.Point(61, 261)
        Me.LBL_Extras.Name = "LBL_Extras"
        Me.LBL_Extras.Size = New System.Drawing.Size(39, 13)
        Me.LBL_Extras.TabIndex = 3
        Me.LBL_Extras.Text = "Extras:"
        '
        'LBL_ExtraRegalado
        '
        Me.LBL_ExtraRegalado.AutoSize = True
        Me.LBL_ExtraRegalado.Location = New System.Drawing.Point(61, 291)
        Me.LBL_ExtraRegalado.Name = "LBL_ExtraRegalado"
        Me.LBL_ExtraRegalado.Size = New System.Drawing.Size(78, 13)
        Me.LBL_ExtraRegalado.TabIndex = 4
        Me.LBL_ExtraRegalado.Text = "Extra regalado:"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(61, 320)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(56, 13)
        Me.LBL_IVA.TabIndex = 5
        Me.LBL_IVA.Text = "IVA (21%):"
        '
        'LBL_Total
        '
        Me.LBL_Total.AutoSize = True
        Me.LBL_Total.Location = New System.Drawing.Point(61, 350)
        Me.LBL_Total.Name = "LBL_Total"
        Me.LBL_Total.Size = New System.Drawing.Size(45, 13)
        Me.LBL_Total.TabIndex = 6
        Me.LBL_Total.Text = "TOTAL:"
        '
        'TXT_PrecioBase
        '
        Me.TXT_PrecioBase.Location = New System.Drawing.Point(145, 227)
        Me.TXT_PrecioBase.Name = "TXT_PrecioBase"
        Me.TXT_PrecioBase.ReadOnly = True
        Me.TXT_PrecioBase.Size = New System.Drawing.Size(100, 20)
        Me.TXT_PrecioBase.TabIndex = 7
        '
        'TXT_ExtraRegalado
        '
        Me.TXT_ExtraRegalado.Location = New System.Drawing.Point(145, 288)
        Me.TXT_ExtraRegalado.Name = "TXT_ExtraRegalado"
        Me.TXT_ExtraRegalado.ReadOnly = True
        Me.TXT_ExtraRegalado.Size = New System.Drawing.Size(100, 20)
        Me.TXT_ExtraRegalado.TabIndex = 8
        '
        'TXT_Extras
        '
        Me.TXT_Extras.Location = New System.Drawing.Point(145, 258)
        Me.TXT_Extras.Name = "TXT_Extras"
        Me.TXT_Extras.ReadOnly = True
        Me.TXT_Extras.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Extras.TabIndex = 9
        '
        'TXT_IVA
        '
        Me.TXT_IVA.Location = New System.Drawing.Point(145, 317)
        Me.TXT_IVA.Name = "TXT_IVA"
        Me.TXT_IVA.ReadOnly = True
        Me.TXT_IVA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_IVA.TabIndex = 10
        '
        'TXT_Total
        '
        Me.TXT_Total.Location = New System.Drawing.Point(145, 347)
        Me.TXT_Total.Name = "TXT_Total"
        Me.TXT_Total.ReadOnly = True
        Me.TXT_Total.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Total.TabIndex = 11
        '
        'PCB_Foto
        '
        Me.PCB_Foto.Location = New System.Drawing.Point(313, 22)
        Me.PCB_Foto.Name = "PCB_Foto"
        Me.PCB_Foto.Size = New System.Drawing.Size(318, 178)
        Me.PCB_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Foto.TabIndex = 12
        Me.PCB_Foto.TabStop = False
        '
        'CHK_Llantas
        '
        Me.CHK_Llantas.AutoSize = True
        Me.CHK_Llantas.Location = New System.Drawing.Point(53, 31)
        Me.CHK_Llantas.Name = "CHK_Llantas"
        Me.CHK_Llantas.Size = New System.Drawing.Size(125, 17)
        Me.CHK_Llantas.TabIndex = 19
        Me.CHK_Llantas.Tag = "300"
        Me.CHK_Llantas.Text = "Llantas Custom 300€"
        Me.CHK_Llantas.UseVisualStyleBackColor = True
        '
        'GRB_Complementos
        '
        Me.GRB_Complementos.Controls.Add(Me.CHK_Intermitentes)
        Me.GRB_Complementos.Controls.Add(Me.CHK_Llantas)
        Me.GRB_Complementos.Controls.Add(Me.CHK_Ambientador)
        Me.GRB_Complementos.Controls.Add(Me.CHK_Asientos)
        Me.GRB_Complementos.Controls.Add(Me.CHK_Navegador)
        Me.GRB_Complementos.Location = New System.Drawing.Point(313, 217)
        Me.GRB_Complementos.Name = "GRB_Complementos"
        Me.GRB_Complementos.Size = New System.Drawing.Size(405, 177)
        Me.GRB_Complementos.TabIndex = 20
        Me.GRB_Complementos.TabStop = False
        Me.GRB_Complementos.Text = " Complementos"
        '
        'CHK_Intermitentes
        '
        Me.CHK_Intermitentes.AutoSize = True
        Me.CHK_Intermitentes.Location = New System.Drawing.Point(53, 139)
        Me.CHK_Intermitentes.Name = "CHK_Intermitentes"
        Me.CHK_Intermitentes.Size = New System.Drawing.Size(119, 17)
        Me.CHK_Intermitentes.TabIndex = 23
        Me.CHK_Intermitentes.Tag = "1000"
        Me.CHK_Intermitentes.Text = "Intermitentes 1000€"
        Me.CHK_Intermitentes.UseVisualStyleBackColor = True
        '
        'CHK_Ambientador
        '
        Me.CHK_Ambientador.AutoSize = True
        Me.CHK_Ambientador.Location = New System.Drawing.Point(53, 58)
        Me.CHK_Ambientador.Name = "CHK_Ambientador"
        Me.CHK_Ambientador.Size = New System.Drawing.Size(143, 17)
        Me.CHK_Ambientador.TabIndex = 20
        Me.CHK_Ambientador.Tag = "10"
        Me.CHK_Ambientador.Text = "Ambientador Pinosol 10€"
        Me.CHK_Ambientador.UseVisualStyleBackColor = True
        '
        'CHK_Asientos
        '
        Me.CHK_Asientos.AutoSize = True
        Me.CHK_Asientos.Location = New System.Drawing.Point(53, 113)
        Me.CHK_Asientos.Name = "CHK_Asientos"
        Me.CHK_Asientos.Size = New System.Drawing.Size(117, 17)
        Me.CHK_Asientos.TabIndex = 22
        Me.CHK_Asientos.Tag = "800"
        Me.CHK_Asientos.Text = "Calefactables 800€"
        Me.CHK_Asientos.UseVisualStyleBackColor = True
        '
        'CHK_Navegador
        '
        Me.CHK_Navegador.AutoSize = True
        Me.CHK_Navegador.Location = New System.Drawing.Point(53, 86)
        Me.CHK_Navegador.Name = "CHK_Navegador"
        Me.CHK_Navegador.Size = New System.Drawing.Size(106, 17)
        Me.CHK_Navegador.TabIndex = 21
        Me.CHK_Navegador.Tag = "500"
        Me.CHK_Navegador.Text = "Navegador 500€"
        Me.CHK_Navegador.UseVisualStyleBackColor = True
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(643, 423)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 22
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        Me.BTN_Salir.UseWaitCursor = True
        '
        'LBL_Regalo
        '
        Me.LBL_Regalo.AutoSize = True
        Me.LBL_Regalo.Location = New System.Drawing.Point(249, 261)
        Me.LBL_Regalo.Name = "LBL_Regalo"
        Me.LBL_Regalo.Size = New System.Drawing.Size(10, 13)
        Me.LBL_Regalo.TabIndex = 23
        Me.LBL_Regalo.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 455)
        Me.Controls.Add(Me.LBL_Regalo)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.GRB_Complementos)
        Me.Controls.Add(Me.PCB_Foto)
        Me.Controls.Add(Me.TXT_Total)
        Me.Controls.Add(Me.TXT_IVA)
        Me.Controls.Add(Me.TXT_Extras)
        Me.Controls.Add(Me.TXT_ExtraRegalado)
        Me.Controls.Add(Me.TXT_PrecioBase)
        Me.Controls.Add(Me.LBL_Total)
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_ExtraRegalado)
        Me.Controls.Add(Me.LBL_Extras)
        Me.Controls.Add(Me.LBL_PrecioBase)
        Me.Controls.Add(Me.CMB_SeleccionCoche)
        Me.Controls.Add(Me.LBL_Nombre)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PCB_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GRB_Complementos.ResumeLayout(False)
        Me.GRB_Complementos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IML_Fotos As ImageList
    Friend WithEvents LBL_Nombre As Label
    Friend WithEvents CMB_SeleccionCoche As ComboBox
    Friend WithEvents LBL_PrecioBase As Label
    Friend WithEvents LBL_Extras As Label
    Friend WithEvents LBL_ExtraRegalado As Label
    Friend WithEvents LBL_IVA As Label
    Friend WithEvents LBL_Total As Label
    Friend WithEvents TXT_PrecioBase As TextBox
    Friend WithEvents TXT_ExtraRegalado As TextBox
    Friend WithEvents TXT_Extras As TextBox
    Friend WithEvents TXT_IVA As TextBox
    Friend WithEvents TXT_Total As TextBox
    Friend WithEvents PCB_Foto As PictureBox
    Friend WithEvents CHK_Llantas As CheckBox
    Friend WithEvents GRB_Complementos As GroupBox
    Friend WithEvents CHK_Intermitentes As CheckBox
    Friend WithEvents CHK_Asientos As CheckBox
    Friend WithEvents CHK_Navegador As CheckBox
    Friend WithEvents CHK_Ambientador As CheckBox
    Friend WithEvents BTN_Salir As Button
    Friend WithEvents LBL_Regalo As Label
End Class
