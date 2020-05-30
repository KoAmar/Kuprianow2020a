using lab_8.Editors;
using lab_8.NewCreator;
using lab_8.Reports;
using lab_8.Tables;
using System;
using System.Windows.Forms;

namespace lab_8
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AuditBt_Click(object sender, EventArgs e)
        {
            var form = new Audit();
            form.ShowDialog(this);
        }

        private void AdminsBt_Click(object sender, EventArgs e)
        {
            var form = new Admins();
            form.ShowDialog(this);
        }

        private void ClientsBt_Click(object sender, EventArgs e)
        {
            var form = new Clients();
            form.ShowDialog(this);
        }

        private void RoomsBt_Click(object sender, EventArgs e)
        {
            var form = new Rooms();
            form.ShowDialog(this);
        }

        private void LangBt_Click(object sender, EventArgs e)
        {
            var form = new Language();
            form.ShowDialog(this);
        }

        private void AuditEditorBt_Click(object sender, EventArgs e)
        {
            var form = new AuditEditor();
            form.ShowDialog(this);
        }

        private void AddAuditRecordBt_Click(object sender, EventArgs e)
        {
            var form = new NewClientRegistration();
            form.ShowDialog(this);
        }

        private void AddAdminBt_Click(object sender, EventArgs e)
        {
            var form = new NewAdmin();
            form.ShowDialog(this);
        }

        private void AddClientBt_Click(object sender, EventArgs e)
        {
            var form = new NewClient();
            form.ShowDialog(this);
        }

        private void AddRoomBt_Click(object sender, EventArgs e)
        {
            var form = new NewRoom();
            form.ShowDialog(this);
        }

        private void LastClientPrintBt_Click(object sender, EventArgs e)
        {
            var form = new LastRegistered();
            form.ShowDialog(this);
        }

        private void ClientsInRoomsBt_Click(object sender, EventArgs e)
        {
            var form = new ClientRoomLang();
            form.ShowDialog(this);
        }

        private void AuditLogPrintBt_Click(object sender, EventArgs e)
        {
            var form = new AuditReport();
            form.ShowDialog(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var form = new NewLang();
            form.ShowDialog(this);

        }
    }
}