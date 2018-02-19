<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class update_employee
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
        Me.GenderComboBox = New System.Windows.Forms.ComboBox()
        Me.contactMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DOJMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DOBMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.remarksRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.profilepicButton = New System.Windows.Forms.Button()
        Me.ProfilePictureBox = New System.Windows.Forms.PictureBox()
        Me.DepartmentTextBox = New System.Windows.Forms.TextBox()
        Me.DesignationTextBox = New System.Windows.Forms.TextBox()
        Me.PincodeTextBox = New System.Windows.Forms.TextBox()
        Me.CountyTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.FathersnameTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.cancelButton = New System.Windows.Forms.Button()
        Me.saveButton = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CountyLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GenderComboBox
        '
        Me.GenderComboBox.FormattingEnabled = True
        Me.GenderComboBox.Items.AddRange(New Object() {"male", "female"})
        Me.GenderComboBox.Location = New System.Drawing.Point(177, 145)
        Me.GenderComboBox.Name = "GenderComboBox"
        Me.GenderComboBox.Size = New System.Drawing.Size(121, 21)
        Me.GenderComboBox.TabIndex = 71
        '
        'contactMaskedTextBox
        '
        Me.contactMaskedTextBox.Location = New System.Drawing.Point(180, 338)
        Me.contactMaskedTextBox.Mask = "(999) 000-0000"
        Me.contactMaskedTextBox.Name = "contactMaskedTextBox"
        Me.contactMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.contactMaskedTextBox.TabIndex = 70
        '
        'DOJMaskedTextBox
        '
        Me.DOJMaskedTextBox.Location = New System.Drawing.Point(177, 423)
        Me.DOJMaskedTextBox.Mask = "00/00/0000"
        Me.DOJMaskedTextBox.Name = "DOJMaskedTextBox"
        Me.DOJMaskedTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DOJMaskedTextBox.TabIndex = 69
        Me.DOJMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DOBMaskedTextBox
        '
        Me.DOBMaskedTextBox.Location = New System.Drawing.Point(178, 181)
        Me.DOBMaskedTextBox.Mask = "00/00/0000"
        Me.DOBMaskedTextBox.Name = "DOBMaskedTextBox"
        Me.DOBMaskedTextBox.Size = New System.Drawing.Size(123, 20)
        Me.DOBMaskedTextBox.TabIndex = 68
        Me.DOBMaskedTextBox.ValidatingType = GetType(Date)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(439, 280)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 13)
        Me.Label15.TabIndex = 67
        Me.Label15.Text = "Remarks"
        '
        'remarksRichTextBox
        '
        Me.remarksRichTextBox.Location = New System.Drawing.Point(442, 320)
        Me.remarksRichTextBox.Name = "remarksRichTextBox"
        Me.remarksRichTextBox.Size = New System.Drawing.Size(184, 116)
        Me.remarksRichTextBox.TabIndex = 66
        Me.remarksRichTextBox.Text = ""
        '
        'profilepicButton
        '
        Me.profilepicButton.Location = New System.Drawing.Point(442, 241)
        Me.profilepicButton.Name = "profilepicButton"
        Me.profilepicButton.Size = New System.Drawing.Size(107, 23)
        Me.profilepicButton.TabIndex = 65
        Me.profilepicButton.Text = "Upload Profile"
        Me.profilepicButton.UseVisualStyleBackColor = True
        '
        'ProfilePictureBox
        '
        Me.ProfilePictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ProfilePictureBox.Location = New System.Drawing.Point(442, 51)
        Me.ProfilePictureBox.Name = "ProfilePictureBox"
        Me.ProfilePictureBox.Size = New System.Drawing.Size(184, 184)
        Me.ProfilePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.ProfilePictureBox.TabIndex = 64
        Me.ProfilePictureBox.TabStop = False
        '
        'DepartmentTextBox
        '
        Me.DepartmentTextBox.Location = New System.Drawing.Point(178, 395)
        Me.DepartmentTextBox.Name = "DepartmentTextBox"
        Me.DepartmentTextBox.Size = New System.Drawing.Size(124, 20)
        Me.DepartmentTextBox.TabIndex = 63
        '
        'DesignationTextBox
        '
        Me.DesignationTextBox.Location = New System.Drawing.Point(177, 365)
        Me.DesignationTextBox.Name = "DesignationTextBox"
        Me.DesignationTextBox.Size = New System.Drawing.Size(125, 20)
        Me.DesignationTextBox.TabIndex = 62
        '
        'PincodeTextBox
        '
        Me.PincodeTextBox.Location = New System.Drawing.Point(177, 303)
        Me.PincodeTextBox.Name = "PincodeTextBox"
        Me.PincodeTextBox.Size = New System.Drawing.Size(125, 20)
        Me.PincodeTextBox.TabIndex = 61
        '
        'CountyTextBox
        '
        Me.CountyTextBox.Location = New System.Drawing.Point(177, 273)
        Me.CountyTextBox.Name = "CountyTextBox"
        Me.CountyTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CountyTextBox.TabIndex = 60
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(177, 246)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(125, 20)
        Me.CityTextBox.TabIndex = 59
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(177, 216)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(125, 20)
        Me.AddressTextBox.TabIndex = 58
        '
        'FathersnameTextBox
        '
        Me.FathersnameTextBox.Location = New System.Drawing.Point(177, 119)
        Me.FathersnameTextBox.Name = "FathersnameTextBox"
        Me.FathersnameTextBox.Size = New System.Drawing.Size(125, 20)
        Me.FathersnameTextBox.TabIndex = 57
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(177, 84)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(125, 20)
        Me.NameTextBox.TabIndex = 56
        '
        'IdTextBox
        '
        Me.IdTextBox.Location = New System.Drawing.Point(177, 51)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(125, 20)
        Me.IdTextBox.TabIndex = 55
        '
        'cancelButton
        '
        Me.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cancelButton.Location = New System.Drawing.Point(465, 452)
        Me.cancelButton.Name = "cancelButton"
        Me.cancelButton.Size = New System.Drawing.Size(75, 23)
        Me.cancelButton.TabIndex = 54
        Me.cancelButton.Text = "Exit"
        Me.cancelButton.UseVisualStyleBackColor = True
        '
        'saveButton
        '
        Me.saveButton.Location = New System.Drawing.Point(54, 452)
        Me.saveButton.Name = "saveButton"
        Me.saveButton.Size = New System.Drawing.Size(75, 23)
        Me.saveButton.TabIndex = 53
        Me.saveButton.Text = "Save"
        Me.saveButton.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(213, 8)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(236, 24)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "NEW EMPLOYEE ENTITY"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(42, 423)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(75, 13)
        Me.Label13.TabIndex = 51
        Me.Label13.Text = "Date of joining"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(42, 395)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 50
        Me.Label12.Text = "Department"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(42, 365)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(63, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Designation"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(42, 337)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(61, 13)
        Me.Label10.TabIndex = 48
        Me.Label10.Text = "Contact No"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(42, 306)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Pincode"
        '
        'CountyLabel
        '
        Me.CountyLabel.AutoSize = True
        Me.CountyLabel.Location = New System.Drawing.Point(42, 280)
        Me.CountyLabel.Name = "CountyLabel"
        Me.CountyLabel.Size = New System.Drawing.Size(40, 13)
        Me.CountyLabel.TabIndex = 46
        Me.CountyLabel.Text = "County"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(42, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 45
        Me.Label7.Text = "City"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 216)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 13)
        Me.Label6.TabIndex = 44
        Me.Label6.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(42, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 43
        Me.Label5.Text = "Date Of Birth"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(42, 150)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "Gender"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Fathers name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(42, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Emp ID"
        '
        'update_employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(664, 483)
        Me.Controls.Add(Me.GenderComboBox)
        Me.Controls.Add(Me.contactMaskedTextBox)
        Me.Controls.Add(Me.DOJMaskedTextBox)
        Me.Controls.Add(Me.DOBMaskedTextBox)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.remarksRichTextBox)
        Me.Controls.Add(Me.profilepicButton)
        Me.Controls.Add(Me.ProfilePictureBox)
        Me.Controls.Add(Me.DepartmentTextBox)
        Me.Controls.Add(Me.DesignationTextBox)
        Me.Controls.Add(Me.PincodeTextBox)
        Me.Controls.Add(Me.CountyTextBox)
        Me.Controls.Add(Me.CityTextBox)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.FathersnameTextBox)
        Me.Controls.Add(Me.NameTextBox)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.cancelButton)
        Me.Controls.Add(Me.saveButton)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.CountyLabel)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "update_employee"
        Me.Text = "update_employee"
        CType(Me.ProfilePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GenderComboBox As ComboBox
    Friend WithEvents contactMaskedTextBox As MaskedTextBox
    Friend WithEvents DOJMaskedTextBox As MaskedTextBox
    Friend WithEvents DOBMaskedTextBox As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents remarksRichTextBox As RichTextBox
    Friend WithEvents profilepicButton As Button
    Friend WithEvents ProfilePictureBox As PictureBox
    Friend WithEvents DepartmentTextBox As TextBox
    Friend WithEvents DesignationTextBox As TextBox
    Friend WithEvents PincodeTextBox As TextBox
    Friend WithEvents CountyTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents FathersnameTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents cancelButton As Button
    Friend WithEvents saveButton As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents CountyLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
