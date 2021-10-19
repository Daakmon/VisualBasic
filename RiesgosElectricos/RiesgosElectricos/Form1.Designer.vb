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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.BTN_Calcular = New System.Windows.Forms.Button()
        Me.LBL_Riesgo = New System.Windows.Forms.Label()
        Me.TXT_mA = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LBL_Descripcion = New System.Windows.Forms.Label()
        Me.PCB_ImagenEfecto = New System.Windows.Forms.PictureBox()
        Me.PCB_Pila = New System.Windows.Forms.PictureBox()
        Me.PCB_Shock = New System.Windows.Forms.PictureBox()
        Me.PCB_Tetanizacion = New System.Windows.Forms.PictureBox()
        Me.PCB_Cerebro = New System.Windows.Forms.PictureBox()
        Me.PCB_Pulmones = New System.Windows.Forms.PictureBox()
        Me.PCB_Corazon = New System.Windows.Forms.PictureBox()
        Me.PCB_Muerte = New System.Windows.Forms.PictureBox()
        Me.PCB_Mostrar = New System.Windows.Forms.PictureBox()
        CType(Me.PCB_ImagenEfecto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Pila, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Shock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Tetanizacion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Cerebro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Pulmones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Corazon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Muerte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Mostrar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Calcular
        '
        Me.BTN_Calcular.Location = New System.Drawing.Point(383, 91)
        Me.BTN_Calcular.Name = "BTN_Calcular"
        Me.BTN_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Calcular.TabIndex = 0
        Me.BTN_Calcular.Text = "Calcular"
        Me.BTN_Calcular.UseVisualStyleBackColor = True
        '
        'LBL_Riesgo
        '
        Me.LBL_Riesgo.AutoSize = True
        Me.LBL_Riesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(16, Byte))
        Me.LBL_Riesgo.Location = New System.Drawing.Point(119, 37)
        Me.LBL_Riesgo.Name = "LBL_Riesgo"
        Me.LBL_Riesgo.Size = New System.Drawing.Size(273, 22)
        Me.LBL_Riesgo.TabIndex = 1
        Me.LBL_Riesgo.Text = "NO HAY RIESGO ELÉCYTRICO"
        '
        'TXT_mA
        '
        Me.TXT_mA.Location = New System.Drawing.Point(266, 94)
        Me.TXT_mA.Name = "TXT_mA"
        Me.TXT_mA.Size = New System.Drawing.Size(100, 20)
        Me.TXT_mA.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(143, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Introduce una cantidad"
        '
        'LBL_Descripcion
        '
        Me.LBL_Descripcion.AutoSize = True
        Me.LBL_Descripcion.Location = New System.Drawing.Point(143, 148)
        Me.LBL_Descripcion.Name = "LBL_Descripcion"
        Me.LBL_Descripcion.Size = New System.Drawing.Size(169, 13)
        Me.LBL_Descripcion.TabIndex = 4
        Me.LBL_Descripcion.Text = "No hay ningun efecto sin corriente"
        '
        'PCB_ImagenEfecto
        '
        Me.PCB_ImagenEfecto.Image = CType(resources.GetObject("PCB_ImagenEfecto.Image"), System.Drawing.Image)
        Me.PCB_ImagenEfecto.InitialImage = CType(resources.GetObject("PCB_ImagenEfecto.InitialImage"), System.Drawing.Image)
        Me.PCB_ImagenEfecto.Location = New System.Drawing.Point(13, 243)
        Me.PCB_ImagenEfecto.Name = "PCB_ImagenEfecto"
        Me.PCB_ImagenEfecto.Size = New System.Drawing.Size(143, 92)
        Me.PCB_ImagenEfecto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_ImagenEfecto.TabIndex = 5
        Me.PCB_ImagenEfecto.TabStop = False
        Me.PCB_ImagenEfecto.Visible = False
        '
        'PCB_Pila
        '
        Me.PCB_Pila.Image = CType(resources.GetObject("PCB_Pila.Image"), System.Drawing.Image)
        Me.PCB_Pila.InitialImage = CType(resources.GetObject("PCB_Pila.InitialImage"), System.Drawing.Image)
        Me.PCB_Pila.Location = New System.Drawing.Point(162, 243)
        Me.PCB_Pila.Name = "PCB_Pila"
        Me.PCB_Pila.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Pila.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Pila.TabIndex = 6
        Me.PCB_Pila.TabStop = False
        Me.PCB_Pila.Visible = False
        '
        'PCB_Shock
        '
        Me.PCB_Shock.Image = CType(resources.GetObject("PCB_Shock.Image"), System.Drawing.Image)
        Me.PCB_Shock.InitialImage = CType(resources.GetObject("PCB_Shock.InitialImage"), System.Drawing.Image)
        Me.PCB_Shock.Location = New System.Drawing.Point(311, 243)
        Me.PCB_Shock.Name = "PCB_Shock"
        Me.PCB_Shock.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Shock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Shock.TabIndex = 7
        Me.PCB_Shock.TabStop = False
        Me.PCB_Shock.Visible = False
        '
        'PCB_Tetanizacion
        '
        Me.PCB_Tetanizacion.Image = CType(resources.GetObject("PCB_Tetanizacion.Image"), System.Drawing.Image)
        Me.PCB_Tetanizacion.InitialImage = CType(resources.GetObject("PCB_Tetanizacion.InitialImage"), System.Drawing.Image)
        Me.PCB_Tetanizacion.Location = New System.Drawing.Point(460, 243)
        Me.PCB_Tetanizacion.Name = "PCB_Tetanizacion"
        Me.PCB_Tetanizacion.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Tetanizacion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Tetanizacion.TabIndex = 8
        Me.PCB_Tetanizacion.TabStop = False
        Me.PCB_Tetanizacion.Visible = False
        '
        'PCB_Cerebro
        '
        Me.PCB_Cerebro.Image = CType(resources.GetObject("PCB_Cerebro.Image"), System.Drawing.Image)
        Me.PCB_Cerebro.InitialImage = CType(resources.GetObject("PCB_Cerebro.InitialImage"), System.Drawing.Image)
        Me.PCB_Cerebro.Location = New System.Drawing.Point(12, 341)
        Me.PCB_Cerebro.Name = "PCB_Cerebro"
        Me.PCB_Cerebro.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Cerebro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Cerebro.TabIndex = 9
        Me.PCB_Cerebro.TabStop = False
        Me.PCB_Cerebro.Visible = False
        '
        'PCB_Pulmones
        '
        Me.PCB_Pulmones.Image = CType(resources.GetObject("PCB_Pulmones.Image"), System.Drawing.Image)
        Me.PCB_Pulmones.InitialImage = CType(resources.GetObject("PCB_Pulmones.InitialImage"), System.Drawing.Image)
        Me.PCB_Pulmones.Location = New System.Drawing.Point(161, 341)
        Me.PCB_Pulmones.Name = "PCB_Pulmones"
        Me.PCB_Pulmones.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Pulmones.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Pulmones.TabIndex = 10
        Me.PCB_Pulmones.TabStop = False
        Me.PCB_Pulmones.Visible = False
        '
        'PCB_Corazon
        '
        Me.PCB_Corazon.Image = CType(resources.GetObject("PCB_Corazon.Image"), System.Drawing.Image)
        Me.PCB_Corazon.InitialImage = CType(resources.GetObject("PCB_Corazon.InitialImage"), System.Drawing.Image)
        Me.PCB_Corazon.Location = New System.Drawing.Point(310, 341)
        Me.PCB_Corazon.Name = "PCB_Corazon"
        Me.PCB_Corazon.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Corazon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Corazon.TabIndex = 11
        Me.PCB_Corazon.TabStop = False
        Me.PCB_Corazon.Visible = False
        '
        'PCB_Muerte
        '
        Me.PCB_Muerte.Image = CType(resources.GetObject("PCB_Muerte.Image"), System.Drawing.Image)
        Me.PCB_Muerte.InitialImage = CType(resources.GetObject("PCB_Muerte.InitialImage"), System.Drawing.Image)
        Me.PCB_Muerte.Location = New System.Drawing.Point(459, 341)
        Me.PCB_Muerte.Name = "PCB_Muerte"
        Me.PCB_Muerte.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Muerte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Muerte.TabIndex = 12
        Me.PCB_Muerte.TabStop = False
        Me.PCB_Muerte.Visible = False
        '
        'PCB_Mostrar
        '
        Me.PCB_Mostrar.Image = CType(resources.GetObject("PCB_Mostrar.Image"), System.Drawing.Image)
        Me.PCB_Mostrar.InitialImage = CType(resources.GetObject("PCB_Mostrar.InitialImage"), System.Drawing.Image)
        Me.PCB_Mostrar.Location = New System.Drawing.Point(531, 69)
        Me.PCB_Mostrar.Name = "PCB_Mostrar"
        Me.PCB_Mostrar.Size = New System.Drawing.Size(143, 92)
        Me.PCB_Mostrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Mostrar.TabIndex = 13
        Me.PCB_Mostrar.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.PCB_Mostrar)
        Me.Controls.Add(Me.PCB_Muerte)
        Me.Controls.Add(Me.PCB_Corazon)
        Me.Controls.Add(Me.PCB_Pulmones)
        Me.Controls.Add(Me.PCB_Cerebro)
        Me.Controls.Add(Me.PCB_Tetanizacion)
        Me.Controls.Add(Me.PCB_Shock)
        Me.Controls.Add(Me.PCB_Pila)
        Me.Controls.Add(Me.PCB_ImagenEfecto)
        Me.Controls.Add(Me.LBL_Descripcion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TXT_mA)
        Me.Controls.Add(Me.LBL_Riesgo)
        Me.Controls.Add(Me.BTN_Calcular)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PCB_ImagenEfecto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Pila, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Shock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Tetanizacion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Cerebro, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Pulmones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Corazon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Muerte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Mostrar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Calcular As Button
    Friend WithEvents LBL_Riesgo As Label
    Friend WithEvents TXT_mA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents LBL_Descripcion As Label
    Friend WithEvents PCB_ImagenEfecto As PictureBox
    Friend WithEvents PCB_Pila As PictureBox
    Friend WithEvents PCB_Shock As PictureBox
    Friend WithEvents PCB_Tetanizacion As PictureBox
    Friend WithEvents PCB_Cerebro As PictureBox
    Friend WithEvents PCB_Pulmones As PictureBox
    Friend WithEvents PCB_Corazon As PictureBox
    Friend WithEvents PCB_Muerte As PictureBox
    Friend WithEvents PCB_Mostrar As PictureBox
End Class
