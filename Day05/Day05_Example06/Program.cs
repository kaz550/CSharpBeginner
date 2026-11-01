List<Book> books = new List<Book>();
books.Add(new Book("C#入門", 1000));
books.Add(new Book("練習帳", 1500));

int total = 0;
foreach (Book book in books)
{
    total += book.Price;
}

Console.WriteLine($"合計：{total}円");

class Book
{
    public string Title { get; }
    public int Price { get; }

    public Book(string title, int price)
    {
        Title = title;
        Price = price;
    }
}
