Console.Write("年齢を入力してください: ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int age))
{
    Console.WriteLine($"入力された年齢は{age}歳です。");
}
else
{
    Console.WriteLine("整数で入力してください。");
}
