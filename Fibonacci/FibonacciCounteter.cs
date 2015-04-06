using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    public static class FibonacciCounteter
    {


        public static IEnumerable<long> GetNumbers(long numb)
        {
            if (numb==0 || numb==1)
                yield break;
            if (numb < 0)
                throw new ArgumentException("numb");
            
            yield return 0;
            yield return 1;

            long first = 0, second = 1, result;

            for (int i = 0; i < numb-2; i++)
            {
                result = first + second;
                first = second;
                second = result;
                yield return result;
                
            }

            
        }


    }
}
