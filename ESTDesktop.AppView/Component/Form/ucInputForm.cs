using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTDesktop.AppView.Component.Form
{
    public partial class ucInputForm : UserControl
    {
        public ucInputForm()
        {
            InitializeComponent();
        }

        public ucInputForm(string text)
        {
            InitializeComponent();
            this.labelInput.Text = text;
        }
    }
}
