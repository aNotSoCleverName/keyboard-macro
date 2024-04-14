using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HotkeyHook;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
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

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            HotkeyHook.Class_HookManager.UnsetAllHotkeys();
        }
    }
}
