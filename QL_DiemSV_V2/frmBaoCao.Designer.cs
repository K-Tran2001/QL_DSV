namespace QL_DiemSV_V2
{
    partial class frmBaoCao
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
            this.SV_SelectBymaLopBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Ds_SV_Lop = new QL_DiemSV_V2.Ds_SV_Lop();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SV_SelectBymaLopTableAdapter = new QL_DiemSV_V2.Ds_SV_LopTableAdapters.SV_SelectBymaLopTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.SV_SelectBymaLopBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_SV_Lop)).BeginInit();
            this.SuspendLayout();
            // 
            // SV_SelectBymaLopBindingSource
            // 
            this.SV_SelectBymaLopBindingSource.DataMember = "SV_SelectBymaLop";
            this.SV_SelectBymaLopBindingSource.DataSource = this.Ds_SV_Lop;
            // 
            // Ds_SV_Lop
            // 
            this.Ds_SV_Lop.DataSetName = "Ds_SV_Lop";
            this.Ds_SV_Lop.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(33, 29);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 21);
            this.cboLop.TabIndex = 1;
            this.cboLop.SelectedIndexChanged += new System.EventHandler(this.cboLop_SelectedIndexChanged);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.SV_SelectBymaLopBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QL_DiemSV_V2.Report_SV_Lop.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 68);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1134, 433);
            this.reportViewer1.TabIndex = 2;
            // 
            // SV_SelectBymaLopTableAdapter
            // 
            this.SV_SelectBymaLopTableAdapter.ClearBeforeFill = true;
            // 
            // frmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 501);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.cboLop);
            this.Name = "frmBaoCao";
            this.Text = "frmBaoCao";
            this.Load += new System.EventHandler(this.frmBaoCao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SV_SelectBymaLopBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ds_SV_Lop)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cboLop;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource SV_SelectBymaLopBindingSource;
        private Ds_SV_Lop Ds_SV_Lop;
        private Ds_SV_LopTableAdapters.SV_SelectBymaLopTableAdapter SV_SelectBymaLopTableAdapter;
    }
}