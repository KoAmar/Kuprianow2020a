using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                var result = reader.GetValue(0) + " " + reader.GetValue(1) + " " + reader.GetValue(2) + " " + reader.GetValue(3);
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
            var countResult = (int)command.ExecuteScalar();

            label1.Text = @"Общее число клиентов: " + countResult;
            con.Close();

        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            var con = new SqlConnection(ConnectionString);

            // Создать команду для вызова хранимой процедуры InsertEmployee
            var cmd = new SqlCommand("InsertClients", con) { CommandType = CommandType.StoredProcedure };

            // Указать параметры
            cmd.Parameters.AddWithValue("@Name", "Vasia");
            cmd.Parameters.AddWithValue("@Surname", "Svistunov");
            // Последний параметр является выходным (output)
            cmd.Parameters.Add(new SqlParameter("@ClientId", SqlDbType.Int));
            cmd.Parameters["@ClientId"].Direction = ParameterDirection.Output;
            con.Open();
            try
            {
                var numAff = cmd.ExecuteNonQuery();
                label2.Text = @"ExecuteNonQuery result: " + numAff;

                // Получить вновь сгенерированный идентификатор
                var id = (int)cmd.Parameters["@ClientId"].Value;
                label3.Text = @"Новому сотруднику присвоен ID: " + id;
            }
            finally
            {
                con.Close();
            }
        }
    }
}

