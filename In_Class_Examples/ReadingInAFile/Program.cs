string[] contentsOfBook = File.ReadAllLines("Greatest wonders of the world by Esther Singleton and Esther Singleton.txt");

foreach (string line in contentsOfBook)
{
	Console.WriteLine(line); 
}

// The for loop equivalent of a ForEach
for (int i = 0; i < contentsOfBook.Length; i++)
{
	string line = contentsOfBook[i];
    Console.WriteLine(line);
}
