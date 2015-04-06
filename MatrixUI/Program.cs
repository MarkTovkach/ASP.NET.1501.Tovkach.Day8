using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Matrix;

namespace MatrixUI
{
    class Program
    {
        static void Main(string[] args)
        {
            SymmetricMatrix<int> m = new SymmetricMatrix<int>(4);
            m.MatrixElementChanged += Handler;
            m[0, 0] = 0;
            m[0, 3] = 3;
            m[1, 0] = 1;
            m[1, 1] = 4;
            m[2, 2] = 5;
            m[3, 3] = 6;

            SymmetricMatrix<int> m2 = new SymmetricMatrix<int>(4);
            m.MatrixElementChanged += Handler;
            m[0, 0] = 0;
            m[0, 3] = 3;
            m[1, 0] = 1;
            m[1, 1] = 4;
            m[2, 2] = 5;
            m[3, 3] = 6;

            SquareMatrix<int> m3 = m.Sum<int>(m2);





           
        }

        public static void Handler(object sender, MatrixEventArgs args)
        {
            Console.WriteLine(args.i + " " + args.j);
        }
    }
}
