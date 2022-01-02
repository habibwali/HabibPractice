using HabPracticeConsoleApp.LongestContinuousSubArray;
using Xunit;
using System.Linq;

namespace HabPracticeTests
{
    public class LargestContinousSubArrayTests
    {



        [Fact]
        public void TestStringArray()
        {
            LargestContinuousSubArray obj = new LargestContinuousSubArray();
            string[] array1 = new string[] { "3234.html", "xys.html", "7hsaa.html", "ABC", "DEF" };
            string[] array2 = new string[] { "3234.html", "sdhsfjdsh.html", "xys.html", "7hsaa.html", "ABC", "XYZ" };
            var resultArray = obj.FindLongestSubArray(array1, array2);
            Assert.True(resultArray.SequenceEqual(new[] { "xys.html", "7hsaa.html", "ABC" }));
        }

        [Fact]
        public void TestIntegerArray()
        {
            LargestContinuousSubArray obj = new LargestContinuousSubArray();
            int[] array1 = new int[] { 1, 2, 3, 3, 3, 4, 5 };
            int[] array2 = new int[] { 1, 2, 3, 3, 3, 4, 4 };
            var resultArray = obj.FindLongestSubArray(array1, array2);
            Assert.True(resultArray.SequenceEqual(new[] { 1, 2, 3, 3, 3, 4 }));
        }

        [Fact]
        public void TestOneNullArray()
        {
            LargestContinuousSubArray obj = new LargestContinuousSubArray();
            int[] array1 = null;
            int[] array2 = new int[] { 1, 2, 3, 3, 3, 4, 4 };
            var resultArray = obj.FindLongestSubArray(array1, array2);
            Assert.True(!resultArray.Any());
        }

        [Fact]
        public void TestNoMatchingSubArray()
        {
            LargestContinuousSubArray obj = new LargestContinuousSubArray();
            int[] array1 = new int[] {8};
            int[] array2 = new int[] { 1, 2, 3, 3, 3, 4, 4 };
            var resultArray = obj.FindLongestSubArray(array1, array2);
            Assert.True(!resultArray.Any());
        }
        [Fact]
        public void TestUnequalArray()
        {
            LargestContinuousSubArray obj = new LargestContinuousSubArray();
            int[] array1 = new int[] { 1, 2, 3 };
            int[] array2 = new int[] { 1, 2, 3, 3, 3, 4, 4 };
            var resultArray = obj.FindLongestSubArray(array1, array2);
            Assert.True(resultArray.SequenceEqual(new[] { 1, 2, 3}));
        }

        [Fact]
        public void TestUnequalArray2()
        {
            LargestContinuousSubArray obj = new LargestContinuousSubArray();
            int[] array1 = new int[] { 1, 2, 3, 3, 3, 4, 4 };
            int[] array2 = new int[] { 1, 2, 3 };
            var resultArray = obj.FindLongestSubArray(array1, array2);
            Assert.True(resultArray.SequenceEqual(new[] { 1, 2, 3 }));
        }
    }
}