using Caliburn.Micro;

namespace WPFTRACKERUI.ViewModels
{
    public class ReportPageViewModel : Screen
    {
        private string _dateLabel;
        private string _emailLabel;
        private string _phoneNumberLabel;
        private string _commentsLabel;
        public string DateLabel
        {
            get { return _dateLabel; }
            set
            {
                _dateLabel = value;
                NotifyOfPropertyChange(() => DateLabel);
            }
        }
        public string EmailLabel
        {
            get { return _emailLabel; }
            set
            {
                _emailLabel = value;
                NotifyOfPropertyChange(() => EmailLabel);
            }
        }
        public string PhoneNumberLabel
        {
            get { return _phoneNumberLabel; }
            set
            {
                _phoneNumberLabel = value;
                NotifyOfPropertyChange(() => PhoneNumberLabel);
            }
        }
        public string CommentsLabel
        {
            get { return _commentsLabel; }
            set
            {
                _commentsLabel = value;
                NotifyOfPropertyChange(() => CommentsLabel);
            }
        }
    }
}
