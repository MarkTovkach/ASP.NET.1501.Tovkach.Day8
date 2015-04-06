using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using BinarySearchGeneric;
using System.Linq;
using System.Collections;


namespace BinarySearchTest
{
    [TestClass]
    public class BinarySearchTest
    {
        [TestMethod]
        public void ComparisionWithStringTest()
        {
            var a=new TestClass();
            var comparer = new Comparison<String>(a.StringCompareMethod);
            string[] array = { "Sort", "Good" ,"BSUIR" ,"<epam>"};
            var actual = BinarySearch<string>.Searcher(array,"BSUIR",a.StringCompareMethod);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ComparerWithIntTest()
        {
            IComparer<int> a = new TestClass();
            int[] array = { 1, 2, 5, 7, 19, 49, 60 };
            var actual = BinarySearch<int>.Searcher(array, 7, a);
            int expected = Array.BinarySearch(array, 7);
            Assert.AreEqual(expected, actual);
        }
    }
}
