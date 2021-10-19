<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TiroAlPato
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
        Me.TMR_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.BTN_Fin = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PNL_Panel = New System.Windows.Forms.Panel()
        Me.PCB_Blood = New System.Windows.Forms.PictureBox()
        Me.PCB_Demon = New System.Windows.Forms.PictureBox()
        Me.PCB_Pato = New System.Windows.Forms.PictureBox()
        Me.CHK_Pesadilla = New System.Windows.Forms.CheckBox()
        Me.PCB_Pesadilla = New System.Windows.Forms.PictureBox()
        Me.PCB_Ultraviolencia = New System.Windows.Forms.PictureBox()
        Me.TMR_Juego = New System.Windows.Forms.Timer(Me.components)
        Me.TMR_Muerte = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LBL_Muertes = New System.Windows.Forms.Label()
        Me.LBL_Contador = New System.Windows.Forms.Label()
        Me.TMR_Segundo = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PNL_Panel.SuspendLayout()
        CType(Me.PCB_Blood, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Demon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Pato, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Pesadilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Ultraviolencia, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TMR_Timer
        '
        Me.TMR_Timer.Interval = 20
        '
        'BTN_Fin
        '
        Me.BTN_Fin.BackColor = System.Drawing.Color.Transparent
        Me.BTN_Fin.BackgroundImage = Global.TiroPato.My.Resources.Resources.Casco
        Me.BTN_Fin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BTN_Fin.FlatAppearance.BorderSize = 0
        Me.BTN_Fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_Fin.ForeColor = System.Drawing.Color.Transparent
        Me.BTN_Fin.Location = New System.Drawing.Point(622, 0)
        Me.BTN_Fin.Name = "BTN_Fin"
        Me.BTN_Fin.Size = New System.Drawing.Size(79, 67)
        Me.BTN_Fin.TabIndex = 3
        Me.BTN_Fin.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = Global.TiroPato.My.Resources.Resources.Inicio
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(270, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(127, 65)
        Me.Button1.TabIndex = 0
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PNL_Panel
        '
        Me.PNL_Panel.BackgroundImage = Global.TiroPato.My.Resources.Resources.Urdak
        Me.PNL_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PNL_Panel.Controls.Add(Me.PCB_Blood)
        Me.PNL_Panel.Controls.Add(Me.PCB_Demon)
        Me.PNL_Panel.Controls.Add(Me.PCB_Pato)
        Me.PNL_Panel.Location = New System.Drawing.Point(0, 67)
        Me.PNL_Panel.Name = "PNL_Panel"
        Me.PNL_Panel.Size = New System.Drawing.Size(700, 300)
        Me.PNL_Panel.TabIndex = 1
        '
        'PCB_Blood
        '
        Me.PCB_Blood.BackColor = System.Drawing.Color.Transparent
        Me.PCB_Blood.Image = Global.TiroPato.My.Resources.Resources.Blood
        Me.PCB_Blood.Location = New System.Drawing.Point(0, 112)
        Me.PCB_Blood.Name = "PCB_Blood"
        Me.PCB_Blood.Size = New System.Drawing.Size(60, 60)
        Me.PCB_Blood.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Blood.TabIndex = 2
        Me.PCB_Blood.TabStop = False
        '
        'PCB_Demon
        '
        Me.PCB_Demon.Image = Global.TiroPato.My.Resources.Resources.Espectro
        Me.PCB_Demon.Location = New System.Drawing.Point(0, 240)
        Me.PCB_Demon.Name = "PCB_Demon"
        Me.PCB_Demon.Size = New System.Drawing.Size(60, 60)
        Me.PCB_Demon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Demon.TabIndex = 1
        Me.PCB_Demon.TabStop = False
        Me.PCB_Demon.Tag = "2"
        '
        'PCB_Pato
        '
        Me.PCB_Pato.BackColor = System.Drawing.Color.Transparent
        Me.PCB_Pato.Image = Global.TiroPato.My.Resources.Resources.Cacodemonio
        Me.PCB_Pato.Location = New System.Drawing.Point(0, 0)
        Me.PCB_Pato.Name = "PCB_Pato"
        Me.PCB_Pato.Size = New System.Drawing.Size(60, 60)
        Me.PCB_Pato.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Pato.TabIndex = 0
        Me.PCB_Pato.TabStop = False
        Me.PCB_Pato.Tag = "1"
        '
        'CHK_Pesadilla
        '
        Me.CHK_Pesadilla.BackColor = System.Drawing.Color.Transparent
        Me.CHK_Pesadilla.BackgroundImage = Global.TiroPato.My.Resources.Resources.Nightmare
        Me.CHK_Pesadilla.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CHK_Pesadilla.FlatAppearance.BorderSize = 0
        Me.CHK_Pesadilla.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CHK_Pesadilla.ForeColor = System.Drawing.Color.White
        Me.CHK_Pesadilla.Location = New System.Drawing.Point(96, 16)
        Me.CHK_Pesadilla.Name = "CHK_Pesadilla"
        Me.CHK_Pesadilla.Size = New System.Drawing.Size(120, 40)
        Me.CHK_Pesadilla.TabIndex = 4
        Me.CHK_Pesadilla.UseVisualStyleBackColor = False
        '
        'PCB_Pesadilla
        '
        Me.PCB_Pesadilla.BackColor = System.Drawing.Color.Transparent
        Me.PCB_Pesadilla.Image = Global.TiroPato.My.Resources.Resources.Pesadilla
        Me.PCB_Pesadilla.Location = New System.Drawing.Point(0, 0)
        Me.PCB_Pesadilla.Name = "PCB_Pesadilla"
        Me.PCB_Pesadilla.Size = New System.Drawing.Size(79, 67)
        Me.PCB_Pesadilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Pesadilla.TabIndex = 2
        Me.PCB_Pesadilla.TabStop = False
        '
        'PCB_Ultraviolencia
        '
        Me.PCB_Ultraviolencia.BackColor = System.Drawing.Color.Transparent
        Me.PCB_Ultraviolencia.Image = Global.TiroPato.My.Resources.Resources.Ultraviolencia
        Me.PCB_Ultraviolencia.Location = New System.Drawing.Point(0, 0)
        Me.PCB_Ultraviolencia.Name = "PCB_Ultraviolencia"
        Me.PCB_Ultraviolencia.Size = New System.Drawing.Size(79, 67)
        Me.PCB_Ultraviolencia.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Ultraviolencia.TabIndex = 5
        Me.PCB_Ultraviolencia.TabStop = False
        '
        'TMR_Juego
        '
        Me.TMR_Juego.Interval = 6000
        '
        'TMR_Muerte
        '
        Me.TMR_Muerte.Interval = 1000
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.TiroPato.My.Resources.Resources.Muertes
        Me.PictureBox1.Location = New System.Drawing.Point(412, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(46, 44)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'LBL_Muertes
        '
        Me.LBL_Muertes.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Muertes.Font = New System.Drawing.Font("Matura MT Script Capitals", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Muertes.ForeColor = System.Drawing.Color.White
        Me.LBL_Muertes.Location = New System.Drawing.Point(464, 17)
        Me.LBL_Muertes.Name = "LBL_Muertes"
        Me.LBL_Muertes.Size = New System.Drawing.Size(51, 35)
        Me.LBL_Muertes.TabIndex = 7
        '
        'LBL_Contador
        '
        Me.LBL_Contador.BackColor = System.Drawing.Color.Transparent
        Me.LBL_Contador.Font = New System.Drawing.Font("Matura MT Script Capitals", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Contador.ForeColor = System.Drawing.Color.White
        Me.LBL_Contador.Location = New System.Drawing.Point(573, 19)
        Me.LBL_Contador.Name = "LBL_Contador"
        Me.LBL_Contador.Size = New System.Drawing.Size(49, 35)
        Me.LBL_Contador.TabIndex = 8
        '
        'TMR_Segundo
        '
        Me.TMR_Segundo.Interval = 1000
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.TiroPato.My.Resources.Resources.Time
        Me.PictureBox2.Location = New System.Drawing.Point(521, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(46, 44)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'TiroAlPato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TiroPato.My.Resources.Resources.Textura
        Me.ClientSize = New System.Drawing.Size(700, 365)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.LBL_Contador)
        Me.Controls.Add(Me.LBL_Muertes)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PCB_Ultraviolencia)
        Me.Controls.Add(Me.PCB_Pesadilla)
        Me.Controls.Add(Me.CHK_Pesadilla)
        Me.Controls.Add(Me.BTN_Fin)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PNL_Panel)
        Me.Name = "TiroAlPato"
        Me.Text = "Tiro Al Pato"
        Me.PNL_Panel.ResumeLayout(False)
        CType(Me.PCB_Blood, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Demon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Pato, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Pesadilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Ultraviolencia, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PNL_Panel As Panel
    Friend WithEvents PCB_Pato As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_Fin As Button
    Friend WithEvents TMR_Timer As Timer
    Friend WithEvents PCB_Demon As PictureBox
    Friend WithEvents CHK_Pesadilla As CheckBox
    Friend WithEvents PCB_Pesadilla As PictureBox
    Friend WithEvents PCB_Ultraviolencia As PictureBox
    Friend WithEvents TMR_Juego As Timer
    Friend WithEvents PCB_Blood As PictureBox
    Friend WithEvents TMR_Muerte As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LBL_Muertes As Label
    Friend WithEvents LBL_Contador As Label
    Friend WithEvents TMR_Segundo As Timer
    Friend WithEvents PictureBox2 As PictureBox
End Class
