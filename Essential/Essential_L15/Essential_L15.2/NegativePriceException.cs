using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._2
{
    class NegativePriceException : Exception
    {
        const string _message = "The product price cannot be negative!";

        public NegativePriceException()
            : base(_message)
        { }

        public NegativePriceException(string message)
            :base(message)
        {
           
        }
    }
}
