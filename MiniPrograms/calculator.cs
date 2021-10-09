/*
C# Calculator
*/

using System;

class Calculator
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Calculator");
		Console.WriteLine("Type an operator: ");
		Console.WriteLine("[1] Addition");
		Console.WriteLine("[2] Subtraction");
		Console.WriteLine("[3] Multiplication");
		Console.WriteLine("[4] Division");
		string op = Console.ReadLine();
		Console.WriteLine("Type a number: ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Type another number: ");
		int y = Convert.ToInt32(Console.ReadLine());
		if (op == "1")
		{
			// Addition
			try
			{
				int z = x + y;
				Console.WriteLine("The sum is: " + z);
			}
			catch (Exception e)
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		else if (op == "2")
		{
			// Subtraction
			try
			{
				int z = x - y;
				Console.WriteLine("The sum is: " + z);
			}
			catch (Exception e)
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		else if (op == "3")
		{
			// Multiplication
			try
			{
				int z = x * y;
				Console.WriteLine("The sum is: " + z);
			}
			catch (Exception e)
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		else if (op == "4")
		{
			// Division
			try
			{
				int z = x / y;
				Console.WriteLine("The sum is: " + z);
			}
			catch (Exception e)
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		else
		{
			// Error
			Console.WriteLine("Something went wrong.");
		}
	}
}
