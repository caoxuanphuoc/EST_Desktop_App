using ESTDesktop.AppView.TaskView.MinimizeForm;
using ESTDesktop.AppView.TaskView.TaskViewControl;
using ESTDesktop.AppView.TaskView.TaskViewControl.Dtos;
using System.Data;

namespace ESTDesktop.AppView.TaskView
{
    public partial class TaskForm1 : Form
    {
        
        public TaskForm1()
        {
            InitializeComponent();
            lsTask = new List<TaskDetailDto>();
        }

        public List<UcTaskList> ListTaskUC_v2 = new List<UcTaskList>();
        public List<TaskDetailDto> lsTask { get; set; }
        public float TotalMin { get; set; }
        public float TotalOP { get; set; }
        public float TotalMax { get; set; }
        private int IdEdit { get; set; } = -1;


        #region Minimize Form
        //private FrmMinimizeClook frmMinimizeClook;

        // Sự kiện khi form chính bị thu nhỏ
        private void TaskForm1_Resize_1(object sender, EventArgs e)
        {
            FrmMinimizeClook frmMinimizeClook = new FrmMinimizeClook(this);

            if (this.WindowState == FormWindowState.Minimized)
            {
                // Hiển thị form phụ khi form chính thu nhỏ
                frmMinimizeClook.Show();
                this.Hide();
                //frmMinimizeClook.TopMost = true; // Luôn ở trên các cửa sổ khác
            }
        }
        // Hàm để hiển thị lại MainForm từ SimpleForm
        public void ShowMainForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal; // Khôi phục lại kích thước bình thường
        }
        #endregion 

        private void TaskForm1_Load(object sender, EventArgs e)
        {
        }

        private void ShowEST()
        {
            float sum = TotalMin + 4 * TotalOP + TotalMax;
            float est = sum / 6f;
            decimal res = Math.Round((decimal)est, 2);
            /*  string resString = res.ToString();

              int index = resString.IndexOf(".");
              if (index != -1)
              {
                  int lastInd = Math.Min(index + 2, resString.Length );
                  resString = resString.Substring(0, lastInd);
              }*/

            lbTotalHour.Text = $"Total Hour: {Decimal.Floor(res / 60)}:{Math.Round(res, 0) % 60}";
            lbEst.Text = $"EST: {res}";
        }

        //---------------------------------------------------
        private void btAddTask_Click(object sender, EventArgs e)
        {
            string taskName = tbTaskName.Text;
            string description = rtbDescripttion.Text;

            if (string.IsNullOrEmpty(taskName) && string.IsNullOrEmpty(description))
            {
                return;
            }

            TotalMin += string.IsNullOrEmpty(tbMinTime.Text) ? 0 : float.Parse(tbMinTime.Text);
            TotalMax += string.IsNullOrEmpty(tbMaxTime.Text) ? 0 : float.Parse(tbMaxTime.Text);
            TotalOP += string.IsNullOrEmpty(tbEst.Text) ? 0 : float.Parse(tbEst.Text);
            if (IdEdit != -1)
            {
                TotalMin -= lsTask[IdEdit].MinTime;
                TotalMax -= lsTask[IdEdit].MaxTime;
                TotalOP -= lsTask[IdEdit].Est;

                lsTask[IdEdit].TaskName = tbTaskName.Text;
                lsTask[IdEdit].Description = rtbDescripttion.Text;
                lsTask[IdEdit].Est = string.IsNullOrEmpty(tbEst.Text) ? 0 : float.Parse(tbEst.Text);
                lsTask[IdEdit].MaxTime = string.IsNullOrEmpty(tbMaxTime.Text) ? 0 : float.Parse(tbMaxTime.Text);
                lsTask[IdEdit].MinTime = string.IsNullOrEmpty(tbMinTime.Text) ? 0 : float.Parse(tbMinTime.Text);
                btAddTask.Text = "Add Task";
                updateControl_v2(lsTask[IdEdit]);
                IdEdit = -1;
            }
            else
            {
                var TaskDetailDto = new TaskDetailDto
                {
                    No = lsTask.Count,
                    TaskName = tbTaskName.Text,
                    Description = rtbDescripttion.Text,
                    Est = string.IsNullOrEmpty(tbEst.Text) ? 0 : float.Parse(tbEst.Text),
                    MaxTime = string.IsNullOrEmpty(tbMaxTime.Text) ? 0 : float.Parse(tbMaxTime.Text),
                    MinTime = string.IsNullOrEmpty(tbMinTime.Text) ? 0 : float.Parse(tbMinTime.Text),
                    TimeWork = new TimeSpan(0, 0, 0, 0)
                };
                lsTask.Add(TaskDetailDto);
                AddControl_v2(TaskDetailDto);
            }

            tbMinTime.Text = "";
            tbMaxTime.Text = "";
            tbEst.Text = "";
            tbTaskName.Text = "";
            rtbDescripttion.Text = "";
            ShowList_v2();
            ShowEST();
        }

