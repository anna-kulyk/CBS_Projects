using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L9._1
{
    class MyClass : IDisposable
    {
        private FileStream myFile;

        public MyClass()
        {
            myFile = new FileStream("File.txt", FileMode.OpenOrCreate);
        }

        bool disposed = false;

        public void Dispose()
        {
            Dispose(true);
            Console.WriteLine("Dispose(): {0}", this.GetHashCode());
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // Free any other managed objects here.
                }

                if (myFile != null)
                {
                    myFile.Close();
                    myFile = null;
                }
            }

            this.disposed = true;
        }

        ~MyClass()
        {
            Dispose(false);
            Console.WriteLine("Finalise: {0}", this.GetHashCode());
        }
    }
}
