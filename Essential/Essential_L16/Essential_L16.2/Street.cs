using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16._2
{
    class Street //: ICloneable
    {
        public Street(string name)
        {
            Name = name;
        }

        public string Name;

        //public object Clone()
        //{
        //    return new Street(this.Name);
        //}
    }
}