        #region CURD LIST UC UcTaskList
        private void AddControl_v2(TaskDetailDto data)
        {
                UcTaskList elementTaskList = new UcTaskList();
                // elementTaskList.Location = new Point(0, i * 50);
                elementTaskList.No = data.No;
                // take 30 characters of task name
                if (data.TaskName.Length > 30)
                {
                    elementTaskList.TaskName = data.TaskName.Substring(0, 28) + "...";
                }
                else
                { elementTaskList.TaskName = data.TaskName; }
                elementTaskList.Est = data.Est;
                elementTaskList.MinTime = data.MinTime;
                elementTaskList.MaxTime = data.MaxTime;

                // storage time work before reset
                elementTaskList.TimeWork = data.TimeWork;

                elementTaskList.RemoveControlClicked += UserControl_RemoveControlClicked;
                elementTaskList.EditControlClicked += UserControl_EditControlClicked;
                elementTaskList.SaveTimeControlButon += UserControl_SaveTimeControlClicked;
                elementTaskList.PlayTimeControlButon +=
                UserControl_PlayControlClicked;

                ListTaskUC_v2.Add(elementTaskList);
        }
        
        private void updateControl_v2(TaskDetailDto data)
        {
            UcTaskList elementTaskList = ListTaskUC_v2[data.No];
            elementTaskList.No = data.No;
            // take 30 characters of task name
            if (data.TaskName.Length > 30)
            {
                elementTaskList.TaskName = data.TaskName.Substring(0, 28) + "...";
            }
            else
            { elementTaskList.TaskName = data.TaskName; }

            elementTaskList.Est = data.Est;
            elementTaskList.MinTime = data.MinTime;
            elementTaskList.MaxTime = data.MaxTime;

            // storage time work before reset
            elementTaskList.TimeWork = data.TimeWork;

            ListTaskUC_v2[data.No] = elementTaskList;
        }
        #endregion

        #region event for UcTaskList
        private void UserControl_EditControlClicked(object sender, EventArgs e)
        {
            // Khi sự kiện được kích hoạt, xóa UserControl khỏi FlowLayoutPanel và danh sách
            btAddTask.Text = "Save change";
            UcTaskList userControl = sender as UcTaskList;
            if (userControl != null)
            {
                float subMin = lsTask[userControl.No ].MinTime,
                        subOp = lsTask[userControl.No ].Est,
                        subMax = lsTask[userControl.No ].MaxTime;
                float sum = subMin + 4 * subOp + subMax;
                float est = sum / 6f;
                decimal res = Math.Round((decimal)est, 2);


                tbTaskName.Text = lsTask[userControl.No].TaskName;
                tbMinTime.Text = subMin.ToString();
                tbMaxTime.Text = subMax.ToString();
                tbEst.Text = subOp.ToString();
                tbTaskName.Text = lsTask[userControl.No].TaskName;
                rtbDescripttion.Text = lsTask[userControl.No].Description;

                IdEdit = userControl.No;
                int detailHour = (int)(Decimal.Floor(res / 60));
                int detailMinute = (int)(Math.Round(res, 0) % 60);

                lbDetailHour.Text = $"Detail Hour: {detailHour}:{detailMinute}";
                lbFreeTime.Text = $"Free Time: {detailHour - userControl.TimeWork.Hours}:{detailMinute - userControl.TimeWork.Minutes}";
                double timeOver = userControl.TimeWork.TotalMinutes / (double)res * 100;
                lbPerCur.Text = $"Percent Cur: {(Math.Round(timeOver, 1))}%";
            }
        }

        private void UserControl_RemoveControlClicked(object sender, EventArgs e)
        {
            // Khi sự kiện được kích hoạt, xóa UserControl khỏi FlowLayoutPanel và danh sách
            UcTaskList userControl = sender as UcTaskList;
            if (userControl != null)
            {
                flowLayoutPanel1.Controls.Remove(userControl);

                TotalMin -= userControl.MinTime;
                TotalMax -= userControl.MaxTime;
                TotalOP -= userControl.Est;

                var id = userControl.No;
                lsTask.RemoveAt(id);
                ListTaskUC_v2.RemoveAt(id);
                ResetId();
                ShowEST();
            }
        }

        private void UserControl_PlayControlClicked(object sender, EventArgs e)
        {
            // Khi sự kiện được kích hoạt, xóa UserControl khỏi FlowLayoutPanel và danh sách
            UcTaskList userControlTaskElement = sender as UcTaskList;
            lsTask[userControlTaskElement.No].IsRunning = true;
            userControlTaskElement._timeCount.Start();
        }
        
        private void UserControl_SaveTimeControlClicked(object sender, EventArgs e)
        {
            // Khi sự kiện được kích hoạt, xóa UserControl khỏi FlowLayoutPanel và danh sách
            UcTaskList userControlTaskElement = sender as UcTaskList;

            lsTask[userControlTaskElement.No].TimeWork = userControlTaskElement.TimeWork;
            ListTaskUC_v2[userControlTaskElement.No].TimeWork = userControlTaskElement.TimeWork;

            lsTask[userControlTaskElement.No].IsRunning = false;

        }


        #endregion

        private void ShowList_v2()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < ListTaskUC_v2.Count; i++)
            { 
                flowLayoutPanel1.Controls.Add(ListTaskUC_v2[i]);
            }
        }

        private void ResetId()
        {
            for (int i = 0; i < lsTask.Count; i++)
            {
                lsTask[i].No = i ;
                ListTaskUC_v2[i].No = i;
            }
        }

    }
}
