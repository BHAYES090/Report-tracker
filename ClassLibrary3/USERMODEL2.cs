using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary2
{
    public class USERMODEL2
    {
        List<USERMODEL2> ReportTracker { get; set; } = new List<USERMODEL2>();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int Id { get; set; }
    }
}
