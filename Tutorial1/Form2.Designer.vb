<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.SignOut_Btn = New System.Windows.Forms.Button()
        Me.Eid_Label = New System.Windows.Forms.Label()
        Me.Name_Label = New System.Windows.Forms.Label()
        Me.Surname_Label = New System.Windows.Forms.Label()
        Me.Age_label = New System.Windows.Forms.Label()
        Me.TextBox_Eid = New System.Windows.Forms.TextBox()
        Me.TextBox_Name = New System.Windows.Forms.TextBox()
        Me.TextBox_Surname = New System.Windows.Forms.TextBox()
        Me.TextBox_Age = New System.Windows.Forms.TextBox()
        Me.Save_Btn = New System.Windows.Forms.Button()
        Me.Update_Btn = New System.Windows.Forms.Button()
        Me.Delete_Btn = New System.Windows.Forms.Button()
        Me.TextBox_SF = New System.Windows.Forms.Label()
        Me.CB1 = New System.Windows.Forms.ComboBox()
        Me.LB1 = New System.Windows.Forms.ListBox()
        Me.DGV1 = New System.Windows.Forms.DataGridView()
        Me.Load_Table_Btn = New System.Windows.Forms.Button()
        Me.TextBox_Search = New System.Windows.Forms.TextBox()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Load_Chart_Btn = New System.Windows.Forms.Button()
        Me.RB_M = New System.Windows.Forms.RadioButton()
        Me.RB_FM = New System.Windows.Forms.RadioButton()
        Me.Gender_Label = New System.Windows.Forms.Label()
        Me.Calendar_DTP = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SignOut_Btn
        '
        Me.SignOut_Btn.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SignOut_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.SignOut_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold)
        Me.SignOut_Btn.Location = New System.Drawing.Point(17, 482)
        Me.SignOut_Btn.Name = "SignOut_Btn"
        Me.SignOut_Btn.Size = New System.Drawing.Size(118, 32)
        Me.SignOut_Btn.TabIndex = 1
        Me.SignOut_Btn.Text = "Sign Out"
        Me.SignOut_Btn.UseVisualStyleBackColor = False
        '
        'Eid_Label
        '
        Me.Eid_Label.AutoSize = True
        Me.Eid_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Eid_Label.Location = New System.Drawing.Point(6, 41)
        Me.Eid_Label.Name = "Eid_Label"
        Me.Eid_Label.Size = New System.Drawing.Size(34, 25)
        Me.Eid_Label.TabIndex = 2
        Me.Eid_Label.Text = "ID"
        '
        'Name_Label
        '
        Me.Name_Label.AutoSize = True
        Me.Name_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name_Label.Location = New System.Drawing.Point(6, 71)
        Me.Name_Label.Name = "Name_Label"
        Me.Name_Label.Size = New System.Drawing.Size(72, 25)
        Me.Name_Label.TabIndex = 3
        Me.Name_Label.Text = "Name"
        '
        'Surname_Label
        '
        Me.Surname_Label.AutoSize = True
        Me.Surname_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Surname_Label.Location = New System.Drawing.Point(6, 101)
        Me.Surname_Label.Name = "Surname_Label"
        Me.Surname_Label.Size = New System.Drawing.Size(105, 25)
        Me.Surname_Label.TabIndex = 4
        Me.Surname_Label.Text = "Surname"
        '
        'Age_label
        '
        Me.Age_label.AutoSize = True
        Me.Age_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Age_label.Location = New System.Drawing.Point(6, 133)
        Me.Age_label.Name = "Age_label"
        Me.Age_label.Size = New System.Drawing.Size(53, 25)
        Me.Age_label.TabIndex = 5
        Me.Age_label.Text = "Age"
        '
        'TextBox_Eid
        '
        Me.TextBox_Eid.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Eid.Location = New System.Drawing.Point(136, 40)
        Me.TextBox_Eid.Name = "TextBox_Eid"
        Me.TextBox_Eid.Size = New System.Drawing.Size(183, 26)
        Me.TextBox_Eid.TabIndex = 6
        '
        'TextBox_Name
        '
        Me.TextBox_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Name.Location = New System.Drawing.Point(136, 72)
        Me.TextBox_Name.Name = "TextBox_Name"
        Me.TextBox_Name.Size = New System.Drawing.Size(183, 26)
        Me.TextBox_Name.TabIndex = 7
        '
        'TextBox_Surname
        '
        Me.TextBox_Surname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Surname.Location = New System.Drawing.Point(136, 102)
        Me.TextBox_Surname.Name = "TextBox_Surname"
        Me.TextBox_Surname.Size = New System.Drawing.Size(183, 26)
        Me.TextBox_Surname.TabIndex = 8
        '
        'TextBox_Age
        '
        Me.TextBox_Age.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Age.Location = New System.Drawing.Point(136, 134)
        Me.TextBox_Age.Name = "TextBox_Age"
        Me.TextBox_Age.Size = New System.Drawing.Size(183, 26)
        Me.TextBox_Age.TabIndex = 9
        '
        'Save_Btn
        '
        Me.Save_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save_Btn.Location = New System.Drawing.Point(12, 326)
        Me.Save_Btn.Name = "Save_Btn"
        Me.Save_Btn.Size = New System.Drawing.Size(127, 40)
        Me.Save_Btn.TabIndex = 10
        Me.Save_Btn.Text = "Save"
        Me.Save_Btn.UseVisualStyleBackColor = True
        '
        'Update_Btn
        '
        Me.Update_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Update_Btn.Location = New System.Drawing.Point(12, 372)
        Me.Update_Btn.Name = "Update_Btn"
        Me.Update_Btn.Size = New System.Drawing.Size(127, 40)
        Me.Update_Btn.TabIndex = 11
        Me.Update_Btn.Text = "Update"
        Me.Update_Btn.UseVisualStyleBackColor = True
        '
        'Delete_Btn
        '
        Me.Delete_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete_Btn.Location = New System.Drawing.Point(12, 418)
        Me.Delete_Btn.Name = "Delete_Btn"
        Me.Delete_Btn.Size = New System.Drawing.Size(127, 40)
        Me.Delete_Btn.TabIndex = 12
        Me.Delete_Btn.Text = "Delete"
        Me.Delete_Btn.UseVisualStyleBackColor = True
        '
        'TextBox_SF
        '
        Me.TextBox_SF.AutoSize = True
        Me.TextBox_SF.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_SF.ForeColor = System.Drawing.SystemColors.ActiveCaption
        Me.TextBox_SF.Location = New System.Drawing.Point(15, 14)
        Me.TextBox_SF.Name = "TextBox_SF"
        Me.TextBox_SF.Size = New System.Drawing.Size(120, 25)
        Me.TextBox_SF.TabIndex = 0
        Me.TextBox_SF.Text = "Good day!"
        '
        'CB1
        '
        Me.CB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB1.FormattingEnabled = True
        Me.CB1.Location = New System.Drawing.Point(356, 10)
        Me.CB1.Name = "CB1"
        Me.CB1.Size = New System.Drawing.Size(179, 33)
        Me.CB1.TabIndex = 13
        '
        'LB1
        '
        Me.LB1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.LB1.FormattingEnabled = True
        Me.LB1.ItemHeight = 25
        Me.LB1.Location = New System.Drawing.Point(544, 12)
        Me.LB1.Name = "LB1"
        Me.LB1.Size = New System.Drawing.Size(221, 29)
        Me.LB1.TabIndex = 14
        '
        'DGV1
        '
        Me.DGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV1.Location = New System.Drawing.Point(356, 97)
        Me.DGV1.Name = "DGV1"
        Me.DGV1.Size = New System.Drawing.Size(409, 203)
        Me.DGV1.TabIndex = 15
        '
        'Load_Table_Btn
        '
        Me.Load_Table_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Load_Table_Btn.Location = New System.Drawing.Point(356, 49)
        Me.Load_Table_Btn.Name = "Load_Table_Btn"
        Me.Load_Table_Btn.Size = New System.Drawing.Size(179, 41)
        Me.Load_Table_Btn.TabIndex = 16
        Me.Load_Table_Btn.Text = "Load Table"
        Me.Load_Table_Btn.UseVisualStyleBackColor = True
        '
        'TextBox_Search
        '
        Me.TextBox_Search.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox_Search.ForeColor = System.Drawing.SystemColors.WindowFrame
        Me.TextBox_Search.Location = New System.Drawing.Point(541, 50)
        Me.TextBox_Search.Name = "TextBox_Search"
        Me.TextBox_Search.Size = New System.Drawing.Size(224, 39)
        Me.TextBox_Search.TabIndex = 17
        '
        'Chart1
        '
        ChartArea2.AxisX.Interval = 1.0R
        ChartArea2.AxisX.IsLabelAutoFit = False
        ChartArea2.AxisX.LabelStyle.Angle = -90
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(148, 306)
        Me.Chart1.Name = "Chart1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "NAME_VS_AGE"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(617, 218)
        Me.Chart1.TabIndex = 18
        Me.Chart1.Text = "Chart"
        '
        'Load_Chart_Btn
        '
        Me.Load_Chart_Btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold)
        Me.Load_Chart_Btn.Location = New System.Drawing.Point(617, 482)
        Me.Load_Chart_Btn.Name = "Load_Chart_Btn"
        Me.Load_Chart_Btn.Size = New System.Drawing.Size(131, 31)
        Me.Load_Chart_Btn.TabIndex = 19
        Me.Load_Chart_Btn.Text = "Load Chart"
        Me.Load_Chart_Btn.UseVisualStyleBackColor = True
        '
        'RB_M
        '
        Me.RB_M.AutoSize = True
        Me.RB_M.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_M.Location = New System.Drawing.Point(136, 166)
        Me.RB_M.Name = "RB_M"
        Me.RB_M.Size = New System.Drawing.Size(73, 28)
        Me.RB_M.TabIndex = 20
        Me.RB_M.TabStop = True
        Me.RB_M.Text = "Male"
        Me.RB_M.UseVisualStyleBackColor = True
        '
        'RB_FM
        '
        Me.RB_FM.AutoSize = True
        Me.RB_FM.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RB_FM.Location = New System.Drawing.Point(215, 166)
        Me.RB_FM.Name = "RB_FM"
        Me.RB_FM.Size = New System.Drawing.Size(98, 28)
        Me.RB_FM.TabIndex = 21
        Me.RB_FM.TabStop = True
        Me.RB_FM.Text = "Female"
        Me.RB_FM.UseVisualStyleBackColor = True
        '
        'Gender_Label
        '
        Me.Gender_Label.AutoSize = True
        Me.Gender_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender_Label.Location = New System.Drawing.Point(6, 166)
        Me.Gender_Label.Name = "Gender_Label"
        Me.Gender_Label.Size = New System.Drawing.Size(89, 25)
        Me.Gender_Label.TabIndex = 23
        Me.Gender_Label.Text = "Gender"
        '
        'Calendar_DTP
        '
        Me.Calendar_DTP.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Calendar_DTP.CustomFormat = "yyyy-MM-dd"
        Me.Calendar_DTP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.Calendar_DTP.Location = New System.Drawing.Point(136, 202)
        Me.Calendar_DTP.Name = "Calendar_DTP"
        Me.Calendar_DTP.Size = New System.Drawing.Size(183, 31)
        Me.Calendar_DTP.TabIndex = 24
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Eid_Label)
        Me.GroupBox1.Controls.Add(Me.Calendar_DTP)
        Me.GroupBox1.Controls.Add(Me.Name_Label)
        Me.GroupBox1.Controls.Add(Me.Gender_Label)
        Me.GroupBox1.Controls.Add(Me.Surname_Label)
        Me.GroupBox1.Controls.Add(Me.Age_label)
        Me.GroupBox1.Controls.Add(Me.RB_FM)
        Me.GroupBox1.Controls.Add(Me.TextBox_Eid)
        Me.GroupBox1.Controls.Add(Me.RB_M)
        Me.GroupBox1.Controls.Add(Me.TextBox_Name)
        Me.GroupBox1.Controls.Add(Me.TextBox_Surname)
        Me.GroupBox1.Controls.Add(Me.TextBox_Age)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 50)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(325, 250)
        Me.GroupBox1.TabIndex = 25
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Employee Information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 207)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 25)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Birth Date"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(787, 543)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Delete_Btn)
        Me.Controls.Add(Me.Load_Chart_Btn)
        Me.Controls.Add(Me.Chart1)
        Me.Controls.Add(Me.TextBox_Search)
        Me.Controls.Add(Me.Load_Table_Btn)
        Me.Controls.Add(Me.DGV1)
        Me.Controls.Add(Me.Update_Btn)
        Me.Controls.Add(Me.Save_Btn)
        Me.Controls.Add(Me.SignOut_Btn)
        Me.Controls.Add(Me.TextBox_SF)
        Me.Controls.Add(Me.CB1)
        Me.Controls.Add(Me.LB1)
        Me.Name = "Form2"
        Me.Text = "Information Menu"
        CType(Me.DGV1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SignOut_Btn As System.Windows.Forms.Button
    Friend WithEvents Eid_Label As System.Windows.Forms.Label
    Friend WithEvents Name_Label As System.Windows.Forms.Label
    Friend WithEvents Surname_Label As System.Windows.Forms.Label
    Friend WithEvents Age_label As System.Windows.Forms.Label
    Friend WithEvents TextBox_Eid As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Name As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Surname As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Age As System.Windows.Forms.TextBox
    Friend WithEvents Save_Btn As System.Windows.Forms.Button
    Friend WithEvents Update_Btn As System.Windows.Forms.Button
    Friend WithEvents Delete_Btn As System.Windows.Forms.Button
    Friend WithEvents TextBox_SF As System.Windows.Forms.Label
    Friend WithEvents CB1 As System.Windows.Forms.ComboBox
    Friend WithEvents LB1 As System.Windows.Forms.ListBox
    Friend WithEvents DGV1 As System.Windows.Forms.DataGridView
    Friend WithEvents Load_Table_Btn As System.Windows.Forms.Button
    Friend WithEvents TextBox_Search As System.Windows.Forms.TextBox
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents Load_Chart_Btn As System.Windows.Forms.Button
    Friend WithEvents RB_M As System.Windows.Forms.RadioButton
    Friend WithEvents RB_FM As System.Windows.Forms.RadioButton
    Friend WithEvents Gender_Label As System.Windows.Forms.Label
    Friend WithEvents Calendar_DTP As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
