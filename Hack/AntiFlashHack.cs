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
            int player = 0;
            do
            {
                player = mem.ReadInt32(baseAddress + offsets["dwLocalPlayer"]);
            } while (player != 0);

            while (hackThread.IsAlive)
            {
                mem.WriteFloat((IntPtr)(player + offsets["m_flFlashMaxAlpha"]), 1);
                Thread.Sleep(1);
            }
        }
    }
}
