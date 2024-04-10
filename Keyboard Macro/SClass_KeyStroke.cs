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
        public static void PressKey(string inStringKey)
        {
            VirtualKeyCode vkCode = GetVkCodeFromStringKey(inStringKey);
            inputSimulator.Keyboard.KeyPress(vkCode);
        }

        public static void HoldKey(string inStringKey, int inDurationInMiliSec)
        {
            VirtualKeyCode vkCode = GetVkCodeFromStringKey(inStringKey);
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

        public static bool isVkSupported(string inStrKey)
        {
            try
            {
                GetVkCodeFromStringKey(inStrKey);
                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        // Turns the string in the DGV to VK Code
        static VirtualKeyCode GetVkCodeFromStringKey(string inStrKey)
        {
            VirtualKeyCode vkCode;

            if (isNonNumPadDigit(inStrKey))
            {
                vkCode = (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), inStrKey);
                return vkCode;
            }

            // Try just adding VK_ to beginning of string key
            try
            {
                string str_Vk = "VK_" + inStrKey.ToUpper();
                vkCode = (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), str_Vk);
            }
            // Find in dictionary if failed
            catch
            {
                vkCode = dict_SupportedKeys[inStrKey];
            }

            return vkCode;
        }

        static bool isNonNumPadDigit(string inStrKey)
        {
            if (inStrKey.Length > 1)
                return false;

            return Char.IsDigit(inStrKey[0]);
        }

        private static Dictionary<string, VirtualKeyCode> dict_SupportedKeys = new Dictionary<string, VirtualKeyCode>()
        {
            // NumPad number
            { Keys.NumPad0.ToString(), VirtualKeyCode.NUMPAD0 },
            { Keys.NumPad1.ToString(), VirtualKeyCode.NUMPAD1 },
            { Keys.NumPad2.ToString(), VirtualKeyCode.NUMPAD2 },
            { Keys.NumPad3.ToString(), VirtualKeyCode.NUMPAD3 },
            { Keys.NumPad4.ToString(), VirtualKeyCode.NUMPAD4 },
            { Keys.NumPad5.ToString(), VirtualKeyCode.NUMPAD5 },
            { Keys.NumPad6.ToString(), VirtualKeyCode.NUMPAD6 },
            { Keys.NumPad7.ToString(), VirtualKeyCode.NUMPAD7 },
            { Keys.NumPad8.ToString(), VirtualKeyCode.NUMPAD8 },
            { Keys.NumPad9.ToString(), VirtualKeyCode.NUMPAD9 },

            // Arrow Keys
            { Keys.Left.ToString(), VirtualKeyCode.LEFT },
            { Keys.Right.ToString(), VirtualKeyCode.RIGHT },
            { Keys.Up.ToString(), VirtualKeyCode.UP },
            { Keys.Down.ToString(), VirtualKeyCode.DOWN },

            { Keys.Space.ToString(), VirtualKeyCode.SPACE },
            { Keys.Enter.ToString(), VirtualKeyCode.RETURN },

            // Math
            { Keys.Oemplus.ToString(), VirtualKeyCode.OEM_PLUS },
            { Keys.OemMinus.ToString(), VirtualKeyCode.OEM_MINUS },

            // Punctuation
            { Keys.Oemcomma.ToString(), VirtualKeyCode.OEM_COMMA },
            { Keys.OemPeriod.ToString(), VirtualKeyCode.OEM_PERIOD },
        };
    }
}
