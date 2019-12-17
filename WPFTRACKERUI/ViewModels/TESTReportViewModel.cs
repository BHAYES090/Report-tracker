using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPFTRACKERUI.Views;

namespace WPFTRACKERUI.ViewModels
{
    public class TESTReportViewModel : Screen
    {
		private string _keywordSearch;
		private string _dateTimePicker;
		private string _reportId;

		public string KeywordSearch
		{
			get { return _keywordSearch; }
			set
			{
				_keywordSearch = value;
				NotifyOfPropertyChange(() => KeywordSearch);
			}
		}
		public string DateTimePicker
		{
			get { return _dateTimePicker; }
			set
			{
				_dateTimePicker = value;
				NotifyOfPropertyChange(() => DateTimePicker);
			}
		}
		/// <summary>
		/// the below statement can be tossed out, it simply servers the purpose of not greying out the 
		/// Creat Report Box. 
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		//public void CreateButtonClicked(object sender, RoutedEventArgs e)
		//{
		//	CreateReportView subWindow = new CreateReportView();
		//	var host = new Window();
		//	host.Content = subWindow;
		//	host.Show();
		//}
		public string ReportId
		{
			get { return _reportId; }
			set
			{
				_reportId = value;
				NotifyOfPropertyChange(() => ReportId);
			}
		}
		public void ReportSearch()
		{

		}
		public bool CanReportSearch
		{
			get
			{
				bool output = false;

				//Make sure something is selected 
				//make sure there is an item quantity

				return output;
			}
		}

		public void CreateReport_Click(object sender, RoutedEventArgs e)
		{
			CreateReportView subWindow = new CreateReportView();
			var host = new Window();
			host.Content = subWindow;
			host.Show();
		}

		//public bool CanCreateReport
		//{

			
		//}
	}
}
