<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMetricConvertor
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ConversionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PoundsKilogramsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PoundToKilogramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.KilogramToPoundToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnitsOfToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.MetresToFeetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.FeetToMetresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UnitsOfSubstanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.LitresToGallonsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.GallonsToLitresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.txtAnswer = New System.Windows.Forms.TextBox
        Me.txtQuantity = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnCalculate = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ConversionsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(205, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ConversionsToolStripMenuItem
        '
        Me.ConversionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoundsKilogramsToolStripMenuItem, Me.UnitsOfToolStripMenuItem, Me.UnitsOfSubstanceToolStripMenuItem})
        Me.ConversionsToolStripMenuItem.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ConversionsToolStripMenuItem.Name = "ConversionsToolStripMenuItem"
        Me.ConversionsToolStripMenuItem.Size = New System.Drawing.Size(106, 20)
        Me.ConversionsToolStripMenuItem.Text = "Conversions"
        '
        'PoundsKilogramsToolStripMenuItem
        '
        Me.PoundsKilogramsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PoundToKilogramToolStripMenuItem, Me.KilogramToPoundToolStripMenuItem})
        Me.PoundsKilogramsToolStripMenuItem.Name = "PoundsKilogramsToolStripMenuItem"
        Me.PoundsKilogramsToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.PoundsKilogramsToolStripMenuItem.Text = "Units of Mass"
        '
        'PoundToKilogramToolStripMenuItem
        '
        Me.PoundToKilogramToolStripMenuItem.Name = "PoundToKilogramToolStripMenuItem"
        Me.PoundToKilogramToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.PoundToKilogramToolStripMenuItem.Text = "Pound to Kilogram"
        '
        'KilogramToPoundToolStripMenuItem
        '
        Me.KilogramToPoundToolStripMenuItem.Name = "KilogramToPoundToolStripMenuItem"
        Me.KilogramToPoundToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.KilogramToPoundToolStripMenuItem.Text = "Kilogram to Pound"
        '
        'UnitsOfToolStripMenuItem
        '
        Me.UnitsOfToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MetresToFeetToolStripMenuItem, Me.FeetToMetresToolStripMenuItem})
        Me.UnitsOfToolStripMenuItem.Name = "UnitsOfToolStripMenuItem"
        Me.UnitsOfToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.UnitsOfToolStripMenuItem.Text = "Units of Length"
        '
        'MetresToFeetToolStripMenuItem
        '
        Me.MetresToFeetToolStripMenuItem.Name = "MetresToFeetToolStripMenuItem"
        Me.MetresToFeetToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.MetresToFeetToolStripMenuItem.Text = "Metres to Feet"
        '
        'FeetToMetresToolStripMenuItem
        '
        Me.FeetToMetresToolStripMenuItem.Name = "FeetToMetresToolStripMenuItem"
        Me.FeetToMetresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.FeetToMetresToolStripMenuItem.Text = "Feet to Metres"
        '
        'UnitsOfSubstanceToolStripMenuItem
        '
        Me.UnitsOfSubstanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LitresToGallonsToolStripMenuItem, Me.GallonsToLitresToolStripMenuItem})
        Me.UnitsOfSubstanceToolStripMenuItem.Name = "UnitsOfSubstanceToolStripMenuItem"
        Me.UnitsOfSubstanceToolStripMenuItem.Size = New System.Drawing.Size(210, 22)
        Me.UnitsOfSubstanceToolStripMenuItem.Text = "Units of Substance"
        '
        'LitresToGallonsToolStripMenuItem
        '
        Me.LitresToGallonsToolStripMenuItem.Name = "LitresToGallonsToolStripMenuItem"
        Me.LitresToGallonsToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.LitresToGallonsToolStripMenuItem.Text = "Litres to Gallons"
        '
        'GallonsToLitresToolStripMenuItem
        '
        Me.GallonsToLitresToolStripMenuItem.Name = "GallonsToLitresToolStripMenuItem"
        Me.GallonsToLitresToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.GallonsToLitresToolStripMenuItem.Text = "Gallons to Litres"
        '
        'txtAnswer
        '
        Me.txtAnswer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAnswer.Location = New System.Drawing.Point(30, 139)
        Me.txtAnswer.Name = "txtAnswer"
        Me.txtAnswer.Size = New System.Drawing.Size(147, 22)
        Me.txtAnswer.TabIndex = 1
        Me.txtAnswer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(30, 50)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(147, 22)
        Me.txtQuantity.TabIndex = 2
        Me.txtQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Quantity"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Answer"
        '
        'btnCalculate
        '
        Me.btnCalculate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.Location = New System.Drawing.Point(49, 85)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(61, 23)
        Me.btnCalculate.TabIndex = 5
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(116, 86)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(61, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 171)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(205, 22)
        Me.StatusStrip1.SizingGrip = False
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(190, 17)
        Me.ToolStripStatusLabel1.Spring = True
        Me.ToolStripStatusLabel1.Text = "Metric Convertor"
        '
        'frmMetricConvertor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(205, 193)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.txtAnswer)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmMetricConvertor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Metric Convertor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ConversionsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoundsKilogramsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PoundToKilogramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KilogramToPoundToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitsOfToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MetresToFeetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeetToMetresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UnitsOfSubstanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LitresToGallonsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GallonsToLitresToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents txtAnswer As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCalculate As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
End Class
