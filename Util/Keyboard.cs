using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSGOHack.Util
{
    class Keyboard
    {
        public static bool IsPressed(Keys key)
        {
            byte[] result = BitConverter.GetBytes(GetAsyncKeyState(key));
            return result[1] == 0x80;
        }

        [DllImport("User32.dll")]
        private static extern short GetAsyncKeyState(Keys ArrowKeys);
    }
}
