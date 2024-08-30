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
            tbTaskName = new Label();
            tbEst = new TextBox();
            btDel = new Button();
            tbMinTime = new TextBox();
            tbMaxTime = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // lbNo
            // 
            lbNo.AutoSize = true;
            lbNo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbNo.Location = new Point(7, 8);
            lbNo.Name = "lbNo";
            lbNo.Size = new Size(14, 15);
            lbNo.TabIndex = 0;
            lbNo.Text = "1";
            lbNo.Click += label1_Click;
            // 
            // tbTaskName
            // 
            tbTaskName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbTaskName.Location = new Point(36, 5);
            tbTaskName.Name = "tbTaskName";
            tbTaskName.Size = new Size(159, 23);
            tbTaskName.TabIndex = 1;
            // 
            // tbEst
            // 
            tbEst.Location = new Point(246, 6);
            tbEst.Name = "tbEst";
            tbEst.Size = new Size(30, 23);
            tbEst.TabIndex = 2;
            // 
            // btDel
            // 
            btDel.AutoSize = true;
            btDel.BackColor = Color.Red;
            btDel.BackgroundImageLayout = ImageLayout.None;
            btDel.FlatStyle = FlatStyle.Flat;
            btDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDel.ForeColor = Color.AliceBlue;
            btDel.Location = new Point(357, 5);
            btDel.Name = "btDel";
            btDel.Size = new Size(28, 27);
            btDel.TabIndex = 3;
            btDel.Text = "x";
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // tbMinTime
            // 
            tbMinTime.Location = new Point(205, 6);
            tbMinTime.Name = "tbMinTime";
            tbMinTime.Size = new Size(30, 23);
            tbMinTime.TabIndex = 4;
            // 
            // tbMaxTime
            // 
            tbMaxTime.Location = new Point(286, 6);
            tbMaxTime.Name = "tbMaxTime";
            tbMaxTime.Size = new Size(30, 23);
            tbMaxTime.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 13F, FontStyle.Italic);
            button1.ForeColor = Color.AliceBlue;
            button1.Location = new Point(323, 4);
            button1.Name = "button1";
            button1.Size = new Size(28, 27);
            button1.TabIndex = 6;
            button1.Text = "i";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // UcTaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(tbMaxTime);
            Controls.Add(tbMinTime);
            Controls.Add(btDel);
            Controls.Add(tbEst);
            Controls.Add(tbTaskName);
            Controls.Add(lbNo);
            Name = "UcTaskList";
            Size = new Size(388, 35);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbNo;
        private Label tbTaskName;
        private TextBox tbEst;
        private Button btDel;
        private TextBox tbMinTime;
        private TextBox tbMaxTime;
        private Button button1;
    }
}
