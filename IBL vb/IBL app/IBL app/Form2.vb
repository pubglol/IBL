Public Class Form2

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnMaths_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMaths.Click
        Form3.Show()
        Me.Hide()

    End Sub

    Private Sub btnPhysics_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPhysics.Click
        Form4.Show()
        Me.Hide()

    End Sub
End Class