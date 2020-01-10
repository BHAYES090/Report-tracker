using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using TRACKERLIBRARY.models;
using TRACKERLIBRARY.Models;
using System.Net;


namespace TRACKERLIBRARY.DataAccess
{
    public class SQLConnector : IDataConnection
    { 
        //TODO - Make the create report methond actually 
        //save to the database
        /// <summary>
        /// saves a new report to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        
        public INTERREPORTMODEL CreateInterReport(INTERREPORTMODEL model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("REPORTS")))
            {
                var P = new DynamicParameters();
                P.Add("UserName", model.UserName);
                P.Add("EmailAddress", model.EmailAddress);
                P.Add("PhoneNumber", model.PhoneNumber);
                P.Add("Comments", model.CommentBox);
                P.Add("Date", model.CreateDate);
                P.Add("id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spInterReportTable_Insert", P, commandType: CommandType.StoredProcedure);

                model.id = P.Get<int>("@id");

                return model;
            }
        }
    }
}
