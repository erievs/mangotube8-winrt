# MangoTube8.1 #

![Homescreen](https://i.imgur.com/w5q8aFZ.png)

# Benefits #

This Will Receive Updates More Often Than Sliverlight 

Other resolutions besides 360p

~~ Captions ~~ [Soon!]

UI Better Fits Screens

HLS Streaming Support

Better Player

And more!

# Other MangoTube Versions #

## If You're Using Windows Phone 8 ##

https://github.com/erievs/MangoTube8/

## If You Want More Features (For Now) And A More Stock Metro Sty;e ##

https://github.com/erievs/mangotube8/

# Things to Know #

- Sometimes this app is called MangoTube8 WinRT or even UWP (I got confused between universal 8.1 apps and UWPS), this is because I didn't settle on the name MangoTube8.1 untuil later so in the code it is still MangoTube8UWP (it is in fact not a UWP).

- No Windows Desktop Support 8.1 (Won't Work, I am 100% Sure)

- In resolutions other than 360p, there will be lip syncing issues. It'll be there because YouTube doesn't offer any other resolutions with audio built in so we have to sync it, and we cannot sync it SO much or else the app will be SUPER laggy.

-  They're only 3 resolutions FOR NOW, (as of 23/11/2024), they will be added later (not a ton of work but it'd take another hour and I am kind of tired).

-  Auto uses HLS (yes Apple's Tech), just wanted to let you know not super important.

-  Homepage Recommended videos are based on what you watch, every video you watch gets added to a list (that is stored), and a random video is picked (currently the last 5 videos you watched).

-  The Spotlight page only shows approximate views, as for some reason in this page only gives views in k format like 18.1k or something like that, but the other feids it is fine. I could fix this but it'd involve two requests for no reason.

-  Browse page doesn't work yet, all the feeds are implemented code side but I just haven't built a UI like.

-  This aims to recreate the Windows Phone 8 YouTube app fairly accurately (not perfect of course).

- Darkmode will be coming soon.

- Bugs I know about that will be fixed next update, rewind/backwards has some audio issues (not super hard to fix I know why just gotta sync em up), some places video IDs don't save to storage, rarely on startup the recommended page doesn't load, not a bug but not no background audio support for now (It is hard to do for me), there is orientation issue where it doesn't full-screen when you rotate will be fixed next update again, the MangoTube logo is offcentre oops.

- Please report bugs in issues not ONLY on a discord server.

- Please don't have a list of a feature requsts, make one 'issue' for each, and please do not go overboard in feature requsts (I am not going to add TV playback or whatever THAT WOULD BE A LOT OF WORK AND LIKE IDK IF IT IS EVEN POSSIBLE).

- This is a hobby project, I may refuse to repsond to support requsts, I have to say this because this has happened before but if you keep calling me on discord (I never call anyone I don't know IRL on discord) or annoy me I will be pissed off at you, I do not get paid, I like what I like don't arugue about colours or else I will force piss mode.

- I go by NCP,NCP3.0,Erie Valley Software,ErieVS.

- Why Mango, because of Windows Phone 7.5 someone a discord server suggseted it (yes I know this doesn't 7.5 but I like the name).

- Will there be a 7.5 build or 7, maybe if I can figure out how to jailbreak by titan (if someone can help I'll do it).

- Will there be a real UWP version, maybe idk.

- I don't have a discord server but I hang out and talk about MangoTube on multiple Windows Phone realated server some more than other.

- If you live in Russia or Belarus you're probably screwed sorry not much I can do for you maybe. I'm not really going to be able to offer support to y'all because it's more than likely a geo blocking thing or something network related and I don't live there not much I can do. Try a VPN or Proxy I guess.

- Please avoid saying "fix blank" network related thing, instead connect to visual studio and run/build the MangoTube8.1 project and give me the output. I am sadly not a network reader so I cannot really do much, if you can figure out a way to reproduce it reliably then tell me and I can do it myself.

# Dependencies #

## User ##

https://github.com/basharast/wut/releases (Use this and install all dependencies for now, they’re less than this, but this has all the ones I know you need, at some point I will have a link for just the ones that this project needs, I know it needs like VCLib120 or something).

Update 23/11/2024

https://download.microsoft.com/download/5/F/0/5F0F8404-9329-44A9-8176-ED6F7F746F25/VCLibs_Redist_Packages.zip

(You may only need this!)

## Dev ##

https://codeplexarchive.org/project/phonesm (you’ll need to build media-player for 8.1 which should be in libs)

https://codeplexarchive.org/project/playerframework

https://marketplace.visualstudio.com/items?itemName=Cenkd.MicrosoftSmoothStreamingClientSDKforWindows81


