using System;
using System.IO;
using System.Linq;

var lineItems = File.ReadLines("data.txt").Select(lineItem => Convert.ToInt32(lineItem)).ToList();
// Calculations.CheckForTwoWhichAddTo2020(lineItems);
Calculations.CheckForThreeWhichAddTo2020(lineItems);