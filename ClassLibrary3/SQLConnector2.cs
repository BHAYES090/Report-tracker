using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary3;
using ClassLibrary3.TextHelpers;
using Dapper;


namespace TrackerLibrary2
{
    public class SQLConnector2 : IDataConnection2
    {
        //TODO - Make the create report method actually 
        //save to the database
        /// <summary>
        /// saves a new report to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        /// 
        
        
        public INTERREPORTMODEL2 CreateInterReport(INTERREPORTMODEL2 model)
        {
            

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig2.CnnString("REPORTSSQL")))
            {
                
                var P = new DynamicParameters();
                P.Add("UserName", model.UserName);
                P.Add("EmailAddress", model.EmailAddress);
                P.Add("PhoneNumber", model.PhoneNumber);
                P.Add("CommentBox", model.CommentBox);
                P.Add("CreateDate", model.CreateDate);
                P.Add("ScreenShot", model.ScreenShot);
                P.Add("Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                model.ScreenShot = P.Get<byte[]>("@ScreenShot");
                
                connection.Execute("dbo.spInterReportTable_Insert1", P, commandType: CommandType.StoredProcedure);
                
                model.Id = P.Get<int>("@Id");

                return model;
            }
        }

        public USERMODEL2 CreateUserAccount(USERMODEL2 model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig2.CnnString("REPORTSSQL")))
            {
                var P = new DynamicParameters();
                P.Add("FirstName", model.FirstName);
                P.Add("LastName", model.LastName);
                P.Add("PhoneNumber", model.PhoneNumber);
                P.Add("UserName", model.UserName);
                P.Add("EmailAddress", model.EmailAddress);
                P.Add("Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spUsersTable_Insert", P, commandType: CommandType.StoredProcedure);

                model.Id = P.Get<int>("@Id");

                return model;
            }
        }
        public REPORTMODEL2 CreateReport(REPORTMODEL2 model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig2.CnnString("REPORTSSQL")))
            {
                var P = new DynamicParameters();
                P.Add("ReportName", model.ReportName);
                P.Add("ReportID", model.ReportID);
                P.Add("Severity", model.Severity);
                P.Add("ReportStatus", model.ReportStatus);
                P.Add("Comments", model.Comments);
                P.Add("Details", model.Details);
                P.Add("BugBehavior", model.BugBehavior);
                P.Add("Solutions", model.Solutions);
                P.Add("FirstReported", model.FirstReported);
                P.Add("FirstReporter", model.FirstREPORTER);
                P.Add("Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spReportTable_Insert", P, commandType: CommandType.StoredProcedure);

                model.id = P.Get<int>("@Id");

                return model;
            }
        }
    }
}

