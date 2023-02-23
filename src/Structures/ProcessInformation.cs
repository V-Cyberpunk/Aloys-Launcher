﻿// Copyright (c) V.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aloys.WoW.Launcher.Structures;

struct ProcessInformation
{
    public nint ProcessHandle;
    public nint ThreadHandle;
    public uint ProcessId;
    public uint ThreadId;

    public static int Size => Marshal.SizeOf<ProcessInformation>();
}
