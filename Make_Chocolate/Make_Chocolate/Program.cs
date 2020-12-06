using System;

namespace Make_Chocolate
{
	class Program
	{
		public static int MakeChocolate(int small, int big, int goal)
		{
			if (small + (big * 5) < goal)
			{
				return -1;
			}
			else
			{
				for (int i = 0; i < big; i++) // int i = counter
				{
					if (goal >= 5)
					{
						goal -= 5;
					}

				}
				if (goal > small)
				{
					return -1;

				}
				else
				{
					return goal;
				}
			}



		}
		static void Main(string[] args)
		{

			Console.WriteLine(MakeChocolate(4, 1, 9));
			Console.WriteLine(MakeChocolate(4, 1, 10));
			Console.WriteLine(MakeChocolate(4, 1, 7));





		}

	}
}
