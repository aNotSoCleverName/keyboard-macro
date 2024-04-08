using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public class Class_Action
    {
        static List<Class_Action> _keyActions = new List<Class_Action>();

        public enum Enum_ActionType
        {
            Press,
            Hold,
            Delay,
        }

        string _actionType;
        string _key;
        string _duration;

        public Class_Action(string inActionType, string inKey, string inDuration)
        {
            this.ActionType = inActionType;
            this.Key = inKey;
            this.Duration = inDuration;
        }

        public void CleanActionRow(DataGridViewRow inRow)
        {
            inRow.Cells[0].Value = this.ActionType;

            inRow.Cells[1].Value = this.Key;
            if (this.ActionType == Class_Action.Enum_ActionType.Delay.ToString())
                inRow.Cells[1].Value = "";

            inRow.Cells[2].Value = this.Duration;
            if (this.ActionType == Class_Action.Enum_ActionType.Press.ToString())
                inRow.Cells[2].Value = "";
        }

        //Get/set
        public static List<Class_Action> KeyActions { get => _keyActions; set => _keyActions = value; }
        public string ActionType { get => _actionType; set => _actionType = value; }
        public string Key { get => _key; set => _key = value; }
        public string Duration { get => _duration; set => _duration = value; }
    }
}
