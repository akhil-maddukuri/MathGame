using System;
namespace MathGame
{
	internal class GameEngine
	{
        Random random; 
        internal List<string> previousGames;

        internal GameEngine()
        {
            this.random = new Random();
            this.previousGames = new List<string>();
        }

        internal string SubstractGame()
        {
            int operator1 = random.Next(1, 9);
            int operator2 = random.Next(1, 9);

            Console.WriteLine($"{operator1} - {operator2} = ");
            var result = Console.ReadLine();

            try
            {


                if (int.Parse(result) == operator1 - operator2)
                {
                    previousGames.Add($"{operator1} - {operator2} = {result}");
                    return "true";

                }


            }

            catch
            {
                return "except";
            }

            previousGames.Add($"{operator1} - {operator2} = {result}");
            return "false";
        }


        internal string DivisionGame()
        {
            int operator2 = random.Next(1, 9);
            int operator1 = random.Next(1, 100) * operator2;




            Console.WriteLine($"{operator1} / {operator2} = ");
            var result = Console.ReadLine();

            try
            {


                if (int.Parse(result) == operator1 / operator2)
                {
                    previousGames.Add($"{operator1} / {operator2} = {result}");
                    return "true";
                }


            }

            catch
            {
                return "except";
            }

            previousGames.Add($"{operator1} / {operator2} = {result}");
            return "false";
        }

        internal string MultiplicationGame()
        {
            int operator1 = random.Next(1, 9);
            int operator2 = random.Next(1, 9);

            Console.WriteLine($"{operator1} * {operator2} = ");
            var result = Console.ReadLine();

            try
            {



                if (int.Parse(result) == operator1 * operator2)
                {
                    previousGames.Add($"{operator1} * {operator2} = {result}");
                    return "true";
                }


            }

            catch
            {
                return "except";
            }

            previousGames.Add($"{operator1} * {operator2} = {result}");
            return "false";
        }

        internal String AdditionGame()
        {
            int operator1 = random.Next(1, 9);
            int operator2 = random.Next(1, 9);

            Console.WriteLine($"{operator1} + {operator2} = ");
            var result = Console.ReadLine();

            try
            {


                if (int.Parse(result) == operator1 + operator2)
                {
                    previousGames.Add($"{operator1} + {operator2} = {result}");
                    return "true";
                }


            }

            catch
            {
                return "except";
            }

            previousGames.Add($"{operator1} + {operator2} = {result}");
            return "false";
        }

    }
}

