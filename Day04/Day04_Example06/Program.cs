int[] scores = { 80, 65, 90 };
int total = CalculateTotal(scores);
double average = (double)total / scores.Length;

Console.WriteLine($"合計: {total}");
Console.WriteLine($"平均: {average:F1}");

int CalculateTotal(int[] values)
{
    int sum = 0;
    foreach (int value in values)
    {
        sum += value;
    }
    return sum;
}
