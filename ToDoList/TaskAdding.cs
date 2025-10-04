using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class TaskAdding : Form
    {
        private Task task;
        private Form1 form1;
        private bool isEdit = false;
        private int rn;

        public TaskAdding(Task ts, Form1 f1, bool ise, int rowNum)
        {
            InitializeComponent();
            isEdit = ise;
            form1 = f1;
            rn = rowNum;
            task = ts;
            nameTextBox.Text = ts.name;
            priorityText.Text = ts.priority == null? priorityText.Items[0].ToString(): ts.priority;
            categoryText.Text = ts.category == null ? categoryText.Items[0].ToString() : ts.category;
            endingTime.Value = ise ? ts.end : DateTime.Now;
            if (!ise) ts.index = f1.task_list.Count;
        }

        private void TaskAdding_Load(object sender, EventArgs e)
        {

        }

        private void ApplyBttn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                task.name = nameTextBox.Text;
                task.priority = priorityText.Text;
                task.category = categoryText.Text;
                task.end = endingTime.Value;
                if (task.start <= DateTime.MinValue)
                {
                    task.start = DateTime.Now;
                }
                form1.AddTask(task, isEdit, rn);
                this.Close();
            }
            else
            {
                label1.ForeColor = Color.Red;
            }
        }

        private void Cancellbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
