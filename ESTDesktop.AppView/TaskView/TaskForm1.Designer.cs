namespace ESTDesktop.AppView.TaskView
{
    partial class TaskForm1
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
            panel2 = new Panel();
            tbMaxTime = new NumericUpDown();
            label5 = new Label();
            tbMinTime = new NumericUpDown();
            label4 = new Label();
            tbEst = new NumericUpDown();
            btAddTask = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbTaskName = new TextBox();
            rtbDescripttion = new RichTextBox();
            panel3 = new Panel();
            lbDetailHour = new Label();
            lbTotalHour = new Label();
            lbOp = new Label();
            lbM = new Label();
            lbEst = new Label();
            lbMin = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            label6 = new Label();
            panel1 = new Panel();
            label13 = new Label();
            label9 = new Label();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbMaxTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbMinTime).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbEst).BeginInit();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkSeaGreen;
            panel2.Controls.Add(tbMaxTime);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(tbMinTime);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(tbEst);
            panel2.Controls.Add(btAddTask);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(tbTaskName);
            panel2.Controls.Add(rtbDescripttion);
            panel2.Location = new Point(687, 49);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 259);
            panel2.TabIndex = 1;
            // 
            // tbMaxTime
            // 
            tbMaxTime.Location = new Point(332, 178);
            tbMaxTime.Maximum = new decimal(new int[] { 40000, 0, 0, 0 });
            tbMaxTime.Name = "tbMaxTime";
            tbMaxTime.Size = new Size(52, 23);
            tbMaxTime.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 181);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 9;
            label5.Text = "Max";
            // 
            // tbMinTime
            // 
            tbMinTime.Location = new Point(100, 178);
            tbMinTime.Maximum = new decimal(new int[] { 40000, 0, 0, 0 });
            tbMinTime.Name = "tbMinTime";
            tbMinTime.Size = new Size(52, 23);
            tbMinTime.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 183);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "Min";
            // 
            // tbEst
            // 
            tbEst.Location = new Point(210, 178);
            tbEst.Maximum = new decimal(new int[] { 40000, 0, 0, 0 });
            tbEst.Name = "tbEst";
            tbEst.Size = new Size(52, 23);
            tbEst.TabIndex = 3;
            // 
            // btAddTask
            // 
            btAddTask.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btAddTask.Location = new Point(114, 216);
            btAddTask.Name = "btAddTask";
            btAddTask.Size = new Size(247, 23);
            btAddTask.TabIndex = 5;
            btAddTask.TabStop = false;
            btAddTask.Text = "Add Task";
            btAddTask.UseVisualStyleBackColor = true;
            btAddTask.Click += btAddTask_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 183);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 4;
            label3.Text = "EST";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 22);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 3;
            label2.Text = "Tên Task";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 53);
            label1.Name = "label1";
            label1.Size = new Size(41, 15);
            label1.TabIndex = 2;
            label1.Text = "Mô tả:";
            // 
            // tbTaskName
            // 
            tbTaskName.Location = new Point(69, 20);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(315, 23);
            tbTaskName.TabIndex = 0;
            // 
            // rtbDescripttion
            // 
            rtbDescripttion.Location = new Point(67, 51);
            rtbDescripttion.Name = "rtbDescripttion";
            rtbDescripttion.Size = new Size(317, 107);
            rtbDescripttion.TabIndex = 1;
            rtbDescripttion.Text = "";
            rtbDescripttion.TextChanged += rtbDescripttion_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(lbDetailHour);
            panel3.Controls.Add(lbTotalHour);
            panel3.Controls.Add(lbOp);
            panel3.Controls.Add(lbM);
            panel3.Controls.Add(lbEst);
            panel3.Controls.Add(lbMin);
            panel3.Location = new Point(687, 314);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 128);
            panel3.TabIndex = 2;
            // 
            // lbDetailHour
            // 
            lbDetailHour.AutoSize = true;
            lbDetailHour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbDetailHour.ForeColor = Color.ForestGreen;
            lbDetailHour.Location = new Point(184, 83);
            lbDetailHour.Name = "lbDetailHour";
            lbDetailHour.Size = new Size(82, 15);
            lbDetailHour.TabIndex = 5;
            lbDetailHour.Text = "Detail hour: 0";
            // 
            // lbTotalHour
            // 
            lbTotalHour.AutoSize = true;
            lbTotalHour.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbTotalHour.ForeColor = Color.ForestGreen;
            lbTotalHour.Location = new Point(184, 51);
            lbTotalHour.Name = "lbTotalHour";
            lbTotalHour.Size = new Size(76, 15);
            lbTotalHour.TabIndex = 4;
            lbTotalHour.Text = "Total hour: 0";
            // 
            // lbOp
            // 
            lbOp.AutoSize = true;
            lbOp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbOp.ForeColor = Color.ForestGreen;
            lbOp.Location = new Point(12, 51);
            lbOp.Name = "lbOp";
            lbOp.Size = new Size(138, 15);
            lbOp.TabIndex = 3;
            lbOp.Text = "Total Optimistic Time: 0";
            // 
            // lbM
            // 
            lbM.AutoSize = true;
            lbM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbM.ForeColor = Color.ForestGreen;
            lbM.Location = new Point(14, 83);
            lbM.Name = "lbM";
            lbM.Size = new Size(109, 15);
            lbM.TabIndex = 2;
            lbM.Text = "Total Most Time: 0";
            // 
            // lbEst
            // 
            lbEst.AutoSize = true;
            lbEst.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            lbEst.ForeColor = Color.OrangeRed;
            lbEst.Location = new Point(184, 9);
            lbEst.Name = "lbEst";
            lbEst.Size = new Size(73, 36);
            lbEst.TabIndex = 1;
            lbEst.Text = "EST: ";
            // 
            // lbMin
            // 
            lbMin.AutoSize = true;
            lbMin.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lbMin.ForeColor = Color.ForestGreen;
            lbMin.Location = new Point(12, 18);
            lbMin.Name = "lbMin";
            lbMin.Size = new Size(102, 15);
            lbMin.TabIndex = 0;
            lbMin.Text = "Total Min Time: 0";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.DarkSeaGreen;
            flowLayoutPanel1.Location = new Point(0, 36);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(667, 357);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19F, FontStyle.Bold);
            label6.Location = new Point(390, 9);
            label6.Name = "label6";
            label6.Size = new Size(249, 36);
            label6.TabIndex = 4;
            label6.Text = "EST PERT DESKTOP";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(label13);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label12);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(flowLayoutPanel1);
            panel1.Location = new Point(14, 49);
            panel1.Name = "panel1";
            panel1.Size = new Size(667, 393);
            panel1.TabIndex = 5;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label13.Location = new Point(411, 8);
            label13.Name = "label13";
            label13.Size = new Size(83, 23);
            label13.TabIndex = 10;
            label13.Text = "Timming";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label9.Location = new Point(577, 8);
            label9.Name = "label9";
            label9.Size = new Size(62, 23);
            label9.TabIndex = 6;
            label9.Text = "Action";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label12.Location = new Point(350, 8);
            label12.Name = "label12";
            label12.Size = new Size(26, 23);
            label12.TabIndex = 9;
            label12.Text = "M";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label11.Location = new Point(313, 8);
            label11.Name = "label11";
            label11.Size = new Size(23, 23);
            label11.TabIndex = 8;
            label11.Text = "O";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label10.Location = new Point(277, 8);
            label10.Name = "label10";
            label10.Size = new Size(20, 23);
            label10.TabIndex = 7;
            label10.Text = "P";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label8.Location = new Point(81, 8);
            label8.Name = "label8";
            label8.Size = new Size(97, 23);
            label8.TabIndex = 5;
            label8.Text = "Task Name";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12.75F, FontStyle.Bold);
            label7.Location = new Point(4, 8);
            label7.Name = "label7";
            label7.Size = new Size(20, 23);
            label7.TabIndex = 4;
            label7.Text = "#";
            // 
            // TaskForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 454);
            Controls.Add(panel1);
            Controls.Add(label6);
            Controls.Add(panel3);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "TaskForm1";
            Text = "EST Desktop";
            Load += TaskForm1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tbMaxTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbMinTime).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbEst).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel panel2;
        private Panel panel3;
        private Label label2;
        private Label label1;
        private TextBox tbTaskName;
        private RichTextBox rtbDescripttion;
        private Label label3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btAddTask;
        private NumericUpDown tbEst;
        private NumericUpDown tbMaxTime;
        private Label label5;
        private NumericUpDown tbMinTime;
        private Label label4;
        private Label lbOp;
        private Label lbM;
        private Label lbEst;
        private Label lbMin;
        private Label label6;
        private Panel panel1;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;

        private Label lbDetailHour;
        private Label lbTotalHour;

        private Label label13;

    }
}