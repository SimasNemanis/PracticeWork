namespace PracticeWork
{
    partial class Course
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
            this.Courseadd = new System.Windows.Forms.Button();
            this.Courseclear = new System.Windows.Forms.Button();
            this.CourseForm = new System.Windows.Forms.DataGridView();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcourse = new System.Windows.Forms.TextBox();
            this.txthour = new System.Windows.Forms.TextBox();
            this.Courseupdate = new System.Windows.Forms.Button();
            this.Coursedelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcid = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseForm)).BeginInit();
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
            this.label7.Size = new System.Drawing.Size(157, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Course";
            // 
            // Courseadd
            // 
            this.Courseadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Courseadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseadd.ForeColor = System.Drawing.SystemColors.Control;
            this.Courseadd.Location = new System.Drawing.Point(885, 724);
            this.Courseadd.Name = "Courseadd";
            this.Courseadd.Size = new System.Drawing.Size(140, 54);
            this.Courseadd.TabIndex = 76;
            this.Courseadd.Text = "Add";
            this.Courseadd.UseVisualStyleBackColor = false;
            this.Courseadd.Click += new System.EventHandler(this.Courseadd_Click);
            // 
            // Courseclear
            // 
            this.Courseclear.BackColor = System.Drawing.Color.Orange;
            this.Courseclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseclear.ForeColor = System.Drawing.SystemColors.Control;
            this.Courseclear.Location = new System.Drawing.Point(593, 724);
            this.Courseclear.Name = "Courseclear";
            this.Courseclear.Size = new System.Drawing.Size(140, 54);
            this.Courseclear.TabIndex = 75;
            this.Courseclear.Text = "Clear";
            this.Courseclear.UseVisualStyleBackColor = false;
            this.Courseclear.Click += new System.EventHandler(this.Courseclear_Click_1);
            // 
            // CourseForm
            // 
            this.CourseForm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CourseForm.Location = new System.Drawing.Point(12, 86);
            this.CourseForm.Name = "CourseForm";
            this.CourseForm.RowHeadersWidth = 62;
            this.CourseForm.RowTemplate.Height = 28;
            this.CourseForm.Size = new System.Drawing.Size(1013, 348);
            this.CourseForm.TabIndex = 55;
            this.CourseForm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CourseForm_CellContentClick);
            this.CourseForm.Click += new System.EventHandler(this.CourseForm_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(188, 665);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(848, 35);
            this.txtdescription.TabIndex = 81;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(29, 665);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 79;
            this.label1.Text = "Description:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label2.Location = new System.Drawing.Point(2, 560);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 29);
            this.label2.TabIndex = 80;
            this.label2.Text = "Course Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label3.Location = new System.Drawing.Point(106, 613);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 29);
            this.label3.TabIndex = 79;
            this.label3.Text = "Hour:";
            // 
            // txtcourse
            // 
            this.txtcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcourse.Location = new System.Drawing.Point(188, 557);
            this.txtcourse.Name = "txtcourse";
            this.txtcourse.Size = new System.Drawing.Size(225, 35);
            this.txtcourse.TabIndex = 82;
            // 
            // txthour
            // 
            this.txthour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txthour.Location = new System.Drawing.Point(188, 610);
            this.txthour.Name = "txthour";
            this.txthour.Size = new System.Drawing.Size(229, 35);
            this.txthour.TabIndex = 81;
            // 
            // Courseupdate
            // 
            this.Courseupdate.BackColor = System.Drawing.Color.OrangeRed;
            this.Courseupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Courseupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.Courseupdate.Location = new System.Drawing.Point(739, 724);
            this.Courseupdate.Name = "Courseupdate";
            this.Courseupdate.Size = new System.Drawing.Size(140, 54);
            this.Courseupdate.TabIndex = 75;
            this.Courseupdate.Text = "Update";
            this.Courseupdate.UseVisualStyleBackColor = false;
            this.Courseupdate.Click += new System.EventHandler(this.Courseupdate_Click);
            // 
            // Coursedelete
            // 
            this.Coursedelete.BackColor = System.Drawing.Color.Red;
            this.Coursedelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Coursedelete.ForeColor = System.Drawing.SystemColors.Control;
            this.Coursedelete.Location = new System.Drawing.Point(447, 724);
            this.Coursedelete.Name = "Coursedelete";
            this.Coursedelete.Size = new System.Drawing.Size(140, 54);
            this.Coursedelete.TabIndex = 76;
            this.Coursedelete.Text = "Delete";
            this.Coursedelete.UseVisualStyleBackColor = false;
            this.Coursedelete.Click += new System.EventHandler(this.Coursedelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(46, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 29);
            this.label4.TabIndex = 80;
            this.label4.Text = "Course ID:";
            // 
            // txtcid
            // 
            this.txtcid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcid.Location = new System.Drawing.Point(188, 506);
            this.txtcid.Name = "txtcid";
            this.txtcid.Size = new System.Drawing.Size(225, 35);
            this.txtcid.TabIndex = 82;
            // 
            // Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 783);
            this.Controls.Add(this.txthour);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtcid);
            this.Controls.Add(this.txtcourse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Coursedelete);
            this.Controls.Add(this.Courseadd);
            this.Controls.Add(this.Courseupdate);
            this.Controls.Add(this.Courseclear);
            this.Controls.Add(this.CourseForm);
            this.Name = "Course";
            this.Text = "Course";
            this.Load += new System.EventHandler(this.Course_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CourseForm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Courseadd;
        private System.Windows.Forms.Button Courseclear;
        private System.Windows.Forms.DataGridView CourseForm;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcourse;
        private System.Windows.Forms.TextBox txthour;
        private System.Windows.Forms.Button Courseupdate;
        private System.Windows.Forms.Button Coursedelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcid;
    }
}