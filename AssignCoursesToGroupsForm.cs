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
    public partial class AssignCoursesToGroupsForm : Form
    {
        CourseClass course = new CourseClass();
        GroupClass group = new GroupClass();
        public AssignCoursesToGroupsForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            // Load subjects into a ComboBox
            cmbCourse.DataSource = course.getCourselist();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";

            // Load groups into a ComboBox
            cmbGroup.DataSource = group.getGrouplist();
            cmbGroup.DisplayMember = "GroupName";
            cmbGroup.ValueMember = "GroupID";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int Cid = Convert.ToInt32(cmbCourse.SelectedValue);
            int Gid = Convert.ToInt32(cmbGroup.SelectedValue);

            // Perform the assignment
            if (group.AssignCourseToGroup(Cid, Gid))
            {
                MessageBox.Show("Course assigned to group successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh data after assignment
                showTable();
            }
            else
            {
                MessageBox.Show("Failed to assign course to group.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int Gid = Convert.ToInt32(cmbGroup.SelectedValue);
            int Cid = Convert.ToInt32(cmbCourse.SelectedValue);

            // Perform the deletion
            if (group.DeleteCourseToGroup(Gid, Cid))
            {
                MessageBox.Show("Course-group assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh data after deletion
                showTable();
            }
            else
            {
                MessageBox.Show("Failed to delete course-group assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AssignCoursesToGroupsForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void GtoC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showTable()
        {
            GtoC.DataSource = group.getGroup_Courselist();
        }

        private void GtoC_Click(object sender, EventArgs e)
        {
            // Assuming CourseName is in the fourth column and TName is in the first column
            string courseName = GtoC.CurrentRow.Cells[2].Value.ToString();
            string groupName = GtoC.CurrentRow.Cells[0].Value.ToString();

            // Set the selected item based on the value
            cmbCourse.SelectedValue = courseName;
            cmbGroup.SelectedValue = groupName;
        }
    }
}
