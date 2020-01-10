using Microsoft.AspNet.Identity;
using RTDataManager.Library.DataAccess;
using RTDataManager.Library.Models;
using System.Web.Http;

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
