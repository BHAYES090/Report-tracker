using Caliburn.Micro;
using RTDesktopUI.Library.DataAndSQL;
using RTDesktopUI.Library.Configuration;
using RTDesktopUI.Library.Models;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace WPFTRACKERUI.Views
{
    public partial class CreateReportView : UserControl
    {
        public CreateReportView()
        {
            InitializeComponent();
        }
        public void CreateReport_Click(object sender, EventArgs e)
        {

            if (ValidateForm())
            {
                ReportModel m = new ReportModel();

                m.UserNameEmailAddress = UserNameEmailAddressValue.Text;
                m.CommentBox = CommentBoxValue.Text;
                m.PhoneNumber = PhoneNumberValue.Text;
                m.CreateDate = CreateDateValue.DisplayDate;
                //ReportModel m = new ReportModel();

                if (m.GetType() == typeof(ReportModel))
                {
                    GlobalConfig.Connection.CreateReport(m);
                    //GlobalConfig.Connection.CreateReport(m);
                }

                //Console.WriteLine(m.returnValues());

                PhoneNumberValue.Text = "";
                UserNameEmailAddressValue.Text = "";
                CommentBoxValue.Text = "";
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

            if (PhoneNumberValue?.Text.Length == 0)
            {
                output = false;
            }

            if (UserNameEmailAddressValue?.Text.Length == 0)
            {
                output = false;
            }

            if (CommentBoxValue?.Text.Length == 0)
            {
                output = false;
            }
            if (CreateDateValue?.SelectedDate == DateTime.Now)
            {
                output = true;
            }
            return output;
        }
    }
}
