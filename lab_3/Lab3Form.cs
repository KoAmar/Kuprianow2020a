using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace lab_3
{
    public partial class Lab3Form : Form
    {
        private const string ConnectionString = "Data Source=PORTABLE-LAPTOP;" +
                                                "Initial Catalog=HotelDB;" +
                                                "Integrated Security=True";

        public Lab3Form()
        {
            InitializeComponent();
            listBox1.Font = new Font(FontFamily.GenericMonospace.ToString(), 10);
        }

        private void btFill_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);
            const string command = "SELECT * FROM Clients";
            var adapter = new SqlDataAdapter(command, con);

            var dataSet = new DataSet();

            adapter.Fill(dataSet, "Clients");
            listBox1.Items.Clear();

            foreach (DataRow row in dataSet.Tables["Clients"].Rows)
            {
                var result = "" +
                             $"{row[0]}:  " +
                             $"[{row[1]}]  " +
                             $"[{row[2]}]  " +
                             $"[{row[3]}]  " +
                             $"[{row[4]}]  " +
                             $"[{row[5]}]";
                listBox1.Items.Add(result);
            }
        }

        private void btProgramFill_Click(object sender, EventArgs e)
        {
            var hotelDataSet = new DataSet("Hotel");
            var clientsTable = new DataTable("Clients");

            hotelDataSet.Tables.Add(clientsTable);

            var idColumn = new DataColumn("Id", typeof(int))
            {
                Unique = true,
                AllowDBNull = false,
                AutoIncrement = true,
                AutoIncrementSeed = 1,
                AutoIncrementStep = 1
            };

            var nameColumn = new DataColumn("Name", typeof(string));
            var surnameColumn = new DataColumn("Surname", typeof(string));
            var discountColumn = new DataColumn("Discount", typeof(decimal))
            {
                DefaultValue = 0
            };

            clientsTable.Columns.Add(idColumn);
            clientsTable.Columns.Add(nameColumn);
            clientsTable.Columns.Add(surnameColumn);
            clientsTable.Columns.Add(discountColumn);

            clientsTable.PrimaryKey = new[] {clientsTable.Columns["Id"]};

            clientsTable.Rows.Add(null, "Накормите", "Студента", 25);
            clientsTable.Rows.Add(null, "Хотя", "Бы", 50);
            clientsTable.Rows.Add(null, "Котлетой", "...", 75);

            foreach (DataRow row in clientsTable.Rows)
            {
                var result = row.ItemArray
                    .Aggregate((current, cell) => current + $" [{cell}] ");
                listBox2.Items.Add(result);
            }
        }


        private void btAddClient_Click(object sender, EventArgs e)
        {
            DataTable clientsDataTable = hotelDBDataSet.Clients;
            var row = clientsDataTable.NewRow();
            row[1] = tbName.Text;
            row[2] = tbSurname.Text;
            row[3] = tbPatronymic.Text;
            row[4] = tbDiscount.Text;
            row[5] = 5;
            clientsDataTable.Rows.Add(row);
            clientsTableAdapter.Update(hotelDBDataSet.Clients);
        }

        private void btReadTable_Click(object sender, EventArgs e)
        {
            clientsTableAdapter.Fill(hotelDBDataSet.Clients);
        }
    }
}