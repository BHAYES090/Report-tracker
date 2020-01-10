using RTDesktopUI.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTDesktopUI.Library.DataAndSQL
{
    public interface IDataConnection
    {
        ReportModel CreateReport(ReportModel m);
        
        //USERMODEL2 CreateUserAccount(USERMODEL2 model);
        //REPORTMODEL2 CreateReport(REPORTMODEL2 model);
        ////List<REPORTMODEL2> GetReport_All();
    }
}
