using System.IO;

string path = "study-log.txt";
File.WriteAllText(path, "1日目を学習しました。" + Environment.NewLine);
File.AppendAllText(path, "2日目を学習しました。" + Environment.NewLine);
Console.Write(File.ReadAllText(path));
