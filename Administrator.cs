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
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }

        private void Administrator_Load(object sender, EventArgs e)
        {
            customizeDesign();
        }
        private void customizeDesign()
        { 
            stdsubmenu.Visible = false;
            Tsubmenu.Visible = false;
            Adsubmenu.Visible = false;
            Csubmenu.Visible = false;
            Gsubmenu.Visible = false;
        }
        private void hideSubmenu() 
        {
            if(stdsubmenu.Visible == true)
               stdsubmenu.Visible = false;
            if (Tsubmenu.Visible == true)
                Tsubmenu.Visible = false;
            if (Adsubmenu.Visible == true)
                Adsubmenu.Visible = false;
            if (Csubmenu.Visible == true)
                Csubmenu.Visible = false;
            if (Gsubmenu.Visible == true)
                Gsubmenu.Visible = false;
        }
        private void showSubmenu(Panel submenu)
        { 
            if (submenu.Visible == false) 
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;
        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            showSubmenu(stdsubmenu);
        }

        private void btnSReg_Click(object sender, EventArgs e)
        {
            openChildForm(new RegistrationStudent());

            hideSubmenu();
        }

        private void btnSMng_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageStudent());

            hideSubmenu();
        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            showSubmenu(Tsubmenu);
        }

        private void btnTReg_Click(object sender, EventArgs e)
        {
            openChildForm(new TeacherRegistration());

            hideSubmenu();
        }

        private void btnTMng_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageTeacher());

            hideSubmenu();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            showSubmenu(Adsubmenu);
        }

        private void btnAdReg_Click(object sender, EventArgs e)
        {
            openChildForm(new AdministratorRegistration());

            hideSubmenu();
        }

        private void btnAdMng_Click(object sender, EventArgs e)
        {
            openChildForm(new ManageAdministrator());

            hideSubmenu();
        }

        private void btnCourse_Click(object sender, EventArgs e)
        {
            showSubmenu(Csubmenu);
        }

        private void btnCReg_Click(object sender, EventArgs e)
        {
            openChildForm(new Course());

            hideSubmenu();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            openChildForm(new AssignTeachersToCoursesForm());

            hideSubmenu();
        }

        private void btnEnroll_Click(object sender, EventArgs e)
        {
            openChildForm(new EnrollStudentsInCoursesForm());

            hideSubmenu();
        }

        private void btnGroup_Click(object sender, EventArgs e)
        {
            showSubmenu(Gsubmenu);
        }

        private void btnGReg_Click(object sender, EventArgs e)
        {
            openChildForm(new GroupForm());

            hideSubmenu();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            openChildForm(new AssignCoursesToGroupsForm());

            hideSubmenu();
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        { 
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_main.Controls.Add(childForm);
            panel_main.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            LoginForm login = new LoginForm();
            this.Hide();
            login.Show();
        }
    }
}
