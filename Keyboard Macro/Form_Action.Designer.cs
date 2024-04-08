namespace Keyboard_Macro
{
    partial class Form_Action
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tb_Key = new System.Windows.Forms.TextBox();
            this.label_Key = new System.Windows.Forms.Label();
            this.label_ActionType = new System.Windows.Forms.Label();
            this.label_Duration = new System.Windows.Forms.Label();
            this.cb_ActionType = new System.Windows.Forms.ComboBox();
            this.btn_SetKeyAction = new System.Windows.Forms.Button();
            this.nud_Duration = new System.Windows.Forms.NumericUpDown();
            this.btn_Apply = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Duration)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Key
            // 
            this.tb_Key.Location = new System.Drawing.Point(92, 41);
            this.tb_Key.Name = "tb_Key";
            this.tb_Key.ReadOnly = true;
            this.tb_Key.Size = new System.Drawing.Size(124, 20);
            this.tb_Key.TabIndex = 0;
            // 
            // label_Key
            // 
            this.label_Key.Location = new System.Drawing.Point(6, 39);
            this.label_Key.Name = "label_Key";
            this.label_Key.Size = new System.Drawing.Size(80, 23);
            this.label_Key.TabIndex = 1;
            this.label_Key.Text = "Key:";
            this.label_Key.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_ActionType
            // 
            this.label_ActionType.Location = new System.Drawing.Point(6, 10);
            this.label_ActionType.Name = "label_ActionType";
            this.label_ActionType.Size = new System.Drawing.Size(80, 23);
            this.label_ActionType.TabIndex = 3;
            this.label_ActionType.Text = "Action Type:";
            this.label_ActionType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_Duration
            // 
            this.label_Duration.Location = new System.Drawing.Point(6, 65);
            this.label_Duration.Name = "label_Duration";
            this.label_Duration.Size = new System.Drawing.Size(80, 23);
            this.label_Duration.TabIndex = 5;
            this.label_Duration.Text = "Duration (sec):";
            this.label_Duration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cb_ActionType
            // 
            this.cb_ActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ActionType.FormattingEnabled = true;
            this.cb_ActionType.Location = new System.Drawing.Point(92, 12);
            this.cb_ActionType.Name = "cb_ActionType";
            this.cb_ActionType.Size = new System.Drawing.Size(195, 21);
            this.cb_ActionType.TabIndex = 0;
            this.cb_ActionType.SelectedIndexChanged += new System.EventHandler(this.OnSelectActionType);
            // 
            // btn_SetKeyAction
            // 
            this.btn_SetKeyAction.ForeColor = System.Drawing.Color.Black;
            this.btn_SetKeyAction.Location = new System.Drawing.Point(222, 39);
            this.btn_SetKeyAction.Name = "btn_SetKeyAction";
            this.btn_SetKeyAction.Size = new System.Drawing.Size(65, 23);
            this.btn_SetKeyAction.TabIndex = 1;
            this.btn_SetKeyAction.Text = "Set";
            this.btn_SetKeyAction.UseVisualStyleBackColor = true;
            this.btn_SetKeyAction.Click += new System.EventHandler(this.OnSetKey);
            // 
            // nud_Duration
            // 
            this.nud_Duration.DecimalPlaces = 3;
            this.nud_Duration.Location = new System.Drawing.Point(92, 68);
            this.nud_Duration.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.nud_Duration.Name = "nud_Duration";
            this.nud_Duration.Size = new System.Drawing.Size(195, 20);
            this.nud_Duration.TabIndex = 2;
            this.nud_Duration.Value = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            // 
            // btn_Apply
            // 
            this.btn_Apply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Apply.ForeColor = System.Drawing.Color.Black;
            this.btn_Apply.Location = new System.Drawing.Point(220, 111);
            this.btn_Apply.Name = "btn_Apply";
            this.btn_Apply.Size = new System.Drawing.Size(75, 23);
            this.btn_Apply.TabIndex = 3;
            this.btn_Apply.Text = "Apply";
            this.btn_Apply.UseVisualStyleBackColor = true;
            this.btn_Apply.Click += new System.EventHandler(this.OnApply);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancel.ForeColor = System.Drawing.Color.Black;
            this.btn_Cancel.Location = new System.Drawing.Point(139, 111);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.onCancel);
            // 
            // Form_Action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(299, 138);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Apply);
            this.Controls.Add(this.nud_Duration);
            this.Controls.Add(this.btn_SetKeyAction);
            this.Controls.Add(this.cb_ActionType);
            this.Controls.Add(this.label_Duration);
            this.Controls.Add(this.label_ActionType);
            this.Controls.Add(this.label_Key);
            this.Controls.Add(this.tb_Key);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_Action";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_Action";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Duration)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Key;
        private System.Windows.Forms.Label label_Key;
        private System.Windows.Forms.Label label_ActionType;
        private System.Windows.Forms.Label label_Duration;
        private System.Windows.Forms.ComboBox cb_ActionType;
        private System.Windows.Forms.Button btn_SetKeyAction;
        private System.Windows.Forms.NumericUpDown nud_Duration;
        private System.Windows.Forms.Button btn_Apply;
        private System.Windows.Forms.Button btn_Cancel;
    }
}