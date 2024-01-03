using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using static System.Net.Mime.MediaTypeNames;

namespace PracticeWork
{

    public partial class Score : Form
    {
        CourseClass course = new CourseClass();
        StudentClass student = new StudentClass();
        ScoreClass score = new ScoreClass();
        public Score()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        public void showScore()
        {
            DataGridScore.DataSource = score.getList(new MySqlCommand("SELECT * FROM `score`"));
        }
        private void Score_Load(object sender, EventArgs e)
        {
            cbcourse.DataSource = course.getCourselist();
            cbcourse.DisplayMember = "CourseName";
            cbcourse.ValueMember = "CourseName";

            DataGridStudent.DataSource = student.getList(new MySqlCommand("SELECT `StudentUserID`, `StdFirstName`, `StdLastName` FROM `studentuser`"));

            showScore();
        }

        private void stdadd_Click(object sender, EventArgs e)
        {
            if (txtstdid.Text == "" || txtscore.Text == "")
            {
                MessageBox.Show("Need score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int stid = Convert.ToInt32(txtstdid.Text);
            string crName = cbcourse.Text;
            double scor = Convert.ToInt32(txtscore.Text);
            string desc = txtdescription.Text;
            if (!score.checkScore(stid, crName))
            {


                if (score.insertScore(stid, crName, scor, desc))
                {
                    showScore();
                    btnclear.PerformClick();
                    MessageBox.Show("New Score added", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Score not added", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("The score for this course already exist", "Add Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void RegisterForm_Click(object sender, EventArgs e)
        {
            txtstdid.Text = DataGridStudent.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstdid.Clear();
            txtscore.Clear();
            cbcourse.SelectedIndex = 0;
            txtdescription.Clear();
        }
        public DataTable getList(MySqlCommand command)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        private void DataGridStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtstdid.Text = DataGridStudent.CurrentRow.Cells[0].Value.ToString();
        }

        private void ScoreExit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }

        private void ScoreExit_MouseEnter(object sender, EventArgs e)
        {
            ScoreExit.ForeColor = Color.Red;
        }

        private void ScoreExit_MouseLeave(object sender, EventArgs e)
        {
            ScoreExit.ForeColor = Color.Black;
        }
        bool verify()
        {
            if ((txtstdid.Text == "") || (txtscore.Text == ""))
            {
                return false;
            }
            else
                return true;

        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (txtstdid.Text == "" || txtscore.Text == "")
            {
                MessageBox.Show("Need score data", "Field Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            int stid = Convert.ToInt32(txtstdid.Text);
            string crName = cbcourse.Text;
            double scor = Convert.ToInt32(txtscore.Text);
            string desc = txtdescription.Text;

                if (score.updateScore(stid, crName, scor, desc))
                {
                    showScore();
                    btnclear.PerformClick();
                    MessageBox.Show("Score updated complete", "Update Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                else
                {
                    MessageBox.Show("Score not updated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
        }

        private void DataGridScore_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DataGridScore_Click(object sender, EventArgs e)
        {
            txtstdid.Text = DataGridScore.CurrentRow.Cells[0].Value.ToString();
            cbcourse.Text = DataGridScore.CurrentRow.Cells[1].Value.ToString();
            txtscore.Text = DataGridScore.CurrentRow.Cells[2].Value.ToString();
            txtdescription.Text = DataGridScore.CurrentRow.Cells[3].Value.ToString();
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (txtstdid.Text == "")
            {
                MessageBox.Show("Field Error - we need student id", "Delete Score", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            { 
                int stid = Convert.ToInt32(txtstdid.Text);
                string crName = cbcourse.Text;
                if (score.deleteScore(stid, crName))
                {
                    showScore();
                    MessageBox.Show("Score Removed", "Remove Score", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
            
}

