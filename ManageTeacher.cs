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
    public partial class ManageTeacher : Form
    {

        TeacherClass teacher = new TeacherClass();

        public ManageTeacher()
        {
            InitializeComponent();
        }

        private void ManageTeacher_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            TRegisterForm.DataSource = teacher.getTeacherlist();
        }

        private void TRegisterForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Tclear_Click(object sender, EventArgs e)
        {
            txtTid.Clear();
            txtTuser.Clear();
            txtTpass.Clear();
            txtTfname.Clear();
            txtTlname.Clear();
            txtTphone.Clear();
            txtTaddress.Clear();
            Tmale.Checked = true;
            TDOB.Value = DateTime.Now;
        }
        bool verify()
        {
            if ((txtTid.Text == "") || (txtTuser.Text == "") || (txtTpass.Text == "") ||
                (txtTfname.Text == "") || (txtTlname.Text == "") ||
                (txtTphone.Text == "") || (txtTaddress.Text == ""))
            {
                return false;
            }
            else
                return true;

        }

        private void Tupdate_Click(object sender, EventArgs e)
        {
            int Tid = Convert.ToInt32(txtTid.Text);
            string Tuname = txtTuser.Text;
            string Tpass = txtTpass.Text;
            string Tfname = txtTfname.Text;
            string Tlname = txtTlname.Text;
            DateTime TbDate = TDOB.Value;
            string Tgender = Tmale.Checked ? "Male" : "Female";
            string Tphone = txtTphone.Text;
            string Taddress = txtTaddress.Text;

            int born_year = TDOB.Value.Year;
            int this_year = DateTime.Now.Year;

            if ((this_year - born_year) < 20 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The student's age must be between 20 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (teacher.updateTeacher(Tid, Tuname, Tpass, Tfname, Tlname, TbDate, Tgender, Tphone, Taddress))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Teacher data updated", "Update Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No teacher found with the specified ID", "Update Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Tdelete_Click(object sender, EventArgs e)
        {
            int Tstid = Convert.ToInt32(txtTid.Text);
            if (verify())
            {
                try
                {
                    if (teacher.deleteTeacher(Tstid))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Teacher data deleted", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No teacher found with the specified ID", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting teacher data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Delete Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ManageTeacher_Click(object sender, EventArgs e)
        {

        }

        private void TRegisterForm_Click(object sender, EventArgs e)
        {
            txtTid.Text = TRegisterForm.CurrentRow.Cells[0].Value.ToString();
            txtTuser.Text = TRegisterForm.CurrentRow.Cells[1].Value.ToString();
            txtTpass.Text = TRegisterForm.CurrentRow.Cells[2].Value.ToString();
            txtTfname.Text = TRegisterForm.CurrentRow.Cells[3].Value.ToString();
            txtTlname.Text = TRegisterForm.CurrentRow.Cells[4].Value.ToString();

            TDOB.Value = (DateTime)TRegisterForm.CurrentRow.Cells[5].Value;
            if (TRegisterForm.CurrentRow.Cells[6].Value.ToString() == "Male")
                Tmale.Checked = true;

            txtTphone.Text = TRegisterForm.CurrentRow.Cells[7].Value.ToString();
            txtTaddress.Text = TRegisterForm.CurrentRow.Cells[8].Value.ToString();
        }
    }
}
