using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L7
{
    class Employee
    {
    }

    [AccessLevel(AccessLevelEnum.Limited)]
    class Manager : Employee
    { }

    [AccessLevel(AccessLevelEnum.Medium)]
    class Programmer : Employee
    { }

    [AccessLevel(AccessLevelEnum.Full)]
    class Director : Employee
    { }
}
