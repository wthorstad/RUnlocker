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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SetFPS = New System.Windows.Forms.Button()
        Me.FPSValue1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CloseInstances = New System.Windows.Forms.Button()
        Me.ExitProgram = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'SetFPS
        '
        Me.SetFPS.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.SetFPS.Location = New System.Drawing.Point(272, 12)
        Me.SetFPS.Name = "SetFPS"
        Me.SetFPS.Size = New System.Drawing.Size(100, 25)
        Me.SetFPS.TabIndex = 0
        Me.SetFPS.Text = "Set FPS Value"
        Me.SetFPS.UseVisualStyleBackColor = True
        '
        'FPSValue1
        '
        Me.FPSValue1.Location = New System.Drawing.Point(166, 15)
        Me.FPSValue1.Name = "FPSValue1"
        Me.FPSValue1.Size = New System.Drawing.Size(100, 20)
        Me.FPSValue1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Location = New System.Drawing.Point(8, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Enter Your Desired FPS Value:"
        '
        'CloseInstances
        '
        Me.CloseInstances.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.CloseInstances.Location = New System.Drawing.Point(11, 49)
        Me.CloseInstances.Name = "CloseInstances"
        Me.CloseInstances.Size = New System.Drawing.Size(280, 25)
        Me.CloseInstances.TabIndex = 3
        Me.CloseInstances.Text = "Close ROBLOX Instances"
        Me.CloseInstances.UseVisualStyleBackColor = True
        '
        'ExitProgram
        '
        Me.ExitProgram.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.ExitProgram.Location = New System.Drawing.Point(297, 49)
        Me.ExitProgram.Name = "ExitProgram"
        Me.ExitProgram.Size = New System.Drawing.Size(75, 25)
        Me.ExitProgram.TabIndex = 4
        Me.ExitProgram.Text = "Exit Program"
        Me.ExitProgram.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 86)
        Me.Controls.Add(Me.ExitProgram)
        Me.Controls.Add(Me.CloseInstances)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.FPSValue1)
        Me.Controls.Add(Me.SetFPS)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "RUnlocker Visual"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SetFPS As Button
    Friend WithEvents FPSValue1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseInstances As Button
    Friend WithEvents ExitProgram As Button
End Class
