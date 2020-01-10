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
        private string _createDate;
        private string _userNameEmailAddress;
        private string _phoneNumber;
        private string _commentBox;
        //private BindableCollection<ReportDetailModel> _reports = new BindableCollection<ReportDetailModel>();
        public string CreateDate
        {
            get { return _createDate; }
            set
            {
                _createDate = DateTime.Now.ToString("MM dd yyyy");
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
            ReportModel model = new ReportModel(
            CreateDate = CreateDate,
            UserNameEmailAddress = UserNameEmailAddress,
            PhoneNumber = PhoneNumber,
            CommentBox = CommentBox);

            await _reportEndpoint.PostReport(CreateDate, UserNameEmailAddress, PhoneNumber, CommentBox);
            try
            {
                await _reportEndpoint.PostReport(model.CreateDate, model.UserNameEmailAddress, model.PhoneNumber, model.CommentBox);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

