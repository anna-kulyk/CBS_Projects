using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L1._2
{
    static class CollectionGenericPersonExtensions
    {
        public static Person FindByName(this Collection<Person> persons, string name)
        {
            Person result = null;

            foreach (var person in persons)
            {
                if (person.Name == name)
                {
                    result = person;
                }
                else if (person.Heirs != null && person.Heirs.Any())
                {
                    result = FindByName(person.Heirs, name);
                }
            }

            return result;
        }

        public static void AddHeir(this Collection<Person> persons, string parentName, Person heir)
        {
            Person parent = persons.FindByName(parentName);
            if(parent != null)
            {
                parent.Heirs.Add(heir);
            }
            else
            {
                Console.WriteLine("There is no {0} in this family", parentName);
            }
        }

        public static void ShowHeirs(this Collection<Person> persons, string parentName)
        {
            Person parent = persons.FindByName(parentName);
            Console.WriteLine("{0} heirs:", parentName);
            foreach (var item in parent.Heirs)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void SelectByYear(this Collection<Person> sortedByYear, Collection<Person> persons, uint year)
        {
            foreach (var person in persons)
            {
                if (person.Year == year)
                {
                    sortedByYear.Add(person);
                }
                else if(person.Heirs != null && person.Heirs.Any())
                {
                    SelectByYear(sortedByYear, person.Heirs, year);
                }
            }
        }
    }
}
