using Keyboard_Macro.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        private void btn_SaveActions_Click(object sender, EventArgs e)
        {
            // Restore dialog init directory
            this.saveFileDialog1.InitialDirectory = SClass_SaveLoad.CurrentPath;

            // Cancel save
            if (this.saveFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            // Set dialog init directory
            SClass_SaveLoad.CurrentPath = this.saveFileDialog1.InitialDirectory;

            SClass_SaveLoad.Save(this.saveFileDialog1.FileName,
                                 this.tb_ProcessName.Text, this.tb_WindowTitle.Text,
                                 this.rb_RepeatFinite.Checked, this.nud_RepeatFinite.Value,
                                 this.nud_LoopInterval.Value);
        }

        private void btn_LoadActions_Click(object sender, EventArgs e)
        {
            // Restore dialog init directory
            this.openFileDialog1.InitialDirectory = SClass_SaveLoad.CurrentPath;

            // Cancel load
            if (this.openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

            // Set dialog init directory
            SClass_SaveLoad.CurrentPath = this.openFileDialog1.InitialDirectory;

            // Cancel load if not clear actions
            if (!this.ClearActions())
                return;

            SClass_SaveLoad.Load(this.openFileDialog1.FileName,
                                 this.tb_ProcessName, this.tb_WindowTitle,
                                 this.rb_RepeatInfinite, this.rb_RepeatFinite, this.nud_RepeatFinite,
                                 this.nud_LoopInterval,
                                 this.dgv_Action);
            this.Text = Form_Main.appName + " - " + this.openFileDialog1.FileName;
        }
    }
}
