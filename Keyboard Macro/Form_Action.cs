using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public partial class Form_Action : Form
    {
        bool isEditting;
        DataGridView dgv_Action;
        Class_Action action;

        public Form_Action(bool inIsEditting, DataGridView inDgv_Action)
        {
            InitializeComponent();
            this.isEditting = inIsEditting;
            this.dgv_Action = inDgv_Action;

            //Add action types to combo box
            foreach (string str_ActionType in Enum.GetNames(typeof(Class_Action.Enum_ActionType)))
            {
                this.cb_ActionType.Items.Add(str_ActionType);
            }
            this.cb_ActionType.SelectedIndex = 0;

            //Set existing values to controls
            if (this.isEditting)
            {
                this.action = Class_Action.KeyActions[this.dgv_Action.SelectedRows[0].Index];

                this.cb_ActionType.Text = this.action.ActionType;
                this.tb_Key.Text = this.action.Key.ToString();
                this.nud_Duration.Value = Decimal.Parse(this.action.Duration);
            }
        }

        private void OnSelectActionType(object sender, EventArgs e)
        {
            Class_Action.Enum_ActionType selectedActionType = (Class_Action.Enum_ActionType)Enum.Parse(typeof(Class_Action.Enum_ActionType), this.cb_ActionType.Text);
            switch (selectedActionType)
            {
                case Class_Action.Enum_ActionType.Press:
                    this.label_Key.Enabled = true;
                    this.tb_Key.Enabled = true;
                    this.btn_SetKeyAction.Enabled = true;

                    this.label_Duration.Enabled = false;
                    this.nud_Duration.Enabled = false;
                    break;
                case Class_Action.Enum_ActionType.Hold:
                    this.label_Key.Enabled = true;
                    this.tb_Key.Enabled = true;
                    this.btn_SetKeyAction.Enabled = true;

                    this.label_Duration.Enabled = true;
                    this.nud_Duration.Enabled = true;
                    break;
                case Class_Action.Enum_ActionType.Delay:
                    this.label_Key.Enabled = false;
                    this.tb_Key.Enabled = false;
                    this.btn_SetKeyAction.Enabled = false;

                    this.label_Duration.Enabled = true;
                    this.nud_Duration.Enabled = true;
                    break;
            }
        }

        private void OnSetKey(object sender, EventArgs e)
        {
            (new Form_ReadKey(this.tb_Key)).ShowDialog();
        }

        private void OnApply(object sender, EventArgs e)
        {
            //Get value from controls
            string newActionType = this.cb_ActionType.Text;
            string newKey = this.tb_Key.Text;
            string newDuration = this.nud_Duration.Value.ToString();

            //If action requires key, but key is not set, return
            if (newActionType != Class_Action.Enum_ActionType.Delay.ToString() &&
                this.tb_Key.Text == "")
            {
                MessageBox.Show("Please set the key press");
                return;
            }

            //If adding
            DataGridViewRow selectedRow;
            if (!this.isEditting)
            {
                //List
                this.action = new Class_Action(newActionType, newKey, newDuration);
                Class_Action.KeyActions.Add(this.action);

                //DGV
                selectedRow = new DataGridViewRow();
                selectedRow.CreateCells(this.dgv_Action);
            }
            //If editting
            else
            {
                //List
                this.action.ActionType = newActionType;
                this.action.Key = newKey;
                this.action.Duration = newDuration;

                //DGV
                selectedRow = this.dgv_Action.SelectedRows[0];
            }

            this.action.CleanActionRow(selectedRow);
            //This has to be done after setting the value. Otherwise, it fucks with the index
            if (!this.isEditting)
                this.dgv_Action.Rows.Add(selectedRow);

            this.Close();
        }

        private void onCancel(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
