// See https://aka.ms/new-console-template for more information

using System.Text.RegularExpressions;


var solutionDirectory = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName!;
var filePath = Path.Combine(solutionDirectory, "Resources", "Input.txt");
var lines = File.ReadAllLines(filePath);
var input    = string.Join(string.Empty, lines);

//solution 2
const string disposePattern = @"(?<=don't\(\)).*?(?=do\(\))";
var output = Regex.Replace(input, disposePattern, string.Empty); //clear the useless shit

var lastDoIndex = output.LastIndexOf("do()", StringComparison.Ordinal); //clear everything after first don't() following the last do()
if (lastDoIndex != -1)
{
    var orphanDontIndex = output.IndexOf("don't()", lastDoIndex, StringComparison.Ordinal);
    if (orphanDontIndex != -1)
    {
        output = output[..orphanDontIndex];
    }
}

//solution 1
var total = 0;
const string pattern = @"mul\((\d+),(\d+)\)";

var matches = Regex.Matches(output, pattern);
foreach (Match match in matches)
{
    var firstDigit = match.Groups[1].Value;
    var secondDigit = match.Groups[2].Value;

    total += (int.Parse(firstDigit) * int.Parse(secondDigit));
}

Console.WriteLine($"Total: {total}");