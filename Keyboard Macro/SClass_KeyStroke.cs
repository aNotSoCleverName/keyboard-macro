using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace Keyboard_Macro
{
    public static class SClass_KeyStroke
    {
        static InputSimulator inputSimulator = new InputSimulator();
        public static void PressKey(string inStrVk)
        {
            //VirtualKeyCode vkCode = Class_SupportedKey.GetVkCodeFromStringKey(inStringKey);
            VirtualKeyCode vkCode = (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), inStrVk);
            inputSimulator.Keyboard.KeyPress(vkCode);
        }

        public static void HoldKey(string inStrVk, int inDurationInMiliSec)
        {
            //VirtualKeyCode vkCode = Class_SupportedKey.GetVkCodeFromStringKey(inStringKey);
            VirtualKeyCode vkCode = (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), inStrVk);
            inputSimulator.Keyboard.KeyDown(vkCode);
            inputSimulator.Keyboard.Sleep(inDurationInMiliSec);
            inputSimulator.Keyboard.KeyUp(vkCode);
        }

        public static void Wait(int inDurationInMiliSec)
        {
            inputSimulator.Keyboard.Sleep(inDurationInMiliSec);
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
    }
}
