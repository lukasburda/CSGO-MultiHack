using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSGOHack.Hack
{
    public abstract class AbstractHack
    {
        protected VAMemory mem;
        protected IntPtr baseAddress;
        protected Thread hackThread;

        public AbstractHack(VAMemory mem, IntPtr baseAddress)
        {
            this.mem = mem;
            this.baseAddress = baseAddress;
            hackThread = new Thread(new ThreadStart(this.Run));
            hackThread.IsBackground = true;
        }
        public void Start()
        {
            hackThread.Start();
        }

        public void Stop()
        {
            hackThread.Join();
        }

        public abstract void Run();
    }
}
