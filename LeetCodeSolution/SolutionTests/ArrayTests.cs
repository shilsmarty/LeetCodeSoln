using System;
using Common.Sorting;
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
            inputList = new[] { 50, 3, 4, 71, 5, 50, 92, 3, 61, 12, 7, 25, 92, 88, 9 };
            var sortedArray = new RemoveDuplicatesFromSortedArray();
            var result = sortedArray.RemoveDuplicates(inputList);
            Assert.AreEqual(12, result.Length);
        }
    }
}
