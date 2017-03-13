Module ScreenSaver
    Declare Function GetDesktopWindow Lib "user32" () As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSExpressCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hWnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Integer) As Integer

    Public Const WM_SYSCOMMAND As Integer = &H112
    Public Const SC_SCREENSAVE As Integer = &HF140

    Function gf_StartScreenSaver() As Boolean
        Dim hWnd As Integer
        On Error Resume Next
        hWnd = GetDesktopWindow()
        Call SendMessage(hWnd, WM_SYSCOMMAND, SC_SCREENSAVE, 0)
        gf_StartScreenSaver = (Err.Number = 0)
    End Function
End Module
