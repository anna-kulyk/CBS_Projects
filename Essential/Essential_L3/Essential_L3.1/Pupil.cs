using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._1
{
    class Pupil
    {
        protected virtual string PupilQuality
        { get { return "Pupil"; } }

        public void Study()
        {
            Console.WriteLine("{0}.Study()", PupilQuality);
        }
        public void Read()
        {
            Console.WriteLine("{0}.Read()", PupilQuality);
        }
        public void Write()
        {
            Console.WriteLine("{0}.Write()", PupilQuality);
        }
        public void Relax()
        {
            Console.WriteLine("{0}.Relax()", PupilQuality);
        }
    }
}
