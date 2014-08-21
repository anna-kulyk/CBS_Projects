using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L3
{
    //Создайте на диске 100 директорий с именами от Folder_0 до Folder_99б затем удалите их

    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo myDirectory = new DirectoryInfo(@"H:/");
            for (int i = 0; i < 100; i++)
            {
                myDirectory.CreateSubdirectory(string.Format("Folder_{0}", i));
            }
            for (int i = 0; i < 100; i++)
            {
                Directory.Delete(string.Format(@"H:/Folder_{0}", i));
            }
            
        }
    }
}
