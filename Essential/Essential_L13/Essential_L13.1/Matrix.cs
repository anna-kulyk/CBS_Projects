using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Essential_L13._1
{
    class Matrix
    {
        public void MatrixString(object x)
        {
            int xInt = (int)x;

            while (true)
            {
                var matrixChain = new Chain();
                ChainDisplayer.DisplayChain(matrixChain, xInt); 
            }
        }
    }
}
