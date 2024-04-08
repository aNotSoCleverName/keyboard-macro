namespace Keyboard_Macro
{
    partial class Form_TargetWindow
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
            this.btn_Select = new System.Windows.Forms.Button();
            this.dgv_Windows = new System.Windows.Forms.DataGridView();
            this.dgvCol_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.dgvCol_ProcessName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCol_WindowTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Windows)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Select
            // 
            this.btn_Select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Select.Location = new System.Drawing.Point(472, 243);
            this.btn_Select.Name = "btn_Select";
            this.btn_Select.Size = new System.Drawing.Size(75, 23);
            this.btn_Select.TabIndex = 2;
            this.btn_Select.Text = "Select";
            this.btn_Select.UseVisualStyleBackColor = true;
            this.btn_Select.Click += new System.EventHandler(this.btn_Select_Click);
            // 
            // dgv_Windows
            // 
            this.dgv_Windows.AllowUserToAddRows = false;
            this.dgv_Windows.AllowUserToDeleteRows = false;
            this.dgv_Windows.AllowUserToResizeRows = false;
            this.dgv_Windows.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgv_Windows.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_Windows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Windows.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCol_Icon,
            this.dgvCol_ProcessName,
            this.dgvCol_WindowTitle});
            this.dgv_Windows.Location = new System.Drawing.Point(12, 12);
            this.dgv_Windows.MultiSelect = false;
            this.dgv_Windows.Name = "dgv_Windows";
            this.dgv_Windows.ReadOnly = true;
            this.dgv_Windows.RowHeadersVisible = false;
            this.dgv_Windows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Windows.Size = new System.Drawing.Size(535, 225);
            this.dgv_Windows.TabIndex = 3;
            this.dgv_Windows.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Windows_CellDoubleClick);
            // 
            // dgvCol_Icon
            // 
            this.dgvCol_Icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCol_Icon.FillWeight = 20F;
            this.dgvCol_Icon.HeaderText = "Icon";
            this.dgvCol_Icon.Name = "dgvCol_Icon";
            this.dgvCol_Icon.ReadOnly = true;
            this.dgvCol_Icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCol_Icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // dgvCol_ProcessName
            // 
            this.dgvCol_ProcessName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCol_ProcessName.FillWeight = 40F;
            this.dgvCol_ProcessName.HeaderText = "Process Name";
            this.dgvCol_ProcessName.Name = "dgvCol_ProcessName";
            this.dgvCol_ProcessName.ReadOnly = true;
            // 
            // dgvCol_WindowTitle
            // 
            this.dgvCol_WindowTitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dgvCol_WindowTitle.FillWeight = 40F;
            this.dgvCol_WindowTitle.HeaderText = "Window Title";
            this.dgvCol_WindowTitle.Name = "dgvCol_WindowTitle";
            this.dgvCol_WindowTitle.ReadOnly = true;
            // 
            // Form_TargetWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(559, 278);
            this.Controls.Add(this.dgv_Windows);
            this.Controls.Add(this.btn_Select);
            this.Name = "Form_TargetWindow";
            this.Text = "Select Target Window";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Windows)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Select;
        private System.Windows.Forms.DataGridView dgv_Windows;
        private System.Windows.Forms.DataGridViewImageColumn dgvCol_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_ProcessName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCol_WindowTitle;
    }
}