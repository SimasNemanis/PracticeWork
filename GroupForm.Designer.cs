namespace PracticeWork
{
    partial class GroupForm
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
            this.txtgid = new System.Windows.Forms.TextBox();
            this.txtgname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.Groupdelete = new System.Windows.Forms.Button();
            this.Groupadd = new System.Windows.Forms.Button();
            this.Groupupdate = new System.Windows.Forms.Button();
            this.Groupclear = new System.Windows.Forms.Button();
            this.DataGridGroup = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // txtgid
            // 
            this.txtgid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgid.Location = new System.Drawing.Point(188, 506);
            this.txtgid.Name = "txtgid";
            this.txtgid.Size = new System.Drawing.Size(225, 35);
            this.txtgid.TabIndex = 99;
            // 
            // txtgname
            // 
            this.txtgname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgname.Location = new System.Drawing.Point(628, 506);
            this.txtgname.Name = "txtgname";
            this.txtgname.Size = new System.Drawing.Size(230, 35);
            this.txtgname.TabIndex = 97;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label4.Location = new System.Drawing.Point(46, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 29);
            this.label4.TabIndex = 93;
            this.label4.Text = "Group ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.label9.Location = new System.Drawing.Point(445, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(168, 29);
            this.label9.TabIndex = 94;
            this.label9.Text = "Group Name:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel3.Location = new System.Drawing.Point(12, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1013, 17);
            this.panel3.TabIndex = 89;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 68);
            this.panel1.TabIndex = 88;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(391, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(145, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "New Group";
            // 
            // Groupdelete
            // 
            this.Groupdelete.BackColor = System.Drawing.Color.Red;
            this.Groupdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupdelete.ForeColor = System.Drawing.SystemColors.Control;
            this.Groupdelete.Location = new System.Drawing.Point(214, 578);
            this.Groupdelete.Name = "Groupdelete";
            this.Groupdelete.Size = new System.Drawing.Size(140, 54);
            this.Groupdelete.TabIndex = 87;
            this.Groupdelete.Text = "Delete";
            this.Groupdelete.UseVisualStyleBackColor = false;
            this.Groupdelete.Click += new System.EventHandler(this.Groupdelete_Click);
            // 
            // Groupadd
            // 
            this.Groupadd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.Groupadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupadd.ForeColor = System.Drawing.SystemColors.Control;
            this.Groupadd.Location = new System.Drawing.Point(652, 578);
            this.Groupadd.Name = "Groupadd";
            this.Groupadd.Size = new System.Drawing.Size(140, 54);
            this.Groupadd.TabIndex = 86;
            this.Groupadd.Text = "Add";
            this.Groupadd.UseVisualStyleBackColor = false;
            this.Groupadd.Click += new System.EventHandler(this.Groupadd_Click);
            // 
            // Groupupdate
            // 
            this.Groupupdate.BackColor = System.Drawing.Color.OrangeRed;
            this.Groupupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupupdate.ForeColor = System.Drawing.SystemColors.Control;
            this.Groupupdate.Location = new System.Drawing.Point(506, 578);
            this.Groupupdate.Name = "Groupupdate";
            this.Groupupdate.Size = new System.Drawing.Size(140, 54);
            this.Groupupdate.TabIndex = 84;
            this.Groupupdate.Text = "Update";
            this.Groupupdate.UseVisualStyleBackColor = false;
            this.Groupupdate.Click += new System.EventHandler(this.Groupupdate_Click);
            // 
            // Groupclear
            // 
            this.Groupclear.BackColor = System.Drawing.Color.Orange;
            this.Groupclear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupclear.ForeColor = System.Drawing.SystemColors.Control;
            this.Groupclear.Location = new System.Drawing.Point(360, 578);
            this.Groupclear.Name = "Groupclear";
            this.Groupclear.Size = new System.Drawing.Size(140, 54);
            this.Groupclear.TabIndex = 85;
            this.Groupclear.Text = "Clear";
            this.Groupclear.UseVisualStyleBackColor = false;
            this.Groupclear.Click += new System.EventHandler(this.Groupclear_Click);
            // 
            // DataGridGroup
            // 
            this.DataGridGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridGroup.Location = new System.Drawing.Point(12, 86);
            this.DataGridGroup.Name = "DataGridGroup";
            this.DataGridGroup.RowHeadersWidth = 62;
            this.DataGridGroup.RowTemplate.Height = 28;
            this.DataGridGroup.Size = new System.Drawing.Size(1013, 348);
            this.DataGridGroup.TabIndex = 83;
            this.DataGridGroup.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridGroup_CellContentClick);
            this.DataGridGroup.Click += new System.EventHandler(this.DataGridGroup_Click);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 663);
            this.Controls.Add(this.txtgid);
            this.Controls.Add(this.txtgname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Groupdelete);
            this.Controls.Add(this.Groupadd);
            this.Controls.Add(this.Groupupdate);
            this.Controls.Add(this.Groupclear);
            this.Controls.Add(this.DataGridGroup);
            this.Name = "GroupForm";
            this.Text = "GroupForm";
            this.Load += new System.EventHandler(this.GroupForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtgid;
        private System.Windows.Forms.TextBox txtgname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Groupdelete;
        private System.Windows.Forms.Button Groupadd;
        private System.Windows.Forms.Button Groupupdate;
        private System.Windows.Forms.Button Groupclear;
        private System.Windows.Forms.DataGridView DataGridGroup;
    }
}