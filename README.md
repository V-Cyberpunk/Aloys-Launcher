# Aloys-Launcher
## Description and little theory
Modified version derived from the Arctium WoW-Launcher with some great new features under GPLv3.

Currently I externalized CDN links for versions and cdns file. Also the certs for adding own self signed certs to the launcher and server.<br />
These files are needed for real independency from any servers. The actual Arctium WoW Launcher does link hardcoded to it's own CDN and hardcodes the certs, but this is crap. It's not good to be dependent from anothers server and hardcoded certs. The self signed TrinityCore certs are in the src and best known, so anyone can decrypt the connection. With own self signed certs, you are secure.<br />
Do you want dependency from a random person? Sure, you won't! So, here is my solution, the real deal, for self-sufficiency.
You can host the files in your own lab or with local httpd included in the companiontool on localhost. Files are here for your lab: https://github.com/V-Cyberpunk/World-of-Warcraft-Local-CDN-files

## Example
For example: if your machines hostname is "tc-server" and versions file is in "/var/www/html/versions" your entry for versions.conf will be "tc-server/versions".<br />
If it is also the localhost "localhost/versions" is possible, too. If it is another server in your network, you will need a DNS A record or an entry in your hosts, because WoW needs a domain!

## The files
- cdns.conf contains the link to the cdns file - max 32 chars
- versions.conf contains the link to the versions file - max 36 chars
- certs.conf contains the certs base64 coded

For getting the cdn files, you can use my https://github.com/V-Cyberpunk/Linux-Server-Toolscripts/blob/main/mk_cdn.sh script. eu, us, arctium are the same, but good to have all sources maybe.

## Companiontool
The Companiontool administrates CDN links, portal link and certs for Retail, Classic and Classic-Era<br /><br />
![Companiontool](companiontool.png?raw=true "Companiontool")

## Compiling and usage

Compiling and options are the same like in the original project.

Here are the relevant parts from the original README:

### Supported Game Versions (Windows x86 64 bit)
* Dragonflight: 10.0.0, 10.0.2, 10.0.5 (implicit)
* Shadowlands: 9.1.0, 9.1.5, 9.2.0, 9.2.5, 9.2.7 (implicit)
* Classic: 2.5.2, 2.5.3, 2.5.4, 3.4.x (--version Classic)
* Classic Era: 1.14.x (--version ClassicEra)

## Building

### Build Prerequisites
* [.NET Core SDK 7.0.0 or later](https://dotnet.microsoft.com/download/dotnet/7.0)
* Optional for native builds: C++ workload through Visual Studio 2022 or latest C++ build tools

### Build Instructions Windows (native)
* Available runtime identifiers/platforms: win-x64/x64, win-arm64/ARM64
* Available release configurations: Release, ReleaseSilentMode, ReleaseCustomFiles, ReleaseCustomFilesSilentMode
* Execute `dotnet publish -r RuntimeIdentifier -c Configuration -p:platform="Platform"`
* Native output is placed in `build\Configuration\bin\native`

## Usage

### Windows Usage
1. Copy `Aloys WoW Launcher.exe` to your World of Warcraft folder.
2. Optional: Edit the `WTF/Config.wtf` to set your portal or use a different config file with the `-config Config2.wtf` launch arg.
3. Run the `Aloys WoW Launcher.exe`

### Static Auth Seed Usage
* Use the --staticseed launch parameter
* On server side add `179D3DC3235629D07113A9B3867F97A7` as auth seed in the database.

### Custom File Loading Usage
1. Get or create your own file mapping (.txt) file(s) and place it in the `mappings` folder.
   File Format: `fileId;filePath`
2. Place your custom files (mods) in the `files` folder. Be sure to follow the correct folder structure.

### File mapping sources
* https://github.com/wowdev/wow-listfile

### Launch Parameters
* Use --help

## WARNING

DO NOT USE THIS AS BASE FOR ANY OFFICIAL SERVER TOOLS.
IT WILL GET YOU BANNED THERE!!!

Please do NOT remove the name `aloys` from the final binary.
