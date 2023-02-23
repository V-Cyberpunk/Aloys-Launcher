# Aloys-Launcher
Modified version derived of the Arctium WoW-Launcher with some great new features.

Actually I externalized cdn links for versions and cdns file. Also the certs for adding own self signed certs to the launcher and server.<br />
These files are needed for real independency from any servers. The actual Arctium WoW Launcher does link hardcoded to it's own cdn and hardcodes the certs, but this is crap. It's not good to be dependent from anothers server and hardcoded certs. The self signed TrinityCore certs are in the src and best known, so anyone can decrypt the connection. With own self signed certs, you are secure.<br />
Do you want dependency from a random person? Sure, you won't! So, here is my solution, the real deal, for self-sufficiency.
You can host the files in your own lab or with local httpd on localhost.

For example: if your machines hostname is "tc-server" and versions file is in "/var/www/html/versions" your entry for versions.txt will be "tc-server/versions".<br />
If it is also the localhost "localhost/versions" is possible, too. If it is another server in your network, you will need a DNS A record or an entry in your hosts, because WoW needs a domain!

- cdns.txt contains the link to the cdns file
- versions.txt contains the link to the versions file
- certs.txt contains the certs base64 coded

For getting the cdn files, you can use my https://github.com/V-Cyberpunk/Linux-Server-Toolscripts/blob/main/mk_cdn.sh script. eu, us, arctium are the same, but good to have all sources maybe.

Compiling and Options are the same like in the original project.
