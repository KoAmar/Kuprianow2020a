﻿using System;
using System.Windows.Forms;
using lab_6.Forms;

namespace lab_6
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
    }
}