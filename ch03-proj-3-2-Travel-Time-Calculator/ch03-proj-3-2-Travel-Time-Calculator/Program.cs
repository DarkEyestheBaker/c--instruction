using System;

namespace ch03_proj_3_2_Travel_Time_Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			double speed,  miles,  timespan;
			Console.WriteLine("Welcome to the Travel Time Calculator!");
			Console.WriteLine();

			String choice = "y";
			while (choice.Equals("y")) {
				Console.Write("Enter miles: ");
				miles = Convert.ToDouble(Console.ReadLine());
				Console.WriteLine();

				Console.Write("Enter miles per hour: ");
				speed = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine();

				Console.WriteLine();

				Console.WriteLine("Estimated travel time: ");
				Console.WriteLine("______________________");
				double d1 = miles / speed;
				var timeSpan = TimeSpan.FromMinutes(d1);
				int hh = timeSpan.Hours;
				int mm = timeSpan.Minutes;

				Console.WriteLine("Hours: " + hh);
				Console.WriteLine("Minutes: " + mm);
				Console.Write("Continue?  (y/n)");
				choice = Console.ReadLine();
			}
			Console.WriteLine("Good-bye!");
		}
	}
}
