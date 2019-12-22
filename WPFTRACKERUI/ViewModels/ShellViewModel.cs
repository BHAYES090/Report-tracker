using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using RTDesktopUI.Library.EventModels;
using WPFTRACKERUI.Views;

namespace WPFTRACKERUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        //private SalesViewModel _salesVM;
        //private TESTReportViewModel _testReportVM;
        private CreateReportViewModel _createReportVM;
        

        public ShellViewModel(IEventAggregator events,
            //SalesViewModel salesVM)//,
            CreateReportViewModel createReportVM)
            //TESTReportViewModel testReportVM)
        {
            _events = events;
            //_salesVM = salesVM;
            _createReportVM = createReportVM;
            //_testReportVM = testReportVM;
           
            
            _events.Subscribe(this);

            
            ActivateItem(IoC.Get<LoginViewModel>());
        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(/*_salesVM_testReportVM */ _createReportVM);
        }
    }
}
