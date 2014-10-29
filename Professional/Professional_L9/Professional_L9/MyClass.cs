using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Professional_L9
{
    class MyClass : IDisposable    
    {
        private int[] array = new int[100000000];

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

                // Free any unmanaged objects here.
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
