using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._1
{
    class ClassRoom
    {

        private Pupil[] pupils = new Pupil[4];
        private Random r = new Random();


        public ClassRoom(Pupil pupil0, Pupil pupil1)
        {
            pupils[0] = pupil0;
            pupils[1] = pupil1;
            pupils[2] = GeneratePupil();
            pupils[3] = GeneratePupil();
        }

        public ClassRoom(Pupil pupil0, Pupil pupil1, Pupil pupil2)
        {
            pupils[0] = pupil0;
            pupils[1] = pupil1;
            pupils[2] = pupil2;
            pupils[3] = GeneratePupil();

        }

        private Pupil GeneratePupil()
        {
            int rNumber = r.Next(1, 4);

            switch (rNumber)
            {
                case 1:
                    {
                        return new ExcelentPupil();
                    }
                case 2:
                    {
                        return new GoodPupil();
                    }
                case 3:
                    {
                        return new BadPupil();
                    }
                default:
                    {
                        return new Pupil();
                    }
            }

        }

        private void GroupStudy()
        {
            foreach (var pupil in pupils)
            {
                pupil.Study();
            }            
        }

        private void GroupRead()
        {
            foreach (var pupil in pupils)
            {
                pupil.Read();
            }
        }

        private void GroupWrite()
        {
            foreach (var pupil in pupils)
            {
                pupil.Write();
            }
        }

        private void GroupRelax()
        {
            foreach (var pupil in pupils)
            {
                pupil.Relax();
            }
        }

        public void GroupAct()
        {
            GroupStudy();
            Console.WriteLine(new string('-', 30));
            GroupRead();
            Console.WriteLine(new string('-', 30));
            GroupWrite();
            Console.WriteLine(new string('-', 30));
            GroupRelax();
        }
    }
}
