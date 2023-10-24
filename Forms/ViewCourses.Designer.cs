namespace SchoolManagementSystem.Forms
{
    partial class ViewCourses
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader_courseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_teacher = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_viewCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_courseID,
            this.columnHeader_courseName,
            this.columnHeader_teacher});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(50, 101);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(700, 249);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_courseID
            // 
            this.columnHeader_courseID.Text = "Course ID";
            this.columnHeader_courseID.Width = 97;
            // 
            // columnHeader_courseName
            // 
            this.columnHeader_courseName.Text = "Course Name";
            this.columnHeader_courseName.Width = 177;
            // 
            // columnHeader_teacher
            // 
            this.columnHeader_teacher.Text = "Teacher";
            this.columnHeader_teacher.Width = 190;
            // 
            // button_viewCourse
            // 
            this.button_viewCourse.Location = new System.Drawing.Point(363, 384);
            this.button_viewCourse.Name = "button_viewCourse";
            this.button_viewCourse.Size = new System.Drawing.Size(75, 23);
            this.button_viewCourse.TabIndex = 1;
            this.button_viewCourse.Text = "View Course";
            this.button_viewCourse.UseVisualStyleBackColor = true;
            this.button_viewCourse.Click += new System.EventHandler(this.button_viewCourse_Click);
            // 
            // ViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_viewCourse);
            this.Controls.Add(this.listView1);
            this.Name = "ViewCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewCourses";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader_courseID;
        private System.Windows.Forms.ColumnHeader columnHeader_courseName;
        private System.Windows.Forms.ColumnHeader columnHeader_teacher;
        private System.Windows.Forms.Button button_viewCourse;
    }
}