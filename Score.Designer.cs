namespace PracticeWork
{
    partial class Score
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
            this.ScoreExit = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.txtscore = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DataGridStudent = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdescription = new System.Windows.Forms.TextBox();
            this.cbcourse = new System.Windows.Forms.ComboBox();
            this.DataGridScore = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnupdate = new System.Windows.Forms.Button();
            this.txtstdid = new System.Windows.Forms.TextBox();
            this.btndelete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridScore)).BeginInit();
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
            this.panel1.Controls.Add(this.ScoreExit);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 68);
            this.panel1.TabIndex = 77;
            // 
            // ScoreExit
            // 
            this.ScoreExit.AutoSize = true;
            this.ScoreExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreExit.Location = new System.Drawing.Point(962, 25);
            this.ScoreExit.Name = "ScoreExit";
            this.ScoreExit.Size = new System.Drawing.Size(31, 29);
            this.ScoreExit.TabIndex = 5;
            this.ScoreExit.Text = "X";
            this.ScoreExit.Click += new System.EventHandler(this.ScoreExit_Click);
            this.ScoreExit.MouseEnter += new System.EventHandler(this.ScoreExit_MouseEnter);
            this.ScoreExit.MouseLeave += new System.EventHandler(this.ScoreExit_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(183, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student List";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(697, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Add Score";
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.Control;
            this.btnadd.Location = new System.Drawing.Point(885, 724);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(140, 54);
            this.btnadd.TabIndex = 76;
            this.btnadd.Text = "Add";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.stdadd_Click);
            // 
            // btnclear
            // 
            this.btnclear.BackColor = System.Drawing.Color.Orange;
            this.btnclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnclear.Location = new System.Drawing.Point(739, 724);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(140, 54);
            this.btnclear.TabIndex = 75;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = false;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // txtscore
            // 
            this.txtscore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtscore.Location = new System.Drawing.Point(214, 621);
            this.txtscore.Name = "txtscore";
            this.txtscore.Size = new System.Drawing.Size(216, 35);
            this.txtscore.TabIndex = 67;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(115, 624);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 60;
            this.label9.Text = "Score:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label10.Location = new System.Drawing.Point(59, 502);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 29);
            this.label10.TabIndex = 58;
            this.label10.Text = "Student ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label8.Location = new System.Drawing.Point(23, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(185, 29);
            this.label8.TabIndex = 57;
            this.label8.Text = "Select Course:";
            // 
            // DataGridStudent
            // 
            this.DataGridStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DataGridStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridStudent.Location = new System.Drawing.Point(12, 86);
            this.DataGridStudent.Name = "DataGridStudent";
            this.DataGridStudent.RowHeadersWidth = 62;
            this.DataGridStudent.RowTemplate.Height = 28;
            this.DataGridStudent.Size = new System.Drawing.Size(493, 348);
            this.DataGridStudent.TabIndex = 55;
            this.DataGridStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridStudent_CellContentClick);
            this.DataGridStudent.Click += new System.EventHandler(this.RegisterForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label1.Location = new System.Drawing.Point(9, 671);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 29);
            this.label1.TabIndex = 60;
            this.label1.Text = "Description:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtdescription
            // 
            this.txtdescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescription.Location = new System.Drawing.Point(167, 671);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(855, 35);
            this.txtdescription.TabIndex = 67;
            // 
            // cbcourse
            // 
            this.cbcourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbcourse.FormattingEnabled = true;
            this.cbcourse.Location = new System.Drawing.Point(214, 559);
            this.cbcourse.Name = "cbcourse";
            this.cbcourse.Size = new System.Drawing.Size(212, 37);
            this.cbcourse.TabIndex = 79;
            // 
            // DataGridScore
            // 
            this.DataGridScore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.DataGridScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridScore.Location = new System.Drawing.Point(527, 86);
            this.DataGridScore.Name = "DataGridScore";
            this.DataGridScore.RowHeadersWidth = 62;
            this.DataGridScore.RowTemplate.Height = 28;
            this.DataGridScore.Size = new System.Drawing.Size(495, 348);
            this.DataGridScore.TabIndex = 55;
            this.DataGridScore.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridScore_CellContentClick);
            this.DataGridScore.Click += new System.EventHandler(this.DataGridScore_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel2.Location = new System.Drawing.Point(511, 86);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 350);
            this.panel2.TabIndex = 80;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.Color.OrangeRed;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnupdate.Location = new System.Drawing.Point(593, 724);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(140, 54);
            this.btnupdate.TabIndex = 76;
            this.btnupdate.Text = "Update";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // txtstdid
            // 
            this.txtstdid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtstdid.Location = new System.Drawing.Point(214, 496);
            this.txtstdid.Name = "txtstdid";
            this.txtstdid.Size = new System.Drawing.Size(216, 35);
            this.txtstdid.TabIndex = 67;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.Red;
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btndelete.Location = new System.Drawing.Point(447, 724);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(140, 54);
            this.btndelete.TabIndex = 105;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 806);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cbcourse);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.txtstdid);
            this.Controls.Add(this.txtscore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DataGridScore);
            this.Controls.Add(this.DataGridStudent);
            this.Name = "Score";
            this.Text = "Score";
            this.Load += new System.EventHandler(this.Score_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label ScoreExit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.TextBox txtscore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView DataGridStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdescription;
        private System.Windows.Forms.ComboBox cbcourse;
        private System.Windows.Forms.DataGridView DataGridScore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox txtstdid;
        private System.Windows.Forms.Button btndelete;
    }
}