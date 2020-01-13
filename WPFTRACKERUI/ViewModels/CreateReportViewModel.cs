using Caliburn.Micro;
using RTDesktopUI.Library.API;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WPFTRACKERUI.ViewModels
{
    public class CreateReportViewModel : Screen
    {
        readonly IReportEndpoint _reportEndpoint;

        public CreateReportViewModel(IReportEndpoint reportEndpoint)
        {
            _reportEndpoint = reportEndpoint;
        }
        private DateTime _createDate;
        private string _userNameEmailAddress;
        private string _phoneNumber;
        private string _commentBox;
        public DateTime CreateDate
        {
            get { return _createDate; }
            set
            {
                _createDate = DateTime.Now;
                NotifyOfPropertyChange(() => CreateDate);
            }
        }
        public string UserNameEmailAddress
        {
            get { return _userNameEmailAddress; }
            set
            {
                _userNameEmailAddress = value;
                NotifyOfPropertyChange(() => UserNameEmailAddress);
            }
        }
        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                _phoneNumber = value;
                NotifyOfPropertyChange(() => PhoneNumber);
            }
        }
        public string CommentBox
        {
            get { return _commentBox; }
            set
            {
                _commentBox = value;
                NotifyOfPropertyChange(() => CommentBox);
            }
        }
        public async Task CreateReport(string CreateDate, string UserNameEmailAddress, string PhoneNumber, string CommentBox)
        {
            await _reportEndpoint.PostReport(CreateDate, UserNameEmailAddress, PhoneNumber, CommentBox);

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
            ClearReport();
        }
        private void ClearReport()
        {
            UserNameEmailAddress = "";
            PhoneNumber = "";
            CommentBox = "";
        }
    }
}