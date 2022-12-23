
GetAppInfo(); // return app info

GreetUser(); // Ask for username

    while (true) { 

    //Set correct number
    // int correctNumber = 7;

    //Create a New Random object
    Random random = new Random();

    //Set correct number
    int correctNumber = random.Next(1, 11);

    //Init guess var
    int guess = 0;

    // ask user for a number
    Console.WriteLine("Guess a number between 1 and 10");

    // while guess is not correct
    while(guess != correctNumber)
    {
        //Get users input
        string input = Console.ReadLine();

        //Make sure its a number
        if (!int.TryParse(input, out guess))
        {
            // Print error message
            PrintColorMessage(ConsoleColor.Red, "Please use a Number ");

            // keep going
            continue;
        }

        //Cast to int and put in guess
        guess = Int32.Parse(input);

   

        //match guess to correct number
        if(guess != correctNumber)
        {
            // Print error message
            PrintColorMessage(ConsoleColor.Red, "Wrong Number Please try again ");
        }

    }


    // Print Correct Message
    PrintColorMessage(ConsoleColor.Yellow, "You are CORRECT!!!");

        //Ask to play again
        Console.WriteLine("Play Again? [Y or N]");

        //Get answer
        string answer = Console.ReadLine().ToUpper();

    if (answer == "Y")
    {
        continue;
    }else if(answer == "N")
    {
        return;
    }
    else
    {
        return;
    }

    }


    // Get User Info
static void GetAppInfo()
{
    // Set Up vars
    string appName = "Number Guesser";
    string appVersion = "1.0.0";
    string appAuthor = "Donnie Angel";



    // change text color
    Console.ForegroundColor = ConsoleColor.Green;

    // Write out app info
    Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

    // reset text color
    Console.ResetColor();
}

//Ask and greet
static void GreetUser()
{
    // Ask username
    Console.WriteLine("Whats is your name?");

    //Get user input 
    string name = Console.ReadLine();

    Console.WriteLine("Hello {0}, Let's play a game...", name);
}

// Print Color Message
static void PrintColorMessage(ConsoleColor color, string message)
{
    // change text color
    Console.ForegroundColor = color;

    // Tell its not a number
    Console.WriteLine(message);

    // reset text color
    Console.ResetColor();
}


