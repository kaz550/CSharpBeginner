using System.IO;

string filePath = "memo.txt";

Console.Write("メモを入力してください: ");
string memo = Console.ReadLine() ?? "";

try
{
    File.WriteAllText(filePath, memo);
    Console.WriteLine("保存しました。");

    string savedMemo = File.ReadAllText(filePath);
    Console.WriteLine($"保存したメモ: {savedMemo}");
}
catch (IOException)
{
    Console.WriteLine("ファイルの読み書きに失敗しました。");
}
catch (UnauthorizedAccessException)
{
    Console.WriteLine("ファイルへのアクセスが許可されていません。");
}
