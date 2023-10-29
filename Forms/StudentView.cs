using SchoolManagementSystem.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms
{
	public partial class StudentView : Form
	{
		private Student currentStudent;
		
		public StudentView(Student student)
		{
			InitializeComponent();
			this.currentStudent = student;	
		}

		private void button1_Click(object sender, EventArgs e)
		{
			MyProfile viewMyProfileForm = new MyProfile(currentStudent);
			viewMyProfileForm.Show();
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{

		}

		private void button3_Click(object sender, EventArgs e)
		{

		}
	}
}
