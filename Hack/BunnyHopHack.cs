using System;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace CSGOHack.Hack
{
    class BunnyHopHack : AbstractHack
    {
        public BunnyHopHack(VAMemory mem, IntPtr baseAddress, Dictionary<String, int> offsets) : base(mem, baseAddress, offsets)
        {
        
        }
        public override void Run()
        {
            while (hackThread.IsAlive)
            {
                Thread.Sleep(1);
                if ((Control.ModifierKeys & Keys.Alt) == 0)
                {
                    continue;
                }
                int player = mem.ReadInt32(baseAddress + offsets["dwLocalPlayer"]);
                if (player == 0)
                {
                    continue;
                }
                int forceJump = (int)(baseAddress + offsets["dwForceJump"]);
                int onGround = mem.ReadInt32((IntPtr)(player + offsets["m_fFlags"]));
                if (onGround == 257)
                {
                    mem.WriteInt32((IntPtr)forceJump, 5);
                    Thread.Sleep(80);
                    mem.WriteInt32((IntPtr)forceJump, 4);
                }
            }
        }
    }
}
