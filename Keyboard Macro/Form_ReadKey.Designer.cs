namespace Keyboard_Macro
{
    partial class Form_ReadKey
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
            this.components = new System.ComponentModel.Container();
            this.label_PressAnyKey = new System.Windows.Forms.Label();
            this.timer_KeyNotSupported = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label_PressAnyKey
            // 
            this.label_PressAnyKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_PressAnyKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PressAnyKey.ForeColor = System.Drawing.Color.White;
            this.label_PressAnyKey.Location = new System.Drawing.Point(0, 0);
            this.label_PressAnyKey.Name = "label_PressAnyKey";
            this.label_PressAnyKey.Size = new System.Drawing.Size(321, 121);
            this.label_PressAnyKey.TabIndex = 0;
            this.label_PressAnyKey.Text = "Press Any Key";
            this.label_PressAnyKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer_KeyNotSupported
            // 
            this.timer_KeyNotSupported.Interval = 500;
            this.timer_KeyNotSupported.Tick += new System.EventHandler(this.timer_KeyNotSupported_Tick);
            // 
            // Form_ReadKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(321, 121);
            this.Controls.Add(this.label_PressAnyKey);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_ReadKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Reading Key Press...";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form_ReadKey_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_PressAnyKey;
        private System.Windows.Forms.Timer timer_KeyNotSupported;
    }
}