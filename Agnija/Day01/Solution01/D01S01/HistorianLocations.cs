namespace D01S01;

public static class HistorianLocations
{
    public static int FindLocationIdDifferences(List<int> list1, List<int> list2)
    {
        var totalDifference = 0;
        var itemCount = list1.Count;
        for (var i = 0; i < itemCount; i++)
        {

            var smallestList1 = FindSmallestElement(list1);
            list1.Remove(smallestList1);

            var smallestList2 = FindSmallestElement(list2);

            list2.Remove(smallestList2);
            totalDifference += Math.Abs(smallestList1 - smallestList2);
        }

        return totalDifference;
    }

    private static int FindSmallestElement(List<int> elements)
    {
        var smallestElement = elements[0];
        foreach (var el in elements)
        {
            if (el < smallestElement)
            {
                smallestElement = el;

            }
        }

        return smallestElement;
    }
}