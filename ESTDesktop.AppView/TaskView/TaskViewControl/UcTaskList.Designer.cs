namespace ESTDesktop.AppView.TaskView.TaskViewControl
{
    partial class UcTaskList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbNo = new Label();
            tbTaskName = new TextBox();
            tbEst = new TextBox();
            btDel = new Button();
            tbMinTime = new TextBox();
            tbMaxTime = new TextBox();
            SuspendLayout();
            // 
            // lbNo
            // 
            lbNo.AutoSize = true;
            lbNo.Location = new Point(7, 8);
            lbNo.Name = "lbNo";
            lbNo.Size = new Size(13, 15);
            lbNo.TabIndex = 0;
            lbNo.Text = "1";
            lbNo.Click += label1_Click;
            // 
            // tbTaskName
            // 
            tbTaskName.Location = new Point(28, 5);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(141, 23);
            tbTaskName.TabIndex = 1;
            // 
            // tbEst
            // 
            tbEst.Location = new Point(217, 5);
            tbEst.Name = "tbEst";
            tbEst.Size = new Size(37, 23);
            tbEst.TabIndex = 2;
            // 
            // btDel
            // 
            btDel.AutoSize = true;
            btDel.BackColor = Color.Red;
            btDel.BackgroundImageLayout = ImageLayout.None;
            btDel.FlatStyle = FlatStyle.Flat;
            btDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDel.ForeColor = Color.Azure;
            btDel.Location = new Point(298, 4);
            btDel.Name = "btDel";
            btDel.Size = new Size(28, 27);
            btDel.TabIndex = 3;
            btDel.Text = "x";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // tbMinTime
            // 
            tbMinTime.Location = new Point(175, 5);
            tbMinTime.Name = "tbMinTime";
            tbMinTime.Size = new Size(36, 23);
            tbMinTime.TabIndex = 4;
            // 
            // tbMaxTime
            // 
            tbMaxTime.Location = new Point(260, 5);
            tbMaxTime.Name = "tbMaxTime";
            tbMaxTime.Size = new Size(31, 23);
            tbMaxTime.TabIndex = 5;
            // 
            // UcTaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tbMaxTime);
            Controls.Add(tbMinTime);
            Controls.Add(btDel);
            Controls.Add(tbEst);
            Controls.Add(tbTaskName);
            Controls.Add(lbNo);
            Name = "UcTaskList";
            Size = new Size(331, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNo;
        private TextBox tbTaskName;
        private TextBox tbEst;
        private Button btDel;
        private TextBox tbMinTime;
        private TextBox tbMaxTime;
    }
}
