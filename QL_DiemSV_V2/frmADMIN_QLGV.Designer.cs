namespace QL_DiemSV_V2
{
    partial class frmADMIN_QLGV
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datengaySinh = new System.Windows.Forms.DateTimePicker();
            this.cbogioiTinh = new System.Windows.Forms.ComboBox();
            this.txtdiaChi = new System.Windows.Forms.TextBox();
            this.txttenGV = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdienThoai = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txteMail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmaGV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ibtnNext = new FontAwesome.Sharp.IconButton();
            this.ibtnBack = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ibtnTim = new FontAwesome.Sharp.IconButton();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dtggiaoVien = new System.Windows.Forms.DataGridView();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtggiaoVien)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datengaySinh);
            this.groupBox1.Controls.Add(this.cbogioiTinh);
            this.groupBox1.Controls.Add(this.txtdiaChi);
            this.groupBox1.Controls.Add(this.txttenGV);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtdienThoai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txteMail);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtmaGV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1109, 118);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // datengaySinh
            // 
            this.datengaySinh.Location = new System.Drawing.Point(447, 27);
            this.datengaySinh.Name = "datengaySinh";
            this.datengaySinh.Size = new System.Drawing.Size(296, 26);
            this.datengaySinh.TabIndex = 2;
            // 
            // cbogioiTinh
            // 
            this.cbogioiTinh.ForeColor = System.Drawing.Color.Teal;
            this.cbogioiTinh.FormattingEnabled = true;
            this.cbogioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbogioiTinh.Location = new System.Drawing.Point(432, 75);
            this.cbogioiTinh.Name = "cbogioiTinh";
            this.cbogioiTinh.Size = new System.Drawing.Size(91, 27);
            this.cbogioiTinh.TabIndex = 3;
            // 
            // txtdiaChi
            // 
            this.txtdiaChi.ForeColor = System.Drawing.Color.Teal;
            this.txtdiaChi.Location = new System.Drawing.Point(613, 76);
            this.txtdiaChi.Name = "txtdiaChi";
            this.txtdiaChi.Size = new System.Drawing.Size(218, 26);
            this.txtdiaChi.TabIndex = 4;
            // 
            // txttenGV
            // 
            this.txttenGV.ForeColor = System.Drawing.Color.Teal;
            this.txttenGV.Location = new System.Drawing.Point(93, 75);
            this.txttenGV.Name = "txttenGV";
            this.txttenGV.Size = new System.Drawing.Size(219, 26);
            this.txttenGV.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(552, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(357, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(20, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên GV:";
            // 
            // txtdienThoai
            // 
            this.txtdienThoai.ForeColor = System.Drawing.Color.Teal;
            this.txtdienThoai.Location = new System.Drawing.Point(927, 32);
            this.txtdienThoai.Name = "txtdienThoai";
            this.txtdienThoai.Size = new System.Drawing.Size(164, 26);
            this.txtdienThoai.TabIndex = 5;
            this.txtdienThoai.TextChanged += new System.EventHandler(this.txtdienThoai_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(841, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điện thoại:";
            // 
            // txteMail
            // 
            this.txteMail.ForeColor = System.Drawing.Color.Teal;
            this.txteMail.Location = new System.Drawing.Point(927, 78);
            this.txteMail.Name = "txteMail";
            this.txteMail.Size = new System.Drawing.Size(164, 26);
            this.txteMail.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(841, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(360, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh:";
            // 
            // txtmaGV
            // 
            this.txtmaGV.ForeColor = System.Drawing.Color.Teal;
            this.txtmaGV.Location = new System.Drawing.Point(91, 30);
            this.txtmaGV.Name = "txtmaGV";
            this.txtmaGV.Size = new System.Drawing.Size(219, 26);
            this.txtmaGV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã GV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ibtnNext);
            this.groupBox2.Controls.Add(this.ibtnBack);
            this.groupBox2.Controls.Add(this.ibtnXoa);
            this.groupBox2.Controls.Add(this.ibtnLuu);
            this.groupBox2.Controls.Add(this.ibtnSua);
            this.groupBox2.Controls.Add(this.ibtnThem);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(841, 160);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(291, 388);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bảng điều khiển";
            // 
            // ibtnNext
            // 
            this.ibtnNext.FlatAppearance.BorderSize = 0;
            this.ibtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNext.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ibtnNext.IconColor = System.Drawing.Color.Black;
            this.ibtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNext.Location = new System.Drawing.Point(138, 136);
            this.ibtnNext.Name = "ibtnNext";
            this.ibtnNext.Size = new System.Drawing.Size(75, 57);
            this.ibtnNext.TabIndex = 10;
            this.ibtnNext.UseVisualStyleBackColor = true;
            this.ibtnNext.Click += new System.EventHandler(this.ibtnNext_Click);
            // 
            // ibtnBack
            // 
            this.ibtnBack.AccessibleRole = System.Windows.Forms.AccessibleRole.OutlineButton;
            this.ibtnBack.Cursor = System.Windows.Forms.Cursors.Default;
            this.ibtnBack.FlatAppearance.BorderSize = 0;
            this.ibtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBack.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.ibtnBack.IconColor = System.Drawing.Color.Black;
            this.ibtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBack.Location = new System.Drawing.Point(57, 136);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(75, 57);
            this.ibtnBack.TabIndex = 10;
            this.ibtnBack.UseVisualStyleBackColor = true;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.FlatAppearance.BorderSize = 0;
            this.ibtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoa.IconColor = System.Drawing.Color.Black;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.Location = new System.Drawing.Point(173, 312);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(75, 56);
            this.ibtnXoa.TabIndex = 10;
            this.toolTip1.SetToolTip(this.ibtnXoa, "Xóa");
            this.ibtnXoa.UseVisualStyleBackColor = true;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.FlatAppearance.BorderSize = 0;
            this.ibtnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtnLuu.IconColor = System.Drawing.Color.Black;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.Location = new System.Drawing.Point(173, 221);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(75, 55);
            this.ibtnLuu.TabIndex = 10;
            this.toolTip1.SetToolTip(this.ibtnLuu, "Lưu");
            this.ibtnLuu.UseVisualStyleBackColor = true;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtLuu_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.FlatAppearance.BorderSize = 0;
            this.ibtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnSua.IconColor = System.Drawing.Color.Black;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.Location = new System.Drawing.Point(38, 312);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(75, 56);
            this.ibtnSua.TabIndex = 10;
            this.toolTip1.SetToolTip(this.ibtnSua, "Sửa");
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.FlatAppearance.BorderSize = 0;
            this.ibtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.Location = new System.Drawing.Point(38, 221);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(75, 55);
            this.ibtnThem.TabIndex = 10;
            this.toolTip1.SetToolTip(this.ibtnThem, "Thêm");
            this.ibtnThem.UseVisualStyleBackColor = true;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ibtnTim);
            this.groupBox4.Controls.Add(this.txtTim);
            this.groupBox4.Location = new System.Drawing.Point(6, 29);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(279, 90);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm theo tên";
            // 
            // ibtnTim
            // 
            this.ibtnTim.FlatAppearance.BorderSize = 0;
            this.ibtnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnTim.IconColor = System.Drawing.Color.Black;
            this.ibtnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTim.IconSize = 40;
            this.ibtnTim.Location = new System.Drawing.Point(211, 28);
            this.ibtnTim.Name = "ibtnTim";
            this.ibtnTim.Size = new System.Drawing.Size(53, 45);
            this.ibtnTim.TabIndex = 10;
            this.ibtnTim.Tag = "Tìm";
            this.ibtnTim.UseVisualStyleBackColor = true;
            this.ibtnTim.Click += new System.EventHandler(this.ibtnTim_Click);
            // 
            // txtTim
            // 
            this.txtTim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTim.Location = new System.Drawing.Point(6, 41);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(177, 26);
            this.txtTim.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtggiaoVien);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 147);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(807, 401);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách giáo viên";
            // 
            // dtggiaoVien
            // 
            this.dtggiaoVien.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtggiaoVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtggiaoVien.Location = new System.Drawing.Point(6, 34);
            this.dtggiaoVien.Name = "dtggiaoVien";
            this.dtggiaoVien.Size = new System.Drawing.Size(787, 359);
            this.dtggiaoVien.TabIndex = 0;
            // 
            // frmADMIN_QLGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1134, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmADMIN_QLGV";
            this.Text = "frmADMIN_QLGV";
            this.Load += new System.EventHandler(this.frmADMIN_QLGV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmADMIN_QLGV_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtggiaoVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker datengaySinh;
        private System.Windows.Forms.ComboBox cbogioiTinh;
        private System.Windows.Forms.TextBox txtdiaChi;
        private System.Windows.Forms.TextBox txttenGV;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdienThoai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txteMail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmaGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dtggiaoVien;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnNext;
        private FontAwesome.Sharp.IconButton ibtnBack;
        private FontAwesome.Sharp.IconButton ibtnTim;
        private System.Windows.Forms.TextBox txtTim;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}