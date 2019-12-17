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
    public partial class REPORTDASHBOARD : Form
    {
        public REPORTDASHBOARD()
        {
            InitializeComponent();
        }

        private void CreateReportButton_Click(object sender, EventArgs e)
        {
            var CREATEREPORT = new CREATEREPORTFORM();
            CREATEREPORT.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
