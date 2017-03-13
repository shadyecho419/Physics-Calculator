<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mdiPhysicsHome
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(mdiPhysicsHome))
        Me.StatusStrip = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.tsMain1 = New System.Windows.Forms.ToolStrip
        Me.tsMain2 = New System.Windows.Forms.ToolStrip
        Me.btnFormulas = New System.Windows.Forms.ToolStripButton
        Me.btnElectricity = New System.Windows.Forms.ToolStripButton
        Me.btnGeometricalOptics = New System.Windows.Forms.ToolStripButton
        Me.btnHeat = New System.Windows.Forms.ToolStripButton
        Me.btnMechanics = New System.Windows.Forms.ToolStripButton
        Me.btnNuclearPhysics = New System.Windows.Forms.ToolStripButton
        Me.btnUnits = New System.Windows.Forms.ToolStripButton
        Me.btnAbout = New System.Windows.Forms.ToolStripButton
        Me.StatusStrip.SuspendLayout()
        Me.tsMain1.SuspendLayout()
        Me.tsMain2.SuspendLayout()
        Me.SuspendLayout()
        '
        'StatusStrip
        '
        Me.StatusStrip.BackColor = System.Drawing.Color.White
        Me.StatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel})
        Me.StatusStrip.Location = New System.Drawing.Point(0, 726)
        Me.StatusStrip.Name = "StatusStrip"
        Me.StatusStrip.Size = New System.Drawing.Size(1028, 22)
        Me.StatusStrip.TabIndex = 7
        Me.StatusStrip.Text = "StatusStrip"
        '
        'ToolStripStatusLabel
        '
        Me.ToolStripStatusLabel.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripStatusLabel.Name = "ToolStripStatusLabel"
        Me.ToolStripStatusLabel.Size = New System.Drawing.Size(1013, 17)
        Me.ToolStripStatusLabel.Spring = True
        Me.ToolStripStatusLabel.Text = "Welcome to the Physics Calculator"
        '
        'tsMain1
        '
        Me.tsMain1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsMain1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnElectricity, Me.btnGeometricalOptics, Me.btnHeat, Me.btnMechanics, Me.btnNuclearPhysics})
        Me.tsMain1.Location = New System.Drawing.Point(0, 0)
        Me.tsMain1.Name = "tsMain1"
        Me.tsMain1.Size = New System.Drawing.Size(1028, 47)
        Me.tsMain1.TabIndex = 9
        '
        'tsMain2
        '
        Me.tsMain2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.tsMain2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.tsMain2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnFormulas, Me.btnUnits, Me.btnAbout})
        Me.tsMain2.Location = New System.Drawing.Point(0, 679)
        Me.tsMain2.Name = "tsMain2"
        Me.tsMain2.Size = New System.Drawing.Size(1028, 47)
        Me.tsMain2.Stretch = True
        Me.tsMain2.TabIndex = 11
        '
        'btnFormulas
        '
        Me.btnFormulas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnFormulas.Image = CType(resources.GetObject("btnFormulas.Image"), System.Drawing.Image)
        Me.btnFormulas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnFormulas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnFormulas.Name = "btnFormulas"
        Me.btnFormulas.Size = New System.Drawing.Size(124, 44)
        Me.btnFormulas.ToolTipText = "Formulas Page"
        '
        'btnElectricity
        '
        Me.btnElectricity.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnElectricity.Image = CType(resources.GetObject("btnElectricity.Image"), System.Drawing.Image)
        Me.btnElectricity.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnElectricity.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnElectricity.Name = "btnElectricity"
        Me.btnElectricity.Size = New System.Drawing.Size(124, 44)
        Me.btnElectricity.ToolTipText = "Opens Electricity page"
        '
        'btnGeometricalOptics
        '
        Me.btnGeometricalOptics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnGeometricalOptics.Image = CType(resources.GetObject("btnGeometricalOptics.Image"), System.Drawing.Image)
        Me.btnGeometricalOptics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnGeometricalOptics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGeometricalOptics.Name = "btnGeometricalOptics"
        Me.btnGeometricalOptics.Size = New System.Drawing.Size(184, 44)
        Me.btnGeometricalOptics.Text = "ToolStripButton3"
        Me.btnGeometricalOptics.ToolTipText = "Opens Geometrical Optics page"
        '
        'btnHeat
        '
        Me.btnHeat.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnHeat.Image = CType(resources.GetObject("btnHeat.Image"), System.Drawing.Image)
        Me.btnHeat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnHeat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnHeat.Name = "btnHeat"
        Me.btnHeat.Size = New System.Drawing.Size(124, 44)
        Me.btnHeat.Text = "ToolStripButton1"
        Me.btnHeat.ToolTipText = "Opens Heat page"
        '
        'btnMechanics
        '
        Me.btnMechanics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnMechanics.Image = CType(resources.GetObject("btnMechanics.Image"), System.Drawing.Image)
        Me.btnMechanics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnMechanics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnMechanics.Name = "btnMechanics"
        Me.btnMechanics.Size = New System.Drawing.Size(144, 44)
        Me.btnMechanics.Text = "ToolStripButton4"
        Me.btnMechanics.ToolTipText = "Opens Mechanics and Properties of matter page"
        '
        'btnNuclearPhysics
        '
        Me.btnNuclearPhysics.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnNuclearPhysics.Image = CType(resources.GetObject("btnNuclearPhysics.Image"), System.Drawing.Image)
        Me.btnNuclearPhysics.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnNuclearPhysics.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuclearPhysics.Name = "btnNuclearPhysics"
        Me.btnNuclearPhysics.Size = New System.Drawing.Size(164, 44)
        Me.btnNuclearPhysics.Text = "ToolStripButton5"
        Me.btnNuclearPhysics.ToolTipText = "Opens Nuclear Physics page"
        '
        'btnUnits
        '
        Me.btnUnits.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnUnits.Image = CType(resources.GetObject("btnUnits.Image"), System.Drawing.Image)
        Me.btnUnits.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnUnits.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUnits.Name = "btnUnits"
        Me.btnUnits.Size = New System.Drawing.Size(184, 44)
        Me.btnUnits.ToolTipText = "Standard Units and Constants Page"
        '
        'btnAbout
        '
        Me.btnAbout.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAbout.Image = CType(resources.GetObject("btnAbout.Image"), System.Drawing.Image)
        Me.btnAbout.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.btnAbout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAbout.Name = "btnAbout"
        Me.btnAbout.Size = New System.Drawing.Size(124, 44)
        Me.btnAbout.Text = "About Blu-2"
        '
        'mdiPhysicsHome
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 748)
        Me.Controls.Add(Me.tsMain2)
        Me.Controls.Add(Me.tsMain1)
        Me.Controls.Add(Me.StatusStrip)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "mdiPhysicsHome"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Physics Calculator"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip.ResumeLayout(False)
        Me.StatusStrip.PerformLayout()
        Me.tsMain1.ResumeLayout(False)
        Me.tsMain1.PerformLayout()
        Me.tsMain2.ResumeLayout(False)
        Me.tsMain2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents ToolStripStatusLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents StatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents tsMain1 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnHeat As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnElectricity As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnGeometricalOptics As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnMechanics As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnNuclearPhysics As System.Windows.Forms.ToolStripButton
    Friend WithEvents tsMain2 As System.Windows.Forms.ToolStrip
    Friend WithEvents btnFormulas As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnUnits As System.Windows.Forms.ToolStripButton
    Friend WithEvents btnAbout As System.Windows.Forms.ToolStripButton

End Class
