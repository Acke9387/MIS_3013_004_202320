
//prompt the user to provide us the number of bank accounts they have
Console.WriteLine("How many bank accounts do you have? >>");
//get the input and convert their answer to a string so we can validate
string answer = Console.ReadLine();
int numberOfAccounts;

while (int.TryParse(answer, out numberOfAccounts) == false)
{
    Console.WriteLine("Incorrect number of accounts.  Please enter a valid integer value");
    answer = Console.ReadLine();
}

double total = 0;
for (int i = 0; i < numberOfAccounts; i++)
{
    Console.WriteLine($"What is the balance of the {i.ToString("N")} bank account?");
    total += Convert.ToDouble(Console.ReadLine());
}

//calculate the average by dividing the total by the number of accounts that they have
double average = total / numberOfAccounts;

//output the total of all their accounts
Console.WriteLine($"The total of all your accounts is {total.ToString("C")}");

// check to see if the average is greater than 5000.  If it is, we want to output the average in a different color
if (average > 5000)
{
    Console.BackgroundColor = ConsoleColor.Red;
    Console.ForegroundColor = ConsoleColor.Green;
}
Console.WriteLine($"The average of all your accounts is {average.ToString("C")}");