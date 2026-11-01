Book book = new Book("ゲーム制作入門", 2000);
book.ShowInfo();

class Book
{
    public string Title { get; }
    public int Price { get; }

    public Book(string title, int price)
    {
        Title = title;
        Price = price;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Title}：{Price}円");
    }
}
