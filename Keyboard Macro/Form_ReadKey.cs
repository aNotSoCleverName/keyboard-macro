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
            this.tb_Result.Text = e.KeyCode.ToString();
            this.Close();
        }
    }
}
