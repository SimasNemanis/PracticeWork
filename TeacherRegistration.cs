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
    public partial class TeacherRegistration : Form
    {

        TeacherClass teacher = new TeacherClass();

        public TeacherRegistration()
        {
            InitializeComponent();
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
            if  ((txtTid.Text == "") || (txtTuser.Text == "") || (txtTpass.Text == "") ||
                (txtTfname.Text == "") || (txtTlname.Text == "") ||
                (txtTphone.Text == "") || (txtTaddress.Text == ""))
            {
                return false;
            }
            else
                return true;

        }

        private void Tadd_Click(object sender, EventArgs e)
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
                MessageBox.Show("The students age must be between 20 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (teacher.insertTeacher(Tid, Tuname, Tpass, Tfname, Tlname, TbDate, Tgender, Tphone, Taddress))
                    {
                        showTable();
                        MessageBox.Show("New Teacher Added", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Teacher", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void TeacherRegistration_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            TRegisterForm.DataSource = teacher.getTeacherlist();
        }
    }
}
