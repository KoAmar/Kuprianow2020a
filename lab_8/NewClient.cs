using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace lab_8
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void auditLogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            auditLogBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);

        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            this.administratorsTableAdapter.Fill(this.hotelDBDataSet.Administrators);
            this.auditLogTableAdapter.Fill(this.hotelDBDataSet.AuditLog);
            this.administratorsTableAdapter.Fill(this.hotelDBDataSet.Administrators);



            //auditLogTableAdapter.Fill(hotelDBDataSet.AuditLog);
            //var query = from a in hotelDBDataSet.AuditLog
            //            orderby a.Id
            //            select a;
            //foreach (var row in query)
            //{
            //    Console.WriteLine($@"{row.Id} {row.AdministratorId}");
            //}
            //dataGridView1.DataSource = hotelDBDataSet.AuditLog;
            //DataTable dt = hotelDBDataSet.AuditLog;

            //var newRow = dt.NewRow();

            //newRow[1] = 1;
            //dateTimePicker1.Value = DateTime.Today;
            //newRow[2] = DateTime.Today.AddDays(-5);
            //dateTimePicker2.Value = DateTime.Today.AddDays(10);
            //newRow[3] = DateTime.Today.AddDays(10);
            //newRow[4] = DateTime.Now;
            //newRow[5] = 4;
            //newRow[6] = 1;

            //dt.Rows.Add(newRow);

            ////auditLogTableAdapter.Update(hotelDBDataSet.AuditLog);
            //hotelDBDataSet.Clear();



        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker2.Value.ToShortDateString());
            MessageBox.Show(comboBox1.SelectedValue.ToString());
        }
    }
}
