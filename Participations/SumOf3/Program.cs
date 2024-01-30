

Console.WriteLine("Please enter your first number >>");
string answer = Console.ReadLine();
double val1 = Convert.ToDouble(answer);

Console.WriteLine("Please enter your second number >>");
answer = Console.ReadLine();
double val2 = Convert.ToDouble(answer);

Console.WriteLine("Please enter your third number >>");
answer = Console.ReadLine();
double val3 = Convert.ToDouble(answer);

double total = val1 + val2 + val3;

Console.WriteLine($"The sum of your numbers\n{val1.ToString("N3")} + {val2.ToString("N3")} + {val3.ToString("N3")} = {total.ToString("N3")}");

const double MAGIC_NUMBER = 7.777;

double magicTotal = total * MAGIC_NUMBER;

Console.WriteLine($"The magic total is {magicTotal.ToString("N3")}");
