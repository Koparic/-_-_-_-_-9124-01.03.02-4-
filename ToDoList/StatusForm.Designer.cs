namespace ToDoList
{
    partial class StatusForm
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
            this.statusSelector = new System.Windows.Forms.ComboBox();
            this.okBttn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // statusSelector
            // 
            this.statusSelector.FormattingEnabled = true;
            this.statusSelector.Items.AddRange(new object[] {
            "",
            "Done",
            "In Work",
            "Cancelled",
            "Failed"});
            this.statusSelector.Location = new System.Drawing.Point(12, 23);
            this.statusSelector.Name = "statusSelector";
            this.statusSelector.Size = new System.Drawing.Size(186, 24);
            this.statusSelector.TabIndex = 0;
            // 
            // okBttn
            // 
            this.okBttn.Location = new System.Drawing.Point(237, 24);
            this.okBttn.Name = "okBttn";
            this.okBttn.Size = new System.Drawing.Size(75, 23);
            this.okBttn.TabIndex = 1;
            this.okBttn.Text = "OK";
            this.okBttn.UseVisualStyleBackColor = true;
            this.okBttn.Click += new System.EventHandler(this.okBttn_Click);
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(334, 69);
            this.Controls.Add(this.okBttn);
            this.Controls.Add(this.statusSelector);
            this.Name = "StatusForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StatusForm";
            this.Load += new System.EventHandler(this.StatusForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox statusSelector;
        private System.Windows.Forms.Button okBttn;
    }
}