<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.CC_Btn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox_UN = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_Pass = New System.Windows.Forms.TextBox()
        Me.Login_Btn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'CC_Btn
        '
        Me.CC_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.CC_Btn.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.CC_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.CC_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold)
        Me.CC_Btn.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.CC_Btn.Location = New System.Drawing.Point(251, 184)
        Me.CC_Btn.Name = "CC_Btn"
        Me.CC_Btn.Size = New System.Drawing.Size(142, 26)
        Me.CC_Btn.TabIndex = 0
        Me.CC_Btn.Text = "Check Connection"
        Me.CC_Btn.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 25)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'TextBox_UN
        '
        Me.TextBox_UN.Location = New System.Drawing.Point(185, 70)
        Me.TextBox_UN.Name = "TextBox_UN"
        Me.TextBox_UN.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_UN.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'TextBox_Pass
        '
        Me.TextBox_Pass.Location = New System.Drawing.Point(185, 96)
        Me.TextBox_Pass.Name = "TextBox_Pass"
        Me.TextBox_Pass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox_Pass.Size = New System.Drawing.Size(155, 20)
        Me.TextBox_Pass.TabIndex = 4
        '
        'Login_Btn
        '
        Me.Login_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Login_Btn.Location = New System.Drawing.Point(144, 131)
        Me.Login_Btn.Name = "Login_Btn"
        Me.Login_Btn.Size = New System.Drawing.Size(119, 32)
        Me.Login_Btn.TabIndex = 5
        Me.Login_Btn.Text = "Login"
        Me.Login_Btn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(139, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 25)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "WELCOME!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(405, 222)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Login_Btn)
        Me.Controls.Add(Me.TextBox_Pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox_UN)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CC_Btn)
        Me.Name = "Form1"
        Me.Text = "Employee Information System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CC_Btn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox_UN As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox_Pass As System.Windows.Forms.TextBox
    Friend WithEvents Login_Btn As System.Windows.Forms.Button
    Friend WithEvents Label3 As Label
End Class
