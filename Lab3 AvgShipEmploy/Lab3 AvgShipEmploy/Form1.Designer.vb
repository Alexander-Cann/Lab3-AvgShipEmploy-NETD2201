<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeShippedAverages
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
        Me.components = New System.ComponentModel.Container()
        Me.lbDay = New System.Windows.Forms.Label()
        Me.lbUnits = New System.Windows.Forms.Label()
        Me.tbInput = New System.Windows.Forms.TextBox()
        Me.tbData1 = New System.Windows.Forms.RichTextBox()
        Me.tbData3 = New System.Windows.Forms.RichTextBox()
        Me.tbData2 = New System.Windows.Forms.RichTextBox()
        Me.lbEmployee1 = New System.Windows.Forms.Label()
        Me.lbEmployee2 = New System.Windows.Forms.Label()
        Me.lbEmployee3 = New System.Windows.Forms.Label()
        Me.tbDataAverage1 = New System.Windows.Forms.TextBox()
        Me.tbDataAverage3 = New System.Windows.Forms.TextBox()
        Me.tbDataAverage2 = New System.Windows.Forms.TextBox()
        Me.tbCompanyAverage = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lbDay
        '
        Me.lbDay.AutoSize = True
        Me.lbDay.Location = New System.Drawing.Point(12, 9)
        Me.lbDay.Name = "lbDay"
        Me.lbDay.Size = New System.Drawing.Size(45, 17)
        Me.lbDay.TabIndex = 0
        Me.lbDay.Text = "Day 1"
        Me.lbDay.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbUnits
        '
        Me.lbUnits.AutoSize = True
        Me.lbUnits.Location = New System.Drawing.Point(12, 39)
        Me.lbUnits.Name = "lbUnits"
        Me.lbUnits.Size = New System.Drawing.Size(44, 17)
        Me.lbUnits.TabIndex = 0
        Me.lbUnits.Text = "Units:"
        Me.lbUnits.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbInput
        '
        Me.tbInput.Location = New System.Drawing.Point(62, 39)
        Me.tbInput.Name = "tbInput"
        Me.tbInput.Size = New System.Drawing.Size(68, 22)
        Me.tbInput.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.tbInput, "Input your amount of units shipped in this box")
        '
        'tbData1
        '
        Me.tbData1.BackColor = System.Drawing.Color.White
        Me.tbData1.Location = New System.Drawing.Point(15, 109)
        Me.tbData1.Name = "tbData1"
        Me.tbData1.ReadOnly = True
        Me.tbData1.Size = New System.Drawing.Size(148, 180)
        Me.tbData1.TabIndex = 3
        Me.tbData1.TabStop = False
        Me.tbData1.Text = ""
        Me.ToolTip1.SetToolTip(Me.tbData1, "This box keeps track of the data entered for employee 1")
        '
        'tbData3
        '
        Me.tbData3.BackColor = System.Drawing.Color.White
        Me.tbData3.Location = New System.Drawing.Point(323, 109)
        Me.tbData3.Name = "tbData3"
        Me.tbData3.ReadOnly = True
        Me.tbData3.Size = New System.Drawing.Size(148, 180)
        Me.tbData3.TabIndex = 4
        Me.tbData3.TabStop = False
        Me.tbData3.Text = ""
        Me.ToolTip1.SetToolTip(Me.tbData3, "This box keeps track of the data entered for employee 3")
        '
        'tbData2
        '
        Me.tbData2.BackColor = System.Drawing.Color.White
        Me.tbData2.Location = New System.Drawing.Point(169, 109)
        Me.tbData2.Name = "tbData2"
        Me.tbData2.ReadOnly = True
        Me.tbData2.Size = New System.Drawing.Size(148, 180)
        Me.tbData2.TabIndex = 5
        Me.tbData2.TabStop = False
        Me.tbData2.Text = ""
        Me.ToolTip1.SetToolTip(Me.tbData2, "This box keeps track of the data entered for employee 2")
        '
        'lbEmployee1
        '
        Me.lbEmployee1.AutoSize = True
        Me.lbEmployee1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbEmployee1.Location = New System.Drawing.Point(45, 89)
        Me.lbEmployee1.Name = "lbEmployee1"
        Me.lbEmployee1.Size = New System.Drawing.Size(92, 17)
        Me.lbEmployee1.TabIndex = 0
        Me.lbEmployee1.Text = "Employee 1"
        Me.lbEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployee2
        '
        Me.lbEmployee2.AutoSize = True
        Me.lbEmployee2.Location = New System.Drawing.Point(207, 89)
        Me.lbEmployee2.Name = "lbEmployee2"
        Me.lbEmployee2.Size = New System.Drawing.Size(82, 17)
        Me.lbEmployee2.TabIndex = 0
        Me.lbEmployee2.Text = "Employee 2"
        Me.lbEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbEmployee3
        '
        Me.lbEmployee3.AutoSize = True
        Me.lbEmployee3.Location = New System.Drawing.Point(361, 89)
        Me.lbEmployee3.Name = "lbEmployee3"
        Me.lbEmployee3.Size = New System.Drawing.Size(82, 17)
        Me.lbEmployee3.TabIndex = 0
        Me.lbEmployee3.Text = "Employee 3"
        Me.lbEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tbDataAverage1
        '
        Me.tbDataAverage1.Location = New System.Drawing.Point(15, 295)
        Me.tbDataAverage1.Name = "tbDataAverage1"
        Me.tbDataAverage1.ReadOnly = True
        Me.tbDataAverage1.Size = New System.Drawing.Size(148, 22)
        Me.tbDataAverage1.TabIndex = 9
        Me.tbDataAverage1.TabStop = False
        Me.tbDataAverage1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tbDataAverage1, "The average units shipped for employee 1")
        '
        'tbDataAverage3
        '
        Me.tbDataAverage3.BackColor = System.Drawing.SystemColors.Control
        Me.tbDataAverage3.Location = New System.Drawing.Point(323, 295)
        Me.tbDataAverage3.Name = "tbDataAverage3"
        Me.tbDataAverage3.ReadOnly = True
        Me.tbDataAverage3.Size = New System.Drawing.Size(148, 22)
        Me.tbDataAverage3.TabIndex = 10
        Me.tbDataAverage3.TabStop = False
        Me.tbDataAverage3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tbDataAverage3, "The average units shipped for employee 3")
        '
        'tbDataAverage2
        '
        Me.tbDataAverage2.Location = New System.Drawing.Point(169, 295)
        Me.tbDataAverage2.Name = "tbDataAverage2"
        Me.tbDataAverage2.ReadOnly = True
        Me.tbDataAverage2.Size = New System.Drawing.Size(148, 22)
        Me.tbDataAverage2.TabIndex = 11
        Me.tbDataAverage2.TabStop = False
        Me.tbDataAverage2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tbDataAverage2, "The average units shipped for employee 2")
        '
        'tbCompanyAverage
        '
        Me.tbCompanyAverage.BackColor = System.Drawing.SystemColors.Control
        Me.tbCompanyAverage.Location = New System.Drawing.Point(15, 323)
        Me.tbCompanyAverage.Name = "tbCompanyAverage"
        Me.tbCompanyAverage.ReadOnly = True
        Me.tbCompanyAverage.Size = New System.Drawing.Size(456, 22)
        Me.tbCompanyAverage.TabIndex = 12
        Me.tbCompanyAverage.TabStop = False
        Me.tbCompanyAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.ToolTip1.SetToolTip(Me.tbCompanyAverage, "The average units shipped for all employees together")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(15, 351)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(148, 33)
        Me.btnEnter.TabIndex = 2
        Me.btnEnter.Text = "&Enter"
        Me.ToolTip1.SetToolTip(Me.btnEnter, "Submit the current data in the input box")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(169, 351)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(148, 33)
        Me.btnReset.TabIndex = 3
        Me.btnReset.Text = "&Reset"
        Me.ToolTip1.SetToolTip(Me.btnReset, "Reset the application to all default values")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(323, 351)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(148, 33)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.ToolTip1.SetToolTip(Me.btnExit, "Exi/ Close the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'EmployeeShippedAverages
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(488, 398)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.tbCompanyAverage)
        Me.Controls.Add(Me.tbDataAverage2)
        Me.Controls.Add(Me.tbDataAverage3)
        Me.Controls.Add(Me.tbDataAverage1)
        Me.Controls.Add(Me.lbEmployee3)
        Me.Controls.Add(Me.lbEmployee2)
        Me.Controls.Add(Me.lbEmployee1)
        Me.Controls.Add(Me.tbData2)
        Me.Controls.Add(Me.tbData3)
        Me.Controls.Add(Me.tbData1)
        Me.Controls.Add(Me.tbInput)
        Me.Controls.Add(Me.lbUnits)
        Me.Controls.Add(Me.lbDay)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "EmployeeShippedAverages"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped by Employee"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbDay As Label
    Friend WithEvents lbUnits As Label
    Friend WithEvents tbInput As TextBox
    Friend WithEvents tbData1 As RichTextBox
    Friend WithEvents tbData3 As RichTextBox
    Friend WithEvents tbData2 As RichTextBox
    Friend WithEvents lbEmployee1 As Label
    Friend WithEvents lbEmployee2 As Label
    Friend WithEvents lbEmployee3 As Label
    Friend WithEvents tbDataAverage1 As TextBox
    Friend WithEvents tbDataAverage3 As TextBox
    Friend WithEvents tbDataAverage2 As TextBox
    Friend WithEvents tbCompanyAverage As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
