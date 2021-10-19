<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.LSB_Regalos = New System.Windows.Forms.ListBox()
        Me.IML_Regalos = New System.Windows.Forms.ImageList(Me.components)
        Me.LBL_Regalo1 = New System.Windows.Forms.Label()
        Me.LBL_Regalo2 = New System.Windows.Forms.Label()
        Me.BTN_Elegir = New System.Windows.Forms.Button()
        Me.BTN_Borrar = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.PCB_Imagen = New System.Windows.Forms.PictureBox()
        CType(Me.PCB_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LSB_Regalos
        '
        Me.LSB_Regalos.FormattingEnabled = True
        Me.LSB_Regalos.ItemHeight = 20
        Me.LSB_Regalos.Items.AddRange(New Object() {"Altavoz", "Auriculares", "Reloj", "Ordenador", "Movil"})
        Me.LSB_Regalos.Location = New System.Drawing.Point(18, 18)
        Me.LSB_Regalos.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.LSB_Regalos.Name = "LSB_Regalos"
        Me.LSB_Regalos.Size = New System.Drawing.Size(199, 244)
        Me.LSB_Regalos.TabIndex = 0
        '
        'IML_Regalos
        '
        Me.IML_Regalos.ImageStream = CType(resources.GetObject("IML_Regalos.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_Regalos.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_Regalos.Images.SetKeyName(0, "Altavoz.jpg")
        Me.IML_Regalos.Images.SetKeyName(1, "Auriculares.jpg")
        Me.IML_Regalos.Images.SetKeyName(2, "Reloj.jpg")
        Me.IML_Regalos.Images.SetKeyName(3, "Ordenador.jpeg")
        Me.IML_Regalos.Images.SetKeyName(4, "Movil.jpg")
        '
        'LBL_Regalo1
        '
        Me.LBL_Regalo1.AutoSize = True
        Me.LBL_Regalo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Regalo1.Location = New System.Drawing.Point(582, 58)
        Me.LBL_Regalo1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_Regalo1.Name = "LBL_Regalo1"
        Me.LBL_Regalo1.Size = New System.Drawing.Size(57, 20)
        Me.LBL_Regalo1.TabIndex = 1
        Me.LBL_Regalo1.Text = "Label1"
        '
        'LBL_Regalo2
        '
        Me.LBL_Regalo2.AutoSize = True
        Me.LBL_Regalo2.Location = New System.Drawing.Point(582, 132)
        Me.LBL_Regalo2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LBL_Regalo2.Name = "LBL_Regalo2"
        Me.LBL_Regalo2.Size = New System.Drawing.Size(57, 20)
        Me.LBL_Regalo2.TabIndex = 2
        Me.LBL_Regalo2.Text = "Label2"
        '
        'BTN_Elegir
        '
        Me.BTN_Elegir.Location = New System.Drawing.Point(18, 288)
        Me.BTN_Elegir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Elegir.Name = "BTN_Elegir"
        Me.BTN_Elegir.Size = New System.Drawing.Size(201, 35)
        Me.BTN_Elegir.TabIndex = 3
        Me.BTN_Elegir.Text = "Elegir Regalo"
        Me.BTN_Elegir.UseVisualStyleBackColor = True
        '
        'BTN_Borrar
        '
        Me.BTN_Borrar.Location = New System.Drawing.Point(255, 288)
        Me.BTN_Borrar.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.BTN_Borrar.Name = "BTN_Borrar"
        Me.BTN_Borrar.Size = New System.Drawing.Size(301, 35)
        Me.BTN_Borrar.TabIndex = 4
        Me.BTN_Borrar.Text = "Borrar Regalo"
        Me.BTN_Borrar.UseVisualStyleBackColor = True
        '
        'Salir
        '
        Me.Salir.Location = New System.Drawing.Point(132, 355)
        Me.Salir.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(201, 35)
        Me.Salir.TabIndex = 5
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = True
        '
        'PCB_Imagen
        '
        Me.PCB_Imagen.Location = New System.Drawing.Point(255, 18)
        Me.PCB_Imagen.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PCB_Imagen.Name = "PCB_Imagen"
        Me.PCB_Imagen.Size = New System.Drawing.Size(301, 246)
        Me.PCB_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Imagen.TabIndex = 6
        Me.PCB_Imagen.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 433)
        Me.Controls.Add(Me.PCB_Imagen)
        Me.Controls.Add(Me.Salir)
        Me.Controls.Add(Me.BTN_Borrar)
        Me.Controls.Add(Me.BTN_Elegir)
        Me.Controls.Add(Me.LBL_Regalo2)
        Me.Controls.Add(Me.LBL_Regalo1)
        Me.Controls.Add(Me.LSB_Regalos)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PCB_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LSB_Regalos As ListBox
    Friend WithEvents IML_Regalos As ImageList
    Friend WithEvents LBL_Regalo1 As Label
    Friend WithEvents LBL_Regalo2 As Label
    Friend WithEvents BTN_Elegir As Button
    Friend WithEvents BTN_Borrar As Button
    Friend WithEvents Salir As Button
    Friend WithEvents PCB_Imagen As PictureBox
End Class
