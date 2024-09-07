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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcTaskList));
            lbNo = new Label();
            tbTaskName = new Label();
            tbEst = new TextBox();
            btDel = new Button();
            tbMinTime = new TextBox();
            tbMaxTime = new TextBox();
            btEdit = new Button();
            tbTimer = new TextBox();
            btPlay = new Button();
            btPause = new Button();
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
            tbTaskName.Size = new Size(225, 23);
            tbTaskName.TabIndex = 1;
            // 
            // tbEst
            // 
            tbEst.Font = new Font("Microsoft Sans Serif", 9F);
            tbEst.Location = new Point(308, 6);
            tbEst.Name = "tbEst";
            tbEst.ReadOnly = true;
            tbEst.Size = new Size(30, 21);
            tbEst.TabIndex = 2;
            tbEst.TextAlign = HorizontalAlignment.Center;
            // 
            // btDel
            // 
            btDel.AutoSize = true;
            btDel.BackColor = Color.SaddleBrown;
            btDel.BackgroundImage = Properties.Resources.delete;
            btDel.BackgroundImageLayout = ImageLayout.Stretch;
            btDel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btDel.ForeColor = Color.AliceBlue;
            btDel.Location = new Point(606, 5);
            btDel.Name = "btDel";
            btDel.Size = new Size(28, 27);
            btDel.TabIndex = 3;
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // tbMinTime
            // 
            tbMinTime.Font = new Font("Microsoft Sans Serif", 9F);
            tbMinTime.Location = new Point(267, 6);
            tbMinTime.Name = "tbMinTime";
            tbMinTime.ReadOnly = true;
            tbMinTime.Size = new Size(30, 21);
            tbMinTime.TabIndex = 4;
            tbMinTime.TextAlign = HorizontalAlignment.Center;
            // 
            // tbMaxTime
            // 
            tbMaxTime.Font = new Font("Microsoft Sans Serif", 9F);
            tbMaxTime.Location = new Point(348, 6);
            tbMaxTime.Name = "tbMaxTime";
            tbMaxTime.ReadOnly = true;
            tbMaxTime.Size = new Size(30, 21);
            tbMaxTime.TabIndex = 5;
            tbMaxTime.TextAlign = HorizontalAlignment.Center;
            // 
            // btEdit
            // 
            btEdit.BackColor = Color.Peru;
            btEdit.BackgroundImage = Properties.Resources.editing;
            btEdit.BackgroundImageLayout = ImageLayout.Stretch;
            btEdit.Font = new Font("Segoe UI", 13F, FontStyle.Italic);
            btEdit.Image = (Image)resources.GetObject("btEdit.Image");
            btEdit.Location = new Point(572, 4);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(28, 27);
            btEdit.TabIndex = 6;
            btEdit.UseVisualStyleBackColor = false;
            btEdit.Click += button1_Click;
            // 
            // tbTimer
            // 
            tbTimer.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tbTimer.Location = new Point(391, 6);
            tbTimer.Name = "tbTimer";
            tbTimer.ReadOnly = true;
            tbTimer.Size = new Size(100, 24);
            tbTimer.TabIndex = 7;
            tbTimer.Text = "00:00:00";
            tbTimer.TextAlign = HorizontalAlignment.Center;
            // 
            // btPlay
            // 
            btPlay.BackColor = Color.DarkGreen;
            btPlay.BackgroundImage = Properties.Resources.play_button;
            btPlay.BackgroundImageLayout = ImageLayout.Stretch;
            btPlay.Location = new Point(498, 5);
            btPlay.Name = "btPlay";
            btPlay.Size = new Size(27, 27);
            btPlay.TabIndex = 8;
            btPlay.TextImageRelation = TextImageRelation.ImageBeforeText;
            btPlay.UseVisualStyleBackColor = false;
            btPlay.Click += btPlay_Click;
            // 
            // btPause
            // 
            btPause.BackColor = Color.ForestGreen;
            btPause.BackgroundImage = Properties.Resources.pause_v2;
            btPause.BackgroundImageLayout = ImageLayout.Stretch;
            btPause.Location = new Point(530, 5);
            btPause.Name = "btPause";
            btPause.Size = new Size(27, 27);
            btPause.TabIndex = 9;
            btPause.TextImageRelation = TextImageRelation.ImageBeforeText;
            btPause.UseVisualStyleBackColor = false;
            btPause.Click += btPause_Click;
            // 
            // UcTaskList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btPause);
            Controls.Add(btPlay);
            Controls.Add(tbTimer);
            Controls.Add(btEdit);
            Controls.Add(tbMaxTime);
            Controls.Add(tbMinTime);
            Controls.Add(btDel);
            Controls.Add(tbEst);
            Controls.Add(tbTaskName);
            Controls.Add(lbNo);
            Name = "UcTaskList";
            Size = new Size(636, 35);
            Load += UcTaskList_Load;
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
        private Button btEdit;
        private TextBox tbTimer;
        private Button btPlay;
        private Button btPause;
    }
}
