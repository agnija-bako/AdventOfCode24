namespace Day04;

public class Directions
{
    public static Point[] WithDiagonals { get; } =
    {
        (0, 1),
        (1, 0),
        (0, -1),
        (-1, 0),
        (1, 1),
        (-1, 1),
        (1, -1),
        (-1, -1)
    };
}

public record struct Point(int X, int Y)
{
    public static Point operator +(Point a, Point b) => new(a.X + b.X, a.Y + b.Y);

    public static Point operator -(Point a, Point b) => new(a.X - b.X, a.Y - b.Y);

    public static Point operator *(Point point, int multiple) => new(point.X * multiple, point.Y * multiple);

    public static implicit operator Point((int X, int Y) tuple) => new(tuple.X, tuple.Y);
}