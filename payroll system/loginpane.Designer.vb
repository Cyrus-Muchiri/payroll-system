<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loginpane
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.passworTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.firstNameTextBox = New System.Windows.Forms.TextBox()
        Me.lastNameTextBox = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "User name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "password"
        '
        'loginButton
        '
        Me.loginButton.Location = New System.Drawing.Point(31, 188)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(75, 23)
        Me.loginButton.TabIndex = 2
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Location = New System.Drawing.Point(171, 188)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(75, 23)
        Me.exitButton.TabIndex = 3
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(146, 65)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.UsernameTextBox.TabIndex = 4
        '
        'passworTextBox
        '
        Me.passworTextBox.Location = New System.Drawing.Point(146, 99)
        Me.passworTextBox.Name = "passworTextBox"
        Me.passworTextBox.Size = New System.Drawing.Size(100, 20)
        Me.passworTextBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "First Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 38)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Last Name"
        '
        'firstNameTextBox
        '
        Me.firstNameTextBox.Location = New System.Drawing.Point(146, 5)
        Me.firstNameTextBox.Name = "firstNameTextBox"
        Me.firstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.firstNameTextBox.TabIndex = 8
        '
        'lastNameTextBox
        '
        Me.lastNameTextBox.Location = New System.Drawing.Point(146, 35)
        Me.lastNameTextBox.Name = "lastNameTextBox"
        Me.lastNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.lastNameTextBox.TabIndex = 9
        '
        'loginpane
        '
        Me.AcceptButton = Me.loginButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.lastNameTextBox)
        Me.Controls.Add(Me.firstNameTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.passworTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "loginpane"
        Me.Text = "loginpane"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents loginButton As Button
    Friend WithEvents exitButton As Button
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents passworTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents firstNameTextBox As TextBox
    Friend WithEvents lastNameTextBox As TextBox
End Class
