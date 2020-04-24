using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lab_4
{
    public partial class Lab4Form : Form
    {
        private const string ConnectionString = "Data Source=PORTABLE-LAPTOP;" +
                                                "Initial Catalog=HotelDB;" +
                                                "Integrated Security=True";

        public Lab4Form()
        {
            InitializeComponent();
        }

        private void page1_btRead_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);
            const string cmd = "SELECT TOP 5 * FROM Clients";
            var adapter = new SqlDataAdapter(cmd, con);

            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Clients");

            dataGridView1.DataSource = dataSet.Tables["Clients"];

            var view2 = new DataView(dataSet.Tables["Clients"]) {Sort = "Name"};
            dataGridView2.DataSource = view2;

            var view3 = new DataView(dataSet.Tables["Clients"]) {Sort = "Id"};
            dataGridView3.DataSource = view3;
        }

        private void page2_btRead_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);

            const string cmd = "SELECT * FROM Clients";
            var adapter = new SqlDataAdapter(cmd, con);

            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Clients");

            var rowFilter = string.Empty;

            var item1 = listBox1.SelectedItem;
            var item2 = listBox2.SelectedItem;

            if (item1 != null) rowFilter += $"({item1})";

            if (item2 != null)
            {
                if (item1 != null) rowFilter += " and ";
                rowFilter += $"({item2})";
            }

            var view1 = new DataView(dataSet.Tables["Clients"])
            {
                RowFilter = rowFilter
            };
            dataGridView4.DataSource = view1;
        }

        private void page3_btRead_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);

            const string cmd = "SELECT * FROM Clients";

            var adapter = new SqlDataAdapter(cmd, con);
            var dataSet = new DataSet();
            adapter.Fill(dataSet, "Clients");

            var fullName = new DataColumn(
                "FullName", typeof(string), "Name+' '+Surname+' '+Patronymic");

            dataSet.Tables["Clients"].Columns.Add(fullName);

            dataGridView5.DataSource = dataSet.Tables["Clients"];
        }
    }
}