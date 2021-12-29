// See https://aka.ms/new-console-template for more information
using HabPracticeConsoleApp.LongestContinuousSubArray;

string[] array1 = new string[] { "3234.html", "xys.html", "7hsaa.html", "ABC", "DEF" };
string[] array2 = new string[] { "3234.html", "sdhsfjdsh.html", "xys.html", "7hsaa.html", "ABC", "XYZ" };

LargestContinuousSubArray largestArray = new LargestContinuousSubArray();
var result = largestArray.FindLongestSubArray("abcdefg".ToCharArray(), "efg".ToCharArray());
Console.WriteLine(result.Count());
