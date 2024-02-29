List<string> favoriteFruits = new List<string>();

favoriteFruits.Add("banana");
favoriteFruits.Add("grapes");
favoriteFruits.Add("oranges");
Console.WriteLine("My favorite fruits are: ");


//for (int i = 0; i < favoriteFruits.Count; i++)
//{
//    favoriteFruits[i] = favoriteFruits[i] + ".";
//    Console.WriteLine(favoriteFruits[i]);
//}

foreach (string fruit in favoriteFruits)
{
	if (fruit.ToLower()[0] == 'b')
	{
		Console.WriteLine(fruit); 
	}
}
