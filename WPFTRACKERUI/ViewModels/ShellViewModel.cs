using Caliburn.Micro;
using RTDesktopUI.Library.EventModels;

namespace WPFTRACKERUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private CreateReportViewModel _createReportVM;
        private ReportDashboardViewModel _testReportVM;
        
        

        public ShellViewModel(IEventAggregator events,
            CreateReportViewModel createReportVM,
            ReportDashboardViewModel testReportVM)
        {
            _events = events;
            _createReportVM = createReportVM;
            _testReportVM = testReportVM;
           
            _events.Subscribe(this);

            ActivateItem(IoC.Get<LoginViewModel>());
        }
        public void Handle(LogOnEvent message)
        {
            ActivateItem(_createReportVM);
            ActivateItem(_testReportVM );
        }
    }
}
