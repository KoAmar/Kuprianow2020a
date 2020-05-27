using System;
using System.Windows.Forms;
using lab_8.Editors;
using lab_8.Reports;

namespace lab_8.Tables
{
    public partial class Audit : Form
    {
        public Audit()
        {
            InitializeComponent();
        }

        private void auditLogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();
            auditLogBindingSource.EndEdit();
            tableAdapterManager.UpdateAll(hotelDBDataSet);
        }

        private void Audit_Load(object sender, EventArgs e)
        {
            roomsTableAdapter.Fill(hotelDBDataSet.Rooms);
            clientsTableAdapter.Fill(hotelDBDataSet.Clients);
            administratorsTableAdapter.Fill(hotelDBDataSet.Administrators);
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

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var id = auditLogDataGridView.CurrentCell.RowIndex;
            
            Properties.Settings.Default.InfoId = (int)auditLogDataGridView.Rows[id].Cells[0].Value;
            Properties.Settings.Default.Save();  

            //MessageBox.Show(Properties.Settings.Default.InfoId.ToString());

            var form = new TransactionInformationReport();
            form.ShowDialog();
        }
    }
}