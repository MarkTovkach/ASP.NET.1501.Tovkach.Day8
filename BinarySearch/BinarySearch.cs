using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchGeneric
{
    public static class BinarySearch<T>
    {


        public static int Searcher(T[] array, T key, Comparison<T> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            int left = 0;
            int rigth = array.Length-1;

            while (left < rigth)
            {
                int middle = (rigth + left) / 2;

                int compareResult = comparer(key, array[middle]);

                if (compareResult > 0)
                {
                    left = middle + 1;
                }
                else if (compareResult < 0)
                {
                    rigth = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return ~array.Length;
 
        }
       
        //Ломал голову, как применить DRY, но увы.
        public static int Searcher( T[] array, T key, IComparer<T> comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array");
            }

            int left = 0;
            int rigth = array.Length-1;

            while (left < rigth)
            {
                int middle = (rigth + left) / 2;

                int compareResult = comparer.Compare(key,array[middle]);

                if (compareResult > 0)
                {
                    left = middle + 1;
                }
                else if (compareResult < 0)
                {
                    rigth = middle - 1;
                }
                else
                {
                    return middle;
                }
            }
            return ~array.Length;

        }


    }
}
