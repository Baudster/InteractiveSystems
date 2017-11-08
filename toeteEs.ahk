SetTitleMatchMode, 2
IfWinExist, Visual Studio
{
	WinGet, FUCKING_VS, ProcessName, Visual Studio
	WinGet, FUCKING_VS_PATH, ProcessPath, Visual Studio
}
Else
{
	return
}
MsgBox % FUCKING_VS_PATH . "\" . FUCKING_VS
WinClose, Visual Studio

Run, %FUCKING_VS_PATH% . "\" . %FUCKING_VS% . " /command `"File.OpenSolution InteractiveSystems.sln`"",,, FUCKING_VS_PID
