Book book = new Book();
book.Title = "C#入門";
Console.WriteLine(book.Title);

public class Book
{
    private int edition = 1;
    public string Title { get; set; } = "";
    public int Edition => edition;
}
