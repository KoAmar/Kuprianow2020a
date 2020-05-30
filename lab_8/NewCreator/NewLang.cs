using System;
using System.Data;
using System.Windows.Forms;

namespace lab_8.NewCreator
{
    public partial class NewLang : Form
    {
        public NewLang()
        {
            InitializeComponent();
        }

        private void NewLang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            this.languagesTableAdapter.Fill(this.hotelDBDataSet.Languages);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = hotelDBDataSet.Languages;
            var newRow = dt.NewRow();

            newRow[1] = nameTextBox.Text;

            dt.Rows.Add(newRow);

            languagesTableAdapter.Update(hotelDBDataSet.Languages);
            hotelDBDataSet.Clear();
            MessageBox.Show(@"Язык зарегистрирован");
            this.Close();


        }
    }
}
