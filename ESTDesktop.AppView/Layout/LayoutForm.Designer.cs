namespace ESTDesktop.AppView.Layout
{
    partial class LayoutForm
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
            button1 = new Button();
            pnContent = new Panel();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(31, 13);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "show Taskform";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pnContent
            // 
            pnContent.Location = new Point(30, 62);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(1019, 504);
            pnContent.TabIndex = 1;
            // 
            // LayoutForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1082, 600);
            Controls.Add(pnContent);
            Controls.Add(button1);
            Name = "LayoutForm";
            Text = "LayoutForm";
            Load += LayoutForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Panel pnContent;
    }
}