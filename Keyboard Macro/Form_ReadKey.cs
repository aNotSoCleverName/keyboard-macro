using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using WindowsInput.Native;

namespace Keyboard_Macro
{
    public partial class Form_ReadKey : Form
    {
        const string pressAnyKey = "Press Any Key";
        const string keyNotSupported = "Key Not Supported";

        TextBox tb_Result;

        public Form_ReadKey(TextBox inTb_Result)
        {
            InitializeComponent();

            this.tb_Result = inTb_Result;
        }

        private void Form_ReadKey_KeyUp(object sender, KeyEventArgs e)
        {
            string strKey = e.KeyCode.ToString();

            /// <summary>
            /// Numbers that don't come from numpad have the string key of D0, D1, D2, ...
            /// VK code that InputSimulator use is in the format of VK_0, VK_1, VK_2, ... without the D
            /// This code removes the D
            /// Numbers that come from numpad have the string key of Numpad0, Numpad1, Numpad2
            /// VK code that InputSimulator use is in the format of NUMPAD0, NUMPAD1, NUMPAD2, ..., so it's doesn't require "string cleaning" like non-numpad number does
            /// </summary>
            if (isNonNumPadDigit(e.KeyCode))
                strKey = strKey.Last().ToString();

            if (!Class_SupportedKey.isKeySupported(strKey))
            {
                // Inform key is not supported
                if (!this.timer_KeyNotSupported.Enabled)
                {
                    this.label_PressAnyKey.Text = keyNotSupported;
                    this.timer_KeyNotSupported.Start();
                }
                return;
            }

            this.tb_Result.Text = Class_SupportedKey.GetShownKeyName(strKey).ToString();
            this.tb_Result.Tag = Class_SupportedKey.GetVkCodeFromStringKey(strKey).ToString();
            this.Close();
        }

        bool isNonNumPadDigit(Keys inKey)
        {
            return (inKey >= Keys.D0 && inKey <= Keys.D9);
        }

        private void timer_KeyNotSupported_Tick(object sender, EventArgs e)
        {
            this.label_PressAnyKey.Text = pressAnyKey;
            this.timer_KeyNotSupported.Enabled = false;
        }
    }
}
