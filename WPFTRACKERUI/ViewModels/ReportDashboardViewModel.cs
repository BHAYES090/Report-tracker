using Caliburn.Micro;
using System.Windows.Input;
using WPFTRACKERUI.Views;

namespace WPFTRACKERUI.ViewModels
{
    public class ReportDashboardViewModel : Screen
    {
		public ICommand Search;
		private string _keywordSearch;
		private string _dateTimePicker;
		private string _reportId;
		private CreateReportView _createReportView;

		public CreateReportView CreateReportView
		{
			get { return _createReportView; }
			set 
			{
				_createReportView = value;
				NotifyOfPropertyChange(() => CreateReportView);
			}
		}

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
		public string ReportId
		{
			get { return _reportId; }
			set
			{
				_reportId = value;
				NotifyOfPropertyChange(() => ReportId);
			}
		}
		public static void ReportSearch()
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
	}
}
