// Copyright (c) V.
// Licensed under the GPLv3 license. See LICENSE file in the project root for full license information.

namespace Aloys.WoW.Launcher.Structures;

[StructLayout(LayoutKind.Sequential, Pack = 1)]
struct ProcessBasicInformation
{
    public nint ExitStatus;
    public nint PebBaseAddress;
    public nint AffinityMask;
    public nint BasePriority;
    public nint UniqueProcessId;
    public nint InheritedFromUniqueProcessId;

    public static int Size => Marshal.SizeOf<ProcessBasicInformation>();
}
