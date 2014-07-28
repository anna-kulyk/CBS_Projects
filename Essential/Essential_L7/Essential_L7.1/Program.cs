using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L7._1
{
    class Program
    {
        static void AddTrains(Train[] trains)
        {
            for (int i = 0; i < trains.Length; i++)
            {
                Console.Write("Enter the destination: ");
                string destination = Console.ReadLine();
                Console.Write("Enter the number of the train: ");
                uint number = Convert.ToUInt32(Console.ReadLine());
                Console.Write("Enter the departure time: ");
                string departureTime = Console.ReadLine();
                Console.WriteLine(new string('-', 30));
                trains[i] = new Train(destination, number, departureTime);
            }
        }

        static void Sort(Train[] trains)
        {            
            for (int i = 0; i < trains.Length; i++)
            {
                for (int j = 0; j < trains.Length; j++)
                {
                    if (trains[i].Number <= trains[j].Number)
                    {
                        Train t = trains[i];
                        trains[i] = trains[j];
                        trains[j] = t;
                        
                    }
                }
            }
        }

        static void ShowTrainByNumber (Train[] trains, uint number)
        {
            int counter = 0;
            for (int i = 0; i < trains.Length; i++)
            {
                if (trains[i].Number == number)
                {
                    counter++;
                    Console.WriteLine(trains[i].ToString());
                }                
            }
            if (counter == 0)
            {
               Console.WriteLine("The train # {0} doesn't exists!", number); 
            }
        }


        static void Main(string[] args)
        {
            var trains = new Train[3];
            AddTrains(trains);
            Sort(trains);
            Console.WriteLine("You have entered the following data:");
            foreach (var item in trains)
            {
                Console.WriteLine(new string('*', 20));
                Console.WriteLine(item);                
            }
            Console.WriteLine(new string('-', 30));
            Console.Write("Enter the number of the train to start the search: ");
            uint tnumber = Convert.ToUInt32(Console.ReadLine());
            ShowTrainByNumber(trains, tnumber);
        }
    }
}
