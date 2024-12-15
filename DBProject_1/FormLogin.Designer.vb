<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        ButtonCheckConnection = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox_Username = New TextBox()
        TextBox_Password = New TextBox()
        Panel1 = New Panel()
        Button_Login = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' ButtonCheckConnection
        ' 
        ButtonCheckConnection.AutoSize = True
        ButtonCheckConnection.BackColor = Color.Gray
        ButtonCheckConnection.FlatStyle = FlatStyle.Popup
        ButtonCheckConnection.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        ButtonCheckConnection.Location = New Point(553, 12)
        ButtonCheckConnection.Name = "ButtonCheckConnection"
        ButtonCheckConnection.Size = New Size(235, 39)
        ButtonCheckConnection.TabIndex = 0
        ButtonCheckConnection.Text = "Check Connection"
        ButtonCheckConnection.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.White
        Label1.Location = New Point(3, 12)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.White
        Label2.Location = New Point(3, 40)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.Location = New Point(80, 9)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.Size = New Size(140, 23)
        TextBox_Username.TabIndex = 2
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.Location = New Point(80, 37)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.PasswordChar = "*"c
        TextBox_Password.Size = New Size(140, 23)
        TextBox_Password.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Transparent
        Panel1.Controls.Add(Button_Login)
        Panel1.Controls.Add(TextBox_Password)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox_Username)
        Panel1.Location = New Point(268, 191)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(238, 100)
        Panel1.TabIndex = 1
        ' 
        ' Button_Login
        ' 
        Button_Login.Location = New Point(62, 69)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(75, 23)
        Button_Login.TabIndex = 4
        Button_Login.Text = "Login"
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' FormLogin
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(ButtonCheckConnection)
        Name = "FormLogin"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents ButtonCheckConnection As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Login As Button

End Class
