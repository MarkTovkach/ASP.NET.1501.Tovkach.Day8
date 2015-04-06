using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    public abstract class AbstractMatrix <T>
    {
        public int Dimension { get;  set; }

        public event EventHandler<MatrixEventArgs> MatrixElementChanged = delegate { };

        public abstract T this[int i, int j] { get; set; }

        public virtual void OnMatrixElementChanged(MatrixEventArgs e)
        {
            MatrixElementChanged(this, e);
        }

    }
}
