using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.String;

namespace lab_2
{
    public partial class MainForm : Form
    {
        private const string ConnectionString = "Data Source=PORTABLE-LAPTOP;" +
                                                "Initial Catalog=HotelDB;" +
                                                "Integrated Security=True";

        public MainForm()
        {
            InitializeComponent();
        }

        private void btRead_Click(object sender, EventArgs e)
        {
            // Создание строки подключения
            var con = new SqlConnection(ConnectionString);

            // Создание команды
            var command = new SqlCommand
            {
                Connection = con,
                CommandType = CommandType.Text,
                CommandText = "SELECT * FROM Clients"
            };

            con.Open();
            var reader = command.ExecuteReader();
            // Проход в цикле по записям 
            while (reader.Read())
            {
                var result = "" +
                             $"{reader.GetValue(0),4} " +
                             $"{reader.GetValue(1),20} " +
                             $"{reader.GetValue(2),20} " +
                             $"{reader.GetValue(3),20} " +
                             $"{reader.GetValue(4),3} " +
                             $"{reader.GetValue(5)}";
                listBox1.Items.Add(result);
            }

            // Закрытие DataReader
            reader.Close();
        }

        private void btClean_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void btSum_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);
            // Создать команду
            var command = new SqlCommand("SELECT COUNT (*) FROM Clients", con);
            con.Open();
            // Получить значение COUNT
            var countResult = (int) command.ExecuteScalar();

            label1.Text = @"Общее число клиентов: " + countResult;
            con.Close();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);

            var cmd = new SqlCommand("InsertClients", con) {CommandType = CommandType.StoredProcedure};

            // Указать параметры
            cmd.Parameters.AddWithValue("@Name", IsNullOrEmpty(textBox1.Text) ? "Default" : textBox1.Text);
            cmd.Parameters.AddWithValue("@Surname", IsNullOrEmpty(textBox1.Text) ? "Client" : textBox2.Text);
            // Последний параметр является выходным (output)
            cmd.Parameters.Add(new SqlParameter("@ClientId", SqlDbType.Int));
            cmd.Parameters["@ClientId"].Direction = ParameterDirection.Output;
            con.Open();
            try
            {
                var numAff = cmd.ExecuteNonQuery();
                label2.Text = @"ExecuteNonQuery result: " + numAff;

                // Получить вновь сгенерированный идентификатор
                var id = (int) cmd.Parameters["@ClientId"].Value;
                label3.Text = @"Новому сотруднику присвоен ID: " + id;
            }
            finally
            {
                con.Close();
            }
        }
    }
}