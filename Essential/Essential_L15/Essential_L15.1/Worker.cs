using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._1
{
    struct Worker
    {
        private string _fullName;
        private string _position;
        private int _year;

        public Worker(string fullName, string position, int year)
        {
            _year = DateTime.Now.Year;
            _fullName = fullName;
            _position = position;
            Year = year;
        }

        public string FullName { get { return _fullName; } }
        public string Position { get { return _position; } }
        public int Year
        {
            get
            {
                return _year;
            }

            set
            {
                if (value <= 0 || value > DateTime.Now.Year)
                {
                    throw new Exception("You have entered the wrong year!");
                }

                _year = value;
            }
        }

        public int Experience
        {
            get
            {
                return (DateTime.Now.Year - Year);
            }
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", FullName, Position, Year);
        }
    }
}
