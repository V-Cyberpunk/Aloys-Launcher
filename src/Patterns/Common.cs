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


//Modifications: Copyright(c) V under GPL v3 

namespace Aloys.WoW.Launcher.Patterns;

static class Common
{
    public static short[] ConnectToModulus = { 0x91, 0xD5, 0x9B, 0xB7, 0xD4, 0xE1, 0x83, 0xA5 };
    public static short[] SignatureModulus = { 0x35, 0xFF, 0x17, 0xE7, 0x33, 0xC4, 0xD3, 0xD4 };
    public static short[] CryptoRsaModulus = { 0x71, 0xFD, 0xFA, 0x60, 0x14, 0x0D, 0xF2, 0x05 };
    public static short[] CryptoEdPublicKey = { 0x15, 0xD6, 0x18, 0xBD, 0x7D, 0xB5, 0x77, 0xBD };

    public static short[] CertBundle = "{\"Created\":".ToPattern();
    public static short[] VersionUrl = "%s.patch.battle.net:1119/%s/versions".ToPattern();
    public static short[] CdnsUrl = "%s.patch.battle.net:1119/%s/cdns".ToPattern();
    public static short[] Portal = ".actual.battle.net\0".ToPattern();
    public static short[] CommandLineHelp = "World of Warcraft usage".ToPattern();
}
