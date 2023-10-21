# Giants Steps

1. About

GS is a mini roguelike dungeon crawler RPG with turn based combat. It is written in C# and played 
in a Command Line Interface (CLI).

You play as a lonely adventurer looking for fame and/or fortune. On your trip you will collect loot
with randomly generated stats and fight generated enemies while navigating randomly generated mazes. 
I made it in my spare weekends, in between being a dad, contracting and working on MoonWard.
It began as an experiment to see what's the least amount of lines I can fit a full game inside.
The orginial goal was 600 lines but it quickly grew and is now just under 1000.
I'm happy with the size but I think I need to unpack some lines.
I may have gone too far in a few places with the line saving.

2. Installation

- Rip and Tear. That's a bit dramatic. Simply copy the code in this project's Program.cs file, create a new 
C# Console Application project in Visual Studio, paste the code in your new project's Program.cs file
and start debugging. Build an executable if you like - it's up to you. The project targets net 5.0,
but I don't think that should be an issue for anyone.

3. How to play

This section was difficult to write because everything you can do is shown as a text prompt on 
the screen. Basically, GS is a command line game. Options will be presented to you on screen, you 
will then pick an option, type its index (0/1/2/3 etc.) and press Enter to execute. This should be 
enough for you to start playing. If you think you're ready, then - go, play the game!

Still here? Alright I'll elaborate a bit more.
I'll avoid the screen by screen breakdown because that shouldn't be necessary anyway. Instead I'll 
just give you a quick overview of the more obscure things. GS is a dungeon crawler which means you 
go from room to room clearing enemies or looting loot. Moving to a new room always uses 1 ration and heals
you for your Health Regeneration amount. Resting heals you for 2 times that amount and only uses 1 ration.
If you run out of rations you can't rest and you won't heal when moving between rooms. Here's a list of 
the different rooms types as shown on the map screen:

- <div>[x] -> You are here. This is the room your adventurer is currently in. It obscures the room's type
visual but you can still do actions available for this room type.</div>
- \[?] -> Unexplored. You can see unexplored rooms adjcened to your location on the map. Exploring this
room will either start a fight or reveal an empty or treasure room.
- \[_] -> Empty. Explored and empty. This room has nothing of interest.
- \[*] -> Treasure. Explored and has an item in it.
- \\_/ -> Staircase. Descends a single depth level. One way trip down. Use or collect items on your
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

4. Takeaways

5. Future


