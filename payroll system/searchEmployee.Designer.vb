<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class searchEmployee
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
        Me.Label14 = New System.Windows.Forms.Label()
        Me.DOJTextBox = New System.Windows.Forms.TextBox()
        Me.contactTextBox = New System.Windows.Forms.TextBox()
        Me.DOBTextBox = New System.Windows.Forms.TextBox()
        Me.genderTextBox = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.remarksRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(204, 9)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(269, 24)
        Me.Label14.TabIndex = 51
        Me.Label14.Text = "SEARCH EMPLOYEE ENTITY"
        '
        'DOJTextBox
        '
        Me.DOJTextBox.Location = New System.Drawing.Point(183, 316)
        Me.DOJTextBox.Name = "DOJTextBox"
        Me.DOJTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DOJTextBox.TabIndex = 88
        '
        'contactTextBox
        '
        Me.contactTextBox.Location = New System.Drawing.Point(183, 236)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.Size = New System.Drawing.Size(127, 20)
        Me.contactTextBox.TabIndex = 87
        '
        'DOBTextBox
        '
        Me.DOBTextBox.Location = New System.Drawing.Point(184, 137)
        Me.DOBTextBox.Name = "DOBTextBox"
        Me.DOBTextBox.Size = New System.Drawing.Size(126, 20)
        Me.DOBTextBox.TabIndex = 86
        '
        'genderTextBox
        '
        Me.genderTextBox.Location = New System.Drawing.Point(185, 105)
        Me.genderTextBox.Name = "genderTextBox"
        Me.genderTextBox.Size = New System.Drawing.Size(123, 20)
        Me.genderTextBox.TabIndex = 85
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(438, 44)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 84
        Me.Label15.Text = "Remarks"
        '
        'remarksRichTextBox
        '
        Me.remarksRichTextBox.Location = New System.Drawing.Point(441, 86)
        Me.remarksRichTextBox.Name = "remarksRichTextBox"
        Me.remarksRichTextBox.Size = New System.Drawing.Size(184, 116)
        Me.remarksRichTextBox.TabIndex = 83
        Me.remarksRichTextBox.Text = ""
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(182, 279)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DepartmentTextBox.TabIndex = 82
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(183, 199)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(127, 20)
        Me.CityTextBox.TabIndex = 81
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(184, 168)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(126, 20)
        Me.AddressTextBox.TabIndex = 80
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(185, 77)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(125, 20)
        Me.NameTextBox.TabIndex = 79
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(185, 44)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(125, 20)
        Me.IdTextBox.TabIndex = 78
        '
        'cancelButton
        '
        Me.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelButton.Location = New System.Drawing.Point(459, 445)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 77
        Me.cancelButton.Text = "Exit"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(62, 445)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 76
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(49, 316)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 75
        Me.Label13.Text = "Date of joining"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(49, 282)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 74
        Me.Label12.Text = "Department"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(50, 234)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 73
        Me.Label10.Text = "Contact No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(50, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 72
        Me.Label7.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(50, 171)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(50, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Date Of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(50, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "Gender"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Emp ID"
        '
        'searchEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(675, 512)
        Me.Controls.Add(Me.DOJTextBox)
        Me.Controls.Add(Me.contactTextBox)
        Me.Controls.Add(Me.DOBTextBox)
        Me.Controls.Add(Me.genderTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.remarksRichTextBox)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label14)
        Me.Name = "searchEmployee"
        Me.Text = "searchEmployee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label14 As Label
    Friend WithEvents DOJTextBox As TextBox
    Friend WithEvents contactTextBox As TextBox
    Friend WithEvents DOBTextBox As TextBox
    Friend WithEvents genderTextBox As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents remarksRichTextBox As RichTextBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
