using System;
using System.Data;
using System.Windows.Forms;

namespace lab_8.NewCreator
{
    public partial class NewClient : Form
    {
        public NewClient()
        {
            InitializeComponent();
        }

        private void NewClient_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            this.languagesTableAdapter.Fill(this.hotelDBDataSet.Languages);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDBDataSet.Clients);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = hotelDBDataSet.Clients;
            var newRow = dt.NewRow();

            newRow[1] = nameTextBox.Text;
            newRow[2] = surnameTextBox.Text;
            newRow[3] = patronymicTextBox.Text;
            newRow[4] = discountPercentageTextBox.Text;
            newRow[5] = comboBox1.SelectedValue;

            dt.Rows.Add(newRow);

            clientsTableAdapter.Update(hotelDBDataSet.Clients);
            hotelDBDataSet.Clear();
            MessageBox.Show(@"Клиент зарегистрирован");
            this.Close();
        }
    }
}
