using System;
using System.Data;
using System.Windows.Forms;

namespace lab_8.NewCreator
{
    public partial class NewAdmin : Form
    {
        public NewAdmin()
        {
            InitializeComponent();
        }

        private void NewAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Administrators' table. You can move, or remove it, as needed.
            this.administratorsTableAdapter.Fill(this.hotelDBDataSet.Administrators);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = hotelDBDataSet.Administrators;
            var newRow = dt.NewRow();

            newRow[1] = nameTextBox.Text;
            newRow[2] = surnameTextBox.Text;
            newRow[3] = patronymicTextBox.Text;

            dt.Rows.Add(newRow);

            administratorsTableAdapter.Update(hotelDBDataSet.Administrators);
            hotelDBDataSet.Clear();
            MessageBox.Show(@"Администратор зарегистрирован");
            this.Close();
        }
    }
}
