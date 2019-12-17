using System;
using Dapper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Net;

namespace ClassLibrary1
{
    public class SQLConnector1 : IDataConnection1
    {
        //TODO - Make the create report methond actually 
        //save to the database
        /// <summary>
        /// saves a new report to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>

        public INTERREPORTMODEL1 CreateInterReport(INTERREPORTMODEL1 model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig1.CnnString("REPORTS")))
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
}
