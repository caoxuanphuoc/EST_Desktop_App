using ESTDesktop.AppView.TaskView.TaskViewControl;
using System.Timers;
using System.Windows.Forms;

namespace ESTDesktop.AppView.TaskView.MinimizeForm
{
    public partial class FrmMinimizeClook : Form
    {
        private TaskForm1 _taskForm;
        private UcTaskList _ucTaskList;

        private System.Timers.Timer _timeCount;
        private int h, m, s, ms;
        public FrmMinimizeClook(TaskForm1 frmTask)
        {
            InitializeComponent();
            _taskForm = frmTask;
            this.StartPosition = FormStartPosition.Manual;
            this.TopMost = true; // Luôn ở trên cùng
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;

            var mainTask = _taskForm.lsTask.FirstOrDefault(x => x.IsRunning);
            _ucTaskList = mainTask == null? null :_taskForm.ListTaskUC_v2[mainTask.No];
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.TopMost = true;
        }

        private void FrmMinimizeClook_FormClosed(object sender, FormClosedEventArgs e)
        {
            // base.OnFormClosing(e);
            _taskForm.ShowMainForm();
        }

        private void FrmMinimizeClook_Load(object sender, EventArgs e)
        {
            if(_taskForm.lsTask.Count > 0)
            {
                if(_ucTaskList != null)
                {
                    lbTaskName.Text = _ucTaskList.TaskName;


                    TimeSpan time = _ucTaskList.TimeWork;
                    h= time.Hours;
                    m= time.Minutes;
                    s = time.Seconds;
                    ms = 0;

                    #region Timmer
                    _timeCount = new System.Timers.Timer();
                    _timeCount.Interval = 100;
                    _timeCount.Elapsed += OnTimeEvent;
                    _timeCount.Start();
                    #endregion
                    // ad time here
                }

            }
        }
        // Xử lý sự kiện đóng của SimpleForm
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
                        /* if (s == 30)
                         {
                             SaveTimeControlButon?.Invoke(this, EventArgs.Empty);
                         }*/
                        s++;
                        if ((s ) % 5 == 0)
                        {
                            UpdatePercent((m + 60 * h) * 60 + s);
                        }

                    }
                }
                else
                {
                    ms += 100;
                }

                tbClook.Text = $"{h.ToString().PadLeft(2, '0')}" +
                               $":{m.ToString().PadLeft(2, '0')}:" +
                               $"{s.ToString().PadLeft(2, '0')}:" +
                               $"{(ms / 100).ToString().PadLeft(2, '0')}";

            }));

        }

        private void UpdatePercent(int s)
        {
            if (_ucTaskList != null)
            {
                float subMin = _ucTaskList.MinTime,
                             subOp = _ucTaskList.Est,
                             subMax = _ucTaskList.MaxTime;
                float sum = subMin + 4 * subOp + subMax;
                float est = sum / 6f;
                decimal res = Math.Round((decimal)est, 2) * 60;

                decimal percent = Math.Round((decimal)(s / res * 100), 2);
                
                lbPercent.Text = percent.ToString() + "%";
                // set color for text if lesstha 30% => red else if less than 70% is orange else is green
                if (percent < 30)
                {
                    lbPercent.ForeColor = Color.Red;
                }
                else if (percent < 70)
                {
                    lbPercent.ForeColor = Color.Orange;
                }
                else
                {
                    lbPercent.ForeColor = Color.Green;
                }
            }
        }
    }
}
