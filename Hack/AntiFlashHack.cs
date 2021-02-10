using System;
using System.Threading;

namespace CSGOHack.Hack
{
    public class AntiFlashHack : AbstractHack
    {
        public AntiFlashHack(VAMemory mem, IntPtr baseAddress) : base(mem, baseAddress)
        {

        }

        public override void Run()
        {
            int player = 0;
            do
            {
                player = mem.ReadInt32(baseAddress + 0xD8B2BC);
                Thread.Sleep(100);
            } while (player != 0);

            while (hackThread.IsAlive)
            {
                mem.WriteFloat((IntPtr)(player + 0xA41C), 1);
                Thread.Sleep(10);
            }
        }
    }
}
