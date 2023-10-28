namespace SchoolManagementSystem.Forms
{
    partial class ViewTeachers
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
            this.teacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.teacherName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_deleteTeacher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.teacherID,
            this.teacherName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 18);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(242, 239);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // teacherID
            // 
            this.teacherID.Text = "Teacher ID";
            this.teacherID.Width = 72;
            // 
            // teacherName
            // 
            this.teacherName.Text = "Teacher Name";
            this.teacherName.Width = 166;
            // 
            // button_deleteTeacher
            // 
            this.button_deleteTeacher.Location = new System.Drawing.Point(155, 269);
            this.button_deleteTeacher.Name = "button_deleteTeacher";
            this.button_deleteTeacher.Size = new System.Drawing.Size(100, 23);
            this.button_deleteTeacher.TabIndex = 1;
            this.button_deleteTeacher.Text = "Delete Teacher";
            this.button_deleteTeacher.UseVisualStyleBackColor = true;
            this.button_deleteTeacher.Click += new System.EventHandler(this.button1_Click);
            // 
            // ViewTeachers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(270, 304);
            this.Controls.Add(this.button_deleteTeacher);
            this.Controls.Add(this.listView1);
            this.Name = "ViewTeachers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTeachers";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader teacherID;
        private System.Windows.Forms.ColumnHeader teacherName;
        private System.Windows.Forms.Button button_deleteTeacher;
    }
}