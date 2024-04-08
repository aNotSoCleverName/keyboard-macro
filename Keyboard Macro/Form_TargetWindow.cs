using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Keyboard_Macro
{
    public partial class Form_TargetWindow : Form
    {
        Process[] list_Process = Process.GetProcesses();
        Form_Main form_Main;

        public Form_TargetWindow(Form_Main inForm_Main)
        {
            InitializeComponent();
            this.SetWindowTitles();

            this.form_Main = inForm_Main;
        }

        void SetWindowTitles()
        {
            foreach (Process process in list_Process)
            {
                if (this.list_HiddenProcessNames.Contains(process.ProcessName))
                    continue;

                if (String.IsNullOrEmpty(process.MainWindowTitle))
                    continue;

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(this.dgv_Windows);

                newRow.Cells[0].Value = this.tryGetIcon(process);
                newRow.Cells[1].Value = process.ProcessName;
                newRow.Cells[2].Value = process.MainWindowTitle;

                this.dgv_Windows.Rows.Add(newRow);
            }
            this.dgv_Windows.ClearSelection();
        }

        Icon tryGetIcon(Process inProcess)
        {
            try
            {
                return Icon.ExtractAssociatedIcon(inProcess.MainModule.FileName);
            }
            catch
            {
                return null;
            }
        }

        void SelectProcess()
        {
            DataGridViewRow selectedRow = this.dgv_Windows.SelectedRows[0];
            string selectedWindowName = selectedRow.Cells[this.dgvCol_WindowTitle.Name].Value.ToString();
            form_Main.selectedProcess = list_Process.FirstOrDefault(process => process.MainWindowTitle.Equals(selectedWindowName));

            this.Close();
        }

        private void btn_Select_Click(object sender, EventArgs e)
        {
            this.SelectProcess();
        }

        private void dgv_Windows_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.SelectProcess();
        }

        private string[] list_HiddenProcessNames = new string[]
        {
            Process.GetCurrentProcess().ProcessName,
            "Microsoft.Media.Player",
            "Maps",
            "ApplicationFrameHost",
            "Taskmgr",
            "SystemSettings",
            "TextInputHost",
        };
    }
}
