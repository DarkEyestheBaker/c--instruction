using System;
using System.Collections.Generic;
using System.Text;

namespace ch03_proj_3_1_Temperature_Converter
{
	class Program
	{
		static void Main(string[] args)

		{
			Console.WriteLine("Welcome to the Temperature Converter!");
			//while loop
			String choice = "y";
			while (choice.Equals("y"))
			{

				Console.Write("Enter degrees in Fahrenheit: ");
				double fahrenheit = Convert.ToDouble(Console.ReadLine());

				double celsius = (fahrenheit - 32) * 5 / 9;
				Console.WriteLine("Degrees in Celsius: " + celsius);
				Console.WriteLine("Continue? (y/n)");
				choice = Console.ReadLine();

			}
			Console.WriteLine("Good-bye!");
		}
	}
}
