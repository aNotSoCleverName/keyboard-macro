using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public static class Class_KeyStrokeSimulator
    {
        public static void PressKey(Process inProcess, string inStringKey)
        {
            Keys key = GetKeyFromKeyString(inStringKey);
            PressKey(inProcess, key);
        }

        public static void PressKey(Process inProcess, Keys inKey)
        {
            IntPtr processPtr = inProcess.MainWindowHandle;
            IntPtr keyPtr = (IntPtr)inKey;

            PostMessage(processPtr, WM_KEYDOWN, keyPtr, IntPtr.Zero);
            PostMessage(processPtr, WM_KEYUP, keyPtr, IntPtr.Zero);
        }

        public static async Task HoldKey(Process inProcess, string inStringKey, int inDurationInMiliSec)
        {
            Keys key = GetKeyFromKeyString(inStringKey);
            await HoldKey(inProcess, key, inDurationInMiliSec);
        }

        public static async Task HoldKey(Process inProcess, Keys inKey, int inDurationInMiliSec)
        {
            IntPtr processPtr = inProcess.MainWindowHandle;
            IntPtr keyPtr = (IntPtr)inKey;

            PostMessage(processPtr, WM_KEYDOWN, keyPtr, IntPtr.Zero);
            await Wait(inDurationInMiliSec);
            PostMessage(processPtr, WM_KEYUP, keyPtr, IntPtr.Zero);
        }

        public static async Task Wait(int inDurationInMiliSec)
        {
            await Task.Delay(inDurationInMiliSec);
        }

        public static int GetDurationInMiliSec(decimal inDurationInSec)
        {
            int intDuration = (Int32)(inDurationInSec * 1000);
            return intDuration;
        }

        public static int GetDurationInMiliSec(string inDurationInSec)
        {
            decimal decDuration = Decimal.Parse(inDurationInSec);
            return GetDurationInMiliSec(decDuration);
        }

        public static Keys GetKeyFromKeyString(string inKeyString)
        {
            return (Keys)Enum.Parse(typeof(Keys), inKeyString, ignoreCase:true);
        }

        static Process GetProcessFromName(string inProcessName)
        {
            Process[] processes = Process.GetProcesses();
            return processes.FirstOrDefault(process => process.ProcessName.Equals(inProcessName));
        }

        [DllImport("user32.dll")]
        static extern IntPtr PostMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);

        const uint WM_KEYDOWN = 0x100;
        const uint WM_KEYUP = 0x0101;
    }
}
