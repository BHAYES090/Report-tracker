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
using ReportModel = RTDataManager.Library.Models.ReportModel;
using Microsoft.AspNet.Identity;

namespace DataManager1.Controllers
{
    [Authorize]
    public class ReportController : ApiController
    {
        public void Post(ReportModel report)
        {
            ReportData data = new ReportData();
            string userId = RequestContext.Principal.Identity.GetUserId();
            data.SaveReport(report, userId);
        }
    }
}
