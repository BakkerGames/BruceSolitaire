' --- GameOverForm.vb - 12/27/2008 ---

Public Class GameOverForm

    Private Sub YesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles YesButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.Yes
        Me.Close()
    End Sub

    Private Sub YesButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles YesButton.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.DialogResult = Windows.Forms.DialogResult.Yes
            Me.Close()
        End If
    End Sub

    Private Sub NoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoButton.Click
        Me.DialogResult = Windows.Forms.DialogResult.No
        Me.Close()
    End Sub

    Private Sub NoButton_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NoButton.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Right Then
            Me.DialogResult = Windows.Forms.DialogResult.No
            Me.Close()
        End If
    End Sub

End Class