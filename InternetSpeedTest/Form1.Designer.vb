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
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.lblSpeedResult = New System.Windows.Forms.Label()
        Me.lstSpeed = New System.Windows.Forms.ListBox()
        Me.btnEnterSpeed = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.AutoSize = True
        Me.lblHeader.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Location = New System.Drawing.Point(361, 50)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(379, 31)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "Internet  Speed Test Survey"
        '
        'lblSpeedResult
        '
        Me.lblSpeedResult.AutoSize = True
        Me.lblSpeedResult.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblSpeedResult.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpeedResult.Location = New System.Drawing.Point(483, 492)
        Me.lblSpeedResult.Name = "lblSpeedResult"
        Me.lblSpeedResult.Size = New System.Drawing.Size(0, 25)
        Me.lblSpeedResult.TabIndex = 1
        '
        'lstSpeed
        '
        Me.lstSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSpeed.FormattingEnabled = True
        Me.lstSpeed.ItemHeight = 20
        Me.lstSpeed.Location = New System.Drawing.Point(787, 77)
        Me.lstSpeed.Name = "lstSpeed"
        Me.lstSpeed.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstSpeed.Size = New System.Drawing.Size(91, 164)
        Me.lstSpeed.TabIndex = 2
        '
        'btnEnterSpeed
        '
        Me.btnEnterSpeed.BackColor = System.Drawing.Color.Tan
        Me.btnEnterSpeed.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnterSpeed.Location = New System.Drawing.Point(422, 115)
        Me.btnEnterSpeed.Name = "btnEnterSpeed"
        Me.btnEnterSpeed.Size = New System.Drawing.Size(245, 47)
        Me.btnEnterSpeed.TabIndex = 4
        Me.btnEnterSpeed.Text = "Enter Internet Speed"
        Me.btnEnterSpeed.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(702, 394)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 5
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InternetSpeedTest.My.Resources.Resources.speed
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(906, 596)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnEnterSpeed)
        Me.Controls.Add(Me.lstSpeed)
        Me.Controls.Add(Me.lblSpeedResult)
        Me.Controls.Add(Me.lblHeader)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Internet Speed Test Survey for Home Users"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeader As Label
    Friend WithEvents lblSpeedResult As Label
    Friend WithEvents lstSpeed As ListBox
    Friend WithEvents btnEnterSpeed As Button
    Friend WithEvents btnClear As Button
End Class
