using Keyboard_Macro.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
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
            bool isCanceled = !ShowFileDialogWithInitDirAndFileName(this.saveFileDialog1, e);
            if (isCanceled)
                return;

            SClass_SaveLoad.Save(this.saveFileDialog1.FileName,
                                 this.tb_ProcessName.Text, this.tb_WindowTitle.Text,
                                 this.rb_RepeatFinite.Checked, this.nud_RepeatFinite.Value,
                                 this.nud_LoopInterval.Value);
            this.SetSaveFileToFormText(Path.GetFileName(this.saveFileDialog1.FileName));
        }

        private void btn_LoadActions_Click(object sender, EventArgs e)
        {
            bool isCanceled = !ShowFileDialogWithInitDirAndFileName(this.openFileDialog1, e);
            if (isCanceled)
                return;

            // Cancel load if not clear actions
            if (!this.ClearActions())
                return;

            SClass_SaveLoad.Load(this.openFileDialog1.FileName,
                                 this.tb_ProcessName, this.tb_WindowTitle,
                                 this.rb_RepeatInfinite, this.rb_RepeatFinite, this.nud_RepeatFinite,
                                 this.nud_LoopInterval,
                                 this.dgv_Action);
            this.SetSaveFileToFormText(Path.GetFileName(this.openFileDialog1.FileName));
        }

        private bool ShowFileDialogWithInitDirAndFileName(FileDialog sender, EventArgs e)
        {
            if (!Directory.Exists(SClass_SaveLoad.CurrentPath))
            {
                Directory.CreateDirectory(SClass_SaveLoad.CurrentPath);
            }

            // Restore dialog init directory and file name
            sender.InitialDirectory = SClass_SaveLoad.CurrentPath;
            sender.FileName = SClass_SaveLoad.CurrentFile == "" ?
                              "untitled" :
                              Path.GetFileName(SClass_SaveLoad.CurrentFile);

            // Cancel save
            if (sender.ShowDialog() != DialogResult.OK)
                return false;

            // Set dialog init directory and file name
            SClass_SaveLoad.CurrentPath = sender.InitialDirectory;
            SClass_SaveLoad.CurrentFile = sender.FileName;

            return true;
        }

        private void SetSaveFileToFormText(string inFileName)
        {
            this.Text = Form_Main.appName + " - " + inFileName;
        }
    }
}
