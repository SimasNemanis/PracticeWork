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
    public partial class AssignTeachersToCoursesForm : Form
    {
        TeacherClass teacher = new TeacherClass();
        CourseClass course = new CourseClass();
        public AssignTeachersToCoursesForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            // Load lecturers into a ComboBox
            cmbTeacher.DataSource = teacher.getTeacherlist();
            cmbTeacher.DisplayMember = "TName";
            cmbTeacher.ValueMember = "TeacherUserID";

            // Load subjects into a ComboBox
            cmbCourse.DataSource = course.getCourselist();
            cmbCourse.DisplayMember = "CourseName";
            cmbCourse.ValueMember = "CourseID";
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            int Tid = Convert.ToInt32(cmbTeacher.SelectedValue);
            int courseID = Convert.ToInt32(cmbCourse.SelectedValue);

            // Perform the assignment
            if (teacher.AssignTeacherToCourse(Tid, courseID))
            {
                MessageBox.Show("Teacher assigned to course successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh data after assignment
                showTable();
            }
            else
            {
                MessageBox.Show("Failed to assign teacher to course.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            int Tid = Convert.ToInt32(cmbTeacher.SelectedValue);
            int courseID = Convert.ToInt32(cmbCourse.SelectedValue);

            // Perform the deletion
            if (teacher.DeleteTeacherToCourse(Tid, courseID))
            {
                MessageBox.Show("Teacher-course assignment deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData(); // Refresh data after deletion
                showTable();
            }
            else
            {
                MessageBox.Show("Failed to delete teacher-course assignment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private void TtoC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AssignTeachersToCoursesForm_Load(object sender, EventArgs e)
        {
            showTable();
        }
        public void showTable()
        {
            TtoC.DataSource = teacher.getTeacher_Courselist();
        }

        private void TtoC_Click(object sender, EventArgs e)
        {
            // Assuming CourseName is in the fourth column and TName is in the first column
            string courseName = TtoC.CurrentRow.Cells[3].Value.ToString();
            string teacherName = TtoC.CurrentRow.Cells[0].Value.ToString();

            // Set the selected item based on the value
            cmbCourse.SelectedValue = courseName;
            cmbTeacher.SelectedValue = teacherName;

        }
    }
}
