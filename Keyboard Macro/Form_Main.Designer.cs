namespace Keyboard_Macro
{
    partial class Form_Main
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gb_RecordPlay = new System.Windows.Forms.GroupBox();
            this.cb_PlayKey = new System.Windows.Forms.ComboBox();
            this.cb_RecordKey = new System.Windows.Forms.ComboBox();
            this.label_Play = new System.Windows.Forms.Label();
            this.label_Record = new System.Windows.Forms.Label();
            this.gb_Macro = new System.Windows.Forms.GroupBox();
            this.btn_Record = new System.Windows.Forms.Button();
            this.btn_PlayStop = new System.Windows.Forms.Button();
            this.gb_ActionSetting = new System.Windows.Forms.GroupBox();
            this.btn_LoadActions = new System.Windows.Forms.Button();
            this.btn_SaveActions = new System.Windows.Forms.Button();
            this.btn_ClearActions = new System.Windows.Forms.Button();
            this.btn_ActionDown = new System.Windows.Forms.Button();
            this.btn_ActionUp = new System.Windows.Forms.Button();
            this.btn_DeleteAction = new System.Windows.Forms.Button();
            this.btn_EditAction = new System.Windows.Forms.Button();
            this.btn_AddAction = new System.Windows.Forms.Button();
            this.dgv_Action = new System.Windows.Forms.DataGridView();
            this.dgvCol_ActionType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Key = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_WindowTitle = new System.Windows.Forms.TextBox();
            this.label_WindowTitle = new System.Windows.Forms.Label();
            this.tb_ProcessName = new System.Windows.Forms.TextBox();
            this.nud_LoopInterval = new System.Windows.Forms.NumericUpDown();
            this.lb_LoopInterval = new System.Windows.Forms.Label();
            this.nud_RepeatFinite = new System.Windows.Forms.NumericUpDown();
            this.rb_RepeatFinite = new System.Windows.Forms.RadioButton();
            this.label_Repeat = new System.Windows.Forms.Label();
            this.rb_RepeatInfinite = new System.Windows.Forms.RadioButton();
            this.btn_SetTargetWindow = new System.Windows.Forms.Button();
            this.label_ProcessName = new System.Windows.Forms.Label();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gb_RecordPlay.SuspendLayout();
            this.gb_Macro.SuspendLayout();
            this.gb_ActionSetting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Action)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_LoopInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RepeatFinite)).BeginInit();
            this.SuspendLayout();
            // 
            // gb_RecordPlay
            // 
            this.gb_RecordPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_RecordPlay.Controls.Add(this.cb_PlayKey);
            this.gb_RecordPlay.Controls.Add(this.cb_RecordKey);
            this.gb_RecordPlay.Controls.Add(this.label_Play);
            this.gb_RecordPlay.Controls.Add(this.label_Record);
            this.gb_RecordPlay.ForeColor = System.Drawing.Color.White;
            this.gb_RecordPlay.Location = new System.Drawing.Point(396, 13);
            this.gb_RecordPlay.Name = "gb_RecordPlay";
            this.gb_RecordPlay.Size = new System.Drawing.Size(196, 122);
            this.gb_RecordPlay.TabIndex = 0;
            this.gb_RecordPlay.TabStop = false;
            this.gb_RecordPlay.Text = "Shortcut";
            // 
            // cb_PlayKey
            // 
            this.cb_PlayKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_PlayKey.FormattingEnabled = true;
            this.cb_PlayKey.Items.AddRange(new object[] {
            "F1",
            "F2",
            "F3",
            "F4",
            "F5",
            "F6",
            "F7",
            "F8",
            "F9",
            "F10",
            "F11",
            "F12"});
            this.cb_PlayKey.Location = new System.Drawing.Point(40, 87);
            this.cb_PlayKey.Name = "cb_PlayKey";
            this.cb_PlayKey.Size = new System.Drawing.Size(144, 21);
            this.cb_PlayKey.TabIndex = 5;
            this.cb_PlayKey.SelectedIndexChanged += new System.EventHandler(this.cb_PlayKey_SelectedIndexChanged);
            // 
            // cb_RecordKey
            // 
            this.cb_RecordKey.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_RecordKey.FormattingEnabled = true;
            this.cb_RecordKey.Location = new System.Drawing.Point(40, 39);
            this.cb_RecordKey.Name = "cb_RecordKey";
            this.cb_RecordKey.Size = new System.Drawing.Size(144, 21);
            this.cb_RecordKey.TabIndex = 4;
            // 
            // label_Play
            // 
            this.label_Play.Location = new System.Drawing.Point(9, 69);
            this.label_Play.Name = "label_Play";
            this.label_Play.Size = new System.Drawing.Size(45, 13);
            this.label_Play.TabIndex = 3;
            this.label_Play.Text = "Play:";
            this.label_Play.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_Record
            // 
            this.label_Record.Location = new System.Drawing.Point(9, 21);
            this.label_Record.Name = "label_Record";
            this.label_Record.Size = new System.Drawing.Size(45, 13);
            this.label_Record.TabIndex = 1;
            this.label_Record.Text = "Record:";
            // 
            // gb_Macro
            // 
            this.gb_Macro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_Macro.Controls.Add(this.btn_Record);
            this.gb_Macro.Controls.Add(this.btn_PlayStop);
            this.gb_Macro.Controls.Add(this.gb_ActionSetting);
            this.gb_Macro.Controls.Add(this.dgv_Action);
            this.gb_Macro.ForeColor = System.Drawing.Color.White;
            this.gb_Macro.Location = new System.Drawing.Point(12, 141);
            this.gb_Macro.Name = "gb_Macro";
            this.gb_Macro.Size = new System.Drawing.Size(580, 406);
            this.gb_Macro.TabIndex = 1;
            this.gb_Macro.TabStop = false;
            this.gb_Macro.Text = "Key Macro";
            // 
            // btn_Record
            // 
            this.btn_Record.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Record.ForeColor = System.Drawing.Color.Black;
            this.btn_Record.Location = new System.Drawing.Point(390, 320);
            this.btn_Record.Name = "btn_Record";
            this.btn_Record.Size = new System.Drawing.Size(178, 23);
            this.btn_Record.TabIndex = 14;
            this.btn_Record.Text = "Record";
            this.btn_Record.UseVisualStyleBackColor = true;
            this.btn_Record.Visible = false;
            // 
            // btn_PlayStop
            // 
            this.btn_PlayStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_PlayStop.ForeColor = System.Drawing.Color.Black;
            this.btn_PlayStop.Location = new System.Drawing.Point(390, 349);
            this.btn_PlayStop.Name = "btn_PlayStop";
            this.btn_PlayStop.Size = new System.Drawing.Size(178, 51);
            this.btn_PlayStop.TabIndex = 15;
            this.btn_PlayStop.Text = "Play";
            this.btn_PlayStop.UseVisualStyleBackColor = true;
            this.btn_PlayStop.Click += new System.EventHandler(this.btn_PlayStop_Click);
            // 
            // gb_ActionSetting
            // 
            this.gb_ActionSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_ActionSetting.Controls.Add(this.btn_LoadActions);
            this.gb_ActionSetting.Controls.Add(this.btn_SaveActions);
            this.gb_ActionSetting.Controls.Add(this.btn_ClearActions);
            this.gb_ActionSetting.Controls.Add(this.btn_ActionDown);
            this.gb_ActionSetting.Controls.Add(this.btn_ActionUp);
            this.gb_ActionSetting.Controls.Add(this.btn_DeleteAction);
            this.gb_ActionSetting.Controls.Add(this.btn_EditAction);
            this.gb_ActionSetting.Controls.Add(this.btn_AddAction);
            this.gb_ActionSetting.ForeColor = System.Drawing.Color.White;
            this.gb_ActionSetting.Location = new System.Drawing.Point(384, 19);
            this.gb_ActionSetting.Name = "gb_ActionSetting";
            this.gb_ActionSetting.Size = new System.Drawing.Size(190, 207);
            this.gb_ActionSetting.TabIndex = 1;
            this.gb_ActionSetting.TabStop = false;
            this.gb_ActionSetting.Text = "Action Settings";
            // 
            // btn_LoadActions
            // 
            this.btn_LoadActions.ForeColor = System.Drawing.Color.Black;
            this.btn_LoadActions.Location = new System.Drawing.Point(6, 177);
            this.btn_LoadActions.Name = "btn_LoadActions";
            this.btn_LoadActions.Size = new System.Drawing.Size(178, 23);
            this.btn_LoadActions.TabIndex = 13;
            this.btn_LoadActions.Text = "Load";
            this.btn_LoadActions.UseVisualStyleBackColor = true;
            this.btn_LoadActions.Click += new System.EventHandler(this.btn_LoadActions_Click);
            // 
            // btn_SaveActions
            // 
            this.btn_SaveActions.Enabled = false;
            this.btn_SaveActions.ForeColor = System.Drawing.Color.Black;
            this.btn_SaveActions.Location = new System.Drawing.Point(6, 148);
            this.btn_SaveActions.Name = "btn_SaveActions";
            this.btn_SaveActions.Size = new System.Drawing.Size(178, 23);
            this.btn_SaveActions.TabIndex = 12;
            this.btn_SaveActions.Text = "Save";
            this.btn_SaveActions.UseVisualStyleBackColor = true;
            this.btn_SaveActions.Click += new System.EventHandler(this.btn_SaveActions_Click);
            // 
            // btn_ClearActions
            // 
            this.btn_ClearActions.Enabled = false;
            this.btn_ClearActions.ForeColor = System.Drawing.Color.Black;
            this.btn_ClearActions.Location = new System.Drawing.Point(6, 106);
            this.btn_ClearActions.Name = "btn_ClearActions";
            this.btn_ClearActions.Size = new System.Drawing.Size(178, 23);
            this.btn_ClearActions.TabIndex = 11;
            this.btn_ClearActions.Text = "Clear";
            this.btn_ClearActions.UseVisualStyleBackColor = true;
            this.btn_ClearActions.Click += new System.EventHandler(this.btn_ClearActions_Click);
            // 
            // btn_ActionDown
            // 
            this.btn_ActionDown.Enabled = false;
            this.btn_ActionDown.ForeColor = System.Drawing.Color.Black;
            this.btn_ActionDown.Location = new System.Drawing.Point(120, 60);
            this.btn_ActionDown.Name = "btn_ActionDown";
            this.btn_ActionDown.Size = new System.Drawing.Size(40, 40);
            this.btn_ActionDown.TabIndex = 10;
            this.btn_ActionDown.Text = "↓";
            this.btn_ActionDown.UseVisualStyleBackColor = true;
            this.btn_ActionDown.Click += new System.EventHandler(this.btn_ActionUpOrDown_Click);
            // 
            // btn_ActionUp
            // 
            this.btn_ActionUp.Enabled = false;
            this.btn_ActionUp.ForeColor = System.Drawing.Color.Black;
            this.btn_ActionUp.Location = new System.Drawing.Point(120, 19);
            this.btn_ActionUp.Name = "btn_ActionUp";
            this.btn_ActionUp.Size = new System.Drawing.Size(40, 40);
            this.btn_ActionUp.TabIndex = 9;
            this.btn_ActionUp.Text = "↑";
            this.btn_ActionUp.UseVisualStyleBackColor = true;
            this.btn_ActionUp.Click += new System.EventHandler(this.btn_ActionUpOrDown_Click);
            // 
            // btn_DeleteAction
            // 
            this.btn_DeleteAction.Enabled = false;
            this.btn_DeleteAction.ForeColor = System.Drawing.Color.Black;
            this.btn_DeleteAction.Location = new System.Drawing.Point(6, 77);
            this.btn_DeleteAction.Name = "btn_DeleteAction";
            this.btn_DeleteAction.Size = new System.Drawing.Size(86, 23);
            this.btn_DeleteAction.TabIndex = 8;
            this.btn_DeleteAction.Text = "Delete";
            this.btn_DeleteAction.UseVisualStyleBackColor = true;
            this.btn_DeleteAction.Click += new System.EventHandler(this.btn_DeleteAction_Click);
            // 
            // btn_EditAction
            // 
            this.btn_EditAction.Enabled = false;
            this.btn_EditAction.ForeColor = System.Drawing.Color.Black;
            this.btn_EditAction.Location = new System.Drawing.Point(6, 48);
            this.btn_EditAction.Name = "btn_EditAction";
            this.btn_EditAction.Size = new System.Drawing.Size(86, 23);
            this.btn_EditAction.TabIndex = 7;
            this.btn_EditAction.Text = "Edit";
            this.btn_EditAction.UseVisualStyleBackColor = true;
            this.btn_EditAction.Click += new System.EventHandler(this.btn_AddOrEditAction_Click);
            // 
            // btn_AddAction
            // 
            this.btn_AddAction.ForeColor = System.Drawing.Color.Black;
            this.btn_AddAction.Location = new System.Drawing.Point(6, 19);
            this.btn_AddAction.Name = "btn_AddAction";
            this.btn_AddAction.Size = new System.Drawing.Size(86, 23);
            this.btn_AddAction.TabIndex = 6;
            this.btn_AddAction.Text = "Add";
            this.btn_AddAction.UseVisualStyleBackColor = true;
            this.btn_AddAction.Click += new System.EventHandler(this.btn_AddOrEditAction_Click);
            // 
            // dgv_Action
            // 
            this.dgv_Action.AllowUserToAddRows = false;
            this.dgv_Action.AllowUserToDeleteRows = false;
            this.dgv_Action.AllowUserToResizeRows = false;
            this.dgv_Action.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Action.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Action.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Action.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_ActionType,
            this.dgvCol_Key,
            this.dgvCol_Duration});
            this.dgv_Action.Location = new System.Drawing.Point(10, 19);
            this.dgv_Action.MultiSelect = false;
            this.dgv_Action.Name = "dgv_Action";
            this.dgv_Action.ReadOnly = true;
            this.dgv_Action.RowHeadersVisible = false;
            this.dgv_Action.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Action.Size = new System.Drawing.Size(368, 381);
            this.dgv_Action.TabIndex = 0;
            this.dgv_Action.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.OnRowAdded);
            this.dgv_Action.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.OnRowRemoved);
            this.dgv_Action.SelectionChanged += new System.EventHandler(this.OnRowSelected);
            // 
            // dgvCol_ActionType
            // 
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvCol_ActionType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCol_ActionType.FillWeight = 40F;
            this.dgvCol_ActionType.HeaderText = "Action Type";
            this.dgvCol_ActionType.Name = "dgvCol_ActionType";
            this.dgvCol_ActionType.ReadOnly = true;
            this.dgvCol_ActionType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvCol_Key
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgvCol_Key.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvCol_Key.FillWeight = 30F;
            this.dgvCol_Key.HeaderText = "Key";
            this.dgvCol_Key.Name = "dgvCol_Key";
            this.dgvCol_Key.ReadOnly = true;
            this.dgvCol_Key.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dgvCol_Duration
            // 
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            this.dgvCol_Duration.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvCol_Duration.FillWeight = 30F;
            this.dgvCol_Duration.HeaderText = "Duration (sec)";
            this.dgvCol_Duration.Name = "dgvCol_Duration";
            this.dgvCol_Duration.ReadOnly = true;
            this.dgvCol_Duration.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_WindowTitle);
            this.groupBox1.Controls.Add(this.label_WindowTitle);
            this.groupBox1.Controls.Add(this.tb_ProcessName);
            this.groupBox1.Controls.Add(this.nud_LoopInterval);
            this.groupBox1.Controls.Add(this.lb_LoopInterval);
            this.groupBox1.Controls.Add(this.nud_RepeatFinite);
            this.groupBox1.Controls.Add(this.rb_RepeatFinite);
            this.groupBox1.Controls.Add(this.label_Repeat);
            this.groupBox1.Controls.Add(this.rb_RepeatInfinite);
            this.groupBox1.Controls.Add(this.btn_SetTargetWindow);
            this.groupBox1.Controls.Add(this.label_ProcessName);
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 123);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // tb_WindowTitle
            // 
            this.tb_WindowTitle.Location = new System.Drawing.Point(114, 43);
            this.tb_WindowTitle.Name = "tb_WindowTitle";
            this.tb_WindowTitle.ReadOnly = true;
            this.tb_WindowTitle.Size = new System.Drawing.Size(187, 20);
            this.tb_WindowTitle.TabIndex = 12;
            // 
            // label_WindowTitle
            // 
            this.label_WindowTitle.Location = new System.Drawing.Point(25, 47);
            this.label_WindowTitle.Name = "label_WindowTitle";
            this.label_WindowTitle.Size = new System.Drawing.Size(83, 13);
            this.label_WindowTitle.TabIndex = 11;
            this.label_WindowTitle.Text = "Window Title:";
            this.label_WindowTitle.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tb_ProcessName
            // 
            this.tb_ProcessName.Location = new System.Drawing.Point(114, 17);
            this.tb_ProcessName.Name = "tb_ProcessName";
            this.tb_ProcessName.ReadOnly = true;
            this.tb_ProcessName.Size = new System.Drawing.Size(187, 20);
            this.tb_ProcessName.TabIndex = 10;
            // 
            // nud_LoopInterval
            // 
            this.nud_LoopInterval.DecimalPlaces = 3;
            this.nud_LoopInterval.Location = new System.Drawing.Point(114, 95);
            this.nud_LoopInterval.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nud_LoopInterval.Name = "nud_LoopInterval";
            this.nud_LoopInterval.Size = new System.Drawing.Size(97, 20);
            this.nud_LoopInterval.TabIndex = 9;
            this.nud_LoopInterval.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // lb_LoopInterval
            // 
            this.lb_LoopInterval.Location = new System.Drawing.Point(6, 97);
            this.lb_LoopInterval.Name = "lb_LoopInterval";
            this.lb_LoopInterval.Size = new System.Drawing.Size(102, 13);
            this.lb_LoopInterval.TabIndex = 8;
            this.lb_LoopInterval.Text = "Loop Interval (sec):";
            this.lb_LoopInterval.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // nud_RepeatFinite
            // 
            this.nud_RepeatFinite.Location = new System.Drawing.Point(213, 69);
            this.nud_RepeatFinite.Name = "nud_RepeatFinite";
            this.nud_RepeatFinite.Size = new System.Drawing.Size(70, 20);
            this.nud_RepeatFinite.TabIndex = 3;
            // 
            // rb_RepeatFinite
            // 
            this.rb_RepeatFinite.Location = new System.Drawing.Point(197, 71);
            this.rb_RepeatFinite.Name = "rb_RepeatFinite";
            this.rb_RepeatFinite.Size = new System.Drawing.Size(123, 17);
            this.rb_RepeatFinite.TabIndex = 2;
            this.rb_RepeatFinite.Text = "Times";
            this.rb_RepeatFinite.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.rb_RepeatFinite.UseVisualStyleBackColor = true;
            // 
            // label_Repeat
            // 
            this.label_Repeat.Location = new System.Drawing.Point(24, 71);
            this.label_Repeat.Name = "label_Repeat";
            this.label_Repeat.Size = new System.Drawing.Size(83, 13);
            this.label_Repeat.TabIndex = 7;
            this.label_Repeat.Text = "Repeat:";
            this.label_Repeat.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // rb_RepeatInfinite
            // 
            this.rb_RepeatInfinite.AutoSize = true;
            this.rb_RepeatInfinite.Checked = true;
            this.rb_RepeatInfinite.Location = new System.Drawing.Point(113, 71);
            this.rb_RepeatInfinite.Name = "rb_RepeatInfinite";
            this.rb_RepeatInfinite.Size = new System.Drawing.Size(56, 17);
            this.rb_RepeatInfinite.TabIndex = 1;
            this.rb_RepeatInfinite.TabStop = true;
            this.rb_RepeatInfinite.Text = "Infinite";
            this.rb_RepeatInfinite.UseVisualStyleBackColor = true;
            // 
            // btn_SetTargetWindow
            // 
            this.btn_SetTargetWindow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_SetTargetWindow.ForeColor = System.Drawing.Color.Black;
            this.btn_SetTargetWindow.Location = new System.Drawing.Point(307, 17);
            this.btn_SetTargetWindow.Name = "btn_SetTargetWindow";
            this.btn_SetTargetWindow.Size = new System.Drawing.Size(65, 46);
            this.btn_SetTargetWindow.TabIndex = 0;
            this.btn_SetTargetWindow.Text = "Set";
            this.btn_SetTargetWindow.UseVisualStyleBackColor = true;
            this.btn_SetTargetWindow.Click += new System.EventHandler(this.btn_SetTargetWindow_Click);
            // 
            // label_ProcessName
            // 
            this.label_ProcessName.Location = new System.Drawing.Point(25, 21);
            this.label_ProcessName.Name = "label_ProcessName";
            this.label_ProcessName.Size = new System.Drawing.Size(83, 13);
            this.label_ProcessName.TabIndex = 0;
            this.label_ProcessName.Text = "Process Name:";
            this.label_ProcessName.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.saveFileDialog1.InitialDirectory = ".\\\\Projects";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files (*.xml)|*.xml|All Files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = ".\\\\Projects";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(604, 559);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gb_Macro);
            this.Controls.Add(this.gb_RecordPlay);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Keyboard Macro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form_Main_FormClosing);
            this.gb_RecordPlay.ResumeLayout(false);
            this.gb_Macro.ResumeLayout(false);
            this.gb_ActionSetting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Action)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_LoopInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_RepeatFinite)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_RecordPlay;
        private System.Windows.Forms.Label label_Play;
        private System.Windows.Forms.Label label_Record;
        private System.Windows.Forms.GroupBox gb_Macro;
        private System.Windows.Forms.DataGridView dgv_Action;
        private System.Windows.Forms.GroupBox gb_ActionSetting;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_RepeatFinite;
        private System.Windows.Forms.Label label_Repeat;
        private System.Windows.Forms.RadioButton rb_RepeatInfinite;
        private System.Windows.Forms.Button btn_SetTargetWindow;
        private System.Windows.Forms.Label label_ProcessName;
        private System.Windows.Forms.Button btn_ActionUp;
        private System.Windows.Forms.Button btn_DeleteAction;
        private System.Windows.Forms.Button btn_EditAction;
        private System.Windows.Forms.Button btn_AddAction;
        private System.Windows.Forms.Button btn_ActionDown;
        private System.Windows.Forms.NumericUpDown nud_RepeatFinite;
        private System.Windows.Forms.Button btn_PlayStop;
        private System.Windows.Forms.Button btn_ClearActions;
        private System.Windows.Forms.Button btn_Record;
        private System.Windows.Forms.Button btn_LoadActions;
        private System.Windows.Forms.Button btn_SaveActions;
        private System.Windows.Forms.ComboBox cb_PlayKey;
        private System.Windows.Forms.ComboBox cb_RecordKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_ActionType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Key;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_Duration;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lb_LoopInterval;
        private System.Windows.Forms.NumericUpDown nud_LoopInterval;
        private System.Windows.Forms.Label label_WindowTitle;
        public System.Windows.Forms.TextBox tb_WindowTitle;
        public System.Windows.Forms.TextBox tb_ProcessName;
    }
}

