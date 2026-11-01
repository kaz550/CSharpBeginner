Book book = new Book();
book.Title = "C#入門";
book.Price = 1000;
book.ShowInfo();

class Book
{
    public string Title { get; set; } = "";
    public int Price { get; set; }

    public void ShowInfo()
    {
        Console.WriteLine($"{Title}：{Price}円");
    }
}
