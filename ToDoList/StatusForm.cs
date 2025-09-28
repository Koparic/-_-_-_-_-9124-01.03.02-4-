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
    public partial class StatusForm : Form
    {
        private int selRow;
        private Form1 form;
        public StatusForm(int a, Form1 f)
        {
            InitializeComponent();
            form = f;
            selRow = a;
        }

        private void StatusForm_Load(object sender, EventArgs e)
        {

        }

        private void okBttn_Click(object sender, EventArgs e)
        {
            form.StatusChange(selRow, statusSelector.Text);
            this.Close();
        }
    }
}
