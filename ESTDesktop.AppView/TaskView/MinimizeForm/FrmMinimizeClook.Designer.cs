namespace ESTDesktop.AppView.TaskView.MinimizeForm
{
    partial class FrmMinimizeClook
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
            lbTaskName = new Label();
            tbClook = new Label();
            lbPercent = new Label();
            SuspendLayout();
            // 
            // lbTaskName
            // 
            lbTaskName.AutoSize = true;
            lbTaskName.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTaskName.Location = new Point(27, 9);
            lbTaskName.Name = "lbTaskName";
            lbTaskName.Size = new Size(112, 24);
            lbTaskName.TabIndex = 0;
            lbTaskName.Text = "Task name";
            // 
            // tbClook
            // 
            tbClook.BackColor = Color.SeaGreen;
            tbClook.Font = new Font("Microsoft Sans Serif", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbClook.ForeColor = SystemColors.Control;
            tbClook.Location = new Point(20, 39);
            tbClook.Name = "tbClook";
            tbClook.Size = new Size(283, 55);
            tbClook.TabIndex = 1;
            tbClook.Text = "00:00:00:00";
            // 
            // lbPercent
            // 
            lbPercent.AutoSize = true;
            lbPercent.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbPercent.ForeColor = Color.IndianRed;
            lbPercent.Location = new Point(257, 9);
            lbPercent.Name = "lbPercent";
            lbPercent.Size = new Size(37, 24);
            lbPercent.TabIndex = 2;
            lbPercent.Text = "0%";
            // 
            // FrmMinimizeClook
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(322, 106);
            Controls.Add(lbPercent);
            Controls.Add(tbClook);
            Controls.Add(lbTaskName);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMinimizeClook";
            Text = "EST Counting";
            FormClosed += FrmMinimizeClook_FormClosed;
            Load += FrmMinimizeClook_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbTaskName;
        private Label tbClook;
        private Label lbPercent;
    }
}