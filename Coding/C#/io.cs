using System;

class IO
{
	static void Main(string[] args)
	{
		int hello = 0;
		Console.WriteLine("Input and Output");
		while (hello < 10000)
		{
			Console.WriteLine("Put in some input: ");
			string x = Console.ReadLine();
			Console.WriteLine("Your input was: " + x);
			hello++;
		}
		
	}
}