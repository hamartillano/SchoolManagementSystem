namespace SchoolManagementSystem.Forms
{
    partial class AdminMain
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
			this.button_viewTeachers = new System.Windows.Forms.Button();
			this.button_viewStudents = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button_viewTeachers
			// 
			this.button_viewTeachers.Location = new System.Drawing.Point(20, 22);
			this.button_viewTeachers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_viewTeachers.Name = "button_viewTeachers";
			this.button_viewTeachers.Size = new System.Drawing.Size(198, 155);
			this.button_viewTeachers.TabIndex = 0;
			this.button_viewTeachers.Text = "View Teachers";
			this.button_viewTeachers.UseVisualStyleBackColor = true;
			this.button_viewTeachers.Click += new System.EventHandler(this.button_viewTeachers_Click);
			// 
			// button_viewStudents
			// 
			this.button_viewStudents.Location = new System.Drawing.Point(250, 22);
			this.button_viewStudents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_viewStudents.Name = "button_viewStudents";
			this.button_viewStudents.Size = new System.Drawing.Size(198, 155);
			this.button_viewStudents.TabIndex = 1;
			this.button_viewStudents.Text = "View Students";
			this.button_viewStudents.UseVisualStyleBackColor = true;
			this.button_viewStudents.Click += new System.EventHandler(this.button_viewStudents_Click);
			// 
			// AdminMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(470, 198);
			this.Controls.Add(this.button_viewStudents);
			this.Controls.Add(this.button_viewTeachers);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "AdminMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AdminMain";
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_viewTeachers;
        private System.Windows.Forms.Button button_viewStudents;
    }
}