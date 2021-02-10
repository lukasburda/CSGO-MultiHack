using System;
using System.Diagnostics;
using System.Linq;

namespace CSGOHack.Util
{
    class Utils
    {
        public static IntPtr GetBaseAddress(String processName, String moduleName)
        {
            // Get an instance of the specified process
            Process process;

            try
            {
                process = Process.GetProcessesByName(processName)[0];
            }

            catch (IndexOutOfRangeException)
            {
                // The process isn't currently running
                throw new ArgumentException($"No process with name {processName} is currently running");
            }

            // Get an instance of the specified module in the process
            // We use linq here to avoid unnecesary for loops

            var module = process.Modules.Cast<ProcessModule>().SingleOrDefault(m => string.Equals(m.ModuleName, moduleName, StringComparison.OrdinalIgnoreCase));

            // Attempt to get the base address of the module - Return IntPtr.Zero if the module doesn't exist in the process
            return module?.BaseAddress ?? IntPtr.Zero;
        }
    }
}
