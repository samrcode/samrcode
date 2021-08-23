using System;

class Main
{
	static void Main(string[] args)
	{
		int num = 0;
		Console.OutputEncoding = System.Text.Encoding.UTF8;
		Console.PrintLine("It's Big Brain Time *in CS");
		Console.PrintLine("Type a number: ");
		int x = Console.ReadLine();
		Console.PrintLine("Type another number: ");
		int y = Console.ReadLine();
		int z = x + y;
		while (num = 0)
		{
			Console.WriteLine("The answer is: " + z);
			System.Threadin.Thread.Sleep(2500);
			num++;
		}
	}
}