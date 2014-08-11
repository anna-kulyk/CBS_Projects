using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L15._1
{
    class Staff
    {
        private Worker[] _staff;

        public Staff(uint n)
        {
            _staff = new Worker[n];
            Initialize(_staff);
            Array.Sort(_staff, new Comparison<Worker>((a, b) => a.FullName.CompareTo(b.FullName)));
        }

        private void Initialize(Worker[] staff)
        {
            for (int i = 0; i < staff.Length; i++)
            {
                Console.Write("Enter the family name and initials of the worker: ");
                string workerFullName = Console.ReadLine();
                Console.Write("Enter the position: ");
                string workerPosition = Console.ReadLine();                
                int workerYear = DateTime.Now.Year;
                bool locker = true;
                while (locker)
                {
                    locker = false;
                    Console.Write("Enter the year of hiring: ");
                    try
                    {
                        workerYear = Convert.ToInt32(Console.ReadLine());
                        staff[i] = new Worker(workerFullName, workerPosition, workerYear);
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine(e.Message);
                        locker = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        locker = true;
                    }  
                } 
                Console.Clear();
            }
        }

        public void ShowIfExperienced(int experience)
        {
            for (int i = 0; i < _staff.Length; i++)
			{
                if (experience <= _staff[i].Experience)
                {
                    Console.WriteLine(_staff[i].ToString());
                }			 
			}
        }

        public Worker this[uint index]
        {
            get
            {
                return _staff[index];
            }
        }               
    }
}
