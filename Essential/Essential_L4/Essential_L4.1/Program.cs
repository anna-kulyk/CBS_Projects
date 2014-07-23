using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential_L4._1
{
    class Program
    {
        static void Handler(DocumentType dt)
        {
            AbstractHandler ah = null; 

            switch(dt)
            {
                case DocumentType.DOC:
                    {
                        ah = new DOCHandler();
                        break;
                    }
                case DocumentType.TXT:
                    {
                        ah = new TXTHandler();
                        break;
                    }
                case DocumentType.XML:
                    {
                        ah = new XMLHandler();                        
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You should choose existing document type"); ;
                        break;
                    }                    
            }

            if (ah != null)
            {
                ah.Act();
            }            
        }


        static void Main(string[] args)
        {
            Handler(DocumentType.DOC);
        }
    }
}
