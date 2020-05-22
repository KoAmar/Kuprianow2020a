using System;
using System.Windows.Forms;
using lab_8.Editors;
using lab_8.Tables;

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

        }

        private void AddClientBt_Click(object sender, EventArgs e)
        {

        }

        private void AddRoomBt_Click(object sender, EventArgs e)
        {

        }
    }
}