Public NotInheritable Class Welcome

    Private Sub Welcome_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        mdiPhysicsHome.Show()
    End Sub

    Private Sub Welcome_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        mdiPhysicsHome.Show()
    End Sub

    Private Sub Welcome_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Copyright.Text = My.Application.Info.Copyright
    End Sub

    Private Sub Welcome_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseClick
        mdiPhysicsHome.Show()
    End Sub

    Private Sub Welcome_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDoubleClick
        mdiPhysicsHome.Show()
    End Sub


    Private Sub Welcome_MouseHover(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseHover
        mdiPhysicsHome.Show()
    End Sub
End Class
