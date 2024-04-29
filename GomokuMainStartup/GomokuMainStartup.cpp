#include <Windows.h>
void GomokuMainStartup()
{
    BOOL ret;
    IsWow64Process(GetCurrentProcess(), &ret);
    STARTUPINFOW si;
    PROCESS_INFORMATION pi;
    ZeroMemory(&si, sizeof(si));
    si.cb = sizeof(si);
    ZeroMemory(&pi, sizeof(pi));
    CreateProcessW(ret ? L"Gomoku.exe" : L"Gomoku x86.exe", NULL, NULL, NULL, FALSE, 0, NULL, NULL, &si, &pi);
    WaitForSingleObject(pi.hProcess, INFINITE);
    CloseHandle(pi.hProcess);
    CloseHandle(pi.hThread);
};