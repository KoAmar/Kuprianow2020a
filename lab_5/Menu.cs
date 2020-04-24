using System;
using System.Windows.Forms;
using lab_5.Forms;

namespace lab_5
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void AuditBt_Click(object sender, EventArgs e)
        {
            var form = new AuditForm1();
            form.ShowDialog(this);
        }

        private void AdminsBt_Click(object sender, EventArgs e)
        {
            var form = new AdminsForm();
            form.ShowDialog(this);
        }

        private void ClientsBt_Click(object sender, EventArgs e)
        {
            var form = new Clients();
            form.ShowDialog(this);
        }

        private void RoomsBt_Click(object sender, EventArgs e)
        {
            var form = new RoomsForm();
            form.ShowDialog(this);
        }

        private void LangBt_Click(object sender, EventArgs e)
        {
            var form = new LangForm();
            form.ShowDialog(this);
        }
    }
}