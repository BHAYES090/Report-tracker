using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary2
{
    public interface IDataConnection2
    {
        INTERREPORTMODEL2 CreateInterReport(INTERREPORTMODEL2 model);
        
        USERMODEL2 CreateUserAccount(USERMODEL2 model);
        REPORTMODEL2 CreateReport(REPORTMODEL2 model);
        //List<REPORTMODEL2> GetReport_All();

    }
}
