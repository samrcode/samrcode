using System;

class SubtractProgram
{
	static void Main(string[] args)
	{
		Console.WriteLine("Math - Subtraction");
		Console.WriteLine("Type a number: ");
		int x = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Type another number: ");
		int y = Convert.ToInt32(Console.ReadLine());
		int z = x - y;
		Console.WriteLine("The answer is: " + z + ".");
		Console.WriteLine("Press any key to continue... ");
		Console.ReadKey();
	}
}