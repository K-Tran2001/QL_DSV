namespace QL_DiemSV_V2
{
    partial class frmBAOMATTK
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmKMoi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmKMoi_NhapLai = new System.Windows.Forms.TextBox();
            this.labtK = new System.Windows.Forms.Label();
            this.ibtndoiMK = new FontAwesome.Sharp.IconButton();
            this.ibtnThoat = new FontAwesome.Sharp.IconButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.chk_hienMK = new System.Windows.Forms.CheckBox();
            this.ibtn_hienMK2 = new FontAwesome.Sharp.IconButton();
            this.ibtn_hienMK1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(134, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài khoản";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(106, 289);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 19);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mật khẩu mới";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmKMoi
            // 
            this.txtmKMoi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmKMoi.ForeColor = System.Drawing.Color.Teal;
            this.txtmKMoi.Location = new System.Drawing.Point(233, 286);
            this.txtmKMoi.Name = "txtmKMoi";
            this.txtmKMoi.Size = new System.Drawing.Size(198, 26);
            this.txtmKMoi.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(50, 343);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 19);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nhập lại mật khẩu mới";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmKMoi_NhapLai
            // 
            this.txtmKMoi_NhapLai.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmKMoi_NhapLai.ForeColor = System.Drawing.Color.Teal;
            this.txtmKMoi_NhapLai.Location = new System.Drawing.Point(233, 340);
            this.txtmKMoi_NhapLai.Name = "txtmKMoi_NhapLai";
            this.txtmKMoi_NhapLai.Size = new System.Drawing.Size(198, 26);
            this.txtmKMoi_NhapLai.TabIndex = 1;
            // 
            // labtK
            // 
            this.labtK.AutoSize = true;
            this.labtK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labtK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labtK.Location = new System.Drawing.Point(247, 240);
            this.labtK.Name = "labtK";
            this.labtK.Size = new System.Drawing.Size(52, 19);
            this.labtK.TabIndex = 2;
            this.labtK.Text = "NULL";
            // 
            // ibtndoiMK
            // 
            this.ibtndoiMK.FlatAppearance.BorderSize = 0;
            this.ibtndoiMK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtndoiMK.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.ibtndoiMK.IconColor = System.Drawing.Color.Black;
            this.ibtndoiMK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtndoiMK.Location = new System.Drawing.Point(453, 251);
            this.ibtndoiMK.Name = "ibtndoiMK";
            this.ibtndoiMK.Size = new System.Drawing.Size(75, 65);
            this.ibtndoiMK.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtndoiMK, "Đỏi mật khẩu");
            this.ibtndoiMK.UseVisualStyleBackColor = true;
            this.ibtndoiMK.Click += new System.EventHandler(this.ibtndoiMK_Click);
            // 
            // ibtnThoat
            // 
            this.ibtnThoat.FlatAppearance.BorderSize = 0;
            this.ibtnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnThoat.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.ibtnThoat.IconColor = System.Drawing.Color.Black;
            this.ibtnThoat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnThoat.Location = new System.Drawing.Point(453, 321);
            this.ibtnThoat.Name = "ibtnThoat";
            this.ibtnThoat.Size = new System.Drawing.Size(75, 65);
            this.ibtnThoat.TabIndex = 9;
            this.toolTip1.SetToolTip(this.ibtnThoat, "Thoát");
            this.ibtnThoat.UseVisualStyleBackColor = true;
            this.ibtnThoat.Click += new System.EventHandler(this.ibtnThoat_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QL_DiemSV_V2.Properties.Resources.persona;
            this.pictureBox1.Location = new System.Drawing.Point(72, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(484, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // chk_hienMK
            // 
            this.chk_hienMK.AutoSize = true;
            this.chk_hienMK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chk_hienMK.Location = new System.Drawing.Point(198, 394);
            this.chk_hienMK.Name = "chk_hienMK";
            this.chk_hienMK.Size = new System.Drawing.Size(115, 23);
            this.chk_hienMK.TabIndex = 5;
            this.chk_hienMK.Text = "Hiện mật khẩu";
            this.chk_hienMK.UseVisualStyleBackColor = true;
            this.chk_hienMK.CheckedChanged += new System.EventHandler(this.chk_hienMK_CheckedChanged);
            // 
            // ibtn_hienMK2
            // 
            this.ibtn_hienMK2.BackColor = System.Drawing.Color.White;
            this.ibtn_hienMK2.FlatAppearance.BorderSize = 0;
            this.ibtn_hienMK2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_hienMK2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ibtn_hienMK2.IconColor = System.Drawing.Color.Black;
            this.ibtn_hienMK2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_hienMK2.IconSize = 20;
            this.ibtn_hienMK2.Location = new System.Drawing.Point(400, 344);
            this.ibtn_hienMK2.Name = "ibtn_hienMK2";
            this.ibtn_hienMK2.Size = new System.Drawing.Size(29, 19);
            this.ibtn_hienMK2.TabIndex = 6;
            this.ibtn_hienMK2.UseVisualStyleBackColor = false;
            // 
            // ibtn_hienMK1
            // 
            this.ibtn_hienMK1.BackColor = System.Drawing.Color.White;
            this.ibtn_hienMK1.FlatAppearance.BorderSize = 0;
            this.ibtn_hienMK1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtn_hienMK1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.ibtn_hienMK1.IconColor = System.Drawing.Color.Black;
            this.ibtn_hienMK1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtn_hienMK1.IconSize = 20;
            this.ibtn_hienMK1.Location = new System.Drawing.Point(400, 290);
            this.ibtn_hienMK1.Name = "ibtn_hienMK1";
            this.ibtn_hienMK1.Size = new System.Drawing.Size(29, 19);
            this.ibtn_hienMK1.TabIndex = 6;
            this.ibtn_hienMK1.UseVisualStyleBackColor = false;
            // 
            // frmBAOMATTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.ibtn_hienMK1);
            this.Controls.Add(this.ibtn_hienMK2);
            this.Controls.Add(this.chk_hienMK);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ibtnThoat);
            this.Controls.Add(this.ibtndoiMK);
            this.Controls.Add(this.labtK);
            this.Controls.Add(this.txtmKMoi_NhapLai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmKMoi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmBAOMATTK";
            this.Text = "frmSINHVIEN_BaoMatTK";
            this.Load += new System.EventHandler(this.frmBAOMATTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmKMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmKMoi_NhapLai;
        private System.Windows.Forms.Label labtK;
        private FontAwesome.Sharp.IconButton ibtndoiMK;
        private FontAwesome.Sharp.IconButton ibtnThoat;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox chk_hienMK;
        private FontAwesome.Sharp.IconButton ibtn_hienMK2;
        private FontAwesome.Sharp.IconButton ibtn_hienMK1;
    }
}