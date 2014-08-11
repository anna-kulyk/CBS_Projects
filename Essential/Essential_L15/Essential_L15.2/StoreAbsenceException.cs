using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._2
{
    class StoreAbsenceException : Exception
    {
        const string _message = "There is no information about this store!";

        public StoreAbsenceException()
            : base(_message)
        { }

        public StoreAbsenceException(string message)
            :base(message)
        {
           
        }
    }
}
