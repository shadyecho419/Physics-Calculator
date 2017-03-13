Imports System.Windows.Forms

Public Class mdiPhysicsHome

    Private Sub btnElectricity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnElectricity.Click
        frmElectricity.MdiParent = Me
        frmElectricity.Show()
    End Sub

    Private Sub btnGeometricalOptics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGeometricalOptics.Click
        frmGeometricalOptics.MdiParent = Me
        frmGeometricalOptics.Show()
    End Sub

    Private Sub btnHeat_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHeat.Click
        frmHeat.MdiParent = Me
        frmHeat.Show()
    End Sub

    Private Sub btnMechanics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMechanics.Click
        frmMechAndPropOfMatter.MdiParent = Me
        frmMechAndPropOfMatter.Show()
    End Sub

    Private Sub btnNuclearPhysics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNuclearPhysics.Click
        frmNuclearPhysics.MdiParent = Me
        frmNuclearPhysics.Show()
    End Sub
    Private Sub mdiPhysicsHome_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Welcome.Close()
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFormulas.Click
        frmFormulas.MdiParent = Me
        frmFormulas.Show()
    End Sub

    Private Sub btnUnits_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUnits.Click
        frmSIUnits.MdiParent = Me
        frmSIUnits.Show()
    End Sub

    Private Sub btnAbout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAbout.Click
        AboutBlu_2.MdiParent = Me
        AboutBlu_2.Show()
    End Sub
End Class
