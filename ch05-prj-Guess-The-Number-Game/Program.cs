using System;

namespace ch05_prj_Guessing_Game
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Guess The Numbers Game!");
			Console.WriteLine();
			string choice = "y";
			while(choice.Equals("y")) {

			// Declare Random Instance
			var r = new Random();
			int numToGuess = r.Next(1, 101);

			Console.WriteLine (numToGuess);
			int userGuess = 0;
			int numGuesses = 0;
			Console.WriteLine("I'm thinking of a whole number from 1 to 100.");
			Console.WriteLine("What's your guess?");
			while (userGuess != numToGuess)
			{
				numGuesses++;
				//Replace Console.getInt w/Console.ReadLine and Parse
				userGuess = int.Parse(Console.ReadLine());

				if (userGuess > (10 + numToGuess))
				{
					Console.WriteLine("Way too high!");
				}
				else if (userGuess > numToGuess)
				{
					Console.WriteLine("Too high!");
				}
				else if (userGuess < (numToGuess - 10))
				{
					Console.WriteLine ("Way too low!");
				}
				else if (userGuess < numToGuess)
				{
					Console.WriteLine ("Too low!");
				}
				else
				{
					Console.WriteLine("You got it in " + numGuesses + " tries!");
				}
			}
				Console.WriteLine();
				Console.Write("Want to play again? (y/n) ");
				choice = Console.ReadLine();
				Console.WriteLine();

			}
			Console.WriteLine("I guess I'll see you around!  (See what I did there?)  Bye!");
		}


	}

}

