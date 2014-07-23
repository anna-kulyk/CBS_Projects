using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._2
{
    class Ship : Vehicle
    {
        public Ship(double price, uint speed, uint year, string port, uint capacity)
            : base(price, speed, year)
        {
            Port = port;
            Capacity = capacity;
        }

        protected override string Name { get { return "SHIP"; } }

        public string Port { get; set; }
        public uint Capacity { get; set; }

        public override void ShowProperties()
        {
            base.ShowProperties();
            Console.WriteLine("Port: {1}{0}Capacity: {2}", Environment.NewLine, Port, Capacity);
        }
    }
}
