///MIT License

//Copyright (c) Arctium

//Permission is hereby granted, free of charge, to any person obtaining a copy
//of this software and associated documentation files (the "Software"), to deal
//in the Software without restriction, including without limitation the rights
//to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//copies of the Software, and to permit persons to whom the Software is
//furnished to do so, subject to the following conditions:

//The above copyright notice and this permission notice shall be included in all
//copies or substantial portions of the Software.

//THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//SOFTWARE. 

namespace Aloys.WoW.Launcher.Misc;

static class NativeWindows
{
    /// kernel32.dll
    // Process
    [DllImport("kernel32.dll", EntryPoint = "CreateProcessA", SetLastError = true)]
    public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, nint lpProcessAttributes, nint lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, nint lpEnvironment, string lpCurrentDirectory, ref StartupInfo lpStartupInfo, out ProcessInformation lpProcessInformation);

    [DllImport("kernel32.dll", EntryPoint = "TerminateProcess")]
    public static extern void TerminateProcess(nint processHandle, int exitCode);

    [DllImport("kernel32.dll", EntryPoint = "CloseHandle")]
    public static extern void CloseHandle(nint handle);

    // Memory
    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern int VirtualQueryEx(nint hProcess, nint lpBaseAddress, out MemoryBasicInformation mbi, int dwSize);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern nint VirtualAllocEx(nint hProcess, nint lpAddress, uint dwSize, uint flAllocationType, uint flProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool VirtualProtectEx(nint hProcess, nint lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);

    [DllImport("kernel32.dll", SetLastError = true)]
    public static extern bool ReadProcessMemory(nint hProcess, nint lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesRead);

    [DllImport("kernel32.dll", SetLastError = true)]
    internal static extern bool WriteProcessMemory(nint hProcess, nint lpBaseAddress, byte[] lpBuffer, int nSize, out int lpNumberOfBytesWritten);

    [DllImport("kernel32.dll", EntryPoint = "FlushInstructionCache", SetLastError = true)]
    public static extern bool FlushInstructionCache(nint hProcess, nint lpBaseAddress, uint dwSize);

    /// ntdll.dll
    // Process
    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern NtStatus NtQueryInformationProcess(nint hProcess, int pic, ref ProcessBasicInformation pbi, int cb, out int pSize);

    // Page/View
    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern NtStatus NtCreateSection(ref nint sectionHandle, uint accessMask, nint zero, ref LargeInteger maximumSize, uint protection, uint allocationAttributes, nint zero2);

    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern NtStatus NtMapViewOfSection(nint sectionHandle, nint proccessHandle, ref nint baseAddress, nint zero, ulong regionSize, out LargeInteger sectionOffset, out uint viewSize, uint viewSection, nint zero2, int protection);

    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern NtStatus NtUnmapViewOfSection(nint processHandle, nint baseAddress);

    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern nint NtResumeProcess(nint ProcessHandle);

    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern nint NtSuspendProcess(nint ProcessHandle);

    [DllImport("ntdll.dll", SetLastError = true)]
    public static extern nint NtClose(nint handle);
}
