using lab_8.Editors;
using System;
using System.Windows.Forms;

namespace lab_8.Tables
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            clientsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            languagesTableAdapter.Fill(hotelDBDataSet.Languages);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Clients' table. You can move, or remove it, as needed.
            clientsTableAdapter.Fill(hotelDBDataSet.Clients);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new LanguageEditor();
            form.ShowDialog();
            languagesTableAdapter.Fill(hotelDBDataSet.Languages);
            Refresh();
        }
    }
}