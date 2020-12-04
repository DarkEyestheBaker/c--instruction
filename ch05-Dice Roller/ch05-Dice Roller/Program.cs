using System;

namespace ch05_Dice_Roller
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Dice Roller!");
			Console.WriteLine();
			String choice = "y";
			while (choice.Equals("y"))
			{
				var r = new Random();
				var n1 = r.Next(6) + 1;
				var n2 = r.Next(6) + 1;
				{

					if (n1 + n2 == 2) {
						Console.WriteLine("Snake eyes!  You rolled two ones!");

					}
					else if (n1 + n2 == 12) {
						Console.WriteLine("Boxcars! You rolled two sixes!");

					}
					else
					{
						Console.Write("Die 1: " + n1 + ", ");
						Console.Write("Die 2: " + n2 + ", ");
						Console.Write("Total: " + (n1 + n2));
						Console.WriteLine();
					}					
				}
				Console.WriteLine();
				Console.Write("Continue rolling? (y/n) ");
				choice = Console.ReadLine();
				Console.WriteLine();

			}
			Console.WriteLine("Bye!");
		}
	}
}

