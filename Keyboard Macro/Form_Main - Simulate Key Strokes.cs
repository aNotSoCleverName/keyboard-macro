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
            TogglePlayStopSimulation(new Dictionary<string, object>());   
        }

        private void TogglePlayStopSimulation(Dictionary<string, object> inObject)
        {
            // If simulation is already playing, stop
            if (SClass_KeySimulation.IsPlaying || SClass_KeySimulation.SimulationTask != null)
            {
                SClass_KeySimulation.IsStopSimulation = true;
                return;
            }

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

            IntPtr hWnd = selectedProcess.MainWindowHandle;
            SetForegroundWindow(hWnd);

            SClass_KeySimulation.StartSimulation(this.btn_PlayStop, this.nud_LoopInterval.Value, this.rb_RepeatFinite.Checked, (int)this.nud_RepeatFinite.Value);
        }

        private static void InformNoWindowFound()
        {
            SetForegroundWindow(Process.GetCurrentProcess().MainWindowHandle);
            Console.WriteLine("Window not found");
            MessageBox.Show("Window not found");
        }
    }
}
