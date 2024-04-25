using Classes_Easter_Bunny;

string[] lines = File.ReadAllLines("Easter_Bunny.csv");

List<Bunny> bunnies = new List<Bunny>();

for (int i = 1; i < lines.Length; i++)
{
    //Name,Age,FavoriteColor,Location,EggCount,EggColor,BasketSize,DeliveryDate
    string[] pieces = lines[i].Split(',');
    string name = pieces[0];
    //...

    Bunny b = new Bunny(pieces[0], Convert.ToInt32(pieces[1]));
    //b.Name = pieces[0];
    //b.Age = int.Parse(pieces[1]);
    b.FavoriteColor = pieces[2];
    b.Location = pieces[3];
    b.EggCount = Convert.ToInt32(pieces[4]);
    b.EggColor = pieces[5];
    b.BasketSize = Convert.ToInt32(pieces[6]);
    b.DeliveryDate = pieces[7];

    bunnies.Add(b);
}
int totalEgg = 0;
foreach (Bunny b in bunnies)
{
    totalEgg += b.EggCount;
}
Console.WriteLine($"The total eggs from all Bunnies is {totalEgg.ToString("N")}");


Console.WriteLine($"\nAll the bunnies that are older than 75 are :");

foreach (Bunny b in bunnies)
{
    if (b.Age > 75)
    {
        Console.WriteLine("\t" + b);
    }
}

foreach (Bunny b in bunnies)
{
    //output where age is less than 20
    if (b.Age < 20)
    {
        Console.WriteLine("\t" + b);
    }
}

Console.WriteLine("\nWhat color do you want to check for the Bunnies Favorite color? >>");
string color = Console.ReadLine();

foreach (Bunny b in bunnies)
{
    if (b.FavoriteColor.ToLower() == color.ToLower())
    {
        Console.WriteLine("\t" + b);
    }
}