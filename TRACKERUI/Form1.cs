using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TRACKERUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void interReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.interReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rEPORTSSQLDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rEPORTSSQLDataSet.InterReportTable' table. You can move, or remove it, as needed.
            this.interReportTableTableAdapter.Fill(this.rEPORTSSQLDataSet.InterReportTable);

        }
    }
}
