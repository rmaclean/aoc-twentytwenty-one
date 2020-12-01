using System;
using System.Collections.Generic;

public static partial class Calculations
{
    public static void CheckForThreeWhichAddTo2020(List<int> lineItems)
    {
        var found = false;
        for (var firstIndex = 0; firstIndex < lineItems.Count; firstIndex++)
        {
            for (var secondIndex = 0; secondIndex < lineItems.Count; secondIndex++)
            {
                for (var thirdIndex = 0; thirdIndex < lineItems.Count; thirdIndex++)
                {
                    if (firstIndex == secondIndex || secondIndex == thirdIndex || firstIndex == thirdIndex)
                    {
                        continue;
                    }

                    if (lineItems[firstIndex] + lineItems[secondIndex] + lineItems[thirdIndex] == 2020)
                    {
                        Console.WriteLine($"{lineItems[firstIndex]} x {lineItems[secondIndex]} + {lineItems[thirdIndex] } = {lineItems[firstIndex] * lineItems[secondIndex] * lineItems[thirdIndex]}");
                        found = true;
                        break;
                    }
                }
            }

            if (found)
            {
                break;
            }
        }
    }
}