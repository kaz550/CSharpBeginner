List<string> items = new List<string>();

items.Add("りんご");
items.Add("みかん");
items.Add("ぶどう");

Console.WriteLine($"商品数: {items.Count}");
foreach (string item in items)
{
    Console.WriteLine(item);
}
