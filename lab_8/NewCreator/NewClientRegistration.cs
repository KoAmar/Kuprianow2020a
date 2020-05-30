using System;
using System.Data;
using System.Windows.Forms;

namespace lab_8
{
    public partial class NewClientRegistration : Form
    {
        public NewClientRegistration()
        {
            InitializeComponent();
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            this.roomsTableAdapter.Fill(this.hotelDBDataSet.Rooms);
            this.clientsTableAdapter.Fill(this.hotelDBDataSet.Clients);
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



            dateTimePicker1.Value = DateTime.Today;
            dateTimePicker2.Value = DateTime.Today.AddDays(10);




        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = hotelDBDataSet.AuditLog;
            var newRow = dt.NewRow();

            newRow[1] = comboBox1.SelectedValue;
            newRow[2] = dateTimePicker1.Value;
            newRow[3] = dateTimePicker2.Value;
            newRow[4] = DateTime.Now;
            newRow[5] = comboBox2.SelectedValue;
            newRow[6] = comboBox3.SelectedValue;

            dt.Rows.Add(newRow);

            auditLogTableAdapter.Update(hotelDBDataSet.AuditLog);
            hotelDBDataSet.Clear();
            MessageBox.Show(@"Клиент зарегистрирован");
            this.Close();
        }
    }
}
