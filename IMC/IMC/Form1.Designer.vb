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
        Me.LBL_Rango = New System.Windows.Forms.Label()
        Me.BTN_Calcular = New System.Windows.Forms.Button()
        Me.TXT_Altura = New System.Windows.Forms.TextBox()
        Me.TXT_Peso = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LBL_Imc = New System.Windows.Forms.Label()
        Me.PCB_Anorexico = New System.Windows.Forms.PictureBox()
        Me.PCB_Delgado = New System.Windows.Forms.PictureBox()
        Me.PCB_Normal = New System.Windows.Forms.PictureBox()
        Me.PCB_Sobrepeso = New System.Windows.Forms.PictureBox()
        Me.PCB_Obesidad = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PCB_Anorexico, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Delgado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Normal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Sobrepeso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Obesidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_Rango
        '
        Me.LBL_Rango.AutoSize = True
        Me.LBL_Rango.Location = New System.Drawing.Point(354, 39)
        Me.LBL_Rango.Name = "LBL_Rango"
        Me.LBL_Rango.Size = New System.Drawing.Size(70, 13)
        Me.LBL_Rango.TabIndex = 0
        Me.LBL_Rango.Text = "ANOREXICO"
        '
        'BTN_Calcular
        '
        Me.BTN_Calcular.Location = New System.Drawing.Point(117, 158)
        Me.BTN_Calcular.Name = "BTN_Calcular"
        Me.BTN_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Calcular.TabIndex = 1
        Me.BTN_Calcular.Text = "Calcular"
        Me.BTN_Calcular.UseVisualStyleBackColor = True
        '
        'TXT_Altura
        '
        Me.TXT_Altura.Location = New System.Drawing.Point(105, 77)
        Me.TXT_Altura.Name = "TXT_Altura"
        Me.TXT_Altura.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Altura.TabIndex = 2
        '
        'TXT_Peso
        '
        Me.TXT_Peso.Location = New System.Drawing.Point(105, 117)
        Me.TXT_Peso.Name = "TXT_Peso"
        Me.TXT_Peso.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Peso.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(88, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = " INTRODUCE TUS DATOS"
        '
        'LBL_Imc
        '
        Me.LBL_Imc.AutoSize = True
        Me.LBL_Imc.Location = New System.Drawing.Point(278, 235)
        Me.LBL_Imc.Name = "LBL_Imc"
        Me.LBL_Imc.Size = New System.Drawing.Size(7, 17)
        Me.LBL_Imc.TabIndex = 6
        Me.LBL_Imc.Text = " "
        Me.LBL_Imc.UseCompatibleTextRendering = True
        '
        'PCB_Anorexico
        '
        Me.PCB_Anorexico.Image = CType(resources.GetObject("PCB_Anorexico.Image"), System.Drawing.Image)
        Me.PCB_Anorexico.Location = New System.Drawing.Point(331, 64)
        Me.PCB_Anorexico.Name = "PCB_Anorexico"
        Me.PCB_Anorexico.Size = New System.Drawing.Size(149, 184)
        Me.PCB_Anorexico.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Anorexico.TabIndex = 7
        Me.PCB_Anorexico.TabStop = False
        '
        'PCB_Delgado
        '
        Me.PCB_Delgado.Image = CType(resources.GetObject("PCB_Delgado.Image"), System.Drawing.Image)
        Me.PCB_Delgado.Location = New System.Drawing.Point(331, 64)
        Me.PCB_Delgado.Name = "PCB_Delgado"
        Me.PCB_Delgado.Size = New System.Drawing.Size(149, 184)
        Me.PCB_Delgado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Delgado.TabIndex = 8
        Me.PCB_Delgado.TabStop = False
        '
        'PCB_Normal
        '
        Me.PCB_Normal.Image = CType(resources.GetObject("PCB_Normal.Image"), System.Drawing.Image)
        Me.PCB_Normal.Location = New System.Drawing.Point(331, 64)
        Me.PCB_Normal.Name = "PCB_Normal"
        Me.PCB_Normal.Size = New System.Drawing.Size(149, 184)
        Me.PCB_Normal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Normal.TabIndex = 9
        Me.PCB_Normal.TabStop = False
        '
        'PCB_Sobrepeso
        '
        Me.PCB_Sobrepeso.Image = CType(resources.GetObject("PCB_Sobrepeso.Image"), System.Drawing.Image)
        Me.PCB_Sobrepeso.Location = New System.Drawing.Point(331, 64)
        Me.PCB_Sobrepeso.Name = "PCB_Sobrepeso"
        Me.PCB_Sobrepeso.Size = New System.Drawing.Size(149, 184)
        Me.PCB_Sobrepeso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Sobrepeso.TabIndex = 10
        Me.PCB_Sobrepeso.TabStop = False
        '
        'PCB_Obesidad
        '
        Me.PCB_Obesidad.Image = CType(resources.GetObject("PCB_Obesidad.Image"), System.Drawing.Image)
        Me.PCB_Obesidad.Location = New System.Drawing.Point(331, 64)
        Me.PCB_Obesidad.Name = "PCB_Obesidad"
        Me.PCB_Obesidad.Size = New System.Drawing.Size(149, 184)
        Me.PCB_Obesidad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Obesidad.TabIndex = 11
        Me.PCB_Obesidad.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 326)
        Me.Controls.Add(Me.PCB_Obesidad)
        Me.Controls.Add(Me.PCB_Sobrepeso)
        Me.Controls.Add(Me.PCB_Normal)
        Me.Controls.Add(Me.PCB_Delgado)
        Me.Controls.Add(Me.PCB_Anorexico)
        Me.Controls.Add(Me.LBL_Imc)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TXT_Peso)
        Me.Controls.Add(Me.TXT_Altura)
        Me.Controls.Add(Me.BTN_Calcular)
        Me.Controls.Add(Me.LBL_Rango)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PCB_Anorexico, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Delgado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Normal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Sobrepeso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Obesidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LBL_Rango As Label
    Friend WithEvents BTN_Calcular As Button
    Friend WithEvents TXT_Altura As TextBox
    Friend WithEvents TXT_Peso As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents LBL_Imc As Label
    Friend WithEvents PCB_Anorexico As PictureBox
    Friend WithEvents PCB_Delgado As PictureBox
    Friend WithEvents PCB_Normal As PictureBox
    Friend WithEvents PCB_Sobrepeso As PictureBox
    Friend WithEvents PCB_Obesidad As PictureBox
    Friend WithEvents ImageList1 As ImageList
End Class
