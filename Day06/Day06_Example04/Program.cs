using System.IO;

string filePath = "message.txt";
string message = "C#の学習を続けています。";

File.WriteAllText(filePath, message);
Console.WriteLine("ファイルに保存しました。");
