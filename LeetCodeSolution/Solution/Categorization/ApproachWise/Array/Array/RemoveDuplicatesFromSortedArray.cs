using System.Collections.Generic;
using System.Linq;
using Common.Sorting;

namespace LeetCodeSolution.Array
{
    ///// <summary>
    ///// Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
    //Do not allocate extra space for another array, you must do this in place with constant memory.

    //For example,

    //Given input array nums = [1, 1, 2],
    //Your function should return length = 2, with the first two elements of nums being 1 and 2 respectively.It doesn't matter what you leave beyond the new length.
    ///// </summary>
    public class RemoveDuplicatesFromSortedArray
    {

        public int[] RemoveDuplicates(int[] input)
        {
            var sortedArray = SortedArray(input);
            var approach1 = approach1_hashset(sortedArray);
            var approach2 = approach2_usingLoop(sortedArray);

            return approach2;
        }

        private int[] SortedArray(int[] input)
        {
            // Since this is Non sorted array , so we will sort this collection first.
            var sortedList = input.ToList().MergeSort();

            return sortedList.ToArray();
        }

        private int[] approach1_hashset(int[] sortedArray)
        {
            return new HashSet<int>(sortedArray).ToArray();
        }

        private int[] approach2_usingLoop(int[] sortedArray)
        {
            var resultArray = new List<int>();
            foreach (var value in sortedArray)
            {
                if (!resultArray.Contains(value))
                {
                    resultArray.Add(value);
                }
            }
            return resultArray.ToArray();
        }
    }
}
