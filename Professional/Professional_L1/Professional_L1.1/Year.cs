using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._1
{
    class Year : IEnumerable<Month>
    {
        readonly Month[] _year = 
        {
            new Month("January", 1, 31),
            new Month("February", 2, 28),
            new Month("March", 3, 31),
            new Month("April", 4, 30),
            new Month("May", 5, 31),
            new Month("June", 6, 30),
            new Month("July", 7, 31),
            new Month("August", 8, 31),
            new Month("September", 9, 30),
            new Month("October", 10, 31),
            new Month("November", 11, 30),
            new Month("December", 12, 31)
        };

        public IEnumerator<Month> GetEnumerator()
        {
            for (int i = 0; i < _year.Length; i++)
            {
                yield return _year[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Month GetMonthByConsecutiveNumber(uint consecutiveNumber)
        {
            for (int i = 0; i < _year.Length; i++)
            {
                if (_year[i].ConsecutiveNumber == consecutiveNumber)
                {
                    return _year[i];
                }                
            }
            return new Month();
        }

        public IEnumerable<Month> GetMonthByNumberOfDays(uint numberOfDays)
        {
            for (int i = 0; i < _year.Length; i++)
            {
                if (_year[i].NumberOfDays == numberOfDays)
                {
                    yield return _year[i];
                }
            }
        }
    }
}
