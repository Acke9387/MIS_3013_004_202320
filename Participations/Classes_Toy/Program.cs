using Classes_Toy;

List<Toy> toys = new List<Toy>();

Toy myToy = new Toy();
myToy.Name = "Switch";
myToy.Manufacturer = "Nintendo";
myToy.Price = 299.99;
myToy.SetNotes("Fun for all ages");

toys.Add(myToy);

//Console.WriteLine($"{myToy.Name} is made by {myToy.Manufacturer} and sells for {myToy.Price.ToString("C")}\n{myToy.GetNotes()}");
//Console.WriteLine(myToy);

Toy myToy2 = new Toy("Barbie", "Mattel", 25.25, "Perfect toy for your kid");

toys.Add(myToy2);
//Console.WriteLine(myToy2);

foreach (Toy toy in toys)
{
    Console.WriteLine(toy);
}