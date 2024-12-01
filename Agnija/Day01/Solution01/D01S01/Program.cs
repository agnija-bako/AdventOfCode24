// See https://aka.ms/new-console-template for more information

using D01S01;

var solutionDirectory = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName!;
var filePath = Path.Combine(solutionDirectory, "Resources", "Input");
string[] lines = File.ReadAllLines(filePath);


var list1 = new List<int>();
var list2 = new List<int>();

foreach (var line in lines)
{
    string[] parts = line.Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);

    if (parts.Length == 2 && int.TryParse(parts[0], out int num1) && int.TryParse(parts[1], out int num2))
    {
        list1.Add(num1);
        list2.Add(num2);
    }
}

var totalDifference = HistorianLocations.FindLocationIdDifferences(list1, list2);


Console.WriteLine($"Total difference: {totalDifference}");



