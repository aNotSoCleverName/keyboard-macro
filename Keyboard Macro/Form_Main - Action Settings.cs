using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Keyboard_Macro
{
    public partial class Form_Main : Form
    {
        private void OnAddOrEditAction(object sender, EventArgs e)
        {
            bool isEditting = (Button)sender == this.btn_EditAction;

            Form_Action form_Action = new Form_Action(isEditting, this.dgv_Action);
            form_Action.ShowDialog();
        }

        private void OnDeleteAction(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Delete selected action?", "Confirm Deletion", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                return;

            int deletedIndex = this.dgv_Action.SelectedRows[0].Index;
            Class_Action.KeyActions.RemoveAt(deletedIndex);
            this.dgv_Action.Rows.RemoveAt(deletedIndex);
        }

        private void OnClearActions(object sender, EventArgs e)
        {
            this.ClearActions();
        }

        bool ClearActions()
        {
            DialogResult result = MessageBox.Show("Clear ALL actions?", "Confirm Clear", MessageBoxButtons.YesNo);
            if (result != DialogResult.Yes)
                return false;

            Class_Action.KeyActions.Clear();
            while (this.dgv_Action.Rows.Count > 0)
            {
                this.dgv_Action.Rows.RemoveAt(0);
            }
            return true;
        }

        private void OnMoveActionUpOrDown(object sender, EventArgs e)
        {
            bool isMoveUp = (Button)sender == this.btn_ActionUp;
            int selectedIndex = this.dgv_Action.SelectedRows[0].Index;

            int indexOffset = 1;
            if (isMoveUp)
                indexOffset = -1;

            //List
            Class_Action selectedAction = Class_Action.KeyActions[selectedIndex];
            Class_Action.KeyActions.Remove(selectedAction);
            Class_Action.KeyActions.Insert(selectedIndex + indexOffset, selectedAction);

            //DGV
            DataGridViewRow selectedRow = this.dgv_Action.Rows[selectedIndex];
            this.dgv_Action.Rows.Remove(selectedRow);
            this.dgv_Action.Rows.Insert(selectedIndex + indexOffset, selectedRow);
        }
    }
}
