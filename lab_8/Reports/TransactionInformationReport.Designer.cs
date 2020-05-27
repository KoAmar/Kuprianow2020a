namespace lab_8.Reports
{
    partial class TransactionInformationReport
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
            this.megaAuditBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDBDataSet = new lab_8.HotelDBDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.megaAuditTableAdapter = new lab_8.HotelDBDataSetTableAdapters.MegaAuditTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.megaAuditBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // megaAuditBindingSource
            // 
            this.megaAuditBindingSource.DataMember = "MegaAudit";
            this.megaAuditBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "MainDS";
            reportDataSource1.Value = this.megaAuditBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "lab_8.Reports.TransactionInformationReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(647, 619);
            this.reportViewer1.TabIndex = 0;
            // 
            // megaAuditTableAdapter
            // 
            this.megaAuditTableAdapter.ClearBeforeFill = true;
            // 
            // TransactionInformationReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 619);
            this.Controls.Add(this.reportViewer1);
            this.Name = "TransactionInformationReport";
            this.Text = "TransactionInformationReport";
            this.Load += new System.EventHandler(this.TransactionInformationReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.megaAuditBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource megaAuditBindingSource;
        private HotelDBDataSetTableAdapters.MegaAuditTableAdapter megaAuditTableAdapter;
    }
}