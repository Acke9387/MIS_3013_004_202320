//Ask the user to provide input for what number they want to count by as well
//as up to which number.
//E.g. I wish to count by 3 up to 10.
//The output would be "3, 6, 9"

Console.WriteLine("What do you want to count by? >>");
int countBy = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What do you want to count to? >>");
int countTo = Convert.ToInt32(Console.ReadLine());

int count = countBy;

Console.WriteLine("\n\nWhile Loop Way");
while (count <= countTo)
{
    Console.WriteLine(count);
    count = count + countBy;
    // shortened way to write the same expression
    //count += countBy;
}


Console.WriteLine("\n\nFor Loop Way");

for (int i = countBy; i <= countTo; i = i + countBy)
{
    Console.WriteLine(i);
}