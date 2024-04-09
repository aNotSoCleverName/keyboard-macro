using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        private void btn_PlayStop_Click(object sender, EventArgs e)
        {
            // Set selectedProcess
            Process selectedProcess;
            {
                Process[] processes = Process.GetProcesses();
                selectedProcess = processes.FirstOrDefault(process => process.ProcessName.Equals(tb_ProcessName.Text) &&
                                                                      process.MainWindowTitle.Equals(tb_WindowTitle.Text));
            }

            if (selectedProcess == null)
            {
                InformNoWindowFound();
                return;
            }

            // If simulation is already playing, stop
            if (SClass_KeySimulation.IsPlaying)
            {
                SClass_KeySimulation.StopSimulation();
                return;
            }

            IntPtr hWnd = selectedProcess.MainWindowHandle;
            SetForegroundWindow(hWnd);

            SClass_KeySimulation.StartSimulation(this.btn_PlayStop, nud_LoopInterval.Value, rb_RepeatFinite.Checked, (int) nud_RepeatFinite.Value);
        }

        private static void InformNoWindowFound()
        {
            Console.WriteLine("Window not found");
            MessageBox.Show("Window not found");
        }
    }
}
