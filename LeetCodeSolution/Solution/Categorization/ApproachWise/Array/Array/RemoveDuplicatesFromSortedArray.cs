using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public int[] SortedArray(int[] input)
        {
            // Since this is Non sorted array , so we will sort this collection first.
            var sortedList = new QuickSortAlgo().QuickSort(input.ToList());

            return sortedList.ToArray();
        }
    }
}
