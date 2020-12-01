using System;

namespace ch02_proj_2_2_student_registration
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Student Registration Form!");
			{
				Console.Write("Enter first name: ");
				String firstName = Console.ReadLine();
				Console.WriteLine(firstName);

				Console.Write("Enter last name: ");
				String lastName = Console.ReadLine();
				Console.WriteLine(lastName);

				Console.Write("Enter year of birth: ");
				double birthYear = Console.ReadLine();
				Console.WriteLine(birthYear);

				Console.WriteLine();

				Console.WriteLine("Welcome " + firstName + lastName + "!");
				Console.WriteLine("Your registration is complete.");
				Console.WriteLine("Your temporary password is: " + firstName + "*" + birthYear);

		} 
	}
}
