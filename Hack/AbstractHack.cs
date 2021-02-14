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
        protected Dictionary<String, int> offsets;

        public AbstractHack(VAMemory mem, IntPtr baseAddress, Dictionary<String, int> offsets)
        {
            this.mem = mem;
            this.baseAddress = baseAddress;
            hackThread = new Thread(new ThreadStart(this.Run));
            hackThread.IsBackground = true;
            this.offsets = offsets;
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
