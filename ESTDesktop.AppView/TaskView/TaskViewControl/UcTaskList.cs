using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESTDesktop.AppView.TaskView.TaskViewControl
{
    public partial class UcTaskList : UserControl
    {
        public UcTaskList()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private string _taskName;

        private float _est;
        private float _minTime;
        private float _maxTime;

        private int _no;

        // Khai báo sự kiện để thông báo việc xóa
        public event EventHandler RemoveControlClicked;
        private void btDel_Click(object sender, EventArgs e)
        {
            RemoveControlClicked?.Invoke(this, EventArgs.Empty);
        }

        public int No
        {
            get { return _no; }
            set { _no = value; lbNo.Text = value.ToString(); }
        }

       

        public string TaskName
        {
            get { return _taskName; }
            set { _taskName = value; tbTaskName.Text = value.ToString(); }
        }

        public float Est
        {
            get { return _est; }
            set { _est = value; tbEst.Text = value.ToString(); }
        }

        public float MinTime
        {
            get { return _minTime; }
            set { _minTime = value; tbMinTime.Text = value.ToString(); }
        }

        public float MaxTime
        {
            get { return _maxTime; }
            set { _maxTime = value; tbMaxTime.Text = value.ToString(); }
        }
    }
}
