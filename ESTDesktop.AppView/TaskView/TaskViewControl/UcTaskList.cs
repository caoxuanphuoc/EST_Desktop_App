using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
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

        public System.Timers.Timer _timeCount;
        private int h, m, s, ms;


        private int _no;

        // Khai báo sự kiện để thông báo việc xóa
        public event EventHandler RemoveControlClicked;

        public event EventHandler EditControlClicked;

        public event EventHandler SaveTimeControlButon;

        public event EventHandler PlayTimeControlButon;
        private void btDel_Click(object sender, EventArgs e)
        {
            RemoveControlClicked?.Invoke(this, EventArgs.Empty);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditControlClicked?.Invoke(this, EventArgs.Empty);
        }

        private void btPlay_Click(object sender, EventArgs e)
        {

            PlayTimeControlButon?.Invoke(this, EventArgs.Empty);
            //_timeCount.Start();
        }

        private void OnTimeEvent(object? sender, ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {

                if (ms == 1000)
                {
                    ms = 0;
                    if (s == 59)
                    {
                        s = 0;
                        if (m == 59)
                        {
                            m = 0;
                            h++;
                        }
                        else
                        {
                            m++;
                        }
                    }
                    else
                    {
                        // each 30s storage data in paren component
                        if(s == 30)
                        {
                            SaveTimeControlButon?.Invoke(this, EventArgs.Empty);
                        }
                        s++;
                    }
                }
                else
                {
                    ms += 100;
                }

                tbTimer.Text = $"{h.ToString().PadLeft(2, '0')}" +
                               $":{m.ToString().PadLeft(2, '0')}:" +
                               $"{s.ToString().PadLeft(2, '0')}:" +
                               $"{(ms / 100).ToString().PadLeft(2, '0')}";

            }));

        }

        private void btPause_Click(object sender, EventArgs e)
        {
            _timeCount.Stop();
            SaveTimeControlButon?.Invoke(this, EventArgs.Empty);

        }

        private void UcTaskList_Load(object sender, EventArgs e)
        {
            _timeCount = new System.Timers.Timer();
            _timeCount.Interval = 100;
            _timeCount.Elapsed += OnTimeEvent;
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

        public TimeSpan TimeWork
        {
            get { return new TimeSpan(0,h, m, s, ms); }
            set
            {
                h = value.Hours;
                m = value.Minutes;
                s = value.Seconds;
                ms = value.Microseconds;

                tbTimer.Text = $"{h.ToString().PadLeft(2, '0')}" +
                              $":{m.ToString().PadLeft(2, '0')}:" +
                              $"{s.ToString().PadLeft(2, '0')}:" +
                              $"{(ms / 100).ToString().PadLeft(2, '0')}";
            }
        }
    }
}
