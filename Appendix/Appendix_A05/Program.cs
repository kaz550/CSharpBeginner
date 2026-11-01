Dictionary<string, int> prices = new()
{
    ["りんご"] = 120,
    ["みかん"] = 80
};

HashSet<string> fruits = new() { "りんご", "みかん" };
fruits.Add("りんご");

Console.WriteLine(prices["りんご"]);
Console.WriteLine(fruits.Count);
