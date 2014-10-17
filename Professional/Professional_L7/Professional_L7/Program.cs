using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L7
{
    /*
     * Создайте пользовательский атрибут AccessLevelAttribute, 
     * позволяющий определить уровень доступа пользователя к системе. 
     * Сформируйте состав сотрудников некоторой фирмы в виде набора классов, 
     * например, Manager , Programmer , Director . 
     * При помощи атрибута AccessLevelAttribute распределите уровни доступа персонала 
     * и отобразите на экране реакцию системы на попытку каждого сотрудника получить доступ в защищенную секцию.
    */

    class Program
    {
        static void ProtectedSection(Employee emp)
        {
            Type type = emp.GetType();
            AccessLevelAttribute attr = Attribute.GetCustomAttribute(type, typeof(AccessLevelAttribute)) as AccessLevelAttribute;
            
            switch (attr.AccessLevel)
            {
                case AccessLevelEnum.Limited:
                case AccessLevelEnum.Medium:
                case AccessLevelEnum.Full:
                    {
                        Console.WriteLine("This employee has a {0} access level", attr.AccessLevel.ToString());
                        break;
                    }
                default:
                    {
                        Console.WriteLine("This employee has no access level");
                        break;
                    }
            }
        }

        static void Main(string[] args)
        {
            var anna = new Director();
            ProtectedSection(anna);
        }
    }
}
