using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_5.Forms
{
    public partial class AuditForm1 : Form
    {
        public AuditForm1()
        {
            InitializeComponent();
        }

        private void auditLogBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.auditLogBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.hotelDBDataSet);

        }

        private void AuditForm1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelDBDataSet.AuditLog' table. You can move, or remove it, as needed.
            this.auditLogTableAdapter.Fill(this.hotelDBDataSet.AuditLog);

        }
    }
}
