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
	public class CreateReportViewModel : Conductor<object>
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
				var result = await _reportEndpoint.PostReport(UserNameEmailAddress, PhoneNumber, CommentBox, CreateDate);

				await _reportEndpoint.PostReport(result.CommentBox, result.PhoneNumber, result.UserNameEmailAddress, result.CreateDate);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}

