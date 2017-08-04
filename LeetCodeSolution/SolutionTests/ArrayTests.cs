using System;
using LeetCodeSolution.Array;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SolutionTests
{
    [TestClass]
    public class ArrayTests
    {
        [TestInitialize]
        public void Initialize()
        {
        }


        [TestMethod]
        public void Sorted_Array_RemoveDuplicatesFromSortedArray()
        {
            var inputList = new int[100];
            inputList = new[] {50, 3 , 4 , 71 , 5 , 61 , 12 , 7 , 25 , 92 , 88 , 9};
            var sortedArray = new RemoveDuplicatesFromSortedArray();
            sortedArray.SortedArray(inputList);
        }
    }
}
