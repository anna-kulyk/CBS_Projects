using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2
{
    class User
    {
        private readonly DateTime _date;

        public User()
        { _date = DateTime.Now; }

        public User (string login, string name, string surname, uint age)
        {
            Login = login;
            Name = name;
            Surname = surname;
            Age = age;
            _date = DateTime.Now;
        }

        public string Login { get; private set; }
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public uint Age { get; private set; }
        public DateTime Date
        {
            get
            {
                return _date;
            }
        }

        public override string ToString()
        {
            return string.Format(CultureInfo.CurrentCulture,
                                "Date: {1}{0}Login:{2}{0}Name: {3}{0}Surname: {4}{0}Age: {5}{0}",
                                 Environment.NewLine,
                                 _date,
                                 Login,
                                 Name,
                                 Surname,
                                 Age);
        }
        
    }
}
