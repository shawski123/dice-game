while (true)
{
    Console.Clear();

    int round = 1;
    Random roll = new();

    int pRoll;
    int cRoll;

    int win = 0;
    int lose = 0;

    Console.WriteLine("Dice Game");
    Console.WriteLine("\nIn this game you and a computer Rival will face off in 10 rounds.");
    Console.WriteLine("You will each roll a 6-sided dice, and the player.");
    Console.WriteLine("The highest dice value will win the round.");
    Console.WriteLine("The player who wins the most rounds wins the game. Good luck!\n");

    Console.Write("Press any key to start...");

    Console.ReadKey(true);


    for (int i = 0; i < 10; i++)
    {
        cRoll = roll.Next(1, 7);
        pRoll = roll.Next(1, 7);

        Console.WriteLine("\n\nRound " + round + "\n");
        Console.WriteLine("Rival rolled a " + cRoll);
        Console.Write("Press any key to roll the dice...");
        Console.ReadKey(true);

        Console.WriteLine("\nYou rolled a " + pRoll);


        if (cRoll == pRoll)
        {

            Console.WriteLine("The round is a draw!");
        }
        else if (cRoll > pRoll)
        {

            Console.WriteLine("The Rival won this round.");
            lose++;
        }
        else if (cRoll < pRoll)
        {

            Console.WriteLine("You won this round.");
            win++;
        }
        round++;
        Console.ResetColor();


        Console.WriteLine("The score is now - You : " + win + ". Rival : " + lose + ".");
        Console.Write("Press any key to continue...");


        Console.ReadKey(true);


    }
    Console.Clear();
    if (win > lose)
    {
        while (true)
        {
            Console.WriteLine("You have won!");

            Console.Write("\nPlay again? [y]es / [n]o: ");
            string option = Console.ReadLine();

            if (option.ToUpper() == "yes".ToUpper() || option.ToUpper() == "y".ToUpper())
            {
                break;
            }
            else if (option.ToUpper() == "no".ToUpper() || option.ToUpper() == "n".ToUpper())
            {
                Console.WriteLine("\nClosing game...");
                await Task.Delay(1000);

                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nInvalid\n");
            }



        }
    }
    else if (win < lose)
    {
        while (true)
        {
            Console.WriteLine("The Rival has won!");

            Console.Write("\nPlay again? [y]es / [n]o: ");
            string option = Console.ReadLine();

            if (option.ToUpper() == "yes".ToUpper() || option.ToUpper() == "y".ToUpper())
            {
                break;
            }
            else if (option.ToUpper() == "no".ToUpper() || option.ToUpper() == "n".ToUpper())
            {
                Console.WriteLine("\nClosing game...");
                await Task.Delay(1000);

                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("\nInvalid\n");
            }



        }

    }
    else if (win == lose)
    {
        Console.WriteLine("The game was a draw, playing again...");
        await Task.Delay(1000);
    }

}

