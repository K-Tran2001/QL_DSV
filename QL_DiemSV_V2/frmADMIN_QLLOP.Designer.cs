namespace QL_DiemSV_V2
{
    partial class frmADMIN_QLLOP
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
            this.cbomaGV = new System.Windows.Forms.ComboBox();
            this.datengayKhaiGiang = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txttenLop = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmaLop = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgLop = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ibtnThem = new FontAwesome.Sharp.IconButton();
            this.ibtnNext = new FontAwesome.Sharp.IconButton();
            this.ibtnBack = new FontAwesome.Sharp.IconButton();
            this.ibtnXoa = new FontAwesome.Sharp.IconButton();
            this.ibtnLuu = new FontAwesome.Sharp.IconButton();
            this.ibtnSua = new FontAwesome.Sharp.IconButton();
            this.ibtnRefesh = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLop)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbomaGV);
            this.groupBox1.Controls.Add(this.datengayKhaiGiang);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txttenLop);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtmaLop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Blue;
            this.groupBox1.Location = new System.Drawing.Point(672, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 336);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin giáo viên";
            // 
            // cbomaGV
            // 
            this.cbomaGV.ForeColor = System.Drawing.Color.Teal;
            this.cbomaGV.FormattingEnabled = true;
            this.cbomaGV.Location = new System.Drawing.Point(150, 215);
            this.cbomaGV.Name = "cbomaGV";
            this.cbomaGV.Size = new System.Drawing.Size(166, 27);
            this.cbomaGV.TabIndex = 3;
            // 
            // datengayKhaiGiang
            // 
            this.datengayKhaiGiang.Location = new System.Drawing.Point(150, 148);
            this.datengayKhaiGiang.Name = "datengayKhaiGiang";
            this.datengayKhaiGiang.Size = new System.Drawing.Size(166, 26);
            this.datengayKhaiGiang.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(36, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã GV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày khai giảng";
            // 
            // txttenLop
            // 
            this.txttenLop.ForeColor = System.Drawing.Color.Teal;
            this.txttenLop.Location = new System.Drawing.Point(150, 106);
            this.txttenLop.Name = "txttenLop";
            this.txttenLop.Size = new System.Drawing.Size(166, 26);
            this.txttenLop.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(36, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên lớp:";
            // 
            // txtmaLop
            // 
            this.txtmaLop.ForeColor = System.Drawing.Color.Teal;
            this.txtmaLop.Location = new System.Drawing.Point(150, 53);
            this.txtmaLop.Name = "txtmaLop";
            this.txtmaLop.Size = new System.Drawing.Size(166, 26);
            this.txtmaLop.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(36, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã lớp:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtgLop);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Blue;
            this.groupBox2.Location = new System.Drawing.Point(100, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(508, 355);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách giáo viên";
            // 
            // dtgLop
            // 
            this.dtgLop.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgLop.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dtgLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLop.Location = new System.Drawing.Point(6, 19);
            this.dtgLop.Name = "dtgLop";
            this.dtgLop.Size = new System.Drawing.Size(489, 311);
            this.dtgLop.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ibtnThem);
            this.groupBox3.Controls.Add(this.ibtnNext);
            this.groupBox3.Controls.Add(this.ibtnBack);
            this.groupBox3.Controls.Add(this.ibtnXoa);
            this.groupBox3.Controls.Add(this.ibtnLuu);
            this.groupBox3.Controls.Add(this.ibtnSua);
            this.groupBox3.Controls.Add(this.ibtnRefesh);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Blue;
            this.groupBox3.Location = new System.Drawing.Point(70, 387);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 119);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bảng điều khiển";
            // 
            // ibtnThem
            // 
            this.ibtnThem.FlatAppearance.BorderSize = 0;
            this.ibtnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.ibtnThem.IconColor = System.Drawing.Color.Black;
            this.ibtnThem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThem.Location = new System.Drawing.Point(324, 36);
            this.ibtnThem.Name = "ibtnThem";
            this.ibtnThem.Size = new System.Drawing.Size(75, 61);
            this.ibtnThem.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnThem, "Thêm");
            this.ibtnThem.UseVisualStyleBackColor = true;
            this.ibtnThem.Click += new System.EventHandler(this.ibtnThem_Click);
            // 
            // ibtnNext
            // 
            this.ibtnNext.FlatAppearance.BorderSize = 0;
            this.ibtnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnNext.IconChar = FontAwesome.Sharp.IconChar.RedoAlt;
            this.ibtnNext.IconColor = System.Drawing.Color.Black;
            this.ibtnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnNext.Location = new System.Drawing.Point(100, 36);
            this.ibtnNext.Name = "ibtnNext";
            this.ibtnNext.Size = new System.Drawing.Size(75, 61);
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
            this.ibtnBack.Location = new System.Drawing.Point(19, 36);
            this.ibtnBack.Name = "ibtnBack";
            this.ibtnBack.Size = new System.Drawing.Size(75, 61);
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
            this.ibtnXoa.Location = new System.Drawing.Point(752, 36);
            this.ibtnXoa.Name = "ibtnXoa";
            this.ibtnXoa.Size = new System.Drawing.Size(75, 61);
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
            this.ibtnLuu.Location = new System.Drawing.Point(590, 36);
            this.ibtnLuu.Name = "ibtnLuu";
            this.ibtnLuu.Size = new System.Drawing.Size(75, 61);
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
            this.ibtnSua.Location = new System.Drawing.Point(439, 36);
            this.ibtnSua.Name = "ibtnSua";
            this.ibtnSua.Size = new System.Drawing.Size(75, 61);
            this.ibtnSua.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnSua, "Sửa");
            this.ibtnSua.UseVisualStyleBackColor = true;
            this.ibtnSua.Click += new System.EventHandler(this.ibtnSua_Click);
            // 
            // ibtnRefesh
            // 
            this.ibtnRefesh.FlatAppearance.BorderSize = 0;
            this.ibtnRefesh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRefesh.IconChar = FontAwesome.Sharp.IconChar.SyncAlt;
            this.ibtnRefesh.IconColor = System.Drawing.Color.Black;
            this.ibtnRefesh.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRefesh.Location = new System.Drawing.Point(195, 36);
            this.ibtnRefesh.Name = "ibtnRefesh";
            this.ibtnRefesh.Size = new System.Drawing.Size(75, 61);
            this.ibtnRefesh.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnRefesh, "Thêm");
            this.ibtnRefesh.UseVisualStyleBackColor = true;
            this.ibtnRefesh.Click += new System.EventHandler(this.ibtnRefresh_Click);
            // 
            // frmADMIN_QLLOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1051, 578);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmADMIN_QLLOP";
            this.Text = "frmADMIN_QLLOP";
            this.Load += new System.EventHandler(this.frmADMIN_QLLOP_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmADMIN_QLLOP_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLop)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dtgLop;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txttenLop;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmaLop;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton ibtnXoa;
        private FontAwesome.Sharp.IconButton ibtnLuu;
        private FontAwesome.Sharp.IconButton ibtnSua;
        private FontAwesome.Sharp.IconButton ibtnRefesh;
        private System.Windows.Forms.ComboBox cbomaGV;
        private System.Windows.Forms.DateTimePicker datengayKhaiGiang;
        private FontAwesome.Sharp.IconButton ibtnNext;
        private FontAwesome.Sharp.IconButton ibtnBack;
        private FontAwesome.Sharp.IconButton ibtnThem;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}