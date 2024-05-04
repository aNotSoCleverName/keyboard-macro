using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public class Class_Action
    {
        public static List<Class_Action> KeyActions { get; set; } = new List<Class_Action>();

        public enum Enum_ActionType
        {
            Press,
            Hold,
            Delay,
        }

        public string ActionType { get; set; }
        public string Key { get; set; }
        public string StrVk { get; set; }
        public string Duration { get; set; }

        public Class_Action(string inActionType, string inKey, string inStrVk, string inDuration)
        {
            this.ActionType = inActionType;
            this.Key = inKey;
            this.StrVk = inStrVk;
            this.Duration = inDuration;
        }

        // Set value to empty string if needed
        public void ActionToRow(DataGridViewRow inRow)
        {
            inRow.Cells[0].Value = this.ActionType;

            inRow.Cells[1].Value = this.Key;
            if (this.ActionType == Class_Action.Enum_ActionType.Delay.ToString())
                inRow.Cells[1].Value = "";

            inRow.Cells[2].Value = this.Duration;
            if (this.ActionType == Class_Action.Enum_ActionType.Press.ToString())
                inRow.Cells[2].Value = "";

            inRow.Cells[3].Value = this.StrVk;
            if (this.ActionType == Class_Action.Enum_ActionType.Delay.ToString())
                inRow.Cells[3].Value = "";
        }
    }
}
