using System.Text.Json;

Book book = new Book { Title = "C#入門", Price = 1500 };
string json = JsonSerializer.Serialize(book);
Book? restored = JsonSerializer.Deserialize<Book>(json);

Console.WriteLine(json);
Console.WriteLine(restored?.Title);

public class Book
{
    public string Title { get; set; } = "";
    public int Price { get; set; }
}
