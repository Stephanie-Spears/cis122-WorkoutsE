Imports System.IO

Module modUtilities

	'***DO NOT TOUCH ANYTHING IN THIS FILE***

	Private g_sInitialFontFamily As String = "Trebuchet MS"
	Private g_iInitialFontSize As Integer = 12
	Private g_InitialFontStyle As FontStyle = FontStyle.Regular
	Private g_InitialBackColor As Color = Color.FromArgb(&HFF193960)
	Private g_InitialForeColor As Color = Color.White


	Private g_sCurrentFontFamily As String
	Private g_iCurrentFontSize As Integer
	Private g_CurrentFontStyle As FontStyle
	Private g_CurrentForeColor As Color
	Private g_CurrentBackColor As Color

	'Publics
	Public Const NL As String = vbNewLine
	Public Const Enter As String = vbNewLine

	Public g_bInputEntered As Boolean = False
	Public g_sCurrentInput As String = ""
	Public g_bReadNumber As Boolean = False
	Public g_bReadInteger As Boolean = False
	Public g_bReadChar As Boolean = False


	Public Sub Init()

		g_sCurrentFontFamily = g_sInitialFontFamily
		g_iCurrentFontSize = g_iInitialFontSize
		g_CurrentFontStyle = g_InitialFontStyle
		g_CurrentForeColor = g_InitialForeColor
		g_CurrentBackColor = g_InitialBackColor

		frmMain.rtfMain.ForeColor = g_InitialForeColor
		frmMain.rtfMain.BackColor = g_InitialBackColor

		frmMain.rtfMain.Font = New Font(g_sInitialFontFamily, g_iInitialFontSize, g_InitialFontStyle)

		g_bReadChar = False

	End Sub


	Public Sub ClearDisplay()

		frmMain.rtfMain.Clear()
		Init()

	End Sub


	Public Sub DisplayLine(Optional ByVal pv_objText As Object = "")

		Dim sText As String = CStr(pv_objText)

		Display(sText & vbNewLine)

	End Sub


	Public Sub Display(ByVal pv_objText As Object)

		Dim sText As String = CStr(pv_objText)

		frmMain.rtfMain.SelectionFont = New Font(g_sInitialFontFamily, g_iCurrentFontSize, g_CurrentFontStyle)
		frmMain.rtfMain.SelectionColor = g_CurrentForeColor
		frmMain.rtfMain.SelectionBackColor = g_CurrentBackColor
		frmMain.rtfMain.AppendText(sText)

	End Sub


	Public Function ReadString(Optional ByVal pv_bReadChar As Boolean = False) As String

		g_bReadChar = pv_bReadChar

		frmMain.rtfMain.SelectionFont = New Font(g_sInitialFontFamily, g_iCurrentFontSize, g_CurrentFontStyle)
		frmMain.rtfMain.SelectionColor = g_CurrentForeColor
		frmMain.rtfMain.SelectionBackColor = g_CurrentBackColor

		frmMain.rtfMain.Focus()

		g_sCurrentInput = ""
		g_bInputEntered = False
		g_bReadNumber = False
		g_bReadInteger = False

		While Not g_bInputEntered
			Threading.Thread.Sleep(50)
			Application.DoEvents()
		End While

		'strip out newline
		If g_bReadChar Then
			g_bReadChar = False
			frmMain.rtfMain.AppendText(vbNewLine)
			Return g_sCurrentInput
		Else
			Return g_sCurrentInput.Substring(0, g_sCurrentInput.Length - 1)
		End If

	End Function


	Public Function ReadChar() As String
		Return ReadString(True)
	End Function


	'Public Function ReadNumber() As Decimal

	'	g_bReadChar = False

	'	frmMain.rtfMain.SelectionFont = New Font(g_sInitialFontFamily, g_iCurrentFontSize, g_CurrentFontStyle)
	'	frmMain.rtfMain.SelectionColor = g_CurrentForeColor
	'	frmMain.rtfMain.SelectionBackColor = g_CurrentBackColor

	'	frmMain.rtfMain.Focus()

	'	g_sCurrentInput = ""
	'	g_bInputEntered = False
	'	g_bReadNumber = True

	'	While Not g_bInputEntered
	'		Threading.Thread.Sleep(50)
	'		Application.DoEvents()
	'	End While

	'	If Not IsNumeric(g_sCurrentInput) Then
	'		Return -1
	'	Else
	'		Return Convert.ToDecimal(g_sCurrentInput)
	'	End If

	'End Function


	Private Function ReadNbr() As String

		g_bReadChar = False

		frmMain.rtfMain.SelectionFont = New Font(g_sInitialFontFamily, g_iCurrentFontSize, g_CurrentFontStyle)
		frmMain.rtfMain.SelectionColor = g_CurrentForeColor
		frmMain.rtfMain.SelectionBackColor = g_CurrentBackColor

		frmMain.rtfMain.Focus()

		g_sCurrentInput = ""
		g_bInputEntered = False
		g_bReadNumber = True

		While Not g_bInputEntered
			Threading.Thread.Sleep(50)
			Application.DoEvents()
		End While

		If Not IsNumeric(g_sCurrentInput) Then
			Return ""
		Else
			Return g_sCurrentInput
		End If


	End Function


	Public Function ReadInteger() As Integer

		Dim sNbr As String

		g_bReadInteger = True
		sNbr = ReadNbr()

		If sNbr = "" Then
			Return -1
		Else
			Return CInt(sNbr)
		End If

	End Function



	Public Function ReadDouble() As Double

		Dim sNbr As String

		g_bReadInteger = False
		sNbr = ReadNbr()

		If sNbr = "" Then
			Return -1
		Else
			Return CDbl(sNbr)
		End If

	End Function


	Public Function ReadDecimal() As Double

		Return ReadDouble()

	End Function


	Public Sub SetTitle(ByVal pv_sTitle As String)

		frmMain.Text = pv_sTitle
		frmMain.lblTitle.Text = pv_sTitle

	End Sub


	Public Sub SetForegroundColor(ByVal pv_Color As Color)
		g_CurrentForeColor = pv_Color
	End Sub


	Public Sub SetBackgroundColor(ByVal pv_Color As Color)
		g_CurrentBackColor = pv_Color
	End Sub


	Public Sub ResetForegroundColor()
		g_CurrentForeColor = g_InitialForeColor
	End Sub


	Public Sub ResetBackgroundColor()
		g_CurrentBackColor = g_InitialBackColor
	End Sub


	Public Sub ResetColors()

		g_CurrentForeColor = g_InitialForeColor
		g_CurrentBackColor = g_InitialBackColor

	End Sub


	Public Sub SetFontFamily(ByVal pv_sFontFamily As String)

		g_sInitialFontFamily = pv_sFontFamily
		frmMain.rtfMain.Font = New Font(g_sInitialFontFamily, g_iCurrentFontSize)

	End Sub


	Public Sub SetFontSize(ByVal pv_iFontSize As Integer)
		g_iCurrentFontSize = pv_iFontSize
	End Sub


	Public Sub ResetFontSize()
		g_iCurrentFontSize = g_iInitialFontSize
	End Sub


	Public Sub SetFontNormal()
		g_CurrentFontStyle = FontStyle.Regular
	End Sub


	Public Sub SetFontBold()
		g_CurrentFontStyle = FontStyle.Bold
	End Sub


	Public Sub SetFontItalic()
		g_CurrentFontStyle = FontStyle.Italic
	End Sub


	Public Sub SetFontBoldItalic()
		g_CurrentFontStyle = FontStyle.Bold Or FontStyle.Italic
	End Sub


	Public Function GetRandomNumber(ByVal pv_iHighNumber As Integer, Optional ByVal pv_iLowNumber As Integer = 1) As Integer

		Dim iRandomNbr As Integer

		Randomize()
		iRandomNbr = CInt(Int((pv_iHighNumber - pv_iLowNumber + 1) * Rnd() + pv_iLowNumber))

		Return iRandomNbr

	End Function

End Module
