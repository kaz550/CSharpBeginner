Console.WriteLine(Add(2, 3));
Console.WriteLine(Add(1.5, 2.5));
Greet();
Greet("さくら");

int Add(int a, int b)
{
    return a + b;
}

double Add(double a, double b)
{
    return a + b;
}

void Greet(string name = "ゲスト")
{
    Console.WriteLine($"こんにちは、{name}さん");
}
