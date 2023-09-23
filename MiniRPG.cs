using System;
using System.Collections.Generic;
using System.Linq;

namespace MiniRPG_CS
{
	public static class Defines
	{
		public const int LARGE_NUMBER = 665;
		public const int COMPARISON_SHEET_WIDTH = 36;
		public const RoomType DEBUG_ALL_ROOMS = RoomType.Fight;
		public const bool DEBUG_ALWAYS_AMBUSH = true;
		public static List<ResourceConfig> Resources => new List<ResourceConfig>
		{
			new ResourceConfig(ResourceType.None, 0f),
			new ResourceConfig(ResourceType.Health, 200f, 10000f, 1.8f, false),
			new ResourceConfig(ResourceType.Armor, 0f, 0f, 0.2f, true),
			new ResourceConfig(ResourceType.Damage, 0f, 0f, 0.2f, true),
			new ResourceConfig(ResourceType.Attacks, 0f, 0f, 0f, true),
			new ResourceConfig(ResourceType.Evades, 0f, 0f, 0f, true),
			new ResourceConfig(ResourceType.AbilityPoints, 100f, 5f),
			new ResourceConfig(ResourceType.Experience, 10000f),
			new ResourceConfig(ResourceType.Strength, 100f, 10f),
			new ResourceConfig(ResourceType.Dexterity, 100f, 10f),
			new ResourceConfig(ResourceType.Vitality, 100f, 10f),
			new ResourceConfig(ResourceType.CriticalDamage, 125f, 125f, 0.1f, true, true),
			new ResourceConfig(ResourceType.CriticalChance, 0f, 0f, 0.1f, true, true),
			new ResourceConfig(ResourceType.ChanceToHit, 45f, 45f, 0.1f, true, true),
			new ResourceConfig(ResourceType.ChanceToEvade, 15f, 15f, 0.1f, true, true),
			new ResourceConfig(ResourceType.Level, 100f, 90f),
			new ResourceConfig(ResourceType.Initiative, 0f, 0f, 0.2f, true),
			new ResourceConfig(ResourceType.HealthRegeneration, 0f, 999f, 0.2f, true),
			new ResourceConfig(ResourceType.Rations, 10000f, 30f),
		};
		public static List<ResourceConfig[]> AbilityBonusesPerPoint => new List<ResourceConfig[]>
		{
			new[] {new ResourceConfig(ResourceType.Damage, 1f), new ResourceConfig(ResourceType.Armor, 0.5f), },
			new[] {new ResourceConfig(ResourceType.ChanceToHit, 0.5f), new ResourceConfig(ResourceType.ChanceToEvade, 1f), new ResourceConfig(ResourceType.Initiative, 0.5f), },
			new[] {new ResourceConfig(ResourceType.Health, 5f), new ResourceConfig(ResourceType.HealthRegeneration, 0.5f), },
		};
		public static int[] RandomItems => new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14 };
		public static void GetItemIndexWithName(string name, ref int itemIndex) { for (var index = 0; index < Items.Count; index++) if (name.GetHashCode() == Items[index].ItemName.GetHashCode()) itemIndex = index; }
		public static List<ItemConfig> Items => new List<ItemConfig>
		{
			new ItemConfig(ItemSlot.Weapon, "Dagger", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 35f), new ResourceConfig( ResourceType.Attacks, 5f), new ResourceConfig( ResourceType.CriticalChance, 30f), }),
			new ItemConfig(ItemSlot.Weapon, "Sabre", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 45f), new ResourceConfig( ResourceType.Attacks, 3f), new ResourceConfig( ResourceType.CriticalChance, 20f), }),
			new ItemConfig(ItemSlot.Weapon, "Claymore", new ResourceConfig[] { new ResourceConfig( ResourceType.Damage, 55f), new ResourceConfig( ResourceType.Attacks, 2f), new ResourceConfig( ResourceType.CriticalChance, 10f), }),
			new ItemConfig(ItemSlot.Armor, "Leather Cuiras", new ResourceConfig[] { new ResourceConfig( ResourceType.Armor, 50f), new ResourceConfig( ResourceType.Evades, 5f) }),
			new ItemConfig(ItemSlot.Armor, "Chainmail", new ResourceConfig[] { new ResourceConfig( ResourceType.Armor, 100f), new ResourceConfig( ResourceType.Evades, 3f) }),
			new ItemConfig(ItemSlot.Armor, "Plate Mail", new ResourceConfig[] { new ResourceConfig( ResourceType.Armor, 150f), new ResourceConfig( ResourceType.Evades, 1f) }),
			new ItemConfig(ItemSlot.Consumable, "Snakeweed Oil", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 150f) }),
			new ItemConfig(ItemSlot.Consumable, "Snakeweed Elixir", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 300f) }),
			new ItemConfig(ItemSlot.Consumable, "Grimoire", new ResourceConfig[] { new ResourceConfig( ResourceType.Experience, 8f) }),
			new ItemConfig(ItemSlot.Consumable, "Yellow Mushroom", new ResourceConfig[] { new ResourceConfig( ResourceType.Strength, 1f) }),
			new ItemConfig(ItemSlot.Consumable, "Blue Mushroom", new ResourceConfig[] { new ResourceConfig( ResourceType.Dexterity, 1f) }),
			new ItemConfig(ItemSlot.Consumable, "Red Mushroom", new ResourceConfig[] { new ResourceConfig( ResourceType.Vitality, 1f) }),
			new ItemConfig(ItemSlot.Consumable, "Ration Pack", new ResourceConfig[] { new ResourceConfig( ResourceType.Rations, 10f) }),
			new ItemConfig(ItemSlot.Consumable, "Energetic Crystal", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 500f) }),
			new ItemConfig(ItemSlot.Consumable, "Azure Shard", new ResourceConfig[] { new ResourceConfig( ResourceType.Health, 1000f) }),
		};
		public static List<OpponentConfig> Opponents = new List<OpponentConfig>()
		{
			new OpponentConfig("Hawkwolf", new[] {0, 3, 6}, new[] {0, 30, 0 }, ResourceType.Dexterity),
			new OpponentConfig("Trollog", new[] {1, 4, 6}, new[] {10, 0, 20 }, ResourceType.Vitality),
			new OpponentConfig("Skeleton Warrior", new[] {2, 3, 6}, new[] {20, 5, 5 }, ResourceType.Strength),
			new OpponentConfig("Bloblin", new[] {0, 5, 7}, new[] {0, 5, 25 }, ResourceType.Vitality),
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

	public enum ResourceType { None, Health, Armor, Damage, Attacks, Evades, AbilityPoints, Experience, Strength, Dexterity, Vitality, CriticalDamage, CriticalChance, ChanceToHit, ChanceToEvade, Level, Initiative, HealthRegeneration, Rations }
	public enum StateType { None, MainMenu, CharacterCreation, Map, CharacterSheet, Room, Fight }
	public enum ItemSlot { Weapon, Armor, Consumable }
	public enum RoomType { None, Empty, Treasure, Fight, Staircase }
	public enum RoomStatus { None, Hidden, Seen, Explored }

	public interface IResource
	{
		public ResourceType ResourceType { get; }
		public float Starting { get; }
		public float Max { get; }
		public float BonusMod { get; }
	}

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
		private IOParser InputParser = new IOParser();

		public MiniRPGStateMachine() => ChangeState(StateType.MainMenu);

		protected void GoToState<T>(T newState) where T : State
		{
			if (state != null && state.StateTypeId != newState.StateTypeId) PreviousState = state;
			state = newState;
			state.OnChangeState += ChangeState;
			state.Initialize(InputParser);
		}
		private void ChangeState(StateType stateType) => new Action[] { null, () => GoToState(new MainMenuState()), () => GoToState(new CharacterCreationState()), () => GoToState(new MapState()), () => GoToState(new CharacterSheetState()), () => GoToState(new RoomState()), () => GoToState(new FightState()), }[(int)stateType].Invoke();
	}

	public class IOParser
	{
		public int LastInput { get; private set; }

		public bool WaitForInput(int totalInputs)
		{
			var result = -1;
			var isInt = int.TryParse(Console.ReadLine(), out result);
			if (isInt && result >= 0 && result < totalInputs) LastInput = result;
			return isInt && result >= 0 && result < totalInputs;
		}
		public void ProcessValidName(ref string characterName, Action onShowStateName)
		{
			while (characterName.Length < 3 || characterName.Length > 12)
			{
				Console.Clear();
				onShowStateName?.Invoke();
				Console.WriteLine("Please type name between 3 and 12 characters long and press Enter.");
				characterName = Console.ReadLine();
			}
			Console.Clear();
		}
		public void ProcessValidInput(Action beforeOptions, string[] options, Action[] actions)
		{
			beforeOptions?.Invoke();
			ShowOptions(options);
			while (!WaitForInput(actions.Length))
			{
				Console.Clear();
				beforeOptions?.Invoke();
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
				GetResourceLine(player, ResourceType.Armor, false, true),
				GetResourceLine(player, ResourceType.Evades, false, true),
				GetResourceLine(player, ResourceType.Damage, false, true),
				GetResourceLine(player, ResourceType.Attacks, false, true),
				GetResourceLine(player, ResourceType.ChanceToHit, false, true),
				GetResourceLine(player, ResourceType.ChanceToEvade, false, true),
				GetResourceLine(player, ResourceType.CriticalChance, false, true),
				GetResourceLine(player, ResourceType.CriticalDamage, false, true),
			};
			var equipmentLines = new List<string>() { string.Empty, string.Empty, $"___Supplies:", $"{GetResourceLine(player, ResourceType.Rations)}" };
			foreach (var itemSlot in (ItemSlot[])Enum.GetValues(typeof(ItemSlot))) GetItemLines(ref equipmentLines, player.GetInventoryItemFromSlot(itemSlot), itemSlot);
			CombineTwoLists(characterLines, equipmentLines, Defines.COMPARISON_SHEET_WIDTH);
			Console.WriteLine($"{Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_")} {Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_")}\n");
		}
		public void DrawRoomItemComparison(Item roomItem, Item item)
		{
			if (roomItem == null) return;
			List<string> roomItemLines = new List<string>(), playerItemLines = new List<string>();
			GetItemLines(ref roomItemLines, roomItem, roomItem.Slot);
			if (item != null) GetItemLines(ref playerItemLines, item, item.Slot);
			CombineTwoLists(roomItemLines, playerItemLines, Defines.COMPARISON_SHEET_WIDTH);
			Console.WriteLine($"{Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_")} {Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_")}\n");
		}
		public void DrawLeveledUpText() => Console.WriteLine($"{Game.Instance.Player.CharacterName} has leveled up to level {Game.Instance.Level} and has {Game.Instance.Player.Resource(ResourceType.AbilityPoints).Current} unused ability points!\n");
		public string GetResourceLine(Actor actor, ResourceType resourceType, bool willShowCurrent = true, bool willShowMax = false) => $"{Defines.AddSpacesBeforeCapitals(resourceType.ToString())}: {(willShowCurrent ? actor.Resource((int)resourceType).Current : string.Empty)}{(willShowCurrent && willShowMax ? "/" : string.Empty)}{(willShowMax ? actor.Resource((int)resourceType).MaxWithBonuses : string.Empty)}{(Defines.Resources[(int)resourceType].IsPercentage ? "%" : string.Empty)}";
		public string GetItemLine(Item item, ResourceType resourceType) => $"{Defines.AddSpacesBeforeCapitals(resourceType.ToString())}: +{item.Resource(resourceType).MaxWithBonuses}{(Defines.Resources[(int)resourceType].IsPercentage ? "%" : string.Empty)}";

		private void CombineTwoLists(List<string> list1, List<string> list2, int text1Width) { for (var index = 0; index < (int)MathF.Max(list1.Count, list2.Count); index++) DrawSheetLine($"{(list1.Count > index ? list1[index] : string.Empty)}", $"{(list2.Count > index ? list2[index] : string.Empty)}", index > 0 ? "|" : string.Empty, text1Width); }
		private void DrawSheetLine(string text1, string text2, string separator, int text1Width) => Console.WriteLine($"|{Defines.FillTextToSize(text1, text1Width)}{separator}{text2}");
		private void ShowOptions(string[] options)
		{
			for (var index = 0; index < options.Length; index++) Console.WriteLine($"| {index}. {options[index]}");
			Console.WriteLine($"{Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_")}\nType your option's index and press Enter:");
		}
		private void GetItemLines(ref List<string> equipmentLines, Item item, ItemSlot itemSlot)
		{
			equipmentLines.AddRange(new[] { string.Empty, $"___{itemSlot}:", $"Name: {(item == null ? "None Equipped" : item.ItemConfig.ItemName)}" });
			if (item == null) return;
			if (item.ItemConfig.Slot == ItemSlot.Weapon) equipmentLines.AddRange(new[] { $"{GetItemLine(item, ResourceType.Damage)}", $"{GetItemLine(item, ResourceType.Attacks)}", $"{GetItemLine(item, ResourceType.CriticalChance)}" });
			if (item.ItemConfig.Slot == ItemSlot.Armor) equipmentLines.AddRange(new[] { $"{GetItemLine(item, ResourceType.Armor)}", $"{GetItemLine(item, ResourceType.Evades)}" });
			if (item.ItemConfig.Slot == ItemSlot.Consumable) equipmentLines.Add($"Effect: +{item.GetConsumableResource().MaxWithBonuses} {item.GetConsumableResource().ResourceType}");
			else
			{
				if (item.GetResourcesWithBonuses().Length > 0) equipmentLines.Add("___Bonuses:");
				foreach (var resource in item.GetResourcesWithBonuses()) equipmentLines.Add($"> {GetItemLine(item, resource.ResourceType)}");
			}
		}
	}

	public class Game
	{
		private Game() { }
		private static Game instance;
		public static Game Instance => instance ?? (instance = new Game());

		public Map Map;
		public Player Player;
		public Opponent Opponent;
		public int Level => Player?.Level ?? (int)Defines.Resources[(int)ResourceType.Level].Starting;
		public Room PlayerRoom => Map.GetRoom(Map.PlayerPosition);
	}

	public abstract class State
	{
		protected IOParser InputParser;
		public Action<StateType> OnChangeState;

		protected abstract string[] BaseOptions { get; }
		protected abstract Action[] BaseActions { get; }

		public void Initialize(IOParser inputParser)
		{
			InputParser = inputParser;
			ShowStateName();
			StateMain();
		}
		public abstract StateType StateTypeId { get; }

		protected abstract void StateMain();
		protected void ShowStateName() { Console.Clear(); Console.WriteLine($">----<{Defines.AddSpacesBeforeCapitals(StateTypeId.ToString())}>\n\n"); }
		protected void ShowTextAndReset(string text, StateType stateType = StateType.None, Action onStateShown = null)
		{
			ShowStateName(); onStateShown?.Invoke(); Console.WriteLine(text + "\nPress enter to continue."); Console.ReadLine();
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
			Game.Instance.Player = null;
			Game.Instance.Opponent = null;
			InputParser.ProcessValidInput(ShowStateName, BaseOptions, BaseActions);
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
			InputParser.ProcessValidName(ref characterName, ShowStateName);
			(Game.Instance.Player = new Player(characterName)).AddItems();
			InputParser.ProcessValidInput(() =>
			{
				ShowStateName();
				Console.WriteLine($"Create character named: {characterName}?\n");
			}, BaseOptions, BaseActions);
		}
	}

	public class MapState : State
	{
		public override StateType StateTypeId => StateType.Map;
		protected override string[] BaseOptions => new string[] { "Explore Current Room", "Move North", "Move South", "Move West", "Move East", "Character Sheet", $"Rest (+{Game.Instance.Player.Resource(ResourceType.HealthRegeneration).MaxWithBonuses * 2f} {ResourceType.Health})", "Quit" };
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
			if (Game.Instance.Map == null || (Game.Instance.Map != null && Game.Instance.PlayerRoom.RoomType == RoomType.Staircase)) Game.Instance.Map = new Map(Game.Instance.Level + 20);
			InputParser.ProcessValidInput(() =>
			{
				ShowStateName();
				Game.Instance.Map.DrawMap();
				if (Game.Instance.Player.HasJustLeveledUp) InputParser.DrawLeveledUpText();
				Console.WriteLine($"|{Defines.FillTextToSize("", (int)MathF.Ceiling((Defines.COMPARISON_SHEET_WIDTH - $"Name: {Game.Instance.Player.CharacterName}".Length) * 0.5f), " ")}Name: {Game.Instance.Player.CharacterName}\n|{InputParser.GetResourceLine(Game.Instance.Player, ResourceType.Health, true, true)}\n|{InputParser.GetResourceLine(Game.Instance.Player, ResourceType.Rations)}\n{Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_")}\n");
			}, BaseOptions, BaseActions);
		}

		private void MovePlayer(Vec2Int direction)
		{
			if (Game.Instance.Map.MovePlayer(direction) && WillHeal().HasValue) OnChangeState?.Invoke(StateType.Room);
			ShowTextAndReset("Can't go that way! Press enter to return to Map.");
		}
		private void Rest()
		{
			if (!WillHeal(2f).Value) ShowTextAndReset($"Not enough {ResourceType.Rations} to rest! Press enter to return to Map.");
			ShowTextAndReset("You find a safe spot and rest for a few hours. You feel much better now! Press enter to return to Map.");
		}
		private bool? WillHeal(float healMod = 1f)
		{
			if (Game.Instance.Player.Resource(ResourceType.Rations).Current <= 0) return false;
			Game.Instance.Player.Resource(ResourceType.Rations).AddCurrent(-1f);
			Game.Instance.Player.Resource(ResourceType.Health).AddCurrent((int)MathF.Ceiling(Game.Instance.Player.Resource(ResourceType.HealthRegeneration).MaxWithBonuses * healMod));
			return true;
		}
	}

	public class CharacterSheetState : State
	{
		public override StateType StateTypeId => StateType.CharacterSheet;
		protected override string[] BaseOptions => new string[] { $"{ResourceType.Strength} + 1", $"{ResourceType.Dexterity} + 1", $"{ResourceType.Vitality} + 1", "Use Consumable", "Back" };
		protected override Action[] BaseActions => new Action[] { () => AddAbility(ResourceType.Strength), () => AddAbility(ResourceType.Dexterity), () => AddAbility(ResourceType.Vitality), UseConsumable, () => OnChangeState?.Invoke(MiniRPGStateMachine.PreviousState.StateTypeId) };

		protected override void StateMain()
		{
			InputParser.ProcessValidInput(() =>
			{
				ShowStateName();
				InputParser.DrawCharacterSheet();
			}, BaseOptions, BaseActions);
			Game.Instance.Player.ResetLeveledUpFlag();
		}

		private void AddAbility(ResourceType resourceType)
		{
			ShowStateName();
			var abilityPoints = Game.Instance.Player.Resource(ResourceType.AbilityPoints);
			if (abilityPoints.Current <= 0) ShowTextAndReset("No available ability points!");
			if (abilityPoints.Current == abilityPoints.Max) ShowTextAndReset($"{resourceType} already at max!");
			var abilityText = $"{resourceType} Bonuses per point:\n";
			foreach (var bonus in Defines.AbilityBonusesPerPoint[(int)resourceType - (int)ResourceType.Strength]) abilityText += $"+{bonus.Max} {Defines.AddSpacesBeforeCapitals(bonus.ResourceType.ToString())}\n";
			Console.WriteLine($"{abilityText}\nType 'y' to increase {resourceType} by 1\nType 'n' to cancel.");
			var input = Console.ReadLine();
			while (input != "y" && input != "n") Console.WriteLine(abilityText + (input = Console.ReadLine()));
			if (input == "n") OnChangeState?.Invoke(StateTypeId);
			abilityPoints.AddCurrent(-1);
			Game.Instance.Player.AddAbility(resourceType);
			OnChangeState?.Invoke(StateTypeId);
		}
		private void UseConsumable()
		{
			if (!Game.Instance.Player.UseConsumable()) return;
			var item = Game.Instance.Player.GetInventoryItemFromSlot(ItemSlot.Consumable);
			Game.Instance.Player.RemoveInventoryItem(ItemSlot.Consumable);
			var itemResource = item.GetConsumableResource();
			ShowTextAndReset($"Used {item.ItemConfig.ItemName} to {(itemResource.MaxWithBonuses > float.Epsilon ? "increase" : "damage")} {itemResource.ResourceType} by {itemResource.MaxWithBonuses}.");
		}
	}

	public class RoomState : State
	{
		public override StateType StateTypeId => StateType.Room;
		protected override string[] BaseOptions => new string[] { $"Swap Item ({(Game.Instance.PlayerRoom.Item == null ? "None" : Game.Instance.PlayerRoom.Item.ItemConfig.ItemName)})", "Character Sheet", "Back to Map" };
		protected override Action[] BaseActions => new Action[] { SwapItem, () => OnChangeState?.Invoke(StateType.CharacterSheet), () => OnChangeState?.Invoke(StateType.Map) };

		protected override void StateMain()
		{
			if (Game.Instance.PlayerRoom.RoomType == RoomType.Staircase) ShowTextAndReset("You stumble into a room with a dusty staircase going down into the darkness.\nAll of a sudden, a strange whim compels you to begin climbing down.\nAs soon as you touch the final step, the staircase crumbles behind you.\nYou are now stranded on this level of the dungeon.\nWith nothing else to do and no way back, you press on.\n", StateType.Map);
			if (Game.Instance.PlayerRoom.RoomType == RoomType.Fight && Game.Instance.PlayerRoom.RoomStatus != RoomStatus.Explored) OnChangeState?.Invoke(StateType.Fight);
			Game.Instance.PlayerRoom.UpdateStatus(RoomStatus.Explored);
			Game.Instance.Opponent = null;
			InputParser.ProcessValidInput(() =>
			{
				ShowStateName();
				if (Game.Instance.PlayerRoom.Item == null) Console.WriteLine("Room has no item.\n");
				else InputParser.DrawRoomItemComparison(Game.Instance.PlayerRoom.Item, Game.Instance.Player.GetInventoryItemFromSlot(Game.Instance.PlayerRoom.Item.ItemConfig.Slot));
				if (Game.Instance.Player.HasJustLeveledUp) InputParser.DrawLeveledUpText();
			}, BaseOptions, BaseActions);
		}

		private void SwapItem()
		{
			if (Game.Instance.PlayerRoom.Item == null) ShowTextAndReset("Room has no item.");
			var roomItem = Game.Instance.PlayerRoom.Item;
			var playerItem = Game.Instance.Player.GetInventoryItemFromSlot(roomItem.Slot);
			Game.Instance.Player.SetInventoryItemInSlot(roomItem);
			Game.Instance.PlayerRoom.ReplaceItem(playerItem);
			ShowTextAndReset($"{(playerItem != null ? $"{playerItem.ItemConfig.ItemName}" : "Nothing")} dropped. {roomItem.ItemConfig.ItemName} equipped.");
		}
	}

	public class FightState : State
	{
		public override StateType StateTypeId => StateType.Fight;
		protected override string[] BaseOptions => new string[] {
			GetAttackString("Light Attack ", actors[playerIndex], (int)actors[playerIndex].Resource(ResourceType.Attacks).MaxWithBonuses, 0.3f, 1f),
			GetAttackString("Heavy Attack ", actors[playerIndex], 1, 1f, 1.5f),
			$"Use Consumable ({(actors[playerIndex].GetInventoryItemFromSlot(ItemSlot.Consumable) == null ? "None" : actors[playerIndex].GetInventoryItemFromSlot(ItemSlot.Consumable).ItemConfig.ItemName)})",
			"Debug: Win!", "Debug: Lose!", };
		protected override Action[] BaseActions => new Action[] { () => LightAttack(actors[playerIndex], actors[opponentIndex]), () => HeavyAttack(actors[playerIndex], actors[opponentIndex]), () => UseConsumable(actors[playerIndex], actors[opponentIndex]), () => Won(40), Lost };

		private List<int>[] attackLists = new[] { new List<int>(), new List<int>() };
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
			InputParser.ProcessValidInput(() =>
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
				if (actorIndex > playerIndex && attackLists[playerIndex].Count == 0) Console.WriteLine($"| A sneaky {actors[opponentIndex].CharacterName} ambushed you!");
				Console.WriteLine($"{Defines.FillTextToSize("|", (int)MathF.Round((Defines.COMPARISON_SHEET_WIDTH - actors[actorIndex].CharacterName.Length) * 0.5f), " ")}{actors[actorIndex].CharacterName}\n|{InputParser.GetResourceLine(actors[actorIndex], ResourceType.Health, true, true)}");
				if (actorAttacks.Count != 0)
				{
					for (var index = 0; index < actorAttacks.Count; index++)
					{
						if (actorAttacks[index] > 10000)
						{
							var itemResource = Defines.Items[actorAttacks[index] - 10000].ResourceConfigs.FirstOrDefault(x => x.Max > 0f);
							Console.WriteLine($"|>Used {Defines.Items[actorAttacks[index] - 10000].ItemName} to {(itemResource.Max > float.Epsilon ? "increase" : "damage")} {itemResource.ResourceType} by {itemResource.Max}.");
						}
						else Console.WriteLine($"|>Used {(actorAttacks.Count > 1 ? "Light" : "Heavy")} Attack. It {(actorAttacks[index] < 0 ? "was evaded" : (actorAttacks[index] == 0 ? "missed" : $"hit dealing {actorAttacks[index]} damage"))}.");
					}
				}
				Console.WriteLine($"{Defines.FillTextToSize("|", Defines.COMPARISON_SHEET_WIDTH, "_")}\n");
			}
		}
		private void AI()
		{
			turns++;
			var actor = actors[opponentIndex];
			var chance = new Random().Next(0, 100);
			var health = actors[opponentIndex].Resource(ResourceType.Health);
			if (chance + (int)((1f - (health.Current / (float)health.MaxWithBonuses)) * 100f) > 120) 
			{
				var consumable = actor.GetInventoryItemFromSlot(ItemSlot.Consumable);
				if (consumable != null && (consumable.GetConsumableResource().ResourceType == ResourceType.Health)) UseConsumable(actor, actors[playerIndex]);
			}
			var lightChance = chance + (int)actor.Resource(ResourceType.Dexterity).Current;
			var heavyChance = (100 - chance) + (int)actor.Resource(ResourceType.Strength).Current;
			if (lightChance > heavyChance) LightAttack(actor, actors[playerIndex]);
			else HeavyAttack(actor, actors[playerIndex]);
		}
		private void LightAttack(Actor attacker, Actor defender) => Attack(attacker, defender, (int)attacker.Resource(ResourceType.Attacks).MaxWithBonuses, 0.3f);
		private void HeavyAttack(Actor attacker, Actor defender) => Attack(attacker, defender, 1, 1f, 1.5f);
		private void Attack(Actor attacker, Actor defender, int attacks, float damagePercentage, float toHitMod = 1f)
		{
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
			var itemIndex = 0; Defines.GetItemIndexWithName(attacker.GetInventoryItemFromSlot(ItemSlot.Consumable).ItemConfig.ItemName, ref itemIndex);
			attackLists[turns].Add(10000 + itemIndex);
			if (attacker.UseConsumable()) attacker.RemoveInventoryItem(ItemSlot.Consumable);
			if (turns > 0) DrawCombat();
			else AI();
		}
		private List<int> GetPotentialHits(Actor attacker, int amount, float damagePercentage, float toHitMod = 1f)
		{
			var result = new List<int>();
			for (var index = 0; index < amount; index++) result.Add(WillPotentiallyHit(attacker, toHitMod) ? (int)MathF.Round(attacker.Resource(ResourceType.Damage).MaxWithBonuses * damagePercentage * GetCritMultiplier(attacker)) : 0);
			return result;
		}
		private void EvaluateEvasions(Actor defender, ref List<int> potentialHits)
		{
			var totalEvasions = defender.Resource(ResourceType.Evades).MaxWithBonuses;
			for (var index = 0; index < potentialHits.Count; index++)
			{
				if (potentialHits[index] <= 0 || totalEvasions <= 0) continue;
				totalEvasions--;
				if (WillEvade(defender)) potentialHits[index] = -1;
			}
		}
		private void EvaluateDefence(Actor defender, ref List<int> potentialHits)
		{
			var armorRating = 1f - MathF.Min(defender.Resource(ResourceType.Armor).MaxWithBonuses < float.Epsilon ? 0f : defender.Resource(ResourceType.Armor).MaxWithBonuses / 300f, 0.95f);
			for (var index = 0; index < potentialHits.Count; index++) if (potentialHits[index] > 0) potentialHits[index] = (int)MathF.Max(1f, MathF.Round(armorRating * potentialHits[index]));
		}
		private bool WillPotentiallyHit(Actor attacker, float toHitMod = 1f) => (new Random().NextDouble() * 100f) < MathF.Min(95f, MathF.Round(attacker.Resource(ResourceType.ChanceToHit).MaxWithBonuses * toHitMod));
		private bool WillCrit(Actor attacker) => (new Random().NextDouble() * 100f) < attacker.Resource(ResourceType.CriticalChance).MaxWithBonuses;
		private float GetCritMultiplier(Actor attacker) => (WillCrit(attacker) ? (attacker.Resource(ResourceType.CriticalDamage).MaxWithBonuses * 0.01f) : 1f);
		private bool WillEvade(Actor defender) => (new Random().NextDouble() * 100f) < defender.Resource(ResourceType.ChanceToEvade).MaxWithBonuses;
		private Opponent GetRandomOpponent() => new Opponent(Defines.Opponents[new Random().Next(0, Defines.Opponents.Count)]);
		private bool IsAmbush() => Defines.DEBUG_ALWAYS_AMBUSH || actors[playerIndex].Resource(ResourceType.Initiative).MaxWithBonuses < actors[opponentIndex].Resource(ResourceType.Initiative).MaxWithBonuses;
		private bool IsActorDead(Actor actor) => actor.Resource(ResourceType.Health).Current < float.Epsilon;
		private void Won(int experience = 1)
		{
			actors[playerIndex].GiveExperience(experience);
			Game.Instance.PlayerRoom.UpdateStatus(RoomStatus.Explored);
			ShowTextAndReset($"{actors[playerIndex].CharacterName} was victorious!\nThey gained {experience} expirence point!", StateType.Room, DrawTurns);
		}
		private void Lost() => ShowTextAndReset($"{actors[playerIndex].CharacterName} was slain by a vicious {Defines.AddSpacesBeforeCapitals(actors[opponentIndex].CharacterName)}!\nThey achieved level {actors[playerIndex].Level} before perishing.\nHow tragic!\n", StateType.MainMenu, DrawTurns);
		private string GetAttackString(string moveName, Actor actor, int times, float damagePercentage, float toHitMod) => $"{moveName}({MathF.Min(toHitMod * actor.Resource(ResourceType.ChanceToHit).MaxWithBonuses, 95f)}% to hit, {times}x{(int)MathF.Round(actor.Resource(ResourceType.Damage).MaxWithBonuses * damagePercentage)} damage)";
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
				ResourceConfigs.Add(new ResourceConfig(Defines.Resources[index].ResourceType, 0f, 0f, 0f));
				ResourceConfigs[index].AddMax(presetValues?.FirstOrDefault(x => x.ResourceType == ResourceConfigs[index].ResourceType));
			}
		}
	}

	public class Item
	{
		public ItemSlot Slot => ItemConfig.Slot;
		public int ItemHashId => ItemConfig.ItemName.GetHashCode();
		public ItemConfig ItemConfig { get; private set; }

		private List<Resource> resources = new List<Resource>();

		public Item(ItemConfig itemConfig, bool isForPlayer = false)
		{
			if (itemConfig == null) itemConfig = Defines.Items[Defines.RandomItems[new Random().Next(0, Defines.Items.Count)]];
			ItemConfig = itemConfig;
			for (var index = 0; index < Defines.Resources.Count; index++) resources.Add(new Resource(itemConfig.ResourceConfigs[index]));
			if (!isForPlayer || ItemConfig.Slot == ItemSlot.Consumable) return;
			for (var index = 0; index < (int)MathF.Ceiling(Game.Instance.Level * /*0.039f*/ 0.049f); index++)
			{
				var resource = resources[new Random().Next(1, resources.Count)];
				var bonusAmount = MathF.Floor(Game.Instance.Level * Defines.Resources[(int)resource.ResourceType].BonusMod);
				if (resource.MaxWithBonuses < float.Epsilon && Defines.Resources[(int)resource.ResourceType].BonusMod > float.Epsilon && bonusAmount > float.Epsilon)
					resource.UpdateMaxBonus(ItemHashId, bonusAmount);
			}
		}
		public Resource Resource(ResourceType resourceType) => Resource((int)resourceType);
		public Resource Resource(int index) => resources[index];
		public bool Use(Actor actor)
		{
			if (GetConsumableResource().ResourceType == ResourceType.Experience) actor.GiveExperience((int)GetConsumableResource().MaxWithBonuses);
			else if (GetConsumableResource().ResourceType == ResourceType.Strength || GetConsumableResource().ResourceType == ResourceType.Dexterity || GetConsumableResource().ResourceType == ResourceType.Vitality) actor.AddAbility(GetConsumableResource().ResourceType, true, (int)GetConsumableResource().MaxWithBonuses);
			else actor.Resource((int)GetConsumableResource().ResourceType).AddCurrent(GetConsumableResource().MaxWithBonuses);
			return true;
		}
		public Resource GetConsumableResource() => ItemConfig.Slot == ItemSlot.Consumable ? resources.FirstOrDefault(x => x.MaxWithBonuses > float.Epsilon) : null;
		public Resource[] GetResourcesWithBonuses() => resources.Where(x => x.Max != x.MaxWithBonuses)?.ToArray() ?? new Resource[0];
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
			AddAbility(ResourceType.Strength, false); AddAbility(ResourceType.Dexterity, false); AddAbility(ResourceType.Vitality, false);
		}
		public void AddAbility(ResourceType ability, bool willAddPoint = true, int amount = 1)
		{
			if (willAddPoint) Resource((int)ability).AddCurrent(amount);
			foreach (var bonus in Defines.AbilityBonusesPerPoint[(int)ability - (int)ResourceType.Strength]) Resource((int)bonus.ResourceType).UpdateMaxBonus(CharacterName.GetHashCode(), Resource((int)ability).Current * bonus.Max);
		}
		public Resource Resource(ResourceType resourceType) => Resource((int)resourceType);
		public Resource Resource(int index) => resources[index];
		public void SetInventoryItemInSlot(Item item) => CanUpdateResources(inventory[(int)item.Slot] = item, (int)item.Slot);
		public Item GetInventoryItemFromSlot(ItemSlot itemSlot) => inventory[(int)itemSlot];
		public bool UseConsumable() => (inventory[(int)ItemSlot.Consumable]?.Use(this)).HasValue;
		public void RemoveInventoryItem(ItemSlot itemSlot) => inventory[(int)itemSlot] = null;
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
		private void UpdateResourcesWithItem(Item item) { for (var index = 0; index < resources.Count; index++) Resource(index).UpdateMaxBonus(item.ItemHashId, item.Resource(index).MaxWithBonuses); }
	}

	public class Player : Actor
	{
		private int[] startingItems = new[] { 1, 3, 6 };
		public Player(string name) : base(name) { for (var index = 0; index < startingItems.Length; index++) SetInventoryItemInSlot(new Item(Defines.Items[startingItems[index]], true)); }
		public void AddItems() { for (var index = 0; index < startingItems.Length; index++) SetInventoryItemInSlot(new Item(Defines.Items[startingItems[index]], true)); }
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
			for (var index = 0; index < opponentConfig.StartingItemsIndices.Length; index++) SetInventoryItemInSlot(new Item(Defines.Items[opponentConfig.StartingItemsIndices[index]], true));
			for (var index = (int)ResourceType.Strength; index < (int)ResourceType.Strength + 3; index++) Resource(index).AddCurrent(opponentConfig.StartingAbilities[index - (int)ResourceType.Strength]);
			Resource(ResourceType.Health).AddCurrent(Defines.LARGE_NUMBER);
		}
		//AUTO - LEVEL UP TO TARGET LEVEL
	}

	public class ResourceConfig : IResource
	{
		public ResourceType ResourceType { get; private set; }
		public float Max { get; private set; }
		public float Starting { get; private set; }
		public float BonusMod { get; private set; }
		public bool WillSetToMaxOnUpdate { get; private set; }
		public bool IsPercentage { get; private set; }

		public ResourceConfig(ResourceType resourceType, float max, float starting = 0f, float bonusMod = 0f, bool willSetToMaxOnUpdate = false, bool isPercentage = false)
		{
			ResourceType = resourceType;
			Starting = starting;
			Max = max;
			BonusMod = bonusMod;
			WillSetToMaxOnUpdate = willSetToMaxOnUpdate;
			IsPercentage = isPercentage;
		}

		public void AddMax(ResourceConfig otherConfig) { if (otherConfig != null) Max += otherConfig.Max; }
	}

	public class Resource
	{
		public ResourceType ResourceType => ResourceBase.ResourceType;
		public ResourceConfig ResourceBase { get; private set; }
		public bool IsAtMax => (int)MathF.Round(MaxWithBonuses) == (int)MathF.Round(Current);
		public float Max => ResourceBase.Max;
		public float MaxWithBonuses => ResourceBase.Max + maxBonuses.Sum(x => x.Value);
		public float Current { get; private set; }

		private Dictionary<int, float> maxBonuses = new Dictionary<int, float>();

		public Resource(ResourceConfig resourceConfig) => ResourceBase = new ResourceConfig(resourceConfig.ResourceType, resourceConfig.Max, Current = resourceConfig.Starting, resourceConfig.BonusMod, resourceConfig.WillSetToMaxOnUpdate, resourceConfig.IsPercentage);

		public void AddCurrent(float amount)
		{
			Current += amount;
			if (Current >= MaxWithBonuses) Current = MaxWithBonuses;
			if (Current <= 0f) Current = 0f;
		}
		public void UpdateMaxBonus(int idHash, float amount, bool willRemove = false)
		{
			if (willRemove && maxBonuses.ContainsKey(idHash)) maxBonuses.Remove(idHash);
			if (!willRemove && maxBonuses.ContainsKey(idHash)) maxBonuses[idHash] = amount;
			if (!willRemove && !maxBonuses.ContainsKey(idHash) && MathF.Abs(amount) > float.Epsilon) maxBonuses.Add(idHash, amount);
			AddCurrent(ResourceBase.WillSetToMaxOnUpdate ? MaxWithBonuses : 0);
		}
		public float GetBonusPoints(int idHash = 0, bool willRoundToInt = true) => willRoundToInt ? MathF.Round(idHash == 0 ? maxBonuses.Values.ElementAt(0) : maxBonuses[idHash]) : idHash == 0 ? maxBonuses.Values.ElementAt(0) : maxBonuses[idHash];
	}

	public class Room
	{
		public Vec2Int Position { get; private set; }
		public RoomType RoomType { get; private set; }
		public Item Item { get; private set; }
		public RoomStatus RoomStatus { get; private set; }

		public Room(Vec2Int position, RoomType roomType, Item item, RoomStatus roomStatus)
		{ Position = position; RoomType = roomType; Item = item; RoomStatus = roomStatus; }

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
			rooms = new List<Room>() { new Room(startPosition ?? PlayerPosition, RoomType.Empty, null, RoomStatus.Explored) };
			while (rooms.Count < roomsAmount)
			{
				for (var roomIndex = 0; roomIndex < roomsAmount - 1 && rooms.Count < roomsAmount; roomIndex++)
				{
					new Random().Shuffle(directions);
					for (var directionIndex = 0; directionIndex < directions.Length; directionIndex++)
					{
						var pos = GetStartingRoom() + directions[directionIndex];
						if (pos.X >= 0 && pos.X < width && pos.Y >= 0 && pos.Y < height && GetRoom(pos) == null)
						{
							var roomType = Defines.DEBUG_ALL_ROOMS == RoomType.None ? (RoomType)(new Random().Next(1, (Enum.GetValues(typeof(RoomType))).Length - 1)) : Defines.DEBUG_ALL_ROOMS;
							rooms.Add(new Room(pos, roomType, (roomType != RoomType.Empty ? new Item(null, true) : null), RoomStatus.Hidden));
						}
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
					var roomSymbol = (room == null || room.RoomStatus == RoomStatus.Hidden) ? "   " : (PlayerPosition.X == xPos && PlayerPosition.Y == yPos ? "[x]" : (room.RoomStatus == RoomStatus.Seen ? "[?]" : (room.RoomType == RoomType.Staircase ? $"\\_/" : (room.Item == null ? "[_]" : "[*]"))));
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
			for (var roomIndex = 0; roomIndex < rooms.Count; roomIndex++)
			{
				var counter = 0;
				for (var directionIndex = 0; directionIndex < directions.Length; directionIndex++)
				{
					var pos = rooms[roomIndex].Position + directions[directionIndex];
					if (pos.X >= 0 && pos.X < width && pos.Y >= 0 && pos.Y < height && GetRoom(pos) == null) if (++counter > 1) return rooms[roomIndex].Position;
				}
			}
			return PlayerPosition;
		}
		private void PickFinalRoom()
		{
			for (var roomIndex = 0; roomIndex < rooms.Count; roomIndex++)
			{
				var counter = 0;
				for (var directionIndex = 0; directionIndex < directions.Length; directionIndex++)
				{
					var pos = rooms[roomIndex].Position + directions[directionIndex];
					if (pos.X >= 0 && pos.X < width && pos.Y >= 0 && pos.Y < height && GetRoom(pos) == null) if (++counter > 2 && roomIndex > (int)(rooms.Count * 0.5f)) { rooms[roomIndex].SetStaircase(); return; }
				}
			}
		}
	}
}

/// <summary>
/// TODO:
/// - add opponent auto level up
/// - NPC Specific Equipment (items only used by enemies)
/// </summary>
