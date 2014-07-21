using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L2._2
{
    class Employee
    {
        private Post _employeePost;
        private double _salary;
        private double _incomeTax;

        public Employee (string name, string surname)
        {
            Name = name;
            Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public uint Experience { get; set; }

        public Post EmployeePost
        {
            get
            {
                if (_employeePost == Post.Default)
                {
                    Console.WriteLine("The employee's post wasn't specified");
                }

                return _employeePost;
            }

            set { _employeePost = value; }
        }

        public void EmployeeInformation()
        {
            Console.WriteLine("Name: {1}{0}Surname: {2}", Environment.NewLine, Name, Surname);
            if (EmployeePost != Post.Default)
            { Console.WriteLine("Post: {1}{0}Salary: {2}{0}Income Tax: {3}", Environment.NewLine, EmployeePost, Salary, IncomeTax); }
        }

        public double Salary
        {
            get
            {
                if (_salary == 0)
                {
                    SalaryCounter();
                }

                return _salary;
            }

            set { _salary = value; }
        }

        public double IncomeTax
        {
            get
            {
                if (_incomeTax == 0)
                {
                    Tax();
                }

                return _incomeTax;
            }

            set { _incomeTax = value; }
        }

        public void SalaryCounter()
        {
            switch (EmployeePost)
            {
                case Post.Manager:
                    {
                        _salary = 30000;
                        break;
                    }
                case Post.Programer:
                    {
                        _salary = 10000;
                        break;
                    }
                case Post.Accountant:
                    {
                        _salary = 8000;
                        break;
                    }
                default:
                    {
                        _salary = 0;
                        break;
                    }
            }

            if (Experience < 2)
            {
                _salary *= 1;
            }
            else if (Experience >= 2 && Experience < 5)
            {
                _salary *= 1.25;
            }
            else
            {
                _salary *= 1.5;
            }
        }

        public void Tax()
        {
            if (_salary == 0)
            {
                SalaryCounter();
            }         

            if (_salary < 8000)
            {
                _incomeTax = _salary * 0.15;
            }
            else
            {
                _incomeTax = _salary * 0.17;
            }            
        }
    }
}
