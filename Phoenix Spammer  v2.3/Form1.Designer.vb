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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.CarbonFiberTheme1 = New Phoenix_Spammer__v2._3.CarbonFiberTheme()
        Me.txtInt = New Phoenix_Spammer__v2._3.CarbonFiberTextBox()
        Me.CarbonFiberLabel4 = New Phoenix_Spammer__v2._3.CarbonFiberLabel()
        Me.CarbonFiberButton1 = New Phoenix_Spammer__v2._3.CarbonFiberButton()
        Me.txtCounter = New Phoenix_Spammer__v2._3.CarbonFiberTextBox()
        Me.CarbonFiberLabel3 = New Phoenix_Spammer__v2._3.CarbonFiberLabel()
        Me.txtLimit = New Phoenix_Spammer__v2._3.CarbonFiberTextBox()
        Me.CarbonFiberLabel2 = New Phoenix_Spammer__v2._3.CarbonFiberLabel()
        Me.btnClear = New Phoenix_Spammer__v2._3.CarbonFiberButton()
        Me.btnStop = New Phoenix_Spammer__v2._3.CarbonFiberButton()
        Me.btnStart = New Phoenix_Spammer__v2._3.CarbonFiberButton()
        Me.txtSpam = New Phoenix_Spammer__v2._3.CarbonFiberTextBox()
        Me.CarbonFiberLabel1 = New Phoenix_Spammer__v2._3.CarbonFiberLabel()
        Me.CarbonFiberTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 2000
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        Me.BackgroundWorker1.WorkerSupportsCancellation = True
        '
        'CarbonFiberTheme1
        '
        Me.CarbonFiberTheme1.BackColor = System.Drawing.Color.FromArgb(CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer), CType(CType(22, Byte), Integer))
        Me.CarbonFiberTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.CarbonFiberTheme1.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.CarbonFiberTheme1.Controls.Add(Me.txtInt)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberLabel4)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberButton1)
        Me.CarbonFiberTheme1.Controls.Add(Me.txtCounter)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberLabel3)
        Me.CarbonFiberTheme1.Controls.Add(Me.txtLimit)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberLabel2)
        Me.CarbonFiberTheme1.Controls.Add(Me.btnClear)
        Me.CarbonFiberTheme1.Controls.Add(Me.btnStop)
        Me.CarbonFiberTheme1.Controls.Add(Me.btnStart)
        Me.CarbonFiberTheme1.Controls.Add(Me.txtSpam)
        Me.CarbonFiberTheme1.Controls.Add(Me.CarbonFiberLabel1)
        Me.CarbonFiberTheme1.Customization = ""
        Me.CarbonFiberTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CarbonFiberTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberTheme1.Icon = CType(resources.GetObject("CarbonFiberTheme1.Icon"), System.Drawing.Icon)
        Me.CarbonFiberTheme1.Image = CType(resources.GetObject("CarbonFiberTheme1.Image"), System.Drawing.Image)
        Me.CarbonFiberTheme1.Location = New System.Drawing.Point(0, 0)
        Me.CarbonFiberTheme1.Movable = True
        Me.CarbonFiberTheme1.Name = "CarbonFiberTheme1"
        Me.CarbonFiberTheme1.NoRounding = False
        Me.CarbonFiberTheme1.ShowIcon = False
        Me.CarbonFiberTheme1.Sizable = True
        Me.CarbonFiberTheme1.Size = New System.Drawing.Size(641, 223)
        Me.CarbonFiberTheme1.SmartBounds = True
        Me.CarbonFiberTheme1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.CarbonFiberTheme1.TabIndex = 0
        Me.CarbonFiberTheme1.Text = "Stealthy Cat Spammer"
        Me.CarbonFiberTheme1.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CarbonFiberTheme1.Transparent = False
        '
        'txtInt
        '
        Me.txtInt.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.txtInt.Customization = ""
        Me.txtInt.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtInt.Image = Nothing
        Me.txtInt.Location = New System.Drawing.Point(48, 124)
        Me.txtInt.MaxLength = 32767
        Me.txtInt.Multiline = False
        Me.txtInt.Name = "txtInt"
        Me.txtInt.NoRounding = False
        Me.txtInt.ReadOnly = False
        Me.txtInt.Size = New System.Drawing.Size(62, 24)
        Me.txtInt.TabIndex = 10
        Me.txtInt.Text = "1"
        Me.txtInt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtInt.Transparent = False
        Me.txtInt.UseSystemPasswordChar = False
        '
        'CarbonFiberLabel4
        '
        Me.CarbonFiberLabel4.BackColor = System.Drawing.Color.Transparent
        Me.CarbonFiberLabel4.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.CarbonFiberLabel4.Customization = ""
        Me.CarbonFiberLabel4.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberLabel4.Image = Nothing
        Me.CarbonFiberLabel4.Location = New System.Drawing.Point(53, 104)
        Me.CarbonFiberLabel4.Name = "CarbonFiberLabel4"
        Me.CarbonFiberLabel4.NoRounding = False
        Me.CarbonFiberLabel4.Size = New System.Drawing.Size(57, 14)
        Me.CarbonFiberLabel4.TabIndex = 1
        Me.CarbonFiberLabel4.Text = "Interval:"
        Me.CarbonFiberLabel4.Transparent = True
        '
        'CarbonFiberButton1
        '
        Me.CarbonFiberButton1.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.CarbonFiberButton1.Customization = ""
        Me.CarbonFiberButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberButton1.Image = Nothing
        Me.CarbonFiberButton1.Location = New System.Drawing.Point(608, 3)
        Me.CarbonFiberButton1.Name = "CarbonFiberButton1"
        Me.CarbonFiberButton1.NoRounding = False
        Me.CarbonFiberButton1.Size = New System.Drawing.Size(30, 24)
        Me.CarbonFiberButton1.TabIndex = 9
        Me.CarbonFiberButton1.Text = "X"
        Me.CarbonFiberButton1.Transparent = False
        '
        'txtCounter
        '
        Me.txtCounter.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.txtCounter.Customization = ""
        Me.txtCounter.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtCounter.Image = Nothing
        Me.txtCounter.Location = New System.Drawing.Point(543, 176)
        Me.txtCounter.MaxLength = 32767
        Me.txtCounter.Multiline = False
        Me.txtCounter.Name = "txtCounter"
        Me.txtCounter.NoRounding = False
        Me.txtCounter.ReadOnly = False
        Me.txtCounter.Size = New System.Drawing.Size(76, 24)
        Me.txtCounter.TabIndex = 8
        Me.txtCounter.Text = "0"
        Me.txtCounter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtCounter.Transparent = False
        Me.txtCounter.UseSystemPasswordChar = False
        '
        'CarbonFiberLabel3
        '
        Me.CarbonFiberLabel3.BackColor = System.Drawing.Color.Transparent
        Me.CarbonFiberLabel3.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.CarbonFiberLabel3.Customization = ""
        Me.CarbonFiberLabel3.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberLabel3.Image = Nothing
        Me.CarbonFiberLabel3.Location = New System.Drawing.Point(444, 176)
        Me.CarbonFiberLabel3.Name = "CarbonFiberLabel3"
        Me.CarbonFiberLabel3.NoRounding = False
        Me.CarbonFiberLabel3.Size = New System.Drawing.Size(93, 14)
        Me.CarbonFiberLabel3.TabIndex = 7
        Me.CarbonFiberLabel3.Text = "Spam Counter:"
        Me.CarbonFiberLabel3.Transparent = True
        '
        'txtLimit
        '
        Me.txtLimit.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.txtLimit.Customization = ""
        Me.txtLimit.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtLimit.Image = Nothing
        Me.txtLimit.Location = New System.Drawing.Point(363, 176)
        Me.txtLimit.MaxLength = 32767
        Me.txtLimit.Multiline = False
        Me.txtLimit.Name = "txtLimit"
        Me.txtLimit.NoRounding = False
        Me.txtLimit.ReadOnly = False
        Me.txtLimit.Size = New System.Drawing.Size(75, 24)
        Me.txtLimit.TabIndex = 6
        Me.txtLimit.Text = "9999"
        Me.txtLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtLimit.Transparent = False
        Me.txtLimit.UseSystemPasswordChar = False
        '
        'CarbonFiberLabel2
        '
        Me.CarbonFiberLabel2.BackColor = System.Drawing.Color.Transparent
        Me.CarbonFiberLabel2.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.CarbonFiberLabel2.Customization = ""
        Me.CarbonFiberLabel2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberLabel2.Image = Nothing
        Me.CarbonFiberLabel2.Location = New System.Drawing.Point(294, 176)
        Me.CarbonFiberLabel2.Name = "CarbonFiberLabel2"
        Me.CarbonFiberLabel2.NoRounding = False
        Me.CarbonFiberLabel2.Size = New System.Drawing.Size(63, 14)
        Me.CarbonFiberLabel2.TabIndex = 5
        Me.CarbonFiberLabel2.Text = "Set Limit:"
        Me.CarbonFiberLabel2.Transparent = True
        '
        'btnClear
        '
        Me.btnClear.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.btnClear.Customization = ""
        Me.btnClear.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnClear.Image = Nothing
        Me.btnClear.Location = New System.Drawing.Point(48, 60)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.NoRounding = False
        Me.btnClear.Size = New System.Drawing.Size(62, 29)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.Transparent = False
        '
        'btnStop
        '
        Me.btnStop.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.btnStop.Customization = ""
        Me.btnStop.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnStop.Image = Nothing
        Me.btnStop.Location = New System.Drawing.Point(205, 176)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.NoRounding = False
        Me.btnStop.Size = New System.Drawing.Size(83, 29)
        Me.btnStop.TabIndex = 3
        Me.btnStop.Text = "Stop"
        Me.btnStop.Transparent = False
        '
        'btnStart
        '
        Me.btnStart.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.btnStart.Customization = ""
        Me.btnStart.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.btnStart.Image = Nothing
        Me.btnStart.Location = New System.Drawing.Point(116, 176)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.NoRounding = False
        Me.btnStart.Size = New System.Drawing.Size(83, 29)
        Me.btnStart.TabIndex = 2
        Me.btnStart.Text = "Start"
        Me.btnStart.Transparent = False
        '
        'txtSpam
        '
        Me.txtSpam.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.txtSpam.Customization = ""
        Me.txtSpam.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.txtSpam.Image = Nothing
        Me.txtSpam.Location = New System.Drawing.Point(116, 40)
        Me.txtSpam.MaxLength = 32767
        Me.txtSpam.Multiline = True
        Me.txtSpam.Name = "txtSpam"
        Me.txtSpam.NoRounding = False
        Me.txtSpam.ReadOnly = False
        Me.txtSpam.Size = New System.Drawing.Size(503, 130)
        Me.txtSpam.TabIndex = 1
        Me.txtSpam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
        Me.txtSpam.Transparent = False
        Me.txtSpam.UseSystemPasswordChar = False
        '
        'CarbonFiberLabel1
        '
        Me.CarbonFiberLabel1.BackColor = System.Drawing.Color.Transparent
        Me.CarbonFiberLabel1.Colors = New Phoenix_Spammer__v2._3.Bloom(-1) {}
        Me.CarbonFiberLabel1.Customization = ""
        Me.CarbonFiberLabel1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.CarbonFiberLabel1.Image = Nothing
        Me.CarbonFiberLabel1.Location = New System.Drawing.Point(22, 40)
        Me.CarbonFiberLabel1.Name = "CarbonFiberLabel1"
        Me.CarbonFiberLabel1.NoRounding = False
        Me.CarbonFiberLabel1.Size = New System.Drawing.Size(88, 14)
        Me.CarbonFiberLabel1.TabIndex = 0
        Me.CarbonFiberLabel1.Text = "Text to Spam:"
        Me.CarbonFiberLabel1.Transparent = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(641, 223)
        Me.Controls.Add(Me.CarbonFiberTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TopMost = True
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.CarbonFiberTheme1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CarbonFiberTheme1 As CarbonFiberTheme
    Friend WithEvents CarbonFiberLabel1 As CarbonFiberLabel
    Friend WithEvents txtCounter As CarbonFiberTextBox
    Friend WithEvents CarbonFiberLabel3 As CarbonFiberLabel
    Friend WithEvents txtLimit As CarbonFiberTextBox
    Friend WithEvents CarbonFiberLabel2 As CarbonFiberLabel
    Friend WithEvents btnClear As CarbonFiberButton
    Friend WithEvents btnStop As CarbonFiberButton
    Friend WithEvents btnStart As CarbonFiberButton
    Friend WithEvents txtSpam As CarbonFiberTextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents CarbonFiberButton1 As CarbonFiberButton
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents txtInt As CarbonFiberTextBox
    Friend WithEvents CarbonFiberLabel4 As CarbonFiberLabel
End Class
