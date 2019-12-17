using System;
using System.Windows.Forms;
using TrackerLibrary2;
using System.Net.Mail;
using System.Net;
using System.Collections.Generic;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Media.Imaging;
using System.Drawing;
using System.Drawing.Imaging;
using System.Data;

namespace TRACKERUI
{

    public partial class CREATEREPORTFORM : Form
    {
        string fileName;
        public CREATEREPORTFORM()
        {
            InitializeComponent();
        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        public void Button1_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                INTERREPORTMODEL2 m = new INTERREPORTMODEL2();
                m.UserName = UserNameValue.Text;
                m.CommentBox = CommentBoxValue.Text;
                m.EmailAddress = EmailAddressValue.Text;
                m.PhoneNumber = phoneNumberValue.Text;
                m.CreateDate = CreateDateValue.Value;
                //m.ScreenShot = PictureBoxValue.;
               
                
                GlobalConfig2.Connection.CreateInterReport(m);

                phoneNumberValue.Text = "";
                EmailAddressValue.Text = "";
                UserNameValue.Text = "";
                CommentBoxValue.Text = "";
                CreateDateValue.Text = "";
               // PictureBoxValue.; = null;
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
            //int PhoneNumber = 0;
            // bool phoneNumberValidNumber = int.TryParse(phoneNumberValue.Text, out PhoneNumber);
            if (phoneNumberValue.Text.Length == 0)
            {
                output = false;
            }
            /*
            if (phoneNumberValue < 1)
            {
                output = false;
            }
            */
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
            //TODO - screenshot value configuration

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

        public void BrowseButton_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dlg = new OpenFileDialog() { Filter = "All Files (*.*)|*.*", ValidateNames = true, Multiselect = false })
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {

                    fileName = dlg.FileName;
                    lblFileName.Text = fileName;
                    PictureBoxValue.Image = Image.FromFile(fileName);
                }
            }
        }

        private void interReportTableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.interReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rEPORTSSQLDataSet);

        }

        private void interReportTableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.interReportTableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.rEPORTSSQLDataSet);

        }

        private void CREATEREPORTFORM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'rEPORTSSQLDataSet.InterReportTable' table. You can move, or remove it, as needed.
            this.interReportTableTableAdapter.Fill(this.rEPORTSSQLDataSet.InterReportTable);

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void UserNameValue_TextChanged(object sender, EventArgs e)
        {

        }
        /*
private void PictureBoxValue_Click(object sender, EventArgs e)
{
try
{
using (SqlConnection thisConnection = new SqlConnection(@"Data Source=" + 
System.Environment.MachineName +
"\\SQLEXPRESS;Initial Catalog=Image_Scanning;Integrated Security=SSPI "))
{
thisConnection.Open();
string query = "select pic from Image_tbl";// where Name='" + name + "'";
SqlCommand cmd = new SqlCommand(query, thisConnection);
byte[] image = (byte[])cmd.ExecuteScalar();
Image PictureBoxValue = byteArrayToImage(PictureBoxValue);
Picture.Image = PictureBoxValue;
//return image;
}
}
catch (Exception) { }
//return null;
byte[] imageBytes = byteArrayToImage(PictureBoxValue.Image);
}
public Image byteArrayToImage(byte[] byteArrayIn)
{

try
{
using (var ms = new MemoryStream(byteArrayIn))
{
return Image.FromStream(ms);
}
MemoryStream ms = new MemoryStream(byteArrayIn, 0, byteArrayIn.Length);
ms.Write(byteArrayIn, 0, byteArrayIn.Length);
returnImage = Image.FromStream(ms, true);//Exception occurs here
}
catch { }
return returnImage;
}
*/
    }
}
    

