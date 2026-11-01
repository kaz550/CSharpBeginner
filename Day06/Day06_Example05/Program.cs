using System.IO;

string filePath = "message.txt";

if (File.Exists(filePath))
{
    string message = File.ReadAllText(filePath);
    Console.WriteLine(message);
}
else
{
    Console.WriteLine("まだ保存ファイルがありません。");
}
