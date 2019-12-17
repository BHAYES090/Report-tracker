using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary2
{
    /*@Id int = 0 output,


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



    public class REPORTMODEL2
    {
        List<REPORTMODEL2> ReportTracker { get; set; } = new List<REPORTMODEL2>();
        public string ReportName { get; set; }
        public string ReportID { get; set; }
        public string Severity { get; set; }
        public string ReportStatus { get; set; }
        //public string UserName { get; set; }
        public string Comments { get; set; }
        public string Details { get; set; }
        public string BugBehavior { get; set; }
        //public int DateTime { get; set; }
        public string Solutions { get; set; }

        public DateTime FirstReported { get; set; }
        public string FirstREPORTER { get; set; }
        //public string Screenshot { get; set; }
        public int id { get; set; } 
    }
 }
    
