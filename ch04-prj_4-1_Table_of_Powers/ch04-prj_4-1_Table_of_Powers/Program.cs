using System;

namespace ch04_prj_4_1_Table_of_Powers
{
	class Program
	{

	
		static void Main(string[] args)
		{
			Console.WriteLine("Welcome to the Squares and Cubes Table!");
			String choice = "y";
			while (choice.Equals("y"))
			{

				int n = GetInt("Enter an integer: ");
				Console.WriteLine("Number\tSquared\tCubed");
				Console.WriteLine ("======\t=======\t=====");
				for (int i = 1; i <= n; i++) 
				{
					Console.WriteLine(i + "\t" +(i*i) + "\t" +(i*i*i));

				}
				Console.WriteLine();

				Console.Write("Continue?  (y/n) ");
				choice = Console.ReadLine();
				Console.WriteLine();



			}
			Console.WriteLine("Bye!");
		}
		private static int GetInt(String prompt) {
			int n = 0;
			Console.Write(prompt);
			n = int.Parse(Console.ReadLine());
			Console.WriteLine();
			return n;
		}
	}
}