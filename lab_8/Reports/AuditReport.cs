using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_8.Reports
{
    public partial class AuditReport : Form
    {
        public AuditReport()
        {
            InitializeComponent();
        }

        private void AuditReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.AuditReport' table. You can move, or remove it, as needed.
            this.auditReportTableAdapter.Fill(this.hotelDBDataSet.AuditReport);

            this.reportViewer1.RefreshReport();
        }
    }
}
