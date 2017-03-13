<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHeat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmHeat))
        Me.ActivateScreenSaverToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ttInfo = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnSplitMenu = New System.Windows.Forms.ToolStripSplitButton
        Me.CalculatorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BasicToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.txtSecond = New System.Windows.Forms.TextBox
        Me.lblFirst = New System.Windows.Forms.Label
        Me.txtFourth = New System.Windows.Forms.TextBox
        Me.lblThird = New System.Windows.Forms.Label
        Me.lblfourth = New System.Windows.Forms.Label
        Me.lblHeader = New System.Windows.Forms.ToolStripStatusLabel
        Me.lblSecond = New System.Windows.Forms.Label
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.txtFirst = New System.Windows.Forms.TextBox
        Me.btnClear = New System.Windows.Forms.Button
        Me.txtThird = New System.Windows.Forms.TextBox
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.lblAnswer = New System.Windows.Forms.Label
        Me.mnuElectricity = New System.Windows.Forms.MenuStrip
        Me.HeatToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.BoltzmanConstantToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.CubicExpansitivityOfASubstanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdealGaseEquationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdealGasNumberOfMolesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdealGasPressureToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdealGasTemperaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.IdealGasVolumeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InternalEnergyOfAGasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MonatomicInternalEnergyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.DiatomicInternalEnergyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LinearExpansitivityOfASubstanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpecificHeatCapacityOfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SpecificLatentHeatOfVapourisationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox
        Me.StatusStrip1.SuspendLayout()
        Me.mnuElectricity.SuspendLayout()
        Me.SuspendLayout()
        '
        'ActivateScreenSaverToolStripMenuItem
        '
        Me.ActivateScreenSaverToolStripMenuItem.Name = "ActivateScreenSaverToolStripMenuItem"
        Me.ActivateScreenSaverToolStripMenuItem.Size = New System.Drawing.Size(236, 22)
        Me.ActivateScreenSaverToolStripMenuItem.Text = "Activate Screen Saver"
        '
        'ttInfo
        '
        Me.ttInfo.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.ttInfo.ToolTipTitle = "Physics Calculator"
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
        'CalculatorToolStripMenuItem
        '
        Me.CalculatorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BasicToolStripMenuItem})
        Me.CalculatorToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CalculatorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
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
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.White
        Me.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCalculate.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(380, 150)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(83, 28)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'txtSecond
        '
        Me.txtSecond.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSecond.Location = New System.Drawing.Point(16, 135)
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
        Me.lblFirst.Location = New System.Drawing.Point(12, 54)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(351, 23)
        Me.lblFirst.TabIndex = 0
        Me.lblFirst.Text = "First"
        '
        'txtFourth
        '
        Me.txtFourth.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFourth.Location = New System.Drawing.Point(16, 248)
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
        Me.lblThird.Location = New System.Drawing.Point(10, 166)
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
        Me.lblfourth.Location = New System.Drawing.Point(12, 222)
        Me.lblfourth.Name = "lblfourth"
        Me.lblfourth.Size = New System.Drawing.Size(351, 23)
        Me.lblfourth.TabIndex = 6
        Me.lblfourth.Text = "Fourth"
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
        'lblSecond
        '
        Me.lblSecond.BackColor = System.Drawing.Color.Transparent
        Me.lblSecond.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSecond.ForeColor = System.Drawing.Color.White
        Me.lblSecond.Location = New System.Drawing.Point(12, 109)
        Me.lblSecond.Name = "lblSecond"
        Me.lblSecond.Size = New System.Drawing.Size(351, 23)
        Me.lblSecond.TabIndex = 2
        Me.lblSecond.Text = "Second"
        '
        'txtAnswer
        '
        Me.txtAnswer.BackColor = System.Drawing.Color.White
        Me.txtAnswer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(494, 166)
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
        Me.txtFirst.Location = New System.Drawing.Point(16, 80)
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(347, 27)
        Me.txtFirst.TabIndex = 1
        Me.txtFirst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.White
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClear.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(380, 184)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(83, 28)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'txtThird
        '
        Me.txtThird.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtThird.Location = New System.Drawing.Point(16, 192)
        Me.txtThird.Name = "txtThird"
        Me.txtThird.Size = New System.Drawing.Size(347, 27)
        Me.txtThird.TabIndex = 5
        Me.txtThird.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.lblHeader, Me.btnSplitMenu})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 495)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(794, 38)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 107
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.Color.Transparent
        Me.lblAnswer.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnswer.ForeColor = System.Drawing.Color.White
        Me.lblAnswer.Location = New System.Drawing.Point(490, 121)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(292, 42)
        Me.lblAnswer.TabIndex = 10
        Me.lblAnswer.Text = "Answer"
        '
        'mnuElectricity
        '
        Me.mnuElectricity.BackColor = System.Drawing.Color.White
        Me.mnuElectricity.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.mnuElectricity.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HeatToolStripMenuItem, Me.CalculatorToolStripMenuItem})
        Me.mnuElectricity.Location = New System.Drawing.Point(0, 0)
        Me.mnuElectricity.Name = "mnuElectricity"
        Me.mnuElectricity.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.mnuElectricity.Size = New System.Drawing.Size(794, 24)
        Me.mnuElectricity.TabIndex = 106
        Me.mnuElectricity.Text = "MenuStrip1"
        '
        'HeatToolStripMenuItem
        '
        Me.HeatToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BoltzmanConstantToolStripMenuItem, Me.CubicExpansitivityOfASubstanceToolStripMenuItem, Me.IdealGaseEquationToolStripMenuItem, Me.InternalEnergyOfAGasToolStripMenuItem, Me.LinearExpansitivityOfASubstanceToolStripMenuItem, Me.SpecificHeatCapacityOfToolStripMenuItem, Me.SpecificLatentHeatOfVapourisationToolStripMenuItem})
        Me.HeatToolStripMenuItem.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HeatToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.HeatToolStripMenuItem.Name = "HeatToolStripMenuItem"
        Me.HeatToolStripMenuItem.Size = New System.Drawing.Size(94, 20)
        Me.HeatToolStripMenuItem.Text = " Heat Menu"
        '
        'BoltzmanConstantToolStripMenuItem
        '
        Me.BoltzmanConstantToolStripMenuItem.Name = "BoltzmanConstantToolStripMenuItem"
        Me.BoltzmanConstantToolStripMenuItem.Size = New System.Drawing.Size(425, 22)
        Me.BoltzmanConstantToolStripMenuItem.Text = "Boltzman Constant"
        '
        'CubicExpansitivityOfASubstanceToolStripMenuItem
        '
        Me.CubicExpansitivityOfASubstanceToolStripMenuItem.Name = "CubicExpansitivityOfASubstanceToolStripMenuItem"
        Me.CubicExpansitivityOfASubstanceToolStripMenuItem.Size = New System.Drawing.Size(425, 22)
        Me.CubicExpansitivityOfASubstanceToolStripMenuItem.Text = "Cubic expansitivity of a liquid"
        '
        'IdealGaseEquationToolStripMenuItem
        '
        Me.IdealGaseEquationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdealGasNumberOfMolesToolStripMenuItem, Me.IdealGasPressureToolStripMenuItem, Me.IdealGasTemperaToolStripMenuItem, Me.IdealGasVolumeToolStripMenuItem})
        Me.IdealGaseEquationToolStripMenuItem.Name = "IdealGaseEquationToolStripMenuItem"
        Me.IdealGaseEquationToolStripMenuItem.Size = New System.Drawing.Size(425, 22)
        Me.IdealGaseEquationToolStripMenuItem.Text = "Ideal Gase Equation"
        '
        'IdealGasNumberOfMolesToolStripMenuItem
        '
        Me.IdealGasNumberOfMolesToolStripMenuItem.Name = "IdealGasNumberOfMolesToolStripMenuItem"
        Me.IdealGasNumberOfMolesToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.IdealGasNumberOfMolesToolStripMenuItem.Text = "Ideal gas Number of moles"
        '
        'IdealGasPressureToolStripMenuItem
        '
        Me.IdealGasPressureToolStripMenuItem.Name = "IdealGasPressureToolStripMenuItem"
        Me.IdealGasPressureToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.IdealGasPressureToolStripMenuItem.Text = "Ideal gas Pressure"
        '
        'IdealGasTemperaToolStripMenuItem
        '
        Me.IdealGasTemperaToolStripMenuItem.Name = "IdealGasTemperaToolStripMenuItem"
        Me.IdealGasTemperaToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.IdealGasTemperaToolStripMenuItem.Text = "Ideal gas Temperature"
        '
        'IdealGasVolumeToolStripMenuItem
        '
        Me.IdealGasVolumeToolStripMenuItem.Name = "IdealGasVolumeToolStripMenuItem"
        Me.IdealGasVolumeToolStripMenuItem.Size = New System.Drawing.Size(259, 22)
        Me.IdealGasVolumeToolStripMenuItem.Text = "Ideal gas Volume"
        '
        'InternalEnergyOfAGasToolStripMenuItem
        '
        Me.InternalEnergyOfAGasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MonatomicInternalEnergyToolStripMenuItem, Me.DiatomicInternalEnergyToolStripMenuItem})
        Me.InternalEnergyOfAGasToolStripMenuItem.Name = "InternalEnergyOfAGasToolStripMenuItem"
        Me.InternalEnergyOfAGasToolStripMenuItem.Size = New System.Drawing.Size(425, 22)
        Me.InternalEnergyOfAGasToolStripMenuItem.Text = "Internal Energy of a gas"
        '
        'MonatomicInternalEnergyToolStripMenuItem
        '
        Me.MonatomicInternalEnergyToolStripMenuItem.Name = "MonatomicInternalEnergyToolStripMenuItem"
        Me.MonatomicInternalEnergyToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.MonatomicInternalEnergyToolStripMenuItem.Text = "Monatomic Internal Energy"
        '
        'DiatomicInternalEnergyToolStripMenuItem
        '
        Me.DiatomicInternalEnergyToolStripMenuItem.Name = "DiatomicInternalEnergyToolStripMenuItem"
        Me.DiatomicInternalEnergyToolStripMenuItem.Size = New System.Drawing.Size(264, 22)
        Me.DiatomicInternalEnergyToolStripMenuItem.Text = "Diatomic Internal Energy"
        '
        'LinearExpansitivityOfASubstanceToolStripMenuItem
        '
        Me.LinearExpansitivityOfASubstanceToolStripMenuItem.Name = "LinearExpansitivityOfASubstanceToolStripMenuItem"
        Me.LinearExpansitivityOfASubstanceToolStripMenuItem.Size = New System.Drawing.Size(425, 22)
        Me.LinearExpansitivityOfASubstanceToolStripMenuItem.Text = "Linear expansitivity of a substance"
        '
        'SpecificHeatCapacityOfToolStripMenuItem
        '
        Me.SpecificHeatCapacityOfToolStripMenuItem.Name = "SpecificHeatCapacityOfToolStripMenuItem"
        Me.SpecificHeatCapacityOfToolStripMenuItem.Size = New System.Drawing.Size(425, 22)
        Me.SpecificHeatCapacityOfToolStripMenuItem.Text = "Specific heat capacity of material"
        '
        'SpecificLatentHeatOfVapourisationToolStripMenuItem
        '
        Me.SpecificLatentHeatOfVapourisationToolStripMenuItem.Name = "SpecificLatentHeatOfVapourisationToolStripMenuItem"
        Me.SpecificLatentHeatOfVapourisationToolStripMenuItem.Size = New System.Drawing.Size(425, 22)
        Me.SpecificLatentHeatOfVapourisationToolStripMenuItem.Text = "Specific latent heat of vapourization of a substance"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.Location = New System.Drawing.Point(16, 281)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth
        Me.RichTextBox1.Size = New System.Drawing.Size(766, 211)
        Me.RichTextBox1.TabIndex = 109
        Me.RichTextBox1.Text = resources.GetString("RichTextBox1.Text")
        '
        'frmHeat
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CancelButton = Me.btnClear
        Me.ClientSize = New System.Drawing.Size(794, 533)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.txtSecond)
        Me.Controls.Add(Me.lblFirst)
        Me.Controls.Add(Me.txtFourth)
        Me.Controls.Add(Me.lblThird)
        Me.Controls.Add(Me.lblfourth)
        Me.Controls.Add(Me.lblSecond)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.txtFirst)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.txtThird)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.mnuElectricity)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmHeat"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Heat"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.mnuElectricity.ResumeLayout(False)
        Me.mnuElectricity.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ActivateScreenSaverToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutUsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ttInfo As System.Windows.Forms.ToolTip
    Friend WithEvents btnSplitMenu As System.Windows.Forms.ToolStripSplitButton
    Friend WithEvents CalculatorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BasicToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ScientificToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents txtSecond As System.Windows.Forms.TextBox
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents txtFourth As System.Windows.Forms.TextBox
    Friend WithEvents lblThird As System.Windows.Forms.Label
    Friend WithEvents lblfourth As System.Windows.Forms.Label
    Friend WithEvents lblHeader As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents lblSecond As System.Windows.Forms.Label
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents txtThird As System.Windows.Forms.TextBox
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents lblAnswer As System.Windows.Forms.Label
    Friend WithEvents mnuElectricity As System.Windows.Forms.MenuStrip
    Friend WithEvents HeatToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BoltzmanConstantToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CubicExpansitivityOfASubstanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdealGaseEquationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdealGasNumberOfMolesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdealGasPressureToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InternalEnergyOfAGasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LinearExpansitivityOfASubstanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecificHeatCapacityOfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpecificLatentHeatOfVapourisationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdealGasTemperaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IdealGasVolumeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonatomicInternalEnergyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DiatomicInternalEnergyToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
End Class
