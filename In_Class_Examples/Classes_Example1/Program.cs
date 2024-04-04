using Classes_Example1;

Rectangle r = new Rectangle();
r.Width = 5;
r.Length = 10;

Rectangle r1 = new Rectangle();
r1.Length = 500;
r1.Width = 1;

Console.WriteLine($"The area for r is {r.CalculateArea()}");

double r1Perimet = r1.CalculatePerimeter();


Console.WriteLine($"The perimeter for r1 is {r1Perimet}");