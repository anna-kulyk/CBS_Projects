using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pupil pupil0 = new ExcelentPupil();
            Pupil pupil1 = new GoodPupil();
            var myClassRoom = new ClassRoom(pupil0, pupil1);           
            myClassRoom.GroupAct();
            
        }
    }
}
