using RTDataManager.Library.Internal.DataAccess;
using System.Collections.Generic;
using ReportModel = RTDataManager.Library.Models.ReportModel;

namespace RTDataManager.Library.DataAccess
{
    public class ReportData
    {
        public void SaveReport(ReportModel report, string userId)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("dbo.spInterReport_Post", report, "REPORTSDATASQL");
        }
    }
}
