// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;


var solutionDirectory = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName!;
var filePath = Path.Combine(solutionDirectory, "Resources", "Input.txt");
var lines = File.ReadAllLines(filePath);

var total = 0;
var pattern = @"mul\((\d+),(\d+)\)";
foreach (var line in lines)
{
    var matches = Regex.Matches(line, pattern);
    foreach (Match match in matches)
    {
        var firstDigit = match.Groups[1].Value;
        var secondDigit = match.Groups[2].Value;

        total += (int.Parse(firstDigit) * int.Parse(secondDigit));
    }
    
}
Console.WriteLine($"Total: {total}");