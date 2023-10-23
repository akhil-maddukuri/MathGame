string name = GetName();
var date = System.DateTime.Now;
var random = new Random();

var previousGames = new List<String>();

Menu();

void Menu()
{
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

                    string res = AdditionGame();

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

                    string res = SubstractGame();

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

                    string res = MultiplicationGame();

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

                    string res = DivisionGame();

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
                foreach (string s in previousGames)
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

string SubstractGame()
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


string DivisionGame()
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

string MultiplicationGame()
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

String AdditionGame()
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



string GetName()
{
    Console.WriteLine("Enter your name:");
    var name = Console.ReadLine();

    return name;
}

