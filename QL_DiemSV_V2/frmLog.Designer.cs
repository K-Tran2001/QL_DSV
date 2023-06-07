namespace QL_DiemSV_V2
{
    partial class frmLog
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
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.ibtnBrowse = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // txtLog
            // 
            this.txtLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtLog.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.Location = new System.Drawing.Point(0, 82);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtLog.Size = new System.Drawing.Size(800, 368);
            this.txtLog.TabIndex = 0;
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(12, 45);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(470, 20);
            this.txtPath.TabIndex = 0;
            // 
            // ibtnBrowse
            // 
            this.ibtnBrowse.IconChar = FontAwesome.Sharp.IconChar.None;
            this.ibtnBrowse.IconColor = System.Drawing.Color.Black;
            this.ibtnBrowse.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBrowse.Location = new System.Drawing.Point(500, 43);
            this.ibtnBrowse.Name = "ibtnBrowse";
            this.ibtnBrowse.Size = new System.Drawing.Size(75, 23);
            this.ibtnBrowse.TabIndex = 1;
            this.ibtnBrowse.Text = "Chọn file";
            this.ibtnBrowse.UseVisualStyleBackColor = true;
            this.ibtnBrowse.Click += new System.EventHandler(this.ibtnBrowse_Click);
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ibtnBrowse);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.txtLog);
            this.Name = "frmLog";
            this.Text = "frmLog";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtPath;
        private FontAwesome.Sharp.IconButton ibtnBrowse;
    }
}