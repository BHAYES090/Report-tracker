using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using RTDesktopUI.Library.Configuration;
using RTDesktopUI.Library.DataAndSQL;
using RTDesktopUI.Library.Models;

namespace RTDesktopUI.Library.DataAndSQL
{
    public class SQLConnector : IDataConnection
    {
        public ReportModel CreateReport(ReportModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection
                (GlobalConfig.CnnString("REPORTSDATASQL")))
            {
                var P = new DynamicParameters();
                P.Add("UserNameEmailAddress", model.UserNameEmailAddress); ;
                P.Add("PhoneNumber", model.PhoneNumber);
                P.Add("CommentBox", model.CommentBox);
                P.Add("CreateDate", model.CreateDate);
                P.Add("Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spInterReport_Post", P, commandType: CommandType.StoredProcedure);
                
                //model.Id = P.Get<int>("@Id");

                return model;
            }
        }
        //public ReportModel CreateReport(ReportModel model)
        //{
        //    
        //}
        //public void SaveReport(RTDesktopUI.Library.Models.ReportModel report)
        //{
        //    SqlDataAccess sql = new SqlDataAccess();

        //    sql.SaveData("dbo.spInterReport_Post", report, "REPORTSDATASQL");
        //}
        //public USERMODEL2 CreateUserAccount(USERMODEL2 model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig2.CnnString("REPORTSSQL")))
        //    {
        //        var P = new DynamicParameters();
        //        P.Add("FirstName", model.FirstName);
        //        P.Add("LastName", model.LastName);
        //        P.Add("PhoneNumber", model.PhoneNumber);
        //        P.Add("UserName", model.UserName);
        //        P.Add("EmailAddress", model.EmailAddress);
        //        P.Add("Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //        connection.Execute("dbo.spUsersTable_Insert", P, commandType: CommandType.StoredProcedure);

        //        model.Id = P.Get<int>("@Id");

        //        return model;
        //    }
        //}
        //public REPORTMODEL2 CreateReport(REPORTMODEL2 model)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig2.CnnString("REPORTSSQL")))
        //    {
        //        var P = new DynamicParameters();
        //        P.Add("ReportName", model.ReportName);
        //        P.Add("ReportID", model.ReportID);
        //        P.Add("Severity", model.Severity);
        //        P.Add("ReportStatus", model.ReportStatus);
        //        P.Add("Comments", model.Comments);
        //        P.Add("Details", model.Details);
        //        P.Add("BugBehavior", model.BugBehavior);
        //        P.Add("Solutions", model.Solutions);
        //        P.Add("FirstReported", model.FirstReported);
        //        P.Add("FirstReporter", model.FirstREPORTER);
        //        P.Add("Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

        //        connection.Execute("dbo.spReportTable_Insert", P, commandType: CommandType.StoredProcedure);

        //        model.id = P.Get<int>("@Id");

        //        return model;
        //    }
        //}
    }
}

