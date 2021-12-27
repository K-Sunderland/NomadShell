Public Class Password
    Public Event passvalue(text As String)

    Private Sub btnpassvalue_Click(sender As Object, e As EventArgs) Handles unlockBtn.Click
        RaiseEvent passvalue(pwInput.Text)
        Me.Close()
    End Sub

    Private Sub pwInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pwInput.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            RaiseEvent passvalue(pwInput.Text)
            Me.Close()
        End If
    End Sub
End Class