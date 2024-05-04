using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    // Singleton class used to simulate key strokes
    public static class SClass_KeySimulation
    {
        public static Button Btn_PlayStop { get; set; }
        public static bool IsPlaying { get; set; } = false;
        public static bool IsStopSimulation { get; set; } = false;

        public static Task SimulationTask;

        public static async void StartSimulation(Button inBtn_PlayStop, decimal inLoopIntervalInSec, bool inIsRepeatFinite, int inRepeatTimes)
        {
            Btn_PlayStop = inBtn_PlayStop;

            Btn_PlayStop.Text = "Stop";
            IsPlaying = true;
            IsStopSimulation = false;

            SimulationTask = new Task(() => SimulateKeys(inLoopIntervalInSec, inIsRepeatFinite, inRepeatTimes));
            SimulationTask.Start();
            await SimulationTask;

            SimulationTask.Dispose();
            SimulationTask = null;

            StopSimulation();
        }

        public static void StopSimulation()
        {
            Console.WriteLine("STOPPING SIMULATION");

            Btn_PlayStop.Text = "Play";
            IsPlaying = false;
        }

        private static void SimulateKeys(decimal inLoopIntervalInSec, bool inIsRepeatFinite, int inRepeatTimes)
        {
            int repeatTimes = 0;
            int delayBetweenLoop = SClass_KeyStroke.GetDurationInMiliSec(inLoopIntervalInSec);

            while (!IsStopSimulation)
            {
                for (int nthKeyAction = 0; nthKeyAction < Class_Action.KeyActions.Count; nthKeyAction++)
                {
                    Class_Action keyAction = Class_Action.KeyActions[nthKeyAction];

                    // Get action type enum from string
                    Class_Action.Enum_ActionType actionType = (Class_Action.Enum_ActionType)Enum.Parse(typeof(Class_Action.Enum_ActionType), keyAction.ActionType);

                    int duration;       // Hold duration or delay duration
                    switch (actionType)
                    {
                        case Class_Action.Enum_ActionType.Press:
                            SClass_KeyStroke.PressKey(keyAction.StrVk);
                            break;
                        case Class_Action.Enum_ActionType.Hold:
                            duration = SClass_KeyStroke.GetDurationInMiliSec(keyAction.Duration);
                            SClass_KeyStroke.HoldKey(keyAction.StrVk, duration);
                            break;
                        case Class_Action.Enum_ActionType.Delay:
                            duration = SClass_KeyStroke.GetDurationInMiliSec(keyAction.Duration);
                            SClass_KeyStroke.Wait(duration);
                            break;
                    }

                    if (IsStopSimulation)
                        break;
                }
                repeatTimes++;
                SClass_KeyStroke.Wait(delayBetweenLoop);

                // Stop simulation when reaching repeat limit
                if (inIsRepeatFinite &&
                    repeatTimes >= inRepeatTimes + 1)
                {
                    break;
                }
            }
        }
    }
}
