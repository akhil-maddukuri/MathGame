using System;
namespace MathGame
{
	public class Helpers
	{
		internal static string GetName()
        {
            Console.WriteLine("Enter your name:");
            var name = Console.ReadLine();

            return name;
        }
    }
}

