namespace SchoolManagementSystem.Forms
{
    partial class CreateCourse
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
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.button_addCourse = new System.Windows.Forms.Button();
			this.button_back = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox_cid = new System.Windows.Forms.TextBox();
			this.textBox_cname = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox_assignedTeacher = new System.Windows.Forms.TextBox();
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(27, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 20);
			this.label1.TabIndex = 0;
			this.label1.Text = "Course ID:";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button_addCourse
			// 
			this.button_addCourse.Location = new System.Drawing.Point(378, 206);
			this.button_addCourse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_addCourse.Name = "button_addCourse";
			this.button_addCourse.Size = new System.Drawing.Size(112, 35);
			this.button_addCourse.TabIndex = 1;
			this.button_addCourse.Text = "Add";
			this.button_addCourse.UseVisualStyleBackColor = true;
			this.button_addCourse.Click += new System.EventHandler(this.button_addCourse_Click);
			// 
			// button_back
			// 
			this.button_back.Location = new System.Drawing.Point(32, 206);
			this.button_back.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.button_back.Name = "button_back";
			this.button_back.Size = new System.Drawing.Size(112, 35);
			this.button_back.TabIndex = 4;
			this.button_back.Text = "Back";
			this.button_back.UseVisualStyleBackColor = true;
			this.button_back.Click += new System.EventHandler(this.button_back_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(27, 86);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(110, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Course Name:";
			this.label2.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox_cid
			// 
			this.textBox_cid.Location = new System.Drawing.Point(180, 28);
			this.textBox_cid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_cid.Name = "textBox_cid";
			this.textBox_cid.Size = new System.Drawing.Size(308, 26);
			this.textBox_cid.TabIndex = 5;
			// 
			// textBox_cname
			// 
			this.textBox_cname.Location = new System.Drawing.Point(180, 80);
			this.textBox_cname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_cname.Name = "textBox_cname";
			this.textBox_cname.Size = new System.Drawing.Size(308, 26);
			this.textBox_cname.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(27, 140);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(141, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Assigned Teacher:";
			// 
			// textBox_assignedTeacher
			// 
			this.textBox_assignedTeacher.Enabled = false;
			this.textBox_assignedTeacher.Location = new System.Drawing.Point(180, 134);
			this.textBox_assignedTeacher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.textBox_assignedTeacher.Name = "textBox_assignedTeacher";
			this.textBox_assignedTeacher.Size = new System.Drawing.Size(308, 26);
			this.textBox_assignedTeacher.TabIndex = 8;
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// CreateCourse
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(518, 268);
			this.Controls.Add(this.textBox_assignedTeacher);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox_cname);
			this.Controls.Add(this.textBox_cid);
			this.Controls.Add(this.button_back);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_addCourse);
			this.Controls.Add(this.label1);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "CreateCourse";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CreateCourse";
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_addCourse;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_cid;
        private System.Windows.Forms.TextBox textBox_cname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_assignedTeacher;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
	}
}