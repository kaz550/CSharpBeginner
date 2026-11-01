const int answer = 7;
Console.WriteLine("1から10までの数字を当ててください。");

while (true)
{
    Console.Write("予想した数字: ");
    string input = Console.ReadLine() ?? "";

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("整数を入力してください。");
        continue;
    }

    if (guess < 1 || guess > 10)
    {
        Console.WriteLine("1から10までで入力してください。");
        continue;
    }

    if (guess < answer)
    {
        Console.WriteLine("もっと大きい数字です。");
    }
    else if (guess > answer)
    {
        Console.WriteLine("もっと小さい数字です。");
    }
    else
    {
        Console.WriteLine("正解です！");
        break;
    }
}
