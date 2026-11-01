Book book = new Book();
book.Title = "はじめてのC#";
book.Price = 1200;
Console.WriteLine($"{book.Title}：{book.Price}円");

class Book
{
    public string Title { get; set; } = "";
    public int Price { get; set; }
}
