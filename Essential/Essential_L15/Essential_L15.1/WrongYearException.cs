using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._1
{
    class WrongYearException : Exception
    {
        const string _message = "You have entered the wrong year!";

        public WrongYearException()
            : base(_message)
        { }

        public WrongYearException(string message)
            :base(message)
        {
           
        }
    }
}
