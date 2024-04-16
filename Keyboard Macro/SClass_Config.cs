using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard_Macro
{
    public static class SClass_Config
    {
        const string playStopHotkey = "playStopHotkey";     //Must match with the name in application settings
        public static HotkeyHook.Enum_SupportedKeys LoadHotkey()
        {
            return Properties.Settings.Default.playStopHotkey;
        }

        public static void SaveHotkey(HotkeyHook.Enum_SupportedKeys inHotkey)
        {
            Properties.Settings.Default[playStopHotkey] = inHotkey;
            Properties.Settings.Default.Save();
        }
    }
}
