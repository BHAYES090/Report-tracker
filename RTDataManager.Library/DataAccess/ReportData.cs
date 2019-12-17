using RTDataManager.Library.Internal.DataAccess;
using RTDataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RTDesktopUI.Library.Models;

namespace RTDataManager.Library.DataAccess
{
    public class ReportData
    {
        public void SaveReport(RTDesktopUI.Library.Models.ReportModel report)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("dbo.spInterReport_Post", report, "REPORTSDATASQL");
        }
        //public List<ReportModel> GetReport()
        //{
        //    SqlDataAccess sql = new SqlDataAccess();

        //    var output = sql.LoadData<ReportModel, dynamic>("dbo.spInterReport_Post", new { }, "REPORTSDATASQL");

        //    return output;
        //}
    }
}
