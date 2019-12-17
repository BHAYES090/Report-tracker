using RTDataManager.Library.DataAccess;
using RTDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Windows.Forms;
using RTDesktopUI.Library.Models;

namespace DataManager1.Controllers
{
    [Authorize]
    public class ReportController : ApiController
    {
        public void Post(RTDesktopUI.Library.Models.ReportModel report)
        {
            ReportData data = new ReportData();
            data.SaveReport(report);
        }
    }
}
