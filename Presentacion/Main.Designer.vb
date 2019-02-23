<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Main
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.limpiar = New System.Windows.Forms.Button()
        Me.campo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.mensaje = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.generarDigito = New System.Windows.Forms.Button()
        Me.Salir = New System.Windows.Forms.Button()
        Me.generar = New System.Windows.Forms.Button()
        Me.Verif = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DarkGray
        Me.Panel1.Controls.Add(Me.limpiar)
        Me.Panel1.Controls.Add(Me.campo)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.mensaje)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(234, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(961, 606)
        Me.Panel1.TabIndex = 2
        '
        'limpiar
        '
        Me.limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.limpiar.Location = New System.Drawing.Point(883, 580)
        Me.limpiar.Name = "limpiar"
        Me.limpiar.Size = New System.Drawing.Size(75, 23)
        Me.limpiar.TabIndex = 3
        Me.limpiar.Text = "Limpiar"
        Me.limpiar.UseVisualStyleBackColor = True
        '
        'campo
        '
        Me.campo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.campo.Location = New System.Drawing.Point(9, 23)
        Me.campo.Name = "campo"
        Me.campo.Size = New System.Drawing.Size(943, 20)
        Me.campo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(8, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(191, 20)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Campo de cédula (sólo números): "
        '
        'mensaje
        '
        Me.mensaje.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mensaje.ForeColor = System.Drawing.Color.Red
        Me.mensaje.Location = New System.Drawing.Point(847, 46)
        Me.mensaje.Name = "mensaje"
        Me.mensaje.Size = New System.Drawing.Size(105, 19)
        Me.mensaje.TabIndex = 1
        Me.mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Panel2
        '
        Me.Panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.Panel2.BackColor = System.Drawing.Color.Navy
        Me.Panel2.Controls.Add(Me.generarDigito)
        Me.Panel2.Controls.Add(Me.Salir)
        Me.Panel2.Controls.Add(Me.generar)
        Me.Panel2.Controls.Add(Me.Verif)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 606)
        Me.Panel2.TabIndex = 0
        '
        'generarDigito
        '
        Me.generarDigito.BackColor = System.Drawing.Color.MidnightBlue
        Me.generarDigito.Dock = System.Windows.Forms.DockStyle.Top
        Me.generarDigito.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.generarDigito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generarDigito.ForeColor = System.Drawing.Color.White
        Me.generarDigito.Location = New System.Drawing.Point(0, 108)
        Me.generarDigito.Name = "generarDigito"
        Me.generarDigito.Size = New System.Drawing.Size(234, 54)
        Me.generarDigito.TabIndex = 3
        Me.generarDigito.Text = "Generar Dígito Verificador"
        Me.generarDigito.UseVisualStyleBackColor = False
        '
        'Salir
        '
        Me.Salir.BackColor = System.Drawing.Color.MidnightBlue
        Me.Salir.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Salir.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Salir.ForeColor = System.Drawing.Color.White
        Me.Salir.Location = New System.Drawing.Point(0, 519)
        Me.Salir.Name = "Salir"
        Me.Salir.Size = New System.Drawing.Size(234, 87)
        Me.Salir.TabIndex = 2
        Me.Salir.Text = "Salir"
        Me.Salir.UseVisualStyleBackColor = False
        '
        'generar
        '
        Me.generar.AutoSize = True
        Me.generar.BackColor = System.Drawing.Color.MidnightBlue
        Me.generar.Dock = System.Windows.Forms.DockStyle.Top
        Me.generar.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.generar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.generar.ForeColor = System.Drawing.Color.White
        Me.generar.Location = New System.Drawing.Point(0, 54)
        Me.generar.Name = "generar"
        Me.generar.Size = New System.Drawing.Size(234, 54)
        Me.generar.TabIndex = 1
        Me.generar.Text = "Generar Cédula Aleatoria"
        Me.generar.UseVisualStyleBackColor = False
        '
        'Verif
        '
        Me.Verif.BackColor = System.Drawing.Color.MidnightBlue
        Me.Verif.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.Verif.Dock = System.Windows.Forms.DockStyle.Top
        Me.Verif.FlatAppearance.BorderColor = System.Drawing.Color.MidnightBlue
        Me.Verif.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Verif.ForeColor = System.Drawing.Color.White
        Me.Verif.Location = New System.Drawing.Point(0, 0)
        Me.Verif.Name = "Verif"
        Me.Verif.Size = New System.Drawing.Size(234, 54)
        Me.Verif.TabIndex = 0
        Me.Verif.Text = "Verificar Cédula"
        Me.Verif.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AccessibleName = "Ventana"
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1195, 606)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Main"
        Me.Text = "Utilidad de cédulas Uruguayas"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents generar As Button
    Friend WithEvents Verif As Button
    Friend WithEvents Salir As Button
    Friend WithEvents campo As TextBox
    Friend WithEvents mensaje As Label
    Friend WithEvents generarDigito As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents limpiar As Button
End Class
