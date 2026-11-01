Book first = new Book();
first.Title = "C#入門";
first.Price = 1000;

Book second = new Book();
second.Title = "プログラミング練習帳";
second.Price = 1500;

Console.WriteLine($"{first.Title}：{first.Price}円");
Console.WriteLine($"{second.Title}：{second.Price}円");

class Book
{
    public string Title { get; set; } = "";
    public int Price { get; set; }
}
