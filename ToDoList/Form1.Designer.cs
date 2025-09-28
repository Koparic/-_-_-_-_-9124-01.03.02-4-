namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddBttn = new System.Windows.Forms.Button();
            this.DeleteBttn = new System.Windows.Forms.Button();
            this.TaskTable = new System.Windows.Forms.DataGridView();
            this.EditBttn = new System.Windows.Forms.Button();
            this.StatusBttn = new System.Windows.Forms.Button();
            this.TaskName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TaskTable)).BeginInit();
            this.SuspendLayout();
            // 
            // AddBttn
            // 
            this.AddBttn.Location = new System.Drawing.Point(834, 12);
            this.AddBttn.Name = "AddBttn";
            this.AddBttn.Size = new System.Drawing.Size(107, 35);
            this.AddBttn.TabIndex = 0;
            this.AddBttn.Text = "Add";
            this.AddBttn.UseVisualStyleBackColor = true;
            this.AddBttn.Click += new System.EventHandler(this.AddBttn_Click);
            // 
            // DeleteBttn
            // 
            this.DeleteBttn.Location = new System.Drawing.Point(608, 12);
            this.DeleteBttn.Name = "DeleteBttn";
            this.DeleteBttn.Size = new System.Drawing.Size(107, 35);
            this.DeleteBttn.TabIndex = 1;
            this.DeleteBttn.Text = "Delete";
            this.DeleteBttn.UseVisualStyleBackColor = true;
            this.DeleteBttn.Click += new System.EventHandler(this.DeleteBttn_Click);
            // 
            // TaskTable
            // 
            this.TaskTable.AllowUserToAddRows = false;
            this.TaskTable.AllowUserToDeleteRows = false;
            this.TaskTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TaskTable.BackgroundColor = System.Drawing.Color.Azure;
            this.TaskTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TaskTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TaskName,
            this.Priority,
            this.Category,
            this.CreationDate,
            this.EndingDate,
            this.Status});
            this.TaskTable.GridColor = System.Drawing.SystemColors.ControlLight;
            this.TaskTable.Location = new System.Drawing.Point(12, 66);
            this.TaskTable.Name = "TaskTable";
            this.TaskTable.ReadOnly = true;
            this.TaskTable.RowHeadersVisible = false;
            this.TaskTable.RowHeadersWidth = 51;
            this.TaskTable.RowTemplate.Height = 24;
            this.TaskTable.ShowEditingIcon = false;
            this.TaskTable.Size = new System.Drawing.Size(929, 639);
            this.TaskTable.TabIndex = 2;
            // 
            // EditBttn
            // 
            this.EditBttn.Location = new System.Drawing.Point(721, 12);
            this.EditBttn.Name = "EditBttn";
            this.EditBttn.Size = new System.Drawing.Size(107, 35);
            this.EditBttn.TabIndex = 3;
            this.EditBttn.Text = "Edit";
            this.EditBttn.UseVisualStyleBackColor = true;
            this.EditBttn.Click += new System.EventHandler(this.EditBttn_Click);
            // 
            // StatusBttn
            // 
            this.StatusBttn.Location = new System.Drawing.Point(12, 12);
            this.StatusBttn.Name = "StatusBttn";
            this.StatusBttn.Size = new System.Drawing.Size(107, 35);
            this.StatusBttn.TabIndex = 4;
            this.StatusBttn.Text = "Set Status";
            this.StatusBttn.UseVisualStyleBackColor = true;
            this.StatusBttn.Click += new System.EventHandler(this.StatusBttn_Click);
            // 
            // TaskName
            // 
            this.TaskName.HeaderText = "Name";
            this.TaskName.MinimumWidth = 6;
            this.TaskName.Name = "TaskName";
            this.TaskName.ReadOnly = true;
            // 
            // Priority
            // 
            this.Priority.HeaderText = "Priority";
            this.Priority.MinimumWidth = 6;
            this.Priority.Name = "Priority";
            this.Priority.ReadOnly = true;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.ReadOnly = true;
            // 
            // CreationDate
            // 
            this.CreationDate.HeaderText = "CreationDate";
            this.CreationDate.MinimumWidth = 6;
            this.CreationDate.Name = "CreationDate";
            this.CreationDate.ReadOnly = true;
            // 
            // EndingDate
            // 
            this.EndingDate.HeaderText = "EndingDate";
            this.EndingDate.MinimumWidth = 6;
            this.EndingDate.Name = "EndingDate";
            this.EndingDate.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 717);
            this.Controls.Add(this.StatusBttn);
            this.Controls.Add(this.EditBttn);
            this.Controls.Add(this.TaskTable);
            this.Controls.Add(this.DeleteBttn);
            this.Controls.Add(this.AddBttn);
            this.Name = "Form1";
            this.Text = "ToDoList";
            ((System.ComponentModel.ISupportInitialize)(this.TaskTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddBttn;
        private System.Windows.Forms.Button DeleteBttn;
        private System.Windows.Forms.DataGridView TaskTable;
        private System.Windows.Forms.Button EditBttn;
        private System.Windows.Forms.Button StatusBttn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TaskName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

