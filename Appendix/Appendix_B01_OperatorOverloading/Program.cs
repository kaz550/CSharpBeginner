Point a = new Point(2, 3);
Point b = new Point(4, 5);
Point result = a + b;
Console.WriteLine($"({result.X}, {result.Y})");

public readonly struct Point
{
    public int X { get; }
    public int Y { get; }

    public Point(int x, int y)
    {
        X = x;
        Y = y;
    }

    public static Point operator +(Point left, Point right)
    {
        return new Point(left.X + right.X, left.Y + right.Y);
    }
}
