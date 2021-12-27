Imports System.IO
Imports M
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
		Try
			Process.Start("C:\Program Files\ETC\EosFamily\v3\ETC_Launch\ETC_LaunchOffline.exe")

		Catch
			MsgBox("Install ETC EOS to run this command.", vbCritical, "Missing EOS")
		End Try





	End Sub

	Private Sub launchArtnet_Click(sender As Object, e As EventArgs) Handles launchArtnet.Click
		Try
			Directory.SetCurrentDirectory("C:\Program Files\uDMXArtnetP5.windows\")
			Process.Start("C:\Program Files\uDMXArtnetP5.windows\uDMXArtnetP5.bat")

		Catch
			MsgBox("uDMX P5 isn't installed, or is not located in the program files folder", vbCritical, "Missing uDMXArtnet")
		End Try
	End Sub

	Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click

		Dim Result = MsgBox("Are you sure you want to log off?" + vbNewLine + "Unsaved work might be lost.", vbOKCancel + vbQuestion, "Log off")
		If Result = vbOK Then
			Process.Start("shutdown.exe", "/l")
		Else
		End If


	End Sub

	Private Sub powerOff_Click(sender As Object, e As EventArgs) Handles powerOff.Click
		Dim Result = MsgBox("Are you sure you want to power the console off?" + vbNewLine + "Unsaved work might be lost.", vbOKCancel + vbQuestion, "Power down")
		If Result = vbOK Then
			Process.Start("shutdown.exe", "/s")
		Else
		End If
	End Sub
End Class
