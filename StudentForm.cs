using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeWork
{
    public partial class StudentForm : Form
      
    {
        private readonly string firstName;
        private readonly string lastName;
        SearchClass search = new SearchClass();
        ScoreClass score = new ScoreClass();
        CourseClass course = new CourseClass();
        public StudentForm(string firstName, string lastName)
        {
            InitializeComponent();
            this.firstName = firstName;
            this.lastName = lastName;

            txtstdfname.Text = firstName;
            txtstdlname.Text = lastName;
        }

        private void StudentForm_Load(object sender, EventArgs e)
        {
            cbcourse.DataSource = course.getCourselist();
            cbcourse.DisplayMember = "CourseName";
            cbcourse.ValueMember = "CourseName";

            DataGridStdS.DataSource = score.getList(new MySqlCommand("SELECT score.StudentUserID, studentuser.StdFirstName, studentuser.StdLastName, score.CourseName, score.Score, score.Description FROM studentuser INNER JOIN score ON score.StudentUserID = studentuser.StudentUserID"));

        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            try
            {
                string firstName = txtstdfname.Text.Trim();
                string lastName = txtstdlname.Text.Trim();
                string coursename = cbcourse.Text.Trim();

                DataGridStdS.DataSource = search.SearchStudent(firstName, lastName, coursename);
                DataGridStdS.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Red;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Black;
        }
    }
}
