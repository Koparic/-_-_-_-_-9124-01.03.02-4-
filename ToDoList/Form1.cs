using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            string[] categories = new string[3] { "Work", "Home", "Special" };
            string[] statuses = new string[4] { "Done", "InWork", "Cancelled", "Faliled" };

            public struct task_struct
            {
                public string name;
                public string priority;
                public string category;
                public DateTime start;
                public DateTime end;
                public string status;
            }

        }

        public void AddTask(task_struct task, bool e, int rowNum)
        {
            if (e)
            {
                TaskTable.Rows.Remove(TaskTable.Rows[rowNum]);
            }
            TaskTable.Rows.Add(task.name, task.priority.ToString(), task.category, task.start.ToShortDateString(), task.end.ToShortDateString(), task.status);
        }

        public Form1()
        {
            InitializeComponent();
        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

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
                task_struct ts = new task_struct();
                ts.name = row.Cells["TaskName"].Value.ToString();
                ts.priority = row.Cells["Priority"].Value.ToString();
                ts.category = row.Cells["Category"].Value.ToString();
                ts.start = DateTime.Parse(row.Cells["CreationDate"].Value.ToString());
                ts.end = DateTime.Parse(row.Cells["EndingDate"].Value.ToString());
                ts.status = row.Cells["Status"].Value == null ? null : row.Cells["Status"].Value.ToString();
                TaskAdding ta = new TaskAdding(ts, this, true, TaskTable.CurrentRow.Index);
                ta.ShowDialog();
            }
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = TaskTable.CurrentRow;
            if (row != null)
            {
                TaskTable.Rows.Remove(TaskTable.CurrentRow);
            }
        }


    }
}
