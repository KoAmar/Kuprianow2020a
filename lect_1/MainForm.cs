using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace lect_1
{
    public partial class MainForm : Form
    {
        private const string ConStr =
            "Data Source=PORTABLE-LAPTOP;Initial Catalog=BlogDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConStr);
            con.Open();
            var command = new SqlCommand
            {
                CommandText = "SELECT * FROM Posts",
                Connection = con
            };
            var reader = command.ExecuteReader();

            if (reader.HasRows) // если есть данные
            {
                // выводим названия столбцов
                var str1 = $@"{reader.GetName(0)}	{reader.GetName(1)}	{reader.GetName(2)}";

                Console.WriteLine(str1);
                listBox1.Items.Add(str1);

                while (reader.Read()) // построчно считываем данные
                {
                    var id = reader.GetValue(0);
                    var name = reader.GetValue(1);
                    var age = reader.GetValue(2);

                    var str2 = $@"{id} 	{name} 	{age}";

                    Console.WriteLine(str2);
                    listBox1.Items.Add(str2);
                }
            }

            reader.Close();
        }

        private void buttonClean_Click(object sender, EventArgs e)
        {
        }
    }
}