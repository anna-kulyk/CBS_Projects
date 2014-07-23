using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4._1
{
    abstract class AbstractHandler
    {
        abstract public void Open();
        abstract public void Create();
        abstract public void Change();
        abstract public void Save();

        public void Act()
        {
            Open();
            Create();
            Change();
            Save();
        }
    }
}
