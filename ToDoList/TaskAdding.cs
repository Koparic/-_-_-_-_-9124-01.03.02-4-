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
        private Form1.Task.task_struct task_struct;
        private Form1 form1;
        private bool isEdit = false;
        private int rn;

        public TaskAdding(Form1.Task.task_struct ts, Form1 f1, bool ise, int rowNum)
        {
            InitializeComponent();
            isEdit = ise;
            form1 = f1;
            rn = rowNum;
            task_struct = ts;
            nameTextBox.Text = ts.name;
            priorityText.Text = ts.priority == null? priorityText.Items[0].ToString(): ts.priority;
            categoryText.Text = ts.category == null ? categoryText.Items[0].ToString() : ts.category;
            endingTime.Value = ts.end <= DateTime.MinValue ? DateTime.Now:  ts.end;
        }

        private void TaskAdding_Load(object sender, EventArgs e)
        {

        }

        private void ApplyBttn_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "")
            {
                task_struct.name = nameTextBox.Text;
                task_struct.priority = priorityText.Text;
                task_struct.category = categoryText.Text;
                task_struct.end = endingTime.Value;
                if (task_struct.start <= DateTime.MinValue)
                {
                    task_struct.start = DateTime.Now;
                }
                form1.AddTask(task_struct, isEdit, rn);
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
