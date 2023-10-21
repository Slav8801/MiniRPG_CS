using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniRPG_CS
{
	public static class Defines
	{
		public const string INTRO_1 = @"                                                                                " + "\n" + @"                                                                                " + "\n" + @"                                                                                " + "\n" + @"                        ###(                                                    " + "\n" + @"                      /##### ,                                                  " + "\n" + @"  %%%%%#/           #%%%%%%%(#(                                    .,,         #" + "\n" + @"%%%%%%%%%#       .%%%%%&%%%%%%%/             ///,*/              ******,,,   .%%" + "\n" + @"%%%%%%%%%%%(#*#%%&&&&&&&&&&%%%%##,     /((((((((/(((/  ,,,,,,,,***///*******,%%%" + "\n" + @"&&&&&&%%%%&&&&&&&&&&&&&&&&&&%%%%###/((((((((((((((((//*//***////////////////%%%%" + "\n" + @"@@&&&&&&&&&&&&&&&&&&&&&&&&&&&&&%%%%#((((/##/(((/(((((///////(////(((((((///(%%%%" + "\n" + @"@@%&&%&&&&&&&&&&&&&&&&&&&&&&&&%&&&&%#%%%%%#%#(((//(///////(#((((((((((((/((%#&%(" + "\n" + @"%#&%@&%&&&&&&&&&&&&&&&&&&&&&&&%%%%%%%%#%%%#%%%%##((((((((((((//((/////%%%&&&&&@&" + "\n" + @"&&&&%&(##%%&&&&&&&%&%%&&%%%%%%%%%%%%%%%%#######((((((//////(##((###%##%%#%&@@&@&" + "\n" + @"&%%&#%%&#%%%%%%%%%%%%%%%%%%%%%#########((((((((((//&&&&%&&#%%%%%%%&&&%&&&&&&&&&&" + "\n" + @"&&&&%%&%#######((((######(((((((//////(((##//(#(&&@@@@@@@@@@&%%####(((((((((%##(" + "\n" + @"@&#&%&%###%/%%#(###(%((////((%#%%#(##%#((#(####&@@@@@@@@@&&%%%&&&%%#######%%%&&%" + "\n" + @"&%&&&&&&@@&#%%%%&%#((((#/(((#%%&&%%###(###%%%&@&@&&@&&@@@&@@@&&&@@&@&@%#%#&&&&%&" + "\n" + @"@@&%&&%&&&%%%%%%%%&&&#%%&(((/((((&(#((###(##%&&&@&&@@%&&@@@@@&&&&@@&&&&@&@@&&@@&" + "\n" + @"''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''" + "\n" + @"Deep in the Ustrean countryside, in a forgotten valley amongst the mountains, an" + "\n" + @"evil place exists. There, in the cliffside, an ornate stone archway welcomes the" + "\n" + @"foolish, the foolhardy and the desperate.  Legends tell of riches and of wonders" + "\n" + @"far beyond imagination. Countless have fallen to this lure of gold and fame.....";
		public const string INTRO_2 = @"                                                          .%%&&%&&&&@@@@@&@&&@&&" + "\n" + @"                                      **,                  ,(#&%&&&&@&@@@&&@@&@@" + "\n" + @"                                    .(%/(*                  /(%(%&&&&@@&&@&&&@@&" + "\n" + @"                                   ./(%%&//                 *(((#%%&&&&&&&&&@&@@" + "\n" + @"                                   */ %&%&%(,                (/%%(%#(&&&&&@@@@&&" + "\n" + @"                                   (#((##%#&%.                &%%%####&&%%&%%&&@" + "\n" + @"                                   &#(#(#%%&@&                 *#%%#%#/&&%%%&&&&" + "\n" + @"                                  /&%##/(#%% @&                 (/((/%&%&&&&&&&&" + "\n" + @"                                  &&%(*((#%% @&&&&&%,           #/#//#%%%#%#&&&%" + "\n" + @"                               &(&@&%##((#%%  @@@@@@&            ////(#%%%#&&&&&" + "\n" + @"                             *#&#&%%##%@/#%%%,@@@@@@,            */***#(#%%&&&@&" + "\n" + @"                        .*(((%#&   &@@@@@@@@, @&@@@&             (**/*(/%%%&&&&&" + "\n" + @"                    /((##            &@@@&@#  @@@               (((##%%(%#@%&&@%" + "\n" + @"                                     @&@@%&(  &%               #*(/*#%#(%&&&&%%&" + "\n" + @"                                     &&%%&%@&                 (/#//#*%#(#%&&(#&&" + "\n" + @"                                      &##*%@(                ,/*%(/%%%&%&%&@&&%&" + "\n" + @"                                      &##(&&#((###%         (//(&%&&&&&@@@%&&@&%" + "\n" + @"                                      %@@@@@@@&#(/%(##%/#(((*((((&/#/(&%&%&@@%&@" + "\n" + @"                                    (@@@@@&%&%%%%%&@**/%%&%##&%%%%#/%&&&@@@@##@#" + "\n" + @"&&&%&&&%&@&@@@@&&&&&&&&%%%%%%&%@&@@@@@&&&@&@&#%#%(/#(%&&@%%@@&@@&&&&@&@&@@@@@%&&" + "\n" + @"''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''" + "\n" + @"A lone figure aproaches the entrance cautiously. It stops and looks behind. Warm" + "\n" + @"summer sun reveals a troubled face. The figure takes a deep breath and takes one" + "\n" + @"stride down, towards the abyss. Many more lie ahead on this descent into the....";
		public const string GAME_TITLE = @"_____/\\\\\\\\\\\\_______________________________________________________________                 " + "\n" + @" ___/\\\//////////________________________________________________________________                " + "\n" + @"  __/\\\______________/\\\__________________________________/\\\___________________               " + "\n" + @"   _\/\\\____/\\\\\\\_\///___/\\\\\\\\\_____/\\/\\\\\\____/\\\\\\\\\\\__/\\\\\\\\\\_              " + "\n" + @"    _\/\\\___\/////\\\__/\\\_\////////\\\___\/\\\////\\\__\////\\\////__\/\\\//////__             " + "\n" + @"     _\/\\\_______\/\\\_\/\\\___/\\\\\\\\\\__\/\\\__\//\\\____\/\\\______\/\\\\\\\\\\_            " + "\n" + @"      _\/\\\_______\/\\\_\/\\\__/\\\/////\\\__\/\\\___\/\\\____\/\\\_/\\__\////////\\\_           " + "\n" + @"       _\//\\\\\\\\\\\\/__\/\\\_\//\\\\\\\\/\\_\/\\\___\/\\\____\//\\\\\____/\\\\\\\\\\_          " + "\n" + @"        __\////////////____\///___\////////\//__\///____\///______\/////____\//////////__         " + "\n" + @"         _______/\\\\\\\\\\\______________________________________________________________        " + "\n" + @"          ____/\\\/////////\\\_____________________________________________________________       " + "\n" + @"           ___\//\\\______\///______/\\\_______________________/\\\\\\\\\___________________      " + "\n" + @"            ____\////\\\__________/\\\\\\\\\\\_____/\\\\\\\\___/\\\/////\\\__/\\\\\\\\\\_____     " + "\n" + @"             _______\////\\\______\////\\\////____/\\\/////\\\_\/\\\\\\\\\\__\/\\\//////______    " + "\n" + @"              __________\////\\\______\/\\\_______/\\\\\\\\\\\__\/\\\//////___\/\\\\\\\\\\_____   " + "\n" + @"               ___/\\\______\//\\\_____\/\\\_/\\__\//\\///////___\/\\\_________\////////\\\_____  " + "\n" + @"                __\///\\\\\\\\\\\/______\//\\\\\____\//\\\\\\\\\\_\/\\\__________/\\\\\\\\\\_____ " + "\n" + @"                 ____\///////////_________\/////______\//////////__\///__________\//////////______";

		public const string ROOM_VOID = "   ", ROOM_PLAYER = "[x]", ROOM_SEEN = "[?]", ROOM_STAIRCASE = "\\_/", ROOM_EMPTY = "[_]", ROOM_ITEM = "[*]";
		public const int CONSUMABLE_POINTS_OFFSET = 10000, LARGE_NUMBER = 6650, COMPARISON_SHEET_WIDTH = 36, NPC_HEAL_THRESHOLD = 140;
		public const float ITEM_BONUSES_LEVEL_MOD = 0.0501f, LARGE_NUMBER_F = 6650f, LIGHT_ATTACK_DAMAGE_MOD = 0.45f, HEAVY_ATTACK_TO_HIT_MOD = 1.6f, NPC_DAMAGE_NERF = 0.6f;
		public const int DEBUG_XP_FOR_WIN = 0;
		public const RoomType DEBUG_ALL_ROOMS = RoomType.None;
		public const bool DEBUG_ALWAYS_AMBUSH = false;
		public static List<ResourceConfig> Resources => new List<ResourceConfig>
		{
			new ResourceConfig(ResourceType.None, 0f, 0f),
			new ResourceConfig(ResourceType.Health, 100f, LARGE_NUMBER_F, LARGE_NUMBER_F, 1.8f, false),
			new ResourceConfig(ResourceType.ArmorRating, 0f, LARGE_NUMBER_F, 0f, 0.2f, true),
			new ResourceConfig(ResourceType.Damage, 0f, LARGE_NUMBER_F, 0f, 0.2f, true),
			new ResourceConfig(ResourceType.Swings, 0f, 5f, 0f, 0f, true),
			new ResourceConfig(ResourceType.Evades, 0f, 5f, 0f, 0f, true),
			new ResourceConfig(ResourceType.AbilityPoints, 100f, 100f, 5f),
			new ResourceConfig(ResourceType.Experience, LARGE_NUMBER_F, LARGE_NUMBER_F),
			new ResourceConfig(ResourceType.Strength, 100f, 100f, 10f),
			new ResourceConfig(ResourceType.Dexterity, 100f, 100f, 10f),
			new ResourceConfig(ResourceType.Vitality, 100f, 100f, 10f),
			new ResourceConfig(ResourceType.CriticalDamage, 125f, 220f, 125f, 0.1f, true, true),
			new ResourceConfig(ResourceType.CriticalChance, 0f, 75f, 0f, 0.1f, true, true),
			new ResourceConfig(ResourceType.ChanceToHit, 45f, 95f, 45f, 0.1f, true, true),
			new ResourceConfig(ResourceType.ChanceToEvade, 15f, 85f, 15f, 0.1f, true, true),
			new ResourceConfig(ResourceType.Level, 100f, 100f, 1f),
			new ResourceConfig(ResourceType.Initiative, 0f, LARGE_NUMBER_F, 0f, 0.2f, true),
			new ResourceConfig(ResourceType.HealthRegeneration, 0f, 150f, LARGE_NUMBER_F, 0.2f, true),
			new ResourceConfig(ResourceType.Rations, 200f, 200f, 45f),
		};
		public static List<ResourceConfig[]> PlayerAbilityBonuses => new List<ResourceConfig[]>
		{
			new[] {new ResourceConfig(ResourceType.Damage, 1f), new ResourceConfig(ResourceType.ArmorRating, 1f), },
			new[] {new ResourceConfig(ResourceType.ChanceToHit, 1f), new ResourceConfig(ResourceType.ChanceToEvade, 1f), new ResourceConfig(ResourceType.Initiative, 1f), },
			new[] {new ResourceConfig(ResourceType.Health, 5f), new ResourceConfig(ResourceType.HealthRegeneration, 2f), },
		};
		public static List<ResourceConfig[]> NPCAbilityBonuses => new List<ResourceConfig[]>
		{
			new[] {new ResourceConfig(ResourceType.Damage, 0.3f), new ResourceConfig(ResourceType.ArmorRating, 0.75f), },
			new[] {new ResourceConfig(ResourceType.ChanceToHit, 0.7f), new ResourceConfig(ResourceType.ChanceToEvade, 0.6f), new ResourceConfig(ResourceType.Initiative, 1f), },
			new[] {new ResourceConfig(ResourceType.Health, 2f), new ResourceConfig(ResourceType.HealthRegeneration, 0f), },
		};
		public static int[] RandomItems => new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 22, 22, 23, 23, 23, 24, 24, 24, 25, 25, 26, 26 };
		public static void GetItemIndexWithName(string name, ref int itemIndex) { for (var index = 0; index < Items.Count; index++) if (name.GetHashCode() == Items[index].ItemName.GetHashCode()) itemIndex = index; }
		public static List<ItemConfig> Items => new List<ItemConfig>
		{
	/*0*/	new ItemConfig(ItemSlot.Weapon, "Dagger", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 32f), new ResourceConfig( ResourceType.Swings, 5f), new ResourceConfig( ResourceType.CriticalChance, 35f), }),
			new ItemConfig(ItemSlot.Weapon, "Baton", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 36f), new ResourceConfig( ResourceType.Swings, 5f), new ResourceConfig( ResourceType.CriticalChance, 30f), }),
	/*2*/	new ItemConfig(ItemSlot.Weapon, "Hatchet", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 40f), new ResourceConfig( ResourceType.Swings, 5f), new ResourceConfig( ResourceType.CriticalChance, 25f), }),
	/*3*/	new ItemConfig(ItemSlot.Weapon, "Sabre", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 50f), new ResourceConfig( ResourceType.Swings, 4f), new ResourceConfig( ResourceType.CriticalChance, 20f), }),
			new ItemConfig(ItemSlot.Weapon, "Flanged Mace", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 55f), new ResourceConfig( ResourceType.Swings, 3f), new ResourceConfig( ResourceType.CriticalChance, 18f), }),
	/*5*/	new ItemConfig(ItemSlot.Weapon, "Battleaxe", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 60f), new ResourceConfig( ResourceType.Swings, 3f), new ResourceConfig( ResourceType.CriticalChance, 16f), }),
	/*6*/	new ItemConfig(ItemSlot.Weapon, "Banesword", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 75f), new ResourceConfig( ResourceType.Swings, 2f), new ResourceConfig( ResourceType.CriticalChance, 16f), }),
			new ItemConfig(ItemSlot.Weapon, "Maul", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 90f), new ResourceConfig( ResourceType.Swings, 1f), new ResourceConfig( ResourceType.CriticalChance, 8f), }),
	/*8*/	new ItemConfig(ItemSlot.Weapon, "Halberd", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 80f), new ResourceConfig( ResourceType.Swings, 2f), new ResourceConfig( ResourceType.CriticalChance, 12f), }),
	/*9*/	new ItemConfig(ItemSlot.Armor, "Warling", new ResourceConfig[] { new ResourceConfig( ResourceType.ArmorRating, 45f), new ResourceConfig( ResourceType.Evades, 5f) }),
			new ItemConfig(ItemSlot.Armor, "Heavy Robes", new ResourceConfig[] { new ResourceConfig( ResourceType.ArmorRating, 60f), new ResourceConfig( ResourceType.Evades, 4f) }),
			new ItemConfig(ItemSlot.Armor, "Chainmail", new ResourceConfig[] { new ResourceConfig( ResourceType.ArmorRating, 90f), new ResourceConfig( ResourceType.Evades, 3f) }),
			new ItemConfig(ItemSlot.Armor, "Warplate", new ResourceConfig[] { new ResourceConfig( ResourceType.ArmorRating, 125f), new ResourceConfig( ResourceType.Evades, 2f) }),
	/*13*/	new ItemConfig(ItemSlot.Armor, "Truthkeeper", new ResourceConfig[] { new ResourceConfig( ResourceType.ArmorRating, 150f), new ResourceConfig( ResourceType.Evades, 1f) }),
	/*14*/	new ItemConfig(ItemSlot.Consumable, "Snakeweed Oil", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 150f) }),
			new ItemConfig(ItemSlot.Consumable, "Snakeweed Elixir", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 300f) }),
			new ItemConfig(ItemSlot.Consumable, "Energetic Crystal", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 600f) }),
			new ItemConfig(ItemSlot.Consumable, "Azure Shard", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 1000f) }),
	/*18*/	new ItemConfig(ItemSlot.Consumable, "Yellow Mushroom", new ResourceConfig[] { new ResourceConfig( ResourceType.Strength, 1f) }),
			new ItemConfig(ItemSlot.Consumable, "Blue Mushroom", new ResourceConfig[] { new ResourceConfig( ResourceType.Dexterity, 1f) }),
			new ItemConfig(ItemSlot.Consumable, "Red Mushroom", new ResourceConfig[] { new ResourceConfig( ResourceType.Vitality, 1f) }),
			new ItemConfig(ItemSlot.Consumable, "Grimoire", new ResourceConfig[] { new ResourceConfig( ResourceType.Experience, 8f) }),
	/*22*/	new ItemConfig(ItemSlot.Consumable, "Mouldy Cheese", new ResourceConfig[] { new ResourceConfig( ResourceType.Rations, 5f) }),
			new ItemConfig(ItemSlot.Consumable, "Small Rations Pack", new ResourceConfig[] { new ResourceConfig( ResourceType.Rations, 15f) }),
			new ItemConfig(ItemSlot.Consumable, "Old Rucksack", new ResourceConfig[] { new ResourceConfig( ResourceType.Rations, 25f) }),
			new ItemConfig(ItemSlot.Consumable, "Mercenary's Backpack", new ResourceConfig[] { new ResourceConfig( ResourceType.Rations, 35f) }),
	/*26*/	new ItemConfig(ItemSlot.Consumable, "Heroes' Feast", new ResourceConfig[] { new ResourceConfig( ResourceType.Rations, 50f) }),
		};
		public static List<OpponentConfig> Opponents = new List<OpponentConfig>()
		{
			new OpponentConfig("Drog", new[] {3, 10, 18}, new[] {5, 10, 0 }, ResourceType.Dexterity),
			new OpponentConfig("Ice Elemental", new[] {0, 9, 17}, new[] {0, 15, 0 }, ResourceType.Dexterity),
	/*2*/	new OpponentConfig("Devourer Narakin", new[] {2, 11, 17}, new[] {0, 15, 0 }, ResourceType.Dexterity),
			new OpponentConfig("Ca'el Conscript", new[] {4, 11, 14}, new[] {10, 3, 2 }, ResourceType.Strength),
			new OpponentConfig("Fire Elemental", new[] {3, 10, 16}, new[] {7, 5, 3 }, ResourceType.Strength),
	/*5*/	new OpponentConfig("Agressor Narakin", new[] {5, 12, 16}, new[] {12, 0, 3 }, ResourceType.Strength),
			new OpponentConfig("Earth Elemental", new[] {8, 13, 16}, new[] {7, 0, 8 }, ResourceType.Vitality),
			new OpponentConfig("Trollog", new[] {7, 12, 18}, new[] {5, 0, 10 }, ResourceType.Vitality),
			new OpponentConfig("Bloblin", new[] {5, 11, 18}, new[] {0, 5, 10 }, ResourceType.Vitality),
	/*9*/	new OpponentConfig("Obsidian Geckin", new[] {2, 13, 18}, new[] {0, 0, 15 }, ResourceType.Vitality),
		};

		public static int ExpToNextLevel(int currentLevel) => (int)MathF.Floor(currentLevel * 0.201f) + 1;
		public static string AddSpacesBeforeCapitals(string text)
		{
			if (string.IsNullOrWhiteSpace(text)) return string.Empty;
			var newText = (new System.Text.StringBuilder(text.Length * 2)).Append(text[0]);
			for (var index = 1; index < text.Length; index++) newText.Append(((char.IsUpper(text[index]) && text[index - 1] != ' ') ? " " : string.Empty) + text[index]);
			return newText.ToString();
		}
		public static string FillTextToSize(string text, int size, string fill = " ") { for (var index = text?.Length ?? 0; index < size; index++) text += fill; return text; }
		public static void Shuffle<T>(this Random rng, T[] array)
		{
			var iterator = array.Length;
			while (iterator > 1)
			{
				var randomIndex = rng.Next(iterator--);
				T temp = array[iterator];
				array[iterator] = array[randomIndex];
				array[randomIndex] = temp;
			}
		}
	}

	public enum ResourceType { None, Health, ArmorRating, Damage, Swings, Evades, AbilityPoints, Experience, Strength, Dexterity, Vitality, CriticalDamage, CriticalChance, ChanceToHit, ChanceToEvade, Level, Initiative, HealthRegeneration, Rations }
	public enum StateType { None, MainMenu, CharacterCreation, Map, CharacterSheet, Room, Fight }
	public enum ItemSlot { Weapon, Armor, Consumable }
	public enum RoomType { None, Empty, Treasure, Fight, Staircase }
	public enum RoomStatus { None, Hidden, Seen, Explored }

	public class Vec2Int
	{
		public int X, Y = 0;
		public Vec2Int(int x, int y) { X = x; Y = y; }
		public static Vec2Int operator +(Vec2Int a, Vec2Int b) => new Vec2Int(a.X + b.X, a.Y + b.Y);
	}

	public class MiniRPGStateMachine
	{
		public static State PreviousState { get; private set; }
		private State state;
		private IOUtility ioUtility = new IOUtility();

		public MiniRPGStateMachine()
		{
			Intro(Defines.INTRO_1);
			Intro(Defines.INTRO_2);
			Intro(Defines.GAME_TITLE);
			ChangeState(StateType.MainMenu);
		}

		private void Intro(string image)
		{
			Console.WriteLine($"{image}\n\n{ioUtility.Continue}");
			Console.ReadLine();
			Console.Clear();
		}

		protected void GoToState<T>(T newState) where T : State
		{
			if (state != null && state.StateTypeId != newState.StateTypeId) PreviousState = state;
			(state = newState).OnChangeState += ChangeState;
			state.Initialize(ioUtility);
		}
		private void ChangeState(StateType stateType)
		{
			var stateActions = new Action[] { null,
				() => GoToState(new MainMenuState()),
				() => GoToState(new CharacterCreationState()),
				() => GoToState(new MapState()),
				() => GoToState(new CharacterSheetState()),
				() => GoToState(new RoomState()),
				() => GoToState(new FightState()),
			};
			stateActions[(int)stateType].Invoke();
		}
	}

	public class IOUtility
	{
		public int LastInput { get; private set; }
		public string Underline => Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_");
		public string Continue => "Press Enter to continue.";

		public bool WaitForInput(int totalInputs)
		{
			var result = -1;
			var isInt = int.TryParse(Console.ReadLine(), out result);
			if (isInt && result >= 0 && result < totalInputs) LastInput = result;
			return isInt && result >= 0 && result < totalInputs;
		}
		public void ProcessValidName(ref string characterName, Action onAfterClear)
		{
			while (characterName.Length < 3 || characterName.Length > 12)
			{
				Console.Clear();
				onAfterClear?.Invoke();
				Console.WriteLine($"| Please type a name for your character.\n| It has to be between 3 and 12 characters long.\n{Underline}\n{Continue}");
				characterName = Console.ReadLine();
			}
			Console.Clear();
		}
		public void ProcessValidInput(Action onAfterClear, string[] options, Action[] actions)
		{
			onAfterClear?.Invoke();
			ShowOptions(options);
			while (!WaitForInput(actions.Length))
			{
				Console.Clear();
				onAfterClear?.Invoke();
				ShowOptions(options);
				Console.WriteLine("Oops... Unrecognised input. Try again!");
			}
			actions[LastInput].Invoke();
			Console.Clear();
		}
		public void DrawCharacterSheet()
		{
			var player = Game.Instance.Player;
			var characterLines = new List<string> {
				$"{Defines.FillTextToSize("", (int)MathF.Ceiling((Defines.COMPARISON_SHEET_WIDTH - $"Name: {player.CharacterName}".Length) * 0.5f), " ")}Name: {player.CharacterName}",
				"", "___Levels:",
				GetResourceLine(player, ResourceType.Level),
				$"{GetResourceLine(player, ResourceType.Experience)}/{Defines.ExpToNextLevel(player.Level)}",
				"", "___Abilities:",
				GetResourceLine(player, ResourceType.Strength, true, true),
				GetResourceLine(player, ResourceType.Dexterity, true, true),
				GetResourceLine(player, ResourceType.Vitality, true, true),
				GetResourceLine(player, ResourceType.AbilityPoints, true),
				"", "___Stats:",
				GetResourceLine(player, ResourceType.Health, true, true),
				GetResourceLine(player, ResourceType.HealthRegeneration, false, true),
				GetResourceLine(player, ResourceType.Initiative, false, true),
				GetResourceLine(player, ResourceType.ArmorRating, false, true),
				GetResourceLine(player, ResourceType.Evades, false, true),
				GetResourceLine(player, ResourceType.Damage, false, true),
				GetResourceLine(player, ResourceType.Swings, false, true),
				GetResourceLine(player, ResourceType.ChanceToHit, false, true),
				GetResourceLine(player, ResourceType.ChanceToEvade, false, true),
				GetResourceLine(player, ResourceType.CriticalChance, false, true),
				GetResourceLine(player, ResourceType.CriticalDamage, false, true),
			};
			var equipmentLines = new List<string>() { string.Empty, string.Empty, $"___Supplies:", $"{GetResourceLine(player, ResourceType.Rations)}" };
			foreach (var itemSlot in (ItemSlot[])Enum.GetValues(typeof(ItemSlot))) GetItemLines(ref equipmentLines, player.GetInventoryItemFromSlot(itemSlot), itemSlot);
			CombineTwoLists(characterLines, equipmentLines, Defines.COMPARISON_SHEET_WIDTH);
			Console.WriteLine($"{Underline} {Underline}\n");
		}
		public void DrawRoomItemComparison(Item roomItem, Item item)
		{
			if (roomItem == null) return;
			List<string> roomItemLines = new List<string>(), playerItemLines = new List<string>();
			GetItemLines(ref roomItemLines, roomItem, roomItem.Slot);
			if (item != null) GetItemLines(ref playerItemLines, item, item.Slot);
			Console.WriteLine($"{Defines.FillTextToSize("| Player Item", Defines.COMPARISON_SHEET_WIDTH, " ")} | Room Item");
			CombineTwoLists(playerItemLines, roomItemLines, Defines.COMPARISON_SHEET_WIDTH);
			Console.WriteLine($"{Underline} {Underline}\n");
		}
		public void DrawLeveledUpText() => Console.WriteLine($"| {Game.Instance.Player.CharacterName} has leveled up to level {Game.Instance.Level}.\n| They have {Game.Instance.Player.Resource(ResourceType.AbilityPoints).Current} unused ability points!\n{Underline}\n");
		public string GetResourceLine(Actor actor, ResourceType resourceType, bool willShowCurrent = true, bool willShowMax = false)
		{
			var current = willShowCurrent ? (actor.Resource((int)resourceType).Current).ToString("F0") : string.Empty;
			var max = willShowMax ? actor.Resource((int)resourceType).Max.ToString("F0") : string.Empty;
			return $" {GetResourceName(resourceType)}: {current}{(willShowCurrent && willShowMax ? "/" : string.Empty)}{max}{GetPercentageString(resourceType)}";
		}
		public string GetItemLine(Item item, ResourceType resourceType) => $"{GetResourceName(resourceType)}: +{(int)item.Resource(resourceType).Max}{GetPercentageString(resourceType)}";
		public string GetAbilityBonusLine(int abilityIndex, int bonsuIndex, List<ResourceConfig[]> resourceConfigs)
		{
			var resource = resourceConfigs[abilityIndex][bonsuIndex];
			return $"| +{(int)resource.Max}{GetPercentageString(resource.ResourceType)} {GetResourceName(resource.ResourceType)}";
		}

		private void CombineTwoLists(List<string> list1, List<string> list2, int text1Width)
		{
			for (var index = 0; index < (int)MathF.Max(list1.Count, list2.Count); index++) DrawSheetLine(GetLine(list1, index), GetLine(list2, index), "|", text1Width);
			string GetLine(List<string> list, int lineIndex) => list.Count > lineIndex ? list[lineIndex] : string.Empty;
		}
		private void DrawSheetLine(string text1, string text2, string separator, int text1Width) => Console.WriteLine($"|{Defines.FillTextToSize(text1, text1Width)}{separator}{text2}");
		private void ShowOptions(string[] options) { for (var index = 0; index < options.Length; index++) Console.WriteLine($"| {index}. {options[index]}{(index >= (options.Length - 1) ? $"\n{Underline}\nType your option's index and press Enter:" : string.Empty)}"); }
		private void GetItemLines(ref List<string> equipmentLines, Item item, ItemSlot itemSlot)
		{
			equipmentLines.AddRange(new[] { string.Empty, $"___{itemSlot}: {(item == null ? "None Equipped" : item.ItemName)}" });
			if (item == null) return;
			if (item.ItemConfig.Slot == ItemSlot.Weapon) equipmentLines.AddRange(new[] { $" {GetItemLine(item, ResourceType.Damage)}", $" {GetItemLine(item, ResourceType.Swings)}", $" {GetItemLine(item, ResourceType.CriticalChance)}" });
			if (item.ItemConfig.Slot == ItemSlot.Armor) equipmentLines.AddRange(new[] { $" {GetItemLine(item, ResourceType.ArmorRating)}", $" {GetItemLine(item, ResourceType.Evades)}" });
			if (item.ItemConfig.Slot == ItemSlot.Consumable) equipmentLines.Add($" Effect: +{item.GetConsumableResource().Max} {item.GetConsumableResource().ResourceType}");
			else
			{
				if (item.GetResourcesWithBonuses().Length > 0) equipmentLines.Add("___Bonuses:");
				foreach (var resource in item.GetResourcesWithBonuses()) equipmentLines.Add($"> {GetItemLine(item, resource.ResourceType)}");
			}
		}
		private string GetResourceName(ResourceType resourceType) => Defines.AddSpacesBeforeCapitals(resourceType.ToString());
		private string GetPercentageString(ResourceType resourceType) => Defines.Resources[(int)resourceType].IsPercentage ? "%" : string.Empty;
	}

	public class Game
	{
		private Game() { }
		private static Game instance;
		public static Game Instance => instance ?? (instance = new Game());

		public Map Map;
		public Actor Player, Opponent;
		public int Level => Player?.Level ?? (int)Defines.Resources[(int)ResourceType.Level].Starting;
		public Room PlayerRoom => Map.GetRoom(Map.PlayerPosition);
	}

	public abstract class State
	{
		public Action<StateType> OnChangeState;
		public abstract StateType StateTypeId { get; }

		protected IOUtility IOUtility;
		protected abstract string[] BaseOptions { get; }
		protected abstract Action[] BaseActions { get; }

		public void Initialize(IOUtility ioUtility)
		{
			IOUtility = ioUtility;
			StateMain();
		}

		protected abstract void StateMain();
		protected void ShowStateName() { Console.Clear(); Console.WriteLine($">----<{Defines.AddSpacesBeforeCapitals(StateTypeId.ToString())}>\n\n"); }
		protected void ShowTextAndReset(string[] texts, StateType stateType = StateType.None, Action onStateShown = null)
		{
			ShowStateName(); onStateShown?.Invoke();
			foreach (var text in texts) Console.WriteLine($"| {text}");
			Console.WriteLine($"{IOUtility.Underline}\n{IOUtility.Continue}"); Console.ReadLine();
			OnChangeState?.Invoke(stateType == StateType.None ? StateTypeId : stateType);
		}
	}

	public class MainMenuState : State
	{
		public override StateType StateTypeId => StateType.MainMenu;
		protected override string[] BaseOptions => new string[] { "New Game", "Quit" };
		protected override Action[] BaseActions => new Action[] { () => OnChangeState?.Invoke(StateType.CharacterCreation), () => Environment.Exit(0) };

		protected override void StateMain()
		{
			Game.Instance.Map = null;
			Game.Instance.Player = Game.Instance.Opponent = null;
			IOUtility.ProcessValidInput(ShowStateName, BaseOptions, BaseActions);
		}
	}

	public class CharacterCreationState : State
	{
		public override StateType StateTypeId => StateType.CharacterCreation;
		protected override string[] BaseOptions => new string[] { "Confirm", "Recreate", "Back" };
		protected override Action[] BaseActions => new Action[] { () => OnChangeState?.Invoke(StateType.Map), () => OnChangeState?.Invoke(StateType.Map), () => OnChangeState?.Invoke(StateType.MainMenu) };
		private string characterName = string.Empty;

		protected override void StateMain()
		{
			IOUtility.ProcessValidName(ref characterName, ShowStateName);
			Game.Instance.Player = new Player(characterName);
			IOUtility.ProcessValidInput(() =>
			{
				ShowStateName();
				Console.WriteLine($"| Create character named: {characterName}?\n{IOUtility.Underline}\n");
			}, BaseOptions, BaseActions);
		}
	}

	public class MapState : State
	{
		public override StateType StateTypeId => StateType.Map;
		protected override string[] BaseOptions => new string[]
		{
			"Explore Current Room",
			"Move North", "Move South", "Move West", "Move East",
			"Character Sheet",
			$"Rest (+{Game.Instance.Player.Resource(ResourceType.HealthRegeneration).Max * 2f} {ResourceType.Health})",
			"Quit" };
		protected override Action[] BaseActions => new Action[]
		{
			() => OnChangeState?.Invoke(StateType.Room),
			() => MovePlayer(new Vec2Int(0, 1)), () => MovePlayer(new Vec2Int(0, -1)),
			() => MovePlayer(new Vec2Int(-1, 0)), () => MovePlayer(new Vec2Int(1, 0)),
			() => OnChangeState?.Invoke(StateType.CharacterSheet),
			Rest,
			() => OnChangeState?.Invoke(StateType.MainMenu)
		};

		protected override void StateMain()
		{
			var map = Game.Instance.Map;
			if (map == null || (map != null && Game.Instance.PlayerRoom.RoomType == RoomType.Staircase)) Game.Instance.Map = new Map(Game.Instance.Level + 20);
			IOUtility.ProcessValidInput(() =>
			{
				ShowStateName();
				Game.Instance.Map.DrawMap();
				if (Game.Instance.Player.HasJustLeveledUp) IOUtility.DrawLeveledUpText();
				var name = Game.Instance.Player.CharacterName;
				var leftSideSpace = Defines.FillTextToSize(string.Empty, (int)MathF.Ceiling((Defines.COMPARISON_SHEET_WIDTH - $"Name: {name}".Length) * 0.5f), " ");
				var healthCurrent = IOUtility.GetResourceLine(Game.Instance.Player, ResourceType.Health, true, true);
				var rationsCurrent = IOUtility.GetResourceLine(Game.Instance.Player, ResourceType.Rations);
				Console.WriteLine($"|{leftSideSpace}Name: {name}\n|Depth Level: {((Player)Game.Instance.Player).Depth}\n|Level: {Game.Instance.Level}\n|{healthCurrent}\n|{rationsCurrent}\n{IOUtility.Underline}\n");
			}, BaseOptions, BaseActions);
		}

		private void MovePlayer(Vec2Int direction)
		{
			UseRations();
			if (Game.Instance.Map.MovePlayer(direction)) OnChangeState?.Invoke(StateType.Room);
			ShowTextAndReset(new[] { "Can't go that way!" });
		}
		private void Rest()
		{
			if (!UseRations(2f)) ShowTextAndReset(new[] { $"Not enough {ResourceType.Rations} to rest!" });
			ShowTextAndReset(new[] { "You find a safe spot and take a nap.", "You feel much better when you wake up!" });
		}
		private bool UseRations(float healMod = 1f)
		{
			if (Game.Instance.Player.Resource(ResourceType.Rations).Current <= 0) return false;
			else Game.Instance.Player.Resource(ResourceType.Rations).AddCurrent(-1f);
			Game.Instance.Player.Resource(ResourceType.Health).AddCurrent((int)MathF.Ceiling(Game.Instance.Player.Resource(ResourceType.HealthRegeneration).Max * healMod));
			return true;
		}
	}

	public class CharacterSheetState : State
	{
		public override StateType StateTypeId => StateType.CharacterSheet;
		protected override string[] BaseOptions => new string[] { "Use Consumable", $"{ResourceType.Strength} +1", $"{ResourceType.Dexterity} +1", $"{ResourceType.Vitality} +1", "Back" };
		protected override Action[] BaseActions => new Action[]
		{
			UseConsumable,
			() => AddAbility(ResourceType.Strength),
			() => AddAbility(ResourceType.Dexterity),
			() => AddAbility(ResourceType.Vitality),
			() => OnChangeState?.Invoke(MiniRPGStateMachine.PreviousState.StateTypeId)
		};

		protected override void StateMain()
		{
			Game.Instance.Player.ResetLeveledUpFlag();
			IOUtility.ProcessValidInput(() =>
			{
				ShowStateName();
				IOUtility.DrawCharacterSheet();
			}, BaseOptions, BaseActions);
		}

		private void AddAbility(ResourceType resourceType)
		{
			ShowStateName();
			var player = Game.Instance.Player;
			if (player.Resource(ResourceType.AbilityPoints).Current <= 0) ShowTextAndReset(new[] { "No available ability points!" });
			if (player.Resource(resourceType).Current >= player.Resource(resourceType).Max) ShowTextAndReset(new[] { $"{resourceType} already at max!" });
			var abilityText = $"| {resourceType} bonuses per point:\n";
			var abilityIndex = (int)resourceType - (int)ResourceType.Strength;
			var bonuses = Defines.PlayerAbilityBonuses;
			for (var index = 0; index < Defines.PlayerAbilityBonuses[abilityIndex].Length; index++) abilityText += $"{IOUtility.GetAbilityBonusLine(abilityIndex, index, bonuses)} {(bonuses[abilityIndex].Length - 1 > index ? "\n" : string.Empty)}";
			Console.WriteLine($"{abilityText}\n{IOUtility.Underline}\nType '0' to confirm. Type '1' to cancel.\n");
			var input = Console.ReadLine();
			while (input != "0" && input != "1") { Console.Clear(); Console.WriteLine(abilityText + (input = Console.ReadLine())); }
			if (input == "1") OnChangeState?.Invoke(StateTypeId);
			player.AddAbilityBonuses(bonuses, resourceType);
			player.Resource(ResourceType.AbilityPoints).AddCurrent(-1);
			OnChangeState?.Invoke(StateTypeId);
		}
		private void UseConsumable()
		{
			if (!Game.Instance.Player.UseConsumable()) OnChangeState?.Invoke(StateTypeId);
			var item = Game.Instance.Player.GetInventoryItemFromSlot(ItemSlot.Consumable);
			Game.Instance.Player.RemoveInventoryItem(ItemSlot.Consumable);
			var itemResource = item.GetConsumableResource();
			ShowTextAndReset(new[] { $"Used {item.ItemName} to {(itemResource.Max > float.Epsilon ? "increase" : "damage")} {itemResource.ResourceType} by {itemResource.Max}." });
		}
	}

	public class RoomState : State
	{
		public override StateType StateTypeId => StateType.Room;
		protected override string[] BaseOptions => new string[] { $"Swap Item ({(Game.Instance.PlayerRoom.Item == null ? "None" : Game.Instance.PlayerRoom.Item.ItemName)})", "Character Sheet", "Back to Map" };
		protected override Action[] BaseActions => new Action[] { SwapItem, () => OnChangeState?.Invoke(StateType.CharacterSheet), () => OnChangeState?.Invoke(StateType.Map) };

		protected override void StateMain()
		{
			if (Game.Instance.PlayerRoom.RoomType == RoomType.Staircase)
			{
				ShowTextAndReset(new[] {
					"You stumble into a room with a dusty staircase going down into the darkness.",
					"All of a sudden, a strange whim compels you to begin climbing down.",
					"As soon as you touch the final step, the staircase crumbles behind you.",
					"You are now stranded on this level of the dungeon.",
					"With no other options and no way back, you press on." }, StateType.Map);
			}
			if (Game.Instance.PlayerRoom.RoomType == RoomType.Fight && Game.Instance.PlayerRoom.RoomStatus != RoomStatus.Explored) OnChangeState?.Invoke(StateType.Fight);
			Game.Instance.PlayerRoom.UpdateStatus(RoomStatus.Explored);
			Game.Instance.Opponent = null;
			IOUtility.ProcessValidInput(() =>
			{
				ShowStateName();
				if (Game.Instance.PlayerRoom.Item == null) Console.WriteLine($"| This room has no item.\n{IOUtility.Underline}\n");
				else IOUtility.DrawRoomItemComparison(Game.Instance.PlayerRoom.Item, Game.Instance.Player.GetInventoryItemFromSlot(Game.Instance.PlayerRoom.Item.ItemConfig.Slot));
				if (Game.Instance.Player.HasJustLeveledUp) IOUtility.DrawLeveledUpText();
			}, BaseOptions, BaseActions);
		}

		private void SwapItem()
		{
			if (Game.Instance.PlayerRoom.Item == null) ShowTextAndReset(new[] { "This room has no item." });
			var roomItem = Game.Instance.PlayerRoom.Item;
			var playerItem = Game.Instance.Player.GetInventoryItemFromSlot(roomItem.Slot);
			Game.Instance.Player.RemoveInventoryItem(roomItem.Slot);
			Game.Instance.Player.SetInventoryItemInSlot(roomItem);
			Game.Instance.PlayerRoom.ReplaceItem(playerItem);
			ShowTextAndReset(new[] { $"{(playerItem != null ? $"{playerItem.ItemName}" : "Nothing")} dropped.", $"{roomItem.ItemName} equipped." });
		}
	}

	public class FightState : State
	{
		public override StateType StateTypeId => StateType.Fight;
		protected override string[] BaseOptions => new string[] {
			GetAttackString("Light Attacks ", actors[playerIndex], (int)actors[playerIndex].Resource(ResourceType.Swings).Max, Defines.LIGHT_ATTACK_DAMAGE_MOD, 1f),
			GetAttackString("Heavy Attack ", actors[playerIndex], 1, 1f, Defines.HEAVY_ATTACK_TO_HIT_MOD),
			$"Use Consumable ({(actors[playerIndex].GetInventoryItemFromSlot(ItemSlot.Consumable) == null ? "None" : actors[playerIndex].GetInventoryItemFromSlot(ItemSlot.Consumable).ItemName)})",
			/*"Debug: Win!","Debug: Lose!", */ };
		protected override Action[] BaseActions => new Action[] { () => LightAttack(actors[playerIndex], actors[opponentIndex]), () => HeavyAttack(actors[playerIndex], actors[opponentIndex]), () => UseConsumable(actors[playerIndex], actors[opponentIndex]), /*() => Won(), Lost*/ };

		private List<int>[] attackLists = new[] { new List<int>(), new List<int>() };
		private bool[][] criticals = new bool[][] { new bool[5], new bool[5] };
		private Actor[] actors;
		private int playerIndex = 0, opponentIndex = 1;
		private int turns;

		protected override void StateMain()
		{
			actors = new Actor[] { Game.Instance.Player, (Game.Instance.Opponent = GetRandomOpponent()) };
			DrawCombat(true);
		}

		private void DrawCombat(bool isFirstTurn = false)
		{
			IOUtility.ProcessValidInput(() =>
			{
				ShowStateName();
				if (isFirstTurn && IsAmbush()) AI();
				if (turns > 0 && (turns = 0) < Defines.LARGE_NUMBER)
				{
					if (IsActorDead(actors[playerIndex])) Lost();
					if (IsActorDead(actors[opponentIndex])) Won();
				}
				DrawTurns();
			}, BaseOptions, BaseActions);
		}
		private void DrawTurns()
		{
			for (var actorIndex = 0; actorIndex < actors.Length; actorIndex++)
			{
				var actorAttacks = attackLists[actorIndex];
				if (actorIndex > playerIndex && attackLists[playerIndex].Count == 0) Console.WriteLine($"| A sneaky {actors[opponentIndex].CharacterName} ambushed you!\n|");
				Console.WriteLine($"{Defines.FillTextToSize("|", (int)MathF.Round((Defines.COMPARISON_SHEET_WIDTH - actors[actorIndex].CharacterName.Length) * 0.5f), " ")}{actors[actorIndex].CharacterName}\n|{IOUtility.GetResourceLine(actors[actorIndex], ResourceType.Health, true, true)}");
				if (actorAttacks.Count != 0)
				{
					for (var index = 0; index < actorAttacks.Count; index++)
					{
						if (actorAttacks[index] > Defines.CONSUMABLE_POINTS_OFFSET)
						{
							var itemResource = Defines.Items[actorAttacks[index] - Defines.CONSUMABLE_POINTS_OFFSET].ResourceConfigs.FirstOrDefault(x => x.Max > 0f);
							Console.WriteLine($"|>Used {Defines.Items[actorAttacks[index] - Defines.CONSUMABLE_POINTS_OFFSET].ItemName} to {(itemResource.Max > float.Epsilon ? "increase" : "damage")} {itemResource.ResourceType} by {itemResource.Max}.");
						}
						else Console.WriteLine($"|>Used {(actorAttacks.Count > 1 ? "Light" : "Heavy")} Attack. It {(actorAttacks[index] < 0 ? "was evaded" : (actorAttacks[index] == 0 ? "missed" : $"hit dealing {actorAttacks[index]} {(criticals[actorIndex][index] ? "critical " : string.Empty)}damage"))}.");
					}
				}
				Console.WriteLine($"{IOUtility.Underline}\n");
			}
		}
		private void AI()
		{
			turns++;
			var actor = actors[opponentIndex];
			var chance = new Random().Next(0, 100);
			var health = actors[opponentIndex].Resource(ResourceType.Health);
			if (chance + (int)((1f - (health.Current / (float)health.Max)) * 100f) > Defines.NPC_HEAL_THRESHOLD)
			{
				var consumable = actor.GetInventoryItemFromSlot(ItemSlot.Consumable);
				if (consumable != null && (consumable.GetConsumableResource().ResourceType == ResourceType.Health)) UseConsumable(actor, actors[playerIndex]);
			}
			var lightChance = chance + (int)actor.Resource(ResourceType.Dexterity).Current;
			var heavyChance = (100 - chance) + (int)actor.Resource(ResourceType.Strength).Current;
			if (lightChance > heavyChance) LightAttack(actor, actors[playerIndex], Defines.NPC_DAMAGE_NERF);
			else HeavyAttack(actor, actors[playerIndex], Defines.NPC_DAMAGE_NERF);
		}
		private void LightAttack(Actor attacker, Actor defender, float damageMod = 1f) => Attack(attacker, defender, (int)attacker.Resource(ResourceType.Swings).Max, Defines.LIGHT_ATTACK_DAMAGE_MOD * damageMod);
		private void HeavyAttack(Actor attacker, Actor defender, float damageMod = 1f) => Attack(attacker, defender, 1, 1f * damageMod, Defines.HEAVY_ATTACK_TO_HIT_MOD);
		private void Attack(Actor attacker, Actor defender, int attacks, float damagePercentage, float toHitMod = 1f)
		{
			criticals[turns] = new bool[5];
			attackLists[turns] = new List<int>();
			if (IsActorDead(attacker) || IsActorDead(defender)) DrawCombat();
			attackLists[turns] = GetPotentialHits(attacker, attacks, damagePercentage, toHitMod);
			EvaluateEvasions(defender, ref attackLists[turns]);
			EvaluateDefence(defender, ref attackLists[turns]);
			foreach (var attack in attackLists[turns]) if (attack > 0) defender.Resource(ResourceType.Health).AddCurrent(-MathF.Abs(attack));
			if (turns > 0) DrawCombat();
			else AI();
		}
		private void UseConsumable(Actor attacker, Actor defender)
		{
			if (attacker is Player && attacker.GetInventoryItemFromSlot(ItemSlot.Consumable) == null) DrawCombat();
			if (IsActorDead(attacker) || IsActorDead(defender)) DrawCombat();
			attackLists[turns] = new List<int>();
			var itemIndex = 0; Defines.GetItemIndexWithName(attacker.GetInventoryItemFromSlot(ItemSlot.Consumable).ItemName, ref itemIndex);
			attackLists[turns].Add(10000 + itemIndex);
			if (attacker.UseConsumable()) attacker.RemoveInventoryItem(ItemSlot.Consumable);
			if (turns > 0) DrawCombat();
			else AI();
		}
		private List<int> GetPotentialHits(Actor attacker, int amount, float damagePercentage, float toHitMod = 1f)
		{
			var result = new List<int>();
			for (var index = 0; index < amount; index++)
			{
				var critMod = GetCritMultiplier(attacker);
				criticals[turns][index] = critMod > 1f;
				result.Add(WillPotentiallyHit(attacker, toHitMod) ? (int)MathF.Round((attacker.Resource(ResourceType.Damage).Max * damagePercentage * critMod)) : 0);
			}
			return result;
		}
		private void EvaluateEvasions(Actor defender, ref List<int> potentialHits)
		{
			var totalEvasions = defender.Resource(ResourceType.Evades).Max;
			for (var index = 0; index < potentialHits.Count; index++)
			{
				if (potentialHits[index] <= 0 || totalEvasions <= 0) continue;
				totalEvasions--;
				if (WillEvade(defender)) potentialHits[index] = -1;
			}
		}
		private void EvaluateDefence(Actor defender, ref List<int> potentialHits)
		{
			var armorRating = 1f - MathF.Min(defender.Resource(ResourceType.ArmorRating).Max < float.Epsilon ? 0f : defender.Resource(ResourceType.ArmorRating).Max / 300f, 0.95f);
			for (var index = 0; index < potentialHits.Count; index++) if (potentialHits[index] > 0) potentialHits[index] = (int)MathF.Max(1f, MathF.Round(armorRating * potentialHits[index]));
		}
		private bool WillPotentiallyHit(Actor attacker, float toHitMod = 1f) => (new Random().NextDouble() * 100f) < MathF.Min(95f, MathF.Round(attacker.Resource(ResourceType.ChanceToHit).Max * toHitMod));
		private bool WillCrit(Actor attacker) => (new Random().NextDouble() * 100f) < attacker.Resource(ResourceType.CriticalChance).Max;
		private float GetCritMultiplier(Actor attacker) => (WillCrit(attacker) ? (attacker.Resource(ResourceType.CriticalDamage).Max * 0.01f) : 1f);
		private bool WillEvade(Actor defender) => (new Random().NextDouble() * 100f) < defender.Resource(ResourceType.ChanceToEvade).Max;
		private Opponent GetRandomOpponent() => new Opponent(Defines.Opponents[new Random().Next(0, Defines.Opponents.Count)]);
		private bool IsAmbush() => Defines.DEBUG_ALWAYS_AMBUSH || actors[playerIndex].Resource(ResourceType.Initiative).Max < actors[opponentIndex].Resource(ResourceType.Initiative).Max;
		private bool IsActorDead(Actor actor) => actor.Resource(ResourceType.Health).Current < float.Epsilon;
		private void Won(int experience = 1)
		{
			actors[playerIndex].GiveExperience(Defines.DEBUG_XP_FOR_WIN != 0 ? experience = Defines.DEBUG_XP_FOR_WIN : experience);
			Game.Instance.PlayerRoom.UpdateStatus(RoomStatus.Explored);
			ShowTextAndReset(new[] { $"{actors[playerIndex].CharacterName} was victorious!", $"They gained {experience} expirence point{(experience <= 1 ? string.Empty : "s")}!" }, StateType.Room, DrawTurns);
		}
		private void Lost()
		{
			ShowTextAndReset(new[] {
				$"{actors[playerIndex].CharacterName} was slain by a vicious {Defines.AddSpacesBeforeCapitals(actors[opponentIndex].CharacterName)}!",
				$"They achieved level {actors[playerIndex].Level} before perishing.",
				$"How tragic!" }, StateType.MainMenu, DrawTurns);
		}
		private string GetAttackString(string moveName, Actor actor, int times, float damagePercentage, float toHitMod) => $"{moveName}({toHitMod * actor.Resource(ResourceType.ChanceToHit).Max}% to hit, {times}x{(int)MathF.Round(actor.Resource(ResourceType.Damage).Max * damagePercentage)} damage)";
	}

	public class ItemConfig
	{
		public string ItemName { get; private set; }
		public ItemSlot Slot { get; private set; }
		public List<ResourceConfig> ResourceConfigs { get; private set; } = new List<ResourceConfig>();
		public ItemConfig(ItemSlot slot, string itemName, ResourceConfig[] presetValues = null)
		{
			Slot = slot;
			ItemName = itemName;
			for (var index = 0; index < Defines.Resources.Count; index++)
			{
				ResourceConfigs.Add(new ResourceConfig(Defines.Resources[index].ResourceType, 0f, Defines.Resources[index].Cap, 0f));
				ResourceConfigs[index].AddMax(presetValues?.FirstOrDefault(x => x.ResourceType == ResourceConfigs[index].ResourceType));
			}
		}
	}

	public class Item
	{
		public string ItemName => $"{ItemConfig.ItemName}{(GetResourcesWithBonuses().Length > 0 ? $" +{GetResourcesWithBonuses().Length}" : string.Empty)}";
		public ItemSlot Slot => ItemConfig.Slot;
		public int ItemHashId => ItemName.GetHashCode();
		public ItemConfig ItemConfig { get; private set; }

		private List<Resource> resources = new List<Resource>();

		public Item(ItemConfig itemConfig, bool isForPlayer = false)
		{
			if ((ItemConfig = itemConfig) == null) ItemConfig = Defines.Items[Defines.RandomItems[new Random().Next(0, Defines.Items.Count)]];
			for (var index = 0; index < Defines.Resources.Count; index++) resources.Add(new Resource(ItemConfig.ResourceConfigs[index]));
			if (!isForPlayer || ItemConfig.Slot == ItemSlot.Consumable) return;
			for (var index = 0; index < (int)MathF.Floor(Game.Instance.Level * Defines.ITEM_BONUSES_LEVEL_MOD); index++)
			{
				var resource = resources[new Random().Next(1, resources.Count)];
				var bonusAmount = MathF.Floor(Game.Instance.Level * Defines.Resources[(int)resource.ResourceType].BonusMod);
				if (resource.Max < float.Epsilon && bonusAmount > float.Epsilon) resource.UpdateMaxBonus(ItemHashId, bonusAmount);
			}
		}
		public Resource Resource(ResourceType resourceType) => Resource((int)resourceType);
		public Resource Resource(int index) => resources[index];
		public bool Use(Actor actor)
		{
			var resource = GetConsumableResource();
			var resourceType = resource.ResourceType;
			if (resourceType == ResourceType.Experience) actor.GiveExperience((int)resource.Max);
			else if ((int)resourceType > (int)ResourceType.Experience && (int)resourceType < (int)ResourceType.CriticalDamage) actor.AddAbilityBonuses((actor is Player ? Defines.PlayerAbilityBonuses : Defines.NPCAbilityBonuses), resourceType, true, (int)resource.Max);
			else actor.Resource((int)resourceType).AddCurrent(resource.Max);
			return true;
		}
		public Resource GetConsumableResource() => ItemConfig.Slot == ItemSlot.Consumable ? resources.FirstOrDefault(x => x.Max > float.Epsilon) : null;
		public Resource[] GetResourcesWithBonuses() => resources.Where(x => x.HasBonuses)?.ToArray() ?? new Resource[0];
	}

	public abstract class Actor
	{
		public bool HasJustLeveledUp { get; private set; } = false;
		public string CharacterName { get; private set; }
		public int Level => (int)Resource(ResourceType.Level).Current;

		private List<Resource> resources = new List<Resource>();
		private Item[] inventory;

		public Actor(string name)
		{
			inventory = new Item[Enum.GetValues(typeof(ItemSlot)).Length];
			CharacterName = name;
			for (var index = 0; index < Defines.Resources.Count; index++) resources.Add(new Resource(Defines.Resources[index]));
		}
		public void AddAbilityBonuses(List<ResourceConfig[]> resourceConfigs, ResourceType ability, bool willAddPoint = true, int amount = 1)
		{
			if (willAddPoint) Resource((int)ability).AddCurrent(amount);
			foreach (var bonus in resourceConfigs[(int)ability - (int)ResourceType.Strength]) Resource((int)bonus.ResourceType).UpdateMaxBonus(CharacterName.GetHashCode(), Resource((int)ability).Current * bonus.Max);
			if (ability == ResourceType.Vitality && amount > 0f) Resource(ResourceType.Health).AddCurrent(Defines.LARGE_NUMBER_F);
		}
		public Resource Resource(ResourceType resourceType) => Resource((int)resourceType);
		public Resource Resource(int index) => resources[index];
		public void SetInventoryItemInSlot(Item item) => CanUpdateResources(inventory[(int)item.Slot] = item, (int)item.Slot);
		public Item GetInventoryItemFromSlot(ItemSlot itemSlot) => inventory[(int)itemSlot];
		public bool UseConsumable() => (inventory[(int)ItemSlot.Consumable]?.Use(this)).HasValue;
		public void RemoveInventoryItem(ItemSlot itemSlot)
		{
			if (inventory[(int)itemSlot] != null) UpdateResourcesWithItem(inventory[(int)itemSlot], true);
			inventory[(int)itemSlot] = null;
		}

		public void GiveExperience(int amount)
		{
			if (Resource(ResourceType.Level).IsAtMax) { Resource(ResourceType.Experience).AddCurrent(-666f); return; }
			while (amount > 0)
			{
				var exp = Resource(ResourceType.Experience);
				var xpToLevelUp = Defines.ExpToNextLevel(Level) - exp.Current;
				exp.AddCurrent(amount > xpToLevelUp ? xpToLevelUp : (float)amount);
				amount -= amount > xpToLevelUp ? (int)MathF.Round(xpToLevelUp) : amount;
				if ((int)exp.Current == Defines.ExpToNextLevel(Level) && !HasLeveledUp()) return;
			}
		}
		public void ResetLeveledUpFlag() => HasJustLeveledUp = false;
		public void AddItems(int[] startingItems) { for (var index = 0; index < startingItems.Length; index++) SetInventoryItemInSlot(new Item(Defines.Items[startingItems[index]], true)); }
		public void AddAbilities(List<ResourceConfig[]> resourceConfigs) { for (var index = (int)ResourceType.Strength; index < (int)ResourceType.Strength + 3; index++) AddAbilityBonuses(resourceConfigs, (ResourceType)index); }

		private bool HasLeveledUp()
		{
			if (Resource(ResourceType.Level).IsAtMax) return false;
			HasJustLeveledUp = true;
			Resource(ResourceType.Level).AddCurrent(1);
			Resource(ResourceType.AbilityPoints).AddCurrent(1);
			Resource(ResourceType.Experience).AddCurrent(-666f);
			return true;
		}
		private void CanUpdateResources(Item item, int slot) { if (slot != (int)ItemSlot.Consumable) UpdateResourcesWithItem(inventory[slot] = item); }
		private void UpdateResourcesWithItem(Item item, bool willRemove = false) { for (var index = 0; index < resources.Count; index++) Resource(index).UpdateMaxBonus(item.ItemHashId, item.Resource(index).Max, willRemove); }
	}

	public class Player : Actor
	{
		public int Depth { get; private set; } = 0;
		private int[] startingItems = new[] { 3, 9, 14 };
		public Player(string name) : base(name)
		{
			AddItems(startingItems);
			AddAbilities(Defines.PlayerAbilityBonuses);
		}
		public void IncreaseDepth() => Depth++;
	}

	public class OpponentConfig
	{
		public string CharacterName { get; private set; }
		public int[] StartingItemsIndices { get; private set; }
		public int[] StartingAbilities { get; private set; }
		public ResourceType MainAbility { get; private set; }
		public OpponentConfig(string name, int[] startingItemsIndices, int[] startingAbilities, ResourceType mainAbility)
		{
			CharacterName = name;
			StartingItemsIndices = startingItemsIndices;
			StartingAbilities = startingAbilities;
			MainAbility = mainAbility;
		}
	}

	public class Opponent : Actor
	{
		private ResourceType mainAbility;
		public Opponent(OpponentConfig opponentConfig) : base(opponentConfig.CharacterName)
		{
			mainAbility = opponentConfig.MainAbility;
			AddItems(opponentConfig.StartingItemsIndices);
			for (var index = (int)ResourceType.Strength; index < (int)ResourceType.Strength + 3; index++) Resource(index).AddCurrent(opponentConfig.StartingAbilities[index - (int)ResourceType.Strength]);
			NPCLevelUp(Game.Instance.Level);
			AddAbilities(Defines.NPCAbilityBonuses);
			Resource(ResourceType.Health).AddCurrent(Defines.LARGE_NUMBER);
		}

		private void NPCLevelUp(int targetLevel)
		{
			for (var index = 0; index < targetLevel; index++)
				for (var ability = (int)ResourceType.Strength; ability < (int)ResourceType.Strength + 3; ability++) Resource(ability).AddCurrent(ability == (int)mainAbility || (index % 2 == 1 && ability != (int)mainAbility) ? 1 : 0);
		}
	}

	public class ResourceConfig
	{
		public ResourceType ResourceType { get; private set; }
		public float Cap { get; private set; } = Defines.LARGE_NUMBER_F;
		public float Max { get; private set; }
		public float Starting { get; private set; }
		public float BonusMod { get; private set; }
		public bool WillSetToMaxOnUpdate { get; private set; }
		public bool IsPercentage { get; private set; }

		public ResourceConfig(ResourceType resourceType, float max, float cap = Defines.LARGE_NUMBER_F, float starting = 0f, float bonusMod = 0f, bool willSetToMaxOnUpdate = false, bool isPercentage = false)
		{
			ResourceType = resourceType;
			Cap = cap;
			Max = max;
			Starting = starting;
			BonusMod = bonusMod;
			WillSetToMaxOnUpdate = willSetToMaxOnUpdate;
			IsPercentage = isPercentage;
		}

		public void AddMax(ResourceConfig otherConfig) { if (otherConfig != null) Max += otherConfig.Max; }
	}

	public class Resource
	{
		public ResourceType ResourceType => resourceConfig.ResourceType;
		public bool IsAtMax => (int)MathF.Round(Max) == (int)MathF.Round(Current);
		public float Max => MathF.Min(resourceConfig.Max + maxBonuses.Sum(x => x.Value), resourceConfig.Cap);
		public float Current { get; private set; }
		public bool HasBonuses => maxBonuses.Count > 0;

		private ResourceConfig resourceConfig;
		private Dictionary<int, float> maxBonuses = new Dictionary<int, float>();

		public Resource(ResourceConfig resourceConfig)
		{
			this.resourceConfig = resourceConfig;
			Current = resourceConfig.Starting;
		}

		public void AddCurrent(float amount)
		{
			if ((Current += amount) >= Max) Current = Max;
			if (Current <= 0f) Current = 0f;
		}
		public void UpdateMaxBonus(int idHash, float amount, bool willRemove = false)
		{
			if (willRemove && maxBonuses.ContainsKey(idHash)) maxBonuses.Remove(idHash);
			if (!willRemove && maxBonuses.ContainsKey(idHash)) maxBonuses[idHash] = amount;
			if (!willRemove && !maxBonuses.ContainsKey(idHash) && MathF.Abs(amount) > float.Epsilon) maxBonuses.Add(idHash, amount);
			AddCurrent(resourceConfig.WillSetToMaxOnUpdate ? Max : 0);
		}
	}

	public class Room
	{
		public Vec2Int Position { get; private set; }
		public RoomType RoomType { get; private set; }
		public Item Item { get; private set; }
		public RoomStatus RoomStatus { get; private set; }

		public Room(Vec2Int position, RoomType roomType, RoomStatus roomStatus)
		{
			Position = position;
			RoomType = roomType;
			Item = (roomType != RoomType.Empty ? new Item(null, true) : null);
			RoomStatus = roomStatus;
		}

		public void ReplaceItem(Item newItem) => Item = newItem;
		public void UpdateStatus(RoomStatus roomStatus) => RoomStatus = roomStatus;
		public void SetStaircase() => RoomType = RoomType.Staircase;
	}

	public class Map
	{
		public Vec2Int PlayerPosition { get; private set; } = new Vec2Int(10, 0);
		private int width = 20, height = 20;
		private List<Room> rooms;
		private Vec2Int[] directions = new Vec2Int[] { new Vec2Int(1, 0), new Vec2Int(0, -1), new Vec2Int(-1, 0), new Vec2Int(0, 1) };

		public Map(int roomsAmount, Vec2Int startPosition = null)
		{
			((Player)Game.Instance.Player).IncreaseDepth();
			rooms = new List<Room>() { new Room(startPosition ?? PlayerPosition, RoomType.Empty, RoomStatus.Explored) };
			while (rooms.Count < roomsAmount)
			{
				for (var roomIndex = 0; roomIndex < roomsAmount - 1 && rooms.Count < roomsAmount; roomIndex++)
				{
					new Random().Shuffle(directions);
					for (var directionIndex = 0; directionIndex < directions.Length; directionIndex++)
					{
						var pos = GetStartingRoom() + directions[directionIndex];
						if (IsVoid(pos)) rooms.Add(new Room(pos, Defines.DEBUG_ALL_ROOMS != RoomType.None ? Defines.DEBUG_ALL_ROOMS : GetRandomRoomType(new Random().Next(0, 5)), RoomStatus.Hidden));
					}
				}
			}
			PickFinalRoom();
			MovePlayer(new Vec2Int(0, 0));
		}

		public void DrawMap()
		{
			for (var yPos = height - 1; yPos >= 0; yPos--)
			{
				for (var xPos = 0; xPos < width; xPos++)
				{
					var room = GetRoom(new Vec2Int(xPos, yPos));
					if (room == null || room.RoomStatus == RoomStatus.Hidden) { Console.Write((xPos == 0 ? "|" : string.Empty) + Defines.ROOM_VOID); continue; }
					var isPlayerPosition = PlayerPosition.X == xPos && PlayerPosition.Y == yPos;
					var isSeen = room.RoomStatus == RoomStatus.Seen;
					var isStaircase = room.RoomType == RoomType.Staircase;
					var isItemRoom = room.Item == null;
					var roomSymbol = isPlayerPosition ? Defines.ROOM_PLAYER :
							(isSeen ? (isStaircase ? Defines.ROOM_STAIRCASE : Defines.ROOM_SEEN) :
								(isStaircase ? Defines.ROOM_STAIRCASE :
									(isItemRoom ? Defines.ROOM_EMPTY : Defines.ROOM_ITEM)));
					Console.Write((xPos == 0 ? "|" : string.Empty) + roomSymbol);
				}
				Console.WriteLine($"|{(yPos == 0 ? $"\n{Defines.FillTextToSize("|", (width * 3) + 1, "_")}|\n" : string.Empty)}");
			}
		}
		public Room GetRoom(Vec2Int position) => rooms.FirstOrDefault(x => x.Position.X == position.X && x.Position.Y == position.Y);
		public bool MovePlayer(Vec2Int direction)
		{
			var isMoved = GetRoom(PlayerPosition + direction) != null;
			if (!isMoved) return isMoved;
			PlayerPosition += direction;
			for (var directionIndex = 0; directionIndex < directions.Length; directionIndex++)
			{
				var pos = PlayerPosition + directions[directionIndex];
				if (pos.X >= 0 && pos.X < width && pos.Y >= 0 && pos.Y < height && GetRoom(pos) != null && GetRoom(pos).RoomStatus == RoomStatus.Hidden) GetRoom(pos).UpdateStatus(RoomStatus.Seen);
			}
			return isMoved;
		}

		private Vec2Int GetStartingRoom()
		{
			foreach (var room in rooms)
			{
				var counter = 0;
				for (var directionIndex = 0; directionIndex < directions.Length; directionIndex++)
					if (IsVoid(room.Position + directions[directionIndex]) && ++counter > 1) return room.Position;
			}
			return PlayerPosition;
		}
		private void PickFinalRoom()
		{
			for (var roomIndex = 0; roomIndex < rooms.Count; roomIndex++)
			{
				var counter = 0;
				for (var directionIndex = 0; directionIndex < directions.Length; directionIndex++)
					if (IsVoid(rooms[roomIndex].Position + directions[directionIndex]) && ++counter > 2 && roomIndex > (int)(rooms.Count * 0.5f)) { rooms[roomIndex].SetStaircase(); return; }
			}
		}
		private bool IsVoid(Vec2Int pos) => pos.X >= 0 && pos.X < width && pos.Y >= 0 && pos.Y < height && GetRoom(pos) == null;
		private RoomType GetRandomRoomType(int randomNumber) => randomNumber == 0 ? RoomType.Empty : randomNumber % 2 == 0 ? RoomType.Treasure : RoomType.Fight;
	}
}