using System;
using System.Collections.Generic;
using System.Text;

/*@id int = 0 output,


@Severity int,
@Details nvarchar(100),
@Solutions nvarchar(100),
@BugBehavior nvarchar(100),
@Comments nvarchar(100),
@FirstReported datetime2(7),
@FirstREPORTER nvarchar(50),
@Screenshot image,
@Date1 date
*/

namespace TRACKERLIBRARY.models
{
    public class REPORTMODEL
    {
        List<REPORTS> ReportTracker { get; set; } = new List<REPORTS>();
        public string ReportNames { get; set; }
        public int ID { get; set; }
        public int Severity { get; set; }
        public string ReportStatus { get; set; }
        public string UserName { get; set; }
        public string Comments { get; set; }
        public string Details { get; set; }
        public string BugBehavior { get; set; }
        public int DateTime { get; set; }
        public string Solutions { get; set; }
        public int FirstReported { get; set; }
        public string FirstREPORTER { get; set; }
        public string Screenshot { get; set; }


        public REPORTMODEL()
        {

        }
        
    }
    
}
