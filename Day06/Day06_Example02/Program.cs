Console.Write("割る数を入力してください: ");
string input = Console.ReadLine() ?? "";

try
{
    int divisor = int.Parse(input);
    int answer = 100 / divisor;
    Console.WriteLine($"答えは{answer}です。");
}
catch (FormatException)
{
    Console.WriteLine("整数を入力してください。");
}
catch (DivideByZeroException)
{
    Console.WriteLine("0では割れません。");
}
catch (OverflowException)
{
    Console.WriteLine("入力された整数が大きすぎるか小さすぎます。");
}
