using System;

namespace ch12_prj_Wizard_Inventory
{
	class Program
	{
		public String getCommand()
		{
			return command;
		}
	{
	}
	private static sealed int MAX_INVENTORY_SIZE = 4;
	public static void main(String[] args)
	{
		Console.WriteLine("Welcome, Wizard, to your Wizard Inventory!");

		List<string> inventory = new List<string>();
		inventory.add("wooden staff");
		inventory.add("wizard hat");
		inventory.add("cloth shoes");
		inventory.add("tabby cat");
		Console.WriteLine();
		bool done = false;
		String command = "go";
		while (!command.Equals("exit"))
		{
			command = Console.ReadLine.("Command:  ");
			Console.WriteLine();
			switch (command)
			{
				case "show":
					inventory.show(inventory);
					break;
				case "grab":
					inventory.add(inventory);
					break;
				case "edit":
					inventory.edit(inventory);
					break;
				case "drop":
					inventory.drop(inventory);
					break;
				case "exit":
					done = true;
					Console.WriteLine();
					Console.WriteLine("Faretheewell and safe travels, adventurer!");
					break;
				default:
					Console.WriteLine();
					Console.WriteLine("No, fool!  Try again!");
					break;
			}
		}
	}
	// Print lines - no input needed
	String command;
	private static void DisplayMenu() {
	{
		Console.WriteLine("Welcome, adventurers, to the Wizard Inventory Game!");
		Console.WriteLine();
		Console.WriteLine("COMMAND MENU: ");
		Console.WriteLine("show - Show all items");
		Console.WriteLine("grab - Grab an item");
		Console.WriteLine("edit - Edit an item");
		Console.WriteLine("drop - Drop an item");
		Console.WriteLine("exit - Exit program");
		Console.WriteLine();
	}
	private static void ShowInventory(List<String> inventory)
	{
		//		int oneBasedIndex = 1;
		foreach (String item : inventory)
		{
			Console.WriteLine(inventory.indexOf(item) + 1 + ".  " + item);
			//			oneBasedIndex++;
		}
	}

	private static void addItemToInventory(List<String> inventory)
	{

		if (inventory.size() > MAX_INVENTORY_SIZE)
		{
			Console.WriteLine("You are overburdened.  Drop one item.");
			return;
			Console.WriteLine("You are overburdened.  Leave one item behind.");
			return false;
		}
		String newItem = Console.Write("Name:  " + newItem);
		inventory.add(newItem);
		Console.WriteLine(newItem + " was added.");

		return true;
	}
}
