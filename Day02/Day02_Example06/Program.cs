Console.Write("名前を入力してください: ");
string name = Console.ReadLine() ?? "";
Console.Write("年齢を入力してください: ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"{name}さんは来年{age + 1}歳です。");
}
else
{
    Console.WriteLine("年齢は整数で入力してください。");
}
