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
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.LBL_Suma = New System.Windows.Forms.Label()
        Me.TXT_NumRes = New System.Windows.Forms.TextBox()
        Me.BTN_Revisar = New System.Windows.Forms.Button()
        Me.BTN_OtraSuma = New System.Windows.Forms.Button()
        Me.LBL_Total = New System.Windows.Forms.Label()
        Me.LBL_Barra = New System.Windows.Forms.Label()
        Me.LBL_Revisar = New System.Windows.Forms.Label()
        Me.TXT_Num1 = New System.Windows.Forms.TextBox()
        Me.TXT_Num2 = New System.Windows.Forms.TextBox()
        Me.PCB_Bien = New System.Windows.Forms.PictureBox()
        Me.TXT_Estado = New System.Windows.Forms.TextBox()
        Me.PCB_Mal = New System.Windows.Forms.PictureBox()
        CType(Me.PCB_Bien, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCB_Mal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(12, 12)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 11
        Me.BTN_Salir.Text = "Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'LBL_Suma
        '
        Me.LBL_Suma.AutoSize = True
        Me.LBL_Suma.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Suma.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LBL_Suma.Location = New System.Drawing.Point(49, 41)
        Me.LBL_Suma.Name = "LBL_Suma"
        Me.LBL_Suma.Size = New System.Drawing.Size(90, 76)
        Me.LBL_Suma.TabIndex = 1
        Me.LBL_Suma.Text = " +"
        '
        'TXT_NumRes
        '
        Me.TXT_NumRes.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_NumRes.Location = New System.Drawing.Point(130, 169)
        Me.TXT_NumRes.Name = "TXT_NumRes"
        Me.TXT_NumRes.Size = New System.Drawing.Size(46, 45)
        Me.TXT_NumRes.TabIndex = 0
        Me.TXT_NumRes.Text = " "
        '
        'BTN_Revisar
        '
        Me.BTN_Revisar.Location = New System.Drawing.Point(117, 226)
        Me.BTN_Revisar.Name = "BTN_Revisar"
        Me.BTN_Revisar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Revisar.TabIndex = 1
        Me.BTN_Revisar.Text = " Revisar"
        Me.BTN_Revisar.UseVisualStyleBackColor = True
        '
        'BTN_OtraSuma
        '
        Me.BTN_OtraSuma.Location = New System.Drawing.Point(268, 24)
        Me.BTN_OtraSuma.Name = "BTN_OtraSuma"
        Me.BTN_OtraSuma.Size = New System.Drawing.Size(75, 23)
        Me.BTN_OtraSuma.TabIndex = 2
        Me.BTN_OtraSuma.Text = " Otra Suma"
        Me.BTN_OtraSuma.UseVisualStyleBackColor = True
        '
        'LBL_Total
        '
        Me.LBL_Total.AutoSize = True
        Me.LBL_Total.Location = New System.Drawing.Point(12, 186)
        Me.LBL_Total.Name = "LBL_Total"
        Me.LBL_Total.Size = New System.Drawing.Size(95, 13)
        Me.LBL_Total.TabIndex = 5
        Me.LBL_Total.Text = " Escribe el Total ->"
        '
        'LBL_Barra
        '
        Me.LBL_Barra.AutoSize = True
        Me.LBL_Barra.Font = New System.Drawing.Font("Microsoft Sans Serif", 50.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Barra.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.LBL_Barra.Location = New System.Drawing.Point(46, 83)
        Me.LBL_Barra.Name = "LBL_Barra"
        Me.LBL_Barra.Size = New System.Drawing.Size(199, 76)
        Me.LBL_Barra.TabIndex = 6
        Me.LBL_Barra.Text = " ____"
        '
        'LBL_Revisar
        '
        Me.LBL_Revisar.AutoSize = True
        Me.LBL_Revisar.Location = New System.Drawing.Point(12, 231)
        Me.LBL_Revisar.Name = "LBL_Revisar"
        Me.LBL_Revisar.Size = New System.Drawing.Size(99, 13)
        Me.LBL_Revisar.TabIndex = 7
        Me.LBL_Revisar.Text = " Click en Revisar ->"
        '
        'TXT_Num1
        '
        Me.TXT_Num1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Num1.Location = New System.Drawing.Point(130, 24)
        Me.TXT_Num1.Name = "TXT_Num1"
        Me.TXT_Num1.ReadOnly = True
        Me.TXT_Num1.Size = New System.Drawing.Size(46, 45)
        Me.TXT_Num1.TabIndex = 8
        Me.TXT_Num1.TabStop = False
        Me.TXT_Num1.Text = " "
        '
        'TXT_Num2
        '
        Me.TXT_Num2.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Num2.Location = New System.Drawing.Point(130, 92)
        Me.TXT_Num2.Name = "TXT_Num2"
        Me.TXT_Num2.ReadOnly = True
        Me.TXT_Num2.Size = New System.Drawing.Size(46, 45)
        Me.TXT_Num2.TabIndex = 9
        Me.TXT_Num2.TabStop = False
        '
        'PCB_Bien
        '
        Me.PCB_Bien.Image = CType(resources.GetObject("PCB_Bien.Image"), System.Drawing.Image)
        Me.PCB_Bien.Location = New System.Drawing.Point(240, 64)
        Me.PCB_Bien.Name = "PCB_Bien"
        Me.PCB_Bien.Size = New System.Drawing.Size(120, 112)
        Me.PCB_Bien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Bien.TabIndex = 10
        Me.PCB_Bien.TabStop = False
        Me.PCB_Bien.Visible = False
        '
        'TXT_Estado
        '
        Me.TXT_Estado.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TXT_Estado.Location = New System.Drawing.Point(240, 219)
        Me.TXT_Estado.Name = "TXT_Estado"
        Me.TXT_Estado.ReadOnly = True
        Me.TXT_Estado.Size = New System.Drawing.Size(120, 30)
        Me.TXT_Estado.TabIndex = 11
        Me.TXT_Estado.TabStop = False
        '
        'PCB_Mal
        '
        Me.PCB_Mal.Image = CType(resources.GetObject("PCB_Mal.Image"), System.Drawing.Image)
        Me.PCB_Mal.Location = New System.Drawing.Point(240, 64)
        Me.PCB_Mal.Name = "PCB_Mal"
        Me.PCB_Mal.Size = New System.Drawing.Size(120, 112)
        Me.PCB_Mal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PCB_Mal.TabIndex = 12
        Me.PCB_Mal.TabStop = False
        Me.PCB_Mal.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 280)
        Me.Controls.Add(Me.PCB_Mal)
        Me.Controls.Add(Me.TXT_Estado)
        Me.Controls.Add(Me.PCB_Bien)
        Me.Controls.Add(Me.TXT_Num2)
        Me.Controls.Add(Me.TXT_Num1)
        Me.Controls.Add(Me.LBL_Revisar)
        Me.Controls.Add(Me.LBL_Total)
        Me.Controls.Add(Me.BTN_OtraSuma)
        Me.Controls.Add(Me.BTN_Revisar)
        Me.Controls.Add(Me.TXT_NumRes)
        Me.Controls.Add(Me.LBL_Suma)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.LBL_Barra)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PCB_Bien, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCB_Mal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_Salir As Button
    Friend WithEvents LBL_Suma As Label
    Friend WithEvents TXT_NumRes As TextBox
    Friend WithEvents BTN_Revisar As Button
    Friend WithEvents BTN_OtraSuma As Button
    Friend WithEvents LBL_Total As Label
    Friend WithEvents LBL_Barra As Label
    Friend WithEvents LBL_Revisar As Label
    Friend WithEvents TXT_Num1 As TextBox
    Friend WithEvents TXT_Num2 As TextBox
    Friend WithEvents PCB_Bien As PictureBox
    Friend WithEvents TXT_Estado As TextBox
    Friend WithEvents PCB_Mal As PictureBox
End Class
