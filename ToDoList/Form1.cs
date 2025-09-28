using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static ToDoList.Form1.Task;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public class Task
        {
            public struct task_struct
            {
                public string name;
                public string priority;
                public string category;
                public DateTime start;
                public DateTime end;
                public string status;
            }

            public static task_struct Row_to_Struct(DataGridViewRow row)
            {
                task_struct ts = new task_struct();
                ts.name = row.Cells["TaskName"].Value.ToString();
                ts.priority = row.Cells["Priority"].Value.ToString();
                ts.category = row.Cells["Category"].Value.ToString();
                ts.start = DateTime.Parse(row.Cells["CreationDate"].Value.ToString());
                ts.end = DateTime.Parse(row.Cells["EndingDate"].Value.ToString());
                ts.status = row.Cells["Status"].Value == null ? null : row.Cells["Status"].Value.ToString();
                return ts;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void AddTask(task_struct task, bool e, int rowNum)
        {
            if (e)
            {
                TaskTable.Rows.Remove(TaskTable.Rows[rowNum]);
            }
            TaskTable.Rows.Add(task.name, task.priority.ToString(), task.category, task.start.ToShortDateString(), task.end.ToShortDateString(), task.status);
        }


        public void StatusChange(int row, string status)
        {
            TaskTable.Rows[row].Cells["Status"].Value = status;
            Color c;
            switch(status){
                case "Done":
                    c = Color.LightGreen;
                    break;

                case "In Work":
                    c = Color.LightGoldenrodYellow; break;

                case "Failed":
                    c = Color.IndianRed; break;

                case "Cancelled":
                    c = Color.DarkGray; break;

                default:
                    c = Color.Empty; break;
            }
            if (c != Color.Empty)
            {
                foreach (DataGridViewCell i in TaskTable.Rows[row].Cells) i.Style.BackColor = c;

            }
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            TaskAdding ta = new TaskAdding(new Task.task_struct(), this, false, 0);
            ta.ShowDialog();
        }

        private void EditBttn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = TaskTable.CurrentRow;
            if (row != null)
            {
                TaskAdding ta = new TaskAdding(Row_to_Struct(row), this, true, TaskTable.CurrentRow.Index);
                ta.ShowDialog();
            }
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = TaskTable.CurrentRow;
            if (row != null)
            {
                TaskTable.Rows.Remove(row);
            }
        }

        private void StatusBttn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = TaskTable.CurrentRow;
            if (row != null)
            {
                StatusForm ta = new StatusForm(row.Index, this);
                ta.ShowDialog();
            }
        }
    }
}
