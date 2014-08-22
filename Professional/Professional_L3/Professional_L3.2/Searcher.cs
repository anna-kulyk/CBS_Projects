using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L3._2
{
    static class Searcher
    {
        static public FileInfo SearchFile(string fileName, string root)
        {
            var dir = new DirectoryInfo(root);
            FileInfo[] files = dir.GetFiles(string.Format("*{0}*", fileName));
            if (files.Length > 0)
            {
                return files[0];
            }
            else
            {
                DirectoryInfo[] dirs = dir.GetDirectories();
                if (dirs.Length > 0)
                {
                    foreach (var item in dirs)
                    {
                        if (item.Attributes.Equals(FileAttributes.System | FileAttributes.Hidden | FileAttributes.Directory))
                        {
                            continue;
                        }
                        else
                        {
                            FileInfo file = SearchFile(fileName, item.FullName);
                            if (file != null)
                            {
                                return file;
                            }
                            else
                            {
                                continue;
                            }                            
                        }
                    }
                }                
                return null;
            }
        }
    }
}
