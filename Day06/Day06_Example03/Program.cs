int[] scores = { 80, 90 };
try
{
    Console.WriteLine(scores[5]);
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("配列の範囲外です。");
}
