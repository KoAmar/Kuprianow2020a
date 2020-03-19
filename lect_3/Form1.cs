using System;
using System.Data;
using System.Windows.Forms;

namespace lect_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var ds = new DataSet();
            var tabPersons = ds.Tables.Add("Positions");
            var idPersons = tabPersons.Columns.Add("PersonId", typeof(int));
            idPersons.AllowDBNull = false;
            idPersons.Unique = true;
            var lastNameName = tabPersons.Columns.Add("LastName", typeof(string));
            //var taxCol = workTab.C

        }
    }
}
