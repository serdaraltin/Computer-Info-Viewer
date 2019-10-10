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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pcadi_text = New System.Windows.Forms.TextBox()
        Me.user_text = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.surum_text = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.platform_text = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.localip_text = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dinamikip_text = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dinamikip_button = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pc Adı :"
        '
        'pcadi_text
        '
        Me.pcadi_text.Location = New System.Drawing.Point(72, 19)
        Me.pcadi_text.Name = "pcadi_text"
        Me.pcadi_text.ReadOnly = True
        Me.pcadi_text.Size = New System.Drawing.Size(184, 20)
        Me.pcadi_text.TabIndex = 1
        '
        'user_text
        '
        Me.user_text.Location = New System.Drawing.Point(72, 45)
        Me.user_text.Name = "user_text"
        Me.user_text.ReadOnly = True
        Me.user_text.Size = New System.Drawing.Size(184, 20)
        Me.user_text.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "User    :"
        '
        'surum_text
        '
        Me.surum_text.Location = New System.Drawing.Point(72, 71)
        Me.surum_text.Name = "surum_text"
        Me.surum_text.ReadOnly = True
        Me.surum_text.Size = New System.Drawing.Size(184, 20)
        Me.surum_text.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Sürüm :"
        '
        'platform_text
        '
        Me.platform_text.Location = New System.Drawing.Point(72, 97)
        Me.platform_text.Name = "platform_text"
        Me.platform_text.ReadOnly = True
        Me.platform_text.Size = New System.Drawing.Size(184, 20)
        Me.platform_text.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Platform :"
        '
        'localip_text
        '
        Me.localip_text.Location = New System.Drawing.Point(72, 123)
        Me.localip_text.Name = "localip_text"
        Me.localip_text.ReadOnly = True
        Me.localip_text.Size = New System.Drawing.Size(184, 20)
        Me.localip_text.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Local İp :"
        '
        'dinamikip_text
        '
        Me.dinamikip_text.Location = New System.Drawing.Point(72, 149)
        Me.dinamikip_text.Name = "dinamikip_text"
        Me.dinamikip_text.ReadOnly = True
        Me.dinamikip_text.Size = New System.Drawing.Size(138, 20)
        Me.dinamikip_text.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 152)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Dinamik İp :"
        '
        'dinamikip_button
        '
        Me.dinamikip_button.Location = New System.Drawing.Point(216, 147)
        Me.dinamikip_button.Name = "dinamikip_button"
        Me.dinamikip_button.Size = New System.Drawing.Size(40, 23)
        Me.dinamikip_button.TabIndex = 14
        Me.dinamikip_button.Text = ">"
        Me.dinamikip_button.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label8.Location = New System.Drawing.Point(109, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(144, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Powered By DeadSound"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(265, 206)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.dinamikip_button)
        Me.Controls.Add(Me.dinamikip_text)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.localip_text)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.platform_text)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.surum_text)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.user_text)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.pcadi_text)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Computer İnfo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pcadi_text As System.Windows.Forms.TextBox
    Friend WithEvents user_text As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents surum_text As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents platform_text As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents localip_text As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dinamikip_text As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dinamikip_button As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label

End Class
