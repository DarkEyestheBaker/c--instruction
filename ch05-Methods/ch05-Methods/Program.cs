using System;

namespace ch05_Methods
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Call some methods!");
			//Prompt user to enter whole number
			//Convert input to a number
			//print the number
			//in C# int = Int32
			int n = GetInt("Enter a whole number: ");
			Console.WriteLine("You entered the number: " + n);

			int age = GetInt("Enter actor's age: ");
			Console.WriteLine("Actor's age is: " + age);

			Console.WriteLine("Bye!");

		}

		private static int GetInt(String prompt) {
			Console.Write(prompt);
			int n = int.Parse(Console.ReadLine());
			return n;
		}
	}
}
