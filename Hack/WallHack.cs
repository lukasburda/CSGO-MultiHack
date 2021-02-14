using System;
using System.Collections.Generic;
using System.Threading;

namespace CSGOHack.Hack
{
    class WallHack : AbstractHack
    {
        public WallHack(VAMemory mem, IntPtr baseAddress, Dictionary<String, int> offsets) : base(mem, baseAddress, offsets)
        {

        }
        public override void Run()
        {
            while (hackThread.IsAlive)
            {
                int glowManager = mem.ReadInt32(baseAddress + offsets["dwGlowObjectManager"]);
                if (glowManager == 0)
                {
                    continue;
                }
                for (int i = 1; i < 32; i++)
                {
                    int entity = mem.ReadInt32(baseAddress + offsets["dwEntityList"] + i * 0x10);
                    if (entity == 0)
                    {
                        continue;
                    }
                    int entityTeamID = mem.ReadInt32((IntPtr)entity + offsets["m_iTeamNum"]);
                    int entityGlow = mem.ReadInt32((IntPtr)entity + offsets["m_iGlowIndex"]);
                    if (entityTeamID == 2)
                    {
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0x4), 1);
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0x8), 0);
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0xC), 0);
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0x10), 1);
                        mem.WriteInt32((IntPtr)(glowManager + entityGlow * 0x38 + 0x24), 1);
                    }
                    else if (entityTeamID == 3)
                    {
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0x4), 0);
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0x8), 0);
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0xC), 1);
                        mem.WriteFloat((IntPtr)(glowManager + entityGlow * 0x38 + 0x10), 1);
                        mem.WriteInt32((IntPtr)(glowManager + entityGlow * 0x38 + 0x24), 1);
                    }
                }
                Thread.Sleep(1);
            }
        }
    }
}
