using System;
using System.IO;
using System.Windows.Forms;

namespace SchoolManagementSystem.Forms
{
    public partial class EditGrade : Form
    {
        private int studentID;
        private string studentName;
        private string studentGrade;

        public EditGrade(int StudentID, string StudentName, string StudentGrade)
        {
            InitializeComponent();
            textBox_sid.Text = StudentID.ToString();
            textBox_sname.Text = StudentName;
            textBox_sgrade.Text = StudentGrade;
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private bool IsValidGrade(string grade)
        {
            return grade.Length == 1 && "ABCDEF".Contains(grade);
        }

        private void UpdateGradeInFile()
        {
            string[] lines = File.ReadAllLines("students.txt");

            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i];
                string[] parts = line.Split(',');

                if (parts.Length >= 2 && int.TryParse(parts[1], out int id) && id == studentID)
                {
                    parts[3] = studentGrade;
                    lines[i] = string.Join(",", parts);
                    break;
                }
            }

            File.WriteAllLines("students.txt", lines);
        }

        private void button_confirm_Click_1(object sender, EventArgs e)
        {
            string newGrade = textBox_sgrade.Text;

            if (!IsValidGrade(newGrade))
            {
                MessageBox.Show("Invalid grade. Please enter a valid grade.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            studentGrade = newGrade;
            UpdateGradeInFile();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
