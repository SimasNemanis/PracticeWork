using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace PracticeWork
{
    public partial class GroupForm : Form
    {
        GroupClass group = new GroupClass();
        public GroupForm()
        {
            InitializeComponent();
        }

        private void Groupclear_Click(object sender, EventArgs e)
        {
            txtgid.Clear();
            txtgname.Clear();
        }
        bool verify()
        {
            if ((txtgid.Text == "") || (txtgname.Text == ""))
            {
                return false;
            }
            else
                return true;

        }

        private void Groupadd_Click(object sender, EventArgs e)
        {
            int Gid = Convert.ToInt32(txtgid.Text);
            string GName = txtgname.Text;

            try
            {
                if (group.insertGroup(Gid, GName))
                {
                    showTable();
                    MessageBox.Show("New Group Added", "Add Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            DataGridGroup.DataSource = group.getGrouplist();
        }

        private void DataGridGroup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Groupupdate_Click(object sender, EventArgs e)
        {
            int Gid = Convert.ToInt32(txtgid.Text);
            string GName = txtgname.Text;

            if (verify())
            {
                try
                {
                    if (group.updateGroup(Gid, GName))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Group data updated", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No group found with the specified ID", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating Group data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Update Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

            private void Groupdelete_Click(object sender, EventArgs e)
        {
            int Gid = Convert.ToInt32(txtgid.Text);
            if (verify())
            {
                try
                {
                    if (group.deleteGroup(Gid))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Group data deleted", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No group found with the specified ID", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting group data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Delete Group", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void DataGridGroup_Click(object sender, EventArgs e)
        {
            txtgid.Text = DataGridGroup.CurrentRow.Cells[0].Value.ToString();
            txtgname.Text = DataGridGroup.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
