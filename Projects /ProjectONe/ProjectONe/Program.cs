// See https://aka.ms/new-console-template for more information

namespace Program
{
	static void Main(string[] args)
	{
		// no scout --> system.out.print
		//replaced with Console.write
		Console.WriteLine("Testing program one");

		//writeline vs write
		Console.Write("......output placement.....");
		Console.WriteLine("...1...2...2");
		//Console.ReadLine(); //keeps the console open

		//change the text /  background into colour
		Console.BackgroundColor = ConsoleColor.Blue;
		Console.WriteLine("Testing in blue>>>");

        Console.BackgroundColor = ConsoleColor.Green;
        Console.WriteLine("Testing in Green>>>");


        // to change the text col
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Testing in red>>>");

		Console.ReadLine();

    }

}

