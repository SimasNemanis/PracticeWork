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
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace PracticeWork
{
    public partial class Course : Form
    {

        CourseClass course = new CourseClass();

        public Course()
        {
            InitializeComponent();
        }
         bool verify()
        {
            if ((txtcid.Text == "") || (txthour.Text == "") ||
                (txtcourse.Text == "") || (txtdescription.Text == ""))
            {
                return false;
            }
            else
                return true;

        }
        private void Courseadd_Click(object sender, EventArgs e)
        {
            if (txtcourse.Text == "" || txthour.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            int cid = Convert.ToInt32(txtcid.Text);
            string cName = txtcourse.Text;
            int hr = Convert.ToInt32(txthour.Text);
            string desc = txtdescription.Text;


            if (course.insertCourse(cid, cName, hr, desc))
            {
                Courseclear.PerformClick();
                showTable();
                MessageBox.Show("New course inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Course not inserted", "Add Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Course_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            CourseForm.DataSource = course.getCourselist();
        }

        private void Courseclear_Click_1(object sender, EventArgs e)
        {
            txtcid.Clear();
            txtcourse.Clear();
            txtdescription.Clear();
            txthour.Clear();
        }

        private void Coursedelete_Click(object sender, EventArgs e)
        {
            int cid = Convert.ToInt32(txtcid.Text);
            if (verify())
            {
                try
                {
                    if (course.deleteCourse(cid))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Course data deleted", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No course found with the specified ID", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error deleting course data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Empty Field", "Delete Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Courseupdate_Click(object sender, EventArgs e)
        {
            if (txtcourse.Text == "" || txthour.Text == "")
            {
                MessageBox.Show("Need Course data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int cid = Convert.ToInt32(txtcid.Text);
            string cName = txtcourse.Text;
            int hr = Convert.ToInt32(txthour.Text);
            string desc = txtdescription.Text;

                    if (course.updateCourse(cid, cName, hr, desc))
                    {
                        // Refresh the displayed data in your UI
                        showTable();

                        MessageBox.Show("Course data updated", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No course found with the specified ID", "Update Course", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
        }

        private void CourseForm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CourseForm_Click(object sender, EventArgs e)
        {
            txtcid.Text = CourseForm.CurrentRow.Cells[0].Value.ToString();
            txtcourse.Text = CourseForm.CurrentRow.Cells[1].Value.ToString();
            txthour.Text = CourseForm.CurrentRow.Cells[2].Value.ToString();
            txtdescription.Text = CourseForm.CurrentRow.Cells[3].Value.ToString();
        }
    }
}
