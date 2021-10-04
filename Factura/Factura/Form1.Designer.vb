<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FRM_Factura
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
        Me.TXT_Cantidad = New System.Windows.Forms.TextBox()
        Me.LBL_Cantidad = New System.Windows.Forms.Label()
        Me.LBL_Precio = New System.Windows.Forms.Label()
        Me.TXT_Precio = New System.Windows.Forms.TextBox()
        Me.LBL_Importe = New System.Windows.Forms.Label()
        Me.TXT_Importe = New System.Windows.Forms.TextBox()
        Me.LBL_DesCantidad = New System.Windows.Forms.Label()
        Me.TXT_DesCantidadPorc = New System.Windows.Forms.TextBox()
        Me.LBL_DesCantidadImporte = New System.Windows.Forms.Label()
        Me.TXT_DesCantidadImporte = New System.Windows.Forms.TextBox()
        Me.TXT_DesIVAPorc = New System.Windows.Forms.TextBox()
        Me.LBL_DesIVAImporte = New System.Windows.Forms.Label()
        Me.TXT_DesIVAImporte = New System.Windows.Forms.TextBox()
        Me.LBL_TotalImporte = New System.Windows.Forms.Label()
        Me.TXT_TotalImporte = New System.Windows.Forms.TextBox()
        Me.BTN_Salir = New System.Windows.Forms.Button()
        Me.BTN_Calcular = New System.Windows.Forms.Button()
        Me.CHK_ClientePrioritario = New System.Windows.Forms.CheckBox()
        Me.LBL_ClientePrioritario = New System.Windows.Forms.Label()
        Me.LBL_DesCantidadPorc = New System.Windows.Forms.Label()
        Me.LBL_DesIVAPorc = New System.Windows.Forms.Label()
        Me.LBL_IVA = New System.Windows.Forms.Label()
        Me.TXT_DesClientePrioritarioImporte = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TXT_Cantidad
        '
        Me.TXT_Cantidad.Location = New System.Drawing.Point(96, 20)
        Me.TXT_Cantidad.Name = "TXT_Cantidad"
        Me.TXT_Cantidad.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Cantidad.TabIndex = 0
        '
        'LBL_Cantidad
        '
        Me.LBL_Cantidad.AutoSize = True
        Me.LBL_Cantidad.Location = New System.Drawing.Point(28, 23)
        Me.LBL_Cantidad.Name = "LBL_Cantidad"
        Me.LBL_Cantidad.Size = New System.Drawing.Size(62, 13)
        Me.LBL_Cantidad.TabIndex = 1
        Me.LBL_Cantidad.Text = "CANTIDAD"
        '
        'LBL_Precio
        '
        Me.LBL_Precio.AutoSize = True
        Me.LBL_Precio.Location = New System.Drawing.Point(56, 49)
        Me.LBL_Precio.Name = "LBL_Precio"
        Me.LBL_Precio.Size = New System.Drawing.Size(34, 13)
        Me.LBL_Precio.TabIndex = 3
        Me.LBL_Precio.Text = "P.V.P"
        '
        'TXT_Precio
        '
        Me.TXT_Precio.Location = New System.Drawing.Point(96, 46)
        Me.TXT_Precio.Name = "TXT_Precio"
        Me.TXT_Precio.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Precio.TabIndex = 2
        '
        'LBL_Importe
        '
        Me.LBL_Importe.AutoSize = True
        Me.LBL_Importe.Location = New System.Drawing.Point(45, 81)
        Me.LBL_Importe.Name = "LBL_Importe"
        Me.LBL_Importe.Size = New System.Drawing.Size(45, 13)
        Me.LBL_Importe.TabIndex = 5
        Me.LBL_Importe.Text = " TOTAL"
        '
        'TXT_Importe
        '
        Me.TXT_Importe.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_Importe.Location = New System.Drawing.Point(96, 78)
        Me.TXT_Importe.Name = "TXT_Importe"
        Me.TXT_Importe.ReadOnly = True
        Me.TXT_Importe.Size = New System.Drawing.Size(100, 20)
        Me.TXT_Importe.TabIndex = 4
        '
        'LBL_DesCantidad
        '
        Me.LBL_DesCantidad.AutoSize = True
        Me.LBL_DesCantidad.Location = New System.Drawing.Point(93, 115)
        Me.LBL_DesCantidad.Name = "LBL_DesCantidad"
        Me.LBL_DesCantidad.Size = New System.Drawing.Size(132, 13)
        Me.LBL_DesCantidad.TabIndex = 7
        Me.LBL_DesCantidad.Text = "DESCUENTO CNATIDAD"
        '
        'TXT_DesCantidadPorc
        '
        Me.TXT_DesCantidadPorc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_DesCantidadPorc.Location = New System.Drawing.Point(55, 141)
        Me.TXT_DesCantidadPorc.Name = "TXT_DesCantidadPorc"
        Me.TXT_DesCantidadPorc.ReadOnly = True
        Me.TXT_DesCantidadPorc.Size = New System.Drawing.Size(100, 20)
        Me.TXT_DesCantidadPorc.TabIndex = 6
        '
        'LBL_DesCantidadImporte
        '
        Me.LBL_DesCantidadImporte.AutoSize = True
        Me.LBL_DesCantidadImporte.Location = New System.Drawing.Point(192, 144)
        Me.LBL_DesCantidadImporte.Name = "LBL_DesCantidadImporte"
        Me.LBL_DesCantidadImporte.Size = New System.Drawing.Size(59, 13)
        Me.LBL_DesCantidadImporte.TabIndex = 9
        Me.LBL_DesCantidadImporte.Text = " IMPORTE"
        '
        'TXT_DesCantidadImporte
        '
        Me.TXT_DesCantidadImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_DesCantidadImporte.Location = New System.Drawing.Point(257, 141)
        Me.TXT_DesCantidadImporte.Name = "TXT_DesCantidadImporte"
        Me.TXT_DesCantidadImporte.ReadOnly = True
        Me.TXT_DesCantidadImporte.Size = New System.Drawing.Size(100, 20)
        Me.TXT_DesCantidadImporte.TabIndex = 8
        '
        'TXT_DesIVAPorc
        '
        Me.TXT_DesIVAPorc.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_DesIVAPorc.Location = New System.Drawing.Point(55, 225)
        Me.TXT_DesIVAPorc.Name = "TXT_DesIVAPorc"
        Me.TXT_DesIVAPorc.ReadOnly = True
        Me.TXT_DesIVAPorc.Size = New System.Drawing.Size(100, 20)
        Me.TXT_DesIVAPorc.TabIndex = 10
        '
        'LBL_DesIVAImporte
        '
        Me.LBL_DesIVAImporte.AutoSize = True
        Me.LBL_DesIVAImporte.Location = New System.Drawing.Point(192, 228)
        Me.LBL_DesIVAImporte.Name = "LBL_DesIVAImporte"
        Me.LBL_DesIVAImporte.Size = New System.Drawing.Size(59, 13)
        Me.LBL_DesIVAImporte.TabIndex = 13
        Me.LBL_DesIVAImporte.Text = " IMPORTE"
        '
        'TXT_DesIVAImporte
        '
        Me.TXT_DesIVAImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_DesIVAImporte.Location = New System.Drawing.Point(257, 225)
        Me.TXT_DesIVAImporte.Name = "TXT_DesIVAImporte"
        Me.TXT_DesIVAImporte.ReadOnly = True
        Me.TXT_DesIVAImporte.Size = New System.Drawing.Size(100, 20)
        Me.TXT_DesIVAImporte.TabIndex = 12
        '
        'LBL_TotalImporte
        '
        Me.LBL_TotalImporte.AutoSize = True
        Me.LBL_TotalImporte.Location = New System.Drawing.Point(93, 258)
        Me.LBL_TotalImporte.Name = "LBL_TotalImporte"
        Me.LBL_TotalImporte.Size = New System.Drawing.Size(97, 13)
        Me.LBL_TotalImporte.TabIndex = 15
        Me.LBL_TotalImporte.Text = " TOTAL IMPORTE"
        '
        'TXT_TotalImporte
        '
        Me.TXT_TotalImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_TotalImporte.Location = New System.Drawing.Point(96, 279)
        Me.TXT_TotalImporte.Name = "TXT_TotalImporte"
        Me.TXT_TotalImporte.ReadOnly = True
        Me.TXT_TotalImporte.Size = New System.Drawing.Size(100, 20)
        Me.TXT_TotalImporte.TabIndex = 14
        '
        'BTN_Salir
        '
        Me.BTN_Salir.Location = New System.Drawing.Point(495, 292)
        Me.BTN_Salir.Name = "BTN_Salir"
        Me.BTN_Salir.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Salir.TabIndex = 16
        Me.BTN_Salir.Text = " Salir"
        Me.BTN_Salir.UseVisualStyleBackColor = True
        '
        'BTN_Calcular
        '
        Me.BTN_Calcular.Location = New System.Drawing.Point(405, 292)
        Me.BTN_Calcular.Name = "BTN_Calcular"
        Me.BTN_Calcular.Size = New System.Drawing.Size(75, 23)
        Me.BTN_Calcular.TabIndex = 17
        Me.BTN_Calcular.Text = " Calcular"
        Me.BTN_Calcular.UseVisualStyleBackColor = True
        '
        'CHK_ClientePrioritario
        '
        Me.CHK_ClientePrioritario.AutoSize = True
        Me.CHK_ClientePrioritario.Location = New System.Drawing.Point(73, 173)
        Me.CHK_ClientePrioritario.Name = "CHK_ClientePrioritario"
        Me.CHK_ClientePrioritario.Size = New System.Drawing.Size(29, 17)
        Me.CHK_ClientePrioritario.TabIndex = 18
        Me.CHK_ClientePrioritario.Text = " "
        Me.CHK_ClientePrioritario.UseVisualStyleBackColor = True
        '
        'LBL_ClientePrioritario
        '
        Me.LBL_ClientePrioritario.AutoSize = True
        Me.LBL_ClientePrioritario.Location = New System.Drawing.Point(93, 174)
        Me.LBL_ClientePrioritario.Name = "LBL_ClientePrioritario"
        Me.LBL_ClientePrioritario.Size = New System.Drawing.Size(157, 13)
        Me.LBL_ClientePrioritario.TabIndex = 19
        Me.LBL_ClientePrioritario.Text = " CLIENTE PRIORITARIO (10%)"
        '
        'LBL_DesCantidadPorc
        '
        Me.LBL_DesCantidadPorc.AutoSize = True
        Me.LBL_DesCantidadPorc.Location = New System.Drawing.Point(31, 144)
        Me.LBL_DesCantidadPorc.Name = "LBL_DesCantidadPorc"
        Me.LBL_DesCantidadPorc.Size = New System.Drawing.Size(18, 13)
        Me.LBL_DesCantidadPorc.TabIndex = 20
        Me.LBL_DesCantidadPorc.Text = " %"
        '
        'LBL_DesIVAPorc
        '
        Me.LBL_DesIVAPorc.AutoSize = True
        Me.LBL_DesIVAPorc.Location = New System.Drawing.Point(31, 228)
        Me.LBL_DesIVAPorc.Name = "LBL_DesIVAPorc"
        Me.LBL_DesIVAPorc.Size = New System.Drawing.Size(18, 13)
        Me.LBL_DesIVAPorc.TabIndex = 11
        Me.LBL_DesIVAPorc.Text = " %"
        '
        'LBL_IVA
        '
        Me.LBL_IVA.AutoSize = True
        Me.LBL_IVA.Location = New System.Drawing.Point(156, 198)
        Me.LBL_IVA.Name = "LBL_IVA"
        Me.LBL_IVA.Size = New System.Drawing.Size(27, 13)
        Me.LBL_IVA.TabIndex = 21
        Me.LBL_IVA.Text = " IVA"
        '
        'TXT_DesClientePrioritarioImporte
        '
        Me.TXT_DesClientePrioritarioImporte.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TXT_DesClientePrioritarioImporte.Location = New System.Drawing.Point(257, 174)
        Me.TXT_DesClientePrioritarioImporte.Name = "TXT_DesClientePrioritarioImporte"
        Me.TXT_DesClientePrioritarioImporte.ReadOnly = True
        Me.TXT_DesClientePrioritarioImporte.Size = New System.Drawing.Size(100, 20)
        Me.TXT_DesClientePrioritarioImporte.TabIndex = 22
        '
        'FRM_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(585, 327)
        Me.Controls.Add(Me.TXT_DesClientePrioritarioImporte)
        Me.Controls.Add(Me.LBL_IVA)
        Me.Controls.Add(Me.LBL_DesCantidadPorc)
        Me.Controls.Add(Me.LBL_ClientePrioritario)
        Me.Controls.Add(Me.CHK_ClientePrioritario)
        Me.Controls.Add(Me.BTN_Calcular)
        Me.Controls.Add(Me.BTN_Salir)
        Me.Controls.Add(Me.LBL_TotalImporte)
        Me.Controls.Add(Me.TXT_TotalImporte)
        Me.Controls.Add(Me.LBL_DesIVAImporte)
        Me.Controls.Add(Me.TXT_DesIVAImporte)
        Me.Controls.Add(Me.LBL_DesIVAPorc)
        Me.Controls.Add(Me.TXT_DesIVAPorc)
        Me.Controls.Add(Me.LBL_DesCantidadImporte)
        Me.Controls.Add(Me.TXT_DesCantidadImporte)
        Me.Controls.Add(Me.LBL_DesCantidad)
        Me.Controls.Add(Me.TXT_DesCantidadPorc)
        Me.Controls.Add(Me.LBL_Importe)
        Me.Controls.Add(Me.TXT_Importe)
        Me.Controls.Add(Me.LBL_Precio)
        Me.Controls.Add(Me.TXT_Precio)
        Me.Controls.Add(Me.LBL_Cantidad)
        Me.Controls.Add(Me.TXT_Cantidad)
        Me.Name = "FRM_Factura"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_Cantidad As TextBox
    Friend WithEvents LBL_Cantidad As Label
    Friend WithEvents LBL_Precio As Label
    Friend WithEvents TXT_Precio As TextBox
    Friend WithEvents LBL_Importe As Label
    Friend WithEvents TXT_Importe As TextBox
    Friend WithEvents LBL_DesCantidad As Label
    Friend WithEvents TXT_DesCantidadPorc As TextBox
    Friend WithEvents LBL_DesCantidadImporte As Label
    Friend WithEvents TXT_DesCantidadImporte As TextBox
    Friend WithEvents TXT_DesIVAPorc As TextBox
    Friend WithEvents LBL_DesIVAImporte As Label
    Friend WithEvents TXT_DesIVAImporte As TextBox
    Friend WithEvents LBL_TotalImporte As Label
    Friend WithEvents TXT_TotalImporte As TextBox
    Friend WithEvents BTN_Salir As Button
    Friend WithEvents BTN_Calcular As Button
    Friend WithEvents CHK_ClientePrioritario As CheckBox
    Friend WithEvents LBL_ClientePrioritario As Label
    Friend WithEvents LBL_DesCantidadPorc As Label
    Friend WithEvents LBL_DesIVAPorc As Label
    Friend WithEvents LBL_IVA As Label
    Friend WithEvents TXT_DesClientePrioritarioImporte As TextBox
End Class
