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

namespace Aloys.WoW.Launcher.Patches;

static class Windows
{
#if x64
    public static byte[] Integrity = { 0xC2, 0x00, 0x00 };
    public static byte[] CertBundle = { 0x90, 0x90 };
    public static byte[] CertCommonName = { 0xB0, 0x01 };
    public static byte[] ShortJump = { 0xEB };
    public static byte[] NoJump = { 0x00, 0x00, 0x00, 0x00 };
    public static byte[] AuthSeed = { 0x0F, 0x28, 0x05, 0xEF, 0xBE, 0xAD, 0xDE, 0x0F, 0x11, 0x02, 0xC3 };
#elif ARM64
    public static byte[] Integrity = { };
    public static byte[] Branch = { 0xB5 };
    public static byte[] CertCommonName = { 0x20 };
#endif

    // Registry entry used for -launcherlogin.
    public static byte[] LauncherLogin = Encoding.UTF8.GetBytes(@"Software\Custom Game Server Dev\Battle.net\Launch Options\");
}
