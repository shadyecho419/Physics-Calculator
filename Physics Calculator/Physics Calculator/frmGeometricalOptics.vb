Public Class frmGeometricalOptics
    Dim NumericTester As Boolean = False
    Dim objGeometricalOptics As New Geometrical_Optics
    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        TextBoxEntry()


        If NumericTester = True Then
            NumericTester = False
            Exit Sub
        End If


        If lblAnswer.Text = "Absolute Refractive Index" Then
            objGeometricalOptics.CalcAbsRefractiveIndex(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.AbsRefractiveIndexResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Angular Magnification (M)" Then
            objGeometricalOptics.CalcAngularMagnification(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcAngularMagnificationResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Fringe Seperation (Metres)" Then
            objGeometricalOptics.CalcFringeSpacing(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcFringeSpacingResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Lateral Magnification" Then
            objGeometricalOptics.CalcLateralMagnification(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcLateralMagnificationResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Power of Lens(Dioptres)" Then
            objGeometricalOptics.CalcPowerOfLens(txtFirst.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcPowerOfLensResult)
            'DisableControls()
        End If


        If lblAnswer.Text = "Refractive Index of light in material" Then
            objGeometricalOptics.CalcRefractiveIndexOfLightInMat(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcRefractiveIndexOfLightInMatResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Slit Seperation (Metres)" Then
            objGeometricalOptics.CalcSlitSep(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcSlitSepResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Energy of a photon (Joules)" Then
            objGeometricalOptics.CalcEnergyOfPhoton(txtFirst.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcEnergyOfPhotonResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Frequency of wave (Hertz)" Then
            objGeometricalOptics.CalcFrequencyOfWave(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcFrequencyOfWaveResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Wave Velocity (m/s)" Then
            objGeometricalOptics.CalcWaveVelocity(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcWaveVelocityResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Wave Velocity (m/s)" Then
            objGeometricalOptics.CalcWaveVelocity(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcWaveVelocityResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Wavelength (Metres)" Then
            objGeometricalOptics.CalcWaveLength(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcWaveLengthResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Wave Intensity (Wm^-2)" Then
            objGeometricalOptics.CalcWaveIntensity(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objGeometricalOptics.CalcWaveIntensityResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "" Then
        End If

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

    Private Sub frmGeometricalOptics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        DisableControls()
        txtFirst.Focus()
    End Sub
    

    Private Sub AbsoluteRefractiveIndexToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AbsoluteRefractiveIndexToolStripMenuItem.Click
        ' this is done incase user want to change to another calculation, it resets everything back to start settings
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
        lblFirst.Text = "Angle of Incident light to normal"
        lblSecond.Text = "Angle of Refracted light to normal"
        lblAnswer.Text = "Absolute Refractive Index"
        lblHeader.Text = "Absolute Refractive Index"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub


    Private Sub AngularMagnificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngularMagnificationToolStripMenuItem.Click
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
        lblFirst.Text = "Focal length of objective"
        lblSecond.Text = "Focal length of Eyepiece"
        lblAnswer.Text = "Angular Magnification (M)"
        lblHeader.Text = "Angular Magnification (M)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub FringeSeperationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FringeSeperationToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtThird.Enabled = True
        lblThird.Enabled = True
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Distance between slits and screen (Metres)"
        lblSecond.Text = "Wavelength (Metres)"
        lblThird.Text = "Slit seperation (Metres)"
        lblAnswer.Text = "Fringe Seperation (Metres)"
        lblHeader.Text = "Fringe Seperation (Metres)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub LateralMagnificationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LateralMagnificationToolStripMenuItem.Click
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
        lblFirst.Text = "Height of Image (Metres)"
        lblSecond.Text = "Height of Object (Metres)"
        lblAnswer.Text = "Lateral Magnification"
        lblHeader.Text = "Lateral Magnification"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PowerOfALensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerOfALensToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtSecond.Enabled = False
        lblSecond.Enabled = False
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Focal Length of Lens (Metres)"
        lblAnswer.Text = "Power of Lens(Dioptres)"
        lblHeader.Text = "Power of Lens(Dioptres)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub RefractiveIndexOfLightInMaterialsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefractiveIndexOfLightInMaterialsToolStripMenuItem.Click
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
        lblFirst.Text = "Speed of light (m/s)"
        lblSecond.Text = "Speed of light in material (m/s)"
        lblAnswer.Text = "Refractive Index of light in material"
        lblHeader.Text = "Refractive Index of light in material"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub SlitSeperationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SlitSeperationToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Distance between slits (Metres)"
        lblSecond.Text = "Wavelength (Metres)"
        lblThird.Text = "Fringe Seperation (Metres)"
        lblAnswer.Text = "Slit Seperation (Metres)"
        lblHeader.Text = "Slit Seperation (Metres)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub EnergyOfAPhotonToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnergyOfAPhotonToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtSecond.Enabled = False
        lblSecond.Enabled = False
        txtThird.Enabled = False
        lblThird.Enabled = False
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Frequency (Hertz)"
        lblAnswer.Text = "Energy of a photon (Joules)"
        lblHeader.Text = "Energy of a photon (Joules)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub FrequencyOfAWaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrequencyOfAWaveToolStripMenuItem.Click
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
        lblFirst.Text = "Wave velocity (m/s)"
        lblSecond.Text = "Wavelength (Metres)"
        lblAnswer.Text = "Frequency of wave (Hertz)"
        lblHeader.Text = "Frequency of wave (Hertz)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub VelocityOfAWaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VelocityOfAWaveToolStripMenuItem.Click
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
        lblFirst.Text = "Frequency (Hertz)"
        lblSecond.Text = "Wavelength (Metres)"
        lblAnswer.Text = "Wave Velocity (m/s)"
        lblHeader.Text = "Wave Velocity (m/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub WavelengthOfAWaveToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WavelengthOfAWaveToolStripMenuItem.Click
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
        lblFirst.Text = "Frequency (Hertz)"
        lblSecond.Text = "Wave Velocity (m/s)"
        lblAnswer.Text = "Wavelength (Metres)"
        lblHeader.Text = "Wavelength (Metres)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub WaveIntensityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WaveIntensityToolStripMenuItem.Click
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
        lblFirst.Text = "Power (Watts)"
        lblSecond.Text = "Area (m^2)"
        lblAnswer.Text = "Wave Intensity (Wm^-2)"
        lblHeader.Text = "Wave Intensity (Wm^-2)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ActivateScreenSaverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateScreenSaverToolStripMenuItem.Click
        ScreenSaver.gf_StartScreenSaver()
    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub BasicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub
End Class