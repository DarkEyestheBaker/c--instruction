using System;

namespace ch05_Dice_Roller
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dice Roller!");
			String choice = "y";
			while (choice.Equals("y"))
			{
				var r = new Random();
				die1 = r.Next(6) + 1;
				die2 = r.Next(6) + 1;
				static void PrintSpecialMessage(int die1, int die2) 
				{

					if (die1 + die2 == 2) {
						Console.WriteLine("Snake eyes!");
						return die1 + die2;

					}
					else if (die1 + die2 == 12) {
						Console.WriteLine("Boxcars!");
						return die1 + die2;

					}
					else
					{
						return die1 + die2;

						Console.Write("Die 1: " + die1 + ", ");
						Console.Write("Die 2: " + die2 + ", ");
						Console.Write("Total: " + (die1 + die2));
						Console.WriteLine();
					}

					Console.WriteLine("Continue rolling? (y/n)");
					choice = Console.ReadLine();
					Console.WriteLine();
					Console.WriteLine("Bye!");
				}
			}
		}
	}
}

