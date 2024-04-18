using Classes_ToyBox;
List<ToyBox> toyBoxes = new List<ToyBox>();

do
{
    ToyBox tb = new ToyBox();
    Console.WriteLine("Who is the owner of the ToyBox? >>");
    tb.Owner = Console.ReadLine();

    Console.WriteLine("Where is the ToyBox located? >>");
    tb.Location = Console.ReadLine();

    do
    {
        Toy t = new Toy();
        Console.WriteLine("What is the name of the toy? >>");
        t.Name = Console.ReadLine();
        Console.WriteLine("Who is the manufacturer of the toy? >>");
        t.Manufacturer = Console.ReadLine();
        Console.WriteLine("What is the price of the toy? >>");
        t.Price = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("What are your notes about the toy? >>");
        t.SetNotes(Console.ReadLine());
        tb.Toys.Add(t);
        Console.WriteLine($"Do you have another Toy to add to {tb.Owner}'s ToyBox? yes or no >>");

    } while (Console.ReadLine().ToLower()[0] == 'y');

    toyBoxes.Add(tb);
    Console.WriteLine("Do you have another ToyBox to enter information for? yes or no >>");
} while (Console.ReadLine().ToLower()[0] == 'y');

foreach (ToyBox toybox in toyBoxes)
{
    Console.WriteLine($"The ToyBox is owned by {toybox.Owner} and is located in {toybox.Location}");
    foreach (Toy t in toybox.Toys)
    {
        Console.WriteLine(t);
    }
}