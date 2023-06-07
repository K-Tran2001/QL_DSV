namespace QL_DiemSV_V2
{
    partial class frmADMIN_QLTAIKHOAN
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
            this.dtgtaiKhoan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtmatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtloaiTaiKhoan = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenTaiKhoan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttaiKhoan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ibtnNext = new FontAwesome.Sharp.IconButton();
            this.ibtnBack = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgtaiKhoan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtgtaiKhoan);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(18, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách tài khoản";
            // 
            // dtgtaiKhoan
            // 
            this.dtgtaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgtaiKhoan.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dtgtaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgtaiKhoan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgtaiKhoan.Location = new System.Drawing.Point(3, 22);
            this.dtgtaiKhoan.Name = "dtgtaiKhoan";
            this.dtgtaiKhoan.Size = new System.Drawing.Size(550, 327);
            this.dtgtaiKhoan.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtmatKhau);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtloaiTaiKhoan);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txttenTaiKhoan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txttaiKhoan);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(625, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(352, 331);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin tài khoản";
            // 
            // txtmatKhau
            // 
            this.txtmatKhau.ForeColor = System.Drawing.Color.Teal;
            this.txtmatKhau.Location = new System.Drawing.Point(123, 266);
            this.txtmatKhau.Name = "txtmatKhau";
            this.txtmatKhau.Size = new System.Drawing.Size(195, 26);
            this.txtmatKhau.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(27, 269);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mật khẩu:";
            // 
            // txtloaiTaiKhoan
            // 
            this.txtloaiTaiKhoan.ForeColor = System.Drawing.Color.Teal;
            this.txtloaiTaiKhoan.Location = new System.Drawing.Point(123, 189);
            this.txtloaiTaiKhoan.Name = "txtloaiTaiKhoan";
            this.txtloaiTaiKhoan.Size = new System.Drawing.Size(195, 26);
            this.txtloaiTaiKhoan.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(11, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại tài khoản:";
            // 
            // txttenTaiKhoan
            // 
            this.txttenTaiKhoan.ForeColor = System.Drawing.Color.Teal;
            this.txttenTaiKhoan.Location = new System.Drawing.Point(123, 118);
            this.txttenTaiKhoan.Name = "txttenTaiKhoan";
            this.txttenTaiKhoan.Size = new System.Drawing.Size(195, 26);
            this.txttenTaiKhoan.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(11, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên tài khoản:";
            // 
            // txttaiKhoan
            // 
            this.txttaiKhoan.ForeColor = System.Drawing.Color.Teal;
            this.txttaiKhoan.Location = new System.Drawing.Point(123, 55);
            this.txttaiKhoan.Name = "txttaiKhoan";
            this.txttaiKhoan.Size = new System.Drawing.Size(195, 26);
            this.txttaiKhoan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(27, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tài khoản:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ibtnNext);
            this.groupBox4.Controls.Add(this.ibtnBack);
            this.groupBox4.Controls.Add(this.ibtnXoa);
            this.groupBox4.Controls.Add(this.ibtnLuu);
            this.groupBox4.Controls.Add(this.ibtnSua);
            this.groupBox4.Controls.Add(this.ibtnThem);
            this.groupBox4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Blue;
            this.groupBox4.Location = new System.Drawing.Point(18, 381);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(965, 103);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Bảng điều khiển";
            // 
            // ibtnNext
            // 
            this.ibtnNext.FlatAppearance.BorderSize = 0;
            this.ibtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNext.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.ibtnNext.IconColor = System.Drawing.Color.Black;
            this.ibtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNext.Location = new System.Drawing.Point(90, 29);
            this.ibtnNext.Name = "ibtnNext";
            this.ibtnNext.Size = new System.Drawing.Size(75, 59);
            this.ibtnNext.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnNext, "Redo");
            this.ibtnNext.UseVisualStyleBackColor = true;
            this.ibtnNext.Click += new System.EventHandler(this.ibtnNext_Click);
            // 
            // ibtnBack
            // 
            this.ibtnBack.FlatAppearance.BorderSize = 0;
            this.ibtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBack.IconChar = FontAwesome.Sharp.IconChar.UndoAlt;
            this.ibtnBack.IconColor = System.Drawing.Color.Black;
            this.ibtnBack.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBack.Location = new System.Drawing.Point(9, 29);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(75, 59);
            this.ibtnBack.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnBack, "Undo");
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
            this.ibtnXoa.Location = new System.Drawing.Point(873, 29);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(75, 59);
            this.ibtnXoa.TabIndex = 9;
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
            this.ibtnLuu.Location = new System.Drawing.Point(688, 29);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(75, 59);
            this.ibtnLuu.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnLuu, "Lưu");
            this.ibtnLuu.UseVisualStyleBackColor = true;
            this.ibtnLuu.Click += new System.EventHandler(this.ibtnLuu_Click);
            // 
            // ibtnSua
            // 
            this.ibtnSua.FlatAppearance.BorderSize = 0;
            this.ibtnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSua.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.ibtnSua.IconColor = System.Drawing.Color.Black;
            this.ibtnSua.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSua.Location = new System.Drawing.Point(540, 29);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(75, 59);
            this.ibtnSua.TabIndex = 9;
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
            this.ibtnThem.Location = new System.Drawing.Point(403, 29);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(75, 59);
            this.ibtnThem.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnThem, "Thêm");
            this.ibtnThem.UseVisualStyleBackColor = true;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // frmADMIN_QLTAIKHOAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(993, 489);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmADMIN_QLTAIKHOAN";
            this.Text = "frmADMIN_QLTAIKHOAN";
            this.Load += new System.EventHandler(this.frmADMIN_QLTAIKHOAN_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmADMIN_QLTAIKHOAN_KeyDown);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgtaiKhoan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtgtaiKhoan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtmatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtloaiTaiKhoan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenTaiKhoan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttaiKhoan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private FontAwesome.Sharp.IconButton ibtnNext;
        private FontAwesome.Sharp.IconButton ibtnBack;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}