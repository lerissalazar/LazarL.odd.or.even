//Lerissa Lazar
//09-13-22
//Odd or even
//the computer will ask the user to input 2 numbers, the computer will then take those numbers and determine and tell
//the user if the number they put is odd or even.

Console.Clear();

bool loop = true;
while (loop)
{
    string? input;
    int num;
    bool validNum;
    Console.WriteLine("Enter a number and I will tell you if it's odd and even");
    input = Console.ReadLine();

    validNum = int.TryParse(input, out num);

    int remainder = num % 2;

    if (!validNum)
    {
        Console.WriteLine("That is not a number");
    }
    else if (remainder == 0)
    {
        Console.WriteLine($"{num} is an even number");
    }
    else if (remainder == 1)
    {
        Console.WriteLine($"{num} is an odd number");
    }

    Console.WriteLine("Would you like to try again? Yes or no?");
    
    string playAgain;
    bool validInput = false;
    while(!validInput)
    {
        playAgain = Console.ReadLine().ToLower();
        if(playAgain == "yes")
        {
            validInput = true;
        }
        else if(playAgain == "no")
        {
            validInput = true;
            loop = false;
            Console.WriteLine("Thank you for playing!");
        }
        else
        {
            validInput = false;
            Console.WriteLine("Invalid response, enter yes or no");
        }
    }
}
