namespace Day02;

public static class InputFile
{
    public static List<List<int>> GetInput()
    {
        var solutionDirectory = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName!;
        var filePath = Path.Combine(solutionDirectory, "Resources", "Input.txt");

        var lists = new List<List<int>>();

        var lines = File.ReadAllLines(filePath);

        foreach (var line in lines)
        {
            var parts = line.Split(' ');

            var currentList = new List<int>();
            foreach (string part in parts)
            {
                if (int.TryParse(part, out int number))
                {
                    currentList.Add(number);
                }
            }

            lists.Add(currentList);
        }

        return lists;
    }
}