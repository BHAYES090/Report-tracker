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
                P.Add("CreateDate", model.CreateDate);
                P.Add("UserNameEmailAddress", model.UserNameEmailAddress); ;
                P.Add("PhoneNumber", model.PhoneNumber);
                P.Add("CommentBox", model.CommentBox);
                P.Add("Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                
                connection.Execute("dbo.spInterReport_Post", P, commandType: CommandType.StoredProcedure);
                
                //model.Id = P.Get<int>("@Id");

                return model;
            }
        }
    }
}

