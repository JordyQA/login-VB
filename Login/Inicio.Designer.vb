<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
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
        Label1 = New Label()
        MenuStrip1 = New MenuStrip()
        Label2 = New Label()
        Label3 = New Label()
        btnSalirLogin = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(223, 193)
        Label1.Name = "Label1"
        Label1.Size = New Size(142, 20)
        Label1.TabIndex = 0
        Label1.Text = "Formulario de Inicio"
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.AutoSize = False
        MenuStrip1.BackColor = Color.DodgerBlue
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 64)
        MenuStrip1.TabIndex = 1
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(205, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(53, 20)
        Label2.TabIndex = 2
        Label2.Text = "Label2"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Italic, GraphicsUnit.Point)
        Label3.Location = New Point(21, 90)
        Label3.Name = "Label3"
        Label3.Size = New Size(779, 38)
        Label3.TabIndex = 3
        Label3.Text = "SISTEMAS DE REFORZAMIENTO DE EDUCACION ESTUDIANTIL"
        ' 
        ' btnSalirLogin
        ' 
        btnSalirLogin.Location = New Point(629, 284)
        btnSalirLogin.Name = "btnSalirLogin"
        btnSalirLogin.Size = New Size(94, 29)
        btnSalirLogin.TabIndex = 4
        btnSalirLogin.Text = "SALIR"
        btnSalirLogin.UseVisualStyleBackColor = True
        ' 
        ' Inicio
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(btnSalirLogin)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(MenuStrip1)
        Name = "Inicio"
        Text = "Inicio"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSalirLogin As Button
End Class
