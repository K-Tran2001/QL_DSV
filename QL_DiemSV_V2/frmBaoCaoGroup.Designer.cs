namespace QL_DiemSV_V2
{
    partial class frmBaoCaoGroup
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.KQHT_HK_SelectBymaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DS_Diem_Lop_GroupRpt = new QL_DiemSV_V2.DS_Diem_Lop_GroupRpt();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.KQHT_HK_SelectBymaLopTableAdapter = new QL_DiemSV_V2.DS_Diem_Lop_GroupRptTableAdapters.KQHT_HK_SelectBymaLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.KQHT_HK_SelectBymaLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Diem_Lop_GroupRpt)).BeginInit();
            this.SuspendLayout();
            // 
            // KQHT_HK_SelectBymaLopBindingSource
            // 
            this.KQHT_HK_SelectBymaLopBindingSource.DataMember = "KQHT_HK_SelectBymaLop";
            this.KQHT_HK_SelectBymaLopBindingSource.DataSource = this.DS_Diem_Lop_GroupRpt;
            // 
            // DS_Diem_Lop_GroupRpt
            // 
            this.DS_Diem_Lop_GroupRpt.DataSetName = "DS_Diem_Lop_GroupRpt";
            this.DS_Diem_Lop_GroupRpt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(24, 13);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 21);
            this.cboLop.TabIndex = 0;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.KQHT_HK_SelectBymaLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_DiemSV_V2.Report_Diem_Lop_Gr_Rpt.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 52);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1133, 450);
            this.reportViewer1.TabIndex = 1;
            // 
            // KQHT_HK_SelectBymaLopTableAdapter
            // 
            this.KQHT_HK_SelectBymaLopTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCaoGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 501);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboLop);
            this.Name = "frmBaoCaoGroup";
            this.Text = "frmBaoCaoGroup";
            this.Load += new System.EventHandler(this.frmBaoCaoGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.KQHT_HK_SelectBymaLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DS_Diem_Lop_GroupRpt)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLop;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource KQHT_HK_SelectBymaLopBindingSource;
        private DS_Diem_Lop_GroupRpt DS_Diem_Lop_GroupRpt;
        private DS_Diem_Lop_GroupRptTableAdapters.KQHT_HK_SelectBymaLopTableAdapter KQHT_HK_SelectBymaLopTableAdapter;
    }
}