namespace QL_DiemSV_V2
{
    partial class frmADMIN_QLDIEMSV
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
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.treeSV_Lop = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labxepLoai = new System.Windows.Forms.Label();
            this.labdienThoai = new System.Windows.Forms.Label();
            this.labngaySinh = new System.Windows.Forms.Label();
            this.labtenSV = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labdiemTB = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.labmaLop = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labdiaChi = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labgioiTinh = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labmSSV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ibtnallDiem = new FontAwesome.Sharp.IconButton();
            this.ibtnXoaThanhTich = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.cboHK = new System.Windows.Forms.ComboBox();
            this.ibtnxuatExcel = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this._dtgKQHT = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dtgKQHT)).BeginInit();
            this.SuspendLayout();
            // 
            // cboLop
            // 
            this.cboLop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboLop.ForeColor = System.Drawing.Color.Teal;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(9, 37);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(149, 23);
            this.cboLop.TabIndex = 0;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // treeSV_Lop
            // 
            this.treeSV_Lop.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.treeSV_Lop.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeSV_Lop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.treeSV_Lop.Location = new System.Drawing.Point(8, 66);
            this.treeSV_Lop.Name = "treeSV_Lop";
            this.treeSV_Lop.Size = new System.Drawing.Size(149, 514);
            this.treeSV_Lop.TabIndex = 1;
            this.treeSV_Lop.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeSV_Lop_NodeMouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.labxepLoai);
            this.groupBox1.Controls.Add(this.labdienThoai);
            this.groupBox1.Controls.Add(this.labngaySinh);
            this.groupBox1.Controls.Add(this.labtenSV);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labdiemTB);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.labmaLop);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.labdiaChi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.labgioiTinh);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labmSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(167, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(955, 117);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // labxepLoai
            // 
            this.labxepLoai.AutoSize = true;
            this.labxepLoai.ForeColor = System.Drawing.Color.Red;
            this.labxepLoai.Location = new System.Drawing.Point(844, 68);
            this.labxepLoai.Name = "labxepLoai";
            this.labxepLoai.Size = new System.Drawing.Size(37, 19);
            this.labxepLoai.TabIndex = 0;
            this.labxepLoai.Text = "Null";
            // 
            // labdienThoai
            // 
            this.labdienThoai.AutoSize = true;
            this.labdienThoai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdienThoai.ForeColor = System.Drawing.Color.Purple;
            this.labdienThoai.Location = new System.Drawing.Point(578, 68);
            this.labdienThoai.Name = "labdienThoai";
            this.labdienThoai.Size = new System.Drawing.Size(34, 19);
            this.labdienThoai.TabIndex = 0;
            this.labdienThoai.Text = "Null";
            // 
            // labngaySinh
            // 
            this.labngaySinh.AutoSize = true;
            this.labngaySinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labngaySinh.ForeColor = System.Drawing.Color.Purple;
            this.labngaySinh.Location = new System.Drawing.Point(342, 68);
            this.labngaySinh.Name = "labngaySinh";
            this.labngaySinh.Size = new System.Drawing.Size(34, 19);
            this.labngaySinh.TabIndex = 0;
            this.labngaySinh.Text = "Null";
            // 
            // labtenSV
            // 
            this.labtenSV.AutoSize = true;
            this.labtenSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtenSV.ForeColor = System.Drawing.Color.Purple;
            this.labtenSV.Location = new System.Drawing.Point(93, 72);
            this.labtenSV.Name = "labtenSV";
            this.labtenSV.Size = new System.Drawing.Size(34, 19);
            this.labtenSV.TabIndex = 0;
            this.labtenSV.Text = "Null";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.Blue;
            this.label19.Location = new System.Drawing.Point(769, 68);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(69, 19);
            this.label19.TabIndex = 0;
            this.label19.Text = "Xếp loại:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Purple;
            this.label11.Location = new System.Drawing.Point(516, 68);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 19);
            this.label11.TabIndex = 0;
            this.label11.Text = "Sđt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(264, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày sinh:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(31, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên SV:";
            // 
            // labdiemTB
            // 
            this.labdiemTB.AutoSize = true;
            this.labdiemTB.ForeColor = System.Drawing.Color.Red;
            this.labdiemTB.Location = new System.Drawing.Point(844, 24);
            this.labdiemTB.Name = "labdiemTB";
            this.labdiemTB.Size = new System.Drawing.Size(37, 19);
            this.labdiemTB.TabIndex = 0;
            this.labdiemTB.Text = "Null";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.Blue;
            this.label17.Location = new System.Drawing.Point(763, 24);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(75, 19);
            this.label17.TabIndex = 0;
            this.label17.Text = "Điểm TB:";
            // 
            // labmaLop
            // 
            this.labmaLop.AutoSize = true;
            this.labmaLop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmaLop.ForeColor = System.Drawing.Color.Purple;
            this.labmaLop.Location = new System.Drawing.Point(623, 24);
            this.labmaLop.Name = "labmaLop";
            this.labmaLop.Size = new System.Drawing.Size(34, 19);
            this.labmaLop.TabIndex = 0;
            this.labmaLop.Text = "Null";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Purple;
            this.label13.Location = new System.Drawing.Point(561, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 19);
            this.label13.TabIndex = 0;
            this.label13.Text = "Mã Lớp:";
            // 
            // labdiaChi
            // 
            this.labdiaChi.AutoSize = true;
            this.labdiaChi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdiaChi.ForeColor = System.Drawing.Color.Purple;
            this.labdiaChi.Location = new System.Drawing.Point(451, 24);
            this.labdiaChi.Name = "labdiaChi";
            this.labdiaChi.Size = new System.Drawing.Size(34, 19);
            this.labdiaChi.TabIndex = 0;
            this.labdiaChi.Text = "Null";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Purple;
            this.label9.Location = new System.Drawing.Point(389, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 19);
            this.label9.TabIndex = 0;
            this.label9.Text = "Địa chỉ:";
            // 
            // labgioiTinh
            // 
            this.labgioiTinh.AutoSize = true;
            this.labgioiTinh.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labgioiTinh.ForeColor = System.Drawing.Color.Purple;
            this.labgioiTinh.Location = new System.Drawing.Point(282, 24);
            this.labgioiTinh.Name = "labgioiTinh";
            this.labgioiTinh.Size = new System.Drawing.Size(34, 19);
            this.labgioiTinh.TabIndex = 0;
            this.labgioiTinh.Text = "Null";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.Location = new System.Drawing.Point(204, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giới tính:";
            // 
            // labmSSV
            // 
            this.labmSSV.AutoSize = true;
            this.labmSSV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labmSSV.ForeColor = System.Drawing.Color.Purple;
            this.labmSSV.Location = new System.Drawing.Point(93, 28);
            this.labmSSV.Name = "labmSSV";
            this.labmSSV.Size = new System.Drawing.Size(34, 19);
            this.labmSSV.TabIndex = 0;
            this.labmSSV.Text = "Null";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this._dtgKQHT);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(167, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(955, 387);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Điểm học viên";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox3.Controls.Add(this.ibtnallDiem);
            this.groupBox3.Controls.Add(this.ibtnXoaThanhTich);
            this.groupBox3.Controls.Add(this.ibtnXoa);
            this.groupBox3.Controls.Add(this.cboHK);
            this.groupBox3.Controls.Add(this.ibtnxuatExcel);
            this.groupBox3.Controls.Add(this.ibtnLuu);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(19, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(917, 87);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng điều khiển";
            // 
            // ibtnallDiem
            // 
            this.ibtnallDiem.FlatAppearance.BorderSize = 0;
            this.ibtnallDiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnallDiem.IconChar = FontAwesome.Sharp.IconChar.Table;
            this.ibtnallDiem.IconColor = System.Drawing.Color.Black;
            this.ibtnallDiem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnallDiem.Location = new System.Drawing.Point(608, 27);
            this.ibtnallDiem.Name = "ibtnallDiem";
            this.ibtnallDiem.Size = new System.Drawing.Size(60, 49);
            this.ibtnallDiem.TabIndex = 3;
            this.ibtnallDiem.Tag = "Hiển thị điểm tất cả các học kì";
            this.ibtnallDiem.UseVisualStyleBackColor = true;
            this.ibtnallDiem.Click += new System.EventHandler(this.ibtnallDiem_Click);
            // 
            // ibtnXoaThanhTich
            // 
            this.ibtnXoaThanhTich.FlatAppearance.BorderSize = 0;
            this.ibtnXoaThanhTich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoaThanhTich.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.ibtnXoaThanhTich.IconColor = System.Drawing.Color.Black;
            this.ibtnXoaThanhTich.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoaThanhTich.Location = new System.Drawing.Point(345, 21);
            this.ibtnXoaThanhTich.Name = "ibtnXoaThanhTich";
            this.ibtnXoaThanhTich.Size = new System.Drawing.Size(58, 61);
            this.ibtnXoaThanhTich.TabIndex = 0;
            this.ibtnXoaThanhTich.Tag = "Xóa bảng điểm của sinh viên";
            this.ibtnXoaThanhTich.UseVisualStyleBackColor = true;
            this.ibtnXoaThanhTich.Click += new System.EventHandler(this.ibtnXoaThanhTich_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.FlatAppearance.BorderSize = 0;
            this.ibtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.ibtnXoa.IconColor = System.Drawing.Color.Black;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.Location = new System.Drawing.Point(244, 22);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(61, 59);
            this.ibtnXoa.TabIndex = 0;
            this.ibtnXoa.Tag = "Xóa điểm";
            this.ibtnXoa.UseVisualStyleBackColor = true;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // cboHK
            // 
            this.cboHK.ForeColor = System.Drawing.Color.Teal;
            this.cboHK.FormattingEnabled = true;
            this.cboHK.Location = new System.Drawing.Point(676, 39);
            this.cboHK.Name = "cboHK";
            this.cboHK.Size = new System.Drawing.Size(129, 27);
            this.cboHK.TabIndex = 2;
            this.cboHK.SelectedIndexChanged += new System.EventHandler(this.cboHK_SelectedIndexChanged);
            // 
            // ibtnxuatExcel
            // 
            this.ibtnxuatExcel.FlatAppearance.BorderSize = 0;
            this.ibtnxuatExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnxuatExcel.IconChar = FontAwesome.Sharp.IconChar.FileExcel;
            this.ibtnxuatExcel.IconColor = System.Drawing.Color.Black;
            this.ibtnxuatExcel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnxuatExcel.Location = new System.Drawing.Point(843, 22);
            this.ibtnxuatExcel.Name = "ibtnxuatExcel";
            this.ibtnxuatExcel.Size = new System.Drawing.Size(59, 59);
            this.ibtnxuatExcel.TabIndex = 0;
            this.ibtnxuatExcel.Tag = "Cập nhật điểm";
            this.ibtnxuatExcel.UseVisualStyleBackColor = true;
            this.ibtnxuatExcel.Visible = false;
            this.ibtnxuatExcel.Click += new System.EventHandler(this.ibtnxuatExcel_Click);
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.FlatAppearance.BorderSize = 0;
            this.ibtnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtnLuu.IconColor = System.Drawing.Color.Black;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.Location = new System.Drawing.Point(145, 22);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(61, 59);
            this.ibtnLuu.TabIndex = 0;
            this.ibtnLuu.Tag = "Lưu điểm";
            this.ibtnLuu.UseVisualStyleBackColor = true;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // _dtgKQHT
            // 
            this._dtgKQHT.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this._dtgKQHT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dtgKQHT.Location = new System.Drawing.Point(19, 118);
            this._dtgKQHT.Name = "_dtgKQHT";
            this._dtgKQHT.Size = new System.Drawing.Size(917, 263);
            this._dtgKQHT.TabIndex = 3;
            this._dtgKQHT.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this._dtgKQHT_CellClick);
            // 
            // frmADMIN_QLDIEMSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1134, 587);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.treeSV_Lop);
            this.Controls.Add(this.cboLop);
            this.Name = "frmADMIN_QLDIEMSV";
            this.Text = "frmADMIN_QLDIEMSV";
            this.Load += new System.EventHandler(this.frmADMIN_QLDIEMSV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmADMIN_QLDIEMSV_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmADMIN_QLDIEMSV_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dtgKQHT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.TreeView treeSV_Lop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labxepLoai;
        private System.Windows.Forms.Label labdienThoai;
        private System.Windows.Forms.Label labngaySinh;
        private System.Windows.Forms.Label labtenSV;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labdiemTB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label labmaLop;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labdiaChi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labgioiTinh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labmSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton ibtnXoaThanhTich;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnxuatExcel;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private System.Windows.Forms.ComboBox cboHK;
        private FontAwesome.Sharp.IconButton ibtnallDiem;
        private System.Windows.Forms.DataGridView _dtgKQHT;
    }
}