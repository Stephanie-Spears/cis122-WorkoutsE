<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
		Me.btnRunProject = New System.Windows.Forms.Button()
		Me.rtfMain = New System.Windows.Forms.RichTextBox()
		Me.btnClear = New System.Windows.Forms.Button()
		Me.btnClose = New System.Windows.Forms.Button()
		Me.lblTitle = New System.Windows.Forms.Label()
		Me.SuspendLayout()
		'
		'btnRunProject
		'
		Me.btnRunProject.AutoSize = True
		Me.btnRunProject.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnRunProject.Location = New System.Drawing.Point(565, 22)
		Me.btnRunProject.Name = "btnRunProject"
		Me.btnRunProject.Size = New System.Drawing.Size(102, 30)
		Me.btnRunProject.TabIndex = 0
		Me.btnRunProject.Text = "&Run Project"
		Me.btnRunProject.UseVisualStyleBackColor = True
		'
		'rtfMain
		'
		Me.rtfMain.BackColor = System.Drawing.Color.DarkSlateBlue
		Me.rtfMain.ForeColor = System.Drawing.Color.White
		Me.rtfMain.Location = New System.Drawing.Point(37, 58)
		Me.rtfMain.Name = "rtfMain"
		Me.rtfMain.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
		Me.rtfMain.Size = New System.Drawing.Size(630, 572)
		Me.rtfMain.TabIndex = 2
		Me.rtfMain.Text = ""
		'
		'btnClear
		'
		Me.btnClear.AutoSize = True
		Me.btnClear.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClear.Location = New System.Drawing.Point(37, 640)
		Me.btnClear.Name = "btnClear"
		Me.btnClear.Size = New System.Drawing.Size(75, 32)
		Me.btnClear.TabIndex = 3
		Me.btnClear.Text = "C&lear"
		Me.btnClear.UseVisualStyleBackColor = True
		'
		'btnClose
		'
		Me.btnClose.AutoSize = True
		Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
		Me.btnClose.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.btnClose.Location = New System.Drawing.Point(592, 640)
		Me.btnClose.Name = "btnClose"
		Me.btnClose.Size = New System.Drawing.Size(75, 32)
		Me.btnClose.TabIndex = 4
		Me.btnClose.Text = "&Close"
		Me.btnClose.UseVisualStyleBackColor = True
		'
		'lblTitle
		'
		Me.lblTitle.AutoSize = True
		Me.lblTitle.Font = New System.Drawing.Font("Lucida Handwriting", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblTitle.Location = New System.Drawing.Point(30, 21)
		Me.lblTitle.Name = "lblTitle"
		Me.lblTitle.Size = New System.Drawing.Size(175, 31)
		Me.lblTitle.TabIndex = 5
		Me.lblTitle.Text = "Project Title"
		'
		'frmMain
		'
		Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.CancelButton = Me.btnClose
		Me.ClientSize = New System.Drawing.Size(705, 693)
		Me.Controls.Add(Me.lblTitle)
		Me.Controls.Add(Me.btnClose)
		Me.Controls.Add(Me.btnClear)
		Me.Controls.Add(Me.rtfMain)
		Me.Controls.Add(Me.btnRunProject)
		Me.Name = "frmMain"
		Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
		Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
		Me.Text = "Project Title"
		Me.ResumeLayout(False)
		Me.PerformLayout()

	End Sub
    Friend WithEvents btnRunProject As System.Windows.Forms.Button
    Friend WithEvents rtfMain As System.Windows.Forms.RichTextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label

End Class
