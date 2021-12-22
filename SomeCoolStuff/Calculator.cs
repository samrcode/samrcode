/*
C# Calculator
*/

using System;

class Calculator
{
	public static void Calculate(int X, int Y)
	{
		// Calculates values and things
		if (Op == "1")
		{
			// Addition
			try
			{
				int Z = X + Y;
				Console.WriteLine("The sum is: " + Convert.ToString(Z));
			}
			catch (Exception E)
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		else if (Op == "2")
		{
			// Subtraction
			try
			{
				int Z = X - Y;
				Console.WriteLine("The sum is: " + Convert.ToString(Z));
			}
			catch (Exception E)
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		else if (Op == "3")
		{
			// Multiplication
			try
			{
				int Z = X * Y;
				Console.WriteLine("The sum is: " + Convert.ToString(Z));
			}
			catch (Exception E)
			{
				Console.WriteLine("Something went wrong.");
			}
		}
		else if (Op == "4")
		{
			// Division
			try
			{
				int Z = X / Y;
				Console.WriteLine("The sum is: " + Convert.ToString(Z));
			}
			catch (Exception E)
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
	public static void Main(string[] args)
	{
		Console.WriteLine("Calculator");
		Console.WriteLine("Type an operator: ");
		Console.WriteLine("[1] Addition");
		Console.WriteLine("[2] Subtraction");
		Console.WriteLine("[3] Multiplication");
		Console.WriteLine("[4] Division");
		string Op = Console.ReadLine();
		Console.WriteLine("Type a number: ");
		int X = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Type another number: ");
		int Y = Convert.ToInt32(Console.ReadLine());
		Calculate(Op, X, Y)
	}
}
