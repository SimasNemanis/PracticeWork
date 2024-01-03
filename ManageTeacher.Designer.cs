namespace PracticeWork
{
    partial class ManageTeacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Tdelete = new System.Windows.Forms.Button();
            this.Tclear = new System.Windows.Forms.Button();
            this.Tupdate = new System.Windows.Forms.Button();
            this.Tfemale = new System.Windows.Forms.RadioButton();
            this.Tmale = new System.Windows.Forms.RadioButton();
            this.TDOB = new System.Windows.Forms.DateTimePicker();
            this.txtTphone = new System.Windows.Forms.TextBox();
            this.txtTlname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTaddress = new System.Windows.Forms.TextBox();
            this.txtTpass = new System.Windows.Forms.TextBox();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.txtTuser = new System.Windows.Forms.TextBox();
            this.txtTfname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TRegisterForm = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRegisterForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(6, 434);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 17);
            this.panel3.TabIndex = 80;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 68);
            this.panel2.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(356, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(314, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Management Of Teachers";
            // 
            // Tdelete
            // 
            this.Tdelete.BackColor = System.Drawing.Color.Red;
            this.Tdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tdelete.ForeColor = System.Drawing.SystemColors.Control;
            this.Tdelete.Location = new System.Drawing.Point(893, 728);
            this.Tdelete.Name = "Tdelete";
            this.Tdelete.Size = new System.Drawing.Size(140, 54);
            this.Tdelete.TabIndex = 78;
            this.Tdelete.Text = "Delete";
            this.Tdelete.UseVisualStyleBackColor = false;
            this.Tdelete.Click += new System.EventHandler(this.Tdelete_Click);
            // 
            // Tclear
            // 
            this.Tclear.BackColor = System.Drawing.Color.Orange;
            this.Tclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tclear.ForeColor = System.Drawing.SystemColors.Control;
            this.Tclear.Location = new System.Drawing.Point(601, 728);
            this.Tclear.Name = "Tclear";
            this.Tclear.Size = new System.Drawing.Size(140, 54);
            this.Tclear.TabIndex = 76;
            this.Tclear.Text = "Clear";
            this.Tclear.UseVisualStyleBackColor = false;
            this.Tclear.Click += new System.EventHandler(this.Tclear_Click);
            // 
            // Tupdate
            // 
            this.Tupdate.BackColor = System.Drawing.Color.OrangeRed;
            this.Tupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.Tupdate.Location = new System.Drawing.Point(747, 728);
            this.Tupdate.Name = "Tupdate";
            this.Tupdate.Size = new System.Drawing.Size(140, 54);
            this.Tupdate.TabIndex = 75;
            this.Tupdate.Text = "Update";
            this.Tupdate.UseVisualStyleBackColor = false;
            this.Tupdate.Click += new System.EventHandler(this.Tupdate_Click);
            // 
            // Tfemale
            // 
            this.Tfemale.AutoSize = true;
            this.Tfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tfemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Tfemale.Location = new System.Drawing.Point(775, 540);
            this.Tfemale.Name = "Tfemale";
            this.Tfemale.Size = new System.Drawing.Size(126, 33);
            this.Tfemale.TabIndex = 74;
            this.Tfemale.Text = "Female";
            this.Tfemale.UseVisualStyleBackColor = true;
            // 
            // Tmale
            // 
            this.Tmale.AutoSize = true;
            this.Tmale.Checked = true;
            this.Tmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tmale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Tmale.Location = new System.Drawing.Point(674, 542);
            this.Tmale.Name = "Tmale";
            this.Tmale.Size = new System.Drawing.Size(95, 33);
            this.Tmale.TabIndex = 73;
            this.Tmale.TabStop = true;
            this.Tmale.Text = "Male";
            this.Tmale.UseVisualStyleBackColor = true;
            // 
            // TDOB
            // 
            this.TDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TDOB.Location = new System.Drawing.Point(216, 544);
            this.TDOB.Name = "TDOB";
            this.TDOB.Size = new System.Drawing.Size(269, 35);
            this.TDOB.TabIndex = 72;
            // 
            // txtTphone
            // 
            this.txtTphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTphone.Location = new System.Drawing.Point(822, 474);
            this.txtTphone.Name = "txtTphone";
            this.txtTphone.Size = new System.Drawing.Size(197, 35);
            this.txtTphone.TabIndex = 70;
            // 
            // txtTlname
            // 
            this.txtTlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTlname.Location = new System.Drawing.Point(526, 473);
            this.txtTlname.Name = "txtTlname";
            this.txtTlname.Size = new System.Drawing.Size(172, 35);
            this.txtTlname.TabIndex = 69;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(704, 479);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 60;
            this.label6.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(561, 544);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 61;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(376, 479);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 62;
            this.label3.Text = "Last Name:";
            // 
            // txtTaddress
            // 
            this.txtTaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaddress.Location = new System.Drawing.Point(169, 605);
            this.txtTaddress.Name = "txtTaddress";
            this.txtTaddress.Size = new System.Drawing.Size(850, 35);
            this.txtTaddress.TabIndex = 68;
            // 
            // txtTpass
            // 
            this.txtTpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTpass.Location = new System.Drawing.Point(775, 672);
            this.txtTpass.Name = "txtTpass";
            this.txtTpass.Size = new System.Drawing.Size(224, 35);
            this.txtTpass.TabIndex = 71;
            // 
            // txtTid
            // 
            this.txtTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTid.Location = new System.Drawing.Point(101, 670);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(109, 35);
            this.txtTid.TabIndex = 67;
            // 
            // txtTuser
            // 
            this.txtTuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuser.Location = new System.Drawing.Point(389, 668);
            this.txtTuser.Name = "txtTuser";
            this.txtTuser.Size = new System.Drawing.Size(215, 35);
            this.txtTuser.TabIndex = 66;
            // 
            // txtTfname
            // 
            this.txtTfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTfname.Location = new System.Drawing.Point(203, 473);
            this.txtTfname.Name = "txtTfname";
            this.txtTfname.Size = new System.Drawing.Size(167, 35);
            this.txtTfname.TabIndex = 64;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(621, 675);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 59;
            this.label9.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(41, 611);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 58;
            this.label5.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(41, 672);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 29);
            this.label8.TabIndex = 57;
            this.label8.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(231, 672);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 29);
            this.label11.TabIndex = 56;
            this.label11.Text = "Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(41, 549);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 29);
            this.label12.TabIndex = 55;
            this.label12.Text = "Date Of Birth:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label13.Location = new System.Drawing.Point(41, 480);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 29);
            this.label13.TabIndex = 63;
            this.label13.Text = "First Name:";
            // 
            // TRegisterForm
            // 
            this.TRegisterForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TRegisterForm.Location = new System.Drawing.Point(6, 80);
            this.TRegisterForm.Name = "TRegisterForm";
            this.TRegisterForm.RowHeadersWidth = 62;
            this.TRegisterForm.RowTemplate.Height = 28;
            this.TRegisterForm.Size = new System.Drawing.Size(1013, 348);
            this.TRegisterForm.TabIndex = 54;
            this.TRegisterForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TRegisterForm_CellContentClick);
            this.TRegisterForm.Click += new System.EventHandler(this.TRegisterForm_Click);
            // 
            // ManageTeacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 789);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.Tdelete);
            this.Controls.Add(this.Tclear);
            this.Controls.Add(this.Tupdate);
            this.Controls.Add(this.Tfemale);
            this.Controls.Add(this.Tmale);
            this.Controls.Add(this.TDOB);
            this.Controls.Add(this.txtTphone);
            this.Controls.Add(this.txtTlname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTaddress);
            this.Controls.Add(this.txtTpass);
            this.Controls.Add(this.txtTid);
            this.Controls.Add(this.txtTuser);
            this.Controls.Add(this.txtTfname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.TRegisterForm);
            this.Name = "ManageTeacher";
            this.Text = "TManageTeacher";
            this.Load += new System.EventHandler(this.ManageTeacher_Load);
            this.Click += new System.EventHandler(this.ManageTeacher_Click);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRegisterForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Tdelete;
        private System.Windows.Forms.Button Tclear;
        private System.Windows.Forms.Button Tupdate;
        private System.Windows.Forms.RadioButton Tfemale;
        private System.Windows.Forms.RadioButton Tmale;
        private System.Windows.Forms.DateTimePicker TDOB;
        private System.Windows.Forms.TextBox txtTphone;
        private System.Windows.Forms.TextBox txtTlname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTaddress;
        private System.Windows.Forms.TextBox txtTpass;
        private System.Windows.Forms.TextBox txtTid;
        private System.Windows.Forms.TextBox txtTuser;
        private System.Windows.Forms.TextBox txtTfname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView TRegisterForm;
    }
}