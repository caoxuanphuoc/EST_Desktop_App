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
            var x = ucInputForm1.labelInput.Text;
            ucInputForm1.labelInput.Text = "Hello World";
        }

        private void LayoutForm_Load(object sender, EventArgs e)
        {

        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }
    }
}
