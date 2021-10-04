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
        Me.LSB_Catalogo = New System.Windows.Forms.ListBox()
        Me.LSB_Cesta = New System.Windows.Forms.ListBox()
        Me.BTN_Comprar = New System.Windows.Forms.Button()
        Me.BTN_Devolver = New System.Windows.Forms.Button()
        Me.BTN_Deshacer = New System.Windows.Forms.Button()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.LBL_CantidadArticulos = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LSB_Catalogo
        '
        Me.LSB_Catalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSB_Catalogo.FormattingEnabled = True
        Me.LSB_Catalogo.ItemHeight = 20
        Me.LSB_Catalogo.Items.AddRange(New Object() {"Ordenador", "Ratón", "Cargador", "Pantalla", "Móvil"})
        Me.LSB_Catalogo.Location = New System.Drawing.Point(69, 39)
        Me.LSB_Catalogo.Name = "LSB_Catalogo"
        Me.LSB_Catalogo.Size = New System.Drawing.Size(120, 164)
        Me.LSB_Catalogo.TabIndex = 0
        '
        'LSB_Cesta
        '
        Me.LSB_Cesta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LSB_Cesta.FormattingEnabled = True
        Me.LSB_Cesta.ItemHeight = 20
        Me.LSB_Cesta.Location = New System.Drawing.Point(335, 39)
        Me.LSB_Cesta.Name = "LSB_Cesta"
        Me.LSB_Cesta.Size = New System.Drawing.Size(120, 164)
        Me.LSB_Cesta.TabIndex = 1
        '
        'BTN_Comprar
        '
        Me.BTN_Comprar.Location = New System.Drawing.Point(224, 60)
        Me.BTN_Comprar.Name = "BTN_Comprar"
        Me.BTN_Comprar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Comprar.TabIndex = 2
        Me.BTN_Comprar.Text = "COMPRAR"
        Me.BTN_Comprar.UseVisualStyleBackColor = True
        '
        'BTN_Devolver
        '
        Me.BTN_Devolver.Location = New System.Drawing.Point(224, 106)
        Me.BTN_Devolver.Name = "BTN_Devolver"
        Me.BTN_Devolver.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Devolver.TabIndex = 3
        Me.BTN_Devolver.Text = "DEVOLVER"
        Me.BTN_Devolver.UseVisualStyleBackColor = True
        '
        'BTN_Deshacer
        '
        Me.BTN_Deshacer.Location = New System.Drawing.Point(224, 153)
        Me.BTN_Deshacer.Name = "BTN_Deshacer"
        Me.BTN_Deshacer.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Deshacer.TabIndex = 4
        Me.BTN_Deshacer.Tag = " "
        Me.BTN_Deshacer.Text = "DESHACER"
        Me.BTN_Deshacer.UseVisualStyleBackColor = True
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(12, 254)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 5
        Me.BTN_Salir.Tag = " "
        Me.BTN_Salir.Text = " SALIR"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'LBL_CantidadArticulos
        '
        Me.LBL_CantidadArticulos.AutoSize = True
        Me.LBL_CantidadArticulos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_CantidadArticulos.Location = New System.Drawing.Point(335, 240)
        Me.LBL_CantidadArticulos.Name = "LBL_CantidadArticulos"
        Me.LBL_CantidadArticulos.Size = New System.Drawing.Size(13, 20)
        Me.LBL_CantidadArticulos.TabIndex = 6
        Me.LBL_CantidadArticulos.Text = " "
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(597, 307)
        Me.Controls.Add(Me.LBL_CantidadArticulos)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Deshacer)
        Me.Controls.Add(Me.BTN_Devolver)
        Me.Controls.Add(Me.BTN_Comprar)
        Me.Controls.Add(Me.LSB_Cesta)
        Me.Controls.Add(Me.LSB_Catalogo)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LSB_Catalogo As ListBox
    Friend WithEvents LSB_Cesta As ListBox
    Friend WithEvents BTN_Comprar As Button
    Friend WithEvents BTN_Devolver As Button
    Friend WithEvents BTN_Deshacer As Button
    Friend WithEvents BTN_Salir As Button
    Friend WithEvents LBL_CantidadArticulos As Label
End Class
