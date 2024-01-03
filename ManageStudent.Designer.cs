namespace PracticeWork
{
    partial class ManageStudent
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.stdExit = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.stddelete = new System.Windows.Forms.Button();
            this.stdupdate = new System.Windows.Forms.Button();
            this.stdfemale = new System.Windows.Forms.RadioButton();
            this.stdmale = new System.Windows.Forms.RadioButton();
            this.stdDOB = new System.Windows.Forms.DateTimePicker();
            this.txtstdphone = new System.Windows.Forms.TextBox();
            this.txtstdlname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtstdaddress = new System.Windows.Forms.TextBox();
            this.txtstdpass = new System.Windows.Forms.TextBox();
            this.txtstdid = new System.Windows.Forms.TextBox();
            this.txtstduser = new System.Windows.Forms.TextBox();
            this.txtstdfname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.RegisterForm = new System.Windows.Forms.DataGridView();
            this.stdclear = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.stdExit);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(-104, -129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1009, 68);
            this.panel1.TabIndex = 29;
            // 
            // stdExit
            // 
            this.stdExit.AutoSize = true;
            this.stdExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdExit.Location = new System.Drawing.Point(962, 25);
            this.stdExit.Name = "stdExit";
            this.stdExit.Size = new System.Drawing.Size(31, 29);
            this.stdExit.TabIndex = 5;
            this.stdExit.Text = "X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(391, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(297, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Registration Of Students";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(-73, 472);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "ID:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(8, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1013, 68);
            this.panel2.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(356, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(306, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Management Of Students";
            // 
            // stddelete
            // 
            this.stddelete.BackColor = System.Drawing.Color.Red;
            this.stddelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stddelete.ForeColor = System.Drawing.SystemColors.Control;
            this.stddelete.Location = new System.Drawing.Point(895, 734);
            this.stddelete.Name = "stddelete";
            this.stddelete.Size = new System.Drawing.Size(140, 54);
            this.stddelete.TabIndex = 51;
            this.stddelete.Text = "Delete";
            this.stddelete.UseVisualStyleBackColor = false;
            this.stddelete.Click += new System.EventHandler(this.stddelete_Click);
            // 
            // stdupdate
            // 
            this.stdupdate.BackColor = System.Drawing.Color.OrangeRed;
            this.stdupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.stdupdate.Location = new System.Drawing.Point(749, 734);
            this.stdupdate.Name = "stdupdate";
            this.stdupdate.Size = new System.Drawing.Size(140, 54);
            this.stdupdate.TabIndex = 50;
            this.stdupdate.Text = "Update";
            this.stdupdate.UseVisualStyleBackColor = false;
            this.stdupdate.Click += new System.EventHandler(this.stdupdate_Click);
            // 
            // stdfemale
            // 
            this.stdfemale.AutoSize = true;
            this.stdfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdfemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.stdfemale.Location = new System.Drawing.Point(777, 546);
            this.stdfemale.Name = "stdfemale";
            this.stdfemale.Size = new System.Drawing.Size(126, 33);
            this.stdfemale.TabIndex = 49;
            this.stdfemale.Text = "Female";
            this.stdfemale.UseVisualStyleBackColor = true;
            // 
            // stdmale
            // 
            this.stdmale.AutoSize = true;
            this.stdmale.Checked = true;
            this.stdmale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdmale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.stdmale.Location = new System.Drawing.Point(676, 548);
            this.stdmale.Name = "stdmale";
            this.stdmale.Size = new System.Drawing.Size(95, 33);
            this.stdmale.TabIndex = 48;
            this.stdmale.TabStop = true;
            this.stdmale.Text = "Male";
            this.stdmale.UseVisualStyleBackColor = true;
            // 
            // stdDOB
            // 
            this.stdDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdDOB.Location = new System.Drawing.Point(218, 550);
            this.stdDOB.Name = "stdDOB";
            this.stdDOB.Size = new System.Drawing.Size(269, 35);
            this.stdDOB.TabIndex = 47;
            // 
            // txtstdphone
            // 
            this.txtstdphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdphone.Location = new System.Drawing.Point(824, 480);
            this.txtstdphone.Name = "txtstdphone";
            this.txtstdphone.Size = new System.Drawing.Size(197, 35);
            this.txtstdphone.TabIndex = 45;
            // 
            // txtstdlname
            // 
            this.txtstdlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdlname.Location = new System.Drawing.Point(528, 479);
            this.txtstdlname.Name = "txtstdlname";
            this.txtstdlname.Size = new System.Drawing.Size(172, 35);
            this.txtstdlname.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(706, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 36;
            this.label6.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(563, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 37;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(378, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 29);
            this.label3.TabIndex = 38;
            this.label3.Text = "Last Name:";
            // 
            // txtstdaddress
            // 
            this.txtstdaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdaddress.Location = new System.Drawing.Point(171, 611);
            this.txtstdaddress.Name = "txtstdaddress";
            this.txtstdaddress.Size = new System.Drawing.Size(850, 35);
            this.txtstdaddress.TabIndex = 43;
            // 
            // txtstdpass
            // 
            this.txtstdpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdpass.Location = new System.Drawing.Point(777, 678);
            this.txtstdpass.Name = "txtstdpass";
            this.txtstdpass.Size = new System.Drawing.Size(224, 35);
            this.txtstdpass.TabIndex = 46;
            // 
            // txtstdid
            // 
            this.txtstdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdid.Location = new System.Drawing.Point(103, 676);
            this.txtstdid.Name = "txtstdid";
            this.txtstdid.Size = new System.Drawing.Size(109, 35);
            this.txtstdid.TabIndex = 42;
            // 
            // txtstduser
            // 
            this.txtstduser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstduser.Location = new System.Drawing.Point(391, 674);
            this.txtstduser.Name = "txtstduser";
            this.txtstduser.Size = new System.Drawing.Size(215, 35);
            this.txtstduser.TabIndex = 41;
            // 
            // txtstdfname
            // 
            this.txtstdfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdfname.Location = new System.Drawing.Point(205, 479);
            this.txtstdfname.Name = "txtstdfname";
            this.txtstdfname.Size = new System.Drawing.Size(167, 35);
            this.txtstdfname.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(623, 681);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 35;
            this.label9.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(43, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 34;
            this.label5.Text = "Address:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(43, 678);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 29);
            this.label8.TabIndex = 33;
            this.label8.Text = "ID:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label11.Location = new System.Drawing.Point(233, 678);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(139, 29);
            this.label11.TabIndex = 32;
            this.label11.Text = "Username:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label12.Location = new System.Drawing.Point(43, 555);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 29);
            this.label12.TabIndex = 31;
            this.label12.Text = "Date Of Birth:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label13.Location = new System.Drawing.Point(43, 486);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 29);
            this.label13.TabIndex = 39;
            this.label13.Text = "First Name:";
            // 
            // RegisterForm
            // 
            this.RegisterForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RegisterForm.Location = new System.Drawing.Point(8, 86);
            this.RegisterForm.Name = "RegisterForm";
            this.RegisterForm.RowHeadersWidth = 62;
            this.RegisterForm.RowTemplate.Height = 28;
            this.RegisterForm.Size = new System.Drawing.Size(1013, 348);
            this.RegisterForm.TabIndex = 30;
            this.RegisterForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RegisterForm_CellContentClick);
            this.RegisterForm.Click += new System.EventHandler(this.RegisterForm_Click);
            // 
            // stdclear
            // 
            this.stdclear.BackColor = System.Drawing.Color.Orange;
            this.stdclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stdclear.ForeColor = System.Drawing.SystemColors.Control;
            this.stdclear.Location = new System.Drawing.Point(603, 734);
            this.stdclear.Name = "stdclear";
            this.stdclear.Size = new System.Drawing.Size(140, 54);
            this.stdclear.TabIndex = 50;
            this.stdclear.Text = "Clear";
            this.stdclear.UseVisualStyleBackColor = false;
            this.stdclear.Click += new System.EventHandler(this.stdclear_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(8, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 17);
            this.panel3.TabIndex = 53;
            // 
            // ManageStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 800);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.stddelete);
            this.Controls.Add(this.stdclear);
            this.Controls.Add(this.stdupdate);
            this.Controls.Add(this.stdfemale);
            this.Controls.Add(this.stdmale);
            this.Controls.Add(this.stdDOB);
            this.Controls.Add(this.txtstdphone);
            this.Controls.Add(this.txtstdlname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtstdaddress);
            this.Controls.Add(this.txtstdpass);
            this.Controls.Add(this.txtstdid);
            this.Controls.Add(this.txtstduser);
            this.Controls.Add(this.txtstdfname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.RegisterForm);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label10);
            this.Name = "ManageStudent";
            this.Text = "ManageStudent";
            this.Load += new System.EventHandler(this.ManageStudent_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RegisterForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label stdExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button stddelete;
        private System.Windows.Forms.Button stdupdate;
        private System.Windows.Forms.RadioButton stdfemale;
        private System.Windows.Forms.RadioButton stdmale;
        private System.Windows.Forms.DateTimePicker stdDOB;
        private System.Windows.Forms.TextBox txtstdphone;
        private System.Windows.Forms.TextBox txtstdlname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtstdaddress;
        private System.Windows.Forms.TextBox txtstdpass;
        private System.Windows.Forms.TextBox txtstdid;
        private System.Windows.Forms.TextBox txtstduser;
        private System.Windows.Forms.TextBox txtstdfname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView RegisterForm;
        private System.Windows.Forms.Button stdclear;
        private System.Windows.Forms.Panel panel3;
    }
}