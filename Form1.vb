Public Class Form1

	WithEvents pw As Password
	Dim locked
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

		If Process.GetProcessesByName("explorer").Count > 0 Then
			locked = False
			unlock.Text = "Lock"
		Else
			locked = True
			unlock.Text = "Unlock"
		End If

	End Sub






	'lock/unlock method'
	Private Sub Unlock_Click(sender As Object, e As EventArgs) Handles unlock.Click

		If locked = True Then
			pw = New Password
			pw.Show()
		Else
			Dim taskKill = New ProcessStartInfo("taskkill", "/F /IM explorer.exe")
			taskKill.WindowStyle = ProcessWindowStyle.Hidden
			Dim Process = New Process()
			Process.StartInfo = taskKill
			Process.Start()
			Process.WaitForExit()
			unlock.Text = "Unlock"
			locked = True
		End If

	End Sub

	Private Sub pw_passvalue(text As String) Handles pw.passvalue
		If text = "fresnel" Then
			Process.Start("C:\Windows\explorer.exe")
			unlock.Text = "Lock"
			locked = False
		Else
			MsgBox("Incorrect Password", vbCritical, "Incorrect")
		End If


	End Sub

	Private Sub launchEos_Click(sender As Object, e As EventArgs) Handles launchEos.Click
		Process.Start("C:\Program Files\ETC\EosFamily\v3\ETC_Launch\ETC_LaunchOffline.exe")
	End Sub
End Class
