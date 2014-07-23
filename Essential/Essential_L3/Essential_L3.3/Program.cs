using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentWorker dw;

            Console.WriteLine("Введите номер ключа доступа (pro / exp):");
            string key = Console.ReadLine();

            switch (key)
            {
                case "pro":
                    {
                        dw = new ProDocumentWorker();
                        break;
                    }
                case "exp":
                    {
                        dw = new ExpertDocumentWorker();
                        break;
                    }
                default:
                    {
                        dw = new DocumentWorker();
                        break;
                    }
            }

            dw.OpenDocument();
            dw.EditDocument();
            dw.SaveDocument();
        }
    }
}
