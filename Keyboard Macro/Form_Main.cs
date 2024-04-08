using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        public Form_Main()
        {
            InitializeComponent();
            
        }

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

        private void OnRowAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            this.btn_ClearActions.Enabled = true;
            this.btn_SaveActions.Enabled = true;

            this.dgv_Action.Rows[e.RowIndex].Selected = true;
        }

        private void OnRowRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            this.btn_ClearActions.Enabled = this.dgv_Action.RowCount > 0;
            this.btn_SaveActions.Enabled = this.dgv_Action.RowCount > 0;
        }

        public Process selectedProcess;
        private void OnSetTargetWindow(object sender, EventArgs e)
        {
            (new Form_TargetWindow(this)).ShowDialog();

            if (this.selectedProcess == null)
            {
                this.tb_ProcessName.Text = "";
                this.tb_WindowTitle.Text = "";
                return;
            }

            this.tb_ProcessName.Text = selectedProcess.ProcessName;
            this.tb_WindowTitle.Text = selectedProcess.MainWindowTitle;
        }

        private void Form_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //if (this.simulationTask != null)
            //    this.simulationTask.Dispose();
        }
    }
}
