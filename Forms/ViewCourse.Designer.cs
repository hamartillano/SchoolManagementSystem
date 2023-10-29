namespace SchoolManagementSystem.Forms
{
    partial class ViewCourse
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
			this.textBox_courseID = new System.Windows.Forms.TextBox();
			this.textBox_courseName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_teacher = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.label4 = new System.Windows.Forms.Label();
			this.button_editGrade = new System.Windows.Forms.Button();
			this.button_back = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(105, 42);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Course ID:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// textBox_courseID
			// 
			this.textBox_courseID.Enabled = false;
			this.textBox_courseID.Location = new System.Drawing.Point(200, 35);
			this.textBox_courseID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_courseID.Name = "textBox_courseID";
			this.textBox_courseID.Size = new System.Drawing.Size(511, 26);
			this.textBox_courseID.TabIndex = 3;
			this.textBox_courseID.TextChanged += new System.EventHandler(this.textBox_couseID_TextChanged);
			// 
			// textBox_courseName
			// 
			this.textBox_courseName.Enabled = false;
			this.textBox_courseName.Location = new System.Drawing.Point(200, 95);
			this.textBox_courseName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_courseName.Name = "textBox_courseName";
			this.textBox_courseName.Size = new System.Drawing.Size(511, 26);
			this.textBox_courseName.TabIndex = 5;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 102);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Course Name:";
			// 
			// textBox_teacher
			// 
			this.textBox_teacher.Enabled = false;
			this.textBox_teacher.Location = new System.Drawing.Point(200, 160);
			this.textBox_teacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_teacher.Name = "textBox_teacher";
			this.textBox_teacher.Size = new System.Drawing.Size(511, 26);
			this.textBox_teacher.TabIndex = 7;
			this.textBox_teacher.TextChanged += new System.EventHandler(this.textBox_teacher_TextChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(30, 165);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(158, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Assigned TeacherID:";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(200, 225);
			this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(511, 453);
			this.listView1.TabIndex = 8;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "Student ID";
			this.columnHeader1.Width = 91;
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Student Name";
			this.columnHeader2.Width = 155;
			// 
			// columnHeader3
			// 
			this.columnHeader3.Text = "Student Grade";
			this.columnHeader3.Width = 92;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(51, 225);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(140, 20);
			this.label4.TabIndex = 10;
			this.label4.Text = "Enrolled Students:";
			// 
			// button_editGrade
			// 
			this.button_editGrade.Location = new System.Drawing.Point(200, 691);
			this.button_editGrade.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_editGrade.Name = "button_editGrade";
			this.button_editGrade.Size = new System.Drawing.Size(112, 35);
			this.button_editGrade.TabIndex = 11;
			this.button_editGrade.Text = "Edit Grade";
			this.button_editGrade.UseVisualStyleBackColor = true;
			this.button_editGrade.Click += new System.EventHandler(this.button_editGrade_Click);
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(78, 691);
			this.button_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(112, 35);
			this.button_back.TabIndex = 12;
			this.button_back.Text = "Back";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// ViewCourse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(742, 760);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.button_editGrade);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.textBox_teacher);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_courseName);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox_courseID);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "ViewCourse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ViewCourse";
			this.Load += new System.EventHandler(this.ViewCourse_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_courseID;
        private System.Windows.Forms.TextBox textBox_courseName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_teacher;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button button_editGrade;
        private System.Windows.Forms.Button button_back;
    }
}