using System;
using System.Collections.Generic;
using System.Windows.Forms;
using CSGOHack.Hack;
using CSGOHack.Offset;
using CSGOHack.Util;

namespace CSGOHack
{
    public partial class MainWindow : Form
    {
        public static readonly String PROCESS_NAME = "csgo";
        public static readonly String DLL_NAME = "client.dll";

        private static readonly Dictionary<HackNames, AbstractHack> hacks = new Dictionary<HackNames, AbstractHack>();

        public MainWindow()
        {
            InitializeComponent();
            VAMemory mem = new VAMemory(PROCESS_NAME);
            IntPtr baseAddress = Utils.GetBaseAddress(PROCESS_NAME, DLL_NAME);
            Dictionary<String, int> offsets = OffsetParser.ParseOffsets("csgo.CT");

            hacks.Add(HackNames.AntiFlash, new AntiFlashHack(mem, baseAddress, offsets));
            hacks.Add(HackNames.BunnyHop, new BunnyHopHack(mem, baseAddress, offsets));
            hacks.Add(HackNames.WallHack, new WallHack(mem, baseAddress, offsets));
        }

        private void antiFlashCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            processHackStateChange(antiFlashCheckbox.Checked, HackNames.AntiFlash);
        }

        private void wallHackCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            processHackStateChange(wallHackCheckbox.Checked, HackNames.WallHack);
        }

        private void bunnyHopCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            bool checkboxChecked = bunnyHopCheckbox.Checked;
            if (checkboxChecked)
            {
                MessageBox.Show("Bunny hop is triggered by holding Left-Alt", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            processHackStateChange(checkboxChecked, HackNames.BunnyHop);
        }

        private void processHackStateChange(bool checkboxTick, HackNames hackName)
        {
            AbstractHack targetHack = hacks[hackName];
            if (checkboxTick)
            {
                targetHack.Start();
            }
            else
            {
                targetHack.Stop();
            }
        }
    }
}
