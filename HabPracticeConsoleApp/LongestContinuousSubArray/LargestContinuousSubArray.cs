using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabPracticeConsoleApp.LongestContinuousSubArray
{
    public class LargestContinuousSubArray
    {
        public IEnumerable<T> FindLongestSubArray<T>(T[] array1, T[] array2)
        {
            if (array1 == null || array2 == null) return Enumerable.Empty<T>();
            int max = 0;
            (int, int) maxPosition = (0, 0);
            int[,] result = new int[array1.Length + 1, array2.Length + 1];
            for (int i = 0; i < array1.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i].Equals(array2[j]))
                    {
                        result[i + 1, j + 1] = result[i, j] + 1;
                        if (result[i + 1, j + 1] > max)
                        {
                            max = result[i + 1, j + 1];
                            maxPosition = (i + 1, j + 1);
                        }
                    }
                    else
                    {
                        result[i + 1, j + 1] = 0;
                    }
                }
            }

            if (max <= 0) return Enumerable.Empty<T>();
            List<T> list = new List<T>();

            for (int i = Math.Min(maxPosition.Item1, maxPosition.Item2); i >= 0; i--)
            {
                list.Insert(0, array1[--maxPosition.Item1]);
                if (result[maxPosition.Item1, --maxPosition.Item2] < 1) break;
            }
            return list;
        }
    }
}
