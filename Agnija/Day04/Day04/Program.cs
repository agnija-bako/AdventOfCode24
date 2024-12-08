// See https://aka.ms/new-console-template for more information

using Day04;

Console.WriteLine("Hello, World!");

var solutionDirectory = Directory.GetParent(AppContext.BaseDirectory)?.Parent?.Parent?.Parent?.FullName!;
var filePath = Path.Combine(solutionDirectory, "Resources", "Input.txt");

var lines = File.ReadAllLines(filePath);

var sol = new Search();
var totalForLine =  sol.MatchTotal(lines.ToList());
Console.WriteLine($"totalForLine: {totalForLine}");


Console.WriteLine($"done: {totalForLine}");