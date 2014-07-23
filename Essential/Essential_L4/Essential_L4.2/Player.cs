using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4._2
{
    class Player : IPlayable, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Player.IPlayable.Play()");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Player.IPlayable.Pause()");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Player.IPlayable.Stop()");
        }

        public void Record()
        {
            Console.WriteLine("Player.IRecordable.Record()");
        }

        void IRecordable.Pause()
        {
            Console.WriteLine("Player.IRecordable.Pause()");
        }

       void IRecordable.Stop()
        {
            Console.WriteLine("Player.IRecordable.Stop()");
        }
    }
}
