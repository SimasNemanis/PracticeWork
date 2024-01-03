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
    public partial class ManageStudent : Form
    {
        StudentClass student = new StudentClass();
        public ManageStudent()
        {
            InitializeComponent();
        }

        private void ManageStudent_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            RegisterForm.DataSource = student.getStudentlist();
        }

        private void RegisterForm_Click(object sender, EventArgs e)
        {
            txtstdid.Text = RegisterForm.CurrentRow.Cells[0].Value.ToString();
            txtstduser.Text = RegisterForm.CurrentRow.Cells[1].Value.ToString();
            txtstdpass.Text = RegisterForm.CurrentRow.Cells[2].Value.ToString();
            txtstdfname.Text = RegisterForm.CurrentRow.Cells[3].Value.ToString();
            txtstdlname.Text = RegisterForm.CurrentRow.Cells[4].Value.ToString();

            stdDOB.Value = (DateTime)RegisterForm.CurrentRow.Cells[5].Value;
            if (RegisterForm.CurrentRow.Cells[6].Value.ToString() == "Male")
                stdmale.Checked = true;

            txtstdphone.Text = RegisterForm.CurrentRow.Cells[7].Value.ToString();
            txtstdaddress.Text = RegisterForm.CurrentRow.Cells[8].Value.ToString();
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

        private void stdupdate_Click(object sender, EventArgs e)
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
                MessageBox.Show("The student's age must be between 10 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (student.updateStudent(stid, uname, pass, fname, lname, bDate, gender, phone, address))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Student data updated", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No student found with the specified ID", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void stddelete_Click(object sender, EventArgs e)
        {
            int stid = Convert.ToInt32(txtstdid.Text);
               if (verify())
            {
                try
                {
                    if (student.deleteStudent(stid))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Student data deleted", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No student found with the specified ID", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting student data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RegisterForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
