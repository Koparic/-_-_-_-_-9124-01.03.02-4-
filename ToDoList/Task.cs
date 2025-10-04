using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public class Task
    {
        public int index;
        public string name;
        public string priority;
        public string category;
        public DateTime start;
        public DateTime end;
        public string status;

        //public void Row_to_Struct(DataGridViewRow row)
        //{
        //    index = (int)row.Cells["Index"].Value;
        //    name = row.Cells["TaskName"].Value.ToString();
        //    priority = row.Cells["Priority"].Value.ToString();
        //    category = row.Cells["Category"].Value.ToString();
        //    start = DateTime.Parse(row.Cells["CreationDate"].Value.ToString());
        //    end = DateTime.Parse(row.Cells["EndingDate"].Value.ToString());
        //    status = row.Cells["Status"].Value == null ? null : row.Cells["Status"].Value.ToString();
        //}
        
        public DataGridViewRow Task_to_Row(DataGridView table)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.CreateCells(table);
            row.Cells[0].Value = index.ToString();
            row.Cells[1].Value = name;
            row.Cells[2].Value = priority;
            row.Cells[3].Value = category;
            row.Cells[4].Value = start;
            row.Cells[5].Value = end;
            row.Cells[6].Value = status;
            return row;
        }
    }

}
