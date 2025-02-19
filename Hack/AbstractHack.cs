﻿using System;
using System.Collections.Generic;
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
            this.offsets = offsets;
        }
        public void Start()
        {
            if (hackThread != null && hackThread.IsAlive)
            {
                return;
            }
            hackThread = new Thread(new ThreadStart(this.Run));
            hackThread.IsBackground = true;
            hackThread.Start();
        }

        public void Stop()
        {
            if (!hackThread.IsAlive)
            {
                return;
            }
            hackThread.Abort();
        }

        public abstract void Run();
    }
}
