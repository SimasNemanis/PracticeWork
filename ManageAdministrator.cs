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
    public partial class ManageAdministrator : Form
    {

        AdministratorClass administrator = new AdministratorClass();

        public ManageAdministrator()
        {
            InitializeComponent();
        }

        private void ManageAdministrator_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            AdRegisterForm.DataSource = administrator.getAdministratorlist();
        }

        private void AdRegisterForm_Click(object sender, EventArgs e)
        {
            txtAdid.Text = AdRegisterForm.CurrentRow.Cells[0].Value.ToString();
            txtAduser.Text = AdRegisterForm.CurrentRow.Cells[1].Value.ToString();
            txtAdpass.Text = AdRegisterForm.CurrentRow.Cells[2].Value.ToString();
            txtAdfname.Text = AdRegisterForm.CurrentRow.Cells[3].Value.ToString();
            txtAdlname.Text = AdRegisterForm.CurrentRow.Cells[4].Value.ToString();

            AdDOB.Value = (DateTime)AdRegisterForm.CurrentRow.Cells[5].Value;
            if (AdRegisterForm.CurrentRow.Cells[6].Value.ToString() == "Male")
                Admale.Checked = true;

            txtAdphone.Text = AdRegisterForm.CurrentRow.Cells[7].Value.ToString();
            txtAdaddress.Text = AdRegisterForm.CurrentRow.Cells[8].Value.ToString();
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

        private void Adupdate_Click(object sender, EventArgs e)
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
                MessageBox.Show("The student's age must be between 20 and 100", "Invalid Birthdate", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                try
                {
                    if (administrator.updateAdministrator(Adid, Aduname, Adpass, Adfname, Adlname, AdbDate, Adgender, Adphone, Adaddress))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Administrator data updated", "Update Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No administrator found with the specified ID", "Update Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating administrator data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Addelete_Click(object sender, EventArgs e)
        {
            int Adstid = Convert.ToInt32(txtAdid.Text);
            if (verify())
            {
                try
                {
                    if (administrator.deleteAdministrator(Adstid))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Administrator data deleted", "Delete Administrator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No administrator found with the specified ID", "Delete Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting administrator data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Delete Administrator", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
