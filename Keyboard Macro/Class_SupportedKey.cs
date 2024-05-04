using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput.Native;

namespace Keyboard_Macro
{
    // List of supported keys on the bottom
    public class Class_SupportedKey
    {
        string shownKeyName;        // The string shown in the "Key" column in DGV
        string strKey;              // The string that is received upon key up in Form_ReadKey
        VirtualKeyCode vkCode;      // Vk code to interact with InputSimulator

        private Class_SupportedKey(string inShownKeyName, string inStrKey, VirtualKeyCode inVkCode)
        {
            shownKeyName = inShownKeyName;
            strKey = inStrKey;
            vkCode = inVkCode;
        }

        public static bool isKeySupported(string inStrKey)
        {
            return GetVkCodeFromStringKey(inStrKey) != VirtualKeyCode.ESCAPE;
        }

        public static string GetShownKeyName(string inStrKey)
        {
            Class_SupportedKey keyFoundInList = list_SupportedKeys.FirstOrDefault(key => key.strKey.Equals(inStrKey));
            if (keyFoundInList != null)
                return keyFoundInList.shownKeyName;

            return inStrKey;
        }

        // Returns ESC VK code if not supported
        public static VirtualKeyCode GetVkCodeFromStringKey(string inStrKey)
        {
            // Try just adding VK_ to beginning of string key
            try
            {
                string str_Vk = "VK_" + inStrKey.ToUpper();
                return (VirtualKeyCode)Enum.Parse(typeof(VirtualKeyCode), str_Vk);
            }
            // Find in list if failed
            catch
            {
                Class_SupportedKey supportedKey = list_SupportedKeys.FirstOrDefault(key => key.strKey.Equals(inStrKey));
                if (supportedKey != null)
                    return supportedKey.vkCode;
                else
                    return VirtualKeyCode.ESCAPE;
            }
        }

        // Supported keys = Letters + digits + keys in the following list
        static List<Class_SupportedKey> list_SupportedKeys = new List<Class_SupportedKey>()
        {
            // NumPad numbers
            new Class_SupportedKey("NumPad0", Keys.NumPad0.ToString(), VirtualKeyCode.NUMPAD0),
            new Class_SupportedKey("NumPad1", Keys.NumPad1.ToString(), VirtualKeyCode.NUMPAD1),
            new Class_SupportedKey("NumPad2", Keys.NumPad2.ToString(), VirtualKeyCode.NUMPAD2),
            new Class_SupportedKey("NumPad3", Keys.NumPad3.ToString(), VirtualKeyCode.NUMPAD3),
            new Class_SupportedKey("NumPad4", Keys.NumPad4.ToString(), VirtualKeyCode.NUMPAD4),
            new Class_SupportedKey("NumPad5", Keys.NumPad5.ToString(), VirtualKeyCode.NUMPAD5),
            new Class_SupportedKey("NumPad6", Keys.NumPad6.ToString(), VirtualKeyCode.NUMPAD6),
            new Class_SupportedKey("NumPad7", Keys.NumPad7.ToString(), VirtualKeyCode.NUMPAD7),
            new Class_SupportedKey("NumPad8", Keys.NumPad8.ToString(), VirtualKeyCode.NUMPAD8),
            new Class_SupportedKey("NumPad9", Keys.NumPad9.ToString(), VirtualKeyCode.NUMPAD9),

            // Arrow Keys
            new Class_SupportedKey("←", Keys.Left.ToString(), VirtualKeyCode.LEFT),
            new Class_SupportedKey("→", Keys.Right.ToString(), VirtualKeyCode.RIGHT),
            new Class_SupportedKey("↑", Keys.Up.ToString(), VirtualKeyCode.UP),
            new Class_SupportedKey("↓", Keys.Down.ToString(), VirtualKeyCode.DOWN),

            // Space + Enter
            new Class_SupportedKey("[Space]", Keys.Space.ToString(), VirtualKeyCode.SPACE),
            new Class_SupportedKey("[Enter]", Keys.Enter.ToString(), VirtualKeyCode.RETURN),

            // Math
            new Class_SupportedKey("= [Plus]", Keys.Oemplus.ToString(), VirtualKeyCode.OEM_PLUS),
            new Class_SupportedKey("- [Minus]", Keys.OemMinus.ToString(), VirtualKeyCode.OEM_MINUS),

            // Punctuation
            new Class_SupportedKey(", [Comma]", Keys.Oemcomma.ToString(), VirtualKeyCode.OEM_COMMA),
            new Class_SupportedKey(". [Period]", Keys.OemPeriod.ToString(), VirtualKeyCode.OEM_PERIOD),
        };
    }
}
