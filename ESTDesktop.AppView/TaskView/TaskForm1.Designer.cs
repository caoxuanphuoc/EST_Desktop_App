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
            tbMaxTime = new TextBox();
            label5 = new Label();
            tbMinTime = new TextBox();
            label4 = new Label();
            tbEst = new TextBox();
            btAddTask = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tbTaskName = new TextBox();
            rtbDescripttion = new RichTextBox();
            panel3 = new Panel();
            lbOp = new Label();
            lbM = new Label();
            lbEst = new Label();
            lbMin = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel2.Location = new Point(358, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(391, 188);
            panel2.TabIndex = 1;
            // 
            // tbMaxTime
            // 
            tbMaxTime.Location = new Point(332, 110);
            tbMaxTime.Name = "tbMaxTime";
            tbMaxTime.Size = new Size(52, 23);
            tbMaxTime.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(301, 113);
            label5.Name = "label5";
            label5.Size = new Size(30, 15);
            label5.TabIndex = 9;
            label5.Text = "Max";
            // 
            // tbMinTime
            // 
            tbMinTime.Location = new Point(100, 110);
            tbMinTime.Name = "tbMinTime";
            tbMinTime.Size = new Size(52, 23);
            tbMinTime.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(69, 115);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 7;
            label4.Text = "Min";
            // 
            // tbEst
            // 
            tbEst.Location = new Point(210, 110);
            tbEst.Name = "tbEst";
            tbEst.Size = new Size(52, 23);
            tbEst.TabIndex = 3;
            // 
            // btAddTask
            // 
            btAddTask.Location = new Point(116, 148);
            btAddTask.Name = "btAddTask";
            btAddTask.Size = new Size(247, 23);
            btAddTask.TabIndex = 5;
            btAddTask.Text = "Thêm ngay";
            btAddTask.UseVisualStyleBackColor = true;
            btAddTask.Click += btAddTask_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(179, 115);
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
            rtbDescripttion.Size = new Size(317, 47);
            rtbDescripttion.TabIndex = 1;
            rtbDescripttion.Text = "";
            rtbDescripttion.TextChanged += rtbDescripttion_TextChanged;
            // 
            // panel3
            // 
            panel3.BackColor = Color.MistyRose;
            panel3.Controls.Add(lbOp);
            panel3.Controls.Add(lbM);
            panel3.Controls.Add(lbEst);
            panel3.Controls.Add(lbMin);
            panel3.Location = new Point(358, 233);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 149);
            panel3.TabIndex = 2;
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
            lbEst.Location = new Point(210, 46);
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
            flowLayoutPanel1.Location = new Point(14, 23);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(338, 362);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // TaskForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(777, 397);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Name = "TaskForm1";
            Text = "TaskForm1";
            Load += TaskForm1_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
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
        private TextBox tbEst;
        private TextBox tbMaxTime;
        private Label label5;
        private TextBox tbMinTime;
        private Label label4;
        private Label lbOp;
        private Label lbM;
        private Label lbEst;
        private Label lbMin;
    }
}