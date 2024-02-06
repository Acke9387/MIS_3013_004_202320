Random rand = new Random();
int randomNumber = rand.Next(1, 3);

// for testing purposes
//Console.WriteLine(randomNumber);

const int HEADS = 1;
const int TAILS = 2;
const string DEVELOPER_NAME = "Professor Ackerman";

Console.WriteLine("Guess heads or tails? >>");
string usersGuess = Console.ReadLine();

int usersGuessAsNumber;

if (randomNumber == HEADS)
{
    Console.WriteLine("The coin came up heads.");
}
else
{
    Console.WriteLine("The coin came up tails.");
}

if (usersGuess == "heads")
{
    usersGuessAsNumber = HEADS;
}
else
{
    usersGuessAsNumber = TAILS;
}

if (usersGuessAsNumber == randomNumber)
{
    Console.WriteLine("Congratulations, you guessed correct!");
}
else
{
    Console.WriteLine("Sorry, you guessed wrong!");
}


Console.WriteLine($"This application was created by {DEVELOPER_NAME}.");
