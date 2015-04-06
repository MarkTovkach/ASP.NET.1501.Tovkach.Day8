using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTest
{
    public class TestClass : IComparer<int>
    {
        public int StringCompareMethod(string key, string middle)
        {
            if (key.Length > middle.Length) return 1;
            else if (key.Length < middle.Length) return -2;
            return 0;
        }

        public int Compare(int key, int middle)
        {
            if (key > middle) return 1;
            else if (key < middle) return -2;
            return 0;
        }
    }
}
