using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L16._3
{
    class Date
    {
        private DateTime _date = new DateTime();

        public Date(int year, int mounth, int day)
        {
            _date = new DateTime(year, mounth, day);
        }

        public int Day
        {
            get
            {
                return _date.Day;
            }
        }

        public int Month
        {
            get
            {
                return _date.Month;
            }
        }

        public int Year
        {
            get
            {
                return _date.Year;
            }
        }

        public static Date operator +(Date date, int days)
        {
            DateTime newDateTime = date._date.AddDays(days);
            return new Date(newDateTime.Year, newDateTime.Month, newDateTime.Day);
        }

        public Date AddDays(int days)
        {
            return this + days;
        }

        public static int GetAmountOfDays(Date date1, Date date2)
        {
            TimeSpan ts = date1._date.Subtract(date2._date);
            return Math.Abs(ts.Days);
        }

        public override string ToString()
        {
            return string.Format("{0}/{1}/{2}", Month, Day, Year);
        }
    }
}
