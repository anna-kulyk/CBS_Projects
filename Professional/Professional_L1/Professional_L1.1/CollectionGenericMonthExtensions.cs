using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._1
{
    static class CollectionGenericMonthExtensions
    {
        public static Month GetMonthByConsecutiveNumber(this Collection<Month> months, uint consecutiveNumber)
        {
            for (int i = 0; i < months.Count; i++)
            {
                if (months[i].ConsecutiveNumber == consecutiveNumber)
                {
                    return months[i];
                }
            }
            return new Month();
        }

        public static IEnumerable<Month> GetMonthByNumberOfDays(this Collection<Month> months, uint numberOfDays)
        {
            for (int i = 0; i < months.Count; i++)
            {
                if (months[i].NumberOfDays == numberOfDays)
                {
                    yield return months[i];
                }
            }
        }
    }
}
