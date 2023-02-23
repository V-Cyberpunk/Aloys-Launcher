// Copyright (c) V.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Aloys.WoW.Launcher.Misc;

static class Helpers
{
    public static (int Major, int Minor, int Revision, int Build) GetVersionValueFromClient(string fileName)
    {
        var fileVersionInfo = FileVersionInfo.GetVersionInfo(fileName);

        return (fileVersionInfo.FileMajorPart, fileVersionInfo.FileMinorPart,
                fileVersionInfo.FileBuildPart, fileVersionInfo.FilePrivatePart);
    }

    public static void PrintHeader()
    {
        Console.ForegroundColor = ConsoleColor.Cyan;

        Console.WriteLine(@"_____________World of Warcraft___________");

        Console.WriteLine();
        Console.WriteLine($"Operating System: {RuntimeInformation.OSDescription}");
    }

    public static bool IsFileClosed(string filename)
    {
        try
        {
            using (var inputStream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.None))
                return false;
        }
        catch (Exception)
        {
            return true;
        }
    }
}
