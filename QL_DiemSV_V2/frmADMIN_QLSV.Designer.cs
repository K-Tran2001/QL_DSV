namespace QL_DiemSV_V2
{
    partial class frmADMIN_QLSV
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.datengaySinh = new System.Windows.Forms.DateTimePicker();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.cbogioiTinh = new System.Windows.Forms.ComboBox();
            this.txtdienThoai = new System.Windows.Forms.TextBox();
            this.txttenSV = new System.Windows.Forms.TextBox();
            this.txtdiaChi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmSSV = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgsinhVien = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.ibtnExport = new FontAwesome.Sharp.IconButton();
            this.ibtnImport = new FontAwesome.Sharp.IconButton();
            this.ibtnDoc = new FontAwesome.Sharp.IconButton();
            this.ibtnNext = new FontAwesome.Sharp.IconButton();
            this.ibtnBack = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnRefresh = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtTim = new System.Windows.Forms.TextBox();
            this.ibtnTim = new FontAwesome.Sharp.IconButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rad_SQL = new System.Windows.Forms.RadioButton();
            this.rad_XML = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhVien)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.datengaySinh);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.cbogioiTinh);
            this.groupBox1.Controls.Add(this.txtdienThoai);
            this.groupBox1.Controls.Add(this.txttenSV);
            this.groupBox1.Controls.Add(this.txtdiaChi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtmSSV);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Teal;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1174, 110);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sinh viên";
            // 
            // datengaySinh
            // 
            this.datengaySinh.Location = new System.Drawing.Point(388, 19);
            this.datengaySinh.MaxDate = new System.DateTime(2050, 3, 20, 0, 0, 0, 0);
            this.datengaySinh.MinDate = new System.DateTime(1996, 1, 1, 0, 0, 0, 0);
            this.datengaySinh.Name = "datengaySinh";
            this.datengaySinh.Size = new System.Drawing.Size(274, 26);
            this.datengaySinh.TabIndex = 2;
            this.datengaySinh.Value = new System.DateTime(2003, 12, 31, 0, 0, 0, 0);
            // 
            // cboLop
            // 
            this.cboLop.ForeColor = System.Drawing.Color.Teal;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(890, 65);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(124, 27);
            this.cboLop.TabIndex = 6;
            // 
            // cbogioiTinh
            // 
            this.cbogioiTinh.ForeColor = System.Drawing.Color.Teal;
            this.cbogioiTinh.FormattingEnabled = true;
            this.cbogioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.cbogioiTinh.Location = new System.Drawing.Point(388, 61);
            this.cbogioiTinh.Name = "cbogioiTinh";
            this.cbogioiTinh.Size = new System.Drawing.Size(135, 27);
            this.cbogioiTinh.TabIndex = 2;
            // 
            // txtdienThoai
            // 
            this.txtdienThoai.ForeColor = System.Drawing.Color.Teal;
            this.txtdienThoai.Location = new System.Drawing.Point(659, 63);
            this.txtdienThoai.Name = "txtdienThoai";
            this.txtdienThoai.Size = new System.Drawing.Size(135, 26);
            this.txtdienThoai.TabIndex = 4;
            this.txtdienThoai.TextChanged += new System.EventHandler(this.txtdienThoai_TextChanged);
            // 
            // txttenSV
            // 
            this.txttenSV.ForeColor = System.Drawing.Color.Teal;
            this.txttenSV.Location = new System.Drawing.Point(116, 72);
            this.txttenSV.Name = "txttenSV";
            this.txttenSV.Size = new System.Drawing.Size(135, 26);
            this.txttenSV.TabIndex = 1;
            // 
            // txtdiaChi
            // 
            this.txtdiaChi.ForeColor = System.Drawing.Color.Teal;
            this.txtdiaChi.Location = new System.Drawing.Point(890, 21);
            this.txtdiaChi.Name = "txtdiaChi";
            this.txtdiaChi.Size = new System.Drawing.Size(214, 26);
            this.txtdiaChi.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.DarkCyan;
            this.label6.Location = new System.Drawing.Point(619, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 19);
            this.label6.TabIndex = 0;
            this.label6.Text = "Sđt:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.DarkCyan;
            this.label7.Location = new System.Drawing.Point(828, 65);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 19);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã lớp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(303, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Giới tính:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkCyan;
            this.label5.Location = new System.Drawing.Point(830, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Địa chỉ:";
            // 
            // txtmSSV
            // 
            this.txtmSSV.ForeColor = System.Drawing.Color.Teal;
            this.txtmSSV.Location = new System.Drawing.Point(116, 22);
            this.txtmSSV.Name = "txtmSSV";
            this.txtmSSV.Size = new System.Drawing.Size(135, 26);
            this.txtmSSV.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(293, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(47, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên SV:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(47, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã SV:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgsinhVien);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(367, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 400);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sinh viên";
            // 
            // dtgsinhVien
            // 
            this.dtgsinhVien.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgsinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgsinhVien.EnableHeadersVisualStyles = false;
            this.dtgsinhVien.GridColor = System.Drawing.Color.LightGray;
            this.dtgsinhVien.Location = new System.Drawing.Point(6, 29);
            this.dtgsinhVien.Name = "dtgsinhVien";
            this.dtgsinhVien.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgsinhVien.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgsinhVien.Size = new System.Drawing.Size(743, 362);
            this.dtgsinhVien.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.Controls.Add(this.groupBox6);
            this.groupBox3.Controls.Add(this.ibtnNext);
            this.groupBox3.Controls.Add(this.ibtnBack);
            this.groupBox3.Controls.Add(this.ibtnXoa);
            this.groupBox3.Controls.Add(this.ibtnSua);
            this.groupBox3.Controls.Add(this.ibtnRefresh);
            this.groupBox3.Controls.Add(this.ibtnLuu);
            this.groupBox3.Controls.Add(this.ibtnThem);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(12, 140);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(331, 400);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng điều khiển";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.ibtnExport);
            this.groupBox6.Controls.Add(this.ibtnImport);
            this.groupBox6.Controls.Add(this.ibtnDoc);
            this.groupBox6.Location = new System.Drawing.Point(20, 321);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(272, 70);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Import/Export";
            // 
            // ibtnExport
            // 
            this.ibtnExport.FlatAppearance.BorderSize = 0;
            this.ibtnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnExport.IconChar = FontAwesome.Sharp.IconChar.FileExport;
            this.ibtnExport.IconColor = System.Drawing.Color.Black;
            this.ibtnExport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnExport.Location = new System.Drawing.Point(156, 19);
            this.ibtnExport.Name = "ibtnExport";
            this.ibtnExport.Size = new System.Drawing.Size(52, 45);
            this.ibtnExport.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnExport, "Export file XML");
            this.ibtnExport.UseVisualStyleBackColor = true;
            this.ibtnExport.Click += new System.EventHandler(this.ibtnExport_Click);
            // 
            // ibtnImport
            // 
            this.ibtnImport.FlatAppearance.BorderSize = 0;
            this.ibtnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnImport.IconChar = FontAwesome.Sharp.IconChar.FileUpload;
            this.ibtnImport.IconColor = System.Drawing.Color.Black;
            this.ibtnImport.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnImport.IconSize = 45;
            this.ibtnImport.Location = new System.Drawing.Point(99, 19);
            this.ibtnImport.Name = "ibtnImport";
            this.ibtnImport.Size = new System.Drawing.Size(50, 45);
            this.ibtnImport.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnImport, "Import file XML");
            this.ibtnImport.UseVisualStyleBackColor = true;
            this.ibtnImport.Click += new System.EventHandler(this.ibtnImport_Click);
            // 
            // ibtnDoc
            // 
            this.ibtnDoc.FlatAppearance.BorderSize = 0;
            this.ibtnDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDoc.IconChar = FontAwesome.Sharp.IconChar.FileImport;
            this.ibtnDoc.IconColor = System.Drawing.Color.Black;
            this.ibtnDoc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDoc.Location = new System.Drawing.Point(38, 19);
            this.ibtnDoc.Name = "ibtnDoc";
            this.ibtnDoc.Size = new System.Drawing.Size(50, 45);
            this.ibtnDoc.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnDoc, "Đọc file XML");
            this.ibtnDoc.UseVisualStyleBackColor = true;
            this.ibtnDoc.Click += new System.EventHandler(this.ibtnDoc_Click);
            // 
            // ibtnNext
            // 
            this.ibtnNext.BackColor = System.Drawing.Color.Transparent;
            this.ibtnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnNext.FlatAppearance.BorderSize = 0;
            this.ibtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnNext.IconChar = FontAwesome.Sharp.IconChar.Redo;
            this.ibtnNext.IconColor = System.Drawing.Color.Black;
            this.ibtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNext.IconSize = 40;
            this.ibtnNext.Location = new System.Drawing.Point(101, 211);
            this.ibtnNext.Name = "ibtnNext";
            this.ibtnNext.Size = new System.Drawing.Size(75, 57);
            this.ibtnNext.TabIndex = 9;
            this.ibtnNext.Tag = "Redo";
            this.ibtnNext.UseVisualStyleBackColor = false;
            this.ibtnNext.Click += new System.EventHandler(this.ibtnNext_Click);
            // 
            // ibtnBack
            // 
            this.ibtnBack.BackColor = System.Drawing.Color.Transparent;
            this.ibtnBack.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnBack.FlatAppearance.BorderSize = 0;
            this.ibtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnBack.IconChar = FontAwesome.Sharp.IconChar.Undo;
            this.ibtnBack.IconColor = System.Drawing.Color.Black;
            this.ibtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBack.IconSize = 40;
            this.ibtnBack.Location = new System.Drawing.Point(20, 211);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(75, 57);
            this.ibtnBack.TabIndex = 9;
            this.ibtnBack.Tag = "Undo";
            this.ibtnBack.UseVisualStyleBackColor = false;
            this.ibtnBack.Click += new System.EventHandler(this.ibtnBack_Click);
            // 
            // ibtnXoa
            // 
            this.ibtnXoa.BackColor = System.Drawing.Color.Transparent;
            this.ibtnXoa.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnXoa.FlatAppearance.BorderSize = 0;
            this.ibtnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnXoa.IconChar = FontAwesome.Sharp.IconChar.UserMinus;
            this.ibtnXoa.IconColor = System.Drawing.Color.Black;
            this.ibtnXoa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnXoa.Location = new System.Drawing.Point(230, 274);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(62, 41);
            this.ibtnXoa.TabIndex = 9;
            this.ibtnXoa.Tag = "Xóa";
            this.ibtnXoa.UseVisualStyleBackColor = false;
            this.ibtnXoa.Click += new System.EventHandler(this.ibtnXoa_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.BackColor = System.Drawing.Color.Transparent;
            this.ibtnSua.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnSua.FlatAppearance.BorderSize = 0;
            this.ibtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.ibtnSua.IconColor = System.Drawing.Color.Black;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.Location = new System.Drawing.Point(141, 274);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(62, 41);
            this.ibtnSua.TabIndex = 9;
            this.ibtnSua.Tag = "Sửa";
            this.ibtnSua.UseVisualStyleBackColor = false;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnRefresh
            // 
            this.ibtnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.ibtnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnRefresh.FlatAppearance.BorderSize = 0;
            this.ibtnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRefresh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnRefresh.IconChar = FontAwesome.Sharp.IconChar.Sync;
            this.ibtnRefresh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefresh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefresh.Location = new System.Drawing.Point(230, 211);
            this.ibtnRefresh.Name = "ibtnRefresh";
            this.ibtnRefresh.Size = new System.Drawing.Size(70, 63);
            this.ibtnRefresh.TabIndex = 9;
            this.ibtnRefresh.Tag = "Refresh";
            this.ibtnRefresh.UseVisualStyleBackColor = false;
            this.ibtnRefresh.Click += new System.EventHandler(this.ibtnRefresh_Click);
            // 
            // ibtnLuu
            // 
            this.ibtnLuu.BackColor = System.Drawing.Color.Transparent;
            this.ibtnLuu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnLuu.FlatAppearance.BorderSize = 0;
            this.ibtnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnLuu.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnLuu.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtnLuu.IconColor = System.Drawing.Color.Black;
            this.ibtnLuu.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnLuu.Location = new System.Drawing.Point(73, 269);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(62, 51);
            this.ibtnLuu.TabIndex = 9;
            this.ibtnLuu.Tag = "Lưu";
            this.ibtnLuu.UseVisualStyleBackColor = false;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // ibtnThem
            // 
            this.ibtnThem.BackColor = System.Drawing.Color.Transparent;
            this.ibtnThem.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ibtnThem.FlatAppearance.BorderSize = 0;
            this.ibtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.Location = new System.Drawing.Point(5, 274);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(62, 41);
            this.ibtnThem.TabIndex = 9;
            this.ibtnThem.Tag = "Thêm";
            this.ibtnThem.UseVisualStyleBackColor = false;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtTim);
            this.groupBox4.Controls.Add(this.ibtnTim);
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(7, 126);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(308, 79);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tìm kiếm theo tên";
            // 
            // txtTim
            // 
            this.txtTim.ForeColor = System.Drawing.Color.Teal;
            this.txtTim.Location = new System.Drawing.Point(6, 37);
            this.txtTim.Name = "txtTim";
            this.txtTim.Size = new System.Drawing.Size(215, 26);
            this.txtTim.TabIndex = 9;
            // 
            // ibtnTim
            // 
            this.ibtnTim.BackColor = System.Drawing.Color.Transparent;
            this.ibtnTim.FlatAppearance.BorderSize = 0;
            this.ibtnTim.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.ibtnTim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.ibtnTim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnTim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ibtnTim.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ibtnTim.IconColor = System.Drawing.Color.Black;
            this.ibtnTim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnTim.IconSize = 40;
            this.ibtnTim.Location = new System.Drawing.Point(249, 25);
            this.ibtnTim.Name = "ibtnTim";
            this.ibtnTim.Size = new System.Drawing.Size(44, 48);
            this.ibtnTim.TabIndex = 1;
            this.ibtnTim.Tag = "Tìm";
            this.ibtnTim.UseVisualStyleBackColor = false;
            this.ibtnTim.Click += new System.EventHandler(this.ibtnTim_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rad_SQL);
            this.groupBox5.Controls.Add(this.rad_XML);
            this.groupBox5.Location = new System.Drawing.Point(13, 25);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(287, 84);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Thao tác dữ liệu với:";
            // 
            // rad_SQL
            // 
            this.rad_SQL.AutoSize = true;
            this.rad_SQL.Checked = true;
            this.rad_SQL.Location = new System.Drawing.Point(37, 38);
            this.rad_SQL.Name = "rad_SQL";
            this.rad_SQL.Size = new System.Drawing.Size(58, 23);
            this.rad_SQL.TabIndex = 7;
            this.rad_SQL.TabStop = true;
            this.rad_SQL.Text = "SQL";
            this.rad_SQL.UseVisualStyleBackColor = true;
            this.rad_SQL.CheckedChanged += new System.EventHandler(this.rad_SQL_CheckedChanged);
            // 
            // rad_XML
            // 
            this.rad_XML.AutoSize = true;
            this.rad_XML.Location = new System.Drawing.Point(151, 38);
            this.rad_XML.Name = "rad_XML";
            this.rad_XML.Size = new System.Drawing.Size(64, 23);
            this.rad_XML.TabIndex = 7;
            this.rad_XML.TabStop = true;
            this.rad_XML.Text = "XML";
            this.rad_XML.UseVisualStyleBackColor = true;
            this.rad_XML.CheckedChanged += new System.EventHandler(this.rad_XML_CheckedChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // frmADMIN_QLSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1134, 552);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmADMIN_QLSV";
            this.Text = "thucthi";
            this.Load += new System.EventHandler(this.frmADMIN_QLSV_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmADMIN_QLSV_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgsinhVien)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.ComboBox cbogioiTinh;
        private System.Windows.Forms.TextBox txtdienThoai;
        private System.Windows.Forms.TextBox txttenSV;
        private System.Windows.Forms.TextBox txtdiaChi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmSSV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgsinhVien;
        private System.Windows.Forms.GroupBox groupBox3;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnRefresh;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker datengaySinh;
        private System.Windows.Forms.TextBox txtTim;
        private FontAwesome.Sharp.IconButton ibtnTim;
        private FontAwesome.Sharp.IconButton ibtnNext;
        private FontAwesome.Sharp.IconButton ibtnBack;
        private FontAwesome.Sharp.IconButton ibtnDoc;
        private FontAwesome.Sharp.IconButton ibtnImport;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private FontAwesome.Sharp.IconButton ibtnExport;
        private System.Windows.Forms.RadioButton rad_SQL;
        private System.Windows.Forms.RadioButton rad_XML;
    }
}