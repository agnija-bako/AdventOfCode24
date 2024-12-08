namespace Day04;

public class Search
{
    private int _width;
    private int _height;
    private char[,] _map;

    public int MatchTotal(List<string> lines)
    {
        _height = 0;
        _width = 0;
        foreach (var line in lines)
        {
            _width = line.Length;
            _height++;
        }

        var map = new char[_width, _height];
        for (var y = 0; y < _height; y++)
        {
            for (var x = 0; x < _width; x++)
            {
                map[x, y] = lines[y][x];
            }
        }

        _map = map;

        int foundCount = 0;
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                foundCount += Directions.WithDiagonals.Count(direction => SearchWord((x, y), direction, "XMAS"));
            }
        }

        return foundCount;
    }

    private bool SearchWord(Point startingPoint, Point direction, string word)
    {
        for (var characterIndex = 0; characterIndex < word.Length; characterIndex++)
        {
            var (x, y) = startingPoint + direction * characterIndex;
            if (x < 0 ||
                x >= _width ||
                y < 0 ||
                y >= _height ||
                _map[x, y] != word[characterIndex])
            {
                return false;
            }
        }

        return true;
    }
}