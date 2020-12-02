using System;

namespace ch03_proj_3_2_Travel_Time_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			int speed, miles, hours;
			Console.WriteLine("Welcome to the Travel Time Calculator!");
			Console.WriteLine();

			String choice = "y";
			while (choice.Equals("y")) {
				Console.Write("Enter miles: ");
				miles = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				Console.Write("Enter miles per hour: ");
				speed = Convert.ToInt32(Console.ReadLine());

				Console.WriteLine();
				Console.WriteLine();

				Console.WriteLine("Estimated travel time: ");
				Console.WriteLine("______________________");
				hours = miles / speed;
				Console.WriteLine("Hours: " + hours);
				Console.WriteLine("Continue?  (y/n)");
				choice = Console.ReadLine();
			}
			Console.WriteLine("Good-bye!");
		}
	}
}
