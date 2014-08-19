using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var siriusBlack = new Person("Sirius Black", 1959);
            var regulusBlack = new Person("Regulus Black", 1961);
            var orionBlack = new Person("Orion Black", 1929, new Collection<Person> { siriusBlack, regulusBlack });
            var alphardBlack = new Person("Alphard Black", 1930);
            var nymphadoraTonks = new Person("Nymphadora Tonks", 1973);
            var andromedaBlack = new Person("Andromeda Black", 1953, new Collection<Person> { nymphadoraTonks });
            var bellatrixBlack = new Person("Bellatrix Black", 1951);
            var dracoMalfoy = new Person("Draco Malfoy", 1980);
            var narcissaBlack = new Person("Narcissa Black", 1955, new Collection<Person> { dracoMalfoy });
            var cygnusBlack = new Person("Cygnus Black", 1938, new Collection<Person> { bellatrixBlack, andromedaBlack, narcissaBlack });
            var lucretiaBlack = new Person("Lucretia Black", 1925);

            var familyTree = new Collection<Person> 
            {
                orionBlack, alphardBlack, cygnusBlack, lucretiaBlack              
            };
            
            var draco = familyTree.FindByName("Draco Malfoy");
            Console.WriteLine(draco.Name);

            var scorpiusMalfoy = new Person("Scorpius Malfoy", 2006);
            familyTree.AddHeir("Draco Malfoy", scorpiusMalfoy);

            familyTree.ShowHeirs("Draco Malfoy");

            Collection<Person> sorted = new Collection<Person>();
            sorted.SelectByYear(familyTree, 1959);
            foreach (var item in sorted)
            {
                Console.WriteLine(item.Name);
            }
        }
    }
}
