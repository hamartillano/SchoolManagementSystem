namespace SchoolManagementSystem.Forms
{
    partial class EditCourse
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
            this.textBox_cid = new System.Windows.Forms.TextBox();
            this.button_back = new System.Windows.Forms.Button();
            this.textBox_cname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_confirm = new System.Windows.Forms.Button();
            this.textBox_assignedTeacher = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Course ID:";
            // 
            // textBox_cid
            // 
            this.textBox_cid.Enabled = false;
            this.textBox_cid.Location = new System.Drawing.Point(91, 12);
            this.textBox_cid.Name = "textBox_cid";
            this.textBox_cid.Size = new System.Drawing.Size(100, 20);
            this.textBox_cid.TabIndex = 1;
            this.textBox_cid.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(14, 127);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(75, 23);
            this.button_back.TabIndex = 2;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_cname
            // 
            this.textBox_cname.Location = new System.Drawing.Point(91, 49);
            this.textBox_cname.Name = "textBox_cname";
            this.textBox_cname.Size = new System.Drawing.Size(100, 20);
            this.textBox_cname.TabIndex = 4;
            this.textBox_cname.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Course Name:";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(116, 127);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 5;
            this.button_confirm.Text = "Confirm";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox_assignedTeacher
            // 
            this.textBox_assignedTeacher.Enabled = false;
            this.textBox_assignedTeacher.Location = new System.Drawing.Point(91, 86);
            this.textBox_assignedTeacher.Name = "textBox_assignedTeacher";
            this.textBox_assignedTeacher.Size = new System.Drawing.Size(100, 20);
            this.textBox_assignedTeacher.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Teacher ID:";
            // 
            // EditCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 174);
            this.Controls.Add(this.textBox_assignedTeacher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.textBox_cname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.textBox_cid);
            this.Controls.Add(this.label1);
            this.Name = "EditCourse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCourse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_cid;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.TextBox textBox_cname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox textBox_assignedTeacher;
        private System.Windows.Forms.Label label3;
    }
}