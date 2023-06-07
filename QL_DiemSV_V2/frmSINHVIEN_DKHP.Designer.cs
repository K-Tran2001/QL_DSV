namespace QL_DiemSV_V2
{
    partial class frmSINHVIEN_DKHP
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboHK = new System.Windows.Forms.ComboBox();
            this.lstHPDK = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dtgHP = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ibtndangKi = new FontAwesome.Sharp.IconButton();
            this.ibtnboChon = new FontAwesome.Sharp.IconButton();
            this.ibtnChon = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtgCTDKHP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHP)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTDKHP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboHK);
            this.groupBox1.Controls.Add(this.lstHPDK);
            this.groupBox1.Controls.Add(this.dtgHP);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(851, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng kí HP";
            // 
            // cboHK
            // 
            this.cboHK.ForeColor = System.Drawing.Color.Teal;
            this.cboHK.FormattingEnabled = true;
            this.cboHK.Location = new System.Drawing.Point(6, 29);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(134, 27);
            this.cboHK.TabIndex = 2;
            this.cboHK.SelectedIndexChanged += new System.EventHandler(this.cboHK_SelectedIndexChanged);
            // 
            // lstHPDK
            // 
            this.lstHPDK.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lstHPDK.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstHPDK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstHPDK.FullRowSelect = true;
            this.lstHPDK.GridLines = true;
            this.lstHPDK.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstHPDK.HideSelection = false;
            this.lstHPDK.Location = new System.Drawing.Point(466, 62);
            this.lstHPDK.Name = "lstHPDK";
            this.lstHPDK.Size = new System.Drawing.Size(367, 166);
            this.lstHPDK.TabIndex = 1;
            this.lstHPDK.UseCompatibleStateImageBehavior = false;
            this.lstHPDK.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã HP";
            this.columnHeader1.Width = 90;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Tên HP";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Số TC";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Mã HK";
            this.columnHeader4.Width = 80;
            // 
            // dtgHP
            // 
            this.dtgHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHP.Location = new System.Drawing.Point(6, 62);
            this.dtgHP.Name = "dtgHP";
            this.dtgHP.Size = new System.Drawing.Size(442, 166);
            this.dtgHP.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ibtndangKi);
            this.groupBox2.Controls.Add(this.ibtnboChon);
            this.groupBox2.Controls.Add(this.ibtnChon);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(520, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 77);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng điều khiển";
            // 
            // ibtndangKi
            // 
            this.ibtndangKi.FlatAppearance.BorderSize = 0;
            this.ibtndangKi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtndangKi.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtndangKi.IconColor = System.Drawing.Color.Black;
            this.ibtndangKi.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtndangKi.Location = new System.Drawing.Point(194, 19);
            this.ibtndangKi.Name = "ibtndangKi";
            this.ibtndangKi.Size = new System.Drawing.Size(75, 52);
            this.ibtndangKi.TabIndex = 0;
            this.ibtndangKi.UseVisualStyleBackColor = true;
            this.ibtndangKi.Click += new System.EventHandler(this.ibtndangKi_Click);
            // 
            // ibtnboChon
            // 
            this.ibtnboChon.FlatAppearance.BorderSize = 0;
            this.ibtnboChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnboChon.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.ibtnboChon.IconColor = System.Drawing.Color.Black;
            this.ibtnboChon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnboChon.Location = new System.Drawing.Point(113, 19);
            this.ibtnboChon.Name = "ibtnboChon";
            this.ibtnboChon.Size = new System.Drawing.Size(75, 52);
            this.ibtnboChon.TabIndex = 0;
            this.ibtnboChon.UseVisualStyleBackColor = true;
            this.ibtnboChon.Click += new System.EventHandler(this.ibtnboChon_Click);
            // 
            // ibtnChon
            // 
            this.ibtnChon.FlatAppearance.BorderSize = 0;
            this.ibtnChon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnChon.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.ibtnChon.IconColor = System.Drawing.Color.Black;
            this.ibtnChon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnChon.Location = new System.Drawing.Point(32, 19);
            this.ibtnChon.Name = "ibtnChon";
            this.ibtnChon.Size = new System.Drawing.Size(75, 52);
            this.ibtnChon.TabIndex = 0;
            this.ibtnChon.UseVisualStyleBackColor = true;
            this.ibtnChon.Click += new System.EventHandler(this.ibtnChon_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtgCTDKHP);
            this.groupBox3.Controls.Add(this.groupBox2);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 253);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(817, 185);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi tiết DKHP";
            // 
            // dtgCTDKHP
            // 
            this.dtgCTDKHP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgCTDKHP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgCTDKHP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCTDKHP.Location = new System.Drawing.Point(7, 34);
            this.dtgCTDKHP.Name = "dtgCTDKHP";
            this.dtgCTDKHP.Size = new System.Drawing.Size(490, 145);
            this.dtgCTDKHP.TabIndex = 0;
            // 
            // frmSINHVIEN_DKHP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(876, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSINHVIEN_DKHP";
            this.Text = "frmSINHVIEN_DKHP";
            this.Load += new System.EventHandler(this.frmSINHVIEN_DKHP_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHP)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgCTDKHP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListView lstHPDK;
        private System.Windows.Forms.DataGridView dtgHP;
        private FontAwesome.Sharp.IconButton ibtnChon;
        private FontAwesome.Sharp.IconButton ibtndangKi;
        private FontAwesome.Sharp.IconButton ibtnboChon;
        private System.Windows.Forms.DataGridView dtgCTDKHP;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ComboBox cboHK;
    }
}