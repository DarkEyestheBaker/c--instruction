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

		List<String> inventory = new ArrayList<>();
		inventory.add("wooden staff");
		inventory.add("wizard hat");
		inventory.add("cloth shoes");
		inventory.add("tabby cat");
		Console.WriteLine();
		bool done = false;
		String command = "go";
		while (!command.EqualsIgnoreCase("exit"))
		{
			command = Console.ReadLine.("Command:  ");
			Console.WriteLine.println();
			switch (command)
			{
				case "show":
					showInventory(inventory);
					break;
				case "grab":
					addItemToInventory(inventory);
					break;
				case "edit":
					editInventory(inventory);
					break;
				case "drop":
					dropItemFromInventory(inventory);
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
	private static void printWelcomeMessage()
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
	private static void showInventory(List<String> inventory)
	{
		//		int oneBasedIndex = 1;
		for (String item : inventory)
		{
			Console.WriteLine(inventory.indexOf(item) + 1 + ".  " + item);
			//			oneBasedIndex++;
		}
	}

	private static void addItemToInventory(List<String> inventory)
	{
		private static boolean addItemToInventory(List<String> inventory)
		{
			if (inventory.size() > MAX_INVENTORY_SIZE)
			{
				Console.WriteLine("You are overburdened.  Drop one item.");
				return;
				Console.WriteLine("You are overburdened.  Leave one item behind.");
				return false;
			}
			String newItem = Console.getString("Name:  ");
			inventory.add(newItem);
			Console.WriteLine(newItem + " was added.");

			return true;
		}
