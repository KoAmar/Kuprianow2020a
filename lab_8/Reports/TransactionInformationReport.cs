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
    public partial class TransactionInformationReport : Form
    {
        public TransactionInformationReport()
        {
            InitializeComponent();
        }

        private void TransactionInformationReport_Load(object sender, EventArgs e)
        {
            this.megaAuditTableAdapter.FillBy(this.hotelDBDataSet.MegaAudit,Properties.Settings.Default.InfoId);

            this.reportViewer1.RefreshReport();
        }
    }
}
