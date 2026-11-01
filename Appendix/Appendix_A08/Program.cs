try
{
    int number = int.Parse("abc");
    Console.WriteLine(number);
}
catch (FormatException)
{
    Console.WriteLine("数値に変換できません。");
}
finally
{
    Console.WriteLine("処理を終了します。");
}
