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
            const string root = @"H:\";
            const string folderNameTemplate = "Folder_{0}";
            var path = Path.Combine(root, folderNameTemplate);

            DirectoryInfo myDirectory = new DirectoryInfo(root);
            for (int i = 0; i < 100; i++)
            {
                myDirectory.CreateSubdirectory(string.Format(folderNameTemplate, i));
            }

            for (int i = 0; i < 100; i++)
            {
                Directory.Delete(string.Format(path, i));
            }
            
        }
    }
}
