Public Class frmNuclearPhysics
    Dim NumericTester As Boolean = False
    Dim objNuclear As New NuclearPhysics
    Private Sub frmNuclearPhysics_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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


        If lblAnswer.Text = "Activity (Becquerels)" Then
            objNuclear.CalcNuclearDecay(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objNuclear.CalcNuclearDecayResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Energy produced by change of mass (Joules)" Then
            objNuclear.CalcMassEnRelation(txtFirst.Text, txtSecond.Text)
            txtAnswer.Text = CDbl(objNuclear.CalcMassEnRelationResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Half Life (Seconds)" Then
            objNuclear.CalcHalfLife(txtFirst.Text)
            txtAnswer.Text = CDbl(objNuclear.CalcHalfLifeResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Number of atoms at end time" Then
            objNuclear.CalcNAtEndTime(txtFirst.Text, txtSecond.Text, txtThird.Text, txtFourth.Text)
            txtAnswer.Text = CDbl(objNuclear.CalcNAtEndTimeResult)
            ' DisableControls()
        End If


        If lblAnswer.Text = "Nuclear Radius (Metres)" Then
            objNuclear.CalcNucleaRad(txtFirst.Text)
            txtAnswer.Text = CDbl(objNuclear.CalcNucleaRadResult)
            ' DisableControls()
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


    Private Sub ActivityRateOfDecayToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActivityRateOfDecayToolStripMenuItem.Click
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
        lblFirst.Text = "Decay Constant (s^-1)"
        lblSecond.Text = "N(numberof undecayed Nuclei)"
        lblAnswer.Text = "Activity (Becquerels)"
        lblHeader.Text = "Activity (Becquerels)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    
    Private Sub EinsteinsMassEnergyRelationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EinsteinsMassEnergyRelationToolStripMenuItem.Click
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
        lblSecond.Text = "Velocity of light (m/s)"
        lblAnswer.Text = "Energy produced by change of mass (Joules)"
        lblHeader.Text = "Energy produced by change of mass (Joules)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

   
    Private Sub HalfLifeOfAnElementToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HalfLifeOfAnElementToolStripMenuItem.Click
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
        lblFirst.Text = "Decay Constant (s^-1)"
        lblAnswer.Text = "Half Life (Seconds)"
        lblHeader.Text = "Half Life (Seconds)"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub NumberOfAtomsAtEndTimeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumberOfAtomsAtEndTimeToolStripMenuItem.Click
        lblFirst.Text = "First"
        lblSecond.Text = "Second"
        lblThird.Text = "Third"
        lblfourth.Text = "Fourth"
        btnClear_Click(sender, e)

        EnableControls()
        lblFirst.Text = "Number of atoms at t = 0"
        lblSecond.Text = "Decay Constant (s^-1)"
        lblThird.Text = "Charge of an electron (Coulombs)"
        lblfourth.Text = "Time (Seconds)"
        lblAnswer.Text = "Number of atoms at end time"
        lblHeader.Text = "Number of atoms at end time"
        EnableCheck()
        TextBoxActivity()
        txtFirst.Focus()
    End Sub

    Private Sub NuclearRadiusOfAnAtomToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NuclearRadiusOfAnAtomToolStripMenuItem.Click
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
        lblFirst.Text = "Nucleon Number (s^-1)"
        lblAnswer.Text = "Nuclear Radius (Metres)"
        lblHeader.Text = "Nuclear Radius (Metres)"
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