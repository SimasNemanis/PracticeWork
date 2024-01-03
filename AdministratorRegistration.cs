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
    public partial class AdministratorRegistration : Form
    {

        AdministratorClass administrator = new AdministratorClass();

        public AdministratorRegistration()
        {
            InitializeComponent();
        }

        private void Adclear_Click(object sender, EventArgs e)
        {
            txtAdid.Clear();
            txtAduser.Clear();
            txtAdpass.Clear();
            txtAdfname.Clear();
            txtAdlname.Clear();
            txtAdphone.Clear();
            txtAdaddress.Clear();
            Admale.Checked = true;
            AdDOB.Value = DateTime.Now;
        }
         bool verify()
                {
                    if ((txtAdid.Text == "") || (txtAduser.Text == "") || (txtAdpass.Text == "") ||
                        (txtAdfname.Text == "") || (txtAdlname.Text == "") ||
                        (txtAdphone.Text == "") || (txtAdaddress.Text == ""))
                    {
                        return false;
                    }
                    else
                        return true;

                }
        private void Adadd_Click(object sender, EventArgs e)
        {
            int Adid = Convert.ToInt32(txtAdid.Text);
            string Aduname = txtAduser.Text;
            string Adpass = txtAdpass.Text;
            string Adfname = txtAdfname.Text;
            string Adlname = txtAdlname.Text;
            DateTime AdbDate = AdDOB.Value;
            string Adgender = Admale.Checked ? "Male" : "Female";
            string Adphone = txtAdphone.Text;
            string Adaddress = txtAdaddress.Text;

            int born_year = AdDOB.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 20 || (this_year - born_year) > 100)
            {
                MessageBox.Show("The students age must be between 20 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (administrator.insertAdministrator(Adid, Aduname, Adpass, Adfname, Adlname, AdbDate, Adgender, Adphone, Adaddress))
                    {
                        showTable();
                        MessageBox.Show("New Administrator Added", "Add Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Add Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void AdministratorRegistration_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            AdRegisterForm.DataSource = administrator.getAdministratorlist();
        }
    }
}
