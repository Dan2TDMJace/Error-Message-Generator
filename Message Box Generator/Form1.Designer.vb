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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Icon16 = New System.Windows.Forms.RadioButton()
        Me.Icon64 = New System.Windows.Forms.RadioButton()
        Me.Icon48 = New System.Windows.Forms.RadioButton()
        Me.Icon32 = New System.Windows.Forms.RadioButton()
        Me.YN = New System.Windows.Forms.RadioButton()
        Me.RTC = New System.Windows.Forms.RadioButton()
        Me.OKC = New System.Windows.Forms.RadioButton()
        Me.Ok = New System.Windows.Forms.RadioButton()
        Me.ARI = New System.Windows.Forms.RadioButton()
        Me.YNC = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(347, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(322, 35)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Message Box Generator"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(155, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 27)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Text"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(462, 517)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Generate!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(43, 79)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(273, 345)
        Me.TextBox1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(348, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 27)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Title"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(339, 79)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(607, 20)
        Me.TextBox2.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(738, 204)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 27)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Buttons"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(457, 204)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 27)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Icon"
        '
        'Icon16
        '
        Me.Icon16.AutoSize = True
        Me.Icon16.Location = New System.Drawing.Point(462, 234)
        Me.Icon16.Name = "Icon16"
        Me.Icon16.Size = New System.Drawing.Size(47, 17)
        Me.Icon16.TabIndex = 21
        Me.Icon16.TabStop = True
        Me.Icon16.Text = "Error"
        Me.Icon16.UseVisualStyleBackColor = False
        '
        'Icon64
        '
        Me.Icon64.AutoSize = True
        Me.Icon64.Location = New System.Drawing.Point(462, 280)
        Me.Icon64.Name = "Icon64"
        Me.Icon64.Size = New System.Drawing.Size(77, 17)
        Me.Icon64.TabIndex = 22
        Me.Icon64.TabStop = True
        Me.Icon64.Text = "Information"
        Me.Icon64.UseVisualStyleBackColor = True
        '
        'Icon48
        '
        Me.Icon48.AutoSize = True
        Me.Icon48.Location = New System.Drawing.Point(462, 257)
        Me.Icon48.Name = "Icon48"
        Me.Icon48.Size = New System.Drawing.Size(65, 17)
        Me.Icon48.TabIndex = 23
        Me.Icon48.TabStop = True
        Me.Icon48.Text = "Warning"
        Me.Icon48.UseVisualStyleBackColor = True
        '
        'Icon32
        '
        Me.Icon32.AutoSize = True
        Me.Icon32.Location = New System.Drawing.Point(462, 303)
        Me.Icon32.Name = "Icon32"
        Me.Icon32.Size = New System.Drawing.Size(67, 17)
        Me.Icon32.TabIndex = 24
        Me.Icon32.TabStop = True
        Me.Icon32.Text = "Question"
        Me.Icon32.UseVisualStyleBackColor = True
        '
        'YN
        '
        Me.YN.AutoSize = True
        Me.YN.Location = New System.Drawing.Point(743, 326)
        Me.YN.Name = "YN"
        Me.YN.Size = New System.Drawing.Size(63, 17)
        Me.YN.TabIndex = 26
        Me.YN.TabStop = True
        Me.YN.Text = "Yes, No"
        Me.YN.UseVisualStyleBackColor = True
        '
        'RTC
        '
        Me.RTC.AutoSize = True
        Me.RTC.Location = New System.Drawing.Point(743, 303)
        Me.RTC.Name = "RTC"
        Me.RTC.Size = New System.Drawing.Size(89, 17)
        Me.RTC.TabIndex = 27
        Me.RTC.TabStop = True
        Me.RTC.Text = "Retry, Cancel"
        Me.RTC.UseVisualStyleBackColor = True
        '
        'OKC
        '
        Me.OKC.AutoSize = True
        Me.OKC.Location = New System.Drawing.Point(743, 280)
        Me.OKC.Name = "OKC"
        Me.OKC.Size = New System.Drawing.Size(78, 17)
        Me.OKC.TabIndex = 28
        Me.OKC.TabStop = True
        Me.OKC.Text = "Ok, Cancel"
        Me.OKC.UseVisualStyleBackColor = True
        '
        'Ok
        '
        Me.Ok.AutoSize = True
        Me.Ok.Location = New System.Drawing.Point(743, 257)
        Me.Ok.Name = "Ok"
        Me.Ok.Size = New System.Drawing.Size(39, 17)
        Me.Ok.TabIndex = 29
        Me.Ok.TabStop = True
        Me.Ok.Text = "Ok"
        Me.Ok.UseVisualStyleBackColor = True
        '
        'ARI
        '
        Me.ARI.AutoSize = True
        Me.ARI.Location = New System.Drawing.Point(743, 234)
        Me.ARI.Name = "ARI"
        Me.ARI.Size = New System.Drawing.Size(117, 17)
        Me.ARI.TabIndex = 30
        Me.ARI.TabStop = True
        Me.ARI.Text = "Abort, Retry, Ignore"
        Me.ARI.UseVisualStyleBackColor = True
        '
        'YNC
        '
        Me.YNC.AutoSize = True
        Me.YNC.Location = New System.Drawing.Point(743, 349)
        Me.YNC.Name = "YNC"
        Me.YNC.Size = New System.Drawing.Size(102, 17)
        Me.YNC.TabIndex = 31
        Me.YNC.TabStop = True
        Me.YNC.Text = "Yes, No, Cancel"
        Me.YNC.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 488)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(895, 26)
        Me.Label6.TabIndex = 32
        Me.Label6.Text = "Important! You cannot change the icon or button after picking (cuz of VB) so choo" &
    "se wisely!"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 583)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.YNC)
        Me.Controls.Add(Me.ARI)
        Me.Controls.Add(Me.Ok)
        Me.Controls.Add(Me.OKC)
        Me.Controls.Add(Me.RTC)
        Me.Controls.Add(Me.YN)
        Me.Controls.Add(Me.Icon32)
        Me.Controls.Add(Me.Icon48)
        Me.Controls.Add(Me.Icon64)
        Me.Controls.Add(Me.Icon16)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Message Box Generator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Icon16 As RadioButton
    Friend WithEvents Icon64 As RadioButton
    Friend WithEvents Icon48 As RadioButton
    Friend WithEvents Icon32 As RadioButton
    Friend WithEvents YN As RadioButton
    Friend WithEvents RTC As RadioButton
    Friend WithEvents OKC As RadioButton
    Friend WithEvents Ok As RadioButton
    Friend WithEvents ARI As RadioButton
    Friend WithEvents YNC As RadioButton
    Friend WithEvents Label6 As Label
End Class
