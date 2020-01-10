using System;
using System.Windows.Forms;

namespace TRACKERUI
{
    public partial class REPORTVIEWERFORM : Form
    {
        public REPORTVIEWERFORM()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void BUGBEHAVIOR_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BUTTON_Click(object sender, EventArgs e)
        {
            //if (ValidateForm())
            //{
            //    REPORTMODEL2 F = new REPORTMODEL2();
            //    F.ReportName = ReportNameValue.Text;
            //    F.ReportID = ReportIDValue.Text;
            //    F.Severity = SeverityValue.Text;
            //    F.ReportStatus = ReportStatusValue.Text;
            //    F.Comments = CommentValue.Text;
            //    F.Details = DetailsValue.Text;
            //    F.BugBehavior = BugBehaviorValue.Text;
            //    F.Solutions = Solutionvalue.Text;
            //    F.FirstReported = DateFirstReportedValue.Value;
            //    F.FirstREPORTER = FirstReporterValue.Text;

            //    GlobalConfig2.Connection.CreateReport(F);
            //    ReportNameValue.Text = "";
            //    ReportIDValue.Text = "";
            //    SeverityValue.Text = "";
            //    ReportStatusValue.Text = "";
            //    CommentValue.Text = "";
            //    DetailsValue.Text = "";
            //    BugBehaviorValue.Text = "";
            //    Solutionvalue.Text = "";
            //    DateFirstReportedValue.Text = "";
            //    FirstReporterValue.Text = "";

            //}

            //else
            //{
            //    MessageBox.Show("This form has invalid information. " +
            //        "Please check your entries and try again");
            //}
        }
        private bool ValidateForm()
        {
            bool output = true;
            
            if (ReportNameValue.Text.Length == 0)
            {
                output = false;
            }
            
            if (ReportIDValue.Text.Length == 0)
            {
                output = false;
            }

            if (SeverityValue.Text.Length == 0)
            {
                output = false;
            }
            
            if (ReportStatusValue.Text.Length == 0)
            {
                output = false;
            }

            if (CommentValue.Text.Length == 0)
            {
                output = false;
            }

            if (DetailsValue.Text.Length == 0)
            {
                output = false;
            }
            if (BugBehaviorValue.Text.Length == 0)
            {
                output = false;
            }
            if (DateFirstReportedValue.MaxDate == DateTime.Now)
            {
                //MessageBox.Show("Cannot Sync data more or equal to 90 days");
                output = true;
            }

            if (FirstReporterValue.Text.Length == 0)
            {
                output = false;
            }

            return output;

           
        }
    }
    
}
