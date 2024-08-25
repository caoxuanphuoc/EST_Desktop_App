namespace ESTDesktop.AppView.Component.Form
{
    partial class ucInputForm
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
            labelInput = new Label();
            textInput = new TextBox();
            SuspendLayout();
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.ImageAlign = ContentAlignment.MiddleRight;
            labelInput.Location = new Point(17, 17);
            labelInput.Name = "labelInput";
            labelInput.RightToLeft = RightToLeft.Yes;
            labelInput.Size = new Size(43, 15);
            labelInput.TabIndex = 0;
            labelInput.Text = "labelInputs";
            labelInput.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textInput
            // 
            textInput.Location = new Point(61, 14);
            textInput.Name = "textInput";
            textInput.Size = new Size(100, 23);
            textInput.TabIndex = 1;
            // 
            // ucInputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(textInput);
            Controls.Add(labelInput);
            Name = "ucInputForm";
            Size = new Size(194, 55);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label labelInput;
        private TextBox textInput;
    }
}
