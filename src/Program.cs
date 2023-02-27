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

using System.CommandLine.Parsing;
using Aloys.WoW.Launcher;
using static Aloys.WoW.Launcher.Misc.Helpers;

CheckConf();

// "Aloys" should not be removed from the final binary name.
if (!Process.GetCurrentProcess().ProcessName.ToLowerInvariant().Contains("aloys"))
    WaitAndExit();

PrintHeader();

LaunchOptions.RootCommand.SetHandler(context =>
{
    var appPath = Launcher.PrepareGameLaunch(context.ParseResult);
    var gameCommandLine = string.Join(" ", context.ParseResult.UnmatchedTokens);

    if (string.IsNullOrEmpty(appPath) || !Launcher.LaunchGame(appPath, gameCommandLine, context.ParseResult.HasOption(LaunchOptions.UseStaticAuthSeed)))
        WaitAndExit(5000);
});

await LaunchOptions.Instance.InvokeAsync(args);


static void WaitAndExit(int ms = 2000)
{
    Console.ForegroundColor = ConsoleColor.Gray;
    Console.WriteLine($"Closing in {ms / 1000} seconds...");

    Thread.Sleep(ms);

    Environment.Exit(0);
}
