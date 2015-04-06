using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class DiagonalMatrix<T> : AbstractMatrix<T>
    {
        public T[] matrix;

        public DiagonalMatrix(int dimension)
        {
            Dimension = dimension;
            matrix = new T[dimension];
        }

        public override T this[int i, int j]
        {
            get
            {
                if (i < Dimension && j < Dimension)
                {
                    return (i == j) ? matrix[i] : default(T);
                }
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (i < Dimension && j < Dimension)
                {
                    if (i == j)
                        matrix[i] = value;
                    OnMatrixElementChanged(new MatrixEventArgs(i, j));
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }





    }
}
