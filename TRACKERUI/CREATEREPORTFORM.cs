using System;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using TRACKERLIBRARY.Models;
using TRACKERLIBRARY;
using TRACKERLIBRARY.DataAccess;

namespace TRACKERUI
{
    public partial class CREATEREPORTFORM : Form
    {
        public CREATEREPORTFORM()
        {
            InitializeComponent();
        }
        public void Button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                //    AT 5:31:10 HE MOUSES OVER model in his project 
                //    but when I run through, m appears null. 
                //    This is appears significant error and I must 
                //    work through it with whatever time I have left tommorrow. 


                INTERREPORTMODEL model = new INTERREPORTMODEL();
                model.UserName = UserNameValue.Text;
                model.CommentBox = CommentBoxValue.Text;
                model.EmailAddress = EmailAddressValue.Text;
                model.PhoneNumber = phoneNumberValue.Text;
                model.CreateDate = CreateDateValue.Value;

                GlobalConfig.Connection.CreateInterReport(model);

                phoneNumberValue.Text = "";
                EmailAddressValue.Text = "";
                UserNameValue.Text = "";
                CommentBoxValue.Text = "";
                CreateDateValue.Text = "";
            }

            else
            {
                MessageBox.Show("This form has invalid information. " +
                    "Please check your entries and try again");
            }
        }
        private bool ValidateForm()
        {
            bool output = true;
           
            if (phoneNumberValue.Text.Length == 0)
            {
                output = false;
            }
            if (UserNameValue.Text.Length == 0)
            {
                output = false;
            }

            if (EmailAddressValue.Text.Length == 0)
            {
                output = false;
            }

            if (CommentBoxValue.Text.Length == 0)
            {
                output = false;
            }
            if (CreateDateValue.MaxDate == DateTime.Now)
            {
                output = true;
            }
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
            return output;
        }
    }
}
    

