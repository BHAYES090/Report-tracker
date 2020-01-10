using System;
using System.Windows.Forms;
using TRACKERLIBRARY;
using TRACKERLIBRARY.models;

namespace TRACKERUI
{
    public partial class CREATEUSERACCOUNT : Form
    {
        public CREATEUSERACCOUNT()
        {
            InitializeComponent();
        }
        
        private void CREATEUSERACCOUNT_Load(object sender, EventArgs e)
        {

        }
        
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        

        private void Button1CreateUSER_Click(object sender, EventArgs e)
        {     
            //if (ValidateForm())
            //{
            //    USERMODEL u = new USERMODEL();
            //    u.FirstName = FirstNameValue.Text;
            //    u.LastName = LastNameValue.Text;
            //    u.UserName = UserNameValue.Text;
            //    u.EmailAddress = EmailAddressValue.Text;
            //    u.PhoneNumber = PhoneNumberValue.Text;

            //     GlobalConfig.Connection.CreateUserAccount(u);

            //    FirstNameValue.Text = "";
            //    LastNameValue.Text = "";
            //    UserNameValue.Text = "";
            //    EmailAddressValue.Text = "";
            //    PhoneNumberValue.Text = "";
            //}
            //else
            //{
            //    MessageBox.Show("You have entered something inncorrectly, " +
            //        "please try again");
            //}
            
        }
        private bool ValidateForm()
        {
            if (FirstNameValue.Text.Length == 0)
            {
                return false;
            }
            if (LastNameValue.Text.Length == 0)
            {
                return false;
            }
            if (UserNameValue.Text.Length == 0)
            {
                return false;
            }
            if (EmailAddressValue.Text.Length == 0)
            {
                return false;
            }
            if (PhoneNumberValue.Text.Length == 0)
            {
                return false;
            }
            return true;
        }
    }
}
