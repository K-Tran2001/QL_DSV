namespace QL_DiemSV_V2
{
    partial class frmLoad
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
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pgQT = new System.Windows.Forms.ProgressBar();
            this.labQT = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pgQT
            // 
            this.pgQT.Location = new System.Drawing.Point(62, 142);
            this.pgQT.Name = "pgQT";
            this.pgQT.Size = new System.Drawing.Size(294, 23);
            this.pgQT.TabIndex = 0;
            // 
            // labQT
            // 
            this.labQT.AutoSize = true;
            this.labQT.Location = new System.Drawing.Point(186, 198);
            this.labQT.Name = "labQT";
            this.labQT.Size = new System.Drawing.Size(35, 13);
            this.labQT.TabIndex = 1;
            this.labQT.Text = "label1";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(62, 82);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(78, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "button1";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // frmLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 242);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.labQT);
            this.Controls.Add(this.pgQT);
            this.Name = "frmLoad";
            this.Text = "frmLoad";
            this.Load += new System.EventHandler(this.frmLoad_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar pgQT;
        private System.Windows.Forms.Label labQT;
        private System.Windows.Forms.Button btnLoad;
    }
}