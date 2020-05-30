using System;
using System.Data;
using System.Windows.Forms;

namespace lab_8.NewCreator
{
    public partial class NewRoom : Form
    {
        public NewRoom()
        {
            InitializeComponent();
        }

        private void NewRoom_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelDBDataSet.Rooms);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = hotelDBDataSet.Rooms;
            var newRow = dt.NewRow();

            newRow[1] = numberTextBox.Text;
            newRow[2] = numberOfBedsTextBox.Text;
            newRow[3] = costOfNightTextBox.Text;

            dt.Rows.Add(newRow);

            roomsTableAdapter.Update(hotelDBDataSet.Rooms);
            hotelDBDataSet.Clear();
            MessageBox.Show(@"Комната зарегистрирована");
            this.Close();
        }
    }
}
