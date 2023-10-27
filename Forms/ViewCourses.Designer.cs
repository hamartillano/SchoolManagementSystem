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
            this.button_viewCourse = new System.Windows.Forms.Button();
            this.button_createCourse = new System.Windows.Forms.Button();
            this.button_editCourse = new System.Windows.Forms.Button();
            this.button_deleteCourse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_courseID,
            this.columnHeader_courseName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 15);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(345, 289);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader_courseID
            // 
            this.columnHeader_courseID.Text = "Course ID";
            this.columnHeader_courseID.Width = 97;
            // 
            // columnHeader_courseName
            // 
            this.columnHeader_courseName.Text = "Course Name";
            this.columnHeader_courseName.Width = 240;
            // 
            // button_viewCourse
            // 
            this.button_viewCourse.Location = new System.Drawing.Point(14, 330);
            this.button_viewCourse.Name = "button_viewCourse";
            this.button_viewCourse.Size = new System.Drawing.Size(75, 23);
            this.button_viewCourse.TabIndex = 1;
            this.button_viewCourse.Text = "View Course";
            this.button_viewCourse.UseVisualStyleBackColor = true;
            this.button_viewCourse.Click += new System.EventHandler(this.button_viewCourse_Click);
            // 
            // button_createCourse
            // 
            this.button_createCourse.Location = new System.Drawing.Point(95, 330);
            this.button_createCourse.Name = "button_createCourse";
            this.button_createCourse.Size = new System.Drawing.Size(84, 23);
            this.button_createCourse.TabIndex = 2;
            this.button_createCourse.Text = "Create Course";
            this.button_createCourse.UseVisualStyleBackColor = true;
            this.button_createCourse.Click += new System.EventHandler(this.button_createCourse_Click);
            // 
            // button_editCourse
            // 
            this.button_editCourse.Location = new System.Drawing.Point(185, 330);
            this.button_editCourse.Name = "button_editCourse";
            this.button_editCourse.Size = new System.Drawing.Size(84, 23);
            this.button_editCourse.TabIndex = 3;
            this.button_editCourse.Text = "Edit Course";
            this.button_editCourse.UseVisualStyleBackColor = true;
            this.button_editCourse.Click += new System.EventHandler(this.button_editCourse_Click);
            // 
            // button_deleteCourse
            // 
            this.button_deleteCourse.Location = new System.Drawing.Point(275, 330);
            this.button_deleteCourse.Name = "button_deleteCourse";
            this.button_deleteCourse.Size = new System.Drawing.Size(84, 23);
            this.button_deleteCourse.TabIndex = 4;
            this.button_deleteCourse.Text = "Delete Course";
            this.button_deleteCourse.UseVisualStyleBackColor = true;
            this.button_deleteCourse.Click += new System.EventHandler(this.button_deleteCourse_Click);
            // 
            // ViewCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 369);
            this.Controls.Add(this.button_deleteCourse);
            this.Controls.Add(this.button_editCourse);
            this.Controls.Add(this.button_createCourse);
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
        private System.Windows.Forms.Button button_viewCourse;
        private System.Windows.Forms.Button button_createCourse;
        private System.Windows.Forms.Button button_editCourse;
        private System.Windows.Forms.Button button_deleteCourse;
    }
}