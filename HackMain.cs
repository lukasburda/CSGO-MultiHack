using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CSGOHack.Hack;
using CSGOHack.Offset;
using CSGOHack.Util;

namespace CSGOHack
{
    class HackMain
    {
        public static readonly String PROCESS_NAME = "csgo";
        public static readonly String DLL_NAME = "client.dll";

        private static readonly List<AbstractHack> hacks = new List<AbstractHack>();

        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            MainWindow form = new MainWindow();

            VAMemory mem = new VAMemory(PROCESS_NAME);
            IntPtr baseAddress = Utils.GetBaseAddress(PROCESS_NAME, DLL_NAME);
            Dictionary<String, int> offsets = OffsetParser.ParseOffsets("csgo.CT");
            
            hacks.Add(new WallHack(mem, baseAddress, offsets));
            hacks.Add(new AntiFlashHack(mem, baseAddress, offsets));
            foreach (AbstractHack hack in hacks)
            {
                hack.Start();
            }

            Application.Run(form);
        }
    }
}
