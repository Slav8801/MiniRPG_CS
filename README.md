# Giant's Steps


## 1. About

Giant's Steps is a mini roguelike dungeon crawler RPG with turn based combat. It is written in C# and played
in a Command Line Interface (CLI).

You play as a lonely adventurer looking for fame and/or fortune. On your trip you will collect loot
with randomly generated stats and fight generated enemies while navigating randomly generated mazes.

I made it in my spare weekends, in between being a dad, contracting and working on MoonWard.

It began as an experiment to see what's the least amount of lines I can fit a full game inside.
The orginial goal was 600 lines but it quickly grew and is now just under 1000.

I'm happy with the size but I think I need to unpack some lines.
I may have gone too far in a few places with the line saving.


## 2. Installation

First off - you will unfortunately need Windows, Wine on Linux or WineBottler on MacOS to play this.
Might look into porting this to Linux proper and even to MacOS but no promises as of now.

The executable requires .NET Runtime 5.0.17. The following steps are for windows.

- To get .NET Runtime 5.0.17 go to this link: https://dotnet.microsoft.com/en-us/download/dotnet/5.0
- Under the "5.0.17" tab, search for ".NET Runtime 5.0.17", it'll be on the bottom right.
- Download the installer that corresponds to your system (Windows/x64 for most of you).
- When the download is complete use the executable, install and you're ready.

Disclaimer: I've only tested this on Windows so not sure if Wine/WineBottler will even work.

TO Install GS:

- Download the latest Release. Unzip in a desired folder. Run "MiniRPG_CS.exe".
- Rip and Tear. That's a bit dramatic. Simply copy the code in this project's "Program.cs" file, create a new
C# Console Application project in Visual Studio, paste the code in your new project's "Program.cs" file
and start debugging. Build an executable if you like - it's up to you. My project targets .NET 5.0,
but the code should be .NET agnostic so I don't think that should be an issue for anyone.


## 3. How to play

This section was difficult to write because everything you can do is shown as a text prompt on
the screen. Basically, GS is a command line game. Options will be presented to you on screen, you
will then pick an option, type its index (0/1/2/3 etc.) and press Enter to execute. There is NO saving,
not active or passive. Your run dies when you close the game. You are warned!

This should be enough for you to start playing. If you think you're ready, then - go, play the game!

Still here? Alright I'll elaborate a bit more.

I'll avoid the screen by screen breakdown because that shouldn't be necessary anyway. Instead I'll
just give you a quick overview of the more obscure things. GS is a dungeon crawler which means you
go from room to room clearing enemies or looting loot. Moving to a new room always uses 1 ration and heals
you for your Health Regeneration amount. Resting heals you for 2 times that amount and only uses 1 ration.
If you run out of rations you can't rest and you won't heal when moving between rooms. Here's a list of
the different rooms types as shown on the map screen:

- <div>[x] -> You are here.</div>
- \[?] -> Unexplored. You can see unexplored rooms adjcened to your location on the map. Exploring this
room will either start a fight or reveal an empty or treasure room.
- \[_] -> Empty. Explored and empty. This room has nothing of interest.
- \[*] -> Treasure. Explored and has an item in it.
- /_\\ -> Staircase. Descends a single depth level. One way trip down. Use or collect items on your
current level before proceding!

The combat system has some quirks you might want to be aware of. Firstly, combat is turn based. You will
usually start first but the enemy can ambush you based on the Initiative stat. You and your opponent take
turns. Only one action can be performed per combat turn. Those are:

- Light Attacks. A number of attacks based on the weapon's Swings stat. They tend to do less damage and
have a higher miss chance. Some weapons have more Swings than others.
- Heavy Attack. Always just one attack. Tends to do more damage and has a lower miss chance.
- Use Consumable. Use your equipped consumable. Takes an entire combat turn to execute.

Your character total Armor Rating will passively lower damage the higher it is. Every armor set has the
Evades stat which determines your active defences. Some armor sets have more Evades than others. Evades
determines how many enemy swings you will attempt to evade during a combat turn.

For example. Lets say the enemy uses Light Attacks with a weapon that has a Swings stat of 4 and you
have an armor set with an Evades stat of 2. If 3 of the 4 enemy swings pass their Hit Chance check, you
will attempt to evade 2 of those swings using your Evasion Chance. The third swing will hit you. If
you fail to evade, the swing goes through as usual, dealing its damage.


## 4. Takeaways

- Writing code to save lines sucks. Not only do lines end up being extremely wide but it's just plain
hard to read. Would not recommend to anyone.
- Not using classes in separate files was even worse. So much scrolling. My mouse aches.
- I got to do some neat things though. For example. Using "++variable" inside an if statement to save a line,
learning how to best render text in CLI, getting creative with the loot table, figuring out a state
system in CLI, finally getting to use my resource system in a more complete way.
- It was fun making a small scale game without worying about visuals too much. I should do this more often!


## 5. Future
Ultimately I want to port this to C++. I've been meaning to get back into it and now's the best time to do that.
However, there's a few things I want to add before I continue:

- Break it into classes. Yup. It's a nightmare right now.
- Spread out code. it's simply too compact at the moment.
- Refactoring. I'd like to clean up the code, place things into their own methods, add variables, etc.
- Inevitable bug fixes. There will be some.
- Saving your game. Yea that's a no-brainer. I'd retain the roguelike perma-death, but the game would be
save-able through a menu and auto saves will happen at points so you can at least come back if you just
need to close the window.
- Some rebalancing. I've swung wildly between too easy and too hard for a while - I wan't to reach a good balance.
- Add some kind of endgame. Right now you can level up to 100 but the game will continue forever.