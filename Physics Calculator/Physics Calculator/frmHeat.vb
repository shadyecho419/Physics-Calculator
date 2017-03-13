Public Class frmHeat
    Dim NumericTester As Boolean = False
    Dim objHeat As New Heat
    Private Sub frmHeat_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableControls()
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

    Private Sub DisableControls()
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

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        TextBoxEntry()


        If NumericTester = True Then
            NumericTester = False
            Exit Sub
        End If


        If lblAnswer.Text = "Boltzman Constant (J/K)" Then
            objHeat.CalcBoltzmanConstant(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcBoltzmanConstantResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Cubic Expansitivity (K^-1)" Then
            objHeat.CalcCubicExpansitivity(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcCubicExpansitivityResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "N(Number of moles of Gas)" Then
            objHeat.CalcIdealNumberOfMoles(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcIdealNumberOfMolesResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Pressure (Nm^-2)" Then
            objHeat.CalcIdealPressure(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcIdealPressureResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Temperature (Kelvins)" Then
            objHeat.CalcIdealTemp(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcIdealTempResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Volume (m^3)" Then
            objHeat.CalcIdealVol(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcIdealVolResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Monatomic Internal energy of gas (Joules)" Then
            objHeat.CalcMonatomicIntEnergy(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objHeat.CalcMonatomicIntEnergyResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Diatomic Internal energy of gas (Joules)" Then
            objHeat.CalcDiatomicIntEnergy(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objHeat.CalcDiatomicIntEnergyResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Linear expansitivity of a substance (K^-1)" Then
            objHeat.CalcLinearExp(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcLinearExpResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Specific Heat Capacity (J/Kg/K)" Then
            objHeat.CalcSpecificHeatCap(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objHeat.CalcSpecificHeatCapResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Specific latent heat of vapourization (J/Kg/K)" Then
            objHeat.CalcSpecificLatentHeat(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objHeat.CalcSpecificLatentHeatResult)
            ' DisableControls()
        End If


    End Sub

    Private Sub BoltzmanConstantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BoltzmanConstantToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Mass (Kg)"
        lblSecond.Text = "Temperature (Kelvins)"
        lblThird.Text = "R.M.S Velocity (m/s)"
        lblAnswer.Text = "Boltzman Constant (J/K)"
        lblHeader.Text = "Boltzman Constant (J/K)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtFirst.Text = "0"
        txtSecond.Text = "0"
        txtThird.Text = "0"
        txtFourth.Text = "0"
        txtAnswer.Text = "0"

        EnableCheck()

        btnCalculate.Enabled = True
        txtFirst.Focus()
    End Sub

    Private Sub CubicExpansitivityOfASubstanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CubicExpansitivityOfASubstanceToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Change in temperature"
        lblSecond.Text = "Change in volume (m^3)"
        lblThird.Text = "Volume at 273Kelvins (m^3)"
        lblAnswer.Text = "Cubic Expansitivity (K^-1)"
        lblHeader.Text = "Cubic Expansitivity (K^-1)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub IdealGasNumberOfMolesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdealGasNumberOfMolesToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Temperature (Kelvins)"
        lblSecond.Text = "Pressure (Nm^-2)"
        lblThird.Text = "Volume (m^3)"
        lblAnswer.Text = "N(Number of moles of Gas)"
        lblHeader.Text = "N(Number of moles of Gas)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub IdealGasPressureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdealGasPressureToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Temperature (Kelvins)"
        lblSecond.Text = "N(Number of moles of Gas)"
        lblThird.Text = "Volume (m^3)"
        lblAnswer.Text = "Pressure (Nm^-2)"
        lblHeader.Text = "Pressure (Nm^-2)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub IdealGasTemperaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdealGasTemperaToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Pressure (Nm^-2)"
        lblSecond.Text = "N(Number of moles of Gas)"
        lblThird.Text = "Volume (m^3)"
        lblAnswer.Text = "Temperature (Kelvins)"
        lblHeader.Text = "Temperature (Kelvins)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub IdealGasVolumeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdealGasVolumeToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Pressure (Nm^-2)"
        lblSecond.Text = "Temperature (Kelvins)"
        lblThird.Text = "N(Number of moles of Gas)"
        lblAnswer.Text = "Volume (m^3)"
        lblHeader.Text = "Volume (m^3)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub MonatomicInternalEnergyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MonatomicInternalEnergyToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Gas constant per unit mass"
        lblSecond.Text = "Temperature (Kelvins)"
        lblAnswer.Text = "Monatomic Internal energy of gas (Joules)"
        lblHeader.Text = "Monatomic Internal energy of gas (Joules)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub DiatomicInternalEnergyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiatomicInternalEnergyToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Gas constant per unit mass"
        lblSecond.Text = "Temperature (Kelvins)"
        lblAnswer.Text = "Diatomic Internal energy of gas (Joules)"
        lblHeader.Text = "Diatomic Internal energy of gas (Joules)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub LinearExpansitivityOfASubstanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LinearExpansitivityOfASubstanceToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Expansion (Metres)"
        lblSecond.Text = "Original length (Metres)"
        lblThird.Text = "Temperature Rise (Kelvins)"
        lblAnswer.Text = "Linear expansitivity of a substance (K^-1)"
        lblHeader.Text = "Linear expansitivity of a substance (K^-1)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub SpecificHeatCapacityOfToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecificHeatCapacityOfToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Mass of substance (Kg)"
        lblSecond.Text = "Specific heat capacity of material"
        lblThird.Text = "Temperature change (Kelvins)"
        lblAnswer.Text = "Specific Heat Capacity (J/Kg/K)"
        lblHeader.Text = "Specific Heat Capacity (J/Kg/K)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub SpecificLatentHeatOfVapourisationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SpecificLatentHeatOfVapourisationToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Energy Required (Joules)"
        lblSecond.Text = "Mass of material (Kg)"
        lblAnswer.Text = "Specific latent heat of vapourization (J/Kg/K)"
        lblHeader.Text = "Specific latent heat of vapourization of a substance (J/Kg/K)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ActivateScreenSaverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateScreenSaverToolStripMenuItem.Click
        ScreenSaver.gf_StartScreenSaver()
    End Sub

    Private Sub BasicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub
End Class