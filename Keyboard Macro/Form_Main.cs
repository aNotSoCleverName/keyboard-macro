using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HotkeyHook;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        // Gets name of application, minus the ".exe"
        public static string appName = AppDomain.CurrentDomain.FriendlyName.Substring(0, AppDomain.CurrentDomain.FriendlyName.Length-4);

        public Form_Main()
        {
            InitializeComponent();
            Console.WriteLine(Keys.NumPad0.ToString());
        }

        const string projectsDirPath = ".\\Projects\\";
        const string tempProjectPath = projectsDirPath + ".temp.xml";
        private void Form_Main_Load(object sender, EventArgs e)
        {
            this.cb_PlayKey.Text = SClass_Config.LoadHotkey().ToString();

            // Load temp project
            if (File.Exists(tempProjectPath))
            {
                SClass_SaveLoad.CurrentPath = projectsDirPath;
                SClass_SaveLoad.Load(tempProjectPath,
                                     this.tb_ProcessName, this.tb_WindowTitle,
                                     this.rb_RepeatInfinite, this.rb_RepeatFinite, this.nud_RepeatFinite,
                                     this.nud_LoopInterval,
                                     this.dgv_Action);
            }
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save hotkey
            HotkeyHook.Enum_SupportedKeys playStopHotkey = HotkeyHook.Class_SupportedKeys.GetEnumNameFromString(cb_PlayKey.Text);
            SClass_Config.SaveHotkey(playStopHotkey);

            // Unset hotkey
            HotkeyHook.Class_HookManager.UnsetAllHotkeys();

            // Save current project as temp
            SClass_SaveLoad.CurrentPath = projectsDirPath;
            SClass_SaveLoad.Save(tempProjectPath,
                                    this.tb_ProcessName.Text, this.tb_WindowTitle.Text,
                                    this.rb_RepeatFinite.Checked, this.nud_RepeatFinite.Value,
                                    this.nud_LoopInterval.Value);
        }

        // Enable/disable buttons when row is selected
        private void OnRowSelected(object sender, EventArgs e)
        {
            int selectedIndex = -1;
            if (this.dgv_Action.SelectedRows.Count > 0)
                selectedIndex = this.dgv_Action.SelectedRows[0].Index;

            this.btn_EditAction.Enabled = selectedIndex > -1;
            this.btn_DeleteAction.Enabled = selectedIndex > -1;

            this.btn_ActionUp.Enabled = selectedIndex > 0;
            this.btn_ActionDown.Enabled = selectedIndex < this.dgv_Action.RowCount - 1;
        }

        // Enable buttons when row is added, and select new row
        private void OnRowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btn_ClearActions.Enabled = true;
            this.btn_SaveActions.Enabled = true;

            this.dgv_Action.Rows[e.RowIndex].Selected = true;
        }

        // Disable buttons when no row left
        private void OnRowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.btn_ClearActions.Enabled = this.dgv_Action.RowCount > 0;
            this.btn_SaveActions.Enabled = this.dgv_Action.RowCount > 0;
        }

        // Opens form to select target process to play macro on
        private void btn_SetTargetWindow_Click(object sender, EventArgs e)
        {
            (new Form_TargetWindow(this)).ShowDialog();
        }

        // Set hotkey for playing macro
        string prevStrHotkey = "";
        private void cb_PlayKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Unhook previous hotkey
            {
                HotkeyHook.Enum_SupportedKeys prevHotkey = HotkeyHook.Class_SupportedKeys.GetEnumNameFromString(prevStrHotkey);
                HotkeyHook.Class_HookManager.UnsetHotkey(prevHotkey);
                prevStrHotkey = cb_PlayKey.Text;
            }

            HotkeyHook.Enum_SupportedKeys newHotkey = HotkeyHook.Class_SupportedKeys.GetEnumNameFromString(cb_PlayKey.Text);
            HotkeyHook.Class_HookManager.SetHotkeyGlobal(newHotkey, this.TogglePlayStopSimulation);
        }
    }
}
