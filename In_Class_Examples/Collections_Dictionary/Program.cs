Dictionary<int, double> studentGpas = new Dictionary<int, double>();
studentGpas.Add(1, 3.5);
studentGpas.Add(2, 4.0);
studentGpas.Add(3, 2.7);

string answer = "yes";
while (answer.ToLower() == "yes")
{
    Console.WriteLine("Do you want to add another student? yes or no >>");
    answer = Console.ReadLine().ToLower();
    if (answer == "yes")
    {
        Console.WriteLine("What is the student's id? >>");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("What is the student's GPA? >>");
        double gpa = Convert.ToDouble(Console.ReadLine());

        if (studentGpas.ContainsKey(id) == false)
        {
            studentGpas.Add(id, gpa);
        }
        else
        {
            // Business Decision
            studentGpas[id] = gpa;
        }
    } 
}

foreach (int studentID in studentGpas.Keys)
{
    Console.WriteLine($"Student {studentID.ToString("N0")} has a gpa of {studentGpas[studentID].ToString("N2")}");

}
