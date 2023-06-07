namespace QL_DiemSV_V2
{
    partial class frmBackupRestorecs
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
            this.ibtnBackup = new FontAwesome.Sharp.IconButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbodatabaseanme = new System.Windows.Forms.ComboBox();
            this.cboSevername = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labpercent = new System.Windows.Forms.Label();
            this.pg = new System.Windows.Forms.ProgressBar();
            this.ibtnBrowse2 = new FontAwesome.Sharp.IconButton();
            this.ibtnRestore = new FontAwesome.Sharp.IconButton();
            this.txtPath2 = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibtnBackup
            // 
            this.ibtnBackup.FlatAppearance.BorderSize = 0;
            this.ibtnBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBackup.IconChar = FontAwesome.Sharp.IconChar.ClipboardList;
            this.ibtnBackup.IconColor = System.Drawing.Color.Black;
            this.ibtnBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBackup.Location = new System.Drawing.Point(433, 26);
            this.ibtnBackup.Name = "ibtnBackup";
            this.ibtnBackup.Size = new System.Drawing.Size(75, 49);
            this.ibtnBackup.TabIndex = 2;
            this.ibtnBackup.UseVisualStyleBackColor = true;
            this.ibtnBackup.Click += new System.EventHandler(this.ibtnBackup_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbodatabaseanme);
            this.groupBox1.Controls.Add(this.cboSevername);
            this.groupBox1.Controls.Add(this.ibtnBackup);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(54, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(517, 110);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(36, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 19);
            this.label3.TabIndex = 5;
            this.label3.Text = "Null";
            // 
            // cbodatabaseanme
            // 
            this.cbodatabaseanme.FormattingEnabled = true;
            this.cbodatabaseanme.Location = new System.Drawing.Point(200, 38);
            this.cbodatabaseanme.Name = "cbodatabaseanme";
            this.cbodatabaseanme.Size = new System.Drawing.Size(164, 27);
            this.cbodatabaseanme.TabIndex = 4;
            // 
            // cboSevername
            // 
            this.cboSevername.FormattingEnabled = true;
            this.cboSevername.Location = new System.Drawing.Point(30, 38);
            this.cboSevername.Name = "cboSevername";
            this.cboSevername.Size = new System.Drawing.Size(141, 27);
            this.cboSevername.TabIndex = 3;
            this.cboSevername.SelectedIndexChanged += new System.EventHandler(this.cboSevername_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labpercent);
            this.groupBox2.Controls.Add(this.pg);
            this.groupBox2.Controls.Add(this.ibtnBrowse2);
            this.groupBox2.Controls.Add(this.ibtnRestore);
            this.groupBox2.Controls.Add(this.txtPath2);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(54, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(517, 180);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Restore";
            // 
            // labpercent
            // 
            this.labpercent.AutoSize = true;
            this.labpercent.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labpercent.ForeColor = System.Drawing.Color.Black;
            this.labpercent.Location = new System.Drawing.Point(81, 158);
            this.labpercent.Name = "labpercent";
            this.labpercent.Size = new System.Drawing.Size(30, 19);
            this.labpercent.TabIndex = 4;
            this.labpercent.Text = "0%";
            // 
            // pg
            // 
            this.pg.Location = new System.Drawing.Point(30, 118);
            this.pg.Name = "pg";
            this.pg.Size = new System.Drawing.Size(357, 23);
            this.pg.TabIndex = 3;
            // 
            // ibtnBrowse2
            // 
            this.ibtnBrowse2.FlatAppearance.BorderSize = 0;
            this.ibtnBrowse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBrowse2.IconChar = FontAwesome.Sharp.IconChar.Paperclip;
            this.ibtnBrowse2.IconColor = System.Drawing.Color.Black;
            this.ibtnBrowse2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBrowse2.IconSize = 40;
            this.ibtnBrowse2.Location = new System.Drawing.Point(433, 25);
            this.ibtnBrowse2.Name = "ibtnBrowse2";
            this.ibtnBrowse2.Size = new System.Drawing.Size(75, 53);
            this.ibtnBrowse2.TabIndex = 1;
            this.ibtnBrowse2.UseVisualStyleBackColor = true;
            this.ibtnBrowse2.Click += new System.EventHandler(this.ibtnBrowse2_Click);
            // 
            // ibtnRestore
            // 
            this.ibtnRestore.FlatAppearance.BorderSize = 0;
            this.ibtnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRestore.IconChar = FontAwesome.Sharp.IconChar.WindowRestore;
            this.ibtnRestore.IconColor = System.Drawing.Color.Black;
            this.ibtnRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRestore.Location = new System.Drawing.Point(433, 102);
            this.ibtnRestore.Name = "ibtnRestore";
            this.ibtnRestore.Size = new System.Drawing.Size(75, 59);
            this.ibtnRestore.TabIndex = 2;
            this.ibtnRestore.UseVisualStyleBackColor = true;
            this.ibtnRestore.Click += new System.EventHandler(this.ibtnRestore_Click);
            // 
            // txtPath2
            // 
            this.txtPath2.Location = new System.Drawing.Point(30, 49);
            this.txtPath2.Name = "txtPath2";
            this.txtPath2.Size = new System.Drawing.Size(357, 26);
            this.txtPath2.TabIndex = 0;
            // 
            // frmBackupRestorecs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmBackupRestorecs";
            this.Text = "frmBackupRestorecs";
            this.Load += new System.EventHandler(this.frmBackupRestorecs_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton ibtnBackup;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private FontAwesome.Sharp.IconButton ibtnBrowse2;
        private FontAwesome.Sharp.IconButton ibtnRestore;
        private System.Windows.Forms.TextBox txtPath2;
        private System.Windows.Forms.ComboBox cboSevername;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ComboBox cbodatabaseanme;
        private System.Windows.Forms.Label labpercent;
        private System.Windows.Forms.ProgressBar pg;
        private System.Windows.Forms.Label label3;
    }
}