_____/\\\\\\\\\\\\_______________________________________________________________                 
 ___/\\\//////////________________________________________________________________                
  __/\\\______________/\\\__________________________________/\\\___________________               
   _\/\\\____/\\\\\\\_\///___/\\\\\\\\\_____/\\/\\\\\\____/\\\\\\\\\\\__/\\\\\\\\\\_              
    _\/\\\___\/////\\\__/\\\_\////////\\\___\/\\\////\\\__\////\\\////__\/\\\//////__             
     _\/\\\_______\/\\\_\/\\\___/\\\\\\\\\\__\/\\\__\//\\\____\/\\\______\/\\\\\\\\\\_            
      _\/\\\_______\/\\\_\/\\\__/\\\/////\\\__\/\\\___\/\\\____\/\\\_/\\__\////////\\\_           
       _\//\\\\\\\\\\\\/__\/\\\_\//\\\\\\\\/\\_\/\\\___\/\\\____\//\\\\\____/\\\\\\\\\\_          
        __\////////////____\///___\////////\//__\///____\///______\/////____\//////////__         
         _______/\\\\\\\\\\\______________________________________________________________        
          ____/\\\/////////\\\_____________________________________________________________       
           ___\//\\\______\///______/\\\_______________________/\\\\\\\\\___________________      
            ____\////\\\__________/\\\\\\\\\\\_____/\\\\\\\\___/\\\/////\\\__/\\\\\\\\\\_____     
             _______\////\\\______\////\\\////____/\\\/////\\\_\/\\\\\\\\\\__\/\\\//////______    
              __________\////\\\______\/\\\_______/\\\\\\\\\\\__\/\\\//////___\/\\\\\\\\\\_____   
               ___/\\\______\//\\\_____\/\\\_/\\__\//\\///////___\/\\\_________\////////\\\_____  
                __\///\\\\\\\\\\\/______\//\\\\\____\//\\\\\\\\\\_\/\\\__________/\\\\\\\\\\_____ 
                 ____\///////////_________\/////______\//////////__\///__________\//////////______

1. About Giants Steps (GS)
GS is a mini roguelike RPG, written in C# and played in the Windows Command Line Interface (CLI).
You play as a lonely adventurer looking for fame and/or fortune. On your trip you will collect loot
with randomly generated stats and fight generated enemies while navigating randomly generated mazes. 
I made it in my spare weekends, in between being a dad, contracting and working on MoonWard.
It began as an experiment to see what's the least amount of lines I can fit a full game inside.
The orginial goal was 600 lines but it quickly grew and is now just under 1000.
I'm happy with the size but I think I need to unpack some lines.
I may have gone too far in some places with the line saving.

2. Installation


3. How to play
This section was difficult to write because everything you can do is shown as a text prompt on 
the screen. Basically, GS is a command line game. Options will be presented to you on screen, you 
will then pick an option, type its index (0/1/2/3 etc.) and press Enter to execute. This should be 
enough for you to start playing. If you think you're ready, then - go, play the game!

I'll avoid the screen by screen breakdown because that shouldn't be necessary anyway. Instead I'll 
just give you a quick overview of the more obscure things. GS is a dungeon crawler which means you 
go from room to room clearing enemies or looting loot. Here's a list of the different rooms types
as shown on the map screen:

- [x] -> You are here. This is the room your adventurer is currently in. It obscures the room's type
visual but you can still do actions available for this room type.
- [?] -> Unexplored. You can see unexplored rooms adjcened to your location on the map. Exploring this
room will either start a fight or reveal an empty or treasure room.
- [_] -> Empty. Explored and empty. This room has no items.
- [*] -> Treasure. Explored and has an item in it.
- \_/ -> Staircase. Descends a single depth level. One way trip down. Use or collect items on your
current level before proceding!

- Attacks. All weapons have the Attacks stat. What this does is

4. Takeaways

5. Future

