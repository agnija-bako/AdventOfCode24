// See https://aka.ms/new-console-template for more information

using D01S01;

var solutionDirectory = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName!;
var filePath = Path.Combine(solutionDirectory, "Resources", "Input");
string[] lines = File.ReadAllLines(filePath);


var list1 = new List<int>();
var list2 = new List<int>();

foreach (var line in lines)
{
    string[] parts = line.Split(new[] {' ', '\t'}, StringSplitOptions.RemoveEmptyEntries);

    if (parts.Length == 2 && int.TryParse(parts[0], out int num1) && int.TryParse(parts[1], out int num2))
    {
        list1.Add(num1);
        list2.Add(num2);
    }
}

//Solution 1
var locationIdList1 = list1.Select(list => list).ToList();
var locationIdLis2 = list2.Select(list => list).ToList();
var totalDifference = HistorianLocations.FindLocationIdDifferences(locationIdList1, locationIdLis2);

Console.WriteLine($"Total difference: {totalDifference}");

//Solution 2
var totalSimilarityScore = HistorianLocations.FindSimilarityScore(list1, list2);
Console.WriteLine($"Total similarity score: {totalSimilarityScore}");