using ESTDesktop.AppView.TaskView.TaskViewControl;
using ESTDesktop.AppView.TaskView.TaskViewControl.Dtos;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ESTDesktop.AppView.TaskView
{
    public partial class TaskForm1 : Form
    {
        public TaskForm1()
        {
            InitializeComponent();
            lsTask = new List<TaskDetailDto>();
          }
        
        public List<TaskDetailDto> lsTask { get; set; }
        public float TotalMin { get; set; }
        public float TotalOP { get; set; }
        public float TotalMax { get; set; }

        private int IdEdit { get; set; } = -1;

        private void TaskForm1_Load(object sender, EventArgs e)
        {
            ShowListTask();
        }
        private void ShowListTask()
        {
            int length = lsTask.Count();
            flowLayoutPanel1.Controls.Clear();
            UcTaskList[] ListTaskUC = new UcTaskList[length];

            for (int i = 0; i != -1 && i < length; i++)
            {
                ListTaskUC[i] = new UcTaskList();
                // ListTaskUC[i].Location = new Point(0, i * 50);
                ListTaskUC[i].No = lsTask[i].No;
                // take 30 characters of task name
                if (lsTask[i].TaskName.Length > 30)
                {
                    ListTaskUC[i].TaskName = lsTask[i].TaskName.Substring(0, 28) + "...";
                }
                else
                { ListTaskUC[i].TaskName = lsTask[i].TaskName; }
                ListTaskUC[i].Est = lsTask[i].Est;
                ListTaskUC[i].MinTime = lsTask[i].MinTime;
                ListTaskUC[i].MaxTime = lsTask[i].MaxTime;

                // storage time work before reset
                ListTaskUC[i].TimeWork = lsTask[i].TimeWork;

                ListTaskUC[i].RemoveControlClicked += UserControl_RemoveControlClicked;
                ListTaskUC[i].EditControlClicked += UserControl_EditControlClicked;
                ListTaskUC[i].SaveTimeControlButon += UserControl_SaveTimeControlClicked;
                
                flowLayoutPanel1.Controls.Add(ListTaskUC[i]);
            }
        }

        private void UserControl_RemoveControlClicked(object sender, EventArgs e)
        {
            // Khi sự kiện được kích hoạt, xóa UserControl khỏi FlowLayoutPanel và danh sách
            UcTaskList userControl = sender as UcTaskList;
            if (userControl != null)
            {
                TotalMin -= userControl.MinTime;
                TotalMax -= userControl.MaxTime;
                TotalOP -= userControl.Est;

                flowLayoutPanel1.Controls.Remove(userControl);
                var id = userControl.No;
                lsTask = lsTask.Where(x => x.No != id).ToList();
                for (int i = 0; i < lsTask.Count; i++)
                {
                    lsTask[i].No = i + 1;
                }
                ShowListTask();
                ShowEST();
            }
        }

        private void UserControl_EditControlClicked(object sender, EventArgs e)
        {
            // Khi sự kiện được kích hoạt, xóa UserControl khỏi FlowLayoutPanel và danh sách
            btAddTask.Text = "Save change";
            UcTaskList userControl = sender as UcTaskList;
            if (userControl != null)
            {
                float subMin = lsTask[userControl.No - 1].MinTime, 
                        subOp = lsTask[userControl.No - 1].Est, 
                        subMax = lsTask[userControl.No - 1].MaxTime;
                float sum = subMin + 4 * subOp + subMax;
                float est = sum / 6f;
                decimal res = Math.Round((decimal)est, 2);


                tbTaskName.Text = lsTask[userControl.No - 1].TaskName;
                tbMinTime.Text = subMin.ToString();
                tbMaxTime.Text = subMax.ToString();
                tbEst.Text = subOp.ToString();
                tbTaskName.Text = lsTask[userControl.No - 1].TaskName;
                rtbDescripttion.Text = lsTask[userControl.No - 1].Description;

                IdEdit = userControl.No - 1;
                int detailHour = (int)(Decimal.Floor(res / 60));
                int detailMinute = (int)(Math.Round(res, 0) % 60);

                lbDetailHour.Text = $"Detail Hour: {detailHour}:{detailMinute}";
                lbFreeTime.Text = $"Free Time: {detailHour - userControl.TimeWork.Hours}:{detailMinute - userControl.TimeWork.Minutes}";
                double timeOver = userControl.TimeWork.TotalMinutes /(double) res * 100;
                lbPerCur.Text = $"Percent Cur: {(Math.Round(timeOver, 1))}%";
            }
        }

        

        private void UserControl_SaveTimeControlClicked(object sender, EventArgs e)
        {
            // Khi sự kiện được kích hoạt, xóa UserControl khỏi FlowLayoutPanel và danh sách
            UcTaskList userControlTaskElement = sender as UcTaskList;

            lsTask[userControlTaskElement.No - 1].TimeWork = userControlTaskElement.TimeWork;
        }
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
                IdEdit = -1;
                btAddTask.Text = "Add Task";
            }
            else
            {
                var TaskDetailDto = new TaskDetailDto
                {
                    No = lsTask.Count + 1,
                    TaskName = tbTaskName.Text,
                    Description = rtbDescripttion.Text,
                    Est = string.IsNullOrEmpty(tbEst.Text) ? 0 : float.Parse(tbEst.Text),
                    MaxTime = string.IsNullOrEmpty(tbMaxTime.Text) ? 0 : float.Parse(tbMaxTime.Text),
                    MinTime = string.IsNullOrEmpty(tbMinTime.Text) ? 0 : float.Parse(tbMinTime.Text),
                    TimeWork = new TimeSpan(0, 0, 0, 0)
                };
                lsTask.Add(TaskDetailDto);
            }

            tbMinTime.Text = "";
            tbMaxTime.Text = "";
            tbEst.Text = "";
            tbTaskName.Text = "";
            rtbDescripttion.Text = "";
            ShowListTask();
            ShowEST();
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
            
            lbTotalHour.Text = $"Total Hour: {Decimal.Floor(res/60)}:{Math.Round(res,0)% 60}";
            lbEst.Text = $"EST: {res}";
        }
        private void rtbDescripttion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
