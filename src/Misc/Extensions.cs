//MIT License

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

static class Extensions
{
    public static nint ToNint(this byte[] buffer) => (nint)BitConverter.ToInt64(buffer, 0);
    public static nint ToNint(this long value) => (nint)value;

    public static byte[] GetCopy(this byte[] data)
    {
        var copy = new byte[data.Length];

        Array.Copy(data, copy, data.Length);

        return copy;
    }

    public static short[] GetCopy(this short[] data)
    {
        var copy = new short[data.Length];

        Array.Copy(data, copy, data.Length);

        return copy;
    }

    public static long FindPattern(this byte[] data, short[] pattern, long start, long baseOffset = 0)
    {
        long matches;

        for (long i = start; i < data.Length; i++)
        {
            if (pattern.Length > (data.Length - i))
                return 0;

            for (matches = 0; matches < pattern.Length; matches++)
            {
                if ((pattern[matches] != -1) && (data[i + matches] != (byte)pattern[matches]))
                    break;
            }

            if (matches == pattern.Length)
                return baseOffset + i;
        }

        return 0;
    }

    public static long FindPattern(this byte[] data, short[] pattern, long baseOffset = 0) => FindPattern(data, pattern, 0L, baseOffset);

    public static HashSet<long> FindPattern(this byte[] data, short[] pattern, int maxMatches, long maxOffset)
    {
        var matchList = new HashSet<long>();

        long match = 0;

        do
        {
            match = data.FindPattern(pattern, match, 0);

            if (match != 0)
            {
                if (!matchList.Contains(match))
                    matchList.Add(match);

                match += pattern.Length;
            }

        } while ((matchList.Count < maxMatches || match < maxOffset) && match != 0);

        return matchList;
    }

    public static short[] ToPattern(this string data) => Encoding.UTF8.GetBytes(data).Select(b => (short)b).ToArray();
}
