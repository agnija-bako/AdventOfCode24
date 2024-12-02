// See https://aka.ms/new-console-template for more information

using Day02;

var lists = InputFile.GetInput();

var totalSafeReports = 0;

foreach (var list in lists)
{
    var increasing = (list[0] < list[1]);

    var match = 1;
    for (var i = 0; i < list.Count - 1; i++)
    {
        var diff = list[i] - list[i + 1];
        if (diff == 0)
            continue;

        if (increasing)
        {
            if (diff is >= -3 and < 0)
            {
                match++;
            }

            continue;
        }

        if (diff is <= 3 and > 0)
        {
            match++;
        }
    }

    if (list.Count == match || list.Count -1 == match) //Solution 1 + solution 2
    {
        totalSafeReports++;
    }
}

Console.WriteLine($"Total safe reports: {totalSafeReports}");