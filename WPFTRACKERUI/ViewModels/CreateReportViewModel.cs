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
        IReportEndpoint _reportEndpoint;

        public CreateReportViewModel(IReportEndpoint reportEndpoint)
        {
            _reportEndpoint = reportEndpoint;
        }
        private string _createDate;
        private string _userNameEmailAddress;
        private string _phoneNumber;
        private string _commentBox;
        public string CreateDate
        {
            get { return _createDate; }
            set
            {
                _createDate = DateTime.UtcNow.ToString("Day: {0:d} { 0:HH: mm: ss tt}");
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
/// <summary>
/// Well, this has been a very interesting time; figuring out this issue. I'm not sure if I feel comfortable 
/// with this result. Perhaps Ken Burns' Vietnam documentary on netflix has some how clouded my 
/// sense of victory and achievement. I feel like I can possibly move on from this topic.
/// A lot of devs have these crazy UI 
/// designs and I think I should figure out how to spruce up the xaml. 
/// Pat on the back my guy you did it, just a couple more tweeks away from a fully functioning application. 
/// </summary>
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