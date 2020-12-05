using System;

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
				Console.WriteLine("How many games y'all wanna play? (1-5) ");
					int numGames = Console.ReadLine(1,6);

				// Declare random instance
				var r = new Random();
				int pigRoll = r.Next(6) + 1;
				{
					for (int i = 0; i < pigRoll; i++)
						if (pigRoll != 1)
					{



					} else if (n1 == 1)
					{
							Console.WriteLine("Your total score is: " + );
					}
					else
					{
						Console.Write(" ", + i++);
						Console.WriteLine();
					}

				}
				Console.WriteLine();
				Console.Write("Wanna play again? (y/n) ");
				choice = Console.ReadLine();
				Console.WriteLine();

			}
			Console.WriteLine("I'm gonna head on back to the barn then.  See y'all later!");
		}
	}
}

