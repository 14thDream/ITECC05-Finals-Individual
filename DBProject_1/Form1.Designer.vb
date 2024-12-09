<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Button1 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        TextBox_Username = New TextBox()
        TextBox_Password = New TextBox()
        Panel1 = New Panel()
        Button_Login = New Button()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.AutoSize = True
        Button1.Font = New Font("Microsoft Sans Serif", 18.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(3, 3)
        Button1.Name = "Button1"
        Button1.Size = New Size(235, 39)
        Button1.TabIndex = 0
        Button1.Text = "Check Connection"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(3, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(60, 15)
        Label1.TabIndex = 0
        Label1.Text = "Username"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(3, 33)
        Label2.Name = "Label2"
        Label2.Size = New Size(57, 15)
        Label2.TabIndex = 1
        Label2.Text = "Password"
        ' 
        ' TextBox_Username
        ' 
        TextBox_Username.Location = New Point(80, 0)
        TextBox_Username.Name = "TextBox_Username"
        TextBox_Username.Size = New Size(100, 23)
        TextBox_Username.TabIndex = 2
        ' 
        ' TextBox_Password
        ' 
        TextBox_Password.Location = New Point(80, 29)
        TextBox_Password.Name = "TextBox_Password"
        TextBox_Password.Size = New Size(100, 23)
        TextBox_Password.TabIndex = 3
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(Button_Login)
        Panel1.Controls.Add(TextBox_Password)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(TextBox_Username)
        Panel1.Location = New Point(300, 175)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(200, 100)
        Panel1.TabIndex = 1
        ' 
        ' Button_Login
        ' 
        Button_Login.Location = New Point(62, 62)
        Button_Login.Name = "Button_Login"
        Button_Login.Size = New Size(75, 23)
        Button_Login.TabIndex = 4
        Button_Login.Text = "Login"
        Button_Login.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Panel1)
        Controls.Add(Button1)
        Name = "Form1"
        Text = "Form1"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_Username As TextBox
    Friend WithEvents TextBox_Password As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button_Login As Button

End Class
