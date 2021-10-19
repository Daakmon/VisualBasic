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
        Me.GRB_Categoria = New System.Windows.Forms.GroupBox()
        Me.RDB_Jubilado = New System.Windows.Forms.RadioButton()
        Me.RDB_Familiar = New System.Windows.Forms.RadioButton()
        Me.RDB_Ninio = New System.Windows.Forms.RadioButton()
        Me.GRB_Tipo = New System.Windows.Forms.GroupBox()
        Me.CHK_FamilyBig = New System.Windows.Forms.CheckBox()
        Me.CHK_Discapacidad = New System.Windows.Forms.CheckBox()
        Me.CMB_Anio = New System.Windows.Forms.ComboBox()
        Me.LBL_Precio = New System.Windows.Forms.Label()
        Me.BTN_Des = New System.Windows.Forms.Button()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.GRB_Categoria.SuspendLayout()
        Me.GRB_Tipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'GRB_Categoria
        '
        Me.GRB_Categoria.Controls.Add(Me.RDB_Jubilado)
        Me.GRB_Categoria.Controls.Add(Me.RDB_Familiar)
        Me.GRB_Categoria.Controls.Add(Me.RDB_Ninio)
        Me.GRB_Categoria.Location = New System.Drawing.Point(63, 41)
        Me.GRB_Categoria.Name = "GRB_Categoria"
        Me.GRB_Categoria.Size = New System.Drawing.Size(200, 157)
        Me.GRB_Categoria.TabIndex = 1
        Me.GRB_Categoria.TabStop = False
        Me.GRB_Categoria.Text = " Categoría"
        '
        'RDB_Jubilado
        '
        Me.RDB_Jubilado.AutoSize = True
        Me.RDB_Jubilado.Location = New System.Drawing.Point(18, 106)
        Me.RDB_Jubilado.Name = "RDB_Jubilado"
        Me.RDB_Jubilado.Size = New System.Drawing.Size(67, 17)
        Me.RDB_Jubilado.TabIndex = 4
        Me.RDB_Jubilado.TabStop = True
        Me.RDB_Jubilado.Text = " Jubilado"
        Me.RDB_Jubilado.UseVisualStyleBackColor = True
        '
        'RDB_Familiar
        '
        Me.RDB_Familiar.AutoSize = True
        Me.RDB_Familiar.Location = New System.Drawing.Point(18, 70)
        Me.RDB_Familiar.Name = "RDB_Familiar"
        Me.RDB_Familiar.Size = New System.Drawing.Size(63, 17)
        Me.RDB_Familiar.TabIndex = 3
        Me.RDB_Familiar.TabStop = True
        Me.RDB_Familiar.Text = " Familiar"
        Me.RDB_Familiar.UseVisualStyleBackColor = True
        '
        'RDB_Ninio
        '
        Me.RDB_Ninio.AutoSize = True
        Me.RDB_Ninio.Location = New System.Drawing.Point(18, 32)
        Me.RDB_Ninio.Name = "RDB_Ninio"
        Me.RDB_Ninio.Size = New System.Drawing.Size(50, 17)
        Me.RDB_Ninio.TabIndex = 2
        Me.RDB_Ninio.TabStop = True
        Me.RDB_Ninio.Text = " Niño"
        Me.RDB_Ninio.UseVisualStyleBackColor = True
        '
        'GRB_Tipo
        '
        Me.GRB_Tipo.Controls.Add(Me.CHK_FamilyBig)
        Me.GRB_Tipo.Controls.Add(Me.CHK_Discapacidad)
        Me.GRB_Tipo.Location = New System.Drawing.Point(335, 41)
        Me.GRB_Tipo.Name = "GRB_Tipo"
        Me.GRB_Tipo.Size = New System.Drawing.Size(200, 157)
        Me.GRB_Tipo.TabIndex = 5
        Me.GRB_Tipo.TabStop = False
        Me.GRB_Tipo.Text = "Tipo"
        '
        'CHK_FamilyBig
        '
        Me.CHK_FamilyBig.AutoSize = True
        Me.CHK_FamilyBig.Location = New System.Drawing.Point(18, 71)
        Me.CHK_FamilyBig.Name = "CHK_FamilyBig"
        Me.CHK_FamilyBig.Size = New System.Drawing.Size(112, 17)
        Me.CHK_FamilyBig.TabIndex = 1
        Me.CHK_FamilyBig.Text = " Familia Numerosa"
        Me.CHK_FamilyBig.UseVisualStyleBackColor = True
        '
        'CHK_Discapacidad
        '
        Me.CHK_Discapacidad.AutoSize = True
        Me.CHK_Discapacidad.Location = New System.Drawing.Point(18, 32)
        Me.CHK_Discapacidad.Name = "CHK_Discapacidad"
        Me.CHK_Discapacidad.Size = New System.Drawing.Size(94, 17)
        Me.CHK_Discapacidad.TabIndex = 0
        Me.CHK_Discapacidad.Text = " Discapacidad"
        Me.CHK_Discapacidad.UseVisualStyleBackColor = True
        '
        'CMB_Anio
        '
        Me.CMB_Anio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CMB_Anio.FormattingEnabled = True
        Me.CMB_Anio.Items.AddRange(New Object() {"Día", "Mes", "Año"})
        Me.CMB_Anio.Location = New System.Drawing.Point(611, 41)
        Me.CMB_Anio.Name = "CMB_Anio"
        Me.CMB_Anio.Size = New System.Drawing.Size(121, 21)
        Me.CMB_Anio.TabIndex = 6
        '
        'LBL_Precio
        '
        Me.LBL_Precio.AutoSize = True
        Me.LBL_Precio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBL_Precio.Location = New System.Drawing.Point(642, 166)
        Me.LBL_Precio.Name = "LBL_Precio"
        Me.LBL_Precio.Size = New System.Drawing.Size(58, 20)
        Me.LBL_Precio.TabIndex = 7
        Me.LBL_Precio.Text = "000.00"
        '
        'BTN_Des
        '
        Me.BTN_Des.Location = New System.Drawing.Point(634, 231)
        Me.BTN_Des.Name = "BTN_Des"
        Me.BTN_Des.Size = New System.Drawing.Size(98, 32)
        Me.BTN_Des.TabIndex = 9
        Me.BTN_Des.Text = " Deshacer"
        Me.BTN_Des.UseVisualStyleBackColor = True
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(634, 269)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(98, 32)
        Me.BTN_Salir.TabIndex = 10
        Me.BTN_Salir.Text = " Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 327)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.BTN_Des)
        Me.Controls.Add(Me.LBL_Precio)
        Me.Controls.Add(Me.CMB_Anio)
        Me.Controls.Add(Me.GRB_Tipo)
        Me.Controls.Add(Me.GRB_Categoria)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GRB_Categoria.ResumeLayout(False)
        Me.GRB_Categoria.PerformLayout()
        Me.GRB_Tipo.ResumeLayout(False)
        Me.GRB_Tipo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GRB_Categoria As GroupBox
    Friend WithEvents RDB_Jubilado As RadioButton
    Friend WithEvents RDB_Familiar As RadioButton
    Friend WithEvents RDB_Ninio As RadioButton
    Friend WithEvents GRB_Tipo As GroupBox
    Friend WithEvents CHK_FamilyBig As CheckBox
    Friend WithEvents CHK_Discapacidad As CheckBox
    Friend WithEvents CMB_Anio As ComboBox
    Friend WithEvents LBL_Precio As Label
    Friend WithEvents BTN_Des As Button
    Friend WithEvents BTN_Salir As Button
End Class
