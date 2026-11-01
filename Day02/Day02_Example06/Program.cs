Console.Write("名前を入力してください: ");
string name = Console.ReadLine() ?? "";
Console.Write("年齢を入力してください: ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int age) && age >= 0 && age < int.MaxValue)
{
    Console.WriteLine($"{name}さんは来年{age + 1}歳です。");
}
else
{
    Console.WriteLine("年齢は0以上2147483646以下の整数で入力してください。");
}
