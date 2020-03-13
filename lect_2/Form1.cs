using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.AuditLog' table. You can move, or remove it, as needed.
            this.auditLogTableAdapter.Fill(this.hotelDBDataSet.AuditLog);
            const string connectionString = "Data Source=PORTABLE-LAPTOP;Initial Catalog=HotelDB;" +
                                            "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                                            "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                                            "MultiSubnetFailover=False";
            var sqlString = "select * from AuditLog";
            var dataAdapter = new SqlDataAdapter(sqlString, connectionString);
            var dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}