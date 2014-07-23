using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myPlayer = new Player();
            IPlayable play = myPlayer as IPlayable;
            play.Play();
            play.Pause();
            play.Stop();
            IRecordable record = myPlayer as IRecordable;
            record.Record();
            record.Pause();
            record.Stop();

        }
    }
}
