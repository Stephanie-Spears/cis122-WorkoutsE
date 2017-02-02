Public Class frmMain

	'***DO NOT TOUCH ANYTHING IN THIS FILE***

	'Name: Project Start
	'Purpose: Template for CIS 122 projects
	'Author: Michael Passalacqua
	'Date: 7/1/2013

	Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load

		'- selected font attributes revert back to normal after a newline
		'- Font and Forecolor properties will change *everything* in the textbox.

		Init()
		btnRunProject.Focus()

	End Sub


	Private Sub btnRunProject_Click(sender As Object, e As EventArgs) Handles btnRunProject.Click

		rtfMain.ReadOnly = False
		Init()
		ClearDisplay()
		RunProject()

		ResetColors()
		ResetFontSize()
		SetFontNormal()
		Display(NL & NL & "** End Program **")

		rtfMain.ReadOnly = True
		btnRunProject.Focus()

	End Sub


	Private Sub rtfMain_KeyDown(sender As Object, e As KeyEventArgs) Handles rtfMain.KeyDown

		Select Case (e.KeyCode)
			Case Keys.Left, Keys.Right, Keys.Up, Keys.Down, Keys.Home, Keys.End, Keys.PageDown, Keys.PageUp, Keys.Delete, Keys.Insert
				'do not allow user to input these keys
				e.Handled = True

			Case Keys.Back
				If g_sCurrentInput.Length = 0 Then
					e.Handled = True 'ignore backspace
				End If

			Case Keys.Return
				g_bInputEntered = True

		End Select

	End Sub


	Private Sub rtfMain_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rtfMain.KeyPress

		If e.KeyChar = ControlChars.Back Then
			If g_sCurrentInput.Length = 0 Then
				e.Handled = True 'ignore backspace
			Else
				g_sCurrentInput = g_sCurrentInput.Substring(0, g_sCurrentInput.Length - 1)	'remove last character
			End If
		ElseIf g_bReadNumber Then
			If (e.KeyChar >= "0" And e.KeyChar <= "9") Or (e.KeyChar = "-" And g_sCurrentInput.Length = 0) Or (e.KeyChar = "." And Not g_bReadInteger) Then
				e.Handled = False
				g_sCurrentInput += e.KeyChar
			Else
				e.Handled = True
				Beep()
			End If
		Else
			e.Handled = False
			g_sCurrentInput += e.KeyChar
		End If

		'handle reading of a single char
		If g_bReadChar And g_sCurrentInput.Length = 1 Then
			g_bInputEntered = True
		End If

	End Sub


	Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
		rtfMain.Clear()
	End Sub


	Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
		Me.Close()
	End Sub


	Private Sub frmMain_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed

		Try
			'Threading.Thread.CurrentThread.Abort()
			Environment.Exit(0) 'this seems to shut down all threads without causing any problems
			'Application.Exit()

		Catch ex As Exception
			'The thread abort throws an exception. Let's catch it just to keep things clean.

		Finally
			'Application.Exit()

		End Try

	End Sub

End Class
