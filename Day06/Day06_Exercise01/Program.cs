using System.IO;

string filePath = "words.txt";
string words = "継続は力なり";

File.WriteAllText(filePath, words);
Console.WriteLine(File.ReadAllText(filePath));
