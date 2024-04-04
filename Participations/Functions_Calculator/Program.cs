using System.Reflection.Metadata;

const string DEVELOPER_NAME = "Professor Ackerman";
string completionDate = "4/4/24";
DeveloperInformation(DEVELOPER_NAME, "MIS 3013", completionDate);

string userResponse;
string usePreviousAnswer = "no";
double answer = 0;
do
{
    Console.WriteLine("Do you want to Add, Subtract, Multiply or Divide? >>");
    string operation = Console.ReadLine();
    double val1;

    if (usePreviousAnswer == "no")
    {
        Console.WriteLine("What is the first value >>");
        val1 = Convert.ToDouble(Console.ReadLine());
    }
    else
    {
        val1 = answer;
    }

    Console.WriteLine("What is the second value >>");
    double val2 = Convert.ToDouble(Console.ReadLine());

    string symbol;

    if (operation.ToLower() == "add")
    {
        answer = Add(val1, val2);
        symbol = "+";
    }
    else if (operation.ToLower() == "subtract")
    {
        answer = Subtract(val1, val2);
        symbol = "-";
    }
    else if (operation.ToLower() == "multiply")
    {
        answer = Multiply(val1, val2);
        symbol = "*";
    }
    else if (operation.ToLower() == "divide")
    {
        answer = Divide(val1, val2);
        symbol = "/";
    }
    else
    {
        Console.WriteLine("Invalid operation");
        return;
    }

    Console.WriteLine($"{val1.ToString("N")} {symbol} {val2.ToString("N")} = {answer.ToString("N")}");

    Console.WriteLine("Do you want to perform another calculation? yes or no >>");
    userResponse = Console.ReadLine().ToLower();
    if (userResponse == "yes")
    {
        Console.WriteLine($"Do you want to use {answer} as your first value in the next calculation? yes or no>> ");
        usePreviousAnswer = Console.ReadLine().ToLower();
    }
} while (userResponse == "yes");
void DeveloperInformation(string devName, string className, string date)
{
    Console.WriteLine($"{devName} wrote this application on {date} for {className}.");
}

double Add(double leftOperand, double rightOperand)
{
    double answer = 0;
    answer = leftOperand + rightOperand;

    return answer;
}

double Subtract(double leftOperand, double rightOperand)
{
    double answer = 0;
    answer = leftOperand - rightOperand;

    return answer;
}

double Multiply(double leftOperand, double rightOperand)
{
    double answer = 0;
    answer = leftOperand * rightOperand;

    return answer;
}

double Divide(double leftOperand, double rightOperand)
{
    return leftOperand / rightOperand;
}