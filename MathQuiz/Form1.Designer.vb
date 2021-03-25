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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.addA = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.addB = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.addC = New System.Windows.Forms.NumericUpDown()
        Me.subA = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.subB = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.subC = New System.Windows.Forms.NumericUpDown()
        Me.mtpA = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.mtpB = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.mtpC = New System.Windows.Forms.NumericUpDown()
        Me.divA = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.divB = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.divC = New System.Windows.Forms.NumericUpDown()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.addC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.subC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.mtpC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.divC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Time left"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TextBox1.Location = New System.Drawing.Point(76, 24)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'addA
        '
        Me.addA.AutoSize = True
        Me.addA.Location = New System.Drawing.Point(23, 69)
        Me.addA.Name = "addA"
        Me.addA.Size = New System.Drawing.Size(13, 13)
        Me.addA.TabIndex = 2
        Me.addA.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(56, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "+"
        '
        'addB
        '
        Me.addB.AutoSize = True
        Me.addB.Location = New System.Drawing.Point(93, 69)
        Me.addB.Name = "addB"
        Me.addB.Size = New System.Drawing.Size(13, 13)
        Me.addB.TabIndex = 4
        Me.addB.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(133, 69)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "="
        '
        'addC
        '
        Me.addC.Location = New System.Drawing.Point(168, 67)
        Me.addC.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.addC.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.addC.Name = "addC"
        Me.addC.Size = New System.Drawing.Size(83, 20)
        Me.addC.TabIndex = 6
        '
        'subA
        '
        Me.subA.AutoSize = True
        Me.subA.Location = New System.Drawing.Point(23, 106)
        Me.subA.Name = "subA"
        Me.subA.Size = New System.Drawing.Size(13, 13)
        Me.subA.TabIndex = 2
        Me.subA.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(56, 106)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(10, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "-"
        '
        'subB
        '
        Me.subB.AutoSize = True
        Me.subB.Location = New System.Drawing.Point(93, 106)
        Me.subB.Name = "subB"
        Me.subB.Size = New System.Drawing.Size(13, 13)
        Me.subB.TabIndex = 4
        Me.subB.Text = "0"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(133, 106)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 5
        Me.Label9.Text = "="
        '
        'subC
        '
        Me.subC.Location = New System.Drawing.Point(168, 104)
        Me.subC.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.subC.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.subC.Name = "subC"
        Me.subC.Size = New System.Drawing.Size(83, 20)
        Me.subC.TabIndex = 6
        '
        'mtpA
        '
        Me.mtpA.AutoSize = True
        Me.mtpA.Location = New System.Drawing.Point(23, 143)
        Me.mtpA.Name = "mtpA"
        Me.mtpA.Size = New System.Drawing.Size(13, 13)
        Me.mtpA.TabIndex = 2
        Me.mtpA.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(56, 143)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "*"
        '
        'mtpB
        '
        Me.mtpB.AutoSize = True
        Me.mtpB.Location = New System.Drawing.Point(93, 143)
        Me.mtpB.Name = "mtpB"
        Me.mtpB.Size = New System.Drawing.Size(13, 13)
        Me.mtpB.TabIndex = 4
        Me.mtpB.Text = "0"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(133, 143)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "="
        '
        'mtpC
        '
        Me.mtpC.Location = New System.Drawing.Point(168, 141)
        Me.mtpC.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.mtpC.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.mtpC.Name = "mtpC"
        Me.mtpC.Size = New System.Drawing.Size(83, 20)
        Me.mtpC.TabIndex = 6
        '
        'divA
        '
        Me.divA.AutoSize = True
        Me.divA.Location = New System.Drawing.Point(23, 178)
        Me.divA.Name = "divA"
        Me.divA.Size = New System.Drawing.Size(13, 13)
        Me.divA.TabIndex = 2
        Me.divA.Text = "0"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(56, 178)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(12, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "/"
        '
        'divB
        '
        Me.divB.AutoSize = True
        Me.divB.Location = New System.Drawing.Point(93, 178)
        Me.divB.Name = "divB"
        Me.divB.Size = New System.Drawing.Size(13, 13)
        Me.divB.TabIndex = 4
        Me.divB.Text = "0"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(133, 178)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 13)
        Me.Label17.TabIndex = 5
        Me.Label17.Text = "="
        '
        'divC
        '
        Me.divC.Location = New System.Drawing.Point(168, 176)
        Me.divC.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.divC.Minimum = New Decimal(New Integer() {10000, 0, 0, -2147483648})
        Me.divC.Name = "divC"
        Me.divC.Size = New System.Drawing.Size(83, 20)
        Me.divC.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(76, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Start Quiz!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(328, 247)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.divC)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.mtpC)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.subC)
        Me.Controls.Add(Me.divB)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.mtpB)
        Me.Controls.Add(Me.addC)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.subB)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.divA)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.mtpA)
        Me.Controls.Add(Me.addB)
        Me.Controls.Add(Me.subA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.addA)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.addC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.subC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.mtpC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.divC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents addA As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents addB As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents addC As NumericUpDown
    Friend WithEvents subA As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents subB As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents subC As NumericUpDown
    Friend WithEvents mtpA As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents mtpB As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents mtpC As NumericUpDown
    Friend WithEvents divA As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents divB As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents divC As NumericUpDown
    Friend WithEvents Button1 As Button
End Class
