﻿//Create a dictionary that will hold multiple values.
//The key will be the course code (e.g. MIS3013, MIS3383, etc.)
//and the values will be all of the students final grades
//(e.g. 0.95, 0.8, etc.).
//
//Add at least 3 courses codes and at least 3 grades in each one.
//Calculate the average for each course code and output it to the user,
//make sure to format it as a percent.

#region
Dictionary<string, List<double>> courseGrades = new Dictionary<string, List<double>>();

courseGrades.Add("MIS3013", new List<double>());
courseGrades["MIS3013"].Add(0.95);
courseGrades["MIS3013"].Add(0.75);
courseGrades["MIS3013"].Add(0.65);
courseGrades["MIS3013"].Add(0.50);

courseGrades.Add("MIS3033", new List<double>());
courseGrades["MIS3033"].Add(1.0);
courseGrades["MIS3033"].Add(0.90);
courseGrades["MIS3033"].Add(0.95);

courseGrades.Add("MIS3383", new List<double>());
courseGrades["MIS3383"].Add(.90);
courseGrades["MIS3383"].Add(0.85);
courseGrades["MIS3383"].Add(0.80);

foreach (string courseCode in courseGrades.Keys)
{
    double courseSum = 0;
    foreach (double studentGrade in courseGrades[courseCode])
    {
        courseSum += studentGrade;
    }
    double courseAverage = courseSum / courseGrades[courseCode].Count;

    Console.WriteLine($"The average for course {courseCode} is {courseAverage.ToString("P")}");

}


#endregion



//Create parallel arrays, one will have the course subject
//(e.g. MIS, MATH, etc.) and the other will hold course numbers
//(e.g. 3033, 3013, etc.).
//
//Ask the user to input 3 for each, store them in the array.
//
//Then use a different loop to output the results to the user
//concatenated together (e.g. MIS3033, MATH3013).

#region Parallel Arrays
string[] subjects = new string[3];
int[] courseNumbers = new int[3];
for (int i = 0; i < subjects.Length; i++)
{
    Console.WriteLine("Please enter a subject >>");
    subjects[i] = Console.ReadLine();

    Console.WriteLine($"Please enter the course number for {subjects[i]} >>");
    courseNumbers[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine();
for (int i = 0;i < courseNumbers.Length; i++)
{
    Console.WriteLine($"{subjects[i]}-{courseNumbers[i]}");
}
#endregion


//Create a list that will hold all of the users grades.
//Keep prompting the user if they have another grade to enter
//until they say 'no'.
//Once you have all of the inputs, use a for each loop to
//iterate through the list and calculate the average.
//
//Output the users grade average.

#region List
List<double> grades = new List<double>();

do
{
    Console.WriteLine("Please enter a grade >>");
    grades.Add(Convert.ToDouble(Console.ReadLine()));

    Console.WriteLine("Do you have another grade to enter? yes or no >>");
} while (Console.ReadLine().ToLower() != "no");


double sum = 0;

foreach (int grade in grades)
{
    sum += grade;
}

double average = sum / grades.Count;

Console.WriteLine($"Your average exam score is {average.ToString("N")}");

#endregion

