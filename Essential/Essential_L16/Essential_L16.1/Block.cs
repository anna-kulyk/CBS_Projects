using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16._1
{
    class Block
    {
        public Block(uint ab, uint bc, uint cd, uint da)
        {
            AB = ab;
            BC = bc;
            CD = cd;
            DA = da;
        }

        public uint AB { get; set; }
        public uint BC { get; set; }
        public uint CD { get; set; }
        public uint DA { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Block)
            {
                Block block = (Block)obj;
                if (this.AB == block.AB && this.BC == block.BC && this.CD == block.CD && this.DA == block.DA)
                {
                    return true;
                }
            }

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return string.Format("({0}, {1}, {2}, {3})", AB, BC, CD, DA);
        }
    }
}
