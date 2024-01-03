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
    public partial class EnrollStudentsInCoursesForm : Form
    {
        StudentClass student = new StudentClass();
        CourseClass course = new CourseClass();
        public EnrollStudentsInCoursesForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            // Load students into a ComboBox
            cmbStudent.DataSource = student.getStudentlist();
            cmbStudent.DisplayMember = "StdFirstName";
            cmbStudent.ValueMember = "StudentUserID";

            // Load subjects into a ComboBox
            cmbCourse.DataSource = course.getCourselist();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int stid = Convert.ToInt32(cmbStudent.SelectedValue);
            int Cid = Convert.ToInt32(cmbCourse.SelectedValue);

            // Perform the enrollment
            if (student.EnrollStudentInCourse(stid, Cid))
            {
                MessageBox.Show("Student enrolled in course successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh data after enrollment
                showTable();
            }
            else
            {
                MessageBox.Show("Failed to enroll student in course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int stid = Convert.ToInt32(cmbStudent.SelectedValue);
            int Cid = Convert.ToInt32(cmbCourse.SelectedValue);

            // Perform the deletion
            if (student.DeleteStudentInCourse(stid, Cid))
            {
                MessageBox.Show("Student-course enrollment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh data after deletion
                showTable();
            }
            else
            {
                MessageBox.Show("Failed to delete Student-course enrollment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EnrollStudentsInCoursesForm_Load(object sender, EventArgs e)
        {
            showTable();
        }

        private void StoC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void showTable()
        {
            StoC.DataSource = student.getStudent_Courselist();
        }

        private void StoC_Click(object sender, EventArgs e)
        {
            // Assuming CourseName is in the fourth column and TName is in the first column
            string courseName = StoC.CurrentRow.Cells[3].Value.ToString();
            string studentName = StoC.CurrentRow.Cells[0].Value.ToString();

            // Set the selected item based on the value
            cmbCourse.SelectedValue = courseName;
            cmbStudent.SelectedValue = studentName;
        }
    }
}
