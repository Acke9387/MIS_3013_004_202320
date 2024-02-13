//             012345678910
string name = "hENRY JAMES";
// Output the name as all lower-case
string lowerName = name.ToLower();
Console.WriteLine(lowerName);

string firstLetter = name.Substring(0, 1).ToUpper();
firstLetter = firstLetter.ToUpper();
// Using array indexing
//firstLetter = firstLetter[0].ToString();
//Console.WriteLine(firstLetter);

int spaceLocation = name.IndexOf(' ');
//Console.WriteLine(spaceLocation);
string firstLetterOfLastName = name.Substring(spaceLocation+1, 1);
//Console.WriteLine(firstLetterOfLastName);

string initials = $"{firstLetter}.{firstLetterOfLastName}.";
Console.WriteLine(initials);
// Print the initials of the name, capital with a .

