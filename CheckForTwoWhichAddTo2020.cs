using System;
using System.Collections.Generic;

public static partial class Calculations
{
    public static void CheckForTwoWhichAddTo2020(List<int> lineItems)
    {
        var found = false;
        for (var firstIndex = 0; firstIndex < lineItems.Count; firstIndex++)
        {
            for (var secondIndex = 0; secondIndex < lineItems.Count; secondIndex++)
            {
                if (firstIndex == secondIndex)
                {
                    continue;
                }

                if (lineItems[firstIndex] + lineItems[secondIndex] == 2020)
                {
                    Console.WriteLine($"{lineItems[firstIndex]} x {lineItems[secondIndex]} = {lineItems[firstIndex] * lineItems[secondIndex]}");
                    found = true;
                    break;
                }
            }

            if (found)
            {
                break;
            }
        }
    }
}