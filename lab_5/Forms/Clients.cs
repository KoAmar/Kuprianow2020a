using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5.Forms
{
    public partial class Clients : Form
    {
        public Clients()
        {
            InitializeComponent();
        }

        private void clientsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientsBindingSource.EndEdit();
            var scb = new SqlCommandBuilder(clientsTableAdapter.Adapter);
            clientsTableAdapter.Update(hotelDBDataSet);
            //this.clientsTableAdapter.Update(hotelDBDataSet.Clients);
            //this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDBDataSet.Clients);

        }
    }
}
