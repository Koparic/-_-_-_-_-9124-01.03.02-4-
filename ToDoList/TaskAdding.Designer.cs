namespace ToDoList
{
    partial class TaskAdding
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cancellbttn = new System.Windows.Forms.Button();
            this.ApplyBttn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.endingTime = new System.Windows.Forms.DateTimePicker();
            this.priorityText = new System.Windows.Forms.DomainUpDown();
            this.categoryText = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Priority";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(252, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ending Time";
            // 
            // Cancellbttn
            // 
            this.Cancellbttn.Location = new System.Drawing.Point(570, 205);
            this.Cancellbttn.Name = "Cancellbttn";
            this.Cancellbttn.Size = new System.Drawing.Size(75, 23);
            this.Cancellbttn.TabIndex = 4;
            this.Cancellbttn.Text = "Cancel";
            this.Cancellbttn.UseVisualStyleBackColor = true;
            this.Cancellbttn.Click += new System.EventHandler(this.Cancellbttn_Click);
            // 
            // ApplyBttn
            // 
            this.ApplyBttn.Location = new System.Drawing.Point(668, 205);
            this.ApplyBttn.Name = "ApplyBttn";
            this.ApplyBttn.Size = new System.Drawing.Size(75, 23);
            this.ApplyBttn.TabIndex = 5;
            this.ApplyBttn.Text = "Apply";
            this.ApplyBttn.UseVisualStyleBackColor = true;
            this.ApplyBttn.Click += new System.EventHandler(this.ApplyBttn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(25, 47);
            this.nameTextBox.Multiline = true;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(718, 58);
            this.nameTextBox.TabIndex = 6;
            // 
            // endingTime
            // 
            this.endingTime.Location = new System.Drawing.Point(503, 154);
            this.endingTime.Name = "endingTime";
            this.endingTime.Size = new System.Drawing.Size(240, 22);
            this.endingTime.TabIndex = 7;
            // 
            // priorityText
            // 
            this.priorityText.Items.Add("High");
            this.priorityText.Items.Add("Medium");
            this.priorityText.Items.Add("Low");
            this.priorityText.Location = new System.Drawing.Point(25, 154);
            this.priorityText.Name = "priorityText";
            this.priorityText.Size = new System.Drawing.Size(224, 22);
            this.priorityText.TabIndex = 9;
            // 
            // categoryText
            // 
            this.categoryText.FormattingEnabled = true;
            this.categoryText.Items.AddRange(new object[] {
            "Work",
            "Home",
            "Special"});
            this.categoryText.Location = new System.Drawing.Point(255, 152);
            this.categoryText.Name = "categoryText";
            this.categoryText.Size = new System.Drawing.Size(241, 24);
            this.categoryText.TabIndex = 10;
            // 
            // TaskAdding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 263);
            this.Controls.Add(this.categoryText);
            this.Controls.Add(this.priorityText);
            this.Controls.Add(this.endingTime);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.ApplyBttn);
            this.Controls.Add(this.Cancellbttn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TaskAdding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TaskAdding";
            this.Load += new System.EventHandler(this.TaskAdding_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cancellbttn;
        private System.Windows.Forms.Button ApplyBttn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.DateTimePicker endingTime;
        private System.Windows.Forms.DomainUpDown priorityText;
        private System.Windows.Forms.ComboBox categoryText;
    }
}