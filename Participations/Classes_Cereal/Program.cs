
using Classes_Cereal;

string[] linesOfFile = File.ReadAllLines("Cereal_Data.txt");

List<Cereal> cereals = new List<Cereal>();

for (int i = 1; i < linesOfFile.Length; i++)
{
    Cereal c = new Cereal();
    //  0         1        2      3
    //name|manufacturer|calories|cups 
    string[] pieces = linesOfFile[i].Split('|');
    c.Name = pieces[0];
    c.Manufacturer = pieces[1];
    c.Calories = Convert.ToDouble(pieces[2]);
    c.Cups = Convert.ToDouble(pieces[3]);

    cereals.Add(c);
}

Console.WriteLine("Cereals with serving size of 1 cup or more");
foreach (Cereal cereal in cereals)
{
    if (cereal.Cups >= 1)
    {
        Console.WriteLine("\t" + cereal);
    }
}

Console.WriteLine("\nCereals with 100 calories or less per serving");
foreach (Cereal cereal in cereals)
{
    if (cereal.Calories < 100)
    {
        Console.WriteLine("\t" + cereal);
    }
}