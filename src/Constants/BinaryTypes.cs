// Copyright (c) V.
// Licensed under the GPLv3 license. See LICENSE file in the project root for full license information.

namespace Aloys.WoW.Launcher.Constants;

enum BinaryTypes : uint
{
    None   = 0000000000,
    Pe32   = 0x0000014C,
    Pe64   = 0x00008664,
    Mach32 = 0xFEEDFACE,
    Mach64 = 0xFEEDFACF
}
