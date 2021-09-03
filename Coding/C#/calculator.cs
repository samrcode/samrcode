using System;

class Calculator
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Calculator");
		Console.WriteLine("Type an operator: ");
		string op = Console.ReadLine();
		Console.WriteLine("Type a number: ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Type another number: ");
		int y = Convert.ToInt32(Console.ReadLine());
		if (op == "+")
		{
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
		else if (op == "-")
		{
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
		else if (op == "*")
		{
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
		else if (op == "/")
		{
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
			Console.WriteLine("Something went wrong.");
		}
	}
}