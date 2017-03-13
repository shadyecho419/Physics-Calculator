Public Class frmMechAndPropOfMatter
    Dim NumericTester As Boolean = False
    Dim objMechandProp As New MechAndPropOfMatter
    Private Sub frmMechAndPropOfMatter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

    Private Sub btnCalculate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalculate.Click
        TextBoxEntry()


        If NumericTester = True Then
            NumericTester = False
            Exit Sub
        End If


        If lblAnswer.Text = "Acceleration in a Circle (m/s/s)" Then
            objMechandProp.CalcCircularAccel(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcCircularAccelResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Acceleration using Angular Velocity (m/s/s)" Then
            objMechandProp.CalcCircularAccelUsnAngVel(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcCircularAccelUsnAngVelResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Angular Velocity (rad/s)" Then
            objMechandProp.CalcAngularVel(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcAngularVelResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Length of an Arc (Metres)" Then
            objMechandProp.CalcLenOfArc(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcLenOfArcResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Period (T) (Seconds)" Then
            objMechandProp.CalcPeriod(txtFirst.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcPeriodResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Velocity of rotating object (m/s)" Then
            objMechandProp.CalcVelOfRotatingObj(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcVelOfRotatingObjResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Acceleration given U, T and V (m/s/s)" Then
            objMechandProp.CalcAccelGVUTV(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcAccelGVUTVResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Acceleration given S, U and T (m/s/s)" Then
            objMechandProp.CalcAccelGVSUT(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcAccelGVSUTResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Distance travelled given T, U And A (m)" Then
            objMechandProp.CalcDistGVTUA(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcDistGVTUAResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Distance travelled given U, V And T (m)" Then
            objMechandProp.CalcDistGVUVT(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcDistGVUVTResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Final Velocity given U, A and S (m/s)" Then
            objMechandProp.CalcFinalVelGVUAS(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcFinalVelGVUASResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Final Velocity given A, T and U (m/s)" Then
            objMechandProp.CalcFinalVelGVATU(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcFinalVelGVATUResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Initial Velocity given V, A and T (m/s)" Then
            objMechandProp.CalcInitialVelGVVAT(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcInitialVelGVVATResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Time taken given U, A and V (Seconds)" Then
            objMechandProp.CalcTimeGVUAV(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcTimeGVUAVResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Density of planet (Kgm^-3)" Then
            objMechandProp.CalcDensOfPlanet(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcDensOfPlanetResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Gravitational Force (F)(Newtons)" Then
            objMechandProp.CalcGravForce(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcGravForceResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Gravitational Potential(V)" Then
            objMechandProp.CalcGravPotential(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcGravPotentialResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Mass of planet (Kg)" Then
            objMechandProp.CalcMassOfPlanet(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcMassOfPlanetResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Period of Satelite in its orbit (Seconds)" Then
            objMechandProp.CalcPeriodOfSatOrbit(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcPeriodOfSatOrbitResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Force (Newtons)" Then
            objMechandProp.CalcForceOnConstMass(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcForceOnConstMassResult)
            ' DisableControls()
        End If

        'done because of length of this sub. Sub continued later on this page
        CalculateContinue()
    End Sub

    Private Sub AccelerationGivenVelocityAndRadiusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccelerationGivenVelocityAndRadiusToolStripMenuItem.Click
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
        lblFirst.Text = "Radius of Circle (Metres)"
        lblSecond.Text = "Velocity (m/s)"
        lblAnswer.Text = "Acceleration in a Circle (m/s/s)"
        lblHeader.Text = "Acceleration in a Circle (m/s/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub AccelerationFivenRadiusAndAngularVelocityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccelerationFivenRadiusAndAngularVelocityToolStripMenuItem.Click
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
        lblFirst.Text = "Radius of Circle (Metres)"
        lblSecond.Text = "Angular Velocity (Radians / second)"
        lblAnswer.Text = "Acceleration using Angular Velocity (m/s/s)"
        lblHeader.Text = "Acceleration using Angular Velocity (m/s/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub AngularVelocityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AngularVelocityToolStripMenuItem.Click
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
        lblFirst.Text = "Angle (Radians)"
        lblSecond.Text = "Time (Seconds)"
        lblAnswer.Text = "Angular Velocity (Radians / second)"
        lblHeader.Text = "Angular Velocity (Radians / second)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub LenghtOfArcToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LenghtOfArcToolStripMenuItem.Click
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
        lblFirst.Text = "Radius of Circle (Metres)"
        lblSecond.Text = "Angle at arc centre (Radians)"
        lblAnswer.Text = "Length of an Arc (Metres)"
        lblHeader.Text = "Length of an Arc (Metres)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PeriodToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodToolStripMenuItem.Click
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
        lblFirst.Text = "Angular Velocity (Radians / second)"
        lblAnswer.Text = "Period (T) (Seconds)"
        lblHeader.Text = "Period (T) (Seconds)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub VelocityOfARotatingObjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VelocityOfARotatingObjectToolStripMenuItem.Click
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
        lblFirst.Text = "Radius of Circle (Metres)"
        lblSecond.Text = "Angular Velocity(Radians / second)"
        lblAnswer.Text = "Velocity of rotating object (m/s)"
        lblHeader.Text = "Velocity of rotating object (m/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub AccelerationGivenInitialVelocityTimeAndFinalVelocityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccelerationGivenInitialVelocityTimeAndFinalVelocityToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Initial Velocity (m/s)"
        lblSecond.Text = "Final Velocity (m/s)"
        lblThird.Text = "Time (Seconds)"
        lblAnswer.Text = "Acceleration given U, T and V (m/s/s)"
        lblHeader.Text = "Acceleration given U, T and V (m/s/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub AccelerationGivenDistanceTravelledInitialVelocityAndTimeTakenToTravelDistanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccelerationGivenDistanceTravelledInitialVelocityAndTimeTakenToTravelDistanceToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Initial Velocity (m/s)"
        lblSecond.Text = "Distance Travelled (Metres)"
        lblThird.Text = "Time (Seconds)"
        lblAnswer.Text = "Acceleration given S, U and T (m/s/s)"
        lblHeader.Text = "Acceleration given S, U and T (m/s/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub DistanceTravelledGivenTimeInitialVelocityAndAccelerationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistanceTravelledGivenTimeInitialVelocityAndAccelerationToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Initial Velocity (m/s)"
        lblSecond.Text = "Accelration (m/s/s)"
        lblThird.Text = "Time (Seconds)"
        lblAnswer.Text = "Distance travelled given T, U And A (m)"
        lblHeader.Text = "Distance travelled given T, U And A (m)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub DistanceTravelledGivenInitialVelocityFinalVelocityAndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DistanceTravelledGivenInitialVelocityFinalVelocityAndTimeToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Initial Velocity (m/s)"
        lblSecond.Text = "Final Velocity (m/s)"
        lblThird.Text = "Time (Seconds)"
        lblAnswer.Text = "Distance travelled given U, V And T (m)"
        lblHeader.Text = "Distance travelled given U, V And T (m)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub FinalVelocityGivenInitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalVelocityGivenInitToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Initial Velocity (m/s)"
        lblSecond.Text = "Acceleration (m/s/s)"
        lblThird.Text = "Displacement (metres)"
        lblAnswer.Text = "Final Velocity given U, A and S (m/s)"
        lblHeader.Text = "Final Velocity given U, A and S (m/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub FinalVelocityGivenUniformAccelerationTimeAndInitialVelocityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalVelocityGivenUniformAccelerationTimeAndInitialVelocityToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Initial Velocity (m/s)"
        lblSecond.Text = "Acceleration (m/s/s)"
        lblThird.Text = "Time (Seconds)"
        lblAnswer.Text = "Final Velocity given A, T and U (m/s)"
        lblHeader.Text = "Final Velocity given A, T and U (m/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub InitialVelocityGivenUniformAccelerationTimeAndFinalVelocityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InitialVelocityGivenUniformAccelerationTimeAndFinalVelocityToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Final Velocity (m/s)"
        lblSecond.Text = "Acceleration (m/s/s)"
        lblThird.Text = "Time (Seconds)"
        lblAnswer.Text = "Initial Velocity given V, A and T (m/s)"
        lblHeader.Text = "Initial Velocity given V, A and T (m/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub TimeTakenGivenInitialVelocityAccelerationAndFinalVelocityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TimeTakenGivenInitialVelocityAccelerationAndFinalVelocityToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Initial Velocity (m/s)"
        lblSecond.Text = "Acceleration (m/s/s)"
        lblThird.Text = "Final Velocity (m/s)"
        lblAnswer.Text = "Time taken given U, A and V (Seconds)"
        lblHeader.Text = "Time taken given U, A and V (Seconds)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub DensityOfAPlanetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DensityOfAPlanetToolStripMenuItem.Click
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
        lblFirst.Text = "Acceleration due to gravity (g)"
        lblSecond.Text = "Radius of Planet (metres)"
        lblAnswer.Text = "Density of planet (Kgm^-3)"
        lblHeader.Text = "Density of planet (Kgm^-3)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub GravitationalForceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravitationalForceToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Mass (m)(Kg)"
        lblSecond.Text = "Mass (M)(Kg)"
        lblThird.Text = "Radius (R)(Metres)"
        lblAnswer.Text = "Gravitational Force (F)(Newtons)"
        lblHeader.Text = "Gravitational Force (F)(Newtons)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub GravitationalPotentialToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravitationalPotentialToolStripMenuItem.Click
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
        lblFirst.Text = "Mass of Planet (M)(Kg)"
        lblSecond.Text = "Distance from centre of planet(R)(Metres)"
        lblAnswer.Text = "Gravitational Potential(V)"
        lblHeader.Text = "Gravitational Potential(V)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub MassOfAPlanetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MassOfAPlanetToolStripMenuItem.Click
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
        lblFirst.Text = "Acceleration due to gravity (g)(m/s/s)"
        lblSecond.Text = "Radius of planet(Metres)"
        lblAnswer.Text = "Mass of planet (Kg)"
        lblHeader.Text = "Mass of planet (Kg)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PeriodOfASatelliteInItsOrbitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodOfASatelliteInItsOrbitToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Acceleration due to gravity (g)(m/s/s)"
        lblSecond.Text = "Radius of planet(Metres)"
        lblThird.Text = "Satellites distance from centre of planet (Metres) "
        lblAnswer.Text = "Period of Satelite in its orbit (Seconds)"
        lblHeader.Text = "Period of Satelite in its orbit (Seconds)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub ForceActingOnConstantMasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceActingOnConstantMasToolStripMenuItem.Click
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
        lblFirst.Text = "Mass of body (Kg)"
        lblSecond.Text = "Acceleration (m/s/s)"
        lblAnswer.Text = "Force (Newtons)"
        lblHeader.Text = "Force (Newtons)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub CalculateContinue()
        If lblAnswer.Text = "Force due to momentum change (Newtons)" Then
            objMechandProp.CalcForceDueToMomentum(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcForceDueToMomentumResult)
            ' DisableControls()
        End If

        If lblAnswer.Text = "Gravitational Potential Energy (Kgs^-1)" Then
            objMechandProp.CalcGPE(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcGPEResult)
            ' DisableControls()
        End If

        If lblAnswer.Text = "Kinetic Energy (Kgm/s)" Then
            objMechandProp.CalcKE(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcKEResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Momentum of an object (Kgm/s)" Then
            objMechandProp.CalcMomentum(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcMomentumResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Power (Watts)" Then
            objMechandProp.CalcPower(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcPowerResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Work (Newton metres)" Then
            objMechandProp.CalcWorkDone(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcWorkDoneResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Work Done with force acting at an agle (Newton metres)" Then
            objMechandProp.CalcWorkDoneWitAngle(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcWorkDoneWitAngleResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Energy stored in a wire (Joules)[Modulus]" Then
            objMechandProp.CalcEnergyUsingYoungMod(txtFirst.Text, txtSecond.Text, txtThird.Text, txtFourth.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcEnergyUsingYoungModResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Energy stored in a wire (Joules)[Force]" Then
            objMechandProp.CalcEnergyUsingForce(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcEnergyUsingForceResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Tensile Stress (Pascals)" Then
            objMechandProp.CalcTensileStress(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcTensileStressResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Tensile Strain" Then
            objMechandProp.CalcTensileStrain(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcTensileStrainResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Young Modules (Pascals)" Then
            objMechandProp.CalcYoungMod(txtFirst.Text, txtSecond.Text, txtThird.Text, txtFourth.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcYoungModResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Acceleration of object (m/s/s)" Then
            objMechandProp.CalcCentiAccel(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcCentiAccelResult)
            ' DisableControls()
        End If

        'continuing calculate event under button this way to prevent length of one event dominating entire page
        CalculateContinue2()

    End Sub

    Private Sub ForceDueToMomentumChageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ForceDueToMomentumChageToolStripMenuItem.Click
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
        lblFirst.Text = "Momentum (Kgm/s)"
        lblSecond.Text = "Time Taken (s)"
        lblAnswer.Text = "Force due to momentum change (Newtons)"
        lblHeader.Text = "Force due to momentum change (Newtons)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub GravitationalPotentialEnergyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GravitationalPotentialEnergyToolStripMenuItem.Click
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
        lblFirst.Text = "Mass (Kg)"
        lblSecond.Text = "Height Change (Metres)"
        lblAnswer.Text = "Gravitational Potential Energy (Kgs^-1)"
        lblHeader.Text = "Gravitational Potential Energy (Kgs^-1)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub KineticEnergyOfAnObjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KineticEnergyOfAnObjectToolStripMenuItem.Click
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
        lblFirst.Text = "Mass (Kg)"
        lblSecond.Text = "Velocity (m/s)"
        lblAnswer.Text = "Kinetic Energy (Kgm/s)"
        lblHeader.Text = "Kinetic Energy (Kgm/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub MomentumOfAnObjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MomentumOfAnObjectToolStripMenuItem.Click
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
        lblFirst.Text = "Mass (Kg)"
        lblSecond.Text = "Velocity (m/s)"
        lblAnswer.Text = "Momentum of an object (Kgm/s)"
        lblHeader.Text = "Momentum of an object (Kgm/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PowerToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PowerToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Force (Newtons)"
        lblSecond.Text = "Displacement (Metres)"
        lblThird.Text = "Time taken (Seconds)"
        lblAnswer.Text = "Power (Watts)"
        lblHeader.Text = "Power (Watts)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub WorkDoneToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkDoneToolStripMenuItem.Click
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
        lblFirst.Text = "Force (Newtons)"
        lblSecond.Text = "Displacement (Metres)"
        lblAnswer.Text = "Work (Newton metres)"
        lblHeader.Text = "Work (Newton metres)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub WorkDoneWithForceActingAtAnAngleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles WorkDoneWithForceActingAtAnAngleToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Force (Newtons)"
        lblSecond.Text = "Angle of Force to Horizontal"
        lblThird.Text = "Displacement (Metres)"
        lblAnswer.Text = "Work Done with force acting at an agle (Newton metres)"
        lblHeader.Text = "Work Done with force acting at an agle (Newton metres)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

   
    Private Sub UsingModulesOfElasticityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsingModulesOfElasticityToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        lblFirst.Text = "Modulus of Elasticity"
        lblSecond.Text = "Cross-Sectional area (m^2)"
        lblThird.Text = "Extension (Metres)"
        lblfourth.Text = "Length of Wire (Metres)"
        lblAnswer.Text = "Energy stored in a wire (Joules)[Modulus]"
        lblHeader.Text = "Energy stored in a wire (Joules)[Modulus]"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub UsingForceAndExtensionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsingForceAndExtensionToolStripMenuItem.Click
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
        lblFirst.Text = "Average Force (Newtons)"
        lblSecond.Text = "Extension"
        lblAnswer.Text = "Energy stored in a wire (Joules)[Force]"
        lblHeader.Text = "Energy stored in a wire (Joules)[Force]"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub TensileStressToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TensileStressToolStripMenuItem.Click
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
        lblFirst.Text = "Force (Newtons)"
        lblSecond.Text = "Area (m^2)"
        lblAnswer.Text = "Tensile Stress (Pascals)"
        lblHeader.Text = "Tensile Stress (Pascals)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub TensileStrainToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TensileStrainToolStripMenuItem.Click
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
        lblFirst.Text = "Extension (Millimetres)"
        lblSecond.Text = "Length of wire (Metres)"
        lblAnswer.Text = "Tensile Strain"
        lblHeader.Text = "Tensile Strain"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub YoungModulusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YoungModulusToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        lblFirst.Text = "Force (Newtons)"
        lblSecond.Text = "Area (m^2)"
        lblThird.Text = "Extension (Millimetres)"
        lblfourth.Text = "Length (Metres)"
        lblAnswer.Text = "Young Modules (Pascals)"
        lblHeader.Text = "Young Modules (Pascals)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub AccelerationOfAnObjectToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AccelerationOfAnObjectToolStripMenuItem.Click
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
        lblFirst.Text = "Angular Velocity(Radians/Second)"
        lblSecond.Text = "Distance of object from fixed point (Metres)"
        lblAnswer.Text = "Acceleration of object (m/s/s)"
        lblHeader.Text = "Acceleration of object (m/s/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub CalculateContinue2()
        If lblAnswer.Text = "Period of Oscillation (Seconds)" Then
            objMechandProp.CalcPeriodOfOsc(txtFirst.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcPeriodOfOscResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Frequency (Hertz)" Then
            objMechandProp.CalcFrequencyOfOsc(txtFirst.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcFrequencyOfOscResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Maximum Velocity (m/s)" Then
            objMechandProp.CalcMaximumVel(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcMaximumVelResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Period of Simple Harmonic Motion (Seconds)" Then
            objMechandProp.CalcPeriodSHM(txtFirst.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcPeriodSHMResult)
            ' DisableControls()
        End If


        ' If lblAnswer.Text = "Velocity at any instant (m/s)" Then
        'objMechandProp.CalcPeriodSHM(txtFirst.Text, txtSecond.Text, txtThird.Text)
        'txtAnswer.Text = CDbl(objMechandProp.CalcPeriodSHMResult)
        ' DisableControls()
        'End If


        If lblAnswer.Text = "Pressure (Nm^2)" Then
            objMechandProp.CalcPressure(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcPressureResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Density (Kgm^-3)" Then
            objMechandProp.CalcDensity(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcDensityResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Pressure in liquid (Pascals)" Then
            objMechandProp.CalcPressureInLiquid(txtFirst.Text, txtSecond.Text, txtThird.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcPressureInLiquidResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Torque (Nm)" Then
            objMechandProp.CalcTorque(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objMechandProp.CalcTorqueResult)
            ' DisableControls()
        End If



    End Sub

    Private Sub PeriodOfOscillationToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodOfOscillationToolStripMenuItem1.Click
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
        lblAnswer.Text = "Period of Oscillation (Seconds)"
        lblHeader.Text = "Period of Oscillation (Seconds)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub FrequencyOfOscillationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FrequencyOfOscillationToolStripMenuItem.Click
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
        lblFirst.Text = "Period of Oscillation (Seconds)"
        lblAnswer.Text = "Frequency (Hertz)"
        lblHeader.Text = "Frequency (Hertz)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub MaximumVelocityToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaximumVelocityToolStripMenuItem.Click
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
        lblFirst.Text = "Angular Velocity(Radians/Second)"
        lblSecond.Text = "Maximum Amplitude"
        lblAnswer.Text = "Maximum Velocity (m/s)"
        lblHeader.Text = "Maximum Velocity (m/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PeriodOfSimpleHarmonicMotionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PeriodOfSimpleHarmonicMotionToolStripMenuItem.Click
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
        lblFirst.Text = "Angular Velocity (Radians/Second)"
        lblAnswer.Text = "Period of Simple Harmonic Motion (Seconds)"
        lblHeader.Text = "Period of Simple Harmonic Motion (Seconds)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub VelocityAtAnyInstantToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Angular Velocity (Radians/Second)"
        lblSecond.Text = "Maximum Amplitude(r)"
        lblThird.Text = "Distance of object from fixed point(Y)"
        lblAnswer.Text = "Velocity at any instant (m/s)"
        lblHeader.Text = "Velocity at any instant (m/s)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub AveragePressureToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AveragePressureToolStripMenuItem.Click
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
        lblFirst.Text = "Force (Newtons)"
        lblSecond.Text = "Area (m^2)"
        lblAnswer.Text = "Pressure (Nm^2)"
        lblHeader.Text = "Pressure (Nm^2)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub DensityOfASubstanceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DensityOfASubstanceToolStripMenuItem.Click
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
        lblFirst.Text = "Mass (Kg)"
        lblSecond.Text = "Volume (m^3)"
        lblAnswer.Text = "Density (Kgm^-3)"
        lblHeader.Text = "Density (Kgm^-3)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub PressureInALiquidToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PressureInALiquidToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        txtFourth.Enabled = False
        lblfourth.Enabled = False
        lblFirst.Text = "Density of liquid (Kgm^-3)"
        lblSecond.Text = "Acceleration due to gravity(g)"
        lblThird.Text = "Depth below liquid surface (Metres)"
        lblAnswer.Text = "Pressure in liquid (Pascals)"
        lblHeader.Text = "Pressure in liquid (Pascals)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub TorqueToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TorqueToolStripMenuItem.Click
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
        lblFirst.Text = "One force (Newtons)"
        lblSecond.Text = "Perpendicular force between the forces(Metres)"
        lblAnswer.Text = "Torque (Nm)"
        lblHeader.Text = "Torque (Nm)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub


    Private Sub ToolStripStatusLabel1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub ActivateScreenSaverToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivateScreenSaverToolStripMenuItem.Click
        ScreenSaver.gf_StartScreenSaver()
    End Sub

    Private Sub BasicToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BasicToolStripMenuItem.Click
        Shell("calc", AppWinStyle.NormalFocus)
    End Sub
End Class