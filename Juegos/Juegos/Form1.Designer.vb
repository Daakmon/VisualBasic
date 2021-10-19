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
        Me.LBL_Titulo = New System.Windows.Forms.Label()
        Me.LSB_ListaJuegos = New System.Windows.Forms.ListBox()
        Me.PCB_Imagen = New System.Windows.Forms.PictureBox()
        Me.IML_ListaImagenes = New System.Windows.Forms.ImageList(Me.components)
        CType(Me.PCB_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LBL_Titulo
        '
        Me.LBL_Titulo.AutoSize = True
        Me.LBL_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Titulo.Location = New System.Drawing.Point(349, 6)
        Me.LBL_Titulo.Name = "LBL_Titulo"
        Me.LBL_Titulo.Size = New System.Drawing.Size(81, 31)
        Me.LBL_Titulo.TabIndex = 0
        Me.LBL_Titulo.Text = "Titulo"
        '
        'LSB_ListaJuegos
        '
        Me.LSB_ListaJuegos.FormattingEnabled = True
        Me.LSB_ListaJuegos.Items.AddRange(New Object() {"Last Of Us", "Horizon Zero Dawn", "Dying Light", "Doom", "Bloodborne"})
        Me.LSB_ListaJuegos.Location = New System.Drawing.Point(12, 185)
        Me.LSB_ListaJuegos.Name = "LSB_ListaJuegos"
        Me.LSB_ListaJuegos.Size = New System.Drawing.Size(120, 95)
        Me.LSB_ListaJuegos.TabIndex = 1
        '
        'PCB_Imagen
        '
        Me.PCB_Imagen.Location = New System.Drawing.Point(156, 43)
        Me.PCB_Imagen.Name = "PCB_Imagen"
        Me.PCB_Imagen.Size = New System.Drawing.Size(535, 302)
        Me.PCB_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Imagen.TabIndex = 2
        Me.PCB_Imagen.TabStop = False
        '
        'IML_ListaImagenes
        '
        Me.IML_ListaImagenes.ImageStream = CType(resources.GetObject("IML_ListaImagenes.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.IML_ListaImagenes.TransparentColor = System.Drawing.Color.Transparent
        Me.IML_ListaImagenes.Images.SetKeyName(0, "The Last Of Us Parte II.jpg")
        Me.IML_ListaImagenes.Images.SetKeyName(1, "Horizon Zero Dawn.jpeg")
        Me.IML_ListaImagenes.Images.SetKeyName(2, "Dying Light.jpg")
        Me.IML_ListaImagenes.Images.SetKeyName(3, "Doom.jpeg")
        Me.IML_ListaImagenes.Images.SetKeyName(4, "Bloodborne.jpg")
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 357)
        Me.Controls.Add(Me.PCB_Imagen)
        Me.Controls.Add(Me.LSB_ListaJuegos)
        Me.Controls.Add(Me.LBL_Titulo)
        Me.Name = "Form1"
        Me.ShowInTaskbar = False
        Me.Text = "Form1"
        CType(Me.PCB_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LBL_Titulo As Label
    Friend WithEvents LSB_ListaJuegos As ListBox
    Friend WithEvents PCB_Imagen As PictureBox
    Friend WithEvents IML_ListaImagenes As ImageList
End Class
