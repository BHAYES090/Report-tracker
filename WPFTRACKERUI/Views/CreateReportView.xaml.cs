using System.Windows.Controls;
using System.Net.Mail;
using System.Net;

namespace WPFTRACKERUI.Views
{
    public partial class CreateReportView : UserControl
    {
        public CreateReportView()
        {
            InitializeComponent();
        }
        private void CreateReport_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress("ReportTracker@outlook.com");
                mail.To.Add("ReportTracker@outlook.com");
                mail.Subject = "New Report";
                mail.Body = "A user has updated the database: REPORTSSQL with a new Report. " +
                    "Please check the database for new Reports";
                mail.IsBodyHtml = false;

                using (SmtpClient smtp = new SmtpClient("smtp-mail.outlook.com", 587))
                {
                    smtp.Credentials = new NetworkCredential("ReportTracker@outlook.com", "pxjqllkhkjgdakeu");
                    smtp.EnableSsl = true;
                    smtp.Send(mail);
                }
            }
        }
    }
}
