using System;
namespace MathGame
{
	internal class Menu
	{
        GameEngine gameEngine;


        internal Menu()
        {
            this.gameEngine = new GameEngine();
        }
		internal void ShowMenu(string name,DateTime date)
		{
			Console.WriteLine($"Hello {name}. Welcome to an amazing game on {date}");
            while (true)
            {
                bool exit = false;
                Console.WriteLine("Select the game type:\n 1. Addition \n 2. Substraction \n 3. Multiplication \n 4. Division \n 5. Display previous games \n 6. Exit Game");
                int gameType = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Your game type is set, Press any aplhabet to change game type or exit");


                switch (gameType)
                {

                    case 1:

                        while (true)
                        {

                            string res = gameEngine.AdditionGame();

                            if (res == "true")
                            {
                                Console.WriteLine("Right Answer :)");
                            }
                            else if (res == "false")
                            {
                                Console.WriteLine("Wrong Answer :(");

                            }
                            else
                            {
                                break;
                            }
                            System.Threading.Thread.Sleep(100);

                        }


                        break;
                    case 2:
                        while (true)
                        {

                            string res = gameEngine.SubstractGame();

                            if (res == "true")
                            {
                                Console.WriteLine("Right Answer :)");
                            }
                            else if (res == "false")
                            {
                                Console.WriteLine("Wrong Answer :(");

                            }
                            else
                            {
                                break;
                            }
                            System.Threading.Thread.Sleep(100);

                        }

                        break;
                    case 3:

                        while (true)
                        {

                            string res = gameEngine.MultiplicationGame();

                            if (res == "true")
                            {
                                Console.WriteLine("Right Answer :)");
                            }
                            else if (res == "false")
                            {
                                Console.WriteLine("Wrong Answer :(");

                            }
                            else
                            {
                                break;
                            }
                            System.Threading.Thread.Sleep(100);

                        }

                        break;
                    case 4:

                        while (true)
                        {

                            string res = gameEngine.DivisionGame();

                            if (res == "true")
                            {
                                Console.WriteLine("Right Answer :)");
                            }
                            else if (res == "false")
                            {
                                Console.WriteLine("Wrong Answer :(");

                            }
                            else
                            {
                                break;
                            }
                            System.Threading.Thread.Sleep(100);

                        }

                        break;
                    case 5:
                        foreach (string s in gameEngine.previousGames)
                        {
                            Console.WriteLine(s);
                        }
                        break;
                    case 6:
                        exit = true;
                        break;


                }
                if (exit)
                    break;

            }

            Console.WriteLine("Game Over!!!");


        }
	}
}

