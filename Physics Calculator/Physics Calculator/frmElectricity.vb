Public Class frmElectricity
    Dim objElectricity As New Electricity
    Dim NumericTester As Boolean = False
    Private Sub frmPhysicsMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableControls()
        txtFirst.Focus()
    End Sub
    Private Sub mnuElectricVoltage_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuElectricVoltage.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Eletric Current (Amperes)"
        lblSecond.Text = "Electric Resistance (Ohms)"
        lblHeader.Text = "Electric Voltage (Volts)"
        lblAnswer.Text = "Electric Voltage (Volts)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub mnuElectricCurrent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuElectricCurrent.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Eletric Voltage (Volts)"
        lblSecond.Text = "Electric Resistance (Ohms)"
        lblHeader.Text = "Electric Current(Amperes)"
        lblAnswer.Text = "Electric Current (Amperes)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub mnuElectricResistance_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuElectricResistance.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Eletric Voltage (Volts)"
        lblSecond.Text = "Electric Current (Amperes)"
        lblHeader.Text = "Electric Resistance (Ohms)"
        lblAnswer.Text = "Electric Resistance (Ohms)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub btnCalculate_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        ' check if entry is numeric or empty. 
        TextBoxEntry()
        If NumericTester = True Then
            NumericTester = False
            Exit Sub
        End If
        If lblAnswer.Text = "Electric Voltage (Volts)" Then
            objElectricity.CalcVoltage(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.Voltage)
            ' DisableControls()

        ElseIf lblAnswer.Text = "Electric Current(Amperes)" Then
            objElectricity.CalcCurrent(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.Current)
            'DisableControls()

        ElseIf lblAnswer.Text = "Electric Resistance (Ohms)" Then
            objElectricity.CalcResistance(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.Resistance)
            'DisableControls()

        ElseIf lblAnswer.Text = "Electric Power(V/I)" Then
            objElectricity.CalcPower(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.Power)
            'DisableControls()

        ElseIf lblAnswer.Text = "Electric Power(V^2 / R)" Then
            objElectricity.CalcPower2(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.Power2)
            'DisableControls()

        ElseIf lblAnswer.Text = "Electric Power(I^2 * R)" Then
            objElectricity.CalcPower3(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.Power3)
            ' DisableControls()

        ElseIf lblAnswer.Text = "Capacitance of a Capacitor" Then
            objElectricity.CalcCapacitance(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.Capacitance)
            ' DisableControls()

        ElseIf lblAnswer.Text = "Capacitance of a charged sphere" Then
            objElectricity.CalcCapacitanceChargedSphere(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.CapacitanceChargedSphere)
            ' DisableControls()

        ElseIf lblAnswer.Text = "Charge (Coulombs)" Then
            objElectricity.calcCapaciCharge(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.CapaciCharge)
            ' DisableControls()

        ElseIf lblAnswer.Text = "Energy Stored (Joules)" Then
            objElectricity.EnergyStoredInCapacitor(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.EnergyCapaci)
            'DisableControls()

        ElseIf lblAnswer.Text = "Potential Difference (Volts)" Then
            objElectricity.CapacitorPD(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.PDCapacitor)
            'DisableControls()

        ElseIf lblAnswer.Text = "Wavelength (Metres)" Then
            objElectricity.DeBroglie(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.DeBroglieResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Charge (Coulombs)" Then
            objElectricity.ElecCharge(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.ElecChargeResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Electric Charge (N/C)" Then
            objElectricity.EFieldIntensity(txtFirst.Text, txtSecond.Text, txtThird.Text, txtFourth.Text)
            txtAnswer.Text = CDbl(objElectricity.EFieldIntensityResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Electromotive force (Volts)" Then
            objElectricity.EMFInRod(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objElectricity.EMFInRodResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Electrostatic Field Intensity (N/C)" Then
            objElectricity.EFieldIntensity2(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.EFieldIntensity2Result)
            ' DisableControls()

        ElseIf lblAnswer.Text = "Electric Field Intensity (V/m)" Then
            objElectricity.EFieldBetweenPlates(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.EFieldBetweenPlatesResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Force on a current carrying conductor (Newtons)" Then
            objElectricity.FOnCurrentCarryingConductor(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objElectricity.FOnCurrentCarryingConductorResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Force on moving charge (Newtons)" Then

            objElectricity.FOnMovingCharges(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objElectricity.FOnMovingChargesResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Force on electron (Newtons)" Then
            objElectricity.FOnElectronBetweenPlates(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.FOnElectronBetweenPlatesResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Magnetic Flux Linkage (Weber)" Then
            objElectricity.MagneticFluxLinkage(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objElectricity.MagneticFluxLinkageResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Permitivity of free space (N/m)" Then
            objElectricity.PermitivityOfFreeSpace(txtFirst.Text, txtSecond.Text, txtThird.Text, txtFourth.Text)
            txtAnswer.Text = CDbl(objElectricity.PermitivityOfFreeSpaceResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Resistivity of wire (Ohm metre)" Then
            objElectricity.ResistivityOfSubstance(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objElectricity.ResistivityOfSubstanceResult)
            'DisableControls()

        ElseIf lblAnswer.Text = "Work Done (Joules)" Then
            objElectricity.WorkDoneOnCharge(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objElectricity.WorkDoneOnChargeResult)
            'DisableControls()

        End If
    End Sub

    Private Sub btnClear_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFirst.Text = "0"
        txtSecond.Text = "0"
        txtThird.Text = "0"
        txtFourth.Text = "0"
        txtAnswer.Text = "0"

        EnableCheck()

        btnCalculate.Enabled = True
        txtFirst.Focus()
    End Sub
    Private Sub EnableCheck()
        If lblFirst.Text <> "First" Then
            txtFirst.Enabled = True
            lblFirst.Enabled = True
        Else
            txtFirst.Enabled = False
            lblFirst.Enabled = False
        End If
        If lblSecond.Text <> "Second" Then
            txtSecond.Enabled = True
            lblSecond.Enabled = True
        Else
            txtSecond.Enabled = False
            lblSecond.Enabled = False
        End If
        If lblThird.Text <> "Third" Then
            txtThird.Enabled = True
            lblThird.Enabled = True
        Else
            txtThird.Enabled = False
            lblThird.Enabled = False
        End If
        If lblfourth.Text <> "Fourth" Then
            txtFourth.Enabled = True
            lblfourth.Enabled = True
        Else
            txtFourth.Enabled = False
            lblfourth.Enabled = False
        End If

    End Sub

    Private Sub PVIToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PVIToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Eletric Voltage (Volt)"
        lblSecond.Text = "Electric Current (Amperes)"
        lblAnswer.Text = "Electric Power(V/I)"
        lblHeader.Text = "Electric Power(Watts)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PV2RToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PV2RToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Eletric Voltage (Volts)"
        lblSecond.Text = "Electric Resistance (Ohms)"
        lblAnswer.Text = "Electric Power(V^2 / R)"
        lblHeader.Text = "Electric Power(Watts)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PI2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PI2ToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Eletric Current (Amperes)"
        lblSecond.Text = "Electric Resistance (Ohms)"
        lblAnswer.Text = "Electric Power(I^2 * R)"
        lblHeader.Text = "Electric Power(Watts)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub CapacitanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitanceToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Electric Charge (Coulombs)"
        lblSecond.Text = "Potential Difference (Volts)"
        lblAnswer.Text = "Capacitance of a Capacitor"
        lblHeader.Text = "Capacitance of a Capacitor"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub CapacitanceOfAChargedSphereToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CapacitanceOfAChargedSphereToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Permitivity of Air (Farad/metre)"
        lblSecond.Text = "Radius of sphere (metre)"
        lblAnswer.Text = "Capacitance of a charged sphere"
        lblHeader.Text = "Capacitance of a charged sphere"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChargeToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Potential Difference (Volts) "
        lblSecond.Text = "Capacitance (Farads)"
        lblAnswer.Text = "Charge (Coulombs)"
        lblHeader.Text = "Charge (Coulombs)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub EnergyStoredInACapacitorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnergyStoredInACapacitorToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Potential Difference (Volts) "
        lblSecond.Text = "Capacitance (Farads)"
        lblAnswer.Text = "Energy Stored (Joules)"
        lblHeader.Text = "Energy Stored (Joules)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PotentialDifferenceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PotentialDifferenceToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Charge (Coulombs) "
        lblSecond.Text = "Capacitance (Farads)"
        lblAnswer.Text = "Potential Difference (Volts)"
        lblHeader.Text = "Potential Difference (Volts)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub DeBrogliesTheoryToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeBrogliesTheoryToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Mass (Kg's) "
        lblSecond.Text = "Velocity (m/s)"
        lblAnswer.Text = "Wavelength (Metres)"
        lblHeader.Text = "Wavelength (Metres)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ElectricChargeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElectricChargeToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Current (Amperes) "
        lblSecond.Text = "Time (Seconds)"
        lblAnswer.Text = "Charge (Coulombs)"
        lblHeader.Text = "Charge (Coulombs)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ElectromotiveForceInARodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElectromotiveForceInARodToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Flux density (Tesla) "
        lblSecond.Text = "Distance moved (Metres)"
        lblThird.Text = "Length of rod (Metres)"
        lblAnswer.Text = "Electromotive force (Volts)"
        lblHeader.Text = "Electromotive force (Volts)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ElectrostaticFieldIntensityToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElectrostaticFieldIntensityToolStripMenuItem1.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Force (Newtons) "
        lblSecond.Text = "Charge (Coulombs)"
        lblAnswer.Text = "Electrostatic Field Intensity (N/C)"
        lblHeader.Text = "Electrostatic Field Intensity (N/C)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub BetweenPlatesADistanceApartToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BetweenPlatesADistanceApartToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Voltage (Volts) "
        lblSecond.Text = "Distance between plates (Metres)"
        lblAnswer.Text = "Electric Field Intensity (V/m)"
        lblHeader.Text = "Electric Field Intensity (V/m)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ElectricChargeSurroundedByMaterialOfPermitivityToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ElectricChargeSurroundedByMaterialOfPermitivityToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = True
        lblfourth.Enabled = True
        lblFirst.Text = "Charge (Coulombs) "
        lblSecond.Text = "Distance between charges (Metres)"
        lblThird.Text = "Permitivity of material"
        lblfourth.Text = "Force between the two charges (Newtons)"
        lblAnswer.Text = "Electric Charge (N/C)"
        lblHeader.Text = "Electric Charge (N/C)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ForceInACurrentCarryingConductorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceInACurrentCarryingConductorToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Flux Density (Tesla) "
        lblSecond.Text = "Current (Amperes)"
        lblThird.Text = "Length of Conductor (Metres)"
        lblAnswer.Text = "Force on a current carrying conductor (Newtons)"
        lblHeader.Text = "Force on a current carrying conductor (Newtons)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ForceOnMovingChargesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceOnMovingChargesToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Flux Density (Tesla) "
        lblSecond.Text = "Charge (Coulombs)"
        lblThird.Text = "Velocity of Charge (m/s)"
        lblAnswer.Text = "Force on moving charge (Newtons)"
        lblHeader.Text = "Force on moving charge (Newtons)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ForceOnAnElectronMovingBetweenPlatesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceOnAnElectronMovingBetweenPlatesToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Electric Field Intensity (N/C) "
        lblSecond.Text = "Charge of Electron (Coulombs)"
        lblAnswer.Text = "Force on electron (Newtons)"
        lblHeader.Text = "Force on an electron moving between plates (Newtons)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub MagneticFluxLinkageThroughACoilToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MagneticFluxLinkageThroughACoilToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Field Strength (Tesla) "
        lblSecond.Text = "Number of turns in coil"
        lblThird.Text = "Area of coil (m^2)"
        lblAnswer.Text = "Magnetic Flux Linkage (Weber)"
        lblHeader.Text = "Magnetic Flux Linkage (Weber)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PermitivityOfFreeSpaceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PermitivityOfFreeSpaceToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = True
        lblfourth.Enabled = True
        lblFirst.Text = "First Charge (Coulombs) "
        lblSecond.Text = "Second Charge (Coulombs)"
        lblThird.Text = "Distance between charges (Metres)"
        lblfourth.Text = "Force between the two charges (Newtons)"
        lblAnswer.Text = "Permitivity of free space (N/m)"
        lblHeader.Text = "Permitivity of free space (N/m)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ResistivityOfAWireToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResistivityOfAWireToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Resistance of wire (Ohms)"
        lblSecond.Text = "Length of wire (Metres)"
        lblThird.Text = "Cross Sectional Area of wire (m^2)"
        lblAnswer.Text = "Resistivity of wire (Ohm metre)"
        lblHeader.Text = "Resistivity of wire (Ohm metre)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub WorkDoneWhenMovingAChargeThroughAPDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkDoneWhenMovingAChargeThroughAPDToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"

        btnClear_Click_1(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Charge (Coulombs)"
        lblSecond.Text = "Potential Difference (Volts)"
        lblAnswer.Text = "Work Done (Joules)"
        lblHeader.Text = "Work Done (Joules)"
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub DisableControls()
        ' this code disables all the understated controls
        Dim d As Control

        For Each d In Me.Controls
            If TypeOf d Is Button Or TypeOf d Is Label Or TypeOf d Is TextBox Then
                With d
                    .Enabled = False
                End With
            End If
        Next

        btnClear.Enabled = True
        txtAnswer.Enabled = True
        lblAnswer.Enabled = True

    End Sub

    Private Sub EnableControls()
        ' this code enabled all the understated controls
        Dim d As Control

        For Each d In Me.Controls
            If TypeOf d Is Button Or TypeOf d Is Label Or TypeOf d Is TextBox Then
                With d
                    .Enabled = True
                End With
            End If
        Next


    End Sub
    Private Sub TextBoxActivity()
        ' this code assigns 0 to all enabled and disabled textboxes. The labels on top of the textboxes determine
        ' which textbox will be enabled or not but all textboxes before a calculation are equated to zero
        Dim d As Control

        For Each d In Me.Controls
            If TypeOf d Is TextBox Then
                With d
                    If txtFirst.Enabled = False Then
                        txtFirst.Text = "0"
                    Else
                        If txtFirst.Enabled = True Then
                            txtFirst.Text = "0"
                        End If
                    End If

                    If txtSecond.Enabled = False Then
                        txtSecond.Text = "0"
                    Else
                        If txtSecond.Enabled = True Then
                            txtSecond.Text = "0"
                        End If
                    End If
                    If txtThird.Enabled = False Then
                        txtThird.Text = "0"
                    Else
                        If txtThird.Enabled = True Then
                            txtThird.Text = "0"
                        End If
                    End If
                    If txtFourth.Enabled = False Then
                        txtFourth.Text = "0"
                        Exit Sub
                    Else
                        If txtFourth.Enabled = True Then
                            txtFourth.Text = "0"
                            Exit Sub
                        End If
                    End If
                End With
            End If
        Next
    End Sub
    Private Sub TextBoxEntry()
        ' this code validates if a text entry is empty or is not numeric. The only letter that is allow is 
        'E because it is the exponentiation sign in mathematics
        Dim d As Control

        For Each d In Me.Controls
            If TypeOf d Is TextBox Then
                With d
                    If .Text = "" Then
                        MessageBox.Show("A required text entry is empty. Check and try again", "Physics Calculator", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        NumericTester = True
                    End If

                    If IsNumeric(.Text) = False Then
                        MessageBox.Show("A text entry is not numeric. Check and try again", "Physics Calculator", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                        NumericTester = True
                        .Text = "0"
                        .Focus()
                    End If

                End With
            End If
        Next
    End Sub

    Private Sub txtTextBoxes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtFirst.GotFocus, txtSecond.GotFocus, txtThird.GotFocus, txtFourth.GotFocus
        ' this code uses a gotfocus event of the textboxes checks for textboxes that have a string entry of zero. this is done when a topic calculation is
        ' selected. When a textbox gets focus and its enabled, automatically all other enabled textboxes are 
        ' assigned to nothing. This is necessary to make the calculations work. Any textbox that retain zero during 
        ' a calculation will most likely not be enabled
        ' if no numeric text is entered, this code will also execute after a messagebox reseting all entries to null
        Dim d As Control
        For Each d In Controls
            If TypeOf d Is TextBox Then
                With d
                    If .Enabled = True Then
                        If .Text = "0" Then
                            .Text = ""
                        End If
                    Else
                        If .Enabled = False Then
                            .Text = "0"
                        End If
                    End If
                End With
            End If
        Next
        txtAnswer.Text = "0"
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ActivateScreenSaverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateScreenSaverToolStripMenuItem.Click
        ' activate screensaver, it must be enabled in the display properties first or there will be no show
        ScreenSaver.gf_StartScreenSaver()
    End Sub

    Private Sub BasicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicToolStripMenuItem.Click
        ' call the windows calculator to the screen
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub
End Class
