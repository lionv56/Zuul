using System.Collections.Generic;

class Room
{
	// Private fields
	private string description;
	private Dictionary<string, Room> exits; // stores exits of this room.

	// Create a room described "description". Initially, it has no exits.
	// "description" is something like "in a kitchen" or "in a court yard".
	public Room(string desc)
	{
		description = desc;
		exits = new Dictionary<string, Room>();
	}

	// Define an exit for this room.
	public void AddExit(string direction, Room neighbor)
	{
		exits.Add(direction, neighbor);
	}

	// Return the description of the room.
	public string GetShortDescription()
	{
		return description;
	}

	// Return a long description of this room, in the form:
	//     You are in the kitchen.
	//     Exits: north, west
	public string GetLongDescription()
	{
		string str = "You are ";
		str += description;
		str += ".\n";
		str += GetExitString();
		return str;
	}

	// Return a description of items in the room
	public string getItemDescription()
	{
		if (items.Count == 0)
		{
			return "The room is empty.";
		}

		string itemDescriptions = "Items in the room:\n";
		foreach (Item item in items)
		{
			itemDescriptions += $"- {item.Description} (Weight: {item.Weight})\n";
		}
		return itemDescriptions;
	}

	// Return the room that is reached if we go from this room in direction
	// "direction". If there is no room in that direction, return null.
	public Room GetExit(string direction)
	{
		if (exits.ContainsKey(direction))
		{
			return exits[direction];
		}
		return null;
	}

	// Return a string describing the room's exits, for example
	// "Exits: north, west".
	private string GetExitString()
	{
		string str = "Exits: ";
		str += String.Join(", ", exits.Keys);

		return str;
	}

	// Add an item to the room
	public void AddItem(Item item)
	{
		// Implementation for adding an item to the room
		items.Add(item);
	}
	private List<Item> items = new List<Item>();
}
