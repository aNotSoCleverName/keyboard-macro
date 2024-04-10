using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public partial class Form_ReadKey : Form
    {
        TextBox tb_Result;

        public Form_ReadKey(TextBox inTb_Result)
        {
            InitializeComponent();

            this.tb_Result = inTb_Result;
        }

        private void Form_ReadKey_KeyUp(object sender, KeyEventArgs e)
        {
            string strKey = e.KeyCode.ToString();
            
            // Numbers that don't come from numpad have the string key of D0, D1, D2, ...
            // VK code that InputSimulator use is in the format of VK_0, VK_1, VK_2, ... without the D
            // This code removes the D
            // Numbers that come from numpad have the string key of Numpad0, Numpad1, Numpad2
            // VK code that InputSimulator use is in the format of VK_NUMPAD0, VK_NUMPAD1, VK_NUMPAD2, ..., so it's doesn't require "string cleaning"
            if (isNonNumPadDigit(e.KeyCode))
                strKey = strKey[1].ToString();
            
            if (!SClass_KeyStroke.isVkSupported(strKey))
                return;

            this.tb_Result.Text = strKey;
            this.Close();
        }

        bool isNonNumPadDigit(Keys inKey)
        {
            return (inKey >= Keys.D0 && inKey <= Keys.D9);
        }
    }
}
