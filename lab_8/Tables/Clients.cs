using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab_7_2.Editors;

namespace lab_7_2.Tables
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
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void Clients_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Languages' table. You can move, or remove it, as needed.
            this.languagesTableAdapter.Fill(this.hotelDBDataSet.Languages);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDBDataSet.Clients);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            var form = new LanguageEditor();
            form.ShowDialog();
            this.languagesTableAdapter.Fill(this.hotelDBDataSet.Languages);
            this.Refresh();
        }
    }
}
