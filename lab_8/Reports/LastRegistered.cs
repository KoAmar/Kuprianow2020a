using System;
using System.Windows.Forms;

namespace lab_8.Reports
{
    public partial class LastRegistered : Form
    {
        public LastRegistered()
        {
            InitializeComponent();
        }

        private void TransactionReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.LastRegisteredClient' table. You can move, or remove it, as needed.
            this.lastRegisteredClientTableAdapter.Fill(this.hotelDBDataSet.LastRegisteredClient);
            lastRegisteredClientTableAdapter.Fill(hotelDBDataSet.LastRegisteredClient);

            //var row = hotelDBDataSet.LastRegisteredClient.Rows[0].ItemArray;

            //var aSurname = new ReportParameter("aSurname", row[2].ToString());
            //var aName = new ReportParameter("aName", row[3].ToString());
            //var aPatronymic = new ReportParameter("aPatronymic", row[4].ToString());

            //reportViewer1.LocalReport.SetParameters(new[] { aSurname, aName, aPatronymic });
            reportViewer1.RefreshReport();
        }
        //private void reportDrivers_Load(object sender, EventArgs e)
        //{
        //    string strFIO;
        //        //strFIO=main.txtText.Text;
        //        var row = main.driversDataGridView.CurrentRow.Cells;
        //        strFIO = row["columnName"].Value.ToString() + row["columnSurname"].Value.ToString() + row["columnFatherName"].Value.ToString();

        //        var pFio = new ReportParameter("pFIO", strFIO);
        //        reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pFio });

        //    this.reportViewer1.RefreshReport();
        //}
    }
}
