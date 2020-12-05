using System;
using ch07_product_manager.util;

namespace Pig_Dice_Coding_Challenge
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Soo-Wee!  Welcome to the Pig Dice Game, Y'all!");
			Console.WriteLine();
			String choice = "y";
			while (choice.Equals("y"))
			{
				Console.WriteLine("Each game consists of die rolls until a 1 is rolled.");
				Console.WriteLine("You can play as many games as you'd like to try and reach the highest score.");
				Console.WriteLine();
				int n = MyConsole.getInt("\nHow many games y'all wanna play?  ");
				int max = 0;
				for (int i = 0; i < n; i++)
				{
					int roll = 0;
					int total = 0;
					while (roll != 1)
					{
						Random rand = new Random();
						roll = rand.Next(1, 7);
						total += roll;
					}
					//Console.WriteLine("Game #" + i + " score: " + total);
					max = Math.Max(max, total);
					roll = 0;
					total = 0;
				}
				Console.WriteLine("====================");
				Console.WriteLine("Total games:\t" + n);
				Console.WriteLine("Max Score:\t" + max);
				Console.WriteLine("====================");
				Console.WriteLine();

					Console.Write("Wanna play again? (y/n) ");
					choice = Console.ReadLine();
					Console.WriteLine();
				}
				Console.WriteLine("I'm gonna head on back to the barn then.  See y'all later!");
			
			

		}
	}
}



