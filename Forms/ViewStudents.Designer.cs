namespace SchoolManagementSystem.Forms
{
    partial class ViewStudents
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
            this.studentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.studentName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_deleteStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.studentID,
            this.studentName});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(242, 239);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // studentID
            // 
            this.studentID.Text = "Student ID";
            this.studentID.Width = 72;
            // 
            // studentName
            // 
            this.studentName.Text = "Student Name";
            this.studentName.Width = 166;
            // 
            // button_deleteStudent
            // 
            this.button_deleteStudent.Location = new System.Drawing.Point(155, 263);
            this.button_deleteStudent.Name = "button_deleteStudent";
            this.button_deleteStudent.Size = new System.Drawing.Size(100, 23);
            this.button_deleteStudent.TabIndex = 3;
            this.button_deleteStudent.Text = "Delete Student";
            this.button_deleteStudent.UseVisualStyleBackColor = true;
            this.button_deleteStudent.Click += new System.EventHandler(this.button_deleteStudent_Click);
            // 
            // ViewStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 299);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button_deleteStudent);
            this.Name = "ViewStudents";
            this.Text = "ViewStudents";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader studentID;
        private System.Windows.Forms.ColumnHeader studentName;
        private System.Windows.Forms.Button button_deleteStudent;
    }
}