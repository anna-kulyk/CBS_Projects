using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L7._1
{
    struct Train
    {
        private string _destination;
        private uint _number;
        private DateTime _departureTime;

        public Train(string destination, uint number, string departureTime)
        {
            _destination = destination;
            _number = number;
            _departureTime = DateTime.Parse(departureTime);
        }

        public string Destination { get { return _destination; } }
        public uint Number { get { return _number; } }
        public DateTime DepartureTime { get { return _departureTime; } }

        public override string ToString()
        {
            return string.Format("Train Information:{0}Destination: {1}{0}Number: {2}{0}Departure time: {3:HH:mm}", Environment.NewLine, Destination, Number, DepartureTime);
        }
    }
}
