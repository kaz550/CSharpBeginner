Student student = new Student("さくら", 85);
student.ShowInfo();

class Student
{
    public string Name { get; }
    public int Score { get; }

    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public void ShowInfo()
    {
        Console.WriteLine($"{Name}：{Score}点");
    }
}
