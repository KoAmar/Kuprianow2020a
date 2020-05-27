using System;
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
            administratorsTableAdapter.Fill(hotelDBDataSet.Administrators);
            auditReportTableAdapter.Fill(hotelDBDataSet.AuditReport);

            dateTimePicker1.Value = DateTime.Today.AddMonths(-3);
            dateTimePicker2.Value = DateTime.Today.AddMonths(3);

            reportViewer1.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value > dateTimePicker2.Value)
            {
                MessageBox.Show(@"Дата выезда не может быть раньше даты въезда!");
            }
            var date1 = dateTimePicker1.Value;
            var date2 = dateTimePicker2.Value;

            //MessageBox.Show($@"{date1.Year}-{date1.Month}-{date1.Day}");

            auditReportTableAdapter.FillBy(hotelDBDataSet.AuditReport,
                    comboBox1.Text,
                    $@"{date1.Year}-{date1.Month}-{date1.Day}",
                    $@"{date2.Year}-{date2.Month}-{date2.Day}"
                    );
            reportViewer1.RefreshReport();
        }
    }
}
