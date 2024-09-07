using ESTDesktop.AppView.TaskView;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTDesktop.AppView.Layout
{
    public partial class LayoutForm : Form
    {
        public LayoutForm()
        {
            InitializeComponent();
        }

        private void LayoutForm_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnContent.Controls.Clear();

            // Create an instance of TaskForm1
            TaskForm1 taskForm = new TaskForm1
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };

            // Add the TaskForm1 instance to the panel
            pnContent.Controls.Add(taskForm);

            // Show the TaskForm1 instance
            taskForm.Show();
        }

    }
}
