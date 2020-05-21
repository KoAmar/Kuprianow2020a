using System;
using System.Windows.Forms;

namespace lab_8.Editors
{
    public partial class AuditEditor : Form
    {
        public AuditEditor()
        {
            InitializeComponent();
        }

        private void auditLogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            auditLogBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void auditLogBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            Validate();
            auditLogBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void AuditEditor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.Rooms' table. You can move, or remove it, as needed.
            roomsTableAdapter.Fill(hotelDBDataSet.Rooms);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Clients' table. You can move, or remove it, as needed.
            clientsTableAdapter.Fill(hotelDBDataSet.Clients);
            // TODO: This line of code loads data into the 'hotelDBDataSet.Administrators' table. You can move, or remove it, as needed.
            administratorsTableAdapter.Fill(hotelDBDataSet.Administrators);
            // TODO: This line of code loads data into the 'hotelDBDataSet.AuditLog' table. You can move, or remove it, as needed.
            auditLogTableAdapter.Fill(hotelDBDataSet.AuditLog);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var form = new AdminsEditor();
            form.ShowDialog();
            administratorsTableAdapter.Fill(hotelDBDataSet.Administrators);
            Refresh();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            var form = new ClientsEditor();
            form.ShowDialog();
            clientsTableAdapter.Fill(hotelDBDataSet.Clients);
            Refresh();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var form = new RoomsEditor();
            form.ShowDialog();
            roomsTableAdapter.Fill(hotelDBDataSet.Rooms);
            Refresh();
        }
    }
}