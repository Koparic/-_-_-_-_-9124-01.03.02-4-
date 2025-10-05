using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;

namespace ToDoList
{
    public partial class Form1 : Form
    {
        public List<Task> task_list = new List<Task>();

        public Form1()
        {
            InitializeComponent();
            string filePath = "tasks.json";
            if (File.Exists(filePath))
            {
                using (StreamReader reader = File.OpenText(filePath))
                {
                    string json = reader.ReadToEnd();
                    task_list.Clear();
                    foreach (Task task in JsonConvert.DeserializeObject<Task[]>(json))
                        task_list.Add(task);
                }
            }
            Update_Table();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            string filePath = "tasks.json";
            using (StreamWriter writer = File.CreateText(filePath))
            {
                string json = JsonConvert.SerializeObject(task_list, Newtonsoft.Json.Formatting.Indented);
                writer.Write(json);
            }
        }

        private void Update_Row(int rowIndex, Task task)
        {
            DataGridViewRow new_row = task.Task_to_Row(TaskTable);
            for (int i = 0; i < TaskTable.Rows[rowIndex].Cells.Count; i++)
            {
                TaskTable.Rows[rowIndex].Cells[i].Value = new_row.Cells[i].Value;
            }
            Color c;
            switch (task.category)
            {
                case "Work":
                    c = Color.Bisque;
                    break;

                case "Home":
                    c = Color.LightBlue; break;

                case "Special":
                    c = Color.Lavender; break;

                default:
                    c = Color.Pink; break;
            }
            if (c != Color.Empty)
            {
                foreach (DataGridViewCell i in TaskTable.Rows[rowIndex].Cells) i.Style.BackColor = c;
            }
            switch (task.status)
            {
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
                    break;
            }
            TaskTable.Rows[rowIndex].Cells["Status"].Style.BackColor = c;
        }

        private void Update_Table()
        {
            TaskTable.Rows.Clear();
            foreach (Task task in task_list)
            {
                Update_Row(TaskTable.Rows.Add(task.Task_to_Row(TaskTable)), task);
            }
        }

        public void AddTask(Task task, bool e, int rowNum)
        {
            if (e)
                task_list[task.index] = task;
            else
                task_list.Add(task);
            Update_Table();
        }


        public void StatusChange(int row, string status)
        {
            int task_index = Convert.ToInt32(TaskTable.Rows[row].Cells["Index"].Value);
            task_list[task_index].status = status;
            Update_Row(row, task_list[task_index]);
        }

        private void AddBttn_Click(object sender, EventArgs e)
        {
            TaskAdding ta = new TaskAdding(new Task(), this, false, 0);
            ta.ShowDialog();
        }

        private void EditBttn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = TaskTable.CurrentRow;
            if (row != null)
            {
                Task ts = new Task();
                ts = task_list[Convert.ToInt32(row.Cells["Index"].Value)];
                TaskAdding ta = new TaskAdding(ts, this, true, TaskTable.CurrentRow.Index);
                ta.ShowDialog();
            }
        }

        private void DeleteBttn_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = TaskTable.CurrentRow;
            if (row != null)
            {
                task_list.RemoveAt(Convert.ToInt32(row.Cells["Index"].Value));
                for (int i = 0; i < task_list.Count; i++)
                {
                    task_list[i].index = i;
                }
                TaskTable.Rows.Remove(row);
            }
            Update_Table();
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
