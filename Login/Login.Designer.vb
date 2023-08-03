<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        txtUsuario = New TextBox()
        txtContraseña = New TextBox()
        btnEntrar = New Button()
        btnCanelar = New Button()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point)
        Label1.Location = New Point(83, 14)
        Label1.Name = "Label1"
        Label1.Size = New Size(404, 25)
        Label1.TabIndex = 0
        Label1.Text = "BIENVENIDO LOGEATE PARA PODER INGRESAR"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(270, 58)
        Label2.Name = "Label2"
        Label2.Size = New Size(59, 15)
        Label2.TabIndex = 1
        Label2.Text = "USUARIO:"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(241, 106)
        Label3.Name = "Label3"
        Label3.Size = New Size(86, 15)
        Label3.TabIndex = 2
        Label3.Text = "CONTRASEÑA:"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.comunidad
        PictureBox1.Location = New Point(21, 44)
        PictureBox1.Margin = New Padding(3, 2, 3, 2)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(176, 127)
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Location = New Point(354, 56)
        txtUsuario.Margin = New Padding(3, 2, 3, 2)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(200, 23)
        txtUsuario.TabIndex = 4
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(354, 104)
        txtContraseña.Margin = New Padding(3, 2, 3, 2)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(200, 23)
        txtContraseña.TabIndex = 5
        ' 
        ' btnEntrar
        ' 
        btnEntrar.Location = New Point(302, 148)
        btnEntrar.Margin = New Padding(3, 2, 3, 2)
        btnEntrar.Name = "btnEntrar"
        btnEntrar.Size = New Size(82, 22)
        btnEntrar.TabIndex = 6
        btnEntrar.Text = "ACEPTAR"
        btnEntrar.UseVisualStyleBackColor = True
        ' 
        ' btnCanelar
        ' 
        btnCanelar.Location = New Point(435, 148)
        btnCanelar.Margin = New Padding(3, 2, 3, 2)
        btnCanelar.Name = "btnCanelar"
        btnCanelar.Size = New Size(82, 22)
        btnCanelar.TabIndex = 7
        btnCanelar.Text = "CANCELAR"
        btnCanelar.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(575, 185)
        Controls.Add(btnCanelar)
        Controls.Add(btnEntrar)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Margin = New Padding(3, 2, 3, 2)
        Name = "Login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents btnEntrar As Button
    Friend WithEvents btnCanelar As Button
End Class
