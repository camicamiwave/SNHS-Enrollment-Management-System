<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class home
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.logout = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Faculty = New System.Windows.Forms.Button()
        Me.BtnEnrollForm = New System.Windows.Forms.Button()
        Me.BtnModify = New System.Windows.Forms.Button()
        Me.Subject = New System.Windows.Forms.Button()
        Me.BtnSearch = New System.Windows.Forms.Button()
        Me.Section = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.CornflowerBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Location = New System.Drawing.Point(1, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(931, 519)
        Me.Panel1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Buxton Sketch", 30.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(386, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(280, 49)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Junior Highschool"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Broadway", 32.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(167, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(744, 48)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Sanfelipe National Highschool"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Lavender
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.logout)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Faculty)
        Me.Panel2.Controls.Add(Me.BtnEnrollForm)
        Me.Panel2.Controls.Add(Me.BtnModify)
        Me.Panel2.Controls.Add(Me.Subject)
        Me.Panel2.Controls.Add(Me.BtnSearch)
        Me.Panel2.Controls.Add(Me.Section)
        Me.Panel2.Font = New System.Drawing.Font("Modern No. 20", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(149, 512)
        Me.Panel2.TabIndex = 0
        '
        'logout
        '
        Me.logout.Location = New System.Drawing.Point(0, 444)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(149, 30)
        Me.logout.TabIndex = 12
        Me.logout.Text = "Logout"
        Me.logout.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackgroundImage = Global.dbms_enrollment.My.Resources.Resources.sfns_logo
        Me.Panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(149, 144)
        Me.Panel3.TabIndex = 10
        '
        'Faculty
        '
        Me.Faculty.Location = New System.Drawing.Point(0, 353)
        Me.Faculty.Name = "Faculty"
        Me.Faculty.Size = New System.Drawing.Size(149, 40)
        Me.Faculty.TabIndex = 9
        Me.Faculty.Text = "Faculty Assigned"
        Me.Faculty.UseVisualStyleBackColor = True
        '
        'BtnEnrollForm
        '
        Me.BtnEnrollForm.Location = New System.Drawing.Point(0, 158)
        Me.BtnEnrollForm.Name = "BtnEnrollForm"
        Me.BtnEnrollForm.Size = New System.Drawing.Size(149, 40)
        Me.BtnEnrollForm.TabIndex = 8
        Me.BtnEnrollForm.Text = "Enrollment Form"
        Me.BtnEnrollForm.UseVisualStyleBackColor = True
        '
        'BtnModify
        '
        Me.BtnModify.Location = New System.Drawing.Point(0, 197)
        Me.BtnModify.Name = "BtnModify"
        Me.BtnModify.Size = New System.Drawing.Size(149, 40)
        Me.BtnModify.TabIndex = 5
        Me.BtnModify.Text = "Modify Student"
        Me.BtnModify.UseVisualStyleBackColor = True
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(0, 314)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(149, 40)
        Me.Subject.TabIndex = 6
        Me.Subject.Text = "Manage Subject"
        Me.Subject.UseVisualStyleBackColor = True
        '
        'BtnSearch
        '
        Me.BtnSearch.Location = New System.Drawing.Point(0, 236)
        Me.BtnSearch.Name = "BtnSearch"
        Me.BtnSearch.Size = New System.Drawing.Size(149, 40)
        Me.BtnSearch.TabIndex = 4
        Me.BtnSearch.Text = "Enrolled Student"
        Me.BtnSearch.UseVisualStyleBackColor = True
        '
        'Section
        '
        Me.Section.Location = New System.Drawing.Point(0, 275)
        Me.Section.Name = "Section"
        Me.Section.Size = New System.Drawing.Size(149, 39)
        Me.Section.TabIndex = 2
        Me.Section.Text = "Manage Section"
        Me.Section.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 40)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "Enrollment Report"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 515)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "home"
        Me.Text = "home"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Faculty As System.Windows.Forms.Button
    Friend WithEvents BtnEnrollForm As System.Windows.Forms.Button
    Friend WithEvents BtnModify As System.Windows.Forms.Button
    Friend WithEvents Subject As System.Windows.Forms.Button
    Friend WithEvents BtnSearch As System.Windows.Forms.Button
    Friend WithEvents Section As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents logout As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
