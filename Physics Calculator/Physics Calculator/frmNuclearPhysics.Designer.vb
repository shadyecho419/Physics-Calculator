<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNuclearPhysics
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNuclearPhysics))
        Me.txtThird = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblHeader = New System.Windows.Forms.ToolStripStatusLabel
        Me.btnSplitMenu = New System.Windows.Forms.ToolStripSplitButton
        Me.ActivateScreenSaverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.lblAnswer = New System.Windows.Forms.Label
        Me.mnuElectricity = New System.Windows.Forms.MenuStrip
        Me.NuclearPhysicsMenuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ActivityRateOfDecayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.EinsteinsMassEnergyRelationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.HalfLifeOfAnElementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NumberOfAtomsAtEndTimeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.NuclearRadiusOfAnAtomToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.txtSecond = New System.Windows.Forms.TextBox
        Me.lblFirst = New System.Windows.Forms.Label
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtFourth = New System.Windows.Forms.TextBox
        Me.lblThird = New System.Windows.Forms.Label
        Me.lblfourth = New System.Windows.Forms.Label
        Me.lblSecond = New System.Windows.Forms.Label
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.StatusStrip1.SuspendLayout()
        Me.mnuElectricity.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtThird
        '
        Me.txtThird.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThird.Location = New System.Drawing.Point(16, 183)
        Me.txtThird.Name = "txtThird"
        Me.txtThird.Size = New System.Drawing.Size(347, 27)
        Me.txtThird.TabIndex = 5
        Me.txtThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblHeader, Me.btnSplitMenu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 495)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(794, 38)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 122
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblHeader
        '
        Me.lblHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.lblHeader.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
                    Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.lblHeader.BorderStyle = System.Windows.Forms.Border3DStyle.Raised
        Me.lblHeader.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(731, 33)
        Me.lblHeader.Spring = True
        Me.lblHeader.Text = "Physics Calculator"
        '
        'btnSplitMenu
        '
        Me.btnSplitMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnSplitMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivateScreenSaverToolStripMenuItem})
        Me.btnSplitMenu.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSplitMenu.Image = CType(resources.GetObject("btnSplitMenu.Image"), System.Drawing.Image)
        Me.btnSplitMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnSplitMenu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSplitMenu.Name = "btnSplitMenu"
        Me.btnSplitMenu.Size = New System.Drawing.Size(48, 36)
        Me.btnSplitMenu.Text = "ToolStripSplitButton1"
        '
        'ActivateScreenSaverToolStripMenuItem
        '
        Me.ActivateScreenSaverToolStripMenuItem.Name = "ActivateScreenSaverToolStripMenuItem"
        Me.ActivateScreenSaverToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ActivateScreenSaverToolStripMenuItem.Text = "Activate Screen Saver"
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.White
        Me.lblAnswer.Location = New System.Drawing.Point(490, 112)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(292, 42)
        Me.lblAnswer.TabIndex = 10
        Me.lblAnswer.Text = "Answer"
        '
        'mnuElectricity
        '
        Me.mnuElectricity.BackColor = System.Drawing.Color.White
        Me.mnuElectricity.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.mnuElectricity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuElectricity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuclearPhysicsMenuToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.mnuElectricity.Location = New System.Drawing.Point(0, 0)
        Me.mnuElectricity.Name = "mnuElectricity"
        Me.mnuElectricity.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuElectricity.Size = New System.Drawing.Size(794, 24)
        Me.mnuElectricity.TabIndex = 121
        Me.mnuElectricity.Text = "MenuStrip1"
        '
        'NuclearPhysicsMenuToolStripMenuItem
        '
        Me.NuclearPhysicsMenuToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ActivityRateOfDecayToolStripMenuItem, Me.EinsteinsMassEnergyRelationToolStripMenuItem, Me.HalfLifeOfAnElementToolStripMenuItem, Me.NumberOfAtomsAtEndTimeToolStripMenuItem, Me.NuclearRadiusOfAnAtomToolStripMenuItem})
        Me.NuclearPhysicsMenuToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NuclearPhysicsMenuToolStripMenuItem.Name = "NuclearPhysicsMenuToolStripMenuItem"
        Me.NuclearPhysicsMenuToolStripMenuItem.Size = New System.Drawing.Size(159, 20)
        Me.NuclearPhysicsMenuToolStripMenuItem.Text = "Nuclear Physics Menu"
        '
        'ActivityRateOfDecayToolStripMenuItem
        '
        Me.ActivityRateOfDecayToolStripMenuItem.Name = "ActivityRateOfDecayToolStripMenuItem"
        Me.ActivityRateOfDecayToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.ActivityRateOfDecayToolStripMenuItem.Text = "Activity (Rate of Decay)"
        '
        'EinsteinsMassEnergyRelationToolStripMenuItem
        '
        Me.EinsteinsMassEnergyRelationToolStripMenuItem.Name = "EinsteinsMassEnergyRelationToolStripMenuItem"
        Me.EinsteinsMassEnergyRelationToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.EinsteinsMassEnergyRelationToolStripMenuItem.Text = "Einstein's Mass energy relation"
        '
        'HalfLifeOfAnElementToolStripMenuItem
        '
        Me.HalfLifeOfAnElementToolStripMenuItem.Name = "HalfLifeOfAnElementToolStripMenuItem"
        Me.HalfLifeOfAnElementToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.HalfLifeOfAnElementToolStripMenuItem.Text = "Half Life of an element"
        '
        'NumberOfAtomsAtEndTimeToolStripMenuItem
        '
        Me.NumberOfAtomsAtEndTimeToolStripMenuItem.Name = "NumberOfAtomsAtEndTimeToolStripMenuItem"
        Me.NumberOfAtomsAtEndTimeToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.NumberOfAtomsAtEndTimeToolStripMenuItem.Text = "Number of atoms at end time"
        '
        'NuclearRadiusOfAnAtomToolStripMenuItem
        '
        Me.NuclearRadiusOfAnAtomToolStripMenuItem.Name = "NuclearRadiusOfAnAtomToolStripMenuItem"
        Me.NuclearRadiusOfAnAtomToolStripMenuItem.Size = New System.Drawing.Size(291, 22)
        Me.NuclearRadiusOfAnAtomToolStripMenuItem.Text = "Nuclear radius of an atom"
        '
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorToolStripMenuItem.Name = "CalculatorToolStripMenuItem"
        Me.CalculatorToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.CalculatorToolStripMenuItem.Text = "Calculator"
        '
        'BasicToolStripMenuItem
        '
        Me.BasicToolStripMenuItem.Name = "BasicToolStripMenuItem"
        Me.BasicToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.BasicToolStripMenuItem.Text = "Activate Calculator"
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(380, 175)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 28)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.White
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(380, 141)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(83, 28)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(16, 126)
        Me.txtSecond.Name = "txtSecond"
        Me.txtSecond.Size = New System.Drawing.Size(347, 27)
        Me.txtSecond.TabIndex = 3
        Me.txtSecond.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblFirst
        '
        Me.lblFirst.BackColor = System.Drawing.Color.Transparent
        Me.lblFirst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirst.ForeColor = System.Drawing.Color.White
        Me.lblFirst.Location = New System.Drawing.Point(12, 45)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(351, 23)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "First"
        '
        'ttInfo
        '
        Me.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttInfo.ToolTipTitle = "Physics Calculator"
        '
        'txtFourth
        '
        Me.txtFourth.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFourth.Location = New System.Drawing.Point(16, 239)
        Me.txtFourth.Name = "txtFourth"
        Me.txtFourth.Size = New System.Drawing.Size(347, 27)
        Me.txtFourth.TabIndex = 7
        Me.txtFourth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblThird
        '
        Me.lblThird.BackColor = System.Drawing.Color.Transparent
        Me.lblThird.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblThird.ForeColor = System.Drawing.Color.White
        Me.lblThird.Location = New System.Drawing.Point(10, 157)
        Me.lblThird.Name = "lblThird"
        Me.lblThird.Size = New System.Drawing.Size(353, 23)
        Me.lblThird.TabIndex = 4
        Me.lblThird.Text = "Third"
        '
        'lblfourth
        '
        Me.lblfourth.BackColor = System.Drawing.Color.Transparent
        Me.lblfourth.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfourth.ForeColor = System.Drawing.Color.White
        Me.lblfourth.Location = New System.Drawing.Point(12, 213)
        Me.lblfourth.Name = "lblfourth"
        Me.lblfourth.Size = New System.Drawing.Size(351, 23)
        Me.lblfourth.TabIndex = 6
        Me.lblfourth.Text = "Fourth"
        '
        'lblSecond
        '
        Me.lblSecond.BackColor = System.Drawing.Color.Transparent
        Me.lblSecond.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.ForeColor = System.Drawing.Color.White
        Me.lblSecond.Location = New System.Drawing.Point(12, 100)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(351, 23)
        Me.lblSecond.TabIndex = 2
        Me.lblSecond.Text = "Second"
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(494, 157)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.ReadOnly = True
        Me.txtAnswer.Size = New System.Drawing.Size(288, 27)
        Me.txtAnswer.TabIndex = 11
        Me.txtAnswer.Text = "0"
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtFirst
        '
        Me.txtFirst.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirst.Location = New System.Drawing.Point(16, 71)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(347, 27)
        Me.txtFirst.TabIndex = 1
        Me.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 272)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(766, 220)
        Me.RichTextBox1.TabIndex = 124
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'frmNuclearPhysics
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(794, 533)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.txtThird)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.mnuElectricity)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtFourth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblfourth)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtFirst)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmNuclearPhysics"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuclear Physics"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnuElectricity.ResumeLayout(False)
        Me.mnuElectricity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtThird As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblHeader As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents btnSplitMenu As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents ActivateScreenSaverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents mnuElectricity As System.Windows.Forms.MenuStrip
    Friend WithEvents NuclearPhysicsMenuToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents ttInfo As System.Windows.Forms.ToolTip
    Friend WithEvents txtFourth As System.Windows.Forms.TextBox
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents lblfourth As System.Windows.Forms.Label
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents ActivityRateOfDecayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinsteinsMassEnergyRelationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HalfLifeOfAnElementToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NumberOfAtomsAtEndTimeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuclearRadiusOfAnAtomToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
