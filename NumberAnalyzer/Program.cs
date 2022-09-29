int loop = 1;
int userNumber = 0;

Console.WriteLine("What is your name?");
string? userName = Console.ReadLine();

Console.Clear();

while (loop == 1)
{
    Console.WriteLine($"Hello {userName} Please enter an integer between 1 and 100: ");
    userNumber = int.Parse(Console.ReadLine());

    while (userNumber <= 1 || userNumber >= 100)
    {
        Console.Clear();
        Console.WriteLine($"Sorry {userName}, {userNumber} is invalid. Please enter an integer between 1 and 100: ");
        userNumber = int.Parse(Console.ReadLine());
    }

    if (userNumber % 2 == 1 && userNumber < 60)
    {
        Console.Clear();
        Console.WriteLine("Odd and less than 60\n");
    }
    else if (userNumber % 2 == 0 && userNumber >= 2 && userNumber <= 24)
    {
        Console.Clear();
        Console.WriteLine("Even and less than 25\n");
    }
    else if (userNumber % 2 == 0 && userNumber >= 26 && userNumber <= 60)
    {
        Console.Clear();
        Console.WriteLine("Even and between 26 and 60 inclusive\n");
    }
    else if (userNumber % 2 == 0 && userNumber > 60)
    {
        Console.Clear();
        Console.WriteLine("Even and greater than 60\n");
    }
    else if (userNumber % 2 == 1 && userNumber > 60)
    {
        Console.Clear();
        Console.WriteLine("Odd and greater than 60\n");
    }

    Console.WriteLine($"Would you like to try another number {userName}? [y]/[n]");
    string? playAgain = Console.ReadLine()?.ToLower();

    if (playAgain != "y")
    {
        Console.Clear();
        Console.WriteLine("Goodbye!");
        loop = 0;
    }
    else
    {
        Console.Clear();
    }
}

Console.ReadKey();
