using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public class SymmetricMatrix<T> : AbstractMatrix<T>
    {
        public T[] matrix;

        public SymmetricMatrix(int dimension)
        {
            matrix = new T[(dimension * dimension + dimension) / 2];
            Dimension = dimension;
        }

        public override T this[int i, int j]
        {
            get
            {
                if (i < Dimension && j < Dimension)
                {
                    int currentI = (i > j) ? j : i;
                    int currentJ = (i > j) ? i : j;

                    int rowIndex = (2 * Dimension - currentI + 1) * currentI / 2;
                    int columnIndex = currentJ - currentI;
                    return matrix[rowIndex + columnIndex];
                }
                else
                    throw new IndexOutOfRangeException();
            }
            set
            {
                if (i < Dimension && j < Dimension)
                {
                    int currentI = (i > j) ? j : i;
                    int currentJ = (i > j) ? i : j;

                    int rowIndex = (2 * Dimension - currentI + 1) * currentI / 2;
                    int columnIndex = currentJ - currentI;

                    matrix[rowIndex + columnIndex] = value;
                    OnMatrixElementChanged(new MatrixEventArgs(i, j));
                    OnMatrixElementChanged(new MatrixEventArgs(j, i));
                }
                else
                    throw new IndexOutOfRangeException();
            }
        }

    }
}
