//Create two parallel arrays.
//
//The first will hold student id’s and the second will hold
//their overall GPA.  Ask the user for one of the id’s that
//they want to see the GPA for and then output it.

int[] studentIds = new int[3];
studentIds[0] = 1;
studentIds[1] = 2;
studentIds[2] = 3;
//for (int i = 0; i < studentIds.Length; i++)
//{
//    studentIds[i] = i+1;
//}
//                 0    1    2
double[] gpas = { 3.5, 4.0, 2.7 }; //new double[3];

//Console.WriteLine($"Student {studentIds[0].ToString("N")} has a gpa of {gpas[0].ToString("N2")}");
//Console.WriteLine($"Student {studentIds[1].ToString("N")} has a gpa of {gpas[1].ToString("N2")}");
//Console.WriteLine($"Student {studentIds[2].ToString("N")} has a gpa of {gpas[2].ToString("N2")}");


for (int i = 0; i < studentIds.Length; i++)
{
    Console.WriteLine($"Student {studentIds[i].ToString("N0")} has a gpa of {gpas[i].ToString("N2")}");
}