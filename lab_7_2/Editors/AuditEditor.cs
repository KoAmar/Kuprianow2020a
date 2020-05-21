using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_7_2.Editors
{
    public partial class AuditEditor : Form
    {
        public AuditEditor()
        {
            InitializeComponent();
        }

        private void auditLogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.auditLogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void auditLogBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.auditLogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void AuditEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Rooms' table. You can move, or remove it, as needed.
            this.roomsTableAdapter.Fill(this.hotelDBDataSet.Rooms);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Clients' table. You can move, or remove it, as needed.
            this.clientsTableAdapter.Fill(this.hotelDBDataSet.Clients);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Administrators' table. You can move, or remove it, as needed.
            this.administratorsTableAdapter.Fill(this.hotelDBDataSet.Administrators);
            // TODO: This line of code loads data into the 'hotelDBDataSet.AuditLog' table. You can move, or remove it, as needed.
            this.auditLogTableAdapter.Fill(this.hotelDBDataSet.AuditLog);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new AdminsEditor();
            form.ShowDialog();
            this.administratorsTableAdapter.Fill(this.hotelDBDataSet.Administrators);
            this.Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var form = new ClientsEditor();
            form.ShowDialog();
            this.clientsTableAdapter.Fill(this.hotelDBDataSet.Clients);
            this.Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var form = new RoomsEditor();
            form.ShowDialog();
            this.roomsTableAdapter.Fill(this.hotelDBDataSet.Rooms);
            this.Refresh();
        }
    }
}
