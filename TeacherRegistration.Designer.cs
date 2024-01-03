namespace PracticeWork
{
    partial class TeacherRegistration
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Tadd = new System.Windows.Forms.Button();
            this.Tclear = new System.Windows.Forms.Button();
            this.Tfemale = new System.Windows.Forms.RadioButton();
            this.Tmale = new System.Windows.Forms.RadioButton();
            this.TDOB = new System.Windows.Forms.DateTimePicker();
            this.txtTphone = new System.Windows.Forms.TextBox();
            this.txtTlname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTaddress = new System.Windows.Forms.TextBox();
            this.txtTpass = new System.Windows.Forms.TextBox();
            this.txtTid = new System.Windows.Forms.TextBox();
            this.txtTuser = new System.Windows.Forms.TextBox();
            this.txtTfname = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TRegisterForm = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRegisterForm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(12, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 17);
            this.panel3.TabIndex = 78;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 68);
            this.panel1.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(391, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Registration Of Teachers";
            // 
            // Tadd
            // 
            this.Tadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Tadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tadd.ForeColor = System.Drawing.SystemColors.Control;
            this.Tadd.Location = new System.Drawing.Point(885, 724);
            this.Tadd.Name = "Tadd";
            this.Tadd.Size = new System.Drawing.Size(140, 54);
            this.Tadd.TabIndex = 76;
            this.Tadd.Text = "Add";
            this.Tadd.UseVisualStyleBackColor = false;
            this.Tadd.Click += new System.EventHandler(this.Tadd_Click);
            // 
            // Tclear
            // 
            this.Tclear.BackColor = System.Drawing.Color.Orange;
            this.Tclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tclear.ForeColor = System.Drawing.SystemColors.Control;
            this.Tclear.Location = new System.Drawing.Point(739, 724);
            this.Tclear.Name = "Tclear";
            this.Tclear.Size = new System.Drawing.Size(140, 54);
            this.Tclear.TabIndex = 75;
            this.Tclear.Text = "Clear";
            this.Tclear.UseVisualStyleBackColor = false;
            this.Tclear.Click += new System.EventHandler(this.Tclear_Click);
            // 
            // Tfemale
            // 
            this.Tfemale.AutoSize = true;
            this.Tfemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tfemale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Tfemale.Location = new System.Drawing.Point(781, 546);
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
            this.Tmale.Location = new System.Drawing.Point(680, 548);
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
            this.TDOB.Location = new System.Drawing.Point(222, 550);
            this.TDOB.Name = "TDOB";
            this.TDOB.Size = new System.Drawing.Size(269, 35);
            this.TDOB.TabIndex = 72;
            // 
            // txtTphone
            // 
            this.txtTphone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTphone.Location = new System.Drawing.Point(828, 480);
            this.txtTphone.Name = "txtTphone";
            this.txtTphone.Size = new System.Drawing.Size(197, 35);
            this.txtTphone.TabIndex = 65;
            // 
            // txtTlname
            // 
            this.txtTlname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTlname.Location = new System.Drawing.Point(532, 479);
            this.txtTlname.Name = "txtTlname";
            this.txtTlname.Size = new System.Drawing.Size(172, 35);
            this.txtTlname.TabIndex = 71;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label6.Location = new System.Drawing.Point(710, 485);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 29);
            this.label6.TabIndex = 63;
            this.label6.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(567, 550);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 29);
            this.label4.TabIndex = 62;
            this.label4.Text = "Gender:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(382, 485);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 29);
            this.label2.TabIndex = 64;
            this.label2.Text = "Last Name:";
            // 
            // txtTaddress
            // 
            this.txtTaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaddress.Location = new System.Drawing.Point(162, 611);
            this.txtTaddress.Name = "txtTaddress";
            this.txtTaddress.Size = new System.Drawing.Size(863, 35);
            this.txtTaddress.TabIndex = 66;
            // 
            // txtTpass
            // 
            this.txtTpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTpass.Location = new System.Drawing.Point(800, 669);
            this.txtTpass.Name = "txtTpass";
            this.txtTpass.Size = new System.Drawing.Size(225, 35);
            this.txtTpass.TabIndex = 67;
            // 
            // txtTid
            // 
            this.txtTid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTid.Location = new System.Drawing.Point(107, 673);
            this.txtTid.Name = "txtTid";
            this.txtTid.Size = new System.Drawing.Size(138, 35);
            this.txtTid.TabIndex = 68;
            // 
            // txtTuser
            // 
            this.txtTuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTuser.Location = new System.Drawing.Point(419, 673);
            this.txtTuser.Name = "txtTuser";
            this.txtTuser.Size = new System.Drawing.Size(212, 35);
            this.txtTuser.TabIndex = 69;
            // 
            // txtTfname
            // 
            this.txtTfname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTfname.Location = new System.Drawing.Point(209, 479);
            this.txtTfname.Name = "txtTfname";
            this.txtTfname.Size = new System.Drawing.Size(167, 35);
            this.txtTfname.TabIndex = 70;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(659, 673);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "Password:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label5.Location = new System.Drawing.Point(47, 614);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 29);
            this.label5.TabIndex = 59;
            this.label5.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(47, 679);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 29);
            this.label10.TabIndex = 58;
            this.label10.Text = "ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(274, 679);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 29);
            this.label8.TabIndex = 57;
            this.label8.Text = "Username:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(47, 555);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 29);
            this.label3.TabIndex = 56;
            this.label3.Text = "Date Of Birth:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(47, 486);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 29);
            this.label1.TabIndex = 61;
            this.label1.Text = "First Name:";
            // 
            // TRegisterForm
            // 
            this.TRegisterForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TRegisterForm.Location = new System.Drawing.Point(12, 86);
            this.TRegisterForm.Name = "TRegisterForm";
            this.TRegisterForm.RowHeadersWidth = 62;
            this.TRegisterForm.RowTemplate.Height = 28;
            this.TRegisterForm.Size = new System.Drawing.Size(1013, 348);
            this.TRegisterForm.TabIndex = 55;
            // 
            // TeacherRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 794);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Tadd);
            this.Controls.Add(this.Tclear);
            this.Controls.Add(this.Tfemale);
            this.Controls.Add(this.Tmale);
            this.Controls.Add(this.TDOB);
            this.Controls.Add(this.txtTphone);
            this.Controls.Add(this.txtTlname);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTaddress);
            this.Controls.Add(this.txtTpass);
            this.Controls.Add(this.txtTid);
            this.Controls.Add(this.txtTuser);
            this.Controls.Add(this.txtTfname);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TRegisterForm);
            this.Name = "TeacherRegistration";
            this.Text = "TeacherRegistration";
            this.Load += new System.EventHandler(this.TeacherRegistration_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TRegisterForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Tadd;
        private System.Windows.Forms.Button Tclear;
        private System.Windows.Forms.RadioButton Tfemale;
        private System.Windows.Forms.RadioButton Tmale;
        private System.Windows.Forms.DateTimePicker TDOB;
        private System.Windows.Forms.TextBox txtTphone;
        private System.Windows.Forms.TextBox txtTlname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTaddress;
        private System.Windows.Forms.TextBox txtTpass;
        private System.Windows.Forms.TextBox txtTid;
        private System.Windows.Forms.TextBox txtTuser;
        private System.Windows.Forms.TextBox txtTfname;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView TRegisterForm;
    }
}