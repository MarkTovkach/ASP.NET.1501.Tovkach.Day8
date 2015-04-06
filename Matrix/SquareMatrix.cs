using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class SquareMatrix<T> : AbstractMatrix<T>
    {
        public T[] matrix;
        public SquareMatrix(int dimension)
        {
            matrix = new T[dimension * dimension];
            Dimension = dimension;
        }

        public override T this[int i, int j]
        {
            get
            {
                if (i < Dimension && j < Dimension)
                    return matrix[Dimension * i + j];
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (i < Dimension && j < Dimension)
                {
                    matrix[Dimension * i + j] = value;
                    OnMatrixElementChanged(new MatrixEventArgs(i, j));
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }


    }
}
