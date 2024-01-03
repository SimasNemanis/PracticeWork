using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace PracticeWork
{
    public partial class LoginForm : Form
    {
        StudentClass student = new StudentClass();
        TeacherClass teacher = new TeacherClass();
        AdministratorClass administrator = new AdministratorClass();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Red;
        }

        private void label10_MouseLeave(object sender, EventArgs e)
        {
            label10.ForeColor = Color.Black;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void studentbutton_Click(object sender, EventArgs e)
        {
            if (txtSname.Text == "" || txtSpass.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sname = txtSname.Text;
                string spass = txtSpass.Text;

                // Using parameterized query to prevent SQL injection
                string query = "SELECT * FROM `studentuser` WHERE StudentUsername = @Username AND StudentPassword = @Password";
                MySqlCommand command = new MySqlCommand(query);
                command.Parameters.AddWithValue("@Username", sname);
                command.Parameters.AddWithValue("@Password", spass);

                DataTable table = student.getList(command);

                if (table.Rows.Count > 0)
                {
                    string firstName = table.Rows[0]["StdFirstName"].ToString();
                    string lastName = table.Rows[0]["StdLastName"].ToString();

                    StudentForm main = new StudentForm(firstName, lastName);
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your username and password do not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtTname.Text == "" || txtTpass.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string tname = txtTname.Text;
                string tpass = txtTpass.Text;

                // Using parameterized query to prevent SQL injection
                string query = "SELECT * FROM `teacheruser` WHERE TeacherUsername = @Username AND TeacherPassword = @Password";
                MySqlCommand command = new MySqlCommand(query);
                command.Parameters.AddWithValue("@Username", tname);
                command.Parameters.AddWithValue("@Password", tpass);

                DataTable table = teacher.getList(command);

                if (table.Rows.Count > 0)
                {

                    Score main = new Score();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your username and password do not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void AdminLogin_Click(object sender, EventArgs e)
        {
            if (txtAdname.Text == "" || txtAdpass.Text == "")
            {
                MessageBox.Show("Need login data", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string adname = txtAdname.Text;
                string adpass = txtAdpass.Text;

                // Using parameterized query to prevent SQL injection
                string query = "SELECT * FROM `administratoruser` WHERE AdministratorUsername = @Username AND AdministratorPassword = @Password";
                MySqlCommand command = new MySqlCommand(query);
                command.Parameters.AddWithValue("@Username", adname);
                command.Parameters.AddWithValue("@Password", adpass);

                DataTable table = administrator.getList(command);

                if (table.Rows.Count > 0)
                {

                    Administrator main = new Administrator();
                    this.Hide();
                    main.Show();
                }
                else
                {
                    MessageBox.Show("Your username and password do not exist", "Wrong Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
