Console.WriteLine(Calculator.Add(2, 3));
Console.WriteLine(Calculator.Add(1.5, 2.5));
Greet();
Greet("さくら");

static class Calculator
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static double Add(double a, double b)
    {
        return a + b;
    }
}

void Greet(string name = "ゲスト")
{
    Console.WriteLine($"こんにちは、{name}さん");
}
