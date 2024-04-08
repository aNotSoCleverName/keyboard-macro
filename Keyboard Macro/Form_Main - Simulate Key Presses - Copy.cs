using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsInput;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        [DllImport("user32.dll", SetLastError = true)]
        static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        Task simulationTask;
        bool isPlaying = false;
        private async void btn_Play_Click(object sender, EventArgs e)
        {
            if (this.isPlaying)
            {
                this.StopSimulation();
                return;
            }

            string windowTitle = this.selectedProcess.MainWindowTitle;
            IntPtr hWnd = FindWindow(null, windowTitle);
            if (hWnd != IntPtr.Zero)
            {
                SetForegroundWindow(hWnd);
                this.isPlaying = true;

                this.stopSimulation = false;
                //Thread thread_KeySimulation = new Thread(() => StartKeySimulation());
                this.simulationTask = StartKeySimulation();
                await this.simulationTask;
                this.simulationTask.Dispose();
            }    
            else
            {
                Console.WriteLine("Window not found");
                MessageBox.Show("Window not found");
                return;
            }
        }

        int test = 0;
        private bool stopSimulation = false;
        private async Task StartKeySimulation()
        {
            var simulator = new InputSimulator();
            int repeatTimes = 0;

            while (!this.stopSimulation)
            {
                Console.WriteLine("REPEAT TIMES: " + repeatTimes.ToString());
                foreach (Class_Action keyAction in Class_Action.KeyActions)
                {
                    Console.WriteLine(test.ToString());
                    test++;
                    Class_Action.Enum_ActionType actionType = (Class_Action.Enum_ActionType) Enum.Parse(typeof(Class_Action.Enum_ActionType), keyAction.ActionType);

                    WindowsInput.Native.VirtualKeyCode vkCode;
                    switch (actionType)
                    {
                        case Class_Action.Enum_ActionType.Press:
                            vkCode = this.GetVKCodeFromStringKey(keyAction.Key);

                            simulator.Keyboard.KeyPress(vkCode);
                            break;
                        case Class_Action.Enum_ActionType.Hold:
                            vkCode = this.GetVKCodeFromStringKey(keyAction.Key);

                            simulator.Keyboard.KeyDown(vkCode);
                            await Task.Delay(GetDuration(keyAction.Duration));
                            simulator.Keyboard.KeyUp(vkCode);
                            break;
                        case Class_Action.Enum_ActionType.Delay:
                            await Task.Delay(GetDuration(keyAction.Duration));
                            break;
                    }
                }
                test = 0;
                repeatTimes++;
                await Task.Delay(GetDuration(nud_LoopInterval.Value));

                // Stop simulation when reaching repeat limit
                if (this.rb_RepeatXTimes.Checked && 
                    repeatTimes >= this.nud_RepeatXTimes.Value + 1)
                {
                    this.StopSimulation();
                }
            }
        }

        private void StopSimulation()
        {
            Console.WriteLine("STOPPING SIMULATION");
            stopSimulation = true;
            isPlaying = false;
        }

        private WindowsInput.Native.VirtualKeyCode GetVKCodeFromStringKey(string inStrKey)
        {
            string str_Vk = "VK_" + inStrKey;
            return (WindowsInput.Native.VirtualKeyCode)Enum.Parse(typeof(WindowsInput.Native.VirtualKeyCode), str_Vk);
        }

        private static int GetDuration(string inDurationString)
        {
            decimal decDuration = Decimal.Parse(inDurationString);
            int intDuration = (Int32) (decDuration * 1000);
            return intDuration;
        }

        private static int GetDuration(decimal inDurationDecimal)
        {
            int intDuration = (Int32)(inDurationDecimal * 1000);
            return intDuration;
        }
    }
}
