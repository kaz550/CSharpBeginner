List<Book> books = new List<Book>();
books.Add(new Book("C#入門", 1000));
books.Add(new Book("練習帳", 1500));
books.Add(new Book("ゲーム制作入門", 2000));

foreach (Book book in books)
{
    book.ShowInfo();
}

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
