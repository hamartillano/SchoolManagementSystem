namespace SchoolManagementSystem.Forms
{
	partial class EnrollandUnenrollCourse
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
			this.courseID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.courseName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.teacherID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.grade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.courseID,
            this.courseName,
            this.teacherID,
            this.status,
            this.grade});
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(24, 30);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(576, 325);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
			// 
			// courseID
			// 
			this.courseID.Text = "Course ID";
			this.courseID.Width = 118;
			// 
			// courseName
			// 
			this.courseName.Text = "Course Name";
			this.courseName.Width = 129;
			// 
			// teacherID
			// 
			this.teacherID.Text = "Teacher ID";
			this.teacherID.Width = 126;
			// 
			// status
			// 
			this.status.Text = "Status";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(24, 361);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(263, 43);
			this.button1.TabIndex = 1;
			this.button1.Text = "Enroll";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(308, 360);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(292, 44);
			this.button2.TabIndex = 2;
			this.button2.Text = "Unenroll";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// grade
			// 
			this.grade.Text = "Grade";
			// 
			// EnrollandUnenrollCourse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 429);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.listView1);
			this.Name = "EnrollandUnenrollCourse";
			this.Text = "EnrollandUnenrollCourse";
			this.Load += new System.EventHandler(this.EnrollandUnenrollCourse_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ColumnHeader courseID;
		private System.Windows.Forms.ColumnHeader courseName;
		private System.Windows.Forms.ColumnHeader teacherID;
		private System.Windows.Forms.ColumnHeader status;
		private System.Windows.Forms.ColumnHeader grade;
	}
}