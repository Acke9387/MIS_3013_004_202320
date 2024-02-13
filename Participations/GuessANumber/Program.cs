
Random r = new Random();

// Totally blanked on how to let the user define the min/max
//int randomNumber = r.Next(Console.ReadLine());

Console.WriteLine("Please define the minimum number >>");
string answer = Console.ReadLine();
int min;
bool isValidInt = int.TryParse(answer, out min);
while (isValidInt == false)
{
    Console.WriteLine("Please give a valid integer for the minimum>>");
    answer = Console.ReadLine();
    
    isValidInt = int.TryParse(answer, out min);
}

Console.WriteLine("Please define the maximum number >>");
answer = Console.ReadLine();
int max =0;// = Convert.ToInt32(Console.ReadLine());
while (isValidInt == false)
{
    Console.WriteLine("Please give a valid integer for the maximum>>");
    answer = Console.ReadLine();

    isValidInt = int.TryParse(answer, out max);
}
// generate a random # between min and max, added 1 so it would include the maxvalue
int randomNumber = r.Next(min, max + 1);

//Console.WriteLine("What is your guess for the random number >>");
int guess;// = Convert.ToInt32(Console.ReadLine());

//while (guess != randomNumber)
//{
//    Console.WriteLine("Sorry you guessed wrong, try guessing again >>");
//    guess = Convert.ToInt32(Console.ReadLine());

//}

do
{
    Console.WriteLine("Try guessing the randomn number >>");
    guess = Convert.ToInt32(Console.ReadLine());
} while (guess != randomNumber);

Console.WriteLine("Congratulations, you guessed correctly!");
Console.WriteLine();
