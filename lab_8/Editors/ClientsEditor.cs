using System;
using System.Windows.Forms;

namespace lab_8.Editors
{
    public partial class ClientsEditor : Form
    {
        public ClientsEditor()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            clientsBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void ClientsEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            languagesTableAdapter.Fill(hotelDBDataSet.Languages);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            languagesTableAdapter.Fill(hotelDBDataSet.Languages);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Clients' table. You can move, or remove it, as needed.
            clientsTableAdapter.Fill(hotelDBDataSet.Clients);
        }
    }
}