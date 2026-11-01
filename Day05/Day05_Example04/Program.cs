Book book = new Book("C#入門", 1000);
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
