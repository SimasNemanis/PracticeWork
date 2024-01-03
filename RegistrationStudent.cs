using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography.X509Certificates;

namespace PracticeWork
{
    public partial class RegistrationStudent : Form
    {
        StudentClass student = new StudentClass();
        public RegistrationStudent()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stdclear_Click(object sender, EventArgs e)
        {
            txtstdid.Clear();
            txtstduser.Clear();
            txtstdpass.Clear();
            txtstdfname.Clear();
            txtstdlname.Clear();
            txtstdphone.Clear();
            txtstdaddress.Clear();
            stdmale.Checked = true;
            stdDOB.Value = DateTime.Now;
        }

        bool verify()
        {
            if ((txtstdid.Text == "") || (txtstduser.Text == "") || (txtstdpass.Text == "") ||
                (txtstdfname.Text == "") || (txtstdlname.Text == "") ||
                (txtstdphone.Text == "") || (txtstdaddress.Text == ""))
            {
                return false;
            }
            else
                return true;

        }

        private void stdadd_Click(object sender, EventArgs e)
        {
            int stid = Convert.ToInt32(txtstdid.Text);
            string uname = txtstduser.Text;
            string pass = txtstdpass.Text;
            string fname = txtstdfname.Text;
            string lname = txtstdlname.Text;
            DateTime bDate = stdDOB.Value;
            string gender = stdmale.Checked ? "Male" : "Female";
            string phone = txtstdphone.Text;
            string address = txtstdaddress.Text;

            int born_year = stdDOB.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 10 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The students age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (student.insertStudent(stid, uname, pass, fname, lname, bDate, gender, phone, address))
                    {
                        showTable();
                        MessageBox.Show("New Student Added", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationStudent_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            RegisterForm.DataSource = student.getStudentlist();
        }

        private void stdExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stdExit_MouseEnter(object sender, EventArgs e)
        {
            stdExit.ForeColor = Color.Red;
        }

        private void stdExit_MouseLeave(object sender, EventArgs e)
        {
            stdExit.ForeColor = Color.Black;
        }
    }
}
