using System.Collections.Generic;

string sentence = "Programming today is a race between software engineers striving to build bigger and better idiot-proof programs, and the universe trying to build bigger and better idiots. So far, the universe is winning.";

// Output to the user the starting sentence
Console.WriteLine(sentence);

Console.WriteLine("Please give me a word that you want to change from the sentence >>");
string searchWord = Console.ReadLine();

Console.WriteLine($"What do you want to change {searchWord} to? >>");
string changeWord = Console.ReadLine();


if (sentence.Contains(searchWord) == true)
{
    Console.WriteLine($"Sentence contains {searchWord}");
    string correctedSentence = sentence.Replace(searchWord, changeWord);
    Console.WriteLine(correctedSentence);
}
else
{
    Console.WriteLine($"Sorry, I could not find your word {searchWord}.");

    for (int i = searchWord.Length - 1; i >= 0; i--)
    {
        Console.Write(searchWord[i]);
    }
    Console.WriteLine();


}