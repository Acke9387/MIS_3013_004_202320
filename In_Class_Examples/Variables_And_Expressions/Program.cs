//Welcome the user to your application
//and prompt the user to enter their name.
//
//Prompt the user, while using their name,
//for their total monthly income as well as
//their total monthly expenses.
//
//Output the difference between the two values.


//Console.WriteLine("Welcome to my application!\nWhat is your name? >>");
Console.WriteLine("Welcome to my application!");

Console.WriteLine("What is your name? >>");
string firstName = Console.ReadLine();

//Console.WriteLine($"{firstName}, what is your monthly income? >>");
Console.WriteLine(firstName + ", what is your monthly income? >>");
string monthlyIncomeAsString = Console.ReadLine();
double monthlyIncome = Convert.ToDouble(monthlyIncomeAsString);

Console.WriteLine($"{firstName}, what is your monthly expenses? >>");
double monthlyExpenses = Convert.ToDouble(Console.ReadLine());

double netTotal = monthlyIncome - monthlyExpenses;

Console.WriteLine($"The difference in income and expenses is {netTotal.ToString("C10")}");