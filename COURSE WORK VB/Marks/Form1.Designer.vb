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
        Label1 = New Label()
        lblmarks = New Label()
        lblgrade = New Label()
        txtMarks = New TextBox()
        txtGrade = New TextBox()
        btnevaluate = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(224, 55)
        Label1.Name = "Label1"
        Label1.Size = New Size(256, 25)
        Label1.TabIndex = 0
        Label1.Text = "GRADING SCALE CALCULATOR"
        ' 
        ' lblmarks
        ' 
        lblmarks.AutoSize = True
        lblmarks.Location = New Point(183, 107)
        lblmarks.Name = "lblmarks"
        lblmarks.Size = New Size(105, 25)
        lblmarks.TabIndex = 1
        lblmarks.Text = "Enter Marks"
        ' 
        ' lblgrade
        ' 
        lblgrade.AutoSize = True
        lblgrade.Location = New Point(183, 162)
        lblgrade.Name = "lblgrade"
        lblgrade.Size = New Size(59, 25)
        lblgrade.TabIndex = 2
        lblgrade.Text = "Grade"
        ' 
        ' txtMarks
        ' 
        txtMarks.Location = New Point(330, 101)
        txtMarks.Name = "txtMarks"
        txtMarks.Size = New Size(150, 31)
        txtMarks.TabIndex = 3
        ' 
        ' txtGrade
        ' 
        txtGrade.Location = New Point(330, 156)
        txtGrade.Name = "txtGrade"
        txtGrade.Size = New Size(150, 31)
        txtGrade.TabIndex = 4
        ' 
        ' btnevaluate
        ' 
        btnevaluate.Location = New Point(289, 229)
        btnevaluate.Name = "btnevaluate"
        btnevaluate.Size = New Size(112, 34)
        btnevaluate.TabIndex = 5
        btnevaluate.Text = "Evaluate"
        btnevaluate.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlDark
        ClientSize = New Size(800, 450)
        Controls.Add(btnevaluate)
        Controls.Add(txtGrade)
        Controls.Add(txtMarks)
        Controls.Add(lblgrade)
        Controls.Add(lblmarks)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Sumayah Nakigudde"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lblmarks As Label
    Friend WithEvents lblgrade As Label
    Friend WithEvents txtMarks As TextBox
    Friend WithEvents txtGrade As TextBox
    Friend WithEvents btnevaluate As Button

End Class
