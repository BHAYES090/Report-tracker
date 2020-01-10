using Caliburn.Micro;
using RTDesktopUI.Library.API;
using RTDesktopUI.Library.Helpers;
using RTDesktopUI.Library.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
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
        private DateTime _createDate;
        private string _userNameEmailAddress;
        private string _phoneNumber;
        private string _commentBox;
        //private BindableCollection<ReportDetailModel> _reports = new BindableCollection<ReportDetailModel>();
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
        public async Task CreateReport()
        {
            try
            {

                ReportModel report = new ReportModel();
                var result = await _reportEndpoint.PostReport(UserNameEmailAddress, CommentBox, PhoneNumber, CreateDate);

                await _reportEndpoint.PostReport(result.UserNameEmailAddress, result.CommentBox, result.PhoneNumber, result.CreateDate);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
//using Caliburn.Micro;
//using RTDesktopUI.Library.Configuration;
//using RTDesktopUI.Library.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows;
//using System.Windows.Controls;
//using System.Windows.Data;
//using System.Windows.Documents;
//using System.Windows.Input;
//using System.Windows.Media;
//using System.Windows.Media.Imaging;
//using System.Windows.Navigation;
//using System.Windows.Shapes;

//namespace WPFTRACKERUI.ViewModels
//{
//    public class CreateReportViewModel : Screen
//    {
//    / <summary>
//    / Interaction logic for CreateReportView.xaml
//    / </summary>
//    public class CreateReportViewModel : Screen
//        {
//            public CreateReportViewModel()
//            {
//                InitializeComponent();
//            }
//            private DateTime _createDate;
//            private string _userNameEmailAddress;
//            private string _phoneNumber;
//            private string _commentBox;
//            private BindableCollection<ReportDetailModel> _reports = new BindableCollection<ReportDetailModel>();
//            public DateTime CreateDate
//            {
//                get { return _createDate; }
//                set
//                {
//                    _createDate = DateTime.Now;
//                    NotifyOfPropertyChange(() => CreateDate);
//                }
//            }

//            public string UserNameEmailAddress
//            {
//                get { return _userNameEmailAddress; }
//                set
//                {
//                    _userNameEmailAddress = value;
//                    NotifyOfPropertyChange(() => UserNameEmailAddress);
//                }
//            }


//            public string PhoneNumber
//            {
//                get { return _phoneNumber; }
//                set
//                {
//                    _phoneNumber = value;
//                    NotifyOfPropertyChange(() => PhoneNumber);
//                }
//            }


//            public string CommentBox
//            {
//                get { return _commentBox; }
//                set
//                {
//                    _commentBox = value;
//                    NotifyOfPropertyChange(() => CommentBox);
//                }
//            }
//            public void CreateReport(object sender, RoutedEventArgs e)
//            {
//                if (ValidateForm())
//                {
//                    ReportModel m = new ReportModel();
//                    m.UserNameEmailAddress = UserNameEmailAddressValue.Text;
//                    m.CommentBox = CommentBoxValue.Text;
//                    m.PhoneNumber = PhoneNumberValue.Text;
//                    m.CreateDate = CreateDate;


//                    GlobalConfig.Connection.CreateReport(m);

//                    PhoneNumber = "";
//                    UserNameEmailAddress = "";
//                    CommentBox = "";
//                }

//                else
//                {
//                    MessageBox.Show("This form has invalid information. " +
//                        "Please check your entries and try again");
//                }
//            }
//            private bool ValidateForm()
//            {
//                bool output = true;

//                if (PhoneNumber.Length == 0)
//                {
//                    output = false;
//                }

//                if (UserNameEmailAddress.Length == 0)
//                {
//                    output = false;
//                }

//                if (CommentBox.Length == 0)
//                {
//                    output = false;
//                }
//                if (CreateDate == DateTime.Now)
//                {
//                    output = true;
//                }
//                return output;
//            }
//        }
//    }

