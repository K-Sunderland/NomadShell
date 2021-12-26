Public Class Password
    Public Event passvalue(text As String)

    Private Sub btnpassvalue_Click(sender As Object, e As EventArgs) Handles unlockBtn.Click
        RaiseEvent passvalue(pwInput.Text)
        Me.Close()
    End Sub


End Class