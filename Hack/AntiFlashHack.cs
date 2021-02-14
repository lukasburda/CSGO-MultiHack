using System;
using System.Collections.Generic;
using System.Threading;

namespace CSGOHack.Hack
{
    public class AntiFlashHack : AbstractHack
    {
        public AntiFlashHack(VAMemory mem, IntPtr baseAddress, Dictionary<String, int> offsets) : base(mem, baseAddress, offsets)
        {

        }

        public override void Run()
        {
            while (hackThread.IsAlive)
            {
                int player = mem.ReadInt32(baseAddress + offsets["dwLocalPlayer"]);
                if (player == 0)
                {
                    continue;
                }
                mem.WriteFloat((IntPtr)(player + offsets["m_flFlashMaxAlpha"]), 1);
                Thread.Sleep(1);
            }
        }
    }
}
